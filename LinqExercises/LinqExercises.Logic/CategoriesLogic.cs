using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public string ReturnCategories()
        {
            var list = new StringBuilder("categorías asociadas a los productos\n");

            var query = _context.Categories.OrderBy(x => x.CategoryName).ToList();

            foreach (var products in query)
            {

                string productsStr = $"Nombre: {products.CategoryName} \nId de Categoria: {products.CategoryID}\n";
                list.AppendLine(productsStr);

            }

            return list.ToString();
        }
    }
}
