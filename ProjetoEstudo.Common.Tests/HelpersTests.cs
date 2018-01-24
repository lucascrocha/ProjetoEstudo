using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Common.Tests
{
    [TestClass]
    public class HelpersTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Helper_ErrorIfStringIsNull()
        {
            Helpers.ForNullOrEmpty(null, "Item não pode ser nulo.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Helper_ErrorIfStringIsEmpty()
        {
            Helpers.ForNullOrEmpty("", "Item não pode ser vazio.");
        }

        [TestMethod]
        public void Helper_WillNotThrowError()
        {
            Helpers.ForNullOrEmpty("teste", "não vai jogar erro");
        }
    }
}