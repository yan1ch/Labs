using System;

namespace CarPark;

class Programm
{
    public static void Main()
    {
        Car car1 = new("Hyundai", "Blue", "A101AA");
        Car car2 = new("Toyota", "Black", "B100BB");
        Parking parking1 = new Parking(4);
        parking1.CarRecording(car1);
        parking1.CarRecording(car2);
        parking1.CarRecording(car1);
        parking1.CarRecording(car2);
        parking1.AllCars();
        parking1.CarRecording(car1);
        string str = car1.ToString();
        Console.WriteLine(str);
    }
}
