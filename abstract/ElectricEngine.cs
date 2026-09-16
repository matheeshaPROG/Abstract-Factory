using System;

namespace VehicleManufacturingSystem
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric Engine started.");
        }
    }
}
