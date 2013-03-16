using System;

namespace DoorControl
{
	public class Door : IDoor
	{
		public bool DoorState
		{
			get; 
			set;
		}

		public Door ()
		{
			DoorState = false;
		}
	}
}

