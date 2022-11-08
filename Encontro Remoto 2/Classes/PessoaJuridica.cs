using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_Remoto_1.Interfaces;
using Encontro_Remoto_1;

namespace Encontro_Remoto_1.Classes
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