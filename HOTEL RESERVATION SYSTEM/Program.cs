using HOTEL_RESERVATION_SYSTEM;

try
{
    Room room1 = new Room("deniz", 300, 10);
    Room room2 = new Room("alma", 200, 12);
    Room room3 = new Room("armud", 150, 6);
    Hotel hotel = new Hotel();
    hotel.AddRoom(room1);
    hotel.AddRoom(room2);
    hotel.AddRoom(room3);
    hotel.Reserve(5);
    hotel.Reserve(2);
}
catch(AlreadyReservedException ex) { Console.WriteLine(ex); }

catch (NotFoundException ex) { Console.WriteLine(ex); }