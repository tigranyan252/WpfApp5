using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Example
    {
        private int x;
        private int y;
        public Example(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Output()
        {
            return (int)Math.Pow(Math.Max(x, y), 3);
        }
    }
}