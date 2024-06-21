using System;

namespace AT_02CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaC = new ContaCorrente();

            string opcao;
            int num = 0;
            double valor = 0;
            do { 
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("1 para sacar");
                Console.WriteLine("2 para apresentar saldo");
                Console.WriteLine("3 para depositar");
                Console.WriteLine("4 para sair");
                opcao = Console.ReadLine();
              try
                {
                    num = int.Parse(opcao);

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Informe o valor para o saque: ");
                            string entradaSaque = Console.ReadLine();
                            try
                            {
                                valor = double.Parse(entradaSaque);
                                contaC.Sacar(valor);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Valor inválido, digite um valor válido!");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Saldo atual: {contaC.Saldo:c}");
                            break;
                        case 3:
                            Console.WriteLine("Informe o valor para deposito: ");
                            string entradaDeposito = Console.ReadLine();
                            try
                            {
                                valor = int.Parse(entradaDeposito);
                                contaC.Depositar(valor);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Valor inválido, digite um valor válido!");
                            }
                        
                            break;
                        case 4:
                            Console.WriteLine("Saindo...");
                            break;
                        default: Console.WriteLine("Opção inválida, informe um numero válido");
                            break;
                    }

                }
                catch(FormatException) 
                {
                    Console.WriteLine("Valor inválido, informe um numero inteiro");
                  
                }
            } while (num !=4);

        }
    }
}
