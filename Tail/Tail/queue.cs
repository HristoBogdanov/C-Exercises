using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tail
{
    public class queue
    {
        private int n;
        private int bottom, top;
        private int[] Elemets = new int[1];

        public queue(int m)
        {
            this.n = m;
            Array.Resize(ref this.Elemets, n);
            top = 0;
            bottom = -1;
        }
        public void Push(int x)
        {
            bottom = bottom + 1;
            this.Elemets[bottom] = x;
        }
        public int Pop()
        {
            return Elemets[top++];
        }
        public int Look()
        {
            return this.Elemets[top];
        }
        public int Count()
        {
            return bottom - top + 1;
        }
        public int[] Output()
        {
            return Elemets;
        }
    }
}
