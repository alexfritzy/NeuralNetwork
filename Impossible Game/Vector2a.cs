using System;

namespace Impossible_Game
{
    class Vector2
    {
        private float x;
        private float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2() : this(0, 0)
        {
        }

        public Vector2(float angle) : this((float)Math.Sin(angle), (float)-Math.Cos(angle))
        {
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public void setX(float x) { this.x = x; }
        public void setY(float y) { this.y = y; }

        public float dot(Vector2 that) { return this.x * that.x + this.y * that.y; }
        public Vector2 perpCW() { return new Vector2(y, -x); }
        public Vector2 perpCCW() { return new Vector2(-y, x); }
        public float length() { return (float) Math.Sqrt(x*x + y*y);  }
        public Vector2 normalize()
        {
            float l = length();
            return (l == 0)? this: new Vector2(x/l,y/l);
        }

        public float getDistance(Vector2 that) {
            float deltaX = this.x - that.x;
            float deltaY = this.y - that.y;
            return (float) Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y - v2.y);
        }

        public static Vector2 operator *(float f, Vector2 v)
        {
            return new Vector2(v.x * f, v.y * f);
        }

        public static Vector2 operator /(Vector2 v, float f)
        {
            return new Vector2(v.x / f, v.y / f);
        }

        public float GetAngle()
        {
            return (float) (Math.Atan2(y, x) - Math.PI/2.0);
        }

        public override bool Equals(object obj)
        {
            var vector = obj as Vector2;
            return vector != null &&
                   x == vector.x &&
                   y == vector.y;
        }

        public override int GetHashCode()
        {
            var hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }

    }
}
