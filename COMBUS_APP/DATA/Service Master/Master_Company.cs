﻿using System;
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
    }
}