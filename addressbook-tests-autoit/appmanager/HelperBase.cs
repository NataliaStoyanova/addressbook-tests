﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected AutoItX3 aux;
        protected string WINTITLE;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            WINTITLE = ApplicationManager.WINTITLE;
            this.manager = manager;
            this.aux = manager.Aux;
        }
    }
}
