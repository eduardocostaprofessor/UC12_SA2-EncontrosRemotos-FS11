using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Console.Interfaces;

namespace Projeto_Console.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public int Idade { get; set; }

        public string? corDeOlhos { get; private set; }

        private string? corDaPele;//get set
        public bool teste;

        public string? GetCorDaPele()
        {
            return this.corDaPele;
        }

        public void SetCorDaPele(string pCor)
        {
            this.corDaPele = pCor;
        }


        public void SetCorDeOlhos(string pCorOlho)
        {
            if (pCorOlho.Length >= 3)
            {

                this.corDeOlhos = pCorOlho;
            }
        }


        // construtor - método especial, sem retorno
        public Pessoa()
        {

        }

        public Pessoa(string pNome)
        {
            this.Nome = pNome;
        }

        public Pessoa(string pNome, Endereco pEndereco, float pRendimento)
        {
            this.Nome = pNome;
        }


        // Implementação da Interface Pessoa: IPessoa
        public abstract float PagarImposto(float rendimento);
        


        public virtual void Envelhecer()
        {
            this.Idade++;
        }
    }
}