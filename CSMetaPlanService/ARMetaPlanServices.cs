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

        public GetByIdMuveletResponse GetByIdMuvelet(GetByIdMuveletRequest request)
        {
            GetByIdMuveletResponse response = new GetByIdMuveletResponse();

            try
            {
                Muvelet getMuvelet = new ARMetaPlanDBCapMethods().GetByIdMuvelet(request.Muvelet);

                response.Muvelet = getMuvelet;
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public IsExistMuveletByIdResponse IsExistMuveletById(IsExistMuveletByIdRequest request)
        {
            IsExistMuveletByIdResponse response = new IsExistMuveletByIdResponse();

            try
            {
                bool isExist = new ARMetaPlanDBCapMethods().IsExistMuveletById(request.Muvelet);

                response.IsExist = isExist;
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public IsExistMuveletByGUIDResponse IsExistMuveletByGUID(IsExistMuveletByGUIDRequest request)
        {
            IsExistMuveletByGUIDResponse response = new IsExistMuveletByGUIDResponse();

            try
            {
                bool isExist = new ARMetaPlanDBCapMethods().IsExistMuveletByGUID(request.Muvelet);

                response.IsExist = isExist;
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public UpdateMuveletByIdResponse UpdateMuveletById(UpdateMuveletByIdRequest request)
        {
            UpdateMuveletByIdResponse response = new UpdateMuveletByIdResponse();

            try
            {
                new ARMetaPlanDBCapMethods().UpdateMuveletById(request.NewMuvelet);
               
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public UpdateMuveletByIdResponse UpdateMuveletByGUID(UpdateMuveletByIdRequest request)
        {
            UpdateMuveletByIdResponse response = new UpdateMuveletByIdResponse();

            try
            {
                new ARMetaPlanDBCapMethods().UpdateMuveletByGUID(request.NewMuvelet);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public MuveletResponse SaveMuvelet(MuveletRequest request)
        {
            MuveletResponse response = new MuveletResponse();

            try
            {
                    new ARMetaPlanDBCapMethods().InsertMuvelet(request.Muvelet);

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }

        public GetByGUIDMuveletResponse GetByGUIDMuvelet(GetByGUIDMuveletRequest request)
        {
            GetByGUIDMuveletResponse response = new GetByGUIDMuveletResponse();

            try
            {
                response.Muvelet = new ARMetaPlanDBCapMethods().GetByGUIDMuvelet(request.GUID);

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
