using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluemixDeployment
{
    class BuildPack
    {
        public string guid { get; set; }
        public string name { get; set; }

        public string filename { get; set; }

        public string created_at { get; set; }

        public string updated_at { get; set; }

        static public List<BuildPack> GetList(string sUrlCloud,string sToken)
        {
            Tools.HttpReturn ret = Tools.HttpRequest(sUrlCloud + "/v2/buildpacks", "GET", null, 0, null, "", "", sToken, null);
            /*DataTable dt = new DataTable();
            dt.Columns.Add("Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Guid", System.Type.GetType("System.String"));
            dt.Columns.Add("Created", System.Type.GetType("System.String"));
            dt.Columns.Add("Updated", System.Type.GetType("System.String"));
            dt.Columns.Add("FileName", System.Type.GetType("System.String"));*/
            List<BuildPack> LstBP = new List<BuildPack>();
            for (int i = 0; i < ret._json.total_results.Value; i++)
            {
                BuildPack Tmp = new BuildPack();
                Tmp.name = ret._json.resources[i].entity.name;
                Tmp.guid = ret._json.resources[i].metadata.guid;
                Tmp.created_at  = ret._json.resources[i].metadata.created_at;
                Tmp.updated_at = ret._json.resources[i].metadata.updated_at;
                Tmp.filename = ret._json.resources[i].entity.filename;

                LstBP.Add(Tmp);
            }
            return LstBP;
        }
               
    }
}
