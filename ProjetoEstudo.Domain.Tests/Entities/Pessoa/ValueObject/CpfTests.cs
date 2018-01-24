using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoEstudo.Domain.Entities.Pessoa.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Domain.Tests.Entities.Pessoa.ValueObject
{
    [TestClass]
    public class CpfTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cpf_InvalidCpf()
        {
            var cpf = new Cpf("68498468411");
        }

        [TestMethod]
        public void Cpf_ValidCpf()
        {
            var cpf = new Cpf("00812480163");
        }
    }
}