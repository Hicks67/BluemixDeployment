using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Xml;
using RecastAI;

namespace BluemixDeployment
{

    public partial class Form1 : Form
    {
        private string sUrlCloud = Settings1.Default["UrlCloud"].ToString();// http://api.eu-gb.bluemix.net";
        //curl -X POST -H "Content-Type: application/x-www-form-urlencoded" -d "user=poubhix-69@yahoo.fr&passwd=K7800xy1!&space=dev&organization=poubhix-69" https://metrics.eu-gb.bluemix.net/login
        //private string sToken = "eyJhbGciOiJIUzI1NiIsImtpZCI6ImtleS0xIiwidHlwIjoiSldUIn0.eyJqdGkiOiJiZDgxOTRkN2ViMGE0NjJhODgwZWU0NTY2NGYwZDA1OCIsInN1YiI6IjI5ZTc2NzI1LTYxMjAtNGJiOC05YTczLTA1NDAwYzIyMDkzNCIsInNjb3BlIjpbIm9wZW5pZCIsInVhYS51c2VyIiwiY2xvdWRfY29udHJvbGxlci5yZWFkIiwicGFzc3dvcmQud3JpdGUiLCJjbG91ZF9jb250cm9sbGVyLndyaXRlIl0sImNsaWVudF9pZCI6ImNmIiwiY2lkIjoiY2YiLCJhenAiOiJjZiIsImdyYW50X3R5cGUiOiJwYXNzd29yZCIsInVzZXJfaWQiOiIyOWU3NjcyNS02MTIwLTRiYjgtOWE3My0wNTQwMGMyMjA5MzQiLCJvcmlnaW4iOiJ1YWEiLCJ1c2VyX25hbWUiOiJ4YXZpZXJfZjY2NkB5YWhvby5mciIsImVtYWlsIjoieGF2aWVyX2Y2NjZAeWFob28uZnIiLCJhdXRoX3RpbWUiOjE1MDMxMDA0OTcsInJldl9zaWciOiI1YWIyNjQ5MSIsImlhdCI6MTUwMzEwMDQ5NywiZXhwIjoxNTA0MzEwMDk3LCJpc3MiOiJodHRwczovL3VhYS5uZy5ibHVlbWl4Lm5ldC9vYXV0aC90b2tlbiIsInppZCI6InVhYSIsImF1ZCI6WyJjbG91ZF9jb250cm9sbGVyIiwicGFzc3dvcmQiLCJjZiIsInVhYSIsIm9wZW5pZCJdfQ.MO6_B8wImSpatzIjoxvQ4POTNOCAZN4v4rq-34l3zrQ";
        private string sToken = Settings1.Default["Token"].ToString();//"eyJhbGciOiJIUzI1NiIsImtpZCI6ImtleS0xIiwidHlwIjoiSldUIn0.eyJqdGkiOiJhMDkwMmM1MjFlMzc0ZjhjOWNjNWI4ZWY2MGJhNDE3OSIsInN1YiI6IjI5ZTc2NzI1LTYxMjAtNGJiOC05YTczLTA1NDAwYzIyMDkzNCIsInNjb3BlIjpbIm9wZW5pZCIsInVhYS51c2VyIiwiY2xvdWRfY29udHJvbGxlci5yZWFkIiwicGFzc3dvcmQud3JpdGUiLCJjbG91ZF9jb250cm9sbGVyLndyaXRlIl0sImNsaWVudF9pZCI6ImNmIiwiY2lkIjoiY2YiLCJhenAiOiJjZiIsImdyYW50X3R5cGUiOiJwYXNzd29yZCIsInVzZXJfaWQiOiIyOWU3NjcyNS02MTIwLTRiYjgtOWE3My0wNTQwMGMyMjA5MzQiLCJvcmlnaW4iOiJ1YWEiLCJ1c2VyX25hbWUiOiJ4YXZpZXJfZjY2NkB5YWhvby5mciIsImVtYWlsIjoieGF2aWVyX2Y2NjZAeWFob28uZnIiLCJhdXRoX3RpbWUiOjE1MDQzOTUzNjMsInJldl9zaWciOiI1YWIyNjQ5MSIsImlhdCI6MTUwNDM5NTM2MywiZXhwIjoxNTA1NjA0OTYzLCJpc3MiOiJodHRwczovL3VhYS5uZy5ibHVlbWl4Lm5ldC9vYXV0aC90b2tlbiIsInppZCI6InVhYSIsImF1ZCI6WyJjbG91ZF9jb250cm9sbGVyIiwicGFzc3dvcmQiLCJjZiIsInVhYSIsIm9wZW5pZCJdfQ.GGXzgla1Q871JkWREQo9zYGB-iNZbltlvmB44et5f9M";
        //eyJhbGciOiJIUzI1NiIsImtpZCI6ImtleS0xIiwidHlwIjoiSldUIn0.eyJqdGkiOiJlZWJhYmViYjIxNDc0ODM0YTcyMDkyMTgwYThlNzMyMCIsInN1YiI6IjNhMDMyNzlmLTY4MjctNGUxZi1hOGYzLWU4ODM3NDg1MDEwZSIsInNjb3BlIjpbIm9wZW5pZCIsInVhYS51c2VyIiwiY2xvdWRfY29udHJvbGxlci5yZWFkIiwicGFzc3dvcmQud3JpdGUiLCJjbG91ZF9jb250cm9sbGVyLndyaXRlIl0sImNsaWVudF9pZCI6ImNmIiwiY2lkIjoiY2YiLCJhenAiOiJjZiIsImdyYW50X3R5cGUiOiJwYXNzd29yZCIsInVzZXJfaWQiOiIzYTAzMjc5Zi02ODI3LTRlMWYtYThmMy1lODgzNzQ4NTAxMGUiLCJvcmlnaW4iOiJ1YWEiLCJ1c2VyX25hbWUiOiJwb3ViaGl4LTY5QHlhaG9vLmZyIiwiZW1haWwiOiJwb3ViaGl4LTY5QHlhaG9vLmZyIiwiYXV0aF90aW1lIjoxNTA2MjA5NTM1LCJyZXZfc2lnIjoiMjI1NDRkMjQiLCJpYXQiOjE1MDYyMDk1MzUsImV4cCI6MTUwNzQxOTEzNSwiaXNzIjoiaHR0cHM6Ly91YWEubmcuYmx1ZW1peC5uZXQvb2F1dGgvdG9rZW4iLCJ6aWQiOiJ1YWEiLCJhdWQiOlsiY2xvdWRfY29udHJvbGxlciIsInBhc3N3b3JkIiwiY2YiLCJ1YWEiLCJvcGVuaWQiXX0.IHn0r8u6joHiNWNmMSzeLlcoTfXkgsJbFkzDrueUTbo
        private ServiceKeys _SK = null;
        private ServiceInstance _SI = null;
        private Service _Srv = null;
        public Form1()
        {
            InitializeComponent();
        }

        

        /*public static T Deserialize<T>(Stream s)
        {
            using (StreamReader reader = new StreamReader(s))
            using (JsonTextReader jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer ser = new JsonSerializer();
                return ser.Deserialize<T>(jsonReader);
            }
        }*/

        

        private void button1_Click(object sender, EventArgs e)
        {

            // string sUrl = "http://api.eu-gb.bluemix.net/v2/buildpacks";
            // string sToken = "eyJhbGciOiJIUzI1NiIsImtpZCI6ImtleS0xIiwidHlwIjoiSldUIn0.eyJqdGkiOiJiZDgxOTRkN2ViMGE0NjJhODgwZWU0NTY2NGYwZDA1OCIsInN1YiI6IjI5ZTc2NzI1LTYxMjAtNGJiOC05YTczLTA1NDAwYzIyMDkzNCIsInNjb3BlIjpbIm9wZW5pZCIsInVhYS51c2VyIiwiY2xvdWRfY29udHJvbGxlci5yZWFkIiwicGFzc3dvcmQud3JpdGUiLCJjbG91ZF9jb250cm9sbGVyLndyaXRlIl0sImNsaWVudF9pZCI6ImNmIiwiY2lkIjoiY2YiLCJhenAiOiJjZiIsImdyYW50X3R5cGUiOiJwYXNzd29yZCIsInVzZXJfaWQiOiIyOWU3NjcyNS02MTIwLTRiYjgtOWE3My0wNTQwMGMyMjA5MzQiLCJvcmlnaW4iOiJ1YWEiLCJ1c2VyX25hbWUiOiJ4YXZpZXJfZjY2NkB5YWhvby5mciIsImVtYWlsIjoieGF2aWVyX2Y2NjZAeWFob28uZnIiLCJhdXRoX3RpbWUiOjE1MDMxMDA0OTcsInJldl9zaWciOiI1YWIyNjQ5MSIsImlhdCI6MTUwMzEwMDQ5NywiZXhwIjoxNTA0MzEwMDk3LCJpc3MiOiJodHRwczovL3VhYS5uZy5ibHVlbWl4Lm5ldC9vYXV0aC90b2tlbiIsInppZCI6InVhYSIsImF1ZCI6WyJjbG91ZF9jb250cm9sbGVyIiwicGFzc3dvcmQiLCJjZiIsInVhYSIsIm9wZW5pZCJdfQ.MO6_B8wImSpatzIjoxvQ4POTNOCAZN4v4rq-34l3zrQ";

            Tools.HttpReturn ret = Tools.HttpRequest(sUrlCloud + "/v2/buildpacks", "GET", null, 0, "application/json", "", "", sToken);
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Guid", System.Type.GetType("System.String"));
            dt.Columns.Add("Created", System.Type.GetType("System.String"));
            dt.Columns.Add("Updated", System.Type.GetType("System.String"));
            dt.Columns.Add("FileName", System.Type.GetType("System.String"));
                                  
            for (int i=0; i< ret._json.total_results.Value;i++)
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = ret._json.resources[i].entity.name;
                dr["Guid"] = ret._json.resources[i].metadata.guid;
                dr["Created"] = ret._json.resources[i].metadata.created_at;
                dr["Updated"] = ret._json.resources[i].metadata.updated_at;
                dr["FileName"] = ret._json.resources[i].entity.filename;

                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;                                    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {                                
                //cbOrg.ValueMember = "guid";
                //cbOrg.DisplayMember = "name";
                //cbOrg.DataSource = new BindingSource(ListElement,null);
                Org oOrg = new Org(sUrlCloud, sToken);
                cbOrg.DataSource = oOrg.GetList();

                //cbBuildPack.ValueMember = "guid";
                //cbBuildPack.DisplayMember = "name";
                cbBuildPack.DataSource = BuildPack.GetList(sUrlCloud, sToken);

                //cbServices.ValueMember = "guid";
                //cbServices.DisplayMember = "label";
                cbServices.DataSource = Service.GetList(sUrlCloud, sToken);

                //cbServiceIntances.ValueMember = "guid";
                //cbServiceIntances.DisplayMember = "name";
                cbServiceIntances.DataSource = ServiceInstance.GetList(sUrlCloud, sToken);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //Dictionary<string, string> ListElement = null;

                /*string sUrlSpaces = sUrlCloud + cbOrg.SelectedValue.ToString().Substring(cbOrg.SelectedValue.ToString().IndexOf("|")+1);
                Tools.HttpReturn ret = Tools.HttpRequest(sUrlSpaces, "GET", null, 0, null, "", "", sToken, "application/json");
                ListElement = new Dictionary<string, string>();
                for (int i = 0; i < ret._json.total_results.Value; i++)
                {
                    Space Tmp = new Space();


                    /*Tmp.guid = ret._json.resources[i].metadata.guid;
                    Tmp.url = ret._json.resources[i].metadata.url;
                    Tmp.created = ret._json.resources[i].metadata.created_at;
                    Tmp.updated = ret._json.resources[i].metadata.updated_at;

                    Tmp.apps_url = ret._json.resources[i].entity.apps_url;

                    Tmp.name = ret._json.resources[i].entity.name;
                    /*Tmp.status = json.resources[i].entity.status;
                    Tmp.spaces_url = json.resources[i].entity.spaces_url;
                    Tmp.domains_url = json.resources[i].entity.domains_url;
                    Tmp.private_domains_url = json.resources[i].entity.private_domains_url;
                    Tmp.users_url = json.resources[i].entity.users_url;*/
                    /*Tmp.managers_url = ret._json.resources[i].entity.managers_url;
                    Tmp.auditors_url = ret._json.resources[i].entity.auditors_url;
                    Tmp.app_events_url = ret._json.resources[i].entity.app_events_url;

                    //Orgs.Add(Tmp);*/
                    /*ListElement.Add(Tmp.name, Tmp.guid + "|" + Tmp.apps_url);
                }*/

                cbSpaces.ValueMember = "guid";
                cbSpaces.DisplayMember = "name";
                Space oSpace = new Space(sUrlCloud, sToken);
                cbSpaces.DataSource = oSpace.GetList((string)cbOrg.SelectedValue);
                //cbSpaces.DataSource = new BindingSource(ListElement, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void cbApps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOrg.ValueMember = "guid";
            cbOrg.DisplayMember = "name";
           
            cbBuildPack.ValueMember = "guid";
            cbBuildPack.DisplayMember = "name";
           
            cbServices.ValueMember = "guid";
            cbServices.DisplayMember = "label";
            
            cbServiceIntances.ValueMember = "guid";
            cbServiceIntances.DisplayMember = "name";

            cbServiceKeys.ValueMember = "guid";
            cbServiceKeys.DisplayMember = "name";

            cbServicesPlans.ValueMember = "guid";
            cbServicesPlans.DisplayMember = "name";
        }

        private void cbSpaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*Dictionary<string, string> ListElement = null;

                string sUrlApp = sUrlCloud + cbSpaces.SelectedValue.ToString().Substring(cbSpaces.SelectedValue.ToString().IndexOf("|") + 1);
                Tools.HttpReturn ret = Tools.HttpRequest(sUrlApp, "GET", null, 0, null, "", "", sToken, "application/json");
                ListElement = new Dictionary<string, string>();
                for (int i = 0; i < ret._json.total_results.Value; i++)
                {
                    App Tmp = new App(ret._json.resources[i]);
                    ListElement.Add(Tmp.name, Tmp.guid + "|" + Tmp.url);
                }

                cbApps.ValueMember = "Value";
                cbApps.DisplayMember = "Key";
                cbApps.DataSource = new BindingSource(ListElement, null);*/
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnNewApp_Click(object sender, EventArgs e)
        {
            try
            {
                App oApp = new App(sUrlCloud, sToken);
                oApp.name = tbAppName.Text;
                oApp.buildpack = (string)cbBuildPack.GetItemText(cbBuildPack.SelectedItem);
                oApp.space_guid = (string)cbSpaces.SelectedValue;
                oApp.Create();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnNewSrvInst_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceInstance oSI = new ServiceInstance();
                oSI.name = tbNewSrvInst.Text;
                oSI.space_guid = (string)cbSpaces.SelectedValue;//cbSpaces.SelectedValue.ToString().Substring(cbSpaces.SelectedValue.ToString().IndexOf("|") + 1);
                oSI.service_plan_guid = (string)cbServicesPlans.SelectedValue;
                oSI.Create(sUrlCloud, sToken);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        
        }

        private void cbServiceIntances_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ServiceInstance oSI = new ServiceInstance(sUrlCloud, sToken);
                oSI.Get(sUrlCloud, sToken, cbServiceIntances.SelectedValue.ToString());
                tbLog.Text = oSI._json + tbLog.Text;

                ServicePlans oSP = oSI.GetServicePlan();
                cbServicesPlans.SelectedValue = oSP.guid;
                                               
                List<ServiceKeys> l = ServiceKeys.GetList(sUrlCloud, sToken, oSI.guid, 1);
                if ((null != l) && (l.Count > 0))
                    _SK = l[0];
                else
                    _SK = null;

                _SI = oSI;
                _Srv = oSI.GetService();
                cbServices.SelectedValue = _Srv.guid;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbServicesPlans.DataSource = ServicePlans.GetListByService(sUrlCloud, sToken, cbServices.SelectedValue.ToString());
                cbServicesPlans.SelectedValue = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnNewSrvKeys_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceKeys oSK = new ServiceKeys(sUrlCloud,sToken);
                oSK.name = tbSrvKeysName.Text;
                if (null != _SI)
                {
                    oSK.service_instance_guid = _SI.guid;
                    oSK.Create();
                    tbLog.Text = oSK._json + tbLog.Text;
                    cbServiceKeys.DataSource = ServiceKeys.GetList(_SI);
                    cbServiceKeys.SelectedValue = oSK.guid;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnGetLstClassifier_Click(object sender, EventArgs e)
        {
            try
            {
                /*ServiceInstance oSI = new ServiceInstance();
                oSI.Get(sUrlCloud, sToken, cbServiceIntances.SelectedValue.ToString());

                ServiceKeys oSK = new ServiceKeys();
                List<ServiceKeys> l = ServiceKeys.GetList(sUrlCloud, sToken, oSI.guid, 1);*/
                if ((null !=_Srv) && (_Srv.label == "natural_language_classifier") && (null != _SK))
                {
                    NLC oNLC = new NLC(_SK);
                    List<NLC> n = oNLC.GetList();
                    tbLog.Text = oNLC._json + tbLog.Text;
                    lvClassifiers.Items.Clear();
                    foreach (NLC s in n)
                    {
                        ListViewItem tmp = new ListViewItem(s.classifier_id);
                        tmp.SubItems.Add(s.name);
                        tmp.SubItems.Add(s.created);
                        tmp.SubItems.Add(s.url);
                        //tmp.SubItems.Add(l[0].cred_username);
                        //tmp.SubItems.Add(l[0].cred_password);

                        tmp.SubItems.Add(_SK.cred_username);
                        tmp.SubItems.Add(_SK.cred_password);
                        lvClassifiers.Items.Add(tmp);
                    }
                }               
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnNLCTest_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (lvClassifiers.CheckedIndices.Count > 0)
                {
                    int index = lvClassifiers.CheckedIndices[0];

                    ListViewItem v = lvClassifiers.Items[index];
                    string surl = v.SubItems[3].Text;

                    NLC n = new NLC();
                    ServiceKeys oSK = new ServiceKeys();
                    oSK.cred_username = v.SubItems[4].Text;
                    oSK.cred_password = v.SubItems[5].Text;
                    if (!String.IsNullOrEmpty(tbTextClassify.Text))
                    {
                        string[] Lines = File.ReadAllLines(tbTextClassify.Text);
                        using (var reader = new StreamReader())
                        {
                            string line;
                            XmlDocument oXml = new XmlDocument();
                            XmlNode root = oXml.CreateNode(XmlNodeType.Element, "results", null);
                            while ((line = reader.ReadLine()) != null)
                            {
                                root.AppendChild(oXml.ImportNode(n.Classify(oSK, surl, line).FirstChild,true));
                            }
                            oXml.AppendChild(root);
                            oXml.Save(@"d:\tools\cloud foundry\questions.xml");
                        }
                    }
                    else
                        MessageBox.Show("A questions File should be filled");
                }*/

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnChooseFileQuestions_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.openFileDialogQuestion.ShowDialog();
               
                if (result == DialogResult.OK)
                {
                    // Set the selected file URL to the textbox
                    this.tbTextClassify.Text = this.openFileDialogQuestion.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnRnRClusters_Click(object sender, EventArgs e)
        {
            try
            {
                /*ServiceInstance oSI = new ServiceInstance(sUrlCloud, sToken);
                oSI.Get(sUrlCloud, sToken, cbServiceIntances.SelectedValue.ToString());
                tbLog.Text =+ oSI._json;

                ServicePlans oSP = oSI.GetServicePlan();
                cbServicesPlans.SelectedValue = oSP.guid;

                Service oSrv = oSI.GetService();
                cbServices.SelectedValue = oSrv.guid;*/

                if ((null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnR oRnR = new RnR(_SK);
                    oRnR.GetListClusters();
                    tbLog.Text = oRnR._json + tbLog.Text;
                    lvRnRClusters.Items.Clear();
                    foreach (RnRCluster s in oRnR.ListClusters)
                    {
                        ListViewItem tmp = new ListViewItem(s.solr_cluster_id);
                        tmp.SubItems.Add(s.cluster_name);
                        tmp.SubItems.Add(s.cluster_size);
                        tmp.SubItems.Add(s.solr_cluster_status);
                        lvRnRClusters.Items.Add(tmp);
                    }

                    /*if (oSrv.label == "retrieve_and_rank")
                    {
                       List<ServiceKeys> keys = ServiceKeys.GetList(oSI);

                       if (null != keys)
                       {
                           RnR oRnR = new RnR(keys[0]);
                           List<RnRCluster> Clusters = oRnR.GetListClusters();
                           tbLog.Text =+ oRnR._json;
                           lvRnRClusters.Items.Clear();
                           foreach (RnRCluster s in Clusters)
                           {
                               ListViewItem tmp = new ListViewItem(s.solr_cluster_id);
                               tmp.SubItems.Add(s.cluster_name);
                               tmp.SubItems.Add(s.cluster_size);
                               tmp.SubItems.Add(s.solr_cluster_status);
                               lvRnRClusters.Items.Add(tmp);
                           }
                       }*/
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnCreateRnRCluster_Click(object sender, EventArgs e)
        {
            try
            {
                if ((null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCluster oRnRCluster = new RnRCluster(_SK);
                    oRnRCluster.Create(tbRnrClusterName.Text, (string)cbRnrClusterSize.SelectedItem);
                    tbLog.Text = oRnRCluster._json + tbLog.Text;
                }
                    /*ServiceInstance oSI = new ServiceInstance(sUrlCloud, sToken);
                    oSI.Get(sUrlCloud, sToken, cbServiceIntances.SelectedValue.ToString());
                    tbLog.Text =+ oSI._json;
                    Service oSrv = oSI.GetService();

                    if (oSrv.label == "retrieve_and_rank")
                    {
                        List<ServiceKeys> keys = ServiceKeys.GetList(oSI);

                        if (null != keys)
                        {
                            RnR oRnR = new RnR(keys[0]);
                            RnRCluster oCluster = oRnR.CreateCluster(tbRnrClusterName.Text, (string)cbRnrClusterSize.SelectedValue);
                            //tbLog.Text =+ oCluster._
                        }
                    }*/
                }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private string GetClusterId()
        {
            string cluster_id = "";
            if (lvRnRClusters.CheckedIndices.Count > 0)
            {
                int index = lvRnRClusters.CheckedIndices[0];
                ListViewItem v = lvRnRClusters.Items[index];
                cluster_id = v.SubItems[0].Text;
            }

            return cluster_id;
        }

        private string GetClassifierId()
        {
            string classifier_id = "";
            if (lvClassifiers.CheckedIndices.Count > 0)
            {
                int index = lvClassifiers.CheckedIndices[0];
                ListViewItem v = lvClassifiers.Items[index];
                classifier_id = v.SubItems[0].Text;
            }

            return classifier_id;
        }

        private string GetRankerId()
        {
            string ranker_id = "";
            if (lvRnRRankers.CheckedIndices.Count > 0)
            {
                int index = lvRnRRankers.CheckedIndices[0];
                ListViewItem v = lvRnRRankers.Items[index];
                ranker_id = v.SubItems[0].Text;
            }

            return ranker_id;
        }

        private string GetDialogId()
        {
            string dialog_id = "";
            if (lvDialogs.CheckedIndices.Count > 0)
            {
                int index = lvDialogs.CheckedIndices[0];
                ListViewItem v = lvDialogs.Items[index];
                dialog_id = v.SubItems[0].Text;
            }

            return dialog_id;
        }

        private string GetRecastIntentId()
        {
            string intent_id = "";
            if (lvRecastIntents.CheckedIndices.Count > 0)
            {
                int index = lvRecastIntents.CheckedIndices[0];
                ListViewItem v = lvRecastIntents.Items[index];
                intent_id = v.SubItems[0].Text;
            }

            return intent_id;
        }

        private List<string> GetRecastExpressionId()
        {
            List<string> expression_id = null;
            if (lvRecastExpressions.CheckedIndices.Count > 0)
            {
                expression_id = new List<string>();
                foreach (int index in lvRecastExpressions.CheckedIndices)
                {                     
                    //int index = lvRecastExpressions.CheckedIndices[0];
                    ListViewItem v = lvRecastExpressions.Items[index];
                    expression_id.Add(v.SubItems[0].Text);
                }
            }

            return expression_id;
        }

        private void btnDeleteRnRCluster_Click(object sender, EventArgs e)
        {

            try
            {
                string cluster_id = GetClusterId();

                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCluster oRnRCluster = new RnRCluster(_SK);
                    oRnRCluster.solr_cluster_id = cluster_id;
                    oRnRCluster.Delete();
                    tbLog.Text = oRnRCluster._json + tbLog.Text;
                }
              
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRCreateConfig_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRConfig oRnRConfig = new RnRConfig(_SK, cluster_id, tbRnRConfigName.Text);
                    oRnRConfig.Create(tbRnRConfigFilePath.Text);

                    tbLog.Text = oRnRConfig._json + tbLog.Text;
                    cbRnRConfigs.DataSource = oRnRConfig.GetList();
                    cbRnRConfigs.SelectedText = "";
                    tbLog.Text = oRnRConfig._json + tbLog.Text;
                    cbRnRConfigs.SelectedValue = oRnRConfig.config_name;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnRnRConfigs_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRConfig oRnRConfig = new RnRConfig(_SK, cluster_id);
                    cbRnRConfigs.DataSource = oRnRConfig.GetList();

                    tbLog.Text = oRnRConfig._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRDeleteConfig_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRConfig oRnRConfig = new RnRConfig(_SK, cluster_id, (string)cbRnRConfigs.SelectedValue);
                    oRnRConfig.Delete();

                    tbLog.Text = oRnRConfig._json + tbLog.Text;
                    cbRnRConfigs.DataSource = oRnRConfig.GetList();
                    tbLog.Text = oRnRConfig._json + tbLog.Text;
                    cbRnRConfigs.SelectedText = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRCreateCollection_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCollection oRnRCollection = new RnRCollection(_SK, cluster_id, "");
                    oRnRCollection.Create(tbRnRCollectionName.Text, (string)cbRnRConfigs.SelectedValue);

                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                    cbRnRCollections.DataSource = oRnRCollection.GetList();
                    cbRnRCollections.SelectedText = oRnRCollection.collection_name;
                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRCollections_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCollection oRnRCollection = new RnRCollection(_SK, cluster_id, "");
                    cbRnRCollections.DataSource = oRnRCollection.GetList();

                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRDeleteCollection_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCollection oRnRCollection = new RnRCollection(_SK, cluster_id, (string)cbRnRCollections.SelectedValue);
                    oRnRCollection.Delete();

                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                    cbRnRCollections.DataSource = oRnRCollection.GetList();
                    
                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCollection oRnRCollection = new RnRCollection(_SK, cluster_id, (string)cbRnRCollections.SelectedValue);
                    if (cbxRnRRanker.Checked)
                        oRnRCollection.Query(tbRnRQuery.Text, GetRankerId());
                    else
                        oRnRCollection.Query(tbRnRQuery.Text);

                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRIndexing_Click(object sender, EventArgs e)
        {
            try
            {
                string cluster_id = GetClusterId();
                if (!String.IsNullOrEmpty(cluster_id) && (null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRCollection oRnRCollection = new RnRCollection(_SK, cluster_id, (string)cbRnRCollections.SelectedValue);
                    
                    oRnRCollection.Indexing(File.ReadAllBytes(tbRnRIndexFilePath.Text));
                    tbLog.Text = oRnRCollection._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRBrowseIndexFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.openFileDialogRnRIndexFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set the selected file URL to the textbox
                    this.tbRnRIndexFilePath.Text = this.openFileDialogRnRIndexFile.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRBrowseConfigFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.openFileDialogRnRConfigFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set the selected file URL to the textbox
                    this.tbRnRConfigFilePath.Text = this.openFileDialogRnRConfigFile.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRRankers_Click(object sender, EventArgs e)
        {
            try
            {
                if ((null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRRanker oRanker = new RnRRanker(_SK);                    
                    List<RnRRanker> r = oRanker.GetList();
                    tbLog.Text = oRanker._json + tbLog.Text;
                    lvRnRRankers.Items.Clear();

                    foreach (RnRRanker ranker in r)
                    {
                        ListViewItem tmp = new ListViewItem(ranker.ranker_id);
                        tmp.SubItems.Add(ranker.name);
                        tmp.SubItems.Add(ranker.created);
                        lvRnRRankers.Items.Add(tmp);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnNLCCreateClassifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ((null != _Srv) && (_Srv.label == "natural_language_classifier") && (null != _SK))
                {
                    NLC oNLC = new NLC(_SK);
                    oNLC.Create(tbNLCClassifierName.Text, (string)cbNLCLanguage.SelectedItem, tbNLCFilePath.Text);
                    tbLog.Text = oNLC._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnNLCBrowseTrainingFile_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialogNLCTrainingFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.tbNLCFilePath.Text = this.openFileDialogNLCTrainingFile.FileName;
            }
        }

        private void btnNLCDeleteClassifier_Click(object sender, EventArgs e)
        {
            try
            {
                string classifier_id = GetClassifierId();
                if (!string.IsNullOrEmpty(classifier_id) && (null != _Srv) && (_Srv.label == "natural_language_classifier") && (null != _SK))
                {
                    NLC oNLC = new NLC(_SK);
                    oNLC.classifier_id = classifier_id;
                    oNLC.Delete();
                    tbLog.Text = oNLC._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnListApplications_Click(object sender, EventArgs e)
        {
            try
            {
                App oApp = new App(sUrlCloud, sToken);
                cbApps.DataSource = oApp.GetList(sUrlCloud, sToken);
                tbLog.Text = oApp._json + tbLog.Text;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            try
            {
                App oApp = new App(sUrlCloud, sToken);
                oApp.guid = (string)cbApps.SelectedValue;
                oApp.Delete();
                cbApps.DataSource = oApp.GetList(sUrlCloud, sToken);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDeleteServiceInstance_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceInstance oSI = _SI;
                oSI.Delete(sUrlCloud, sToken);
                _SI = null;
                cbServiceIntances.DataSource =  ServiceInstance.GetList(sUrlCloud, sToken);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnListServiceKeys_Click(object sender, EventArgs e)
        {
            try
            {                                
                if(null != _SI)
                    cbServiceKeys.DataSource = ServiceKeys.GetList(_SI);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDeleteServiceKeys_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SK != null)
                {
                    _SK.Delete();
                    _SK = null;
                }

                if (null != _SI)
                {
                    cbServiceKeys.DataSource = ServiceKeys.GetList(_SI);
                    cbServiceKeys.SelectedValue = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void cbServiceKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbServiceKeys.SelectedIndex != -1)
                {
                    ServiceKeys oSK = new ServiceKeys(sUrlCloud, sToken);
                    oSK.guid = (string)cbServiceKeys.SelectedValue;
                    oSK.Get();
                    _SK = oSK;
                    tbLog.Text = oSK._json + tbLog.Text;
                }
                else
                    _SK = null;                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRCreateRanker_Click(object sender, EventArgs e)
        {
            try
            {
                if ((null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))                
                {
                    RnRRanker oRanker = new RnRRanker(_SK);
                    oRanker.Create(tbRnRRankerName.Text, tbRnRRankerFilePath.Text);
                    tbLog.Text = oRanker._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRDeleteRanker_Click(object sender, EventArgs e)
        {
            try
            {
                string ranker_id = GetRankerId();
                if ((!string.IsNullOrEmpty(ranker_id)) &&(null != _Srv) && (_Srv.label == "retrieve_and_rank") && (null != _SK))
                {
                    RnRRanker oRanker = new RnRRanker(_SK);
                    oRanker.ranker_id = ranker_id;
                    oRanker.Delete();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRnRBrowseRankerFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.openFileDialogRnRRankerFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set the selected file URL to the textbox
                    this.tbRnRRankerFilePath.Text = this.openFileDialogRnRRankerFile.FileName;
                }               
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnNLCClassify_Click(object sender, EventArgs e)
        {
            try
            {
                string classifier_id = GetClassifierId();
                if ((!string.IsNullOrEmpty(classifier_id)) && (null != _Srv) && (_Srv.label == "natural_language_classifier") && (null != _SK))
                {
                    NLC oNLC = new NLC(_SK);
                    oNLC.classifier_id = classifier_id;
                    oNLC.Classify(tbNLCQuestion.Text);
                    tbLog.Text = oNLC.classes.ToString() + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnListDialogs_Click(object sender, EventArgs e)
        {
            try
            {
                string dialog_id = GetDialogId();
                if ((!string.IsNullOrEmpty(dialog_id)) && (null != _Srv) && (_Srv.label == "natural_language_classifier") && (null != _SK))
                {
                    Dialog oDialog = new Dialog(_SK);
                    
                    List<Dialog> r = oDialog.GetList();
                    tbLog.Text = oDialog._json + tbLog.Text;
                    lvDialogs.Items.Clear();

                    foreach (Dialog dialog in r)
                    {
                        ListViewItem tmp = new ListViewItem(dialog.dialog_id);
                        tmp.SubItems.Add(dialog.name);
                        lvDialogs.Items.Add(tmp);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnListServiceInstance_Click(object sender, EventArgs e)
        {
            try
            {
                cbServiceIntances.DataSource = ServiceInstance.GetList(sUrlCloud, sToken);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }





        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recast AI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecastAI_Click(object sender, EventArgs e)
        {
            try
            {
                //req token : 5fbe8ba474fcbc1f0c61d03da65ec274
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = Bot.Get(oUser, tbRecastBotSlug.Text, tbRecastBotDevToken.Text);

                tbRecastBotId.Text = oBot.id;
                tbRecastBotLanguage.Text = oBot.language.isocode;
                tbRecastBotStrict.Text = oBot.strictness.ToString();
                tbRecastBotDescription.Text = oBot.description;
                cbxRecastBotPublic.Checked = oBot._public;

                lvRecastIntents.Items.Clear();
                foreach (RecastAI.Intent intent in oBot.intents)
                {
                    ListViewItem tmp = new ListViewItem(intent.id);
                    tmp.SubItems.Add(intent.name);
                    tmp.SubItems.Add(intent.slug);
                    tmp.SubItems.Add(intent.description);
                    lvRecastIntents.Items.Add(tmp);
                }

                tbLog.Text = oBot._json + tbLog.Text;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        
        private void btnRecastBotUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //req token : 5fbe8ba474fcbc1f0c61d03da65ec274
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);
                oBot.description = tbRecastBotDescription.Text;
                oBot.strictness = !String.IsNullOrEmpty(tbRecastBotStrict.Text) ? Convert.ToInt32(tbRecastBotStrict.Text) : 0;
                oBot._public = cbxRecastBotPublic.Checked;
                oBot.language.isocode = tbRecastBotLanguage.Text;

                lvRecastIntents.Items.Clear();
                foreach (RecastAI.Intent intent in oBot.intents)
                {
                    ListViewItem tmp = new ListViewItem(intent.id);
                    tmp.SubItems.Add(intent.name);
                    tmp.SubItems.Add(intent.slug);
                    tmp.SubItems.Add(intent.description);
                    lvRecastIntents.Items.Add(tmp);
                }

                tbLog.Text = oBot._json + tbLog.Text;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }       


        private void ReloadListExpressions(Bot oBot)
        {
            lvRecastExpressions.Items.Clear();
            string intent_id = GetRecastIntentId();
            if (!string.IsNullOrEmpty(intent_id))
            {
                RecastAI.Intent oIntent = new Intent(intent_id);
                oIntent.GetListExpressions(oBot);
                tbLog.Text = oIntent._json + tbLog.Text;

                foreach (RecastAI.Expression exp in oIntent.expressions)
                {
                    ListViewItem tmp = new ListViewItem(exp.id);
                    tmp.SubItems.Add(exp.source);
                    tmp.SubItems.Add(exp.language.isocode);
                    lvRecastExpressions.Items.Add(tmp);
                }
            }
        }
        private void btnRecastExpressions_Click(object sender, EventArgs e)
        {
            try
            {
                //req token : 5fbe8ba474fcbc1f0c61d03da65ec274
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                ReloadListExpressions(oBot);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastBrowseExpFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.openFileDialogRecastExpFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set the selected file URL to the textbox
                    this.tbRecastLoadExpFilePath.Text = this.openFileDialogRecastExpFile.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastLoadExpressions_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);
                                
                string intent_id = GetRecastIntentId();
                if (!string.IsNullOrEmpty(intent_id))
                {
                    RecastAI.Intent oIntent = new Intent(intent_id);
                    oIntent.AddExpressions(tbRecastLoadExpFilePath.Text);
                    oIntent.BulkCreateExpressions(oBot);
                    tbLog.Text = oIntent._json + tbLog.Text;
                    ReloadListExpressions(oBot);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastIntentGet_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                lvRecastExpressions.Items.Clear();
                string intent_id = GetRecastIntentId();
                if (!string.IsNullOrEmpty(intent_id))
                {
                    RecastAI.Intent oIntent = new Intent(intent_id);
                    oIntent.Get(oBot);
                    tbLog.Text = oIntent._json + tbLog.Text;

                    tbRecastIntentId.Text = oIntent.id;
                    tbRecastIntentName.Text = oIntent.name;
                    tbRecastIntentSlug.Text = oIntent.slug;
                    tbRecastIntentDesc.Text = oIntent.description;

                    foreach (RecastAI.Expression exp in oIntent.expressions)
                    {
                        ListViewItem tmp = new ListViewItem(exp.id);
                        tmp.SubItems.Add(exp.source);
                        tmp.SubItems.Add(exp.language.isocode);
                        lvRecastExpressions.Items.Add(tmp);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastIntentCreate_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                RecastAI.Intent oIntent = new Intent(null);
                oIntent.name = tbRecastIntentName.Text;
                oIntent.slug = tbRecastIntentSlug.Text;
                oIntent.description = tbRecastIntentDesc.Text;
                oIntent.Create(oBot);

                tbLog.Text = oIntent._json + tbLog.Text;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastIntentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                string intent_id = GetRecastIntentId();
                if (!string.IsNullOrEmpty(intent_id))
                {
                    RecastAI.Intent oIntent = new Intent(intent_id);
                    oIntent.id = tbRecastIntentId.Text;
                    oIntent.name = tbRecastIntentName.Text;
                    oIntent.slug = tbRecastIntentSlug.Text;
                    oIntent.description = tbRecastIntentDesc.Text;

                    oIntent.Update(oBot);
                    tbLog.Text = oIntent._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastIntentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                lvRecastExpressions.Items.Clear();
                string intent_id = GetRecastIntentId();
                if (!string.IsNullOrEmpty(intent_id))
                {
                    RecastAI.Intent oIntent = new Intent(intent_id);
                    oIntent.Delete(oBot);
                    tbLog.Text = oIntent._json + tbLog.Text;                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastExpCreate_Click(object sender, EventArgs e)
        {
            try
            { 
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                string intent_id = GetRecastIntentId();
                if (!string.IsNullOrEmpty(intent_id))
                {
                    RecastAI.Expression oExp = new Expression(null,tbRecastExpSource.Text,tbRecastExpLanguage.Text);
                    oExp.Create(oBot, intent_id);
                    tbLog.Text = oExp._json + tbLog.Text;
                    ReloadListExpressions(oBot);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
}

        private void btnRecastExpUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                string intent_id = GetRecastIntentId();
                string exp_id = GetRecastExpressionId()!=null ? GetRecastExpressionId()[0] : "";
                if (!string.IsNullOrEmpty(intent_id) && !string.IsNullOrEmpty(exp_id))
                {
                    RecastAI.Expression oExp = new Expression(exp_id,tbRecastExpSource.Text, tbRecastExpLanguage.Text);
                    oExp.Update(oBot,intent_id);
                    tbLog.Text = oExp._json + tbLog.Text;
                    ReloadListExpressions(oBot);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
}

        private void btnRecastExpDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                string intent_id = GetRecastIntentId();
                List<string> exp_id = GetRecastExpressionId();
                if (!string.IsNullOrEmpty(intent_id) && null != exp_id)
                {
                    foreach (string s in exp_id)
                    {
                        RecastAI.Expression oExp = new Expression(s, tbRecastExpSource.Text, tbRecastExpLanguage.Text);
                        oExp.Delete(oBot, intent_id);
                        tbLog.Text = oExp._json + tbLog.Text;                        
                    }
                    ReloadListExpressions(oBot);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        

        private void cbxRecastExpSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxRecastExpSelectAll.Checked)
                {
                    for (int i =0; i < lvRecastExpressions.Items.Count; i++)
                    {
                        lvRecastExpressions.Items[i].Checked = true;
                    }
                }
                else
                {
                    for (int i = 0; i < lvRecastExpressions.Items.Count; i++)
                    {
                        lvRecastExpressions.Items[i].Checked = false;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        
        private void btnRecastConversation_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                if (!string.IsNullOrEmpty(tbRecastConvMessage.Text))
                {
                    Conversation oConv = new Conversation();
                    oConv.Converse(oBot,tbRecastConvMessage.Text,tbRecastConvId.Text);
                    tbLog.Text = oConv._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnRecastAnalyzeText_Click(object sender, EventArgs e)
        {
            try
            {
                User oUser = new User(tbRecastUser.Text);
                Bot oBot = new Bot(oUser, tbRecastBotId.Text, "", tbRecastBotSlug.Text, tbRecastRequestToken.Text, tbRecastBotDevToken.Text);

                if(!string.IsNullOrEmpty(tbRecastAnalyzeText.Text))
                {
                    oBot.AnalyzeText(tbRecastAnalyzeText.Text);
                    tbLog.Text = oBot._json + tbLog.Text;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnWCSWorkspaceBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.openFileDialogWCSFilePath.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set the selected file URL to the textbox
                    this.tbWCSWorkspaceFilePath.Text = this.openFileDialogWCSFilePath.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnWCSDeleteWorkspace_Click(object sender, EventArgs e)
        {

        }

        private void btnWCSListWorkspaces_Click(object sender, EventArgs e)
        {
            if ((null != _Srv) && (_Srv.label == "conversation") && (null != _SK))
            {
                WCS oWCS = new WCS(_SK);                
                lvWCSWorkspaces.Items.Clear();
                foreach (WCS s in oWCS.GetList())
                {
                    ListViewItem tmp = new ListViewItem(s.workspace_id);
                    tmp.SubItems.Add(s.name);
                    tmp.SubItems.Add(s.language);
                    tmp.SubItems.Add(s.description);
                    tmp.SubItems.Add(s.created);
                    lvWCSWorkspaces.Items.Add(tmp);
                }               
            }
        }

        private void btnWCSWorkspaceCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
