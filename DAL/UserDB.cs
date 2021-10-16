using System;
using System.Collections.Generic;

namespace DAL
{
    public class UserDB
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
    }
}
