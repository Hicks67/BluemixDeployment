using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BluemixDeployment
{
    class NLC : BaseRESTServices
    {

        public NLC(ServiceKeys key,dynamic json) : base(key)
        {
            classes = new Dictionary<string, double>();
            Load(json);            
        }

        public NLC(ServiceKeys key) :base(key)
        {
            classes = new Dictionary<string, double>();
        }

        public string classifier_id { get; set; } 
        public string url { get; set; } 
        public string name { get; set; } 
        public string status { get; set; } 

        public string status_description { get; set; }

        public string created { get; set; }

        public string language { get; set; }

        public string top_class { get; set; }
         
        public Dictionary<string, double> classes { get; set; }

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
            classifier_id = json.classifier_id;
            name = json.name;
            language = json.language;
            url = json.url;
            status = json.status;
            status_description = json.status_description;
            created = json.created;
            top_class = json.top_class;

            classes.Clear();
            var classe = (JArray)json.classes;
            if (null != classe)
            {
                foreach (dynamic elem in classe)
                {
                    classes.Add((string)elem.class_name, (double)elem.confidence);
                }
            }
            _json = json.ToString();
        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("language", language)
                );

            return rss.ToString();
        }

        public void Create(string sName, string sLanguage, string sFileName)        
        {
            name = sName;
            language = sLanguage;

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

            

            //formDataStream.Write(encoding.GetBytes(postData), 0, encoding.GetByteCount(postData));            
            // Add the end of the request.  Start with a newline
            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/classifiers", "POST", _oMemoryStream.ToArray(), 0, "multipart/form-data; boundary=" + sBoundary, _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();
        }

        public void Get()
        {
            if (!String.IsNullOrEmpty(classifier_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/classifiers/" + classifier_id, "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(classifier_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/classifiers/" + classifier_id, "DELETE", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Classify(string sText)
        {
            if (!String.IsNullOrEmpty(classifier_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/classifiers/" + classifier_id + "/classify?text=" + Uri.EscapeUriString(sText), "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                Load(ret._json);
            }
        }

        public XmlDocument Classify(ServiceKeys key, string sUrl, string sText)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(sUrl+ "/classify?text=" + sText, "GET", null, 0, "application/json", key.cred_username, key.cred_password, null);           
            Load(ret._json);

            //Dictionary<string, double> d = new Dictionary<string, double>();
            XmlDocument oXml = new XmlDocument();
            XmlNode root = oXml.CreateNode(XmlNodeType.Element, "classes", null);
            XmlNode NodeC = null, NodeV = null, NodeT = null;
            NodeT = oXml.CreateNode(XmlNodeType.Attribute, "q", null);
            NodeT.Value = sText;
            root.Attributes.SetNamedItem(NodeT);
            
            //root.AppendChild(NodeT);

            var classe = (JArray)ret._json.classes;
            foreach (dynamic elem in classe)
            {
                NodeC = oXml.CreateNode(XmlNodeType.Element, "class", null);
                NodeV = oXml.CreateNode(XmlNodeType.Attribute, "name", null);
                NodeV.Value = elem.class_name.ToString();
                NodeC.Attributes.SetNamedItem(NodeV);

                NodeV = oXml.CreateNode(XmlNodeType.Attribute, "value", null);
                NodeV.Value = elem.confidence.ToString();
                NodeC.Attributes.SetNamedItem(NodeV);
                root.AppendChild(NodeC);                
                //d[elem.class_name.ToString()] = elem.confidence;
            }
            oXml.AppendChild(root);
            return oXml;
        }

        public List<NLC> GetList()
        {

            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/classifiers", "GET", null, 0, "application/json", _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();

            List<NLC> LstNLC = new List<NLC>();

            var classifiers = (JArray)ret._json.classifiers;
            foreach (var elem in classifiers)
            {                
                NLC Tmp = new NLC(_SK,elem);
                LstNLC.Add(Tmp);
            }           

            return LstNLC;
        }


    }
}
