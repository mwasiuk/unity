using System;
using System.Collections.Generic;
using Lab1.Classes.Figures;

namespace Lab1.Classes
{
	class Chessboard
	{

        public Figure[] figures;

		//kings
		public Figure whiteKing = Figure.FigureFactory("king", "biały");
        public Figure blackKing = Figure.FigureFactory("king", "czarny");

		//queens
        public Figure whiteQueen = Figure.FigureFactory("queen", "biały");
        public Figure blackQueen = Figure.FigureFactory("queen", "czarny");

		//rooks
        public Figure whiteRook1 = Figure.FigureFactory("rook", "biały");
        public Figure whiteRook2 = Figure.FigureFactory("rook", "biały");
        public Figure blackRook1 = Figure.FigureFactory("rook", "czarny");
        public Figure blackRook2 = Figure.FigureFactory("rook", "czarny");

		//bishops
        public Figure whiteBishop1 = Figure.FigureFactory("bishop", "biały");
        public Figure whiteBishop2 = Figure.FigureFactory("bishop", "biały");
        public Figure blackBishop1 = Figure.FigureFactory("bishop", "czarny");
        public Figure blackBishop2 = Figure.FigureFactory("bishop", "czarny");

		public Chessboard()
		{
			foreach (Figure figure in Figure.figures)
			{
				Console.WriteLine(figure);
			}

            figures = new Figure[12];

            figures[0] = whiteKing;
            figures[1] = blackKing;

            figures[2] = whiteQueen;
            figures[3] = blackQueen;

            figures[4] = whiteRook1;
            figures[5] = whiteRook2;
            figures[6] = blackRook1;
            figures[7] = blackRook2;

            figures[8] = whiteBishop1;
            figures[9] = whiteBishop2;
            figures[10] = blackBishop1;
            figures[11] = blackBishop2;
		}

        public Figure this[int index] 
        {
            get
            {
                return this.figures[index];
            }

            set
            {
                this.figures[index] = value;
            }
        }
	}

	static class extenstion
	{
		public static int countFigures(this Chessboard chessboard)
		{
			return chessboard.figures.Length;
		}
	}
}
