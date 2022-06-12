using LinqExercises.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises.Logic
{
    public class ProductsLogic : BaseLogic
    {

        public string ReturnProducts()
        {
            var list = new StringBuilder("Lista de productos sin Stock: \n");
            var query = _context.Products.Where(p => p.UnitsInStock == 0).ToList();

            foreach (var product in query)
            {

                string productStr = $"{product.ProductName}\n";
                list.AppendLine(productStr);

            }

            return list.ToString();
        }


        public string ReturnProductsStock()
        {
            var list = new StringBuilder("Productos en stock y que Cuestan mas de 3$ la unidad: \n");

            var query = _context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).ToList();

            foreach (var product in query)
            {

                string productStr = $"Nombre: {product.ProductName}\nPrecio: {product.UnitPrice}\n";
                list.AppendLine(productStr);

            }

            return list.ToString();

        }

        public string OrderProductsByName()
        {
            var list = new StringBuilder("Lista de Productos Ordenados por Nombre: \n");

            var query = from products in _context.Products
                        orderby products.ProductName
                        select products;

            foreach (var order in query)
            {

                string orderStr = $"{order.ProductName}\n";
                list.AppendLine(orderStr);

            }

            return list.ToString();
        }
        public string OrderProductsByUnitStock()


        {
            var list = new StringBuilder("Lista de productos ordenados por stock de mayor a menor: \n");

            var query = from products in _context.Products
                        orderby products.UnitsInStock descending
                        select products;

            foreach (var products in query)
            {

                string productsStr = $"{products.ProductName}\nUnidades de Stock: {products.UnitsInStock}\n";
                list.AppendLine(productsStr);

            }

            return list.ToString();
        }

        public string ReturnTheFirstProduct()
        {

            

            var query = from products in _context.Products
                        select products;

            

            var elemento = query.First();

            return "Nombre " + elemento.ProductName + "\n" + "Id: " + elemento.ProductID + "\n" + "Id Del Proveedor:" + elemento.SupplierID + "\n" +  "Id de categoria:" + elemento.CategoryID + "\n" + "Cantidad por Unidad: " + elemento.QuantityPerUnit + "\n" + "Precio por Unidad: " + elemento.UnitPrice + "\n" + "Stock de Unidades: " + elemento.UnitsInStock + "\n" + "Unidades en orden: " + elemento.UnitsOnOrder + "\n" + "Reordenamiento: " + elemento.ReorderLevel + "\n"+ "Discontinuados: " + elemento.Discontinued;
        }

        public bool ReturnFirstOrNull()
        {


            var flag = _context.Products.FirstOrDefault(x => x.ProductID == 789);

            if (flag == null)
            {

                return false;

            }

            return true;
        }
    }
}
