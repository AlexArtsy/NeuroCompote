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
        public double InputValue { get; set; }
        public double OutputValue { get; set; }
        public IActivation ActivationFunc { get; set; }
        private Synapse[] inputs;

        #region Constructors
        public Neuron(int inputValue, IActivation activationFunc)    //  Для входных нейронов.
        {
            InputValue = inputValue;
            ActivationFunc = activationFunc;
            OutputValue = CalculateValue(inputValue);
        }

        public Neuron(double inputValue, IActivation activationFunc)    //  Для входных нейронов.
        {
            InputValue = inputValue;
            ActivationFunc = activationFunc;
            OutputValue = CalculateValue(inputValue);
        }

        public Neuron(double[] inputs, IActivation activationFunc)
        {
            this.layerId = layerId;
            ActivationFunc = activationFunc;
            OutputValue = 0;
            inputs = InitializeSynapse(valueOfInputs);
        }
        #endregion
        private Synapse[] InitializeSynapse(int valueOfInputs, double inputValue)
        {
            var rnd = new Random();
            var synapses = new Synapse[valueOfInputs];

            for (var i = 0; i < valueOfInputs; i += 1)
            {
                var weight = rnd.NextDouble();
                synapses[i] = new Synapse(weight, inputValue);
            }
            return synapses;
        }
        public double CalculateValue(int inputValue)
        {

            return 0;
        }

        public double CalculateValue(double inputValue)
        {

            return 0;
        }

        public double CalculateValue()
        {

            return 0;
        }

        private double GetWeightedSum()
        {

        }
    }
}
