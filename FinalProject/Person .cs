using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Person
    {
        protected string firstName,lastName, phoneNumber, email;
        protected int id;
        protected Store store;

        public Person(string firstName, string lastName, string phoneNumber, string email, int id, Store store)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.id = id;
            this.store = store;
        }

        

       
    }
}
