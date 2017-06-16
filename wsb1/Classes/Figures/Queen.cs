using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Figures
{
	class Queen : Figure
    {

		public Queen(string color):base(color) {
			name = "Hetman";

			switch (color)
			{
				case KOLOR_BIAŁY:
					symbol = "♕";
					position = new Position("D1");
					break;
				case KOLOR_CZARNY:
					symbol = "♛";
					position = new Position("D8");
					break;
			}
		}

		public override bool canBeMoved(Position givenPosition)
		{
			int currentX = position.X;
			int currentY = position.Y;

			List<Position> possiblePositions = new List<Position>();
			possiblePositions.Add(new Position(currentX - 1, currentY + 1));
			possiblePositions.Add(new Position(currentX - 2, currentY + 2));
			possiblePositions.Add(new Position(currentX - 3, currentY + 3));
			possiblePositions.Add(new Position(currentX - 4, currentY + 4));
			possiblePositions.Add(new Position(currentX - 5, currentY + 5));
			possiblePositions.Add(new Position(currentX - 6, currentY + 6));
			possiblePositions.Add(new Position(currentX - 7, currentY + 7));
			possiblePositions.Add(new Position(currentX - 8, currentY + 8));

			possiblePositions.Add(new Position(currentX + 1, currentY - 1));
			possiblePositions.Add(new Position(currentX + 2, currentY - 2));
			possiblePositions.Add(new Position(currentX + 3, currentY - 3));
			possiblePositions.Add(new Position(currentX + 4, currentY - 4));
			possiblePositions.Add(new Position(currentX + 5, currentY - 5));
			possiblePositions.Add(new Position(currentX + 6, currentY - 6));
			possiblePositions.Add(new Position(currentX + 7, currentY - 7));
			possiblePositions.Add(new Position(currentX + 8, currentY - 8));

			possiblePositions.Add(new Position(currentX + 1, currentY + 1));
			possiblePositions.Add(new Position(currentX + 2, currentY + 2));
			possiblePositions.Add(new Position(currentX + 3, currentY + 3));
			possiblePositions.Add(new Position(currentX + 4, currentY + 4));
			possiblePositions.Add(new Position(currentX + 5, currentY + 5));
			possiblePositions.Add(new Position(currentX + 6, currentY + 6));
			possiblePositions.Add(new Position(currentX + 7, currentY + 7));
			possiblePositions.Add(new Position(currentX + 8, currentY + 8));

			possiblePositions.Add(new Position(currentX - 1, currentY - 1));
			possiblePositions.Add(new Position(currentX - 2, currentY - 2));
			possiblePositions.Add(new Position(currentX - 3, currentY - 3));
			possiblePositions.Add(new Position(currentX - 4, currentY - 4));
			possiblePositions.Add(new Position(currentX - 5, currentY - 5));
			possiblePositions.Add(new Position(currentX - 6, currentY - 6));
			possiblePositions.Add(new Position(currentX - 7, currentY - 7));
			possiblePositions.Add(new Position(currentX - 8, currentY - 8));

			possiblePositions.Add(new Position(currentX, 1));
			possiblePositions.Add(new Position(currentX, 2));
			possiblePositions.Add(new Position(currentX, 3));
			possiblePositions.Add(new Position(currentX, 4));
			possiblePositions.Add(new Position(currentX, 5));
			possiblePositions.Add(new Position(currentX, 6));
			possiblePositions.Add(new Position(currentX, 7));
			possiblePositions.Add(new Position(currentX, 8));

			possiblePositions.Add(new Position(1, currentY));
			possiblePositions.Add(new Position(2, currentY));
			possiblePositions.Add(new Position(3, currentY));
			possiblePositions.Add(new Position(4, currentY));
			possiblePositions.Add(new Position(5, currentY));
			possiblePositions.Add(new Position(6, currentY));
			possiblePositions.Add(new Position(7, currentY));
			possiblePositions.Add(new Position(8, currentY));

			foreach (Position pos in possiblePositions)
			{
				Console.WriteLine(pos);
				if (base.canBeMoved(pos) && pos.Field == givenPosition.Field)
				{
					return true;
				}
			}
			return false;
		}
    }
}
