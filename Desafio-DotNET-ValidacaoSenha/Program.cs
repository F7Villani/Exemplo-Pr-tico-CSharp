using System;

namespace Desafio_DotNET_ValidacaoSenha
{
    class Program
    {
        static void Main()
        {
            string senha = "0";
            while(!string.IsNullOrWhiteSpace(senha))
            {  
                int maiuscula = 0;
                int minuscula = 0;
                int numero = 0;
                int invalido = 0;
                

                senha = Console.ReadLine();

                if(senha.Length>=6 && senha.Length<=32)
                {
                    foreach (char letra in senha)  
                    {
                        int valido = Valido(letra);
                        switch(valido)
                        {
                            case 0:
                                invalido++;
                                break;
                            case 1:
                                maiuscula++;
                                break;
                            case 2:
                                minuscula++;
                                break;
                            case 3:
                                numero++;
                                break;
                            
                        } 
                    }
                
                    if(maiuscula>0 && minuscula>0 && numero>0)
                    {
                        if(invalido==0)
                        {
                            Console.WriteLine("Senha valida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Senha invalida."); 
                    }
                }    
                else
                {
                    Console.WriteLine("Senha invalida."); 
                }  
            
            }
            
        }
        
        private static int Valido(char letra)
        {
            //Retorna 0, caso caracter de acentuação ou espaço
            //Retorna 1, caso letra maiuscula
            //Retorna 2, caso letra minuscula 
            //Retorna 3, caso um número
            //Retorna 4, caso não seja identificado

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
            return 0;

        }
    }
}
