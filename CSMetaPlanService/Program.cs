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
            /*
            MuveletResponse muveletResponse =
                aRMetaPlanServices.SaveMuvelet(new MuveletRequest()
            {
                Muvelet = new Muvelet()
                {
                    ValaszTipus = 7
                    , GUID = "guid"
                }
            });

            GetByGUIDMuveletResponse getByGUIDMuveletResponse =
                aRMetaPlanServices.GetByGUIDMuvelet(new GetByGUIDMuveletRequest()
                {
                    GUID = "guid"
                });

            SetMuveletResponse setMuveletResponse =
                new ARMetaPlanCompositeServices().SetMuvelet(new SetMuveletRequest()
                {
                    Muvelet = new Muvelet()
                    {
                        GUID = "teszt guid"
                        ,
                        ValaszTipus = 67
                    }
                });*/

            SaveChangesMuveletByGUIDResponse saveChangesMuveletResponse =
                new ARMetaPlanCompositeServices().SaveChangesMuveletByGUID(new SaveChangesMuveletByGUIDRequest()
                {
                    Muvelet = new Muvelet()
                    {
                        GUID = "halandzsa"
                        ,
                        ValaszTipus = 152
                    }
                });
        }
    }
}
