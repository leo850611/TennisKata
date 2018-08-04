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
			if (_firstPlayerScore == 2)
			{
				return "Thirty_Love";
			}
			if (_firstPlayerScore == 1)
			{
				return "Fifteen_Love";
			}
			
			return "Love_All";
		}

		public void FirstPlayerGotScore()
		{
			_firstPlayerScore += 1;
		}
	}
}
