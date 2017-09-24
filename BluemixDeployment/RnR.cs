using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class RnR : BaseRESTServices
    {
        public RnR(dynamic json, ServiceKeys SK) : base(SK)
        {
            //Load(json);
        }
        public RnR() { }
        public RnR(ServiceKeys SK) : base(SK) { }

        public List<RnRCluster> ListClusters { get; set; }

        //Config
        public string config_name { get; set; }

        //Collection
        public string created { get; set; }

        public string language { get; set; }

        public string top_class { get; set; }
        
        public void GetListClusters()
        {

            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters", "GET", null, 0, "application/json", _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();

            ListClusters = new List<RnRCluster>();         

            var clusters = (JArray)ret._json.clusters;
            foreach (var elem in clusters)
            {
                RnRCluster Tmp = new RnRCluster(_SK,elem);
                ListClusters.Add(Tmp);
            }
        }
    }
}
