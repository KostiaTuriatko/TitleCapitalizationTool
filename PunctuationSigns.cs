namespace TitleCapitalizationTool
{
    internal sealed class PunctuationSigns
    {
        internal static string DeleteSpaceBeforePunctuate(string str)
        {
            try
            {
                string tmp = "";
                int i;
                for (i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == ' ')
                    {
                        if (char.IsPunctuation(str[i + 1]))
                        {
                            tmp = tmp + str[i + 1];
                        }
                        else
                        {
                            tmp = tmp + str[i] + str[i + 1];
                        }
                        i += 1;
                    }
                    else
                    {
                        tmp = tmp + str[i];
                    }
                }
                if (str.Length > 0 && !(char.IsPunctuation(str[i - 1])))
                {
                    tmp = tmp + str[str.Length - 1];
                }
                str = tmp;
            }
            catch(System.IndexOutOfRangeException)
            {
                System.Console.WriteLine("Exception: something wrong in \"Punctuation signs\"");
            }
            return str;
        }

        internal static string InsertSpaceAfterPunctuation(string str)
        {
            string tmp = "";
            for(int i = 0; i < str.Length-1; i++)
            {
                if(char.IsPunctuation(str[i]))
                {
                    if(str[i+1] == ' ')
                    {
                        tmp = tmp + str[i] + str[i + 1];
                    } else
                    {
                        tmp = tmp + str[i] + ' ' + str[i + 1];
                    }
                    i += 1;
                } else
                {
                    tmp = tmp + str[i];
                }
            }
            if (str.Length >= 1)
            {
                tmp = tmp + str[str.Length - 1];
            }
            return tmp;
        }
        internal static string DashInstall(string str)
        {            
            for(int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == '-')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, " - ");
                    i++;
                }
            }
            return str;
        }
    }
}