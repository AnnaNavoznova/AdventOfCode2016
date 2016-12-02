using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            new Part1().Run();
        }
    }

    class Part1
    {
        public void Run()
        {
            string input = File.ReadAllText("input1.txt");
            string separator1 = ", ";
            string[] separators = new string[] { separator1 };
            string[] parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // ходок
            int x = 0;
            int y = 0;
            int d = 0; // 0 север, 1 восток, 2 юг, 3 запад

            for (var i = 0; i < parts.Length; i++)
            {
                string str = parts[i];
                char turn = str[0];
                int steps = int.Parse(str.Substring(1));

                // поворот
                if (turn == 'R')
                {
                    d++;
                }
                else if (turn == 'L')
                {
                    d += 3; // один поворот налево == три поворота направо;
                }
                d = d % 4; // d>=0 && d<4

                // шаги
                switch (d)
                {
                    case 0:
                        y += steps;
                        break;
                    case 1:
                        x += steps;
                        break;
                    case 2:
                        y -= steps;

                        break;
                    case 3:
                        x -= steps;
                        break;
                }
            }

            Console.WriteLine(Math.Abs(x) + Math.Abs(y));

        }
    }
}
