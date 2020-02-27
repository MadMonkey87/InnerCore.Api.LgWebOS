using System;
using System.Threading.Tasks;

namespace InnerCore.Api.LgWebOS.Sample
{
	public class Program
	{
		public async static Task Main(string[] args)
		{
			var client = new WebOSClient("192.168.50.70", 3000);

			Console.ReadLine();
		}
	}
}
