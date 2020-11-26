using System;

namespace Projeto_Passagens_aereas
{
    class Program
    {
        static void Main(string[] args)
        {   //Variáveis
            bool SenhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            //Dados
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];




            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("----Cadastro de Passagens----");
            Console.WriteLine("=============================");

            //Login
            do
            {
                Console.WriteLine("Digite a senha para acessar o sistema");
                string senha = Console.ReadLine();
                SenhaValida = Efetuarlogin(senha);
            }while (!SenhaValida);

            Console.WriteLine("OK, Vamos Prosseguir");

            do
            {
                Console.WriteLine("Digite a senha para acessar o sistema");
                string senha = Console.ReadLine();
                SenhaValida = Efetuarlogin(senha);
            } while (!SenhaValida);

            //menu

            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());



                switch (escolha)
                {

                    case 1:
                        Console.WriteLine("Cadastrar Passageiro");
                        do
                        {
                            if(contador < 5)
                            {
                            Console.WriteLine($"Digite o nome do passgeiro:");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a origem");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a Data do Vôo");
                            contador++;
                            }else{
                                Console.WriteLine("Limite Excedido");
                                break;
                            }
                            Console.WriteLine("Você  gostaria de Cadastrar um novo passageiro? S/N");
                            resposta = Console.ReadLine();

                        } while (resposta.ToUpper() == "S");
                        break;
                    case 2:
                         Console.WriteLine("Listar Passagens"); 
                         for (var i = 0; i < contador; i++)
                         {
                            Console.WriteLine($"Passageiro {nomes[i]}");
                         }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado Por Voar Na Clauber airlines");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;

                }

            }while (escolha != 0);




            //Funções 
          bool  Efetuarlogin(String senha){
                if(senha == "123456"){
                    Console.WriteLine("Senha permitida");
                    return true;
                }else{
                    Console.WriteLine("Senha Incorreta");
                    return false;
                }
            }
        }
    }
}
