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

        // Para rendimentos até R$1.500,00 - isento (desconto 0)
        // Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3%
        // Para rendimentos acima de R$5.000,01 - desconto de 5%
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return rendimento;//0%
            }
            else if (rendimento <= 5000)
            {
                return rendimento - ((rendimento / 100) * 3);//3%
            }
            else
            {
                return rendimento - ((rendimento / 100) * 5);//5%
            }

        }
    }



}