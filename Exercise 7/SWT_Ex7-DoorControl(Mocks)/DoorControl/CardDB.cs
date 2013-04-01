using System;
using System.Collections.Generic;

namespace DoorControlSystem
{
	public interface ICardDB
	{
		bool ValidateEntryRequest(int ID);
	}

	public class CardDB : ICardDB
	{
		private List<int> IDs;
		
		public CardDB ()
		{
			IDs = new List<int>();
			for (int i = 0; i < 11; i++)
			{
				IDs.Add(i);
			}
		}
		public bool ValidateEntryRequest(int ID)
		{
			if (IDs.Contains(ID))
				return true;
			else
				return false;
		}
		
	}
}

