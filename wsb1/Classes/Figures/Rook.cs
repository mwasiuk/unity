using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Figures
{
	class Rook : Figure
    {

		public Rook(string color):base(color) {
			name = "Wieża";

			switch (color)
			{
				case KOLOR_BIAŁY:
					symbol = "♕";
					position = specifyPosition(KOLOR_BIAŁY);
					break;
				case KOLOR_CZARNY:
					symbol = "♛";
					position = specifyPosition(KOLOR_CZARNY);
					break;
			}

		}

		private Position specifyPosition(string kolor)
		{
			switch (Figure.figures.Count(f => f.color == kolor && f is Rook))
			{
				case 1:
					if (color == KOLOR_BIAŁY)
					{
						position = new Position("A1");
					}
					else
					{
						position = new Position("A8");
					}
					break;
				case 2:
					if (color == KOLOR_BIAŁY)
					{
						position = new Position("H1");
					}
					else
					{
						position = new Position("H8");
					}
					break;

			}

			return position;
		}

		public override bool canBeMoved(Position givenPosition)
		{
			int currentX = position.X;
			int currentY = position.Y;

			List<Position> possiblePositions = new List<Position>();
			//X
			possiblePositions.Add(new Position(1, currentY));
			possiblePositions.Add(new Position(2, currentY));
			possiblePositions.Add(new Position(3, currentY));
			possiblePositions.Add(new Position(4, currentY));
			possiblePositions.Add(new Position(5, currentY));
			possiblePositions.Add(new Position(6, currentY));
			possiblePositions.Add(new Position(7, currentY));
			possiblePositions.Add(new Position(8, currentY));
			//Y
			possiblePositions.Add(new Position(currentX, 1));
			possiblePositions.Add(new Position(currentX, 2));
			possiblePositions.Add(new Position(currentX, 3));
			possiblePositions.Add(new Position(currentX, 4));
			possiblePositions.Add(new Position(currentX, 5));
			possiblePositions.Add(new Position(currentX, 6));
			possiblePositions.Add(new Position(currentX, 7));
			possiblePositions.Add(new Position(currentX, 8));

			foreach (Position pos in possiblePositions)
			{
				if (base.canBeMoved(pos) && pos.Field == givenPosition.Field)
				{
					return true;
				}
			}
			return false;
		}
    }
}
