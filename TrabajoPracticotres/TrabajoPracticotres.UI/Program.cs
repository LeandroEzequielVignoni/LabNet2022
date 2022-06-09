using EntityFramework.Entities;
using EntityFramework.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabajoPracticotres.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();

            

            


             
             SuppliersLogic suppliersLogic = new SuppliersLogic();

             


           

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Por favor Ingrese una opcion:\n");
                Console.WriteLine("1-Ver lista Category\n");
                Console.WriteLine("2-Ver lista Suppliers\n");
                Console.WriteLine("3-Insertar valor a Category\n");
                Console.WriteLine("4-Delete valor por ID en Category\n");
                Console.WriteLine("5-Update valor por ID en Category\n");
                Console.WriteLine("6-Para Salir\n");

                bool resultado = int.TryParse(Console.ReadLine(), out opcion);

                if (resultado)
                {

                    switch (opcion)
                    {
                        case 1:

                            Console.Clear();
                            foreach (var item in categoriesLogic.GetAll())
                            {
                                Console.WriteLine($"{item.CategoryID} - {item.CategoryName} - {item.Description}");
                            }


                            

                            Console.WriteLine("Oprima cualquier tecla para volver al menu");

                            Console.ReadLine();
                            


                            break;

                        case 2:

                            Console.Clear();
                            foreach (var item in suppliersLogic.GetAll())
                            {
                                Console.WriteLine("");
                                Console.WriteLine($"{item.SupplierID} - {item.CompanyName} - {item.ContactName} - {item.ContactTitle} - {item.Address} - {item.City} - {item.PostalCode} - {item.Region} - {item.PostalCode} - {item.Country} - {item.Phone} - {item.Fax} - {item.HomePage}");
                                //Se recomienda ver en Pantalla Completa la consola para poder ver los datos de una forma ordenada y entendible
                            }

                            Console.WriteLine("Oprima cualquier tecla para volver al menu");

                            Console.ReadLine();

                            break;

                        case 3:

                            Console.Clear();

                            

                            Console.WriteLine("Ingrese los valores a Insertar en Orden: ");




                            try
                            {
                                Console.WriteLine("\nIngrese la Categoria Nueva: ");

                                string newCategoryInsert = Console.ReadLine();

                                Console.WriteLine("\nIngrese la Descripcion Nueva: ");

                                string newDescriptionInsert = Console.ReadLine();

                                Categories newCategory = new Categories(newCategoryInsert, newDescriptionInsert);
                                categoriesLogic.DataCheck(newCategory);

                               
                                categoriesLogic.Add(newCategory);
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine($"{ex.Message}");

                                Console.ReadLine();


                            }
                            catch (CharacterLimitExceededException ex)
                            {
                                Console.WriteLine($"Se han Excedido los Caracteres: {ex.Message}");

                                Console.ReadLine();
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine($"Por favor ingrese los valores adecuadamente: {ex.Message}");

                                Console.ReadLine();
                            }


                            break;

                        case 4:

                            Console.WriteLine("Por favor Ingrese el numero ID del Dato que desea eliminar");

                            try
                            {
                                int numeroId = int.Parse(Console.ReadLine());

                                categoriesLogic.Delete(numeroId);

                                
                            }
                            
                            catch (FormatException ex)
                            {

                                Console.WriteLine($"Ingrese un numero ID correcto: {ex.Message}");
                                Console.ReadLine();



                            }

                            catch (ArgumentNullException ex)
                            {
                                Console.WriteLine($"Ingrese un numero ID correcto: {ex.Message}");

                                Console.ReadLine();
                                
                            }

                            catch(System.Data.Entity.Infrastructure.DbUpdateException ex) 
                            
                            {

                                Console.WriteLine($"Esta ID no se puede Borrar: {ex.Message}");

                                Console.ReadLine();




                            }



                            break;


                        case 5:

                            Console.WriteLine("Por favor Ingrese el numero ID del Dato que desea hacer Update");

                            try
                            {
                                int numberId = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nIngrese la Categoria Nueva: ");

                                string newCategory = Console.ReadLine();

                                Console.WriteLine("\nIngrese la Descripcion Nueva: ");

                                string newDescription = Console.ReadLine();

                                Categories updatedItem = new Categories(numberId, newCategory, newDescription);

                                categoriesLogic.DataCheck(updatedItem);

                                categoriesLogic.Update(updatedItem);

                                


                            }
                            catch (InvalidOperationException ex)
                            {

                                Console.WriteLine($"Este ID no Existe: {ex.Message}");
                                Console.ReadLine();



                            }
                            catch (FormatException ex)
                            {

                                Console.WriteLine($"Ingrese un numero ID correcto: {ex.Message}");
                                Console.ReadLine();



                            }

                            catch (ArgumentNullException ex)
                            {
                                Console.WriteLine($"Ingrese un numero ID correcto: {ex.Message}");

                                Console.ReadLine();

                            }
                            catch (CharacterLimitExceededException ex)
                            {
                                Console.WriteLine($"Se han Excedido los Caracteres: {ex.Message}");

                                Console.ReadLine();
                            }

                            break;


                        case 6:
                            Console.Clear();
                            Console.WriteLine("Que tenga un buen dia"); break;


                        default:
                            Console.WriteLine("Ingrese un Numero valido");
                            break;















                    }











                }
                else
                {

                    Console.WriteLine("Ingrese un valor valido");

                }






            } while (opcion != 6);





            Console.ReadLine();


        }





    }

}












        
    

