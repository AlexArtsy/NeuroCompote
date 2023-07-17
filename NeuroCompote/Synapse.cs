using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    internal class Synapse
    {
        private double value;
        public double InitializedWeight { get; set; }
        public double InitializedValue { get; set; }
        public double Weight { get; set; }

        public double Value
        {
            get => value;
            set
            {
                if (value >= 0 & value <= 1.0)
                {
                    this.value = value;
                }
                else
                {
                    throw new Exception($"Value of synapse must be between 0 and 1, value = {value}");
                }
            }
        }
        public Synapse(double weight, double value)
        {
            Weight = weight;
            this.value = value;
        }
    }
}
