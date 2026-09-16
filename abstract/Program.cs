using System;

namespace VehicleManufacturingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter engine type (gasoline/electric): ");
            string engineType = Console.ReadLine();

            IVehicleFactory factory;

            if (engineType != null && engineType.ToLower() == "electric")
            {
                factory = new ElectricVehicleFactory();
            }
            else
            {
                factory = new GasolineVehicleFactory();
            }

            IVehicle car = factory.CreateCar();
            IVehicle truck = factory.CreateTruck();
            IEngine engine = factory.CreateEngine();

            car.ShowDetails();
            truck.ShowDetails();
            engine.Start();
        }
    }
}
