using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_EXERC_3._4
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        protected Pessoa()
        {
        }

        protected Pessoa(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
