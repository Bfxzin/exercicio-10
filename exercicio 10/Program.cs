using System;

namespace ClassificacaoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto:");
            int codigo = int.Parse(Console.ReadLine());

            string classificacao;

            switch (codigo)
            {
                case 1:
                    classificacao = "Alimento não-perecível";
                    break;
                case 2:
                case 3:
                case 4:
                    classificacao = "Alimento perecível";
                    break;
                case 5:
                case 6:
                    classificacao = "Vestuário";
                    break;
                case 8:
                case 15:
                    classificacao = "Higiene pessoal";
                    break;
                default:
                    classificacao = "Inválido";
                    break;
            }

            Console.WriteLine("Classificação do produto: " + classificacao);
        }
    }
}
