using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Employee: Person
    {

       protected Card card;
        protected double slary;
        protected string workerNumberId;

        public Employee(string workerNumberId, string firstName, string lastName, string phoneNumber, string email, int id, Store store) 
            :base( firstName,  lastName,  phoneNumber,  email,  id, store)
        {
            this.slary = 0;
            this.workerNumberId = workerNumberId;
            this.card = new Card();
        }

        public Store GetStore()
        {
            return this.store;
        }
        public double SalaryCalculation(float slaryPertHour)
        {
            this.slary += card.CountMinutes * slaryPertHour;
            card.CountMinutes = 0;
            return this.slary;
        }

        public void EnteringWork()
        {
            this.card.EnteringWork();
        }
        public void LeavingWork()
        {
            this.card.LeavingWork();
        }
        public void AddProduct(Product newProdect)
        {
            if (store.SumEmoloyees > 0)
                store.AddProduct(newProdect);
            else
            {
                Console.WriteLine("The manager needs to add wmployees!");
            }
        }



    }
}
