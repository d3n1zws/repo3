using System;
using System.Collections.Generic;
using System.Text;

namespace HOTEL_RESERVATION_SYSTEM
{
    internal class NotFoundException: Exception
    {
        public NotFoundException(string Message) : base(Message)
        {
            
        }
    }
}
