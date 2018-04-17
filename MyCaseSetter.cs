using System.Text;

namespace TitleCapitalizationTool
{
    internal sealed class MyCaseSetter
    {
        private static string[] lowerWords = { "a", "an", "the",
                                    "and", "but", "for", "not", "so", "yet",
                                    "at", "by", "in", "of", "on", "or", "out", "to", "up" };

        internal static string SetCase(string input)
        {
            StringBuilder tmp = new StringBuilder("");
            string[] words = input.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if(LowerWordsException(word) && i != (words.Length-1))
                {
                    tmp.Append(word + ' ');
                } else
                {
                    tmp.Append(FirstLetterToUpper(word) + ' ');
                }
            }
            tmp[0] = char.ToUpper(tmp[0]);
            return tmp.ToString();
        }

        internal static string FirstLetterToUpper(string input)
        {
            StringBuilder tmp = new StringBuilder(input);
            if(char.IsLetter(tmp[0]) && char.IsLower(tmp[0]))
            {
                tmp[0] = char.ToUpper(tmp[0]);
            }
            return tmp.ToString();
        }

        internal static bool LowerWordsException(string input)
        {
            bool result = false;
            foreach(string word in lowerWords)
            {
                if(input == word)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}