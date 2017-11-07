using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
    public class UserRegisteration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Postcode { get; set; }
        public string MobileNum { get; set; }
        public string ProfileImg { get; set; } ///String of the filepath of img file
    }
}