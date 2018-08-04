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

		public string GetScore()
		{
			var _scoreLookUp = new Dictionary<int, string>()
			{
				{1, "Fifteen"},
				{2, "Thirty"},
			};
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
	}
}
