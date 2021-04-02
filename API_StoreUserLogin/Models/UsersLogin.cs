using System;
using System.Collections.Generic;

#nullable disable

namespace API_StoreUserLogin.Models
{
    public partial class UsersLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? LoginDate { get; set; }
        public string Source { get; set; }
    }
}
