using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_EXERC_3._4
{
    class Agenda
    {
        public List<Contato> Contatos { get; set; } = new List<Contato>();

        public Agenda()
        {
        }

        public static void Menu()
        {
            Console.WriteLine("         AGENDA" +
                "\nEscolha sua opção:" +
                "\n1- Adicionar contato" +
                "\n2- Mostrar contatos" +
                "\n3- Remover todos os contatos" +
                "\n4- Sair do programa");
        }

        public void AddContato(Contato contato)
        {
            Contatos.Add(contato);
        }
    }
}
