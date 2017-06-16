using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    class Position
    {
        private int x;
        private int y;
        private string field;

        public string Field
        {
			get { return field; }
            set 
			{ 
                field = value;
                this.x = convertX(field);
				this.y = Int32.Parse(field[1].ToString()); 
            }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
       
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private int convertX(string str)
        {
			switch(str[0].ToString().ToUpper()) {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "G":
                    return 7;
                case "H":
                    return 8;
                default:
					Console.WriteLine("Podano złą pozycje");
					this.x = 0;
					this.y = 0;
					this.field = "NN";
                    return 0;
            }
            
        }

		public Position() { }
		public Position(string field)
		{
			this.Field = field;
		}

		public override string ToString()
		{
			return string.Format("Pole = {0}, X = {1}, Y = {2}", Field, X, Y);
		}

		public Position(int X, int Y)
		{
			if (X > 0 && Y > 0)
			{
				this.X = X;
				this.Y = Y;

				switch (X)
				{
					case 1: this.field = "A" + Y; break;
					case 2: this.field = "B" + Y; break;
					case 3: this.field = "C" + Y; break;
					case 4: this.field = "D" + Y; break;
					case 5: this.field = "E" + Y; break;
					case 6: this.field = "F" + Y; break;
					case 7: this.field = "G" + Y; break;
					case 8: this.field = "H" + Y; break;
					default:
						this.x = 0;
						this.y = 0;
						this.field = "NN";
						break;
				}
			}
			else
			{
				this.field = "NN";
			}
		}
    }
}
