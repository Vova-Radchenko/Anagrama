using System;
using System.Collections.Generic;
using System.Text;

namespace Anagrama.RewersWords
{
    public class Anagram
    {
        public string rewSentence(String s)
        {

            if (string.IsNullOrEmpty(s))
            {
                throw new Exception("Exception!!!");
            }

            string[] sArray = s.Split();

            for (int i = 0; i < sArray.Length; i++)
            {
                sArray[i] = rewString(sArray[i]);
            }

            return string.Join(" ", sArray);
        }

        private string rewString(string mas)
        {

            char[] masAnagram = new char[mas.Length];

            for (int i = 0; i < mas.Length; i++)
            {
                if (char.IsLetter(mas[i]))
                {
                    for (int k = masAnagram.Length - 1; k >= 0; k--)
                    {
                        if (masAnagram[k] == '\0' && char.IsLetter(mas[k]))
                        {
                            masAnagram[k] = mas[i];
                            break;
                        }
                    }
                }
                else
                {
                    masAnagram[i] = mas[i];
                }
            }

            return new string(masAnagram);
        }        
    }
}
