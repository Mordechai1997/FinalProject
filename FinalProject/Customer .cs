using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Customer: Person
    {
        Cart cart;

        public Customer(string firstName, string lastName, string phoneNumber, string email, int id, Store store)
            :base(firstName, lastName, phoneNumber, email, id,store)
        {
            this.cart = new Cart();
        }
//        public void AddProduct() { }
        public void AddToCart()
        {
            this.store.AddToCart(this.cart);
        }
    }
}
