using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroCompote
{
    internal class Neuron
    {
        private double[] input;
        private double Out;
        private double[] w;
        private double m;
        private double pw;    // пороговый вес
        private double delta;
        private double sigma;
        private double[,] historyOfW;
        private double[] historyOfPW;

        public Neuron(int valueOfInput, double sig, int nomer)
        {
            sigma = sig;
            input = new double[valueOfInput];
            Out = 0;
            w = new double[valueOfInput];
            Random rnd = new Random();
            pw = rnd.NextDouble() / 100.0;

            for (int i = 0; i < valueOfInput; i++)
            {
                w[i] = rnd.NextDouble() / 100.0;
            }

            if (nomer != 0)
            {
                historyOfW = new double[40000, valueOfInput];
                historyOfPW = new double[40000];
            }
            else
            {
                historyOfW = new double[0, 0];
                historyOfPW = new double[0];
            }
        }
    }
}
