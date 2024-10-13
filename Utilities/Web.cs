using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Discord_Channel_Importer.Utilities
{
	internal static class Web
	{
		/// <summary>
		/// Gets and returns all the text from the specified webpage
		/// </summary>
		public static async Task<string> GetTextFromUriAsync(Uri uri)
		{
			using var client = new HttpClient();
			return await client.GetStringAsync(uri);
		}
	}
}
