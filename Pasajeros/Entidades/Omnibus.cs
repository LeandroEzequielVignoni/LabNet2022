using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{

   
    public class Omnibus : Transportes

        

    {
        protected int tarifaBase = 2;
        public int aPagar = 0;
        protected int pasajeroAuxiliar;
        
        
        



        public Omnibus(int pasajeros, string nombreChofer) : base(pasajeros, nombreChofer)
        {




        }
        public override string Avanzar()
        {

            var distanciaViaje = numeroRandom();


            
            this.kilometrosRecorridos += distanciaViaje;
            
            return $"-------------------\nContamos con {pasajeros} Pasajeros\n-------------------";
            


        }

        public override string Detenerse()

        {
            int pasajerosAux = this.pasajeros;


            aPagar = (int)this.kilometrosRecorridos * 2;

            if (kilometrosRecorridos > 5 )
            {

                aPagar = (int)this.kilometrosRecorridos * 10;

            }



            this.pasajeros = numeroRandomPasajeros();

            

            return $"Nos hemos detenido!\nLos kilometros recorridos hasta ahora son: {this.kilometrosRecorridos}\nA pagar: {aPagar}\nEramos {pasajerosAux} Pasajeros";
            
        }

        private int numeroRandom()
        {


            return new Random(Guid.NewGuid().GetHashCode()).Next(1, 20);


        }
        private int numeroRandomPasajeros()
        {


            return new Random(Guid.NewGuid().GetHashCode()).Next(30, 100);


        }

        public override string RealizarViajes()
        {


            var sb = new StringBuilder("Salimos a Destino:\n");
            for (int i = 0; i < viajes; i++)
            {



                
                sb.AppendLine(this.Avanzar());

                sb.AppendLine(this.Detenerse());








            }

            return sb.ToString();
        }

    }
}
