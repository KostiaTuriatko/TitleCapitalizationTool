using System;

namespace TitleCapitalizationTool
{
    internal sealed class ExtraSpacesDeleter
    {
        internal string Deleter(string input)
        {
            return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}