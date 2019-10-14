using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        const int CanvasHeight = 80;
        const int CanvasWidth = 25;

        static void GetLineCoords(string input, out int x1, out int x2, out int y1, out int y2)
        {
            var inputTokens = input.Split(separator: ',');
            x1 = int.Parse(inputTokens[0]);
            y1 = int.Parse(inputTokens[1]);
            x2 = int.Parse(inputTokens[2]);
            y2 = int.Parse(inputTokens[3]);

        }

        static void Main(string[] args)
        {
            float[,] canvas = float[CanvasWidth, CanvasHeight];
                ConsoleKeyInfo key;
            // y=ax+b; dělen nulou
            do
            {

                Console.WriteLine("Zadej souřadnice čáry x1, y1, x2, y2");
                GetLineCoords(Console.ReadLine(), out int x1, out int x2, out int y1, out int y2);

                Console.Clear();
                //DrawLinetoCanvas(canvas, x1, y1, x2, y2);
                //Draw Canvas(canvas);

                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Enter);


            const int canvasWidth = 2 * 80;
            const int canvasHeight = 2 * 25;
            static void GetLineCoord(out int x1, out int x2, out int y1, out int y2)
            {
                Console.WriteLine("Zadej souřadnice ");
                var input = Console.ReadLine();
                var tokens = input.Split(',');
                x1 = int.Parse(tokens[0]);
                y1 = int.Parse(tokens[1]);
                x2 = int.Parse(tokens[2]);
                y2 = int.Parse(tokens[3]);
            }


            static bool DrawLine(int[,] canvas, out int x1, out int x2, out int y1, out int y2)
            {
                int dx12 = x2 - x1;
                int dy12 = y2 - y1;

                int = steps = Math.max(Math.Abs(dx12), Math.Abs(dy12));
                double dx = dx12 / steps;
                double dy = dy12 / steps;

                for (int i = 0; i < steps; i++)
                {
                    canvas[Convert.ToInt32(x1 + steps * dx), (int)(y1 + steps * dy + 0.5)] = 1;
                }

                return true
            }

            static void PutCanvasToScreen(int[,] canvas);
               }



    }
}
