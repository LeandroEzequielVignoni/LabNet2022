using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises.Logic
{
    public class OrdersLogic : BaseLogic
    {

        public string ReturnOrder()
        {

            var list = new StringBuilder("Region Washington y Fecha mayor a 1997: \n");

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

                string productStr = $"Nombre: {orders.CustomerName}\nRegion: {orders.CustomerRegion}\nId de orden: {orders.OrderId}\nDia de orden:{orders.OrderDate}\n";
                list.AppendLine(productStr);

            }

            return list.ToString();
        }


    }
}
