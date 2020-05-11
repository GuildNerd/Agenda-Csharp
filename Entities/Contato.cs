using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_EXERC_3._4
{
    class Contato
    {
        public Pessoa Pessoa { get; set; }

        public Contato(Pessoa pessoa)
        {
            Pessoa = pessoa;
        }
    }
}
