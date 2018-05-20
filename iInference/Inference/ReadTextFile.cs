using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inference
{
	
	
	public class ReadTextFile
	{
		bool _tell;
		bool _ask;
		List<string> _queries = new List<string>();
		List<Variable> _variables = new List<Variable>();
		string _askvariable;


		public ReadTextFile(string textfile)
		{

			_tell = false;
			_ask = false;






			List<String> lines = File.ReadAllLines(textfile).ToList(); // read text file to list of strings

			foreach (var line in lines)
			{
				if(_tell == true)
				{
					string[] entries = line.Split(';'); // splits txt file into new strings when it encounters a semi colen

					for(int i=0; i <= entries.Count() - 1;i++)
					{
						_queries.Add(entries[i].Replace(" ", String.Empty)); // Removes all spaces from text entries.
                    }

                    foreach (string s in _queries)
                    {
                        if (!s.Contains("&&") && !s.Contains("=>")) // adding logically true variables to list 
                        {
                            if(!_variables.Contains(s))
                            {
                                Variable newVar = new Variable();
                                newVar.Logicaltrue = true; // making var logically true
                                newVar.Name = s; // adding variable name
                                _variables.Add(s); // adding variable to list 
                            }
                        }

                    }


					_tell = false;
                
                    foreach(string s in _queries)
                    {
                        Console.WriteLine(s);
             
                    }
                    Console.ReadKey();

				}

				if(_ask == true)
				{

					_askvariable = line;

					_ask = false;
				}


				if(line == "TELL")
				{
					_tell = true;
				}

				if(line == "ASK")
				{
					_ask = true;
				}


			}

		}

		public List<string> Queries
		{
				get
				{
					return _queries;
				}

				set
				{
					_queries = value;
				}
		}

		public string AskVariable
		{
			get
			{
				return _askvariable;
			}

			set
			{
				_askvariable = value;
			}
		}

	}	


			
				

	}

