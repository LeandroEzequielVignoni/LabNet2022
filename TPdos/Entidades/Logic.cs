using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Logic
    {
        public static void ThrowException()
        {


            throw new StackOverflowException();

        }

        public static void ThrowCustomException()
        {

            throw new CustomException(" Ocurrio Una excepcion");


        }

    }
}
