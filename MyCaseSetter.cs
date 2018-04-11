using System.Text;
using System.Globalization;

namespace TitleCapitalizationTool
{
    internal static class MyCaseSetter
    {
        internal static string SetCase(ref string str)
        {
            StringBuilder tmp = new StringBuilder("");
            string[] words = str.Split(' ');
            try
            {
                foreach (string word in words)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i == 0 && char.IsLetter(word[i]) && !LowerWordsException(word))
                        {
                            tmp.Append(char.ToUpper(word[i]));
                        }
                        else
                        {
                            tmp.Append(char.ToLower(word[i]));
                        }
                    }
                    tmp.Append(" ");
                }
                tmp[0] = char.ToUpper(words[0][0]);     // First letter UpperCase always
            }
            catch(System.IndexOutOfRangeException)
            {
                System.Console.WriteLine("Exception: something wrong in \"MyCaseSetter\"");
            }
            str = tmp.ToString();
            return str;
        }
        internal static string NewSetCase(ref string str)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            StringBuilder tmp = new StringBuilder("");
            foreach(string word in str.Split(' '))
            {
                if (LowerWordsException(word))
                {
                    tmp.Append(word);
                } else
                {
                    tmp.Append(myTI.ToTitleCase(word));
                }
                tmp.Append(" ");
            }
            tmp[9] = char.ToUpper(tmp[9]);
            str = tmp.ToString();
            return str;
        }
        internal static bool LowerWordsException(string str)
        {
            bool result = false;
            foreach(string word in LowerWords)
            {
                if(str == word)
                {
                    result = true;
                }
            }
            return result;
        }
        internal static string[] LowerWords = { "a", "an", "the",
                                    "and", "but", "for", "not", "so", "yet",
                                    "at", "by", "in", "of", "on", "or", "out", "to", "up" };
    }
}
