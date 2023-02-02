using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_AbstractClasses
{
    internal class Dog:Monster
    {
        private ConsoleColor color;
        private string face;
        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Face
        {
            get { return face; }
            set { face = value; }
        }
        public Dog(string face)
        {

            Face= face;
            Random random2 = new Random();
            int colNum = random2.Next(1, 3);
            if (colNum==1)
                Color= ConsoleColor.Yellow;
            else 
                Color= ConsoleColor.DarkYellow;
        }
    }
}
