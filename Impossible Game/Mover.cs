using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Impossible_Game
{
    class Mover
    {
        protected Vector2 location;
        private Vector2[] shapePoints;
        protected Vector2 velocity;
        private Pen color;
        protected Vector2 corner;
        protected float angle;
        public Mover(Vector2 pos, Vector2[] points, Pen pen, Vector2 corn)
        {
            location = pos;
            shapePoints = points;
            color = pen;
            corner = corn;
            angle = 0;
            velocity = new Vector2(0, 0);
        }

        public void Draw(Graphics g)
        {
            float xPos = location.getX();
            float yPos = location.getY();
            for (int x = 0; x < shapePoints.Length - 1; x = x + 2)
            {
                Vector2 endpoint1 = (shapePoints[x]) + location;
                Vector2 endpoint2 = (shapePoints[x + 1]) + location;
                g.DrawLine(color, endpoint1.getX(), endpoint1.getY(), endpoint2.getX(), endpoint2.getY());
            }
        }

        public void Update()
        {
            location = location + velocity;
            if (corner != null)
            {
                if (location.getX() < 0)
                {
                    velocity = new Vector2(-velocity.getX(), velocity.getY());
                }
                if (location.getY() < 0)
                {
                    velocity = new Vector2(velocity.getX(), -velocity.getY());
                }
                if (location.getX() >= corner.getX())
                {
                    velocity = new Vector2(-velocity.getX(), velocity.getY());
                }
                if (location.getY() >= corner.getY())
                {
                    velocity = new Vector2(velocity.getX(), -velocity.getY());
                }
            }

        }

        public Vector2 getLocation()
        {
            return location;
        }

    }
}
