using System;
using DoorControlSystem;

namespace DoorControlTest
{
	public class Mocks
	{
		public class MockDoor : IDoor
		{
			public void Door ()
			{
				WasCloseCalled = WasOpenCalled = true;
			}
			public bool WasOpenCalled { get; private set; }
			public bool WasCloseCalled { get; private set; }
			public void Open() { WasOpenCalled = true; }
			public void Close() { WasCloseCalled = true; }

			public bool DoorState
			{
				get{ return true; }

			}


		}
	}
}

