using System.Text;
using System;

namespace TitleCapitalizationTool
{
    internal sealed class MyCaseSetter
    {
        private static string[] lowerWords = { "a", "an", "and", "at", "but", "by",
                                               "for", "in", "not", "of", "on", "or",
                                               "out", "so", "the", "to", "up", "yet" };

        internal string SetCase(string input)
        {
            StringBuilder changeableString = new StringBuilder("");
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (LowerWordsException(word) && i != (words.Length - 1))
                {
                    changeableString.Append(word + ' ');
                }
                else
                {
                    changeableString.Append(FirstLetterToUpper(word) + ' ');
                }
            }
            changeableString[0] = char.ToUpper(changeableString[0]);
            return changeableString.ToString();
        }

        internal static string FirstLetterToUpper(string input)
        {
            StringBuilder changeableString = new StringBuilder(input);
            if (char.IsLetter(changeableString[0]) && char.IsLower(changeableString[0]))
            {
                changeableString[0] = char.ToUpper(changeableString[0]);
            }
            return changeableString.ToString();
        }

        internal static bool LowerWordsException(string input)
        {
            bool IsExceptionWord = false;
            foreach (string word in lowerWords)
            {
                if (input == word)
                {
                    IsExceptionWord = true;
                    break;
                }
            }
            return IsExceptionWord;
        }
    }
}