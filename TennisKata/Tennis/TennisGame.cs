using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
	public class TennisGame
	{
		private int _firstPlayerScore;

		private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
		{
			{1, "Fifteen"},
			{2, "Thirty"},
			{3, "Forty"},
		};

		private int _secendPlayerScore;

		public string GetScore()
		{
			if (_secendPlayerScore > 0)
			{
				return "Love_" + _scoreLookUp[_secendPlayerScore];
			}

			if (_firstPlayerScore>0)
			{
				return _scoreLookUp[_firstPlayerScore] + "_Love";
			}
			return "Love_All";
		}

		public void FirstPlayerGotScore()
		{
			_firstPlayerScore += 1;
		}

		public void SecendPlayerGotScore()
		{
			_secendPlayerScore += 1;
		}
	}
}
