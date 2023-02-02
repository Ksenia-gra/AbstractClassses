using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_AbstractClasses
{
    abstract class Monster
    {
        private int x;
        private int y;
        private double weight;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public void BeBorn(int x,int y,double weight)
        {
            X = x;
            Y = y;
            Weight = weight;

        }

    }
}
