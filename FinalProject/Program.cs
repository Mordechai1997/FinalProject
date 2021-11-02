using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {


            Store store = new Store();
            string firstName, lastName, phoneNumber, email;
            int id;
            //   Console.WriteLine("\    /");
            // Console.WriteLine(" \/\/");
           
                Console.WriteLine("Wellcome to the store!.\n");

                Console.WriteLine("please  enter your first name");
                firstName = Console.ReadLine();

                Console.WriteLine("please  enter your last name");
                lastName = Console.ReadLine();

                Console.WriteLine("please  enter your phone number ");
                phoneNumber = Console.ReadLine();

                Console.WriteLine("please  enter your email address");
                email = Console.ReadLine();

                Console.WriteLine("please  enter your id (int)");
                id = int.Parse(Console.ReadLine());
            while (true)
            {

                Console.WriteLine("\nenter te right number to choice your status. " + "\n" +
                    "1 > manager.\n" +
                    "2 > employee\n" +
                    "3 > custumer ");
                int firstChoice = int.Parse(Console.ReadLine());

                switch (firstChoice)
                {
                    case 1:
                        Console.WriteLine("please enter your workerID");
                        string managerWorkID = Console.ReadLine();
                        Manager manager = Manager.Instance(managerWorkID, firstName, lastName, phoneNumber, email, id, store);
                        ManagerInterface(manager);
                        break;
                    case 2:
                        Console.WriteLine("please enter your workerID");
                        string employeeWorkID = Console.ReadLine();
                        Employee employee = new Employee(employeeWorkID, firstName, lastName, phoneNumber, email, id, store);
                        EmployeeInterface(employee);

                        break;
                    case 3:
                        Customer customer = new Customer(firstName, lastName, phoneNumber, email, id, store);
                        CustomerInterface(customer);
                        break;
                }
            }


        }
        public static void ManagerInterface(Manager manager)
        {
            Console.WriteLine("choice your option by chooce the right number.");

            Console.WriteLine("1 >add a category of products");
            Console.WriteLine("2 >add a product");
            Console.WriteLine("3 >remove a product");
            Console.WriteLine("4 >search a product");
            Console.WriteLine("5 >change price product");
            int selected = int.Parse(Console.ReadLine());


            switch (selected)
            {
                case 1:
                    Console.WriteLine("enter your category");
                    string category = Console.ReadLine();
                    manager.AddCategory(category);

                    break;
                case 2:
                    Console.WriteLine("please enter the name of product");
                    string nameProduct = Console.ReadLine();
                    Console.WriteLine("please enter the catalog number of product");
                    string catalog_umber = Console.ReadLine();
                    Console.WriteLine("please enter the desired price for product");
                    float priceOfProduct = float.Parse(Console.ReadLine());
                    Console.WriteLine("please enter the category name of product");
                    string categoryOfProduct = Console.ReadLine();
                    Product newProduct = new Product(nameProduct, catalog_umber, priceOfProduct, categoryOfProduct);
                    manager.AddProduct(newProduct);
                    break;
                case 3:////////////////// הפונקציה אמורה להיות שתקבל רק מספר קטלוג וקטגוריה ואז יחסוך את כל הקוד ויצירת פרסון חדש 
                    Console.WriteLine("please enter the category name of product");
                    string _categoryOfProduct = Console.ReadLine();
                    Console.WriteLine("please enter the catalog number of product");
                    string _catalog_umber = Console.ReadLine();
                    manager.RemoveProduct(_categoryOfProduct, _catalog_umber);
                    break;
                case 4:
                      manager.GetStore().SearchProduct(); //////////////////////
                    break;
                case 5:
                    Console.WriteLine("please add the catalog number");
                    string CatalogNumber = Console.ReadLine();
                    Console.WriteLine("please add the category of product");
                    string categoryNumber = Console.ReadLine();
                    Console.WriteLine("please add the new price");
                    float newPrice = float.Parse(Console.ReadLine());
                    manager.ChangePrice(CatalogNumber, categoryNumber, newPrice);
                    break;
            }

        }

        public static void EmployeeInterface(Employee employee)
        {
            Console.WriteLine("choice your option by chooce the right number.");

           
            Console.WriteLine("1 >add a product");
          
            Console.WriteLine("2 >search a product");
          
            int selected = int.Parse(Console.ReadLine());


            switch (selected)
            {
                
                case 1:
                    Console.WriteLine("please enter the name of product");
                    string nameProduct = Console.ReadLine();
                    Console.WriteLine("please enter the catalog number of product");
                    string catalog_umber = Console.ReadLine();
                    Console.WriteLine("please enter the desired price for product");
                    float priceOfProduct = float.Parse(Console.ReadLine());
                    Console.WriteLine("please enter the category name of product");
                    string categoryOfProduct = Console.ReadLine();
                    Product newProduct = new Product(nameProduct, catalog_umber, priceOfProduct, categoryOfProduct);
                    employee.AddProduct(newProduct);
                    break;
               
                case 2:
                    employee.GetStore().SearchProduct();//////////////////////
                    break;
            
            }
        }



        public static void CustomerInterface(Customer customer)
        {
            string letter = "y";
            while (letter!="N"&& letter != "n")
            {
                customer.AddToCart();
                Console.WriteLine("You want to continue buying?");
                Console.WriteLine("Enter Y or N");
                letter = Console.ReadLine();
            }

        }

    }
}
