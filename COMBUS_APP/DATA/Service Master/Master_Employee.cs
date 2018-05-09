using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Service_Master
{
    public class Master_Employee
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

        public List<Employee_GetEmpName_Result> Get_EmpName(string Name)
        {
            return this.ContextEntity.Employee_GetEmpName(Name).ToList();
        }

        public void Del_Emp(int ID)
        {
            this.ContextEntity.Emploee_DelEmp(ID);
        }

        public void Edit_Emp(int ID
                                , string Fname
                                , string Lname
                                , int Age
                                , string Address
                                , string Permistion
                                , string Username
                                , string Pass)
        {
            this.ContextEntity.Emploee_EditEmp(ID
                                                , Fname
                                                , Lname
                                                , Age
                                                , Address
                                                , Permistion
                                                , Username
                                                , Pass);
        }
    }
}
