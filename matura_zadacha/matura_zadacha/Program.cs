using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace matura_zadacha
{
    class Program
    {

        static void Main(string[] args)
        {
            int type;
            string input,brand, numbers;
            Stack<Car> cars_trucks = new Stack<Car>();
            StreamReader reader = new StreamReader("data.txt", Encoding.UTF8);

            using (reader)
            {
                input = reader.ReadLine();
                type = int.Parse(input);
                do
                {
                    brand = reader.ReadLine();
                    numbers = reader.ReadLine();

                    var pom = numbers.Split(' ').ToList();
                    if (type == 1) { Car car = new Car(brand, int.Parse(pom[0]), int.Parse(pom[1]), double.Parse(pom[2])); cars_trucks.Push(car); }
                    else if (type == 2) { Truck truck = new Truck(brand, int.Parse(pom[0]), int.Parse(pom[1]), double.Parse(pom[2]), double.Parse(pom[3])); cars_trucks.Push(truck); }
                    else throw new ArgumentException("Invalid data");
                    input = reader.ReadLine();
                } while (input != null);
            }
            while(cars_trucks.Count>0)
            {
                Console.WriteLine(cars_trucks.Peek().ToString());
                cars_trucks.Pop();
            }
        }
    }
}
