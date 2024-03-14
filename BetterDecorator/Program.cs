using System;

namespace BetterDecorator
{
    /// <summary>
    /// This program decorates a string with a chosen character
    /// The amount of characters in each side of the string is determined by a chosen integer
    /// </summary>
    class Program
    {
        /// <summary>
        /// This Method receives a string, a character and an integer
        /// In the for loop, it adds the character before and after the string
        /// The loop runs the amount of the integer
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int num)
        {
            for(int i = 0; i < num; i++)
            {
                s = $"{dec}{s}{dec}";
            }
            return s;
        }
        
        /// <summary>
        /// This Method works if the user don't put any arguments
        /// This Decor() method returns the Decor() method with arguments
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
        
        /// <summary>
        /// It receives 3 arguments
        /// The second argument is turned into a character
        /// The third argument is turned into an integer
        /// Then runs the method Decor()
        /// Writes the outcome of the method Decor()
        /// If the there's no arguments, it will print "===User did not specify args!==="
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           if (args.Length == 0)
           {
                Console.WriteLine(Decor());
           }
           
           else
           {
            string s = args[0];
           char dec = char.Parse(args[1]);
           int num = int.Parse(args[2]);
           s = Decor(s,dec,num);
           Console.WriteLine(s);
           }
           

        }
    }
}
