using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Impossible_Game
{
    class MoverContainer
    {
        protected List<Mover> list;
        public MoverContainer()
        {
            list = new List<Mover>();
        }

        public void Update()
        {
            foreach (Mover e in list)
            {
                e.Update();
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Mover e in list)
            {
                e.Draw(g);
            }
        }

        public void Add(Mover m)
        {
            list.Add(m);
        }
    }
}
