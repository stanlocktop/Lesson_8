using System;
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Street
    {
        get { return street; }
        set { street = value; }
    }
    public string House
    {
        get { return house; }
        set { house = value; }
    }
    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
    public void DisplayAddress()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        Console.WriteLine($"Індекс: {Index}");
        Console.WriteLine($"Країна: {Country}");
        Console.WriteLine($"Місто: {City}");
        Console.WriteLine($"Вулиця: {Street}");
        Console.WriteLine($"Номер будинку: {House}");
        Console.WriteLine($"Номер квартири: {Apartment}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address();
        myAddress.Index = "49000";
        myAddress.Country = "Україна";
        myAddress.City = "Дніпро";
        myAddress.Street = "Проспект Гагаріна";
        myAddress.House = "15";
        myAddress.Apartment = "12";
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Поштова адреса:");
        myAddress.DisplayAddress();
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}