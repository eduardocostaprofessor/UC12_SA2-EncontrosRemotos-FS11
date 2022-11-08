using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_Remoto_1.Interfaces;

namespace Encontro_Remoto_1.Classes
{
    public class Pessoa : IPessoa
    {
        public string Nome = "Eduardo Costa";
        public Endereco? Endereco;
        public float Rendimento;

        public float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}