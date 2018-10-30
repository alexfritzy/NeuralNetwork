using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class Neuron
    {
        private List<float> connections;
        public Neuron(string path)
        {
            connections = new List<float>();
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                connections.Add(float.Parse(line));
            }
        }

        public List<float> GetConnections()
        {
            return connections;
        }
    }
}
