using System;

namespace mainProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
/*			Console.WriteLine ("Hello World!");

			DoHickey test = new DoHickey();

			test.DoNothing();
			Console.WriteLine(test.DoSomething(2));
			Console.WriteLine(test.DoSomethingElse("HEJ"));
*/

			GasEngine gas = new GasEngine(100);
			DieselEngine diesel = new DieselEngine(200);
			MotorBike motorbikeGas = new MotorBike(gas);
			MotorBike motorbikeDiesel = new MotorBike(diesel);

			motorbikeGas.RunAtHalfSpeed();
			Console.WriteLine("Gas Motorbike at half speed: {0}",gas.Throttle);

			motorbikeDiesel.RunAtHalfSpeed();
			Console.WriteLine("Diesel Motorbike at half speed: {0}",diesel.Throttle);

		}
	}
}
