using System;
using System.Threading;
using System.Net.Http;

namespace ukol
{
	class program
	{
		static string ukol;
		static async Task Main()
		{
			string[] url = { "https://pointerpointer.com/", "https://hackertyper.com/", "https://longdogechallenge.com/" };
			Task<string> taska = StahniDataAsync(url[0], 0);
			Task<string> taskb = StahniDataAsync(url[1], 1);
			Task<string> taskc = StahniDataAsync(url[2], 2);
			await Task.WhenAll(taska, taskb, taskc);
			Console.WriteLine("hotovo"); 
		}

		static async Task<string> StahniDataAsync(string url, int h)
		{
			Console.WriteLine($"Ukol {h + 1} za chvíli bude");
				using HttpClient client = new HttpClient();
				string data = await client.GetStringAsync(url);
			Console.WriteLine($"Ukol {h + 1} uz je");
			return data;
			}
		}
	}