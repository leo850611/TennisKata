using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tennis;

namespace TennisKata
{
	[TestClass]
	public class UnitTest1
	{
		private TennisGame _tennisGame = new TennisGame();

		[TestMethod]
		public void LoveAll()
		{
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Love_All", score);
		}

		[TestMethod]
		public void FifteenLove()
		{
			_tennisGame.FirstPlayerGotScore();
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Fifteen_Love", score);
		}

		[TestMethod]
		public void ThirtyLove()
		{
			_tennisGame.FirstPlayerGotScore();
			_tennisGame.FirstPlayerGotScore();
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Thirty_Love", score);
		}

	}
}