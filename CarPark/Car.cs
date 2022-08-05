internal struct Vehicle
{
    public string Model { get; init; }
    public string Color { get; init; }
    public string StateNumber { get; init; }

	public Vehicle()
	{
		Model = "Unknown";
		Color = "White";
		StateNumber = "AB000C";
	}

    public Vehicle(string model, string color, string stateNumber)
    {
        Model = model;
        Color = color;
        StateNumber = stateNumber;
    }

    public override string ToString()
    {
        return $"Модель: {Model}\nЦвет: {Color}\nНомер: {StateNumber}";
    }
}