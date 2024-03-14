using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec, int num)
        {
            for(int i = 0; i < num; i++)
            {
                s = $"{dec}{s}{dec}";
            }
            return s;
        }
        static void Main(string[] args)
        {
           string s = args[0];
           char dec = char.Parse(args[1]);
           int num = int.Parse(args[2]);
           s = Decor(s,dec,num);
           Console.WriteLine(s);

        }
    }
}
