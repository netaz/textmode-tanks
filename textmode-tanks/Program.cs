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
            int x = 1, y = 1;
            Console.Title = "Tank War";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            string map =    "#############\n" +
                            "#   #   # # #\n" +
                            "# #   #   # #\n" +
                            "# #   #   # #\n" +
                            "# #####  #  #\n" +
                            "#        #  #\n" +
                            "######## #  #\n" +
                            "#   #  # #  #\n" +
                            "# # #  #  # #\n" +
                            "# # #  #  # #\n" +
                            "# #    #    #\n" +
                            "# #    #  # #\n" +
                            "# ###  ##  ##\n" +
                            "#   #  ##   #\n" +
                            "#      #  # #\n" +
                            "##  #       #\n" +
                            "#############";
            Console.WriteLine(map);
            Console.WriteLine("(x,y) = (" + x + "," + y + ")");
            Console.SetCursorPosition(x, y);
            Console.CursorSize = 100;
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    if (Console.CursorLeft < 12)
                    {

                        int characters_to_skip = y * 14 + (x + 1);
                        if (map[characters_to_skip] == ' ') // check if there is a space to the right 
                        {
                            // no wall, so we can walk right
                            x = x + 1;

                        }

                    }
                    else
                    {
                        Console.Beep();
                    }
                }

                if (keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    if (Console.CursorLeft > 0)
                    {
                        int characters_to_skip = y * 14 + (x - 1);
                        if (map[characters_to_skip] == ' ')
                        {
                            x = x - 1;
                        }
                    }
                    else
                    {
                        Console.Beep();
                    }
                }

                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (Console.CursorTop > 0)
                    {
                        int characters_to_skip = (y - 1) * 14 + x;
                        if (map[characters_to_skip] == ' ')
                        {
                            y = y - 1;
                        }
                    }
                    else
                    {
                        Console.Beep();
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (Console.CursorTop < 15)
                    {
                        int characters_to_skip = (y + 1) * 14 + x;
                        if (map[characters_to_skip] == ' ')
                        {
                            y = y + 1;
                        }
                    }
                    else
                    {
                        Console.Beep();
                    }
                }

                if (keyinfo.Key == ConsoleKey.Q)
                {
                    // exit the application
                    break;
                }

                Console.CursorTop = 17;
                Console.CursorLeft = 0;
                Console.WriteLine("(x,y) = (" + x + "," + y + ")");
                Console.CursorTop = y;
                Console.CursorLeft = x;
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


        