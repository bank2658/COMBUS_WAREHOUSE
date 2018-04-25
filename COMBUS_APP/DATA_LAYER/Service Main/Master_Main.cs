using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LAYER.Service_Main
{
    public class Master_Main
    {
        private EFContainer _ContextEntity;
        public EFContainer ContextEntity
        {
            get
            {
                if(_ContextEntity == null)
                {
                    _ContextEntity = new EFContainer();
                }
                return _ContextEntity;
            }
            set
            {
                _ContextEntity = value;
            }
        }

        public List<Main_CheckLogin_Result> check_Login(string userName)
        {

                return this.ContextEntity.Main_CheckLogin(userName).ToList();

        }
    }
}
