using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }

        private void InitializeNeurons(Layer inputLayer, int valueOfNeurons)
        {
            for (var i = 0; i < valueOfNeurons; i += 1)
            {
                this.Neurons.Add(new Neuron(i, inputLayer, new Sigmoid(0.5)));
            }
        }

        private void InitializeInputsLayer(double[] inputs)     //  Входной слой сети.
        {
            for (var i = 0; i < inputs.Length; i += 1)
            {
                this.Neurons.Add(new Neuron(i, inputs[i]));
            }
        }

        public Layer(Layer inputLayer, int valueOfNeurons)
        {
            InitializeNeurons(inputLayer, valueOfNeurons);
        }

        public Layer(double[] inputs)   //  Входной слой
        {
            InitializeInputsLayer(inputs);
        }
    }
}
