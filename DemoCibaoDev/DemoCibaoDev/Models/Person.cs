using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCibaoDev.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageName { get; set; }
        public string NombreCompleto
        {
            get { return $"{FirstName}  {LastName}"; }
        }
    }
}
