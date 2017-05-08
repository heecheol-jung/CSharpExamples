using System;

namespace CSharpClassicDesktopConsoleExamples.EqualityExamples
{
    class EqualityExamplesMain : IExample
    {
        public void DoExample()
        {
            while (true)
            {
                string strCommand = string.Empty;
                IExample ex = null;

                PrintCommand();
                strCommand = Console.ReadLine();
                switch (strCommand)
                {
                    case AppConstants.STR_BOXING_UNBOXING_EXAMPLE:
                        ex = new BoxingUnboxingExample();
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

            Console.WriteLine("Equality example done.\n");
        }

        void PrintCommand()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Equality example commands.");
            Console.WriteLine(AppConstants.STR_BOXING_UNBOXING_EXAMPLE);
            Console.WriteLine(AppConstants.STR_QUIT);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(AppConstants.STR_COMMAND_PROMPT);
        }
    }
}
