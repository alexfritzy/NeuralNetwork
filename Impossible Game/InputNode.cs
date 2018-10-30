using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class InputNode
    {
        private Vector2 offset;
        private Vector2 location;
        private Player player;
        public InputNode(float x, float y, Player player)
        {
            location = new Vector2();
            offset = new Vector2(x, y);
            this.player = player;
        }

        public float Update(List<BulletContainer> bullets)
        {
            location = player.getLocation() + offset;
            foreach (BulletContainer c in bullets)
                foreach (Bullet b in c.GetBullets())
                {
                    if (location.getX() + 2 >= b.getLocation().getX() && location.getX() - 2 <= b.getLocation().getX()
                        && location.getY() + 2 >= b.getLocation().getY() && location.getY() - 2 <= b.getLocation().getY())
                    {
                        return 1;
                    }
                }
            if (location.getX() < 0 || location.getX() > 700 || location.getY() < 0 || location.getY() > 500)
                return (float)0.5;
            return 0;
        }
    }
}
