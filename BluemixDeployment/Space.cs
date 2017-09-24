using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluemixDeployment
{
    class Space : BaseObject
    {

        public Space(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {
            Load(json);
        }

        public Space(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public string guid {get;set;}

        public string url { get; set; } //"url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23",

        public string created { get; set; } //"created_at": "2017-08-05T00:09:51Z",
        public string updated { get; set; } // "updated_at": "2017-08-05T00:09:51Z"
            
        public string name { get; set; }

        public string organization_guid { get; set; } // "organization_guid": "9a5f3313-272e-43d5-8fd2-ba69ec238011",
        public string space_quota_definition_guid { get; set; } //"space_quota_definition_guid": null,
        public string isolation_segment_guid { get; set; } //"isolation_segment_guid": null,
        public string allow_ssh { get; set; } //"allow_ssh": true,
        public string organization_url { get; set; } //"organization_url": "/v2/organizations/9a5f3313-272e-43d5-8fd2-ba69ec238011",
        public string developers_url { get; set; } //"developers_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/developers",
        public string managers_url { get; set; } //"managers_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/managers",
        public string auditors_url { get; set; }//"auditors_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/auditors",
        public string apps_url { get; set; }//"apps_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/apps",
        public string routes_url { get; set; }//"routes_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/routes",
        public string domains_url { get; set; }//"domains_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/domains",
        public string service_instances_url { get; set; }//"service_instances_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/service_instances",
        public string app_events_url { get; set; }//"app_events_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/app_events",
        public string events_url { get; set; }//"events_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/events",
        public string security_groups_url { get; set; }//"security_groups_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/security_groups",
        public string staging_security_groups_url { get; set; } //"staging_security_groups_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23/staging_security_groups"

        public void Load(dynamic json)
        {
            guid = json.metadata.guid;
            url = json.metadata.url;
            created = json.metadata.created_at;
            updated = json.metadata.updated_at;
            apps_url = json.entity.apps_url;
            name = json.entity.name;           
            managers_url = json.entity.managers_url;
            auditors_url = json.entity.auditors_url;
            app_events_url = json.entity.app_events_url;
        }

        public List<Space> GetList(string sGuid)
        {
            string sUrl = _sUrlCloud + "/v2/spaces";
            if (!String.IsNullOrEmpty(sGuid))
                sUrl += "?q=organization_guid:" + sGuid;

            Tools.HttpReturn ret = Tools.HttpRequest(sUrl, "GET", null, 0, null, "", "", _sToken);

            List<Space> LstSpaces = new List<Space>();
            int nbpages = ret._json.total_pages;
            int nbresult = nbpages > 1 ? 50 : (int)ret._json.total_results.Value;
            for (int j = 0; j < nbpages; j++)
            {

                for (int i = 0; i < nbresult; i++)
                {
                    Space Tmp = new Space(ret._json.resources[i], _sUrlCloud,_sToken);
                    LstSpaces.Add(Tmp);
                }

                if (!String.IsNullOrEmpty((string)ret._json.next_url))
                {
                    ret = Tools.HttpRequest(_sUrlCloud + ret._json.next_url, "GET", null, 0, null, "", "", _sToken);
                    if (nbpages - j == 2)
                        nbresult = ((int)ret._json.total_results.Value) - nbpages * 50;
                }
            }

            return LstSpaces;
        }

    }    
}
