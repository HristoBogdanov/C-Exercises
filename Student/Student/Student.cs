using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        private string name;
        private string discipline;
        public string Name
        {
            get { return this.name; }
            set {this.name = value; }
        }
        public string Discipline
        {
            get { return this.discipline; }
            set { this.discipline = value; }
        }
        public Student(string name, string discipline)
        {
            this.Name = name;
            this.Discipline = discipline;
        }
        
        public int Min(List<int> a)
        {
            int min = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] < min) min=a[i];
            }
            return min;
            
        }
        public int Max(List<int> a)
        {
            int max = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] > max) max=a[i];
            }
            return max;
        }
        public double Average(List<int> a)
        {
            double sum=0;
            foreach (int x in a) sum = sum + x;
            double average = sum / a.Count;
            return average;
        }
    }
}
