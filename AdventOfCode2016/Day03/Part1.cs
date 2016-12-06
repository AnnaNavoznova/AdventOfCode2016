using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Part1
    {
        public void Run()
        {
            var input = GetInput();
            var separator = Environment.NewLine;
            string[] separators = {separator};
            string[] lines = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (var line in lines)
            {
                string[] sides = line.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                string firstSide = sides[0];
                int a = int.Parse(firstSide);

                string secondSide = sides[1];
                int b = int.Parse(secondSide);

                string thirdSide = sides[2];
                int c = int.Parse(thirdSide);

                if (CheckIsTriangleSides(a, b, c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private string GetInput()
        {
            //return @"5 10 25
                     //3 4 6";

            return File.ReadAllText("input1.txt");
        }

        private bool CheckIsTriangleSides(int a, int b, int c)
        {
            return a + b > c && c + b > a && a + c > b;
        }
    }
}
