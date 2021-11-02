using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    sealed class Manager: Employee 
    {
        private Manager(string workerNumberId, string firstName, string lastName, string phoneNumber, string email, int id, Store mystore)
            : base(workerNumberId, firstName, lastName, phoneNumber, email, id, mystore)
        {
           
        }
        private static Manager instance = null;
        public static Manager Instance(string workerNumberId, string firstName, string lastName, string phoneNumber, string email, int id, Store myStore)
        {
            
                if (instance == null)
                {
                    instance = new Manager(workerNumberId, firstName, lastName, phoneNumber, email, id, myStore);
                }
                return instance;
            
        }

        public void AddEmployee()
        {
            store.AddEmployee();
        }
        public void AddProduct(Product newProdect)
        {
          
                store.AddProduct(newProdect);
        }

        public void AddCategory(String newCategory)
        {
            store.AddCategory(newCategory);
        }
        public void RemoveProduct(string category, string catalogNumber)
        {
            store.RemoveProduct(category, catalogNumber);
        }
        public void ChangePrice(string CatalogNumber, string category, float newPrice)
        {
            this.store.ChangePrice(CatalogNumber,category,newPrice);
        }

       
    }
}
