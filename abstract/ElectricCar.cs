using System;

namespace VehicleManufacturingSystem
{
    public class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle: Electric Car");
        }
    }
}
