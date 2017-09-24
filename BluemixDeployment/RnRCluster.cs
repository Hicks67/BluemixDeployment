using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class RnRCluster : BaseRESTServices
    {

        public RnRCluster(ServiceKeys SK,dynamic json) : base(SK)
        {
            Load(json);
        }

        public RnRCluster(ServiceKeys SK) : base(SK)
        {         
        }

        public RnRCluster(string name, string size)
        {
            cluster_name = name;
            cluster_size = size;
        }

        public RnRCluster(ServiceKeys SK,string name, string size) : base(SK)
        {
            cluster_name = name;
            cluster_size = size;
        }

        public void Load(dynamic json)
        {
            solr_cluster_id = json.solr_cluster_id;
            cluster_name = json.cluster_name;
            cluster_size = json.cluster_size;
            solr_cluster_status = json.solr_cluster_status;
        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("cluster_size", cluster_size),
                new JProperty("cluster_name", cluster_name));

            return rss.ToString();
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(solr_cluster_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id, "DELETE", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public List<RnRCluster> GetList()
        {

            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters", "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
            _json = ret._json.ToString();

            List<RnRCluster> LstClusters = new List<RnRCluster>();

            var clusters = (JArray)ret._json.clusters;
            foreach (var elem in clusters)
            {
                RnRCluster Tmp = new RnRCluster(_SK,elem);
                LstClusters.Add(Tmp);
            }

            return LstClusters;

        }

        public void Create(string sName, string sSize)
        {
            cluster_size = sSize;
            cluster_name = sName;
            Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters", "POST", Encoding.ASCII.GetBytes(GetJson()), 0, "application/json", _SK.cred_username, _SK.cred_password, null);            
            Load(ret._json);
            _json = ret._json.ToString();
        }

        //Cluster 
        public string solr_cluster_id { get; set; }
        public string cluster_name { get; set; }
        public string cluster_size { get; set; }
        public string solr_cluster_status { get; set; }
    }
}
