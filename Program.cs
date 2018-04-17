﻿using System;

namespace TitleCapitalizationTool
{
    class Program
    {
        static void Main()
        {
            bool IsWhiteSpaceInput = false;
            string text = "";
            while (true)
            {
                if (IsWhiteSpaceInput == false)
                {
                    Console.Write("Enter title to capitalize: ");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                text = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.SetCursorPosition(27, Console.CursorTop - 1);
                    IsWhiteSpaceInput = true;
                }

                if (!string.IsNullOrWhiteSpace(text))
                {
                    IsWhiteSpaceInput = false;

                    text = ExtraSpacesDeleter.Deleter(text);
                    text = PunctuationSigns.DeleteSpaceBeforePunctuate(text);
                    text = PunctuationSigns.DashInstall(text);
                    text = PunctuationSigns.InsertSpaceAfterPunctuation(text);
                    text = text.ToLower();
                    text = MyCaseSetter.SetCase(text);

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