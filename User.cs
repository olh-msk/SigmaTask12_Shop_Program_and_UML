using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    enum UserStatus {New, Registered, VIP, Inanctive, Blocked }
    class User
    {
        public UserStatus UserStatus { get; set; }
    }
}
