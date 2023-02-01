using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using testeTarget;

namespace Faturamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "C:/Users/Jhuliani/Desktop/testes-target/dados.json";
            string conteudoArquivo = File.ReadAllText(caminhoArquivo);
            List<Dados> faturamento = JsonConvert.DeserializeObject<List<Dados>>(conteudoArquivo);


            var menorValor = faturamento[0].Valor;
            var maiorValor = faturamento[0].Valor;
            double valorTotal = 0;
            int diasAcimaDaMedia = 0;

            for (int i = 0; i < faturamento.Count; i++)
            {
                var valorAtual = faturamento[i];
                if (valorAtual.Valor > 0)
                {
                    valorTotal += valorAtual.Valor;
                    if (valorAtual.Valor < menorValor)
                    {
                        menorValor = valorAtual.Valor;
                    }
                    if (valorAtual.Valor > maiorValor)
                    {
                        maiorValor = valorAtual.Valor;
                    }
                }
            }

            double faturamentoMedio = valorTotal / faturamento.Count;
            for (int i = 0; i < faturamento.Count; i++)
            {
                var valorAtual = faturamento[i];
                if (valorAtual.Valor > 0 && valorAtual.Valor > faturamentoMedio)
                {
                    diasAcimaDaMedia++;
                }
            }

            Console.WriteLine("Valor Mínimo: " + menorValor);
            Console.WriteLine("Valor Máximo: " + maiorValor);
            Console.WriteLine("Dias acima da média: " + diasAcimaDaMedia);
            Console.ReadLine();
        }
    }
}
