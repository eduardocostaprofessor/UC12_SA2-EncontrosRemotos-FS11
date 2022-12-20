using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Console.Interfaces
{
    public interface IPessoaJuridica
    {
        public bool ValidarCnpj( string cnpj );
    }
}