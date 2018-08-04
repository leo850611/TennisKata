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

		[TestMethod]
		public void FifteenFifteen()
		{
			SecendPlayerGotScoreTimes(1);
			FirstPlayerGotScoreTimes(1);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Fifteen_All", score);
		}

		[TestMethod]
		public void Deuce_3_3()
		{
			SecendPlayerGotScoreTimes(3);
			FirstPlayerGotScoreTimes(3);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Deuce", score);
		}

		[TestMethod]
		public void Deuce_4_4()
		{
			SecendPlayerGotScoreTimes(4);
			FirstPlayerGotScoreTimes(4);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("Deuce", score);
		}

		[TestMethod]
		public void FirstPlayer_Adv()
		{
			FirstPlayerGotScoreTimes(4);
			SecendPlayerGotScoreTimes(3);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("FirstPlayer_Adv", score);
		}

		[TestMethod]
		public void SecendPlayer_Adv()
		{
			FirstPlayerGotScoreTimes(3);
			SecendPlayerGotScoreTimes(4);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("SecendPlayer_Adv", score);
		}

		[TestMethod]
		public void FirstPlayer_Win()
		{
			FirstPlayerGotScoreTimes(5);
			SecendPlayerGotScoreTimes(3);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("FirstPlayer_Win", score);
		}

		[TestMethod]
		public void SecendPlayer_Win()
		{
			FirstPlayerGotScoreTimes(1);
			SecendPlayerGotScoreTimes(4);
			var score = _tennisGame.GetScore();
			Assert.AreEqual("SecendPlayer_Win", score);
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