using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CustomException : Exception
    {
        public override string Message => "Me parece que algo salio mal capo" + base.Message;

        public CustomException(string mensaje):base(mensaje)
        {

            

        }

    }
}
