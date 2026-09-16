using System;

namespace VehicleManufacturingSystem
{
    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline Engine started.");
        }
    }
}
