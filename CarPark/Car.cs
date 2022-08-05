public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public string StateNumber { get; set; }


    public Car(string model, string color, string stateNumber)
    {
        Model = model;
        Color = color;
        StateNumber = stateNumber;
    }
    public override string ToString()
    {
        return $"Модель: {Model} \n Цвет: {Color} \n Номер: {StateNumber}" ;
    }
}