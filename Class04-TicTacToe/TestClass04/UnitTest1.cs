using System;
using Xunit;
using Class04_TicTacToe;

namespace TestClass04
{
    public class UnitTest1
    {
        [Fact]
        public void TestForTie()
        {
            Position p1 = new Position(0, 0);
            Position p2 = new Position(0, 1);
            Position p3 = new Position(1, 2);
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2);
            testGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            testGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            testGame.Board.GameBoard[p3.Row, p3.Column] = "X";
            Assert.False(testGame.CheckForWinner(testGame.Board));
        }
        [Fact]
        public void TestWin()
        {
            Position p1 = new Position(0, 0);
            Position p2 = new Position(0, 1);
            Position p3 = new Position(0, 2);
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2);
            testGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            testGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            testGame.Board.GameBoard[p3.Row, p3.Column] = "X";
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }
        [Fact]
        public void TestDiagonal()
        {
            Position p1 = new Position(0, 0);
            Position p2 = new Position(1, 1);
            Position p3 = new Position(2, 2);
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2);
            testGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            testGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            testGame.Board.GameBoard[p3.Row, p3.Column] = "X";
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        
        [Fact]
        public void TestSwitchTurns()
        {
            Player player1 = new Player();
            player1.Name = "Foo";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "Bar";
            Game testGame = new Game(player1, player2);
            Player playerBeforeSwitch = testGame.NextPlayer();
            testGame.SwitchPlayer();
            Player playerAfterSwitch = testGame.NextPlayer();
            Assert.NotEqual(playerBeforeSwitch.Name, playerAfterSwitch.Name);
        }

        
        [Fact]
        public void TestPosition()
        {
            int boardPosition = 5;
            Position positionCoordinates = Player.PositionForNumber(boardPosition);
            Assert.True(positionCoordinates.Row == 1 && positionCoordinates.Column == 1);
        }

       
        [Fact]
        public void TestNoPosition()
        {
            int boardPosition = 10;
            Position positionCoordinates = Player.PositionForNumber(boardPosition);
            Assert.Null(positionCoordinates);
        }
    }
}
