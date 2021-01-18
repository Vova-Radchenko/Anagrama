using System;
using Anagrama.RewersWords;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine();

            var rewersString = new Anagram();

            Console.WriteLine("New string is: " + rewersString.rewSentence(null));
        }
    }
}
