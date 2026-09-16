namespace VehicleManufacturingSystem
{
    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateTruck();
        IEngine CreateEngine();
    }
}
