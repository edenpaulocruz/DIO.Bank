using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        // ListarContas();
                        break;
                    case "2":
                        // InserirConta();
                        break;
                    case "3":
                        // Transferir();
                        break;
                    case "4":
                        // Sacar();
                        break;
                    case "5":
                        // Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        // throw new ArgumentOutRangeException();
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.WriteLine();
        }
            
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
