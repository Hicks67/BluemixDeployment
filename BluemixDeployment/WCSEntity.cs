using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;


namespace BluemixDeployment
{
    class WCSEntity : BaseRESTServices
    {
        string sVersionDefault = "2017-05-26";


        public WCSEntity(ServiceKeys key, dynamic json) : base(key)
        {
            Load(json);
        }
        public WCSEntity(ServiceKeys key, string sVersion = null) : base(key)
        {
        }

        public string version { get; set; }

        public string entity { get; set; }        
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

        public JObject GetJson()
        {
            JObject rss = new JObject(
                new JProperty("intent", intent),
                new JProperty("description", description)
                );

            if (examples.Count > 0)
            {
                JArray oArray = new JArray();
                foreach (WCSExample ex in examples)
                {
                    oArray.Add(ex.GetJson());
                }
                rss.Add(new JProperty("examples", oArray));

            }

            return rss;
        }

        /* public List<WCSWorkspace> GetList()
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
         }*/

        /*
        /*public void Create(string sFileName, string sVersion = null)
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
        // }



    }
}
