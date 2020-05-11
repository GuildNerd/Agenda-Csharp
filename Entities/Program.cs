using Microsoft.VisualBasic;
using System;
using System.Text;
namespace LAB4_EXERC_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas-vindas à sua agenda\nPressione alguma tecla para abrir as opções");
            Console.ReadKey();
            Console.Clear();

            Agenda agenda = new Agenda();

            Agenda.Menu();
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Nome: ");
                            string nomePessoa = Console.ReadLine();
                            Console.Write("Endereço: ");
                            string enderecoPessoa = Console.ReadLine();
                            Console.Write("Pessoa física ou jurídica (F ou J)? ");
                            char tipoPessoa = char.ToUpper(char.Parse(Console.ReadLine()));

                            switch (tipoPessoa)
                            {
                                case 'F':
                                    Console.Write("Data de nascimento: ");
                                    DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Sexo (M ou F): ");
                                    char sexo = char.ToUpper(char.Parse(Console.ReadLine()));
                                    Console.Write("CPF: ");
                                    long cpf = long.Parse(Console.ReadLine());
                                    Pessoa pessoaF = new PFisica(dataNascimento, sexo, cpf, nomePessoa, enderecoPessoa);

                                    Contato contatoF = new Contato(pessoaF);

                                    agenda.AddContato(contatoF);
                                    break;
                                case 'J':
                                    Console.Write("Data de estabelecimento: ");
                                    DateTime dataEstabelecimento = DateTime.Parse(Console.ReadLine());
                                    Console.Write("CNPJ: ");
                                    long cnpj = long.Parse(Console.ReadLine());
                                    Pessoa pessoaJ = new PJuridica(dataEstabelecimento, cnpj, nomePessoa, enderecoPessoa);

                                    Contato contatoJ = new Contato(pessoaJ);

                                    agenda.AddContato(contatoJ);
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
                            Console.ReadKey();
                            Console.Clear();
                        } // fim da opção de criar contato
                        break;
                    case 2: // exibir os contatos
                        {
                            Console.Clear();
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("CONTATOS:");
                            sb.AppendLine("");
                            foreach (Contato contato in agenda.Contatos)
                            {
                                sb.Append("Nome: ");
                                sb.AppendLine(contato.Pessoa.Nome);
                                sb.Append("Endereço: ");
                                sb.AppendLine(contato.Pessoa.Endereco);
                                sb.AppendLine(contato.Pessoa.ToString());
                            }

                            Console.WriteLine(sb);
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3: // remover todos os contatos
                        {
                            Console.Clear();
                            agenda.Contatos.Clear();
                            Console.WriteLine("Contatos removidos");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4: // fechar programa
                        Console.WriteLine("Até mais! (Pressione uma tecla para encerrar)");
                        Console.ReadKey();
                        break;
                    default: // opção digitada foi inválida
                        Console.WriteLine("ERRO - OPÇÃO INVÁLIDA");
                        break;
                }

                Agenda.Menu();
                opcao = int.Parse(Console.ReadLine());
            }
        }
    }
}
