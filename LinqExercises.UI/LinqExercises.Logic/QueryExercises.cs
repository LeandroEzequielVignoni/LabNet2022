using LinqExercises.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises.Logic
{
    public class QueryExercises : BaseLogic
    {
            
        public QueryExercises()
        {

        }

        //Punto 1
        public string ReturnCustomer()
        {
            

            var query = from customers in _context.Customers
                        select customers;
           

            var costumers = query.First();

            return costumers.ContactName + "\n" + costumers.CustomerID + "\n" + costumers.CompanyName;


        }
        //Punto 2
        public string ReturnProducts()
        {
            var list = new StringBuilder("Lista de productos sin Stock\n");
            var query = _context.Products.Where(p => p.UnitsInStock == 0).ToList();

            foreach (var product in query)
            {

                string productStr = $"{product.ProductName}";
                list.AppendLine(productStr);

            }

            return list.ToString();
        }

        //Punto 3
        public string ReturnProductsStock()
        {
            var list = new StringBuilder("Productos en stock y que Cuestan mas de 3$ la unidad\n");

            var query = _context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).ToList();

            foreach (var product in query)
            {

                string productStr = $"{product.ProductName}";
                list.AppendLine(productStr);

            }

            return list.ToString();

        }
        //Punto 4
        public string ReturnWACustomers()
        {

            var list = new StringBuilder("Costumers de la Region de Washington\n");

            var query = from customers in _context.Customers
                        where customers.City == "WA"
                       select customers;

            foreach (var costumers in query)
            {

                string productStr = $"{costumers.ContactName}, {costumers.Region}";
                list.AppendLine(productStr);

            }

            return list.ToString();
        }

        //Punto 5
        public Products ReturnFirstOrNull()
        {
            

            return _context.Products.FirstOrDefault(x => x.ProductID == 789);

            
        }

        //Punto 6, Preguntar

        //Punto 7
        public string ReturnOrder()
        {

            var list = new StringBuilder("Region WA y Fecha mayor a 1997\n");
            
            var query = from orders in _context.Orders
                        join customers in _context.Customers
                        on orders.CustomerID equals customers.CustomerID
                        where orders.OrderDate > new DateTime(1997, 1, 1) && customers.Region == "WA"
                        select new 
                        {
                            CustomerName = customers.ContactName,
                            CustomerRegion = customers.Region,
                            OrderId = orders.OrderID,
                            OrderDate = orders.OrderDate
                        };

            foreach (var orders in query)
            {

                string productStr = $"{orders.CustomerName}, {orders.CustomerRegion}, {orders.OrderId}, {orders.OrderDate}";
                list.AppendLine(productStr);

            }

            return list.ToString();
        }

        //Punto 8

        public string ReturnThreeCustomersFromWA()
        {
            var list = new StringBuilder("3 Primeros Costumers region WA\n");

            var query = _context.Customers.Where(c => c.Region == "WA").OrderBy(c => c.CustomerID);

            foreach (var customers in query)
            {

                string customersStr = $"{customers.ContactName}";
                list.AppendLine(customersStr);

            }

            return list.ToString();

        }

        //Punto 9

        public string OrderProductsByName()
        {
            var list = new StringBuilder("Lista de Productos Ordenados por Nombre: \n");

            var query = from products in _context.Products
                        orderby products.ProductName
                        select products;

            foreach (var order in query)
            {

                string orderStr = $"{order.ProductName}";
                list.AppendLine(orderStr);

            }

            return list.ToString();
        }

        //Punto 10

        public string OrderProductsByUnitStock()


        {
            var list = new StringBuilder("Lista de productos ordenados por Unit en stock de mayor a menor: \n");

            var query = from products in _context.Products
                        orderby products descending
                        select products;

            foreach (var products in query)
            {

                string productsStr = $"{products.ProductName}";
                list.AppendLine(productsStr);

            }

            return list.ToString();
        }

        //Punto 11

        public string ReturnCategories()
        {
            var list = new StringBuilder("categorías asociadas a los productos\n");

            var query = _context.Categories.OrderBy(x => x.CategoryName).ToList();

            foreach (var products in query)
            {

                string productsStr = $"{products.CategoryName}";
                list.AppendLine(productsStr);

            }

            return list.ToString();
        }

        //Punto 12

        public string ReturnTheFirstProduct()
        {

            var list = new StringBuilder("primer elemento de una lista de productos\n");

            var query = from products in _context.Products
                        select products;

            string productsStr = query.Take(1).ToString();

            list.AppendLine(productsStr);

            return list.ToString();
        }

        //Punto 13

        public string ReturnOrdersAndCustomers()
        {
            var list = new StringBuilder("customer con la cantidad de ordenes asociadas\n");

            var query = from customers in _context.Customers
                        join orders in _context.Orders
                        on customers.CustomerID
                            equals orders.CustomerID
                        into count

                        select new
                        {
                            ID = customers.CustomerID,

                            ContactName = customers.ContactName,

                            OrdersCuantity = count.Count()
                        };

            foreach (var customer in query)
            {

                string customersStr = $"{customer.ID}, {customer.ContactName}, {customer.OrdersCuantity}";
                list.AppendLine(customersStr);

            }

            return list.ToString();
        }
    }
}
