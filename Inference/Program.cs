using System;

namespace Inference
{
	
	class MainClass
	{
		

		public static void Main(string[] args)
		{
			
			 

			bool _quit;
			string _folderpath;

			_quit = false;
			Console.WriteLine("                --Inference Engine--                  ");
			Console.WriteLine("Set Path of folder containing tests: ");
			_folderpath = Console.ReadLine();
			do
			{
				Console.WriteLine("                --Inference Engine--                  ");
				string UserInput = Console.ReadLine();

				switch(UserInput)
				{
					case "Help":
						Console.WriteLine("-------------------HELP---------------------\n\n\n");
						Console.WriteLine("Commands:\n");
						Console.WriteLine("Input Data example: iengine method filename");
						Console.WriteLine("\n\n Problem Solving:\n");
						Console.WriteLine("1: Make Sure the ");
						Console.WriteLine("Exit the program: quit\n");

						    Console.Write("Press any key to close help menu: ");
						Console.ReadKey();
						break;

					case "quit": 
						quit = true;
						break;
						

				}



				string[] UserSelection = UserInput.Split(' ');



				ReadTextFile data = new ReadTextFile(_folderpath + UserSelection[2]);

				switch(UserSelection[1])
				{
					
					case "TT":
						TT Truthtable = new TT(data.Queries, data.AskVariable);
						break;
					case "FC":
						FC ForwardChaining = new FC(data.Queries, data.AskVariable);
						break;
					case "BC":
						BC BackWardChaining = new BC(data.Queries, data.AskVariable);
						break;

				}

			}while(quit == false);


		}


	}
}
