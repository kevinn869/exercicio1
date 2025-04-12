using System;

namespace Saudacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Seja bem-vindo(a)!");
        }
    }
}
