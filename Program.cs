using System;

namespace TitleCapitalizationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string text = "";
            while (true)
            {
                if (flag == false)
                {
                    Console.Write("Enter title to capitalize: ");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                text = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if(string.IsNullOrWhiteSpace(text))
                {
                    Console.SetCursorPosition(27, Console.CursorTop - 1);
                    flag = true;
                }

                if (!string.IsNullOrWhiteSpace(text))
                {
                    flag = false;

                    text = ExtraSpacesDeleter.Deleter(ref text);
                    text = PunctuationSigns.DeleteSpaceBeforePunctuate(ref text);
                    text = PunctuationSigns.DashInstall(ref text);
                    text = PunctuationSigns.InsertSpaceAfterPunctuation(ref text);
                    text = text.ToLower();
                    text = MyCaseSetter.SetCase(ref text);

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