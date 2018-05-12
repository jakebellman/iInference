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
		List<string> _variables = new List<string>();
		string _askvariable;


		public ReadTextFile(string textfile)
		{

			_tell = false;
			_ask = false;






			List<String> lines = File.ReadAllLines(@"{0}",textfile).ToList();

			foreach (var line in lines)
			{
				if(_tell == true)
				{

					string[] entries = line.Split(';');



					for(int i=0; i <= entries.Count();i++)
					{
						_queries.Add(entries[i]);
					}

					_tell = false;

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

