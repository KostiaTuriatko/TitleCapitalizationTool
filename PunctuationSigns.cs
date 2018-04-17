namespace TitleCapitalizationTool
{
    internal sealed class PunctuationSigns
    {
        internal static string DeleteSpaceBeforePunctuate(string input)
        {
            try
            {
                string ChangeableString = "";
                int i;
                for (i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == ' ')
                    {
                        if (char.IsPunctuation(input[i + 1]))
                        {
                            ChangeableString = ChangeableString + input[i + 1];
                        }
                        else
                        {
                            ChangeableString = ChangeableString + input[i] + input[i + 1];
                        }
                        i += 1;
                    }
                    else
                    {
                        ChangeableString = ChangeableString + input[i];
                    }
                }
                if (input.Length > 0 && !(char.IsPunctuation(input[i - 1])))
                {
                    ChangeableString = ChangeableString + input[input.Length - 1];
                }
                input = ChangeableString;
            }
            catch(System.IndexOutOfRangeException)
            {
                System.Console.WriteLine("Exception: something wrong in \"Punctuation signs\"");
            }
            return input;
        }

        internal static string InsertSpaceAfterPunctuation(string input)
        {
            string ChangeableString = "";
            for (int i = 0; i < input.Length-1; i++)
            {
                if (char.IsPunctuation(input[i]))
                {
                    if (input[i+1] == ' ')
                    {
                        ChangeableString = ChangeableString + input[i] + input[i + 1];
                    } else
                    {
                        ChangeableString = ChangeableString + input[i] + ' ' + input[i + 1];
                    }
                    i += 1;
                } else
                {
                    ChangeableString = ChangeableString + input[i];
                }
            }
            if (input.Length >= 1)
            {
                ChangeableString = ChangeableString + input[input.Length - 1];
            }
            return ChangeableString;
        }
        internal static string DashInstall(string input)
        {            
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == '-')
                {
                    input = input.Remove(i, 1);
                    input = input.Insert(i, " - ");
                    i++;
                }
            }
            return input;
        }
    }
}