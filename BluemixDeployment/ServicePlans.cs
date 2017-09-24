using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class ServicePlans:BaseObject
    {
        public ServicePlans(dynamic json)
        {
            Load(json);
        }

        public ServicePlans(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {
            Load(json);
        }

        public ServicePlans(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public ServicePlans() { }

        //metadata
        public string guid { get; set; } //"guid": "1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string url { get; set; } //"url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string created_at { get; set; } //"created_at": "2017-08-07T22:29:57Z",
        public string updated_at { get; set; } //"updated_at": "2017-08-07T22:29:57Z"


        //entity
        public string name { get; set; } //"name": "AppJava1",
        public bool free { get; set; } 

        public string description { get; set; }
        //public string credentials { get; set; } // "credentials": {},
        public string service_guid { get; set; } //"service_guid": "d94db6ad-29bf-4972-b8c3-e7440a976645",
        public string extra { get; set; } //"extra": "{\"bullets\":[\"1 Natural Language Classifier free per month.\",\"1000 API calls free per month\",\"4 Training Events free per month\"],\"costs\":[{\"partNumber\":\"D1HYSLL\",\"unit\":\"Classifier per month\",\"unitId\":\"CLASSIFIER_INSTANCES_PER_MONTH\",\"unitQuantity\":\"1\",\"tierModel\":\"Granular Tier\",\"quantityTier\":\"1.000\",\"currencies\":[{\"country\":\"ARG\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"ASEAN\",\"amount\":{\"USD\":\"21.00\"}},{\"country\":\"AUS\",\"amount\":{\"AUD\":\"22.68\"}},{\"country\":\"BOL\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"BRA\",\"amount\":{\"BRL\":\"54.68\"}},{\"country\":\"CAN\",\"amount\":{\"CAD\":\"21.13\"}},{\"country\":\"CHE\",\"amount\":{\"CHF\":\"18.95\"}},{\"country\":\"CHL\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"COL\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"DNK\",\"amount\":{\"DKK\":\"111.00\"}},{\"country\":\"ECU\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"EURO\",\"amount\":{\"EUR\":\"15.04\"}},{\"country\":\"GBR\",\"amount\":{\"GBP\":\"12.10\"}},{\"country\":\"HKG\",\"amount\":{\"USD\":\"21.00\"}},{\"country\":\"IDN\",\"amount\":{\"IDR\":\"288800.00\"}},{\"country\":\"IND\",\"amount\":{\"INR\":\"1207.50\"}},{\"country\":\"ISA\",\"amount\":{\"USD\":\"21.00\"}},{\"country\":\"JPN\",\"amount\":{\"JPY\":\"2100\"}},{\"country\":\"KOR\",\"amount\":{\"KRW\":\"23300.00\"}},{\"country\":\"MEX\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"NOR\",\"amount\":{\"NOK\":\"115.00\"}},{\"country\":\"NZL\",\"amount\":{\"NZD\":\"26.10\"}},{\"country\":\"PER\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"SWE\",\"amount\":{\"SEK\":\"131.00\"}},{\"country\":\"TWN\",\"amount\":{\"USD\":\"21.00\"}},{\"country\":\"USA\",\"amount\":{\"USD\":\"20.00\"}},{\"country\":\"USD\",\"amount\":{\"USD\":\"21.40\"}},{\"country\":\"VEN\",\"amount\":{\"USD\":\"23.00\"}},{\"country\":\"ZAF\",\"amount\":{\"ZAR\":\"207.00\"}}]},{\"partNumber\":\"D1HYTLL\",\"unit\":\" API call\",\"unitId\":\"CLASSIFIER_API_CALLS_PER_MONTH\",\"unitQuantity\":\"10000\",\"tierModel\":\"Granular Tier\",\"quantityTier\":\"1.000\",\"currencies\":[{\"country\":\"ARG\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"ASEAN\",\"amount\":{\"USD\":\"36.75\"}},{\"country\":\"AUS\",\"amount\":{\"AUD\":\"39.69\"}},{\"country\":\"BOL\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"BRA\",\"amount\":{\"BRL\":\"95.69\"}},{\"country\":\"CAN\",\"amount\":{\"CAD\":\"36.98\"}},{\"country\":\"CHE\",\"amount\":{\"CHF\":\"33.17\"}},{\"country\":\"CHL\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"COL\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"DNK\",\"amount\":{\"DKK\":\"194.00\"}},{\"country\":\"ECU\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"EURO\",\"amount\":{\"EUR\":\"26.32\"}},{\"country\":\"GBR\",\"amount\":{\"GBP\":\"21.16\"}},{\"country\":\"HKG\",\"amount\":{\"USD\":\"36.75\"}},{\"country\":\"IDN\",\"amount\":{\"IDR\":\"505300.00\"}},{\"country\":\"IND\",\"amount\":{\"INR\":\"2113.13\"}},{\"country\":\"ISA\",\"amount\":{\"USD\":\"36.75\"}},{\"country\":\"JPN\",\"amount\":{\"JPY\":\"3675\"}},{\"country\":\"KOR\",\"amount\":{\"KRW\":\"40780.00\"}},{\"country\":\"MEX\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"NOR\",\"amount\":{\"NOK\":\"202.00\"}},{\"country\":\"NZL\",\"amount\":{\"NZD\":\"45.68\"}},{\"country\":\"PER\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"SWE\",\"amount\":{\"SEK\":\"229.00\"}},{\"country\":\"TWN\",\"amount\":{\"USD\":\"36.75\"}},{\"country\":\"USA\",\"amount\":{\"USD\":\"35.00\"}},{\"country\":\"USD\",\"amount\":{\"USD\":\"37.45\"}},{\"country\":\"VEN\",\"amount\":{\"USD\":\"40.25\"}},{\"country\":\"ZAF\",\"amount\":{\"ZAR\":\"362.00\"}}]},{\"partNumber\":\"D1HYULL\",\"unit\":\" Training Event\",\"unitId\":\"TRAINING_EVENT_API_CALLS_PER_MONTH\",\"unitQuantity\":\"1\",\"tierModel\":\"Granular Tier\",\"quantityTier\":\"1.000\",\"currencies\":[{\"country\":\"ARG\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"ASEAN\",\"amount\":{\"USD\":\"3.15\"}},{\"country\":\"AUS\",\"amount\":{\"AUD\":\"3.40\"}},{\"country\":\"BOL\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"BRA\",\"amount\":{\"BRL\":\"8.20\"}},{\"country\":\"CAN\",\"amount\":{\"CAD\":\"3.17\"}},{\"country\":\"CHE\",\"amount\":{\"CHF\":\"2.85\"}},{\"country\":\"CHL\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"COL\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"DNK\",\"amount\":{\"DKK\":\"16.61\"}},{\"country\":\"ECU\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"EURO\",\"amount\":{\"EUR\":\"2.26\"}},{\"country\":\"GBR\",\"amount\":{\"GBP\":\"1.81\"}},{\"country\":\"HKG\",\"amount\":{\"USD\":\"3.15\"}},{\"country\":\"IDN\",\"amount\":{\"IDR\":\"43310.00\"}},{\"country\":\"IND\",\"amount\":{\"INR\":\"181.13\"}},{\"country\":\"ISA\",\"amount\":{\"USD\":\"3.15\"}},{\"country\":\"JPN\",\"amount\":{\"JPY\":\"315\"}},{\"country\":\"KOR\",\"amount\":{\"KRW\":\"3500.00\"}},{\"country\":\"MEX\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"NOR\",\"amount\":{\"NOK\":\"17.33\"}},{\"country\":\"NZL\",\"amount\":{\"NZD\":\"3.92\"}},{\"country\":\"PER\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"SWE\",\"amount\":{\"SEK\":\"19.61\"}},{\"country\":\"TWN\",\"amount\":{\"USD\":\"3.15\"}},{\"country\":\"USA\",\"amount\":{\"USD\":\"3.00\"}},{\"country\":\"USD\",\"amount\":{\"USD\":\"3.21\"}},{\"country\":\"VEN\",\"amount\":{\"USD\":\"3.45\"}},{\"country\":\"ZAF\",\"amount\":{\"ZAR\":\"31.04\"}}]}],\"displayName\":\"Standard\"}",
        public string unique_id { get; set; } //"unique_id": "3dfcce09-09e2-4b17-8afb-eee8afab0423-",
        public bool public_ { get; set; } //"public": true,
        public bool bindable { get; set; } //"bindable": true,
        public bool active { get; set; } //"active": true,
        public string service_url { get; set; } //"service_url": "/v2/services/d94db6ad-29bf-4972-b8c3-e7440a976645"
        public string service_instances_url { get; set; } //"service_instances_url": "/v2/service_plans/e6c3063c-7163-4134-a934-77a5e9d80be9/service_instances"

        public void Load(dynamic json)
        {
            //metadata
            guid = json.metadata.guid;
            url = json.metadata.url;
            created_at = json.metadata.created_at;
            updated_at = json.metadata.updated_at;

            //entity
            name = json.entity.name;
            free = json.entity.free;
            description = json.entity.description;
            service_guid = json.entity.service_guid;
            extra = json.entity.extra;
            unique_id = json.entity.unique_id;
            //public_ = json.entity.public;
            
            bindable = json.entity.bindable;
            active = json.entity.active;
            service_url = json.entity.service_url;
            service_instances_url = json.entity.service_instances_url;

            _json = json.ToString();
        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("service_url", service_url),
                new JProperty("service_guid", service_guid));

            return rss.ToString();
        }

        /*public void Create(string sUrlCloud, string sToken)
        {
            string sUrl = sUrlCloud + "/v2/service_instances";
            dynamic json = Tools.HttpRequest(sUrl, "POST", Encoding.UTF8.GetBytes(GetJson()), 0, "application/json", "", "", sToken);


        }*/

        static public List<ServicePlans> GetList(string sUrlCloud, string sToken)
        {
            return GetListByService(sUrlCloud, sToken, null);
        }

        static public List<ServicePlans> GetListByService(string sUrlCloud, string sToken, string sGuid)
        {
            string sUrl = sUrlCloud + "/v2/service_plans";
            if (!String.IsNullOrEmpty(sGuid))
                sUrl += "?q=service_guid:" + sGuid;

            Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "GET", null, 0, null, "", "", sToken);

            List<ServicePlans> LstServices = new List<ServicePlans>();
            int nbpages = ret._json.total_pages;
            int nbresult = nbpages > 1 ? 50 : (int)ret._json.total_results.Value;
            for (int j = 0; j < nbpages; j++)
            {

                for (int i = 0; i < nbresult; i++)
                {
                    ServicePlans Tmp = new ServicePlans(ret._json.resources[i]);
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







