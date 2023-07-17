using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    internal class Neuron
    {
        private readonly int layerId;
        public Sigmoid Sigma { get; set; }
        public Neuron(int layerId, Sigmoid sigma)
        {
            this.layerId = layerId;
            Sigma = sigma;
        }
    }
}
