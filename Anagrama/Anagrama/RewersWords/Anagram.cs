using System;
using System.Collections.Generic;
using System.Text;

namespace Anagrama.RewersWords
{
    public class Anagram
    {
        private string rewString(char[] mas)
        {

            char[] masAnagram = new char[mas.Length];

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
                    for (int k = masAnagram.Length - 1; k >= 0; k--)
                    {
                        if (masAnagram[k] == '\0')
                        {
                            masAnagram[k] = mas[i];
                            break;
                        }
                    }
                }
            }

            return new string(masAnagram);
        }

        public string rewSentence(String s)
        {

            if (s == string.Empty)
            {
                throw new Exception();
            }

            string[] sArray = s.Split();

            for (int i = 0; i < sArray.Length; i++)
            {
                sArray[i] = rewString(sArray[i].ToCharArray());
            }

            string sRewers = "";

            for (int i = 0; i < sArray.Length; i++)
            {
                sRewers += i == 0 ? sArray[i]: " " + sArray[i];
            }

            return sRewers;
        }
    }
}
