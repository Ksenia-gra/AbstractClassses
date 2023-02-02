using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_AbstractClasses
{
    internal class Hedgehog:Monster
    {
        private ConsoleColor mColor;
        private string mFace;
        public ConsoleColor MColor
        {
            get { return mColor; }
            set { mColor = value; }
        }
        public string MFace
        {
            get { return mFace; }
            set { mFace = value; }
        }

        public Hedgehog(string mface,ConsoleColor mcolor)
        {
            mFace = mface;
            mColor= mcolor;
        }
    }
}
