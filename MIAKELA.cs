using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus
{
    internal class MIAKELA
    {
        public void RemoveFromCallList(List<string[]> callHistory)
        {
            foreach (string[] item in callHistory)
            {
                Console.WriteLine(item);
            }

            string chosenIndex = string.Empty;
            foreach (var numberInfo in callHistory)
            {
                string searchNumber = numberInfo[0];

                if (chosenIndex == searchNumber)
                {
                    callHistory.RemoveAt(int.Parse(chosenIndex));
                }
            }
        }
    }
}
