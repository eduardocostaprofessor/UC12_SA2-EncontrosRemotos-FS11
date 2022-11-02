using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_1.Interfaces
{
    public interface IPessoaFisica
    {
        public bool ValidarDataNascimento(string dataNasc);
    }
}