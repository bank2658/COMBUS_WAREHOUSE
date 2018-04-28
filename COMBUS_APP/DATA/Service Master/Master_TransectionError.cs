using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Service_Master
{
    public class Master_TransectionError
    {
        private EF _ContextEntity;
        public EF ContextEntity
        {
            get
            {
                if (_ContextEntity == null)
                {
                    _ContextEntity = new EF();
                }
                return _ContextEntity;
            }
            set
            {
                _ContextEntity = value;
            }
        }

        public List<Main_Get_TransectionError_Result> Get_TranAll()
        {
            return this.ContextEntity.Main_Get_TransectionError(null, null).ToList();
        }

        public List<Main_Get_TransectionError_Result> Get_TranFrom(DateTime dt)
        {
            return this.ContextEntity.Main_Get_TransectionError(dt, null).ToList();

        }

        public List<Main_Get_TransectionError_Result> Get_TranFromTo(DateTime dtFrom, DateTime dtTo)
        {
            return this.ContextEntity.Main_Get_TransectionError(dtFrom, dtTo).ToList();

        }

        public void Log_Error(Exception ex,string Screen,string userName)
        {
            this.ContextEntity.Main_Log_TransectionError(ex.ToString(), Screen, userName);
        }
    }
}
