using System;
using System.Collections.Generic;
using System.Text;

namespace BlockPuzzleSolver.Components
{
    public class Piece : IPiece, IConsolePrintable
    {
        /// <summary>
        /// Read a collection of pieces from a file
        /// </summary>
        /// <param name="piecesFile"></param>
        /// <returns></returns>
        public static List<Piece> FromFile(string piecesFile)
        {
            throw new NotImplementedException();
        }

        public string ToConsoleString()
        {
            throw new NotImplementedException();
        }
    }
}
