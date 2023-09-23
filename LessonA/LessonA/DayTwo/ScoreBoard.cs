using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class ScoreBoard
    {
        private static readonly ScoreBoard _board = new ScoreBoard();
        public int Score;
        private ScoreBoard()
        {
            Console.WriteLine("ScoreBoard Created..");
        }
        public static ScoreBoard GetScoreBoard()
        {
            return _board;
        }
    }
    public class TestScoreboard
    {
        public static void TestOne()
        {
            ScoreBoard firstScoreBoard = ScoreBoard.GetScoreBoard();
            firstScoreBoard.Score = 220;
            ScoreBoard secondScoreBoard = ScoreBoard.GetScoreBoard();
            secondScoreBoard.Score = 300;
            Console.WriteLine(secondScoreBoard.Score);
            firstScoreBoard.Score = 250;
            Console.WriteLine(firstScoreBoard.Score);
            Console.WriteLine(secondScoreBoard.Score);
        }
    }
}
