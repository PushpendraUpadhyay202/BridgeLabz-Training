class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Amit");

        Vehicle bike = new Bike("BIKE101", 300);
        Vehicle car = new Car("CAR202", 1000);
        Vehicle truck = new Truck("TRK303", 2000);

        customer.RentVehicle(bike, 3);
        customer.RentVehicle(car, 2);
        customer.RentVehicle(truck, 1);
    }
}
