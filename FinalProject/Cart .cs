using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Cart
    {

        private List<Product> products;
        public void AddProduct(Product singleProduct)
        {
            products.Add(singleProduct);
        }
        public void RemoveProduct(Product singleProduct)
        {
            products.Remove(singleProduct);
        }
    }

}

