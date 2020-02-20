using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMetaPlanService
{
    public class GetByGUIDMuveletRequest : Ac4yServiceRequest
    {
        public string GUID { get; set; }
    }
}
