﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public interface IModService
    {
        string ModifyString(string toModify);
        void ModStateEnable(string mod);
    }
}
