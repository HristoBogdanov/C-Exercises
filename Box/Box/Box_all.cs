using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box_all<T>
    {
        private List<T> spisuk;
        public int Count { get { return spisuk.Count; } }
        public List<T> Spisuk
        {
            get { return this.spisuk; }
            set{ this.spisuk = value; }
        }
        public Box_all()
        {
            this.spisuk = new List<T>();
        }
        public void AddBox(T element)
        {
            spisuk.Insert(0, element);
        }
        
        public T Remove()
        {
            T first = spisuk.First();
            spisuk.RemoveAt(0);
            return first;
        }
        
        public override string ToString()
        {
            string result="";
            foreach (T x in spisuk)
            { 
                result = $"{result} - {x}";
            }
            return result;
        }

    }
}
