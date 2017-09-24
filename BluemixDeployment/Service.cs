using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class Service : BaseObject
    {

        public Service(dynamic json)
        {
            Load(json);
        }
        public Service(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {
            Load(json);
        }

        public Service(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public Service() { }


        public string guid { get; set; } //"guid": "1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string url { get; set; } //"url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string created_at { get; set; } //"created_at": "2017-08-07T22:29:57Z",
        public string updated_at { get; set; } //"updated_at": "2017-08-07T22:29:57Z"
        public string name { get; set; } //"name": "AppJava1",
        public string url2 { get; set; }
        public string label { get; set; }
        public string provider { get; set; }         
        public string description { get; set; }

        public string long_description { get; set; }
        public string version { get; set; }

        public string info_url { get; set; }
        public bool active { get; set; }

        public bool bindable { get; set; }

        public string unique_id { get; set; }

        public string documentation_url { get; set; }
        public string service_broker_guid { get; set; }
        public bool plan_updateable { get; set; }

        public string service_plans_url { get; set; }

        public void Load(dynamic json)
        {
            //metadata
            guid = json.metadata.guid;
            url = json.metadata.url;
            created_at = json.metadata.created_at;
            updated_at = json.metadata.updated_at;

            //entity
            url2 = json.entity.url;
            label = json.entity.label;
            provider = json.entity.provider;
            description = json.entity.description;

            long_description = json.entity.long_description;
            version = json.entity.version;
            info_url = json.entity.info_url;
            active = json.entity.active;   //true
            bindable = json.entity.bindable; //true
            //extra = json.resources[i].entity.extra;

            unique_id = json.entity.unique_id; //"D6D8A8E4-3920-11E5-ABE6-A2B0631DAC50"
            documentation_url = json.entity.documentation_url;
            service_broker_guid = json.entity.service_broker_guid;
            plan_updateable = json.entity.plan_updateable;
            service_plans_url = json.entity.service_plans_url;
            _json = json.ToString();
        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("label", label),
                new JProperty("description", description),
                new JProperty("long_description", long_description));

            return rss.ToString();
        }

        public void Create(string sUrlCloud, string sToken)
        {
            string sUrl = sUrlCloud + "/v2/service";
            Tools.HttpRequest(sUrl, "POST", Encoding.UTF8.GetBytes(GetJson()), 0, "application/json", "", "", sToken);
        }

        static public List<Service> GetList(string sUrlCloud, string sToken)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(sUrlCloud + "/v2/services", "GET", null, 0, null, "", "", sToken);
            
            List<Service> LstServices = new List<Service>();
            int nbpages = ret._json.total_pages;
            int nbresult = nbpages > 1 ? 50 : (int)ret._json.total_results.Value;
            for (int j = 0; j < nbpages; j++)
            {

                for (int i = 0; i < nbresult; i++)
                {
                    Service Tmp = new Service(ret._json.resources[i]);
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
