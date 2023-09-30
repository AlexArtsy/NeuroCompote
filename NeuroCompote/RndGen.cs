﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    internal class RndGen
    {
        private static Random rnd = new Random();

        public static double InitWeight()
        {
            return 2 - rnd.NextDouble();
        }

        public static double AdjustWeight()
        {
            return InitWeight() * 0.01;
        }
    }
}
