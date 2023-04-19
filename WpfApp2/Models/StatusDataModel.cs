﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class StatusDataModel
    {
        public string ContactName { get; set; }
        public Uri ContactPhoto { get; set; }
        public Uri StatusImage { get; set; }

        //If we want to add our status
        public bool IsMeAddStatus { get; set; }
    }
}
