using LinqExercises.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {


               

                    var queryCustomers = new CustomersLogic();

                    var queryProducts = new ProductsLogic();

                    var queryOrders = new OrdersLogic();

                    var queryCategories = new CategoriesLogic();


            Console.WriteLine("Punto 1:\n");        

            Console.WriteLine(queryCustomers.ReturnCustomer());

                    Console.ReadLine();

            Console.WriteLine("Punto 2:\n");

            Console.WriteLine(queryProducts.ReturnProducts());

                   Console.ReadLine();

            Console.WriteLine("Punto 3:\n");

            Console.WriteLine(queryProducts.ReturnProductsStock());

                   Console.ReadLine();

            Console.WriteLine("Punto 4:\n");

            Console.WriteLine(queryCustomers.ReturnWACustomers());

                    Console.ReadLine();

            Console.WriteLine("Punto 5:\n");

            Console.WriteLine(queryProducts.ReturnFirstOrNull());

            Console.ReadLine();

            Console.WriteLine("Punto 6:\n");

            Console.WriteLine(queryCustomers.ReturnUpperAndLowerCase());

            Console.ReadLine();

            Console.WriteLine("Punto 7:\n");
            Console.WriteLine(queryOrders.ReturnOrder());

                    Console.ReadLine();

            Console.WriteLine("Punto 8:\n");
            Console.WriteLine(queryCustomers.ReturnThreeCustomersFromWA());

                    Console.ReadLine();

            Console.WriteLine("Punto 9:\n");
            Console.WriteLine(queryProducts.OrderProductsByName());

                    Console.ReadLine();

            Console.WriteLine("Punto 10:\n");
            Console.WriteLine(queryProducts.OrderProductsByUnitStock());

                    Console.ReadLine();

            Console.WriteLine("Punto 11:\n");
            Console.WriteLine(queryCategories.ReturnCategories());

                    Console.ReadLine();

            Console.WriteLine("Punto 12:\n");
            Console.WriteLine(queryProducts.ReturnTheFirstProduct());

                    Console.ReadLine();

            Console.WriteLine("Punto 13:\n");
            Console.WriteLine(queryCustomers.ReturnOrdersAndCustomers());

                    Console.ReadLine();




        }
    }
}
