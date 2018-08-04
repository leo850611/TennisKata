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
				return _firstPlayerScore >= 3 ? "Deuce" : _scoreLookUp[_firstPlayerScore] + "_All";
			}

			if (IsGamePoint())
			{
				return Math.Abs(_firstPlayerScore - _secendPlayerScore) == 1
					? GetAdvPlayer() + "_Adv"
					: GetAdvPlayer() + "_Win";
			}
			return _scoreLookUp[_firstPlayerScore] + "_" + _scoreLookUp[_secendPlayerScore];
		}

		private bool IsGamePoint()
		{
			return _firstPlayerScore > 3 || _secendPlayerScore > 3;
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
