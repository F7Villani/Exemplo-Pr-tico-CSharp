using System;

namespace Desafio_DotNET_ValidacaoSenha
{
    class Program
    {
        static void Main()
        {
            int maiuscula = 0;
            int minuscula = 0;
            int numero = 0;

            string senha = Console.ReadLine();

            foreach (char letra in senha)  
            {
                int valido = Valido(letra);

            }      
        
            
        }
        private static int Valido(char letra)
        {
            //Retorna 0, caso caracter de acentuação ou espaço
            //Retorna 1, caso letra maiuscula
            //Retorna 2, caso letra minuscula 
            //Retorna 3, caso um número
            //Retorna 4, caso não seja identificado

                        
            if(letra == ' ')
            {
                return 0;
            }
            if((int)letra>=65 && (int)letra<=90)
            {
                return 1;
            }
            if((int)letra>=97 && (int)letra<=122)
            {
                return 2;
            }
            if((int)letra>=48 && (int)letra<=57)
            {
                return 3;
            }
            return 4;

        }
    }
}
