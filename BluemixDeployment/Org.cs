using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluemixDeployment
{
    class Org : BaseObject
    {   
       
        public Org(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {
            Load(json);
        }

        public Org(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public string name { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public string guid { get; set; }
        public string status { get; set; }
        public string quota_url { get; set; }
        public string spaces_url { get; set; }
        public string domains_url { get; set; }
        public string users_url { get; set; }
        public string private_domains_url { get; set; }
        public string managers_url { get; set; }
        public string auditors_url { get; set; }
        public string app_events_url { get; set; }
        

        public void Load(dynamic json)
        {
            guid = json.metadata.guid;
            created = json.metadata.created_at;
            updated = json.metadata.updated_at;

            name = json.entity.name;
            status = json.entity.status;
            spaces_url = json.entity.spaces_url;
            domains_url = json.entity.domains_url;
            private_domains_url = json.entity.private_domains_url;
            users_url = json.entity.users_url;
            managers_url = json.entity.managers_url;
            auditors_url = json.entity.auditors_url;
            app_events_url = json.entity.app_events_url;
        }

        public List<Org> GetList()
        {
            Tools.HttpReturn ret = Tools.HttpRequest(_sUrlCloud + "/v2/organizations", "GET", null, 0, null, "", "", _sToken, null);

            List<Org> LstOrgs = new List<Org>();
            int nbpages = ret._json.total_pages;
            int nbresult = nbpages > 1 ? 50 : (int)ret._json.total_results.Value;
            for (int j = 0; j < nbpages; j++)
            {

                for (int i = 0; i < nbresult; i++)
                {
                    Org Tmp = new Org(ret._json.resources[i],_sUrlCloud,_sToken);
                    LstOrgs.Add(Tmp);
                }

                if (!String.IsNullOrEmpty((string)ret._json.next_url))
                {
                    ret = Tools.HttpRequest(_sUrlCloud + ret._json.next_url, "GET", null, 0, null, "", "", _sToken, null);
                    if (nbpages - j == 2)
                        nbresult = ((int)ret._json.total_results.Value) - nbpages * 50;
                }
            }

            return LstOrgs;
        }
    }
}
