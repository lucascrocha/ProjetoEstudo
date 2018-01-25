using ProjetoEstudo.Domain.Entities.Pessoa;
using ProjetoEstudo.Domain.Entities.Pessoa.ValueObject;
using System.Collections.Generic;

namespace ProjetoEstudo.Infra.Tests
{
    public class PessoaTestsData
    {
        public static Endereco ObterEndereco()
        {
            return new Endereco("58046070", "Altiplano Cabo Branco", "João Pessoa", "PB", "Rua Olívia de Farias Gabino", "487", "");
        }

        public static List<Pessoa> ListarPessoas()
        {
            return new List<Pessoa>
            {
                new Pessoa("Lucas", new Cpf("84591898644"), ObterEndereco()),
                new Pessoa("Lucas", new Cpf("76475495450"), ObterEndereco()),
                new Pessoa("Lucas", new Cpf("64438814782"), ObterEndereco())
            };
        }

        public static Pessoa ObterPessoa()
        {
            return new Pessoa("Lucas", new Cpf("84591898644"), ObterEndereco());
        }
    }
}