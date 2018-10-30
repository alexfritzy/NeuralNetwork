using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Impossible_Game
{
    class Bullet : Mover
    {
        private static Vector2[] shapePoints = new Vector2[]
        {
            new Vector2(-2,-2), new Vector2(2,-2),
            new Vector2(-2,-1), new Vector2(2,-1),
            new Vector2(-2,0), new Vector2(2,0),
            new Vector2(-2,1), new Vector2(2,1),
            new Vector2(-2, 2), new Vector2(2, 2)
        };

        public Bullet(Vector2 pos, Vector2 direction)
            : base(pos, shapePoints, Pens.Black, null)
        {
            velocity = direction;
            velocity = velocity.normalize();
            velocity = 3 * velocity;
        }

        public void Update(Player target)
        {
            base.Update();
            target.Hit(this);
        }
    }
}
