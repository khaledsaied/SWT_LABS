using System;

namespace DoorControlSystem
{
	public interface IDoor
	{
		void Open();
		void Close();
		bool DoorState {get;}
	}

	public class Door : IDoor
	{
		private bool _DoorState;

		public bool DoorState
		{
			get{ return _DoorState; }
			private set { _DoorState = value; }
		}

		public Door ()
		{
			DoorState = false;
		}

		public void Open()
		{
			DoorState = true;
		}
		
		public void Close()
		{
			DoorState = false;
		}
	}
}

