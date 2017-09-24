using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace BluemixDeployment
{
    class RnRCollection : BaseRESTServices
    {

        public RnRCollection(ServiceKeys SK, string sClusterId, string sName) : base(SK)
        {
            solr_cluster_id = sClusterId;
            collection_name = sName;
        }


        public void Create(string sName, string sConfigName)
        {
            collection_name = sName;
            config_name = sConfigName;
            if (!String.IsNullOrEmpty(solr_cluster_id) && !String.IsNullOrEmpty(collection_name))
            {
                //string sData = "action=CREATE&name=" + collection_name + "&collection.configName=" + config_name + "&wt=json";
                //sData = Uri.EscapeUriString(sData);
                //Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/admin/collections", "POST", Encoding.ASCII.GetBytes(sData), 0, null, _SK.cred_username, _SK.cred_password, null, "application/json");

                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/admin/collections?action=CREATE&name=" + collection_name + "&collection.configName=" + config_name + "&wt=json", "POST", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public dynamic Query(string sQuery, string sRankerId = null)
        {
            Tools.HttpReturn ret = new Tools.HttpReturn();
            if (!String.IsNullOrEmpty(solr_cluster_id) && !String.IsNullOrEmpty(collection_name))
            {     
                if (!String.IsNullOrEmpty(sRankerId))
                    ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/" + collection_name + "/fselect?ranker_id="+ sRankerId +"&q=" + sQuery + "&wt=json", "POST", null, 0, "application/json", _SK.cred_username, _SK.cred_password, null);
                else
                    ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/" + collection_name + "/select?q=" + sQuery + "&wt=json", "POST", null, 0, "application/json", _SK.cred_username, _SK.cred_password, null);

                _json = ret._json.ToString();
            }
            return ret._json;
        }

        public void Indexing(byte[] Data)
        {
            if (!String.IsNullOrEmpty(solr_cluster_id) && !String.IsNullOrEmpty(collection_name))
            {
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/" + collection_name + "/update", "POST", Data, 0, null, _SK.cred_username, _SK.cred_password, null);
                _json = ret._json.ToString();
            }
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(solr_cluster_id) && !String.IsNullOrEmpty(collection_name))
            {
                //string sData = "action=DELETE&name=" + collection_name;
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/admin/collections?action=DELETE&name=" + collection_name, "POST", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                //_json = ret._json.ToString();
            }
        }

        public List<string> GetList()
        {
            List<string> LstCollections = null;
            if (!String.IsNullOrEmpty(solr_cluster_id))
            {                
                Tools.HttpReturn ret = Tools.HttpRequest(_SK.cred_url + "/v1/solr_clusters/" + solr_cluster_id + "/solr/admin/collections?action=LIST", "POST", null, 0, null, _SK.cred_username, _SK.cred_password, null);
                //_json = ret._json.ToString();

                LstCollections = new List<string>();

                XmlDocument oDoc = new XmlDocument();
                oDoc.Load(ret._Data);
                
                foreach (XmlNode node in oDoc.SelectNodes("//arr/str"))
                {
                    LstCollections.Add((string)node.InnerText);
                }
            }

            return LstCollections;

        }

        public string collection_name { get; set; }
        public string config_name { get; set; }        
        public string solr_cluster_id { get; set; }
    }
}
