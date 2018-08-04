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
			FirstPlayerGotScoreTimes(2);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Thirty_Love", score);
		}

		[TestMethod]
		public void FortyLove()
		{
			FirstPlayerGotScoreTimes(3);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Forty_Love", score);
		}

		[TestMethod]
		public void LoveFifteen()
		{
			SecendPlayerGotScoreTimes(1);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Love_Fifteen", score);
		}

		[TestMethod]
		public void LoveThirty()
		{
			SecendPlayerGotScoreTimes(2);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Love_Thirty", score);
		}

		private void SecendPlayerGotScoreTimes(int times)
		{
			for (int i = 0; i < times; i++)
			{
				_tennisGame.SecendPlayerGotScore();
			}
		}


		private void FirstPlayerGotScoreTimes(int times)
		{
			for (int i = 0; i < times; i++)
			{
				_tennisGame.FirstPlayerGotScore();
			}
		}
	}
}