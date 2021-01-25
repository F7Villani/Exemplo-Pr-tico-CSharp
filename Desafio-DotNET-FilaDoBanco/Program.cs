using System;

namespace Desafio_DotNET_FilaDoBanco
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i<N; i++)
            {
                int numeroClientes = int.Parse(Console.ReadLine());
                int[] senhas =  new int[numeroClientes];
                string[] senhasString = Console.ReadLine().Split(" ");
                for(int j = 0; j<numeroClientes; j++)
                {
                    senhas[j] = int.Parse(senhasString[j]);
                }
                int[] senhasOrdenadas = new int[numeroClientes];
                senhasOrdenadas = senhas;
                Array.Sort(senhasOrdenadas);
                
                

            }
        }
    }
}
