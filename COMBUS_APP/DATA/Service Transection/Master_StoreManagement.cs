using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Service_Transection
{
    public class Master_StoreManagement
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

        public List<Store_GetListbank_Result> Get_Listbank()
        {
            return this.ContextEntity.Store_GetListbank().ToList();
        }
        public List<Store_GetListcompany_Result> Get_Listcompany()
        {
            return this.ContextEntity.Store_GetListcompany().ToList();
        }
        public List<Store_GetListproduct_Result> Get_Listproduct(int bankid)
        {
            return this.ContextEntity.Store_GetListproduct(bankid).ToList();
        }
        public List<Store_GetListproductNULL_Result> Get_ListproductNULL(int bankid)
        {
            return this.ContextEntity.Store_GetListproductNULL(bankid).ToList();
        }
        public List<Store_GetListrock_Result> Get_Listrock(int Bankid)
        {
            return this.ContextEntity.Store_GetListrock(Bankid).ToList();
        }
        public List<Store_GetPercentrock_Result> Get_Percentrock()
        {
            return this.ContextEntity.Store_GetPercentrock().ToList();
        }

        public List<Store_GetListCpAndPd_Result> Get_ListCpAndPd()
        {
            return this.ContextEntity.Store_GetListCpAndPd().ToList();
        }

        public void Add_Stock(int productID,int bankID, int bay, int level, string statusInStock, string dateIN, string dateOUT, string createBy)
        {
            this.ContextEntity.Store_AddStock(productID,bankID,bay,level,statusInStock,dateIN,dateOUT,createBy).ToString();
        }
        public void Edit_Stock(int stockID, int productID, int bankID, int bay, int level, string statusInStock, string dateIN, string dateOUT, string createBy)
        {
            this.ContextEntity.Store_EditStock(stockID,productID,bankID,bay,level,statusInStock, dateIN, dateOUT, createBy);
        }
        public void Del_Stock(int id)
        {
            this.ContextEntity.Store_DelStock(id);
        }
    }
}
