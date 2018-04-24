using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LAYER.Service_Master
{
    public class Master_Company
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

        public List<Get_Company_Result> Get_Company()
        {
                return this.ContextEntity.Get_Company().ToList();          
        }
    }
}
