using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class ServiceInstance : BaseObject
    {

        public ServiceInstance(dynamic json)
        {
            Load(json);
        }

        public ServiceInstance(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {                      
            Load(json);
        }

        public ServiceInstance(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public ServiceInstance() { }


        public string guid { get; set; } //"guid": "1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string url { get; set; } //"url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string created_at { get; set; } //"created_at": "2017-08-07T22:29:57Z",
        public string updated_at { get; set; } //"updated_at": "2017-08-07T22:29:57Z"
        public string name { get; set; } //"name": "AppJava1",
        //public string credentials { get; set; } // "credentials": {},
        public string service_plan_guid { get; set; } // "service_plan_guid": "e6c3063c-7163-4134-a934-77a5e9d80be9",
        public string space_guid { get; set; } // "space_guid": "b421ef1c-f2b9-446d-b257-41039e21ca23",
        public string gateway_data { get; set; } //"gateway_data": null,
        public string dashboard_url { get; set; } //"dashboard_url": "https://www.ibm.com/watson/developercloud/dashboard/en/nl-classifier-dashboard.html",
        public string type { get; set; } //"type": "managed_service_instance",
        //"last_operation": {
        public string lo_type { get; set; } // "type": "create",
        public string lo_state { get; set; } //"state": "succeeded",
        public string lo_description { get; set; } //"description": "",
        public string lo_updated_at { get; set; } //"updated_at": "2017-08-05T22:39:05Z",
        public string lo_created_at { get; set; } //"created_at": "2017-08-05T22:39:05Z"


        public string service_guid { get; set; } //"service_guid": "d94db6ad-29bf-4972-b8c3-e7440a976645",
        public string space_url { get; set; } //"space_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23",
        public string service_plan_url { get; set; } //"service_plan_url": "/v2/service_plans/e6c3063c-7163-4134-a934-77a5e9d80be9",
        public string service_bindings_url { get; set; } //"service_bindings_url": "/v2/service_instances/58383ae9-34e9-4b53-970d-441e823689df/service_bindings",
        public string service_keys_url { get; set; } //"service_keys_url": "/v2/service_instances/58383ae9-34e9-4b53-970d-441e823689df/service_keys",
        public string routes_url { get; set; } //"routes_url": "/v2/service_instances/58383ae9-34e9-4b53-970d-441e823689df/routes",
        public string service_url { get; set; } //"service_url": "/v2/services/d94db6ad-29bf-4972-b8c3-e7440a976645"
        
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
            service_plan_guid = json.entity.service_plan_guid;
            space_guid = json.entity.space_guid;
            gateway_data = json.entity.gateway_data;
            dashboard_url = json.entity.dashboard_url;
            type = json.entity.type;

            lo_type = json.entity.last_operation.type;
            lo_state = json.entity.last_operation.state;
            lo_description = json.entity.last_operation.description;
            lo_updated_at = json.entity.last_operation.updated_at;
            lo_created_at = json.entity.last_operation.created_at;

            service_guid = json.entity.service_guid;
            space_url = json.entity.space_url;
            service_plan_url = json.entity.service_plan_url;
            service_bindings_url = json.entity.service_bindings_url;
            service_keys_url = json.entity.service_keys_url;
            routes_url = json.entity.routes_url;
            service_url = json.entity.service_url;
            _json = json.ToString();
        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("service_plan_guid", service_plan_guid),
                new JProperty("space_guid", space_guid));

            return rss.ToString();
        }

        public void Create(string sUrlCloud, string sToken)
        {
            string sUrl = sUrlCloud + "/v2/service_instances";
            Tools.HttpRequest(sUrl, "POST", Encoding.ASCII.GetBytes(GetJson()), 0, "application/json", "", "", sToken);
        }

        public void Get(string sUrlCloud, string sToken,string sGuid)
        {
            string sUrl = sUrlCloud + "/v2/service_instances/" + sGuid;
            Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "GET", null, 0, null, "", "", sToken);

            Load(ret._json);

        }

        public Service GetService()
        {

            if (!String.IsNullOrEmpty(service_url))
            {
                string sUrl = _sUrlCloud + service_url;
                Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "GET", null, 0, null, "", "", _sToken);
                return new Service(ret._json, _sUrlCloud, _sToken);
            }
            else
                return null;
        }

        public ServicePlans GetServicePlan()
        {

            if (!String.IsNullOrEmpty(service_plan_url))
            {
                string sUrl = _sUrlCloud + service_plan_url;
                Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "GET", null, 0, null, "", "", _sToken);
                return new ServicePlans(ret._json, _sUrlCloud, _sToken);
            }
            else
                return null;
        }

        public List<ServiceKeys> GetListServiceKeys()
        {

            if (!String.IsNullOrEmpty(service_keys_url))
            {
                return ServiceKeys.GetList(this);
            }
            else
                return null;
        }

        public void Delete(string sUrlCloud, string sToken, string sGuid= null)
        {
            if (!String.IsNullOrEmpty(sGuid))
                guid = sGuid;

            string sUrl = sUrlCloud + "/v2/service_instances/" + guid;            
            Tools.HttpRequest(sUrl, "DELETE", null, 0, null, "", "", sToken);
            
        }

        static public List<ServiceInstance> GetList(string sUrlCloud, string sToken)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(sUrlCloud + "/v2/service_instances", "GET", null, 0, null, "", "", sToken);

            List<ServiceInstance> LstServices = new List<ServiceInstance>();
            int nbpages = ret._json.total_pages;
            int nbresult = nbpages > 1 ? 50 : (int)ret._json.total_results.Value;
            for (int j = 0; j < nbpages; j++)
            {

                for (int i = 0; i < nbresult; i++)
                {
                    ServiceInstance Tmp = new ServiceInstance(ret._json.resources[i]);
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
