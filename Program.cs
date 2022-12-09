using BlockPuzzleSolver.Components;
using System;

namespace BlockPuzzleSolver
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                PrintHelp();
                return;
            }

            var board = new Board(args[0]);
            var pieces = Piece.FromFile(args[1]);

            var solver = new Game.Solver(board, pieces);
            Console.WriteLine("Read in the board:");
            Print(board);
            Console.WriteLine("Read in pieces:");
            for (int i = 0; i < pieces.Count; i++)
            {
                Console.WriteLine($"Piece {i}");
                Print(pieces[i]);
            }

            Console.WriteLine("Press ENTER to begin solving");
            Console.ReadLine();
        }

        public static void PrintHelp()
        {
            Console.WriteLine("Usage: -b board-file -p pieces-files");
        }

        public static void Print(IConsolePrintable item) => Console.WriteLine(item.ToConsoleString());
    }
}
