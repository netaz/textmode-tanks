using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textmode_tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tank War";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("#############");
            Console.WriteLine("#   #   # # #");
            Console.WriteLine("# #   #   # #");
            Console.WriteLine("# #####  #  #");
            Console.WriteLine("#        #  #");
            Console.WriteLine("######## #  #");
            Console.WriteLine("#   #  # #  #");
            Console.WriteLine("# # #  #  # #");
            Console.WriteLine("# # #  #  # #");
            Console.WriteLine("# #    #    #");
            Console.WriteLine("# #    #  # #");
            Console.WriteLine("# ###  ##  ##");
            Console.WriteLine("#   #  ##   #");
            Console.WriteLine("#      #  # #");
            Console.WriteLine("##  #       #");
            Console.WriteLine("#############");
            Console.SetCursorPosition(1, 1);
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    if (Console.CursorLeft < 12)
                    {
                        Console.CursorLeft = Console.CursorLeft + 1;
                    }
                }

                if (keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    if (Console.CursorLeft > 0)
                    {
                        Console.CursorLeft = Console.CursorLeft - 1;
                    }
                }

                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (Console.CursorTop > 0)
                    {
                        Console.CursorTop = Console.CursorTop - 1;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (Console.CursorTop < 15)
                    {
                        Console.CursorTop = Console.CursorTop + 1;
                    }
                }

                if (keyinfo.Key == ConsoleKey.Q)
                {
                    // exit the application
                    break;
                }

                
            }

            Console.Clear();
            string gg = " _____ _____\n" +
                        "|  __ \\  __ \\\n" +
                        "| |  \\/ |  \\/\n" +
                        "| | __| | __ \n" +
                        "| |_\\ \\ |_\\ \\\n" +
                        "\\____/\\____/\n";

            Console.WriteLine(gg);
            System.Threading.Thread.Sleep(2000);
            
        }
    }
}


        