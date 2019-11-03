﻿using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class InputGroupAppendManager : DivBaseManager
    {
        public override string StringCSS
        {
            get
            {
                AddCSS("input-group-append");
                return base.StringCSS;
            }
        }
    }
}
