using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToMorze
{
    public class Translator
    {
        public void translating(string text, string[] morze, string[] abc) 
        {
            string[] NewText = new string[text.Length];
            int temp = -1;
            string str = char.ToLower(text[0]) + text.Substring(1);
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < morze.Length; j++)
                {
                    if (Convert.ToString(str[i]) == abc[j])
                    {
                        temp++;
                        NewText[temp] = morze[j];
                        break;
                    }
                }
            }

            foreach (var item in NewText)
            {
                Console.Write(item + " ");
            }
        }
    }
}

namespace ToAbc
{
    public class Translator
    {
        public void translating(string text, string[] morze, string[] abc)
        {
            string[] NewText = new string[text.Length];
            int temp = -1;
            string[] str = text.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < morze.Length; j++)
                {
                    if (Convert.ToString(str[i]) == morze[j])
                    {
                        temp++;
                        NewText[temp] = abc[j];
                        break;
                    }
                }
            }

            foreach (var item in NewText)
            {
                Console.Write(item + " ");
            }
        }
    }
}
