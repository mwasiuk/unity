using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Classes;

namespace Lab1.Classes.Figures
{
	class King : Figure
    {
		public King(string color):base(color) {
			name = "Król";

			switch (color)
			{
				case KOLOR_BIAŁY:
					symbol = "♔";
					position = new Position("E1");
					break;
				case KOLOR_CZARNY:
					symbol = "♚";
					position = new Position("E8");
					break;
			}
		}

		public override bool canBeMoved(Position givenPosition)
		{
			int currentX = position.X;
			int currentY = position.Y;

			List<Position> possiblePositions = new List<Position>();
			possiblePositions.Add(new Position(currentX + 1, currentY));
			possiblePositions.Add(new Position(currentX - 1, currentY));
			possiblePositions.Add(new Position(currentX, currentY + 1));
			possiblePositions.Add(new Position(currentX, currentY - 1));
			possiblePositions.Add(new Position(currentX + 1, currentY + 1));
			possiblePositions.Add(new Position(currentX - 1, currentY + 1));
			possiblePositions.Add(new Position(currentX - 1, currentY - 1));
			possiblePositions.Add(new Position(currentX + 1, currentY - 1));

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
