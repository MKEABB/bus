using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            EnKlassFörSig.bus();
            EnKlassFörSig.DetVarEnGångEnRiddare();
            Console.ReadLine();
            EnKlassFörSig.bus();
            EnKlassFörSig.OchEnTrollKarl();
            Console.ReadLine();
            EnKlassFörSig.bus();  
            EnKlassFörSig.OchDeGjordeMassaBus();
              
            
            StreamReader reader = new StreamReader(@"neareuropecities.csv");

            List<string> cities = new List<string>();

            int stock = 0, oslo = 0;

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach (var item in values)
                    {

                        cities.Add(item);
                        if (item == "\"Stockholm\"")
                        {

                            stock++;
                            Console.WriteLine(item);
                        }
                        else if (item == "\"Oslo\"")
                        {
                            oslo++;
                            Console.WriteLine(item);
                        }
                    }
                }
                Console.WriteLine("Stockholm: " + stock);
                Console.WriteLine("Oslo: " + oslo);
                Console.ReadKey();

                
                
            }
        }

    }
}