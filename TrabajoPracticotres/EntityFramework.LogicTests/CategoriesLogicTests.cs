using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFramework.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Entities;

namespace EntityFramework.Logic.Tests
{
    [TestClass()]
    public class CategoriesLogicTests
    {
        

        [TestMethod]
        [ExpectedException(typeof(CharacterLimitExceededException))]
        public void Should_ThrowException_When_CharacterLimitIsExceeded()
        {
            Categories testCategory = new Categories("1111111111111111", "Texto de Ejemplo");
            var categoriesLogic = new CategoriesLogic();
            categoriesLogic.DataCheck(testCategory);
        }
    }
}