using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    sealed class Toolbox
    {
        private static Chessboard chessboard = new Chessboard();

        private Toolbox() {}

        public static Chessboard chessboardInstance
        {
            get
            {
                return chessboard;
            }
        }

    }
}
