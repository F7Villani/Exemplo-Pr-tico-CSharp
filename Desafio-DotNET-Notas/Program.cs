using System;

namespace Desafio_DotNET_Notas
{
    class Program
    {
        static void Main()
        {
            string opcao = "1";
            while(opcao == "1")
            {
                int numerosValidos = 0;
                double total = 0;
                while(numerosValidos<2)
                {
                    double nota = double.Parse(Console.ReadLine());
                    while(nota<0 || nota>10)
                    {
                        Console.WriteLine("nota invalida");
                        nota = double.Parse(Console.ReadLine());
                    }
                    total += nota;
                    numerosValidos++; 
                }
                Console.WriteLine("media = {0}", (total/2).ToString("n2"));
                do
                { 
                    Console.WriteLine("novo calculo (1-sim 2-nao)"); 
                    opcao = Console.ReadLine();
                }
                while(opcao != "1" && opcao != "2");
            }
                
            
        }
    }
}