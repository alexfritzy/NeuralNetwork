using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class OutputLayer
    {
        private List<Neuron> Neurons;
        private List<float> outputs;
        public OutputLayer()
        {
            outputs = new List<float>();
            Neurons = new List<Neuron>();
        }

        public void AddNeuron(string path)
        {
            Neurons.Add(new Neuron(path));
            outputs.Add(0);
        }

        public void Update(List<float> input)
        {
            for (int i = 0; i < 6; i++)
            {
                outputs[i] = (float)(1 / (1 + (Math.Pow(Math.E, WeightedSum(input, Neurons[i].GetConnections())))));
                //Console.WriteLine(outputs[i]);
            }
        }

        public double WeightedSum(List<float> inputs, List<float> weights)
        {
            float sum = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum = sum + inputs[i] * weights[i + 1];
            }
            sum = sum + weights[1];
            double sumd = (double)sum;
            return sumd;
        }

        public List<float> GetOutputs()
        {
            return outputs;
        }
    }
}
