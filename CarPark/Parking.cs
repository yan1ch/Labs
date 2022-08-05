namespace CarPark;

internal class Parking
{
    public List<Vehicle> VehicleList { get; init; }
    public int ParkingSpacesCount { get; init; }
	public int VacantSpacesCount 
	{
		get
		{
			return ParkingSpacesCount - VehicleList.Count;
		}
	}

    public Parking()
	{
		VehicleList = new List<Vehicle>();
		ParkingSpacesCount = 10;
	}

    public Parking(int parkingSpacesCount)
    {
        VehicleList = new List<Vehicle>();
        ParkingSpacesCount = parkingSpacesCount;
    }

    public bool AddVehicle(Vehicle car)
    {
        if (VacantSpacesCount == 0)
        {
			return false;
        }

		VehicleList.Add(car);
		return true;
    }

    public IEnumerable<Vehicle> GetAllVehicle() 
    {
        foreach (Vehicle car in VehicleList)
        {
            yield return car;
        }
    }
}