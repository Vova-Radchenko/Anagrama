using System;
using System.Text;
using Anagrama.RewersWords;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");

            var s = Console.ReadLine();
            var rewersString = new Anagram();

            try
            {
                Console.WriteLine("New string is: " + rewersString.rewSentence(s));
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            
        }
    }
}
