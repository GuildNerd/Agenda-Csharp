using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_EXERC_3._4
{
    class PJuridica : Pessoa
    {
        public DateTime DataEstabelecimento { get; set; }
        public long CNPJ { get; set; }

        public PJuridica()
        {
        }

        public PJuridica(DateTime dataEstabelecimento, long cnpj, string nome, string endereco) : base (nome, endereco)
        {
            DataEstabelecimento = dataEstabelecimento;
            CNPJ = cnpj;
        }

        public override string ToString()
        {
            return "\nPessoa Jurídica" + "\nData do estabelecimento: " + DataEstabelecimento.ToString("dd/MM/yyyy") + "\nCNPJ: "+ CNPJ + "\n";
        }
    }
}
