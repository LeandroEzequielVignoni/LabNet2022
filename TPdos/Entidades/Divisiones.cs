using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Divisiones
    {
        public static int EjemploDivionPorCero(int numero)
        {

            try
            {
                return numero / 0;
            }

            catch (Exception)
            {

                throw;
            }



        }

        public static float Division(int numero, int numeroDos)
        {


            return numero / numeroDos;


        }


    }
}
