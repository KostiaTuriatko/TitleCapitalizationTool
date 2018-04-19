using System;

namespace TitleCapitalizationTool
{
    class Program
    {
        static void Main()
        {
            bool IsNothing = false;
            MyCaseSetter caseSetter = new MyCaseSetter();
            ExtraSpacesDeleter spacesDeleter = new ExtraSpacesDeleter();
            PunctuationSigns punctuation = new PunctuationSigns();

            string text = "";
            while (true)
            {
                if (!IsNothing)
                {
                    Console.Write("Enter title to capitalize: ");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                text = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.SetCursorPosition(27, Console.CursorTop - 1);
                    IsNothing = true;
                }

                if (!string.IsNullOrEmpty(text))
                {
                    IsNothing = false;

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        Console.WriteLine();
                        Console.Write("Capitalized title: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(text);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        continue;
                    }

                    text = spacesDeleter.Deleter(text);
                    text = punctuation.DeleteSpaceBeforePunctuate(text);
                    text = punctuation.DashInstall(text);
                    text = punctuation.InsertSpaceAfterPunctuation(text);
                    text = text.ToLower();
                    text = caseSetter.SetCase(text);

                    Console.Write("Capitalized title: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
            } 
        }
    }
}