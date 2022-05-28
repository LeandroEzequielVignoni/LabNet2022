using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taxi : Transportes
    {
        public int tarifa = 5;
        protected int aPagarTaxi = 0;
        
        

        public Taxi(int pasajeros, string nombreChofer) : base(pasajeros, nombreChofer)
        {


        }

        public override string Avanzar()
        {
            var distanciaViaje = numeroRandomTaxi();

            this.kilometrosRecorridos = distanciaViaje;
            tarifa = 5;

            if (kilometrosRecorridos > 5)
            {
                tarifa = 15;

                
                

            }

            return $"El viaje sale con {pasajeros} Pasajeros\nLa Tarifa por Fraccionamiento es de: {tarifa}";


        }

        public override string Detenerse()
        {
            

            aPagarTaxi = (int)this.kilometrosRecorridos * tarifa;



            return $"El viaje termina para un total de {aPagarTaxi} Pesos";
        }


        private int numeroRandomTaxi()
        {


            return new Random(Guid.NewGuid().GetHashCode()).Next(1, 20);


        }

        public override string RealizarViajes()
        {


            var sb = new StringBuilder("Salimos a Destino:\n");
            for (int i = 0; i < 1; i++)
            {


                sb.AppendLine(this.Avanzar());

                sb.AppendLine(this.Detenerse());








            }
            return sb.ToString();
        }
    }
}
