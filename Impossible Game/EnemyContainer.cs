using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Impossible_Game
{
    class EnemyContainer : MoverContainer
    {
        public EnemyContainer()
        {

        }

        public void Update()
        {
            foreach (Enemy e in list)
            {
                e.Update();
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Enemy e in list)
            {
                e.Draw(g);
            }
        }
    }
}
