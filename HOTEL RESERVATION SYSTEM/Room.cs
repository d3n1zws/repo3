using System.Runtime.InteropServices;

namespace HOTEL_RESERVATION_SYSTEM;

internal class Room
{
    static int id = 0;

    public Room(string name, double price, int personCapacity)
    {
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
        id++;
        Id = id;
    }
    public int Id { get; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvailable { get; set; } = true;
    public void ShowInfo()
    {
        Console.WriteLine($"Id : {Id}, Name : {Name}, Price : {Price}, Capacity : {PersonCapacity}, Is Available : {IsAvailable}");
    }
    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}, Price : {Price}, Capacity : {PersonCapacity}, Is Available : {IsAvailable}";
    }
}
