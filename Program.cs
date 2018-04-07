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

                    ExtraSpacesDeleter.Deleter(ref text);
                    PunctuationSigns.DeleteSpaceBeforePunctuate(ref text);
                    PunctuationSigns.DashInstall(ref text);
                    PunctuationSigns.InsertSpaceAfterPunctuation(ref text);
                    MyCaseSetter.SetCase(ref text);

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
