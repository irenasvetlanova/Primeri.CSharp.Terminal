using System;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput = "";

			//Потребителски вход
			do {
				Console.Write ("? ");
				_userinput = Console.ReadLine ();

			} while(_userinput != "exit");
		}
	}
}
