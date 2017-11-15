using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Vehicle>();
            var trucks = new List<Vehicle>();

            for (int i = 0; ; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                
                if (input[0] == "End")              
                {
                    break;
                }

                input[0] = input[0].ToLower();

                var type = input[0];
                var model = input[1];
                var color = input[2];
                var horsePower = int.Parse(input[3]);


                if (type == "car")
                {
                    type = "Car";
                    var car = new Vehicle
                    {
                        Type = type,
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };

                    cars.Add(car);
                }
                else if (type == "truck")
                {
                    type = "Truck";

                    var truck = new Vehicle
                    {
                        Type = type,
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };

                    trucks.Add(truck);
                }
            }

            for (int i = 0;; i++)
            {
                var model = Console.ReadLine().Split();

                if (model[0] == "Close" && model[1] == "the" && model[2] == "Catalogue")
                {
                    break;
                }                
                foreach (var item in cars)
                {
                    if (item.Model == model[0])
                    {
                        Console.WriteLine($"Type: {item.Type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
                foreach (var item in trucks)
                {
                    if (item.Model == model[0])
                    {
                        Console.WriteLine($"Type: {item.Type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
            }
            
            var averageHpCars = 0.0;

            foreach (var item in cars)
            {
                averageHpCars += item.HorsePower;
            }

            averageHpCars = averageHpCars / cars.Count;

            var averageHpTrucks = 0.0;

            foreach (var item in trucks)
            {
                averageHpTrucks += item.HorsePower;
            }

            averageHpTrucks = averageHpTrucks / trucks.Count;
            
            Console.WriteLine("Cars have average horsepower of: {0:F2}.", 
                Double.IsNaN(averageHpCars) ? 0 : averageHpCars);
            Console.WriteLine("Trucks have average horsepower of: {0:F2}.",
                Double.IsNaN(averageHpTrucks) ? 0 : averageHpTrucks);
        }
    }
}
