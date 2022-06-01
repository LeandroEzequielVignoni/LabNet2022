using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Tests
{
    [TestClass()]
    public class ExcepcionesTests
    {
        [TestMethod()]
        public void DivisionTest()
        {

            int numero = 20;
            int numeroDos = 10;
            float resultado = Divisiones.Division(numero, numeroDos);



            float resultadoEsperado = 2;



            Assert.IsTrue(resultado == resultadoEsperado);




        }

        [TestMethod()]

        [ExpectedException(typeof(DivideByZeroException))]

        public void EjemploDivionPorCeroTest()

        {

            Divisiones.EjemploDivionPorCero(5);


           
        }
    }
}