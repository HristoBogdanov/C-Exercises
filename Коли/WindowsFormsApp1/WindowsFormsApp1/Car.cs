using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Car
    {
        private Model_car model_car;
        private Cargo cargo;

        public Car(string name_model, int year, int power, int speed, string name_cargo, double weight)
        {
            model_car = new Model_car(name_model,year,power,speed);
            cargo = new Cargo(name_cargo, weight);
        }

        public string Get_Name_Cargo()
        {
            return cargo.Name_cargo;
        }

        public string Get_Name_Car()
        {
            return model_car.Name_car;
        }

        public double Get_Weight()
        {
            return cargo.Weight;
        }

        public string Print()
        {
            return $"{model_car.Name_car}- пренася {cargo.Name_cargo} - {cargo.Weight}";
        }
    }
}
