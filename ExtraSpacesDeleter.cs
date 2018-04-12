using System;

namespace TitleCapitalizationTool
{
    internal static class ExtraSpacesDeleter
    {
        internal static string Deleter(ref string str)
        {
            str = string.Join(" ", str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            return str;
        }
    }
}