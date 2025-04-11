using System;

namespace Saudacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que digite o nome
            Console.Write("Digite seu nome: ");
            
            // Lê o nome digitado pelo usuário
            string nome = Console.ReadLine();

            // Exibe a saudação personalizada
            Console.WriteLine($"Olá, {nome}! Seja bem-vindo(a)!");
        }
    }
}
