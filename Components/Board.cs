using System;
using System.Collections.Generic;
using System.Text;

namespace BlockPuzzleSolver.Components
{
    public class Board : IBoard, IConsolePrintable
    {
        /// <summary>
        /// Create a new <see cref="Board"/> using a aboard description file
        /// </summary>
        /// <param name="boardFile"></param>
        public Board(string boardFile)
        {
            throw new NotImplementedException();
        }

        public string ToConsoleString()
        {
            throw new NotImplementedException();
        }
    }
}
