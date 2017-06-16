using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Figures
{
	class Bishop : Figure
	{

		public Bishop(string color) : base(color)
		{
			name = "Goniec";

			switch (color)
			{
				case KOLOR_BIAŁY:
					symbol = "♗";
					position = specifyPosition(KOLOR_BIAŁY);
					break;
				case KOLOR_CZARNY:
					symbol = "♝";
					position = specifyPosition(KOLOR_CZARNY);
					break;
			}
		}

		private Position specifyPosition(string kolor)
		{
			switch (Figure.figures.Count(f => f.color == kolor && f is Bishop))
			{
				case 1:
					if (color == KOLOR_BIAŁY)
					{
						position = new Position("C1");
					}
					else
					{
						position = new Position("C8");
					}
					break;
				case 2:
					if (color == KOLOR_BIAŁY)
					{
						position = new Position("F1");
					}
					else
					{
						position = new Position("F8");
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
