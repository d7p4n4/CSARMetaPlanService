﻿using CSARMetaPlan.Class;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMetaPlanService
{
    public class UpdateMuveletByGUIDRequest : Ac4yServiceRequest
    {
        public Muvelet NewMuvelet { get; set; }
    }
}
