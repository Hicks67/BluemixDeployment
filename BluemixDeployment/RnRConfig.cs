using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BluemixDeployment
{
    class RnRConfig : BaseRESTServices
    {

        public RnRConfig(ServiceKeys SK, string sClusterId, string sName = "") : base(SK)
        {
            solr_cluster_id = sClusterId;
            config_name = sName;
        }        

        /*public void Load(dynamic json)
        {
            solr_cluster_id = json.solr_cluster_id;
            cluster_name = json.cluster_name;
            cluster_size = json.cluster_size;
            solr_cluster_status = json.solr_cluster_status;
        }*/

        public void Create(string sFileName)
        {
            if (!String.IsNullOrEmpty(solr_cluster_id) && !String.IsNullOrEmpty(config_name))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/config/" + config_name, "POST", File.ReadAllBytes(sFileName), 0, "application/zip", _SK.cred_username, _SK.cred_password, null, "application/json");
                _json = ret._json.ToString();
            }
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(solr_cluster_id) && !String.IsNullOrEmpty(config_name))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/config/" + config_name, "DELETE", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                //_json = ret._json.ToString();
            }
        }

        public List<string> GetList()
        {
            List<string> LstConfigs = null;
            if (!String.IsNullOrEmpty(solr_cluster_id))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/config", "GET", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();

                LstConfigs = new List<string>();

                var configs = (JArray)ret._json.solr_configs;
                foreach (var elem in configs)
                {
                    LstConfigs.Add((string)elem);
                }
            }

            return LstConfigs;

        }

        

        //Config
        public string config_name { get; set; }
        public string solr_cluster_id { get; set; }
        
    }
}
