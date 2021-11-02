using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Product
    {
        private string nameProduct;
        private string catalog_number;
        private float price;
        private string category;
        private int amount;

        public Product(string nameProduct, string catalog_umber, float price, string category)
        {
            this.nameProduct = nameProduct;
            this.catalog_number = catalog_umber;
            this.price = price;
            this.category = category;
            this.amount = 1;
        }

        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Catalog_number { get => catalog_number; set => catalog_number = value; }
        public float Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }

        public void Print()
        {
            Console.WriteLine($"name: {this.nameProduct}. catalog number: {this.catalog_number }. price: {this.price}. category: {this.category}.");
        }
    }
    }

