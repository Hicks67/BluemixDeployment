using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BluemixDeployment
{
    class RnRRanker : BaseRESTServices
    {
        public RnRRanker(ServiceKeys SK, dynamic json) : base(SK)
        {
            Load(json);
        }

        public RnRRanker(ServiceKeys SK) : base(SK)
        {
        }
        public string ranker_id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string status_description { get; set; }
        public string created { get; set; }
                
        //public Dictionary<string, double> classes { get; set; }
        /*{
              "classifier_id": "10D41B-nlc-1",
              "name": "My Classifier",
              "language": "en"
              "created": "2015-05-28T18:01:57.393Z",
              "url": "https://gateway.watsonplatform.net/natural-language-classifier/api/v1/classifiers/10D41B-nlc-1",
              "status": "Training",
              "status_description": "The classifier instance is in its training phase, not yet ready to accept classify requests"
            }
        */
        public void Load(dynamic json)
        {
            ranker_id = json.ranker_id;
            name = json.name;           
            url = json.url;
            status = json.status;
            status_description = json.status_description;
            created = json.created;
           
            _json = json.ToString();
        }

        public string GetJson()
        {
            JObject rss = new JObject(new JProperty("name", name));
            return rss.ToString();
        }

        public void Create(string sName, string sFileName)
        {
            name = sName;

            string sBoundary = "----xxxxxxxxxx----";
            string sHeaderFormData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"training_data\"\r\n\r\n", sBoundary);
            string sHeaderFormMetaData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"training_metadata\"\r\n\r\n", sBoundary);

            byte[] HeaderFormData = Encoding.UTF8.GetBytes(sHeaderFormData);
            byte[] HeaderFormMetaData = Encoding.UTF8.GetBytes(sHeaderFormMetaData);
            byte[] Footer = Encoding.UTF8.GetBytes("\r\n--" + sBoundary + "--\r\n");
            byte[] Data = File.ReadAllBytes(sFileName);
            byte[] Sep = Encoding.UTF8.GetBytes("\r\n");
            byte[] Json = Encoding.UTF8.GetBytes(GetJson());

            MemoryStream _oMemoryStream = new MemoryStream();
            _oMemoryStream.Write(HeaderFormData, 0, HeaderFormData.Length);
            _oMemoryStream.Write(Data, 0, Data.Length);
            _oMemoryStream.Write(Sep, 0, Sep.Length);
            _oMemoryStream.Write(HeaderFormMetaData, 0, HeaderFormMetaData.Length);
            _oMemoryStream.Write(Json, 0, Json.Length);
            _oMemoryStream.Write(Footer, 0, Footer.Length);
            _oMemoryStream.Position = 0;

            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/rankers", "POST", _oMemoryStream.ToArray(), 0, "multipart/form-data; boundary=" + sBoundary, _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(ranker_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/rankers/" + ranker_id, "DELETE", null, 0, null, _SK.cred_username, _SK.cred_password, null);
            }
        }

        public List<RnRRanker> GetList()
        {
            List<RnRRanker> LstRankers = null;
            
            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/rankers", "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();

            LstRankers = new List<RnRRanker>();

            var rankers = (JArray)ret._json.rankers;
            foreach (var elem in rankers)
            {
                LstRankers.Add(new RnRRanker(_SK,elem));
            }         

            return LstRankers;

        }       
    }
}
