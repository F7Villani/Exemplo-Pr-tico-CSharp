using System;

namespace Desafio_DotNET_ListaDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[1000];
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            for(int i=0; i<totalDeCasosDeTeste; i++)
            {
                lista = Console.ReadLine().Split(" ");
                Array.Sort(lista);
                string printado = "";
                foreach(string produto in lista)
                {   
                    if(produto != printado)
                    { 
                        Console.Write(produto + " ");
                        printado = produto;
                    }                                
                }
                Console.WriteLine();
            }          
        }
    }
}
