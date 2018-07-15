using DemoCibaoDev.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoCibaoDev.ViewModels
{
    public class PersonVM
    {
        public ObservableCollection<Person> Persons { get; set; }

        
        public PersonVM()
        {
            PersonsList();
        }

        /// <summary>
        /// Completamos lista para mostrar en la vista.
        /// </summary>
        void PersonsList()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person
            {
                FirstName = "Juan",
                LastName = "Dominguez",
                Phone = "8095881753",
                Email = "nada@hotmail.com",
                ImageName = "user.png"
            });

            Persons.Add(new Person
            {
                FirstName = "Michael",
                LastName = "Jordan",
                Phone = "8095881753",
                Email = "jordan@hotmail.com",
                ImageName = "user.png"
            });

            Persons.Add(new Person
            {
                FirstName = "Manny",
                LastName = "Machado",
                Phone = "8096995800",
                Email = "machado@hotmail.com",
                ImageName = "user.png"
            });

            Persons.Add(new Person
            {
                FirstName = "Branda",
                LastName = "Sanchez",
                Phone = "8096995800",
                Email = "brenda@hotmail.com",
                ImageName = "user.png"
            });

            Persons.Add(new Person
            {
                FirstName = "David",
                LastName = "Ortiz",
                Phone = "809588200",
                Email = "davido@hotmail.com",
                ImageName = "user.png"
            });

        }
    }
}
