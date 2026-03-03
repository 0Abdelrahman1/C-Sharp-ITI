using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    internal class Parent
    {
        protected int x;
        protected int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Parent(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int Mul() { return x * y; }

        public override string ToString()
        {
            return $"x: {x} , y:{y}";
        }
    }

    class Child : Parent
    {
        int z;
        public int Z { get => z; set => z = value; }

        public Child(int _x , int _y , int _z):base(_x , _y)   ///ctor Chainning 
        {
            z = _z;
        }

        public new int Mul ()
        { return base.Mul() * z; }
        //{ return x * y * z; }
        ///Hide , Mask Base Implementation 

        public override string ToString()
        {
            return $"x:{x} , y:{y} , z:{z}";
        }
    }
}
