using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LAYER.Service_Master
{
    public class Master_TransectionError
    {

        private Model_ConnectionContainer _ContextEntity;
        public Model_ConnectionContainer ContextEntity
        {
            get
            {
                if (_ContextEntity == null)
                {
                    _ContextEntity = new Model_ConnectionContainer();
                }
                return _ContextEntity;
            }
            set
            {
                _ContextEntity = value;
            }
        }

        //public List<Get_transectionError_Result> Get_TransectionError(DateTime FromDate,DateTime ToDate)
        //{
        //    try
        //    {
        //        return this.ContextEntity.Get_transectionError(FromDate, ToDate).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}
        

