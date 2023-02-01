using System;

namespace faturamento_estados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sp = 67836.43M;
            decimal rj = 36678.66M;
            decimal mg = 29229.88M;
            decimal es = 27165.48M;
            decimal outros = 19849.53M;

            decimal total = sp + rj + mg + es + outros;

            decimal spPorcentagem = (sp / total) * 100;
            decimal rjPorcentagem = (rj / total) * 100;
            decimal mgPorcentagem = (mg / total) * 100;
            decimal esPorcentagem = (es / total) * 100;
            decimal outrosPorcentagem = (outros / total) * 100;

            Console.WriteLine("SP: " + spPorcentagem.ToString("0.00") + "%");
            Console.WriteLine("RJ: " + rjPorcentagem.ToString("0.00") + "%");
            Console.WriteLine("MG: " + mgPorcentagem.ToString("0.00") + "%");
            Console.WriteLine("ES: " + esPorcentagem.ToString("0.00") + "%");
            Console.WriteLine("Outros: " + outrosPorcentagem.ToString("0.00") + "%");
        }
    }
}
