using System;

namespace CarPark;

internal class Programm
{
    public static void Main()
    {
        StartVehicleLab();
    }

    private static void StartVehicleLab()
    {
        Vehicle hyundai = new("Hyundai", "Blue", "A101AA");
        Vehicle toyota = new("Toyota", "Black", "B100BB");
        Parking parking = new(4);

        for (var i = 1; i < 2; i++)
        {
            TryAddVehicle(hyundai, ref parking);
            TryAddVehicle(toyota, ref parking);

            Console.WriteLine(parking.GetAllVehicle());
        }
    }

    private static void TryAddVehicle(Vehicle vehicle, ref Parking parking)
    {
        if(parking.AddVehicle(vehicle))
        {
            Console.WriteLine($"{vehicle.Model} была припаркована/nОсталось {parking.VacantSpacesCount} свободных мест");
            return;
        }

        Console.WriteLine("Парковка заполнена");
    }
}