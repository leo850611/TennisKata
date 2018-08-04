using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tennis;

namespace TennisKata
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void LoveAll()
		{
			var tennisGame = new TennisGame();
			var score = tennisGame.GetScore();
			Assert.AreEqual("Love_All", score);
		}

		[TestMethod]
		public void FifteenLove()
		{
			var tennisGame = new TennisGame();
			tennisGame.FirstPlayerGotScore();
			var score = tennisGame.GetScore();
			Assert.AreEqual("Fifteen_Love", score);
		}
	}
}