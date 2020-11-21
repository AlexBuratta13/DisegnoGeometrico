using System;

namespace DisegnoGeometrico
{
    public class Punti2D
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public Punti2D(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
