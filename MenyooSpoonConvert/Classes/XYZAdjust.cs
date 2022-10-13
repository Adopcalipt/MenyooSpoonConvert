﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenyooSpoonConvert.Classes
{
    public class XYZAdjust
    {
        public decimal PosX { get; set; }
        public decimal PosY { get; set; }
        public decimal PosZ { get; set; }
        public decimal RotX { get; set; }
        public decimal RotY { get; set; }
        public decimal RotZ { get; set; }

        public XYZAdjust()
        {
            PosX = 0;
            PosY = 0;
            PosZ = 0;
            RotX = 0;
            RotY = 0;
            RotZ = 0;
        }
    }
}
