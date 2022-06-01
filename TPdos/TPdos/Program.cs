using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TPdos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");

            //Punto 1

            try
            {
                int numero = int.Parse(Console.ReadLine());
                Divisiones.EjemploDivionPorCero(numero);

            }

            catch (DivideByZeroException ex)  
            {
                Console.WriteLine($"Se a lanzado una excepcion: {ex.Message}");

                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                
            }

            catch (FormatException ex)
            {

                Console.WriteLine($"Ingrese un numero correcto: {ex.Message}");


            }

            finally
            {

                Console.WriteLine("Operacion Terminada");
            }

            //Punto 2

            try
            {

                Console.WriteLine("Ingrese el Dividendo: ");
       
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Divisor: ");

                int numeroDos = int.Parse(Console.ReadLine());

                

                float resultado = Divisiones.Division(numero, numeroDos);

                Console.WriteLine($"El Resultado de la Division es: {resultado}");

            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"Solo PIPA divide por Cero\n{ex.Message}");


                
            }

            catch (FormatException)
            {

                Console.WriteLine("Seguro ingresaste una letra pa");


            }

            //Punto 3

            try
            {
                Logic.ThrowException();
            }
            catch (StackOverflowException e)
            {

                Console.WriteLine($"Tipo de Excepcion: {e.GetType().ToString()}\nDescripcion del Error:{e.Message}");
            }


            //Punto 4

            try
            {
                Logic.ThrowCustomException();
            }
            catch (CustomException e)
            {

                Console.WriteLine($"Tipo de Excepcion: {e.GetType().ToString()}\nDescripcion del Error:{e.Message}");
            }


            Console.ReadKey();
        }
    }
}
