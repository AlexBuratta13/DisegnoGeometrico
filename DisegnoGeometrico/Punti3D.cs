using System;
using System.Collections.Generic;
using System.Text;

namespace DisegnoGeometrico
{
    public class Punti3D : Punti2D
    {
        public int z { get; private set; }
        public Punti3D(int x,int y,int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
