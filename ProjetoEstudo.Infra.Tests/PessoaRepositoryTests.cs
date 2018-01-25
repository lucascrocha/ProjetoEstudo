using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoEstudo.Domain.Entities.Pessoa;
using ProjetoEstudo.Domain.Entities.Pessoa.ValueObject;
using ProjetoEstudo.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Infra.Tests
{
    [TestClass]
    public class PessoaRepositoryTests
    {
        private readonly RepositoryBase<Pessoa> _repositoryBase;

        public PessoaRepositoryTests()
        {
            _repositoryBase = new RepositoryBase<Pessoa>();
        }

        [TestMethod]
        public void PessoaRepository_CreatePessoa()
        {
            var pessoaTest = PessoaTestsData.ObterPessoa();
            var novaPessoa = new Pessoa("Lucas", new Cpf("84591898644"), PessoaTestsData.ObterEndereco());

            _repositoryBase.Add(novaPessoa);

            Assert.AreEqual(pessoaTest, _repositoryBase.GetById(pessoaTest.Id));
        }

    }
}