using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi_zad6
{
    class Student
    {
        private string name;
        private int result1;
        private int result2;
        private int result3;

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Result1
        {
            get { return this.result1; }
            set { this.result1 = value; }
        }

        public int Result2
        {
            get { return this.result2; }
            set { this.result2 = value; }
        }

        public int Result3
        {
            get { return this.result3; }
            set { this.result3 = value; }
        }

        public Student(string name,int result1,int result2,int result3)
        {
            this.Name = name;
            this.Result1 = result1;
            this.Result2 = result2;
            this.Result3 = result3;
        }

        public override string ToString()
        {
            return $"{this.Name} -- {this.Result1} -- {this.Result2} -- {this.result3}";
        }

        public int Score()
        {
            return Result1 + Result2 + Result3;
        }
    }
}
