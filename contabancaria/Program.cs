﻿using System;
using System.Linq.Expressions;

namespace contabancaria
{
    public class Program
    {
        private static ConsoleKeyInfo ConsoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.WriteLine("                 BANCO DO BRAZIL COM Z                ");
                Console.WriteLine("                                                      ");
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.WriteLine("                 1 - Criar Conta                      ");
                Console.WriteLine("                 2 - Listar todas as Contas           ");
                Console.WriteLine("                 3 - Buscar Conta por Numero          ");
                Console.WriteLine("                 4 - Atualizar Dados da Conta         ");
                Console.WriteLine("                 5 - Apagar Conta                     ");
                Console.WriteLine("                 6 - Sacar                            ");
                Console.WriteLine("                 7 - Depositar                        ");
                Console.WriteLine("                 8 - Transferir Valores entre Contas  ");
                Console.WriteLine("                 9 - Sair                             ");
                Console.WriteLine("                                                      ");
                Console.WriteLine("******************************************************");
                Console.WriteLine("Entre com a opção desejada:                           ");
                Console.WriteLine("                                                      ");
                Console.ResetColor();

                opcao =Convert.ToInt32(Console.ReadLine());

                if (opcao == 9) 
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nBanco do Brazil com Z - O seu Futuro começa aqui!");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 2:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 3:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 4:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 5:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 6:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Saque\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 7:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Depósito\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 8:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Transferência entre Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    default:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }

            static void Sobre()
            {
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("Projeto Desenvolvido por: Valéria Carvalho");
                Console.WriteLine("Generation Brasil - generation@generation.org");
                Console.WriteLine("github.com/dValsc");
                Console.WriteLine("*********************************************************");
            }

            static void KeyPress()
            {
                do
                {
                    Console.Write("\nPressione Enter para Continuar...");
                    ConsoleKeyInfo = Console.ReadKey();
                } while (ConsoleKeyInfo.Key != ConsoleKey.Enter);
            }

        }
    }
}