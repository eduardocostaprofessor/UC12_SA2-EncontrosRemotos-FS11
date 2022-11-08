using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Console.Interfaces;

namespace Projeto_Console.Classes
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