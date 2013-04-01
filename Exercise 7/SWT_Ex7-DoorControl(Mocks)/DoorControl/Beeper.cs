using System;

namespace DoorControlSystem
{
	public interface IBeeper
	{
		void MakeHappyNoise ();
	}

	public class Beeper : IBeeper
	{
		public Beeper ()
		{
		}

		public void MakeHappyNoise ()
		{
			Console.WriteLine ("HappyNoise ... !");
			//Beeper beep;
		}
	}
}

