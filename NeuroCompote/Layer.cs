using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    internal class Layer
    {
        public List<Neuron> Neurons { get; set; }

        public Layer(List<Neuron> neurons)
        {
            this.Neurons = neurons;
        }
    }
}
