﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.UI
{
    public class DelegateCommandEventArgs : EventArgs
    {

        private object parameter;
        public DelegateCommandEventArgs(object parameter)
        {
            this.parameter = parameter;
        }

        public object Parameter
        {
            get { return this.parameter; }
        }
    }
}
