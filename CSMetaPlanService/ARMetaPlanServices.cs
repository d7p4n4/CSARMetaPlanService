using CSARMetaPlan.Class;
using CSARMetaPlanDBCap;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMetaPlanService
{
    class ARMetaPlanServices
    {

        public MuveletResponse SaveMuvelet(MuveletRequest request)
        {
            MuveletResponse response = new MuveletResponse();

            try
            {
                    new ARMetaPlanDBCapMethods().SaveMuvelet(request.Muvelet);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

    }
}
