using System;

namespace Desafio_DotNET_Coxinha
{
    class Program
    {
        static void Main()
        {
            decimal H, P, averageRounded, average;
            string[] line = Console.ReadLine().Split(" ");
            decimal.TryParse(line[0], out H);
            decimal.TryParse(line[1], out P);
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
            averageRounded = (Math.Round(average, 2));   
            Console.WriteLine(averageRounded);
        }
    }
}
