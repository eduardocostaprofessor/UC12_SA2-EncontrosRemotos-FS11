using Encontro_Remoto_1.Interfaces;

namespace Encontro_Remoto_1.Classes
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