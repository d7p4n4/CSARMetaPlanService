using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMetaPlanService
{
    public class ARMetaPlanCompositeServices
    {
        public SaveChangesMuveletResponse SaveChangesMuvelet(SaveChangesMuveletRequest request)
        {
            SaveChangesMuveletResponse response = new SaveChangesMuveletResponse();

            try
            {
                IsExistMuveletByIdResponse isExistMuveletResponse =
                    new ARMetaPlanServices().IsExistMuvelet(new IsExistMuveletByIdRequest()
                    {
                        Muvelet = request.Muvelet
                    });

                if (isExistMuveletResponse.IsExist)
                {
                    UpdateMuveletByIdResponse updateMuveletResponse =
                        new ARMetaPlanServices().UpdateMuvelet(new UpdateMuveletByIdRequest()
                        {
                            NewMuvelet = request.Muvelet
                        });
                }
                else
                {
                    MuveletResponse muveletResponse =
                        new ARMetaPlanServices().SaveMuvelet(new MuveletRequest()
                        {
                            Muvelet = request.Muvelet
                        });
                }
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }
        

        public SetMuveletResponse SetMuvelet(SetMuveletRequest request)
        {
            SetMuveletResponse response = new SetMuveletResponse();

            try
            {
                MuveletResponse muveletResponse =
                    new ARMetaPlanServices().SaveMuvelet(new MuveletRequest()
                    {
                        Muvelet = request.Muvelet
                    });

                GetByGUIDMuveletResponse getByGUIDMuveletResponse =
                    new ARMetaPlanServices().GetByGUIDMuvelet(new GetByGUIDMuveletRequest()
                    {
                        GUID = request.Muvelet.GUID
                    });

                response.Muvelet = getByGUIDMuveletResponse.Muvelet;
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
