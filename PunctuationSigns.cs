namespace TitleCapitalizationTool
{
    internal sealed class PunctuationSigns
    {
        internal string DeleteSpaceBeforePunctuate(string input)
        {
            try
            {
                string changeableString = "";
                int i;
                for (i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == ' ')
                    {
                        if (char.IsPunctuation(input[i + 1]))
                        {
                            changeableString = changeableString + input[i + 1];
                        }
                        else
                        {
                            changeableString = changeableString + input[i] + input[i + 1];
                        }
                        i += 1;
                    }
                    else
                    {
                        changeableString = changeableString + input[i];
                    }
                }
                if (input.Length > 0 && !(char.IsPunctuation(input[i - 1])))
                {
                    changeableString = changeableString + input[input.Length - 1];
                }
                input = changeableString;
            }
            catch (System.IndexOutOfRangeException)
            {
                System.Console.WriteLine("Exception: something wrong in \"Punctuation signs\"");
            }
            return input;
        }

        internal string InsertSpaceAfterPunctuation(string input)
        {
            string changeableString = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsPunctuation(input[i]))
                {
                    if (input[i+1] == ' ')
                    {
                        changeableString = changeableString + input[i] + input[i + 1];
                    }
                    else
                    {
                        changeableString = changeableString + input[i] + ' ' + input[i + 1];
                    }
                    i += 1;
                }
                else
                {
                    changeableString = changeableString + input[i];
                }
            }
            if (input.Length >= 1)
            {
                changeableString = changeableString + input[input.Length - 1];
            }
            return changeableString;
        }
        internal string DashInstall(string input)
        {            
            for (int i = 0; i < input.Length - 1; i++)
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