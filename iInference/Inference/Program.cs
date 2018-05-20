using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Inference
{
	
	class MainClass
	{
		

		public static void Main(string[] args)
		{
			
			 

			bool _quit;
			string _folderpath;

			_quit = false;
			Console.WriteLine("                --Inference Engine--                 \n ");
			Console.Write("Set Path of folder containing tests: ");
            _folderpath = @"C:\Users\Archie\Desktop\Testdoc\";
                 //Console.ReadLine();
            do
            {
                Console.WriteLine("                --Inference Engine--                  ");
                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "help":
                        Console.WriteLine("-------------------HELP---------------------\n\n\n");
                        Console.WriteLine("Commands:\n");
                        Console.WriteLine("Input Data example: iengine method filename");
                        Console.WriteLine("\n\n Problem Solving:\n");
                        Console.WriteLine("1: Make Sure the correct file name is input");
                        Console.WriteLine("Exit the program: quit\n");

                        Console.Write("Press any key to close help menu: ");
                        Console.ReadKey();
                        break;

                    case "quit":
                        _quit = true;
                        break;


                }



               string[] UserSelection = UserInput.Split(' ');

                if (UserSelection.Length == 2)
                {
                    string curFile = _folderpath + UserSelection[1];
                    Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");

                    if (File.Exists(curFile))
                    {

                        ReadTextFile data = new ReadTextFile(_folderpath + UserSelection[1]);

                        switch (UserSelection[0])
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
                    }
                }
                else

                {
                    Console.WriteLine("Too many inputs for testing, Use format 'TT Test.txt'");
                }
			}  while(_quit == false);

			
		}


	}
}
