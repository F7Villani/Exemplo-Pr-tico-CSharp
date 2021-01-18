using System;

namespace Desafio_DotNET_Coxinha
{
    class Program
    {
        static void Main()
        {
            double H, P, average;
            string[] line = Console.ReadLine().Split(" ");
            double.TryParse(line[0], out H);
            double.TryParse(line[1], out P);
            if(H<0)
            {
                throw new Exception();
            }
            else if(P<0)
            {
                throw new Exception();            
            }
            else if(P==0)
            {
                throw new DivideByZeroException();
            }
            average = H/P;
            Console.WriteLine(average.ToString("F2"));
        }
    }
}
