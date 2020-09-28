using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Média aritmética de 3 números ---");
            Console.Write("Informe o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o terceiro número: ");
            double terceiroNumero = Convert.ToDouble(Console.ReadLine());

            double media = (primeiroNumero + segundoNumero + terceiroNumero) / 3;
            Console.WriteLine($"Média: {media}");
            Console.Write("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
