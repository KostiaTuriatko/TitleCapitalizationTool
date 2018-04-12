using System.Text;

namespace TitleCapitalizationTool
{
    internal static class MyCaseSetter
    {
        internal static string[] lowerWords = { "a", "an", "the",
                                    "and", "but", "for", "not", "so", "yet",
                                    "at", "by", "in", "of", "on", "or", "out", "to", "up" };

        internal static string SetCase(ref string str)
        {
            StringBuilder tmp = new StringBuilder("");
            string[] words = str.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                string s = words[i];
                if(LowerWordsException(s) && i != (words.Length-1))
                {
                    tmp.Append(s + ' ');
                } else
                {
                    tmp.Append(FirstLetterToUpper(ref s) + ' ');
                }
            }
            tmp[0] = char.ToUpper(tmp[0]);
            str = tmp.ToString();
            return str;
        }

        internal static string FirstLetterToUpper(ref string str)
        {
            StringBuilder tmp = new StringBuilder(str);
            if(char.IsLetter(tmp[0]) && char.IsLower(tmp[0]))
            {
                tmp[0] = char.ToUpper(tmp[0]);
            }
            str = tmp.ToString();
            return str;
        }

        internal static bool LowerWordsException(string str)
        {
            bool result = false;
            foreach(string word in lowerWords)
            {
                if(str == word)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
