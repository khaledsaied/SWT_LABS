using System;

namespace DoorControl
{
	public interface IDoorController
	{
		bool ValidateEntryRequest(ICardDB id);		
		void Open();
		void Close();
		void MakeHappyNoise ();
	}

	public class DoorController : IDoorController
	{
		//private bool doorOpened;
		//void RequestEntry(id){}
		public Door door = new Door();
		DoorController ()
		{
			//doorOpened = false; 
		}
		public bool ValidateEntryRequest(ICardDB id)
		{
			return id.ValidateEntryRequest();
		}
		public void Open()
		{
			door.DoorState = true;
		}
		public void Close()
		{
			door.DoorState = false;
		}
		public void MakeHappyNoise ()
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