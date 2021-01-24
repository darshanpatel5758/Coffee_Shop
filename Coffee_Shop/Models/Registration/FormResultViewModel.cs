using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models.Registration
{
    public class FormResultViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string  Lname { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
