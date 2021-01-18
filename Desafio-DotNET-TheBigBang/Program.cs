using System;

namespace Desafio_DotNET
{

class Desafio {
    
    static void Main() {
        int T;
        string sheldon, raj, msg;
        Int32.TryParse(Console.ReadLine(), out T);
        
        for(int i = 0; i < T; i++)
        {
            string[] linha = Console.ReadLine().Split(" ");
            sheldon = linha[0];
            raj = linha[1];
            msg = WhoWin(sheldon, raj);
            Console.WriteLine($"Caso #{i+1}: {msg}");
            
            
        }
        
        
    }
    public static string WhoWin(string s, string r)
    {
        string msg = null;
        if (s == r)
        {
            msg = "De novo!";
        }
        else
        {
            if(s == "tesoura" && (r == "papel" || r == "lagarto"))
            {
                msg = "Bazinga!";
            }
            else if(s == "papel" && (r == "pedra" || r == "Spock"))
            {
                msg = "Bazinga!";
            }
            else if(s == "pedra" && (r == "lagarto" || r == "tesoura"))
            {
                msg = "Bazinga!";
            }
            else if(s == "lagarto" && (r == "Spock" || r == "papel"))
            {
                msg = "Bazinga!";
            }
            else if(s == "Spock" && (r == "tesoura" || r == "pedra"))
            {
                msg = "Bazinga!";
            }
            else
            {
                msg = "Raj trapaceou!";
            }
        }
        return msg;
    }

    
}
}
