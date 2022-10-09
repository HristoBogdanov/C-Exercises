using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archery
{
    public class Player
    {
        private string name;
        private int result;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Result
        {
            get { return this.result; }
            set { this.result = value; }
        }
        public Player(string name,int result)
        {
            this.Name = name;
            this.Result = result;
        }
    }
}
