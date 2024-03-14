using System;
using System.Threading.Tasks.Dataflow;

namespace Special
{
    class Program
    {
        private static int GetSpecial(int n)
        {
            int outcome;

            
            if (n == 0)
            {   
                outcome = 0;
            }

            else if (n == 1)
            {   
                outcome = 1;
            }

            else
            {
                outcome = GetSpecial(n-1) + 2*GetSpecial(n-2);
            }
            return outcome;
            
        }
        static void Main(string[] args)
        {
            Console.Write("insert number of the special sequence: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            n = GetSpecial(n);
            Console.WriteLine(n);
        }
    }
}
