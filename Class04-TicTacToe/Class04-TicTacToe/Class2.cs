using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_TicTacToe
{
    public class Player
    {
        public string Name { get; set; }
        public string Marker { get; set; }
        public bool IsTurn { get; set; }

		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); 
				case 2: return new Position(0, 1); 
				case 3: return new Position(0, 2); 
				case 4: return new Position(1, 0); 
				case 5: return new Position(1, 1); 
				case 6: return new Position(1, 2); 
				case 7: return new Position(2, 0); 
				case 8: return new Position(2, 1); 
				case 9: return new Position(2, 2); 

				default: return null;
			}
		}
		public void TakeTurn(Board board)
		{
			IsTurn = true;

			Console.WriteLine($"{Name} it is your turn");

			Position position = GetPosition(board);

			if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
			{
				board.GameBoard[position.Row, position.Column] = Marker;
			}
			else
			{
				Console.WriteLine("This space is already occupied");
			}
		}
	}
}
