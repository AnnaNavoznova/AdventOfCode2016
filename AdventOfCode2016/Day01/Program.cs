using System;
using System.IO;

namespace Day01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //new Part1().Run();
            new Part2().Run();
        }
    }

    internal class Part1
    {
        public void Run()
        {
            var input = File.ReadAllText("input1.txt");
            var separator1 = ", ";
            string[] separators = {separator1};
            var parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // ходок
            var x = 0;
            var y = 0;
            var d = 0; // 0 север, 1 восток, 2 юг, 3 запад

            for (var i = 0; i < parts.Length; i++)
            {
                var str = parts[i];
                var turn = str[0];
                var steps = int.Parse(str.Substring(1));

                // поворот
                if (turn == 'R')
                {
                    d++;
                }
                else if (turn == 'L')
                {
                    d += 3; // один поворот налево == три поворота направо;
                }
                d = d%4; // d>=0 && d<4

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

    internal class Part2
    {
        public void Run()
        {
            //var input = File.ReadAllText("input1.txt");
            var input = "R4, R2, R2, R4";
            var separator1 = ", ";
            string[] separators = {separator1};
            var parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // ходок
            var x = 0;
            var y = 0;
            var d = 0; // 0 север, 1 восток, 2 юг, 3 запад
            var path = "";

            for (var i = 0; i < parts.Length; i++)
            {
                var str = parts[i];
                var turn = str[0];
                var steps = int.Parse(str.Substring(1));

                // поворот
                if (turn == 'R')
                {
                    d++;
                }
                else if (turn == 'L')
                {
                    d += 3; // один поворот налево == три поворота направо;
                }
                d = d%4; // d>=0 && d<4

                for (var j = 0; j < steps; j++)
                {
                    switch (d)
                    {
                        case 0:
                            y += 1;
                            break;
                        case 1:
                            x += 1;
                            break;
                        case 2:
                            y -= 1;
                            break;
                        case 3:
                            x -= 1;
                            break;
                    }

                    var stepStr = x + "," + y + ";";
                    if (path.Contains(stepStr))
                    {
                        Console.WriteLine(Math.Abs(x) + Math.Abs(y));
                        return;
                    }

                    path = path + stepStr;
                }
            }
        }
    }
}