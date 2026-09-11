using System.Threading.Channels;

namespace HOTEL_RESERVATION_SYSTEM;

internal class AlreadyReservedException : Exception
{
    public AlreadyReservedException(string Message) : base(Message)
    {
        
    }
}
