using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unarnost_new_try
{
    public class Redica_chisla
    {
        private int broi;
        private string redica;

        public int Broi {
            get { return this.broi; }
            set { this.broi = value; }
        }

        public string Redica
        {
            get { return this.redica; }
            set { this.redica = value; }
        }

        public Redica_chisla(int broi,string redica)
        {
            this.Broi = broi;
            this.Redica = redica;
        }

        public List<int> chisla_v_redicata()
        {
            List<int> chisla_v_redicaa = new List<int>();
            string[] NumbersList = this.redica.Split(' ');
            foreach (string x in NumbersList) chisla_v_redicaa.Add(int.Parse(x));
            return chisla_v_redicaa;
        }
    }
}
