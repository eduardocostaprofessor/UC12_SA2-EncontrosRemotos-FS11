using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Console.Interfaces;
using Projeto_Console;

namespace Projeto_Console.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}