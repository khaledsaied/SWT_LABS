using System;

namespace DoorControlSystem
{
	class HappyTest
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Happy Test !\n");
			DoorControl MyController = new DoorControl(new CardDB(), new Door(), new Beeper());
			MyController.RequestEntry(1);
			MyController.OpenDoor();
			MyController.CloseDoor();
		}
	}

	public interface IDoorControl
	{
		void RequestEntry(int ID);
		void OpenDoor();
		void CloseDoor();
	}

	public class DoorControl : IDoorControl
	{
		public ICardDB _CardDB;
		public IDoor _Door;
		private IBeeper _Beeper;
		private bool _Request;
		public bool Request { get { return _Request; } }


		public DoorControl (ICardDB cardDB, IDoor door, IBeeper beeper )
		{
			_CardDB = cardDB;
			_Door = door;
			_Beeper = beeper;
		}

		public void RequestEntry(int ID)
		{
			if (_Request = _CardDB.ValidateEntryRequest(ID))
				Console.WriteLine("ID is valid");
			else
				Console.WriteLine("ID is not valid. Request failed!");
		}

		public void OpenDoor()
		{
			if (_Request)
			{
				_Door.Open();
				_Beeper.MakeHappyNoise();
				if (_Door.DoorState)
					Console.WriteLine("Door Opened");
			}
		}
		public void CloseDoor()
		{
			if (_Door.DoorState)
			{
				_Door.Close();
				if (!_Door.DoorState)
					Console.WriteLine("Door Closed");
			}
			else
				Console.WriteLine("The door is not open");
		}
	}
}