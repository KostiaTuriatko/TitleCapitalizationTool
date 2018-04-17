using System.Text;

namespace TitleCapitalizationTool
{
    internal sealed class MyCaseSetter
    {
        private static string[] lowerWords = { "a", "at", "an", "and", "but", "by",
                                               "for", "in", "not", "of", "on", "or",
                                               "out",  "so", "the", "to", "up", "yet"};

        internal static string SetCase(string input)
        {
            StringBuilder ChangeableString = new StringBuilder("");
            string[] words = input.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if(LowerWordsException(word) && i != (words.Length-1))
                {
                    ChangeableString.Append(word + ' ');
                } else
                {
                    ChangeableString.Append(FirstLetterToUpper(word) + ' ');
                }
            }
            ChangeableString[0] = char.ToUpper(ChangeableString[0]);
            return ChangeableString.ToString();
        }

        internal static string FirstLetterToUpper(string input)
        {
            StringBuilder ChangeableString = new StringBuilder(input);
            if(char.IsLetter(ChangeableString[0]) && char.IsLower(ChangeableString[0]))
            {
                ChangeableString[0] = char.ToUpper(ChangeableString[0]);
            }
            return ChangeableString.ToString();
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