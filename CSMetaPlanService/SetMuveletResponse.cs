﻿using CSARMetaPlan.Class;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMetaPlanService
{
    public class SetMuveletResponse : Ac4yServiceResponse
    {
        public Muvelet Muvelet { get; set; }
    }
}
