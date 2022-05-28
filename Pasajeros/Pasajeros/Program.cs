using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Pasajeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            int contadorTaxi = 0;
            int contadorOmnibus = 0;
            List<Omnibus> omnibus = new List<Omnibus>()
            {
                 new Omnibus(100, "Esteban"),
                 new Omnibus(30, "Antonio"),
                 new Omnibus(10, "Eduardo"),
                 new Omnibus(20, "Matias"),
                 new Omnibus(50, "Ariel")




            };

            List<Taxi> taxi = new List<Taxi>()

            {

                 new Taxi(4, "Jorge"),
                 new Taxi(2, "Mario"),
                 new Taxi(3, "Raul"),
                 new Taxi(1, "Octavio"),
                 new Taxi(2, "Claudio"),






            };


            do
            {
                Console.Clear();
                Console.WriteLine("Por favor Ingrese una opcion:\n");
                Console.WriteLine("1-Viaje Omnibus\n");
                Console.WriteLine("2-Viaje Taxi\n");
                Console.WriteLine("3-Salir\n");

                bool resultado = int.TryParse(Console.ReadLine(), out opcion);

                if (resultado)
                {

                    switch (opcion)
                    {
                        case 1:

                            contadorOmnibus = 0;
                            Console.Clear();
                            foreach (var transporteOmnibus in omnibus)
                            {
                                Console.Clear();
                                contadorOmnibus++;
                                Console.Write($"Omnibus {contadorOmnibus}:\n");
                                //Console.WriteLine(transporteOmnibus.Avanzar());



                                Console.WriteLine(transporteOmnibus.RealizarViajes());

                                Console.WriteLine(transporteOmnibus.TotalViaje());
                                Console.WriteLine("Oprima cualquier tecla para ver el siguiente viaje o N para volver al menu");
                                var vuelta = Console.ReadLine();
                                if (vuelta == "n")
                                {
                                    break;

                                }

                                




                            }

                            break;

                        case 2:
                                Console.Clear();

                                contadorTaxi = 0;
                                foreach (var transporteTaxi in taxi)
                                {
                                    Console.Clear();
                                    contadorTaxi++;
                                    Console.Write($"Taxi {contadorTaxi}:\n");
                                    //Console.WriteLine(transporteTaxi.Avanzar());
                                    Console.WriteLine(transporteTaxi.RealizarViajes());
                                    Console.WriteLine(transporteTaxi.TotalViaje());
                                    Console.WriteLine("Oprima cualquier tecla para ver el siguiente viaje o N para volver al menu");
                                    var vuelta = Console.ReadLine();
                                    if (vuelta == "n")
                                    {
                                        break;

                                    }


                                }

                                break;

                        case 3: Console.Clear(); 
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

                
                



            } while (opcion != 3);





          

            
        }





    }

}
