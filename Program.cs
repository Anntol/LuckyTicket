using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type exit to close the program.");
                Console.WriteLine("Enter your ticket number:");
                string line = Console.ReadLine();
                if (line == "exit")
                {
                    break;
                }
                int number;
                if (int.TryParse(line, out number))
                {
                    int len = line.Length;
                    if (len < 4 || len > 8)
                    {
                        Console.WriteLine("Number should be 4 to 8 digits long!");
                    }
                    else
                    {
                        if (len % 2 != 0)
                        {
                            line = '0' + line;
                            len += 1;
                        }

                        int diff = 0;
                        for (int i = 0; i < len; i++)
                        {
                            if (i < len /2)
                            {
                                diff += line[i];
                            }
                            else
                            {
                                diff -= line[i];
                            }
                        }

                        if (diff == 0)
                        {
                            Console.WriteLine("Congratulations! You have a lucky ticket!");
                        } else
                        {
                            Console.WriteLine("Better luck next time!");
                        }                        
                    }
                }
                else
                {
                    Console.WriteLine("Not a number!");
                }
            }
        }
    }
}
