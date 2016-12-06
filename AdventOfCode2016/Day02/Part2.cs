using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;

namespace Day02
{
    internal class Part2
    {
        public void Run()
        {
            var input = GetInput();
            var separator = Environment.NewLine;
            string[] separators = {separator};
            var lines = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var x = -2;
            var y = 0;

            foreach (var line in lines)
            {
                foreach (var dirChar in line)
                {
                    {
                        switch (dirChar)
                        {
                            case 'U':
                                y--;
                                if (Math.Abs(x) + Math.Abs(y) >2)
                                {
                                    y++;
                                }
                                break;
                            case 'D':
                                y++;
                                if (Math.Abs(x) + Math.Abs(y) > 2)
                                {
                                    y--;
                                }
                                break;
                            case 'R':
                                x++;
                                if (Math.Abs(x) + Math.Abs(y) > 2)
                                {
                                    x--;
                                }
                                break;
                            case 'L':
                                x--;
                                if (Math.Abs(x) + Math.Abs(y) > 2)
                                {
                                    x++;
                                }
                                break;
                        }
                    }
                }
                Console.Write(GetCode(x, y));
            }
            Console.WriteLine();
        }

        public string GetInput()
        {
            return File.ReadAllText("input1.txt");
        }

        public string GetCode(int x, int y)
        {
            var x1 = x + 2;
            var y1 = y + 2;

            var index = x1 + y1*5;

            var padStr =   "  1  "
                         + " 234 "
                         + "56789"
                         + " ABC "
                         + "  D  ";
            return padStr[index].ToString(); // padStr.Substring(index, 1);
        }
    }
}


