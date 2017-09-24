using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BluemixDeployment
{
    class BaseRESTServices
    {
        public BaseRESTServices()
        { }
        public BaseRESTServices(ServiceKeys SK)
        {
            _SK = SK;            
        }

        public string _json { get; set; }
        public ServiceKeys _SK { get; set; }
      



    }
}
