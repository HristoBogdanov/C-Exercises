using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IContainer
    {
        int GetContainerID();
        int GetContainerWeight();
        void setContainerID(int id);
    }

    public class ACMEContainer:IContainer
        {
        private int id;
        private int weight;
        public int GetContainerID()
        {
            return this.id;
        }

        public int GetContainerWeight()
        {
            return this.weight;
        }
        public void setContainerID(int id)
        {
            this.id = id;
        }
        }
}

