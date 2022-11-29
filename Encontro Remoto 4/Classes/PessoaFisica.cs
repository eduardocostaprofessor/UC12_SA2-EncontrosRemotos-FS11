using Projeto_Console.Interfaces;

namespace Projeto_Console.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf;
        public string? DataNascimento;

        public bool ValidarDataNascimento(string dataNasc)
        {
            //("20/07/1982")
            //("1982","07", "20") - (AAAA, MM, DD)
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;//qtd anos
               
                // Console.WriteLine($"String Convertida em Datetime: {dataConvertida}");
                // Console.WriteLine($"Anos: {anos}");
                if (anos >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }

        public override void Envelhecer()
        {

            this.Idade += 2;
        }
    }
}