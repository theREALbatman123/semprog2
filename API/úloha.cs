using System;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		using var httpClient = new HttpClient();

		while (true)
		{

			var response = await httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/EUR");
			var jsonData = await response.Content.ReadAsStringAsync();
			using JsonDocument doc = JsonDocument.Parse(jsonData);
			JsonElement obj = doc.RootElement;
			decimal hodnota1 = obj.GetProperty("rates").GetProperty("CZK").GetDecimal();
			decimal hodnota2 = obj.GetProperty("rates").GetProperty("EUR").GetDecimal();
			decimal hodnota3 = obj.GetProperty("rates").GetProperty("USD").GetDecimal();
			Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Získaná data:\n Euro: {hodnota2}\n Koruna česká: {hodnota1}\n Dolar: {hodnota3}");
			await Task.Delay(5000); // čekání 5 sekund
			Console.Clear();
		}
	}
}
