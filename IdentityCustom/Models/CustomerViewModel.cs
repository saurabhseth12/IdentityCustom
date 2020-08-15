using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityCustom.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
    }
}