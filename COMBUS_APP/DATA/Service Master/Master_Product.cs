using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Service_Master
{
    public class Master_Product
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

        public List<Product_GetProductAll_Result> Get_ProductAll()
        {
            return this.ContextEntity.Product_GetProductAll().ToList();
        }

        public List<Product_GetProductName_Result> Get_ProductName(string Name)
        {
            return this.ContextEntity.Product_GetProductName(Name).ToList();
        }

        public List<Product_GetProductTime_Result> Get_ProductTime(DateTime Timein,DateTime Timeout)
        {
            return this.ContextEntity.Product_GetProductTime(Timein, Timeout).ToList();
        }

        public void Del_Product(int ID)
        {
            this.ContextEntity.Product_DelProduct(ID);
        }

        public void Edit_Product(int ID
                                    ,string ProductName
                                    ,Decimal Weight
                                    ,int type
                                    ,DateTime TimeIn
                                    ,DateTime TimeOut)
        {
            this.ContextEntity.Product_EditProduct(ID,ProductName,Weight,type,TimeIn,TimeOut);
        }

        public void Add_Product(string ProductName
                                ,Decimal Weight
                                ,int type
                                ,int ComID
                                ,DateTime TimeIn
                                ,DateTime TimeOut)
        {
            this.ContextEntity.Product_AddProduct(ProductName
                                                    ,Weight
                                                    ,type
                                                    ,ComID
                                                    ,TimeIn
                                                    ,TimeOut);
        }
    }
}
