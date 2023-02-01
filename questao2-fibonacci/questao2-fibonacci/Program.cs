using System;

namespace questao2_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine("A sequencia Fibonacci: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }

            Console.WriteLine();

            bool pertence = false;
            for (int i = 0; i < n; i++)
            {
                if (fibonacci[i] == n)
                {
                    pertence = true;
                    break;
                }
            }

            if (pertence)
            {
                Console.WriteLine("Esse número pertence a sequência Fibonacci");
            }
            else
            {
                Console.WriteLine("Esse número não pertence a sequência Fibonacci");
            }

            Console.ReadLine();
        }
    }
}
