using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace FinalProject
{
    class Store : GenericStore
    {
      
        private Hashtable categoryList = new Hashtable();
        private int sumEmoloyees = 0 ;

        
        public int SumEmoloyees { get => sumEmoloyees; }

        //public Store()
        //{

        //}
        public override void openStore() { isOpen = true; }
        public override void closeStore() { isOpen = false; }
        public override int getTotalProductsCount() { return totalProducts; }
        public override float getTotalSumOfPurchase() { return totalSumPurchase; }

        public void AddEmployee()
        {
            this.sumEmoloyees++;
        }

        public void AddCategory(string categoryName)
        {
            if (this.categoryList.ContainsKey(categoryName))
            {
                Console.WriteLine("you try to  add category that's already exist..");
                return;
            }
           

            categoryList.Add(categoryName, new List<Product>());
            Console.WriteLine("category added succefully !");
        }
        public void AddProduct(Product product)
        {
            if (!this.categoryList.ContainsKey(product.Category))
                categoryList.Add(product.Category, new List<Product>());

            foreach (Product item in (List<Product>)categoryList[product.Category])
            {
                if (item.Catalog_number == product.Catalog_number)
                {
                    Console.WriteLine("you try to  add product that's already exist..");
                    return;
                }

            }
            ((List<Product>)categoryList[product.Category]).Add(product);
            this.totalProducts++;
            Console.WriteLine($"product {product.NameProduct} added succefully!");
        }

        //public bool ChekProduct(string category, string catalogNumber)
        //{
        //    foreach (Product item in (List<Product>)categoryList[category])
        //    {
        //        if (item.Catalog_number == catalogNumber)

        //            return true;


        //    }
        //    return false;
        //}
        public void RemoveProduct(string category, string catalogNumber)
        {
            if (!this.categoryList.ContainsKey(category))
            {
                Console.WriteLine("this category does not exist");
                return;
            }

            foreach (Product item in (List<Product>)categoryList[category])
            {
                if (item.Catalog_number == catalogNumber)
                {
                    ((List<Product>)categoryList[category]).Remove(item);
                    this.totalProducts--;
                    Console.WriteLine($"product {catalogNumber} removed succefully!");

                    return;
                }

            }
            Console.WriteLine($"this product with catalog number: {catalogNumber} does not exist");
        }

        public void ChangePrice(string CatalogNumber, string category, float newPrice)
        {
            foreach (Product item in (List<Product>)categoryList[category])
            {
                if (item.Catalog_number == CatalogNumber)
                {
                    item.Price = newPrice;

                    Console.WriteLine($"price of {item.NameProduct} Changed  succefully!");

                    return;
                }

            }
            Console.WriteLine($"this product with catalog number: {CatalogNumber} does not exist");
        }

        public bool ChekProduct(string category, string catalogNumber)
        {
            foreach (Product item in (List<Product>)categoryList[category])
            {
                if (item.Catalog_number == catalogNumber)

                    return true;


            }
            return false;
        }

        public void AddToCart(Cart cart)
        {
           Hashtable categorys=new Hashtable();
            int count=0;
            Console.WriteLine();
            if (categoryList.Count == 0)
            {
                Console.WriteLine("no products now, please try later!");
                return;
            }
            foreach (string s in categoryList.Keys)
            {
                Console.WriteLine($"{++count}=> {s}");
                categorys.Add(count, s);
            }
            Console.WriteLine();
            Console.WriteLine("enter number of category");
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine());
            Hashtable products = new Hashtable();
            count = 0;
            foreach (Product item in (List<Product>)categoryList[categorys[num]])
            {
                Console.Write($"{++count}=> ");
                item.Print();
               products.Add(count, item );
            }
            Console.WriteLine();
            Console.WriteLine("enter number of product");
            Console.WriteLine();
            num = int.Parse(Console.ReadLine());

           
            Console.WriteLine("enter sum of product");
            int sumProducts = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < sumProducts; i++)
            {
                Product x = (Product)products[num];
                x.Print();

            }

        }
        public void SearchProduct()
        {
            Hashtable categorys = new Hashtable();
            int count = 0;
            Console.WriteLine();
            if (categoryList.Count == 0)
            {
                Console.WriteLine("no products now, please try later!");
                return;
            }
            foreach (string s in categoryList.Keys)
            {
                Console.WriteLine($"{++count}=> {s}");
                categorys.Add(count, s);
            }
            Console.WriteLine();
            Console.WriteLine("enter number of category");
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine());
            Hashtable products = new Hashtable();
            count = 0;
            foreach (Product item in (List<Product>)categoryList[categorys[num]])
            {
                Console.Write($"{++count}=> ");
                item.Print();
                products.Add(count, item);
            }
            Console.WriteLine();


        }

    }
}