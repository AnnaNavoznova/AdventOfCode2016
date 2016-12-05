using System;
using System.IO;

namespace Day02
{
    internal class Part1
    {
        public void Run1()
        {
            var input = GetInput();
            var separator = Environment.NewLine;
            string[] separators = {separator};
            var lines = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var current = 5;

            foreach (var line in lines)
            {
                foreach (var dirChar in line)
                {
                    switch (dirChar)
                    {
                        case 'U':
                            if (current > 3)
                            {
                                current -= 3;
                            }
                            break;
                        case 'D':
                            if (current < 7)
                            {
                                current += 3;
                            }
                            break;
                        case 'L':
                            if ((current - 1)%3 != 0)
                            {
                                current -= 1;
                            }
                            break;
                        case 'R':
                            if (current%3 != 0)
                            {
                                current += 1;
                            }
                            break;
                    }
                }
                Console.WriteLine(current);
            }
        }

        public void Run()
        {
            var input = GetInput();
            var separator = Environment.NewLine;
            string[] separators = {separator};
            var lines = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var x = 0;
            var y = 0;


            foreach (var line in lines)
            {
                foreach (var dirChar in line)
                {
                    switch (dirChar)
                    {
                        case 'U':
                            if (y != -1)
                            {
                                y--;
                            }
                            break;
                        case 'D':
                            if (y != 1)
                            {
                                y++;
                            }
                            break;
                        case 'L':
                            if (x != -1)
                            {
                                x--;
                            }
                            break;
                        case 'R':
                            if (x != 1)
                            {
                                x++;
                            }
                            break;
                    }
                }
                Console.WriteLine(GetButtonByCoords(x, y));
            }
        }


        public int GetButtonByCoords(int x, int y)
        {
            int code= (x+1) + (y+1)*3+1;
            return code;
        }

        public string GetInput()
        {
            return File.ReadAllText("input1.txt");
        }
    }
}