﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;


namespace BluemixDeployment
{
    class WCSDialogNodes : BaseRESTServices
    {
        string sVersionDefault = "2017-05-26";


        public WCSDialogNodes(ServiceKeys key, dynamic json) : base(key)
        {
            Load(json);
        }
        public WCSDialogNodes(ServiceKeys key, string sVersion = null) : base(key)
        {
        }

        public string version { get; set; }

        public string workspace_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public string language { get; set; }
        public string runtime_version { get; set; }

        public string status { get; set; }

        public bool learning_opt_out { get; set; }

        public void Load(dynamic json)
        {

            workspace_id = json.workspace_id ?? workspace_id;
            name = json.name ?? name;
            description = json.description;
            created = json.created;
            updated = json.updated;
            language = json.language;
            runtime_version = json.metadata != null ? json.metadata.runtime_version : null;
            learning_opt_out = json.learning_opt_out;
            status = json.status;

            _json = json.ToString();
        }

        public List<WCSWorkspace> GetList()
        {
            string next_url = "/v1/workspaces?version=" + (version == null ? sVersionDefault : version);
            List<WCSWorkspace> LstWork = new List<WCSWorkspace>();

            while (!string.IsNullOrEmpty(next_url))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + next_url, "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json += ret._json.ToString();

                var workspaces = (JArray)ret._json.workspaces;
                foreach (var elem in workspaces)
                {
                    WCSWorkspace Tmp = new WCSWorkspace(_SK, elem);
                    LstWork.Add(Tmp);
                }
                next_url = ret._json.pagination.next_url;
            }

            return LstWork;
        }

        /*
         * "name": "Car_Dashboard",
          "created": "2016-07-13T12:26:55.781Z",
          "updated": "2016-11-29T21:46:38.969Z",
          "language": "en",
          "metadata": {
            "runtime_version": "2017-05-26"
          },
          "description": "Cognitive Car workspace which allows multi-turn conversations to perform tasks in the car.",
          "workspace_id": "0a0c06c1-8e31-4655-9067-58fcac5134fc",
          "learning_opt_out": false
      */


        /*public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("language", language)
                );

            return rss.ToString();
        }*/

        /*public void Create(string sName, string sFileName)
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
        }*/

        public void Create(string sFileName, string sVersion = null)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/workspaces?version=" + (sVersion == null ? sVersionDefault : sVersion), "POST", File.ReadAllBytes(sFileName), 0, "application/json", _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();
        }

        public void Update(string sFileName)
        {
            if (!String.IsNullOrEmpty(workspace_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs/" + workspace_id, "PUT", File.ReadAllBytes(sFileName), 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(workspace_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/workspaces/" + workspace_id + "?version=" + (version == null ? sVersionDefault : version), "DELETE", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Converse(string sText)
        {
            /*if (!String.IsNullOrEmpty(dialog_id))
            {
                string sData = "input=" + Uri.EscapeUriString(sText);
                if (null != conversation_id)
                    sData += "&conversation_id=" + conversation_id;

                if (null != client_id)
                    sData += "&client_id=" + client_id;

                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/dialogs/" + dialog_id + "/conversation", "POST", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                Load(ret._json);
            }*/
        }



    }
}
