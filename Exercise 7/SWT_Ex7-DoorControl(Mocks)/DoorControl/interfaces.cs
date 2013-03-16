using System;

namespace DoorControl
{

	public interface IDoorControl
	{
		bool ValidateEntryRequest(ICardDB id);		
		void Open();
		void Close();
		void MakeHappyNoise ();
	}

	public interface IDoor
	{
		bool DoorState { get; set;}
	}

	public interface ICardDB
	{
		bool ValidateEntryRequest();
	}

	public interface IBeeper
	{

	}
		
}

