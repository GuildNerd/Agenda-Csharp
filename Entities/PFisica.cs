using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_EXERC_3._4
{
    class PFisica : Pessoa
    {
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public long CPF { get; set; }

        public PFisica()
        {
        }

        public PFisica(DateTime dataNascimento, char sexo, long cpf, string nome, string endereco) : base(nome, endereco)
        {
            DataNascimento = dataNascimento;
            Sexo = sexo;
            CPF = cpf;
        }

        public override string ToString()
        {
            return "\nPessoa Física" + "\nData de nascimento: " + DataNascimento.ToString("dd/MM/yyyy") + "\nCPF: " + CPF + "\nSexo: " + Sexo + "\n";
        }
    }
}
