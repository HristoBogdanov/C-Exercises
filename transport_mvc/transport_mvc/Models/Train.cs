using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_mvc.Models
{
    public class Train: Vehicle
    {
        private const decimal trainrate = 0.10M;

        public Train():base(trainrate,trainrate)
        {

        }


    }
}
