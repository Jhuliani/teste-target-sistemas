using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            char[] listaCaracteres = palavra.ToCharArray();
            string invertida = "";
            for (int i = listaCaracteres.Length - 1; i >= 0; i--)
            {
                invertida += listaCaracteres[i];
            }
            Console.WriteLine("A palavra invertida é: " + invertida);
            Console.ReadLine();
        }
    }
}
