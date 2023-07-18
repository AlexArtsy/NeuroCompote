using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    internal class Sigmoid : IActivation
    {
        private readonly double sigma;

        public Sigmoid(double sigma)
        {
            this.sigma = sigma;
        }

        public double Calculate(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-1 * sigma * x));
        }
        
    }
}
