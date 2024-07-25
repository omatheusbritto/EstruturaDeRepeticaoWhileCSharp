// Programa para trabalhar estrutura de repetição while
using System;
using System.Globalization;

namespace EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para calcular sua raiz quadrada: ");
            double n1 = double.Parse(Console.ReadLine());
            while (n1 > 0)  
            {
                double resultado = Math.Sqrt(n1);
                Console.WriteLine("A raiz quadrada de {0} é {1:F2}", n1, resultado);
                Console.WriteLine(" ");
                Console.Write("Digite um valor para calcular sua raiz quadrada: ");
                n1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0} é negativo",n1);
        }  
    }
}