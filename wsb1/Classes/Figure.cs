using Lab1.Classes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
	abstract class Figure
	{
		public string name;
		public string color;
		public string symbol;
		public Position position;
		public static List<Figure> figures = new List<Figure>();
		public delegate void moveMessage(bool success);

		public const string KOLOR_BIAŁY = "biały";
		public const string KOLOR_CZARNY = "czarny";

		public Figure(string color)
		{
			color.ToLower();

			if (!(color == KOLOR_BIAŁY || color == KOLOR_CZARNY))
			{
				Console.WriteLine("Podano zły kolor");
				return;
			}
			else
			{
				this.color = color;
			}

			figures.Add(this);
		}

		public override string ToString()
		{
			return string.Format("+-+--------+--------+----+\n" +
								 "|{3,1}|{0,8}|{1,8}|{2,4}|\n" +
								 "+-+--------+--------+----+",
								 this.name.PadRight(7),
								 FirstToUpper(this.color).PadRight(7),
								 this.position.Field.PadRight(3),
								 this.symbol
								);
		}

		private string FirstToUpper(string str)
		{
			return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
		}

		public virtual bool canBeMoved(Position givenPosition)
		{
			if (figures.Count(f => f.position.Field == givenPosition.Field) > 0)
			{
				return false;
			}
			return true;
		}

		public virtual void moveTo(Position givenPosition)
		{
			moveMessage message = new moveMessage(Message);

			if (this.canBeMoved(givenPosition))
			{
				this.position = givenPosition;

				message(true);
			}
			else
			{
				message(false); 
			}
		}

		public static void Message(bool success)
		{
			if (success)
			{
				Console.WriteLine("Figura została przesunięta");

			}
			else
			{
				Console.WriteLine("Błąd, pole zajęte lub wykracza poza dozwolony ruch dla figury.");
			}
		}

        public static Figure FigureFactory(string figure, string color)
        {
            switch (figure)
            {
                case "king": 
                    return new King(color);
                case "bishop":
                    return new Bishop(color);
                case "rook":
                    return new Rook(color);
                case "queen":
                    return new Queen(color);
                default: 
                    throw new NotSupportedException("Nie rozpoznano figury");
            }
        }
	}
}