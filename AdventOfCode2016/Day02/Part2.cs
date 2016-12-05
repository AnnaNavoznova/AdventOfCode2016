using System;
using System.IO;
using System.Runtime.Remoting;

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

            var current = 5;
            foreach (var line in lines)
            {
                foreach (var dirChar in line)
                {
                    { 
                    }
                }
            }




            //foreach (var line in lines)
            //{
            //    foreach (var dirChar in line)
            //    {
            //        switch (dirChar)
            //        {
            //            case 'U':
            //                if (current > 3)
            //                {
            //                    current -= 3;
            //                }
            //                break;
            //            case 'D':
            //                if (current < 7)
            //                {
            //                    current += 3;
            //                }
            //                break;
            //            case 'L':
            //                if ((current - 1)%3 != 0)
            //                {
            //                    current -= 1;
            //                }
            //                break;
            //            case 'R':
            //                if (current%3 != 0)
            //                {
            //                    current += 1;
            //                }
            //                break;
            //        }
            //    }
            //    Console.WriteLine(current);
            //}
        }

        public string GetInput()
        {
            return File.ReadAllText("input1.txt");
        }
    }
}


