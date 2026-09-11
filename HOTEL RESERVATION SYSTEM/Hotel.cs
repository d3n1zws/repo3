namespace HOTEL_RESERVATION_SYSTEM;

internal class Hotel
{
    public string Name { get; set; }
    Room[] rooms { get; set; } = new Room[0];
    public void AddRoom(Room room)
    {
        Room[] newrooms = rooms;
        Array.Resize(ref newrooms, newrooms.Length + 1);
        newrooms[newrooms.Length - 1] = room;
        rooms = newrooms;
    }
    public Room this[int index]
    {
        get
        {
            return rooms[index];
        }
        set
        {
            rooms[index] = value;
        }
    }
    public void Reserve(int? id)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i].Id == id)
            {
                if (rooms[i].IsAvailable)
                {
                    Console.WriteLine("Otaq ugurla rezervasiya edildi");
                    rooms[i].IsAvailable = false;
                    return;
                }
                throw new AlreadyReservedException("Bu otaq artiq reserve edilib.");
            }
        }
        throw new NotFoundException("Otaq tapilmadi");
    }
}
