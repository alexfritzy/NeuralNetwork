using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class BulletContainer : MoverContainer
    {
        private int counter;
        private int fireRate;
        private Bullet bullet;
        public BulletContainer()
        {
            counter = 0;
            fireRate = 10;
        }

        public void Update(Vector2 pos, Vector2 direction, Player target)
        {
            SpawnBullets(pos, direction);
            List<Mover> removeList = new List<Mover>();
            foreach (Bullet b in list)
            {
                b.Update(target);
                if (b.getLocation().getX() < -5)
                    removeList.Add(b);
                if (b.getLocation().getY() < -5)
                    removeList.Add(b);
                if (b.getLocation().getX() > 705)
                    removeList.Add(b);
                if (b.getLocation().getY() > 505)
                    removeList.Add(b);
            }
            foreach (Bullet x in removeList)
            {
                list.Remove(x);
            }
        }

        public void SpawnBullets(Vector2 pos, Vector2 direction)
        {
            counter++;
            if (counter % fireRate == 0)
            {
                bullet = new Bullet(pos, direction);
                list.Add(bullet);
            }
        }

        public List<Mover> GetBullets()
        {
            return list;
        }
    }
}
