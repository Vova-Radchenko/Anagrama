using System;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            String s = Console.ReadLine();
            char[] mas = s.ToCharArray();
            char[] masAnagram = new char[mas.Length];
            String sAnagram = "";

            for (int i = 0; i < mas.Length; i++)
            {
                if (!char.IsLetter(mas[i]))
                {
                    masAnagram[i] = mas[i];
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                if (char.IsLetter(mas[i]))
                {
                    for (int k = masAnagram.Length - 1; k >= 0; k --)
                    {
                        if(masAnagram[k] == '\0')
                        {
                            masAnagram[k] = mas[i];
                            break;
                        }
                    }
                }
            }

            sAnagram = new string(masAnagram);

            Console.WriteLine("New string is: " + sAnagram);
        }
    }
}
