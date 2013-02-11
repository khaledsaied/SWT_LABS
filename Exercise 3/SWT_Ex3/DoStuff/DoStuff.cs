using System;

namespace mainProject
{
		public interface IDoThings
		{
			void DoNothing();
			int DoSomething(int number);
			string DoSomethingElse(string input);
		}

	public class DoHickey : IDoThings
	{
		public void DoNothing()
		{
			Console.WriteLine("Do Nothing");
		}

		public int DoSomething(int number)
		{
			return number;
		}

		public string DoSomethingElse(string input)
		{
			return input;
		}
	}

}

