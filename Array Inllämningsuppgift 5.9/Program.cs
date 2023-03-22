using System;
namespace Array
{
    class program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine("Skriv in ett förnamn");
          string a = Console.ReadLine();
            string[] namn = new string[1000];
            namn[0] = a;
            int t = 0;
            Console.WriteLine(" ");
            for (int i = 1; true; i++)
            {
                
                
                Console.WriteLine("Vill du skriva in ett nytt förnamn? ja/nej?");
              string b = Console.ReadLine();
                if (b == "ja")
                {
                    
                    Console.WriteLine(" ");
                    Console.WriteLine("Skriv in ett förnamn");
                    string c =Console.ReadLine();
                    Console.WriteLine(" ");
                    
                    namn[i] = c;
                }
                else if (b == "nej")
                {
                    y = i;
                    break;
                }
               
                

                


                
            }

            int ö = 0;
                Console.WriteLine(" ");
                Console.WriteLine("Skriv in yterligare ett nytt förnamn");
                string e = Console.ReadLine();
                Console.WriteLine(" ");
            
                for (int j = 0; j < y + 1; j++)
                {
                
                    if (namn[j] == e)
                    {

                        ö++;

                    }
                }

                Console.WriteLine("detta namn uppkom " + ö + " gång/gånger tidigare");
                
            
        }
    }
}