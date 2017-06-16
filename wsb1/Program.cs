using System;
using System.Collections.Generic;
using Lab1.Classes;
using Lab1.Classes.Figures;

namespace Lab1
{
    class Program
    {
		static void Main(string[] args)
        {
            //Chessboard chessboard = Toolbox.chessboardInstance;
            Chessboard chessboard = Toolbox.chessboardInstance;

			//ok
			chessboard.whiteKing.moveTo(new Position("E2"));
			chessboard.whiteBishop1.moveTo(new Position("A3"));

			//error
			chessboard.blackRook1.moveTo(new Position("A8"));

			Console.WriteLine(chessboard.whiteKing);
			Console.WriteLine(chessboard.whiteBishop1);
			Console.WriteLine(chessboard.blackRook1);

            Console.WriteLine("**********************************************");

            Console.WriteLine(chessboard[1]);

			int countFigures = chessboard.countFigures();
			Console.WriteLine("Na szachownicy znajduje się {0} figur.", countFigures.ToString());

			return;
        }


	}

}
