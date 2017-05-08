using CSharpClassicDesktopConsoleExamples.EqualityExamples;
using System;

namespace CSharpClassicDesktopConsoleExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string strCommand = string.Empty;
                IExample ex = null;

                PrintCommand();
                strCommand = Console.ReadLine();
                switch (strCommand)
                {
                    case AppConstants.STR_EQUALITY_EXAMPLES:
                        ex = new EqualityExamplesMain();
                        break;

                    default:
                        Console.WriteLine(AppConstants.STR_UNKNOWN_COMMAND);
                        break;
                }

                if (AppConstants.STR_QUIT == strCommand)
                {
                    break;
                }
                else
                {
                    if (ex != null)
                    {
                        ex.DoExample();
                    }
                    else
                    {
                        Console.WriteLine("No example instance available.");
                    }
                }
            }

            Console.WriteLine("Main done.\n");
        }

        static void PrintCommand()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Main commands.");
            Console.WriteLine(AppConstants.STR_EQUALITY_EXAMPLES);
            Console.WriteLine(AppConstants.STR_QUIT);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(AppConstants.STR_COMMAND_PROMPT);
        }
    }
}
