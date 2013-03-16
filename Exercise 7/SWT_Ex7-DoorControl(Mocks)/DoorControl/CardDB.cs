using System;

namespace DoorControl
{
	public class CardDB : ICardDB
	{
		private int _id;
		
		public CardDB (int id)
		{
			_id = id;
		}
		public bool ValidateEntryRequest()
		{
			return _id == 1;
		}
		
	}
}

