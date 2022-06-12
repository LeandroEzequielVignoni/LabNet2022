using LinqExercises.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises.Logic
{
    public class CustomersLogic : BaseLogic
    {

        public string ReturnCustomer()
        {


            var query = from customers in _context.Customers
                        select customers;


            var costumers = query.First();

            return "Nombre: " + costumers.ContactName + "\n" + "Ciudad: " + costumers.City + "\n"+ "Nombre de la Compania: " + costumers.CompanyName;


        }

        public string ReturnWACustomers()
        {

            var list = new StringBuilder("Clientes de la Region de Washington: \n");

            var query = from customers in _context.Customers
                        where customers.Region == "WA"
                        select customers;

            

            foreach (Customers customers in query)
            {

                string customersStr = $"Nombre: {customers.ContactName}\nRegion: {customers.Region}\n";
                list.AppendLine(customersStr);

            }

            return list.ToString();
        }

        public string ReturnUpperAndLowerCase()
        {
            var list = new StringBuilder("Clientes Mayusculas y Minusculas: \n");

            var query = from customers in _context.Customers
                        select customers.ContactName;


            foreach (var customers in query)
            {
                list.AppendLine(customers.ToUpper());
                list.AppendLine(customers.ToLower());
            }

            return list.ToString();
        }
        public string ReturnThreeCustomersFromWA()
        {
            var list = new StringBuilder("3 Primeros Clientes de la region de Washington: \n");

            var query = _context.Customers.Where(c => c.Region == "WA").OrderBy(c => c.CustomerID);

            foreach (var customers in query)
            {

                string customersStr = $"Nombre: {customers.ContactName}\n";
                list.AppendLine(customersStr);

            }

            return list.ToString();

        }
        public string ReturnOrdersAndCustomers()
        {
            var list = new StringBuilder("Clientes con la cantidad de ordenes asociadas: \n");

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

                string customersStr = $"Id: {customer.ID}\nNombre: {customer.ContactName}\nCantidad de Ordenes: {customer.OrdersCuantity}\n";
                list.AppendLine(customersStr);

            }

            return list.ToString();
        }
    }
}
