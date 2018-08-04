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
			{0, "Love"},
			{1, "Fifteen"},
			{2, "Thirty"},
			{3, "Forty"},
		};

		private int _secendPlayerScore;

		public string GetScore()
		{
			if (IsPlayerSameScore())
			{
				if (_firstPlayerScore >= 3)
				{
					return "Deuce";
				}
				return _scoreLookUp[_firstPlayerScore] + "_All";
			}

			if (_firstPlayerScore > 3 || _secendPlayerScore > 3)
			{
				if (Math.Abs(_firstPlayerScore - _secendPlayerScore) == 1)
				{
					return GetAdvPlayer() + "_Adv";
				}
				return GetAdvPlayer() + "_Win";
			}
			return _scoreLookUp[_firstPlayerScore] + "_" + _scoreLookUp[_secendPlayerScore];
		}

		private bool IsPlayerSameScore()
		{
			return _firstPlayerScore == _secendPlayerScore;
		}

		private string GetAdvPlayer()
		{
			if (_firstPlayerScore > _secendPlayerScore)
			{
				return "FirstPlayer";
			}
			return "SecendPlayer";
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
