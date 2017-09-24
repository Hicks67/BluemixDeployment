using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluemixDeployment
{
    class BaseObject
    {

        public BaseObject()
        { }
        public BaseObject(string sUrlCloud, string sToken)
        {
            _sUrlCloud = sUrlCloud;
            _sToken = sToken;
        }


        public string _json { get; set; }
        public string _sUrlCloud { get; set; }
        public string _sToken { get; set; }
    }
}
