using System;
using System.Globalization;
using Exercicios_de_Fixacao_7.Entities;
using Exercicios_de_Fixacao_7.Entities.Exceptions;

namespace Exercicios_de_Fixacao_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance:");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit:");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(acc);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Account error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unespected error: " + e.Message);
            }
        }
    }
}
