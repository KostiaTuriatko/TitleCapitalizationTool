using System;

namespace TitleCapitalizationTool
{
    internal sealed class ExtraSpacesDeleter
    {
        internal static string Deleter(string input)
        {
            return input = string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}