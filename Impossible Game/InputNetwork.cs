using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class InputNetwork
    {
        private List<InputNode> inputs;
        private List<BulletContainer> bullets;
        private List<float> outputs;
        public InputNetwork(Player player)
        {
            bullets = new List<BulletContainer>();
            inputs = new List<InputNode>();
            outputs = new List<float>();
            InputNode Node;
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    Node = new InputNode(x, y, player);
                    inputs.Add(Node);
                    outputs.Add(0);
                }
            }
        }

        public void AddBullets(BulletContainer bullet)
        {
            bullets.Add(bullet);
        }

        public void Update()
        {
            float output;
            for (int i = 0; i < 121; i++)
            {
                output = inputs[i].Update(bullets);
                outputs[i] = output;
            }
        }

        public List<float> GetOutputs()
        {
            return outputs;
        }
    }
}
