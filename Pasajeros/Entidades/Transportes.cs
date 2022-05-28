using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Transportes
    {
        protected int pasajeros;
        protected string nombreChofer;
        protected decimal kilometrosRecorridos = 0;
        protected float totalApagar = 0;
        protected int viajes = 5;
        
        
        
        


        public Transportes(int pasajeros, string nombreChofer)
        {


            this.pasajeros = pasajeros;
            this.nombreChofer = nombreChofer;


        }


        public int Pasajeros { get; private set; }

        public string NombreChofer { get; private set; }



        public abstract string Avanzar();

        public abstract string Detenerse();


        public string TotalViaje()
        {

            int auxiliar = (int)this.kilometrosRecorridos;

            this.kilometrosRecorridos = 0;

            return $"Nombre del Chofer:{this.nombreChofer}\nkilometros recorridos Totales: {auxiliar}\n";


        }


        public abstract string RealizarViajes();




    }
}
