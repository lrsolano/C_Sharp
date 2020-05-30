using System;

namespace Curso_CSharp_Intermediario
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocaiton)
        {
            if (newLocaiton == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocaiton.X, newLocaiton.Y);
        }
    }

}
