using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Model_car
    {
        private string name_car;
        private int year;
        private int power;
        private int speed;


        //Така се декларира конструктор с 4 параметъра --->
        public Model_car(string name_car, int year, int power, int speed)
        {
            //Правим параметрите на конструктора да приемат стойностите на класа
            this.name_car = name_car;
            this.year = year;
            this.power = power;
            this.speed = speed;

        }

        public string Name_car
        {
            get
            {
                return this.name_car;
            }
        }
    }
}
