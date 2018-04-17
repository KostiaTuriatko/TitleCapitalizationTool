using System;

namespace TitleCapitalizationTool
{
    internal sealed class ExtraSpacesDeleter
    {
        internal static string Deleter(string str)
        {
            str = string.Join(" ", str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            return str;
        }
    }
}