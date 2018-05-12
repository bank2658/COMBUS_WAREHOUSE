using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Service_Transection
{
    public class Master_EmployeeManagement
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

        public Employee_GetTimeWork_Result Get_TimeWork( DateTime dateIN, int id)
        {
            return this.ContextEntity.Employee_GetTimeWork(dateIN, id).FirstOrDefault();
        }
    }
}
