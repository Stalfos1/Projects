using System;

namespace Blog.API.Consumer
{
	public static class Crud<T>
	{

		public static T[] GetAll(string apiUrl)
		{
			using (var webClient = new System.Net.WebClient())
			{
				webClient.Headers.Add("Content-Type", "application/json");
				var json = webClient.DownloadString(apiUrl);
				//...
				//Intalar este paquete en Empresa.API.Consumer -> Install-Package Newtonsoft.Json -ProjectName empresa.api.consumer
				//...
				var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T[]>(json);
				return data;

			}
		}

		public static T GetOne(string apiUrl)
		{
			using (var webClient = new System.Net.WebClient())
			{
				webClient.Headers.Add("Content-Type", "application/json");
				var json = webClient.DownloadString(apiUrl);
				var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
				return data;

			}
		}


		public static void Insert(string apiUrl, T data)
		{
			using (var webClient = new System.Net.WebClient())
			{
				webClient.Headers.Add("Content-Type", "application/json");
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
				webClient.UploadString(apiUrl, "POST", json);
			}
		}


		public static void Update(string apiUrl, T data)
		{
			using (var webClient = new System.Net.WebClient())
			{
				webClient.Headers.Add("Content-Type", "application/json");
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
				webClient.UploadString(apiUrl, "PUT", json);
			}
		}

		public static void Delete(string apiUrl)
		{
			using (var webClient = new System.Net.WebClient())
			{
				webClient.Headers.Add("Content-Type", "application/json");
				webClient.UploadString(apiUrl, "DELETE", "");
			}
		}


	}
}
