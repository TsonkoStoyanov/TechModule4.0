using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Vehicle> vehicles = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();

                string typeOfVehicle = inputArgs[0];

                if (typeOfVehicle == "car")
                {
                    typeOfVehicle = "Car";
                }
                else if (typeOfVehicle == "truck")
                {
                    typeOfVehicle = "Truck";
                }

                string model = inputArgs[1];
                string color = inputArgs[2];
                int horsepower = int.Parse(inputArgs[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsepower);

                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(x => x.Model == input));
            }


            List<Vehicle> cars = new List<Vehicle>();

            List<Vehicle> trucks = new List<Vehicle>();

            cars = vehicles.FindAll(x => x.Type == "Car").ToList();
            trucks = vehicles.FindAll(x => x.Type == "Truck").ToList();
            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {cars.Average(x => x.Horsepower):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucks.Average(x => x.Horsepower):f2}.");

            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");

            }

        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}
