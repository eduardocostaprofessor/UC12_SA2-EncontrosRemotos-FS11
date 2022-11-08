using Projeto_Console.Interfaces;

namespace Projeto_Console.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf;
        public string? DataNascimento;

        public bool ValidarDataNascimento(string dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}