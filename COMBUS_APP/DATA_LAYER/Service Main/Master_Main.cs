using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LAYER.Service_Main
{
    class Master_Main
    {
        private EF_WAREHOUSEContainer _ContextEntity;
        public EF_WAREHOUSEContainer ContextEntity
        {
            get
            {
                if (_ContextEntity == null)
                {
                    _ContextEntity = new EF_WAREHOUSEContainer();
                }
                return _ContextEntity;
            }
            set
            {
                _ContextEntity = value;
            }
        }
    }
}
