using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class ServiceKeys : BaseObject
    {              
        public ServiceKeys(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {
            Load(json);
        }

        public ServiceKeys(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public string guid { get; set; } //"guid": "1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string url { get; set; } //"url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string created_at { get; set; } //"created_at": "2017-08-07T22:29:57Z",
        public string updated_at { get; set; } //"updated_at": "2017-08-07T22:29:57Z"
        public string name { get; set; } //"name": "AppJava1",
        //public string credentials { get; set; } // "credentials": {},
        public string service_instance_guid { get; set; } // "service_instance_guid": "e6c3063c-7163-4134-a934-77a5e9d80be9",

        public string service_instance_url { get; set; }

        public string cred_username { get; set; }

        public string cred_password { get; set; }

        public string cred_url { get; set; }
        //public string _json { get; set; }

        public void Load(dynamic json)
        {
            //metadata
            guid = json.metadata.guid;
            url = json.metadata.url;
            created_at = json.metadata.created_at;
            updated_at = json.metadata.updated_at;

            //entity
            name = json.entity.name;
            service_instance_guid = json.entity.service_instance_guid;
            //cred_name = json.entity.credentials[0].Key;
            //cred_val = json.entity.credentials[0].Value;
            cred_username = json.entity.credentials.username;
            cred_password = json.entity.credentials.password;
            cred_url = json.entity.credentials.url;
            service_instance_url = json.entity.service_instance_url;
            _json = json.ToString();
        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("service_instance_guid", service_instance_guid)
                );

            return rss.ToString();
        }

        public void Create()
        {
            string sUrl = _sUrlCloud + "/v2/service_keys";
            Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "POST", Encoding.UTF8.GetBytes(GetJson()), 0, "application/json", "", "", _sToken);
            Load(ret._json);//to do
        }

        public void Get()
        {
            string sUrl = _sUrlCloud + "/v2/service_keys/" + guid;
            Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "GET", null, 0, null, "", "", _sToken);

            Load(ret._json);

        }

        public void Delete()
        {
            string sUrl = _sUrlCloud + "/v2/service_keys/" + guid;
            Tools.HttpRequest(sUrl, "DELETE", null, 0, null, "", "", _sToken);

        }
        static public List<ServiceKeys> GetList(ServiceInstance SI)
        {
            if (!String.IsNullOrEmpty(SI.service_keys_url))
            {
                return GetList(SI._sUrlCloud, SI._sToken, SI.service_keys_url);
            }
            else
                return null;
        }

        static public List<ServiceKeys> GetList(string sUrlCloud, string sToken, string sGuid,int k = 0)
        {
            string sParam;
            if (k == 0)
            {
                sParam = "/v2/service_keys";
                if (!String.IsNullOrEmpty(sGuid))
                    sParam = "?q=service_instance_guid:" + sGuid;
            }
            else
            {
                sParam = "/v2/service_instances/" + sGuid + "/service_keys";
            }

            return GetList(sUrlCloud, sToken, sParam);
        }

        static private List<ServiceKeys> GetList(string sUrlCloud, string sToken, string sParam)
        {

            Tools.HttpReturn ret = Tools.HttpRequest(sUrlCloud + sParam, "GET", null, 0, null, "", "", sToken);

            List<ServiceKeys> LstServices = new List<ServiceKeys>();
            int nbpages = ret._json.total_pages;
            int nbresult = nbpages > 1 ? 50 : (int)ret._json.total_results.Value;
            for (int j = 0; j < nbpages; j++)
            {

                for (int i = 0; i < nbresult; i++)
                {
                    ServiceKeys Tmp = new ServiceKeys(ret._json.resources[i], sUrlCloud, sToken);
                    LstServices.Add(Tmp);
                }

                if (!String.IsNullOrEmpty((string)ret._json.next_url))
                {
                    ret = Tools.HttpRequest(sUrlCloud + ret._json.next_url, "GET", null, 0, null, "", "", sToken);
                    if (nbpages - j == 2)
                        nbresult = ((int)ret._json.total_results.Value) - nbpages * 50;
                }
            }

            return LstServices;

        }
    }

}

