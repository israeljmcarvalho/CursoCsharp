using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesProject.Session_5
{
    class S5Conta_Main
    {

        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = (Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)?");
            string haveraDI = Console.ReadLine();

            double valorDeposito = 0;
            double valorSaque = 0;

            if (haveraDI.ToUpper() == "S")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine());
            }

            S5_Conta Conta1 = new S5_Conta(conta, nome, valorDeposito);
            

            Console.WriteLine(Environment.NewLine + "Dados da conta:" + Conta1);

            Console.Write(Environment.NewLine + "Entre um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine());
            Conta1.RealizarDeposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: " + Conta1);

            Console.Write(Environment.NewLine + "Entre um valor para saque: ");
            valorSaque = double.Parse(Console.ReadLine());
            Conta1.RealizarSaque(valorSaque);

            Console.WriteLine("Dados da conta atualizados: " + Conta1);

            Console.WriteLine();

        }

   


    }
}
