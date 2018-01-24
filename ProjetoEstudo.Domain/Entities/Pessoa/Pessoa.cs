using ProjetoEstudo.Common;
using ProjetoEstudo.Domain.Entities.Pessoa.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Domain.Entities.Pessoa
{
    public class Pessoa : EntityBase
    {
        protected Pessoa()
        {

        }

        public string Nome { get; private set; }
        public Cpf Cpf { get; private set; }
        public Endereco Endereco { get; private set; }

        public Pessoa(string nome, Cpf cpf, Endereco endereco)
        {
            SetNome(nome);
            SetCpf(cpf);
            SetEndereco(endereco);
            DataInclusao = DateTime.Now;
        }

        private void SetNome(string nome)
        {
            Helpers.ForNullOrEmpty(nome, "Nome da pessoa não pode ser nulo ou vazio.");
            Nome = nome;
        }

        private void SetEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        private void SetCpf(Cpf cpf)
        {
            Helpers.ForNullOrEmpty(cpf.Codigo, "CPF não pode ser nulo ou vazio");
            Cpf = cpf;
        }
    }
}