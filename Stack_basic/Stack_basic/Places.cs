using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_basic
{
   public class Places
    {
        private int n;
        private int top;
        private string[] Elements = new string[1];

        public Places(int m)
        {
            this.n = m;
            Array.Resize(ref this.Elements, n);
            top = -1;
        }
        public void Push(string x)
        {
            if (this.top == n - 1)
            {
                n = n + 32;
                Array.Resize(ref this.Elements, n);
            }

             top++;
                Elements[top] = x;
            
                    
            
        }
        public string Pop()
        {
            if (top == -1)
                throw new Exception("Error");
            return this.Elements[top--];
        }
        public string Look()
        {
            if (top == -1)
                throw new Exception("Error");
            return this.Elements[top];
        }
        public int Size()
        {
            int k = top;
            k++;
            return k;
        }

    }
}
