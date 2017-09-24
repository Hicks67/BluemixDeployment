using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BluemixDeployment
{
    class Dialog : BaseRESTServices
    {

        public Dialog(ServiceKeys key, dynamic json) : base(key)
        {
            //classes = new Dictionary<string, double>();
            Load(json);
        }

        public Dialog(ServiceKeys key) :base(key)
        {
            //classes = new Dictionary<string, double>();
        }

        public string dialog_id { get; set; }
        public string name { get; set; }
        public string conversation_id { get; set; }
        public string confidence { get; set; }
        public string client_id { get; set; }
       
        public void Load(dynamic json)
        {
            dialog_id = json.dialog_id ?? dialog_id;
            name = json.name ?? name;
            conversation_id = json.conversation_id;
            confidence = json.confidence;
            client_id = json.client_id;
                      
            _json = json.ToString();
        }

        /*public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("language", language)
                );

            return rss.ToString();
        }*/

        public void Create(string sName, string sFileName)
        {
            name = sName;            

            string sBoundary = "----xxxxxxxxxx----";
            string sHeaderFormData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"\r\n\r\n", sBoundary);
            string sHeaderFormMetaData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"name\"\r\n\r\n", sBoundary);

            byte[] HeaderFormData = Encoding.UTF8.GetBytes(sHeaderFormData);
            byte[] HeaderFormMetaData = Encoding.UTF8.GetBytes(sHeaderFormMetaData);
            byte[] Footer = Encoding.UTF8.GetBytes("\r\n--" + sBoundary + "--\r\n");
            byte[] Data = File.ReadAllBytes(sFileName);
            byte[] Sep = Encoding.UTF8.GetBytes("\r\n");
            byte[] Name = Encoding.UTF8.GetBytes(sName);

            MemoryStream _oMemoryStream = new MemoryStream();
            _oMemoryStream.Write(HeaderFormData, 0, HeaderFormData.Length);
            _oMemoryStream.Write(Data, 0, Data.Length);
            _oMemoryStream.Write(Sep, 0, Sep.Length);
            _oMemoryStream.Write(HeaderFormMetaData, 0, HeaderFormMetaData.Length);
            _oMemoryStream.Write(Name, 0, Name.Length);
            _oMemoryStream.Write(Footer, 0, Footer.Length);
            _oMemoryStream.Position = 0;

            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs", "POST", _oMemoryStream.ToArray(), 0, "multipart/form-data; boundary=" + sBoundary, _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();
        }

        public void Update(string sFileName)
        {
            if (!String.IsNullOrEmpty(dialog_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs/" + dialog_id, "PUT", File.ReadAllBytes(sFileName), 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(dialog_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs/" + dialog_id, "DELETE", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Converse(string sText)
        {
            if (!String.IsNullOrEmpty(dialog_id))
            {
                string sData = "input="+ Uri.EscapeUriString(sText);
                if (null != conversation_id)
                    sData += "&conversation_id=" + conversation_id;

                if (null != client_id)
                    sData += "&client_id=" + client_id;

                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs/" + dialog_id + "/conversation", "POST", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                Load(ret._json);
            }
        }
            

        public List<Dialog> GetList()
        {

            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs", "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();

            List<Dialog> LstDialog = new List<Dialog>();

            var dialogs = (JArray)ret._json.dialogs;
            foreach (var elem in dialogs)
            {
                Dialog Tmp = new Dialog(_SK, elem);
                LstDialog.Add(Tmp);
            }

            return LstDialog;
        }


    }
}
