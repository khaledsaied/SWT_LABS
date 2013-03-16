using System;

namespace DoorControl
{
	public class DoorControl : IDoorControl
	{
		//private bool doorOpened;
		//void RequestEntry(id){}
		public Door door = new Door();
		DoorControl ()
		{
			//doorOpened = false; 
		}
		bool ValidateEntryRequest(ICardDB id)
		{
			return id.ValidateEntryRequest();
		}
		void Open()
		{
			door.DoorState = true;
		}
		void Close()
		{
			door.DoorState = false;
		}
		void MakeHappyNoise ()
		{
			Console.WriteLine ("HappyNoise ... !");
			//Beeper beep;
		}

	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
}