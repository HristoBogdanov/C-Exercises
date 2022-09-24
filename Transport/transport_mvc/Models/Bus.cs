using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_mvc.Models
{
    public class Bus:Vehicle
    {
        private const decimal busrate = 0.20M;
        public Bus():base(busrate,busrate)
        {
                
        }

    }
}
