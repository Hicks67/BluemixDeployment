using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluemixDeployment;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class App : BaseObject
    {
        public App(dynamic json, string sUrlCloud, string sToken) : base(sUrlCloud, sToken)
        {
            Load(json);
        }

        public App(string sUrlCloud, string sToken) : base(sUrlCloud, sToken) { }

        public string guid { get; set; } //"guid": "1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string url { get; set; } //"url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a",
        public string created_at { get; set; } //"created_at": "2017-08-07T22:29:57Z",
        public string updated_at { get; set; } //"updated_at": "2017-08-07T22:29:57Z"
        public string name { get; set; } //"name": "AppJava1",
        public bool production { get; set; } //"production": false,
        public string space_guid { get; set; } //"space_guid": "b421ef1c-f2b9-446d-b257-41039e21ca23",
        public string stack_guid { get; set; } //"stack_guid": "423dd340-c07e-44c2-b7fb-601c10fd32d3",
        public string buildpack { get; set; } //"buildpack": null,
        public string detected_buildpack { get; set; } //"detected_buildpack": null,
        public string detected_buildpack_guid { get; set; } //"detected_buildpack_guid": null,
        public string environment_json { get; set; } //"environment_json": { },
        public string memory { get; set; } //"memory": 512,
        public string instances { get; set; } //"instances": 1,
        public string disk_quota { get; set; } //"disk_quota": 1024,
        public string state { get; set; } //"state": "STOPPED",
        public string version { get; set; } //"version": "36c8f6b7-d564-4b80-9582-e76857303039",
        public string command { get; set; } //"command": null,
        public bool console { get; set; } //"console": false,
        public string debug { get; set; } //"debug": null,
        public string staging_task_id { get; set; } //"staging_task_id": null,
        public string package_state { get; set; } //"package_state": "PENDING",
        public string health_check_type { get; set; } //"health_check_type": "port",
        public string health_check_timeout { get; set; } //"health_check_timeout": null,
        public string health_check_http_endpoint { get; set; } //"health_check_http_endpoint": null,
        public string staging_failed_reason { get; set; } //"staging_failed_reason": null,
        public string staging_failed_description { get; set; } //"staging_failed_description": null,
        public bool diego { get; set; } //"diego": true,
        public string docker_image { get; set; } //"docker_image": null,
        public string package_updated_at { get; set; } //"package_updated_at": "2017-08-07T22:29:58Z",
        public string detected_start_command { get; set; } //"detected_start_command": "",
        public string enable_ssh { get; set; } //"enable_ssh": true,
        //public string docker_credentials_json { get; set; } //"docker_credentials_json": {"redacted_message": "[PRIVATE DATA HIDDEN]"    },
        //public string ports { get; set; } //"ports": [ 8080],
        public string space_url { get; set; } //"space_url": "/v2/spaces/b421ef1c-f2b9-446d-b257-41039e21ca23",
        public string stack_url { get; set; } //"stack_url": "/v2/stacks/423dd340-c07e-44c2-b7fb-601c10fd32d3",
        public string routes_url { get; set; } //"routes_url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a/routes",
        public string events_url { get; set; } //"events_url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a/events",
        public string service_bindings_url { get; set; } //"service_bindings_url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a/service_bindings",
        public string route_mappings_url { get; set; } //"route_mappings_url": "/v2/apps/1b0b1618-2a05-413d-a2e8-5c411c08854a/route_mappings"


        public void Load(dynamic json)
        {
            //metadata
            guid = json.metadata.guid;
            url = json.metadata.url;
            created_at = json.metadata.created_at;
            updated_at = json.metadata.updated_at;

            //entity
            name = json.entity.name;
            production = json.entity.production;
            space_guid = json.entity.space_guid;
            stack_guid = json.entity.stack_guid;
            buildpack = json.entity.buildpack;
            detected_buildpack = json.entity.detected_buildpack;
            detected_buildpack_guid = json.entity.detected_buildpack_guid;
            //environment_json = json.entity.environment_json;
            memory = json.entity.memory;
            instances = json.entity.instances;
            disk_quota = json.entity.disk_quota;
            state = json.entity.state;
            version = json.entity.version;
            command = json.entity.command;
            console = json.entity.console;
            debug = json.entity.debug;
            staging_task_id = json.entity.staging_task_id;
            package_state = json.entity.package_state;
            health_check_type = json.entity.health_check_type;
            health_check_timeout = json.entity.health_check_timeout;
            health_check_http_endpoint = json.entity.health_check_http_endpoint;
            staging_failed_reason = json.entity.staging_failed_reason;
            staging_failed_description = json.entity.staging_failed_description;
            diego = json.entity.diego;
            docker_image = json.entity.docker_image;
            package_updated_at = json.entity.package_updated_at;
            detected_start_command = json.entity.detected_start_command;
            enable_ssh = json.entity.enable_ssh;
            space_url = json.entity.space_url;
            stack_url = json.entity.stack_url;
            routes_url = json.entity.routes_url;
            events_url = json.entity.events_url;
            service_bindings_url = json.entity.service_bindings_url;
            route_mappings_url = json.entity.route_mappings_url;       

        }

        public string GetJson()
        {
            JObject rss = new JObject(
                new JProperty("name", name),
                new JProperty("space_guid", space_guid),
                new JProperty("buildpack", buildpack),
                new JProperty("diego", true));
 
            return rss.ToString();
        }

        public void Create()
        {
            string sUrl = _sUrlCloud + "/v2/apps";            
            Tools.HttpRequest(sUrl, "POST", Encoding.UTF8.GetBytes(GetJson()), 0, "application/json", "", "", _sToken);
        }

        public void Delete()
        {
            if (!String.IsNullOrEmpty(guid))
            {
                Tools.HttpRequest(_sUrlCloud + "/v2/apps/" + guid, "DELETE", null, 0, null, "", "", _sToken);
            }
        }

        public List<App> GetList(string sUrlCloud, string sToken)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(_sUrlCloud + "/v2/apps", "GET", null, 0, null, "", "", _sToken);

            List<App> ListApps = new List<App>();
            for (int i = 0; i < ret._json.total_results.Value; i++)
            {
                App Tmp = new App(ret._json.resources[i], _sUrlCloud,_sToken);
                ListApps.Add(Tmp);
            }

            return ListApps;
        }
    }
}
