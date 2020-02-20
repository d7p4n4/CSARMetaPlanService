using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMetaPlanService
{
    class Program
    {
        static void Main(string[] args)
        {
            ARMetaPlanServices aRMetaPlanServices = new ARMetaPlanServices();

            MuveletResponse muveletResponse =
                aRMetaPlanServices.SaveMuvelet(new MuveletRequest()
            {
                Muvelet = new Muvelet()
                {
                    ValaszTipus = 7
                }
            });
        }
    }
}
