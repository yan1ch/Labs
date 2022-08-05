namespace CarPark;

public class Parking
{
    public List<Car> ParkedCars { get; set; }
    public int NumberOfParkingSpaces { get; set; }
    public Parking(int numberOfParkingSpaces)
    {
        ParkedCars = new List<Car>();
        NumberOfParkingSpaces = numberOfParkingSpaces;
    }

    public void CarRecording(Car car)
    {
        if (NumberOfParkingSpaces > ParkedCars.Count)
        {
            ParkedCars.Add(car);
            Console.WriteLine($"{car} заехала на парковку");
        }
        else
        {
            Console.Write("Свободных мест нет");
        }
    }
    /// <summary>
    /// Метод вывода всех машин
    /// </summary>
    public void AllCars() 
    {
        foreach (Car car in ParkedCars)
        {
            Console.WriteLine(car);
        }
    }
}