using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Service_Master
{
    public class Master_Company
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

        public List<Company_GetCompany_Result> Get_Company(string Company)
        {
            if(Company == string.Empty)
            {
                return this.ContextEntity.Company_GetCompany(null).ToList();
            }
            else
            {
                return this.ContextEntity.Company_GetCompany(Company).ToList();
            }
           
        }

        public void Del_Company(int ID)
        {
            this.ContextEntity.Company_DelCompany(ID);
        }

        public void Add_Company(string Companyname,string Phone,string Address)
        {
            this.ContextEntity.Company_AddCompany(Companyname,Phone,Address);
        }

        public void Edit_Company(int ID,string Companyname,string Phone,string Address)
        {
            this.ContextEntity.Company_EditCompany(ID,Companyname,Phone,Address);
        }
    }
}
