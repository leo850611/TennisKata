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
			if (_firstPlayerScore >= 3 && _secendPlayerScore >= 3)
			{
				if (_firstPlayerScore - _secendPlayerScore == 1)
				{
					return "FirstPlayer_Adv";
				}
				return "Deuce";
			}
			if (_firstPlayerScore == _secendPlayerScore)
			{
				return _scoreLookUp[_firstPlayerScore]+"_All";
			}
			return _scoreLookUp[_firstPlayerScore] +"_"+ _scoreLookUp[_secendPlayerScore];
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
