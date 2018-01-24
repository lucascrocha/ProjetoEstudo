using ProjetoEstudo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Domain.Entities.Pessoa.ValueObject
{
    public class Endereco
    {
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Numero { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }

        public Endereco(string cep, string bairro, string cidade, string estado, string logradouro, string numero, string complemento)
        {
            SetCep(cep);
            SetBairro(bairro);
            SetCidade(cidade);
            SetEstado(estado);
            SetLogradouro(logradouro);
            SetNumero(numero);
            SetComplemento(complemento);
        }

        private void SetComplemento(string complemento)
        {
            Complemento = complemento;
        }

        private void SetNumero(string numero)
        {
            Helpers.ForNullOrEmpty(numero, "Número não pode ser vazio ou nulo");
            Numero = numero;
        }

        private void SetLogradouro(string logradouro)
        {
            Helpers.ForNullOrEmpty(logradouro, "Logradouro não pode ser vazio ou nulo");
            Logradouro = logradouro;
        }

        private void SetEstado(string estado)
        {
            Helpers.ForNullOrEmpty(estado, "Estado não pode ser vazio ou nulo");
            Estado = estado;
        }

        private void SetCidade(string cidade)
        {
            Helpers.ForNullOrEmpty(cidade, "Cidade não pode ser vazio ou nulo");
            Cidade = cidade;
        }

        private void SetBairro(string bairro)
        {
            Helpers.ForNullOrEmpty(Bairro, "Bairro não pode ser vazio ou nulo");
            Bairro = bairro;
        }

        private void SetCep(string cep)
        {
            Helpers.ForNullOrEmpty(Cep, "Cep não pode ser vazio ou nulo");
            Cep = cep;
        }
    }
}