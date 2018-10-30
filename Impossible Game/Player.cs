using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class Player : Mover
    {
        private float speed;
        private bool isHit;
        private bool isRetarded;
        private static Vector2[] shapePoints = new Vector2[]
        {
            new Vector2(-2,-2), new Vector2(2,-2),
            new Vector2(-2,-1), new Vector2(2,-1),
            new Vector2(-2,0), new Vector2(2,0),
            new Vector2(-2,1), new Vector2(2,1),
            new Vector2(-2, 2), new Vector2(2, 2)
        };

        public Player(Vector2 pos, Vector2 corner)
            : base(pos, shapePoints, System.Drawing.Pens.Red, corner)
        {
            speed = 3;
            isHit = false;
            isRetarded = false;
    }

        public void Update()
        {
            velocity = velocity.normalize();
            velocity = speed * velocity;
            location = location + velocity;
            if (location.getX() < 0)
            {
                //location.setX(0);
                isHit = true;
                isRetarded = true;
            }
            if (location.getY() < 0)
            {
                //location.setY(0);
                isHit = true;
                isRetarded = true;
            }
            if (location.getX() >= corner.getX())
            {
                //location.setX(corner.getX());
                isHit = true;
                isRetarded = true;
            }
            if (location.getY() >= corner.getY())
            {
                //location.setY(corner.getY());
                isHit = true;
                isRetarded = true;
            }
        }

        public void Hit(Mover target)
        {
            if (location.getX() + 4 >= target.getLocation().getX() && location.getX() - 4 <= target.getLocation().getX()
                && location.getY() + 4 >= target.getLocation().getY() && location.getY() - 4 <= target.getLocation().getY())
            {
                isHit = true;
            }
        }

        public bool IsHit()
        {
            return isHit;
        }

        public bool IsRetarded()
        {
            return isRetarded;
        }

        public void Up()
        {
            velocity.setY(-speed);
        }

        public void Down()
        {
            velocity.setY(speed);
        }

        public void Left()
        {
            velocity.setX(-speed);
        }

        public void Right()
        {
            velocity.setX(speed);
        }

        public void StopY()
        {
            velocity.setY(0);
        }

        public void StopX()
        {
            velocity.setX(0);
        }
    }
}
