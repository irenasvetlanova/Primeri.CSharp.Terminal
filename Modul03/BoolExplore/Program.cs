﻿using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//bool _b = true;  //true / false

			//bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0;//Convert.ToInt32 (Console.ReadLine ());

		
			string _input = "0";

			Console.Write ("Моля въведете индекс:");
			_input = Console.ReadLine ();

			bool _check01 = int.TryParse (_input, out _ui);
			bool _check02 = _ui <= _i.Length;
			bool _check03 = _ui > 0;

			if (_check01 && _check02 && _check03) {
				Console.WriteLine (_i [_ui - 1]);
			}

			if (!_check01) {
				Console.WriteLine ("Индекса трябва да е цяло число\n\n\n");

			}

			if (!_check02) {
				Console.WriteLine ("Индекса е прекалено голям\n\n\n");

			}

			if (!_check03 && _check01) {
				Console.WriteLine ("Индекса е прекалено малък\n\n\n");

			}

//			bool _exp01 = _check01 && _check02;     //Логическо и - "&&"
//			bool _exp02 = _check01 || _check02;     //Логическо и - "||"
//			bool _exp03 = !_check01;				//Отрицание "!"
//
//			Console.WriteLine ( "Логическо И:" + _exp01.ToString () );
//			Console.WriteLine ( "Логическо ИЛИ:" + _exp02.ToString () );
//			Console.WriteLine ("Отрицание на " + _check01.ToString () + ": " + _exp03);

//			if (_ui > 0 && _ui <= _i.Length) {
//				Console.WriteLine (_i [_ui - 1]);
//			} else {
//				if (_ui > _i.Length) 
//				{
//					Console.WriteLine ("Индекса е прекалено голям\n\n\n");
//				}
//
//				if (_ui <= 0) 
//				{
//					Console.WriteLine ("Индекса е прекалено малък\n\n\n");
//				}
//				Console.WriteLine (_i [_ui - 1]);
			}
		}
	}


		
	

