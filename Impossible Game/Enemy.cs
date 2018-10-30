using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Impossible_Game
{
    class Enemy : Mover
    {
        private BulletContainer bullets;
        private Player target;
        private int MAX_SPEED = 3;
        private Random random;
        private Vector2 aim;
        private static Vector2[] shapePoints = new Vector2[]
        {
            new Vector2(-10,0), new Vector2(0,-10),
            new Vector2(0,-10), new Vector2(10,0),
            new Vector2(10,0), new Vector2(0,10),
            new Vector2(0,10), new Vector2(-10,0),
        };

        public Enemy(Vector2 pos, Vector2 corner, Player target)
            : base(pos, shapePoints, Pens.Red, corner)
        {
            this.target = target;
            random = new Random();
            aim = new Vector2();
            //velocity = new Vector2(random.Next(-10, 10), random.Next(-10, 10));
            Vector2 direction = location - target.getLocation();
            velocity = direction;
            velocity = velocity.normalize();
            velocity = MAX_SPEED * velocity;
            bullets = new BulletContainer();
        }

        public void Update()
        {
            aim = target.getLocation() - location;
            bullets.Update(location, aim, target);
            base.Update();
        }

        public void Draw(Graphics g)
        {
            bullets.Draw(g);
        }

        public BulletContainer GetBullets()
        {
            return bullets;
        }
    }
}
