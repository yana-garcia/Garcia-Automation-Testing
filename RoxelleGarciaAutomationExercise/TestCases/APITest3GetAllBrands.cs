using  Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;



namespace RoxelleGarciaAutomationExercise.TestCases
{
    class APITest3GetAllBrands
    {
        public void Main(string[] args)
        {
            RestClient client = new RestClient("https://automationexercise.com");
            RestRequest request = new RestRequest("/api/brandsList", Method.Get);

            RestResponse response = client.Get(request);

            if (response.IsSuccessful)
            {
                List<string> brands = JsonConvert.DeserializeObject<List<string>>(response.Content);

                foreach (string brand in brands)
                {
                    Console.WriteLine(brand);
                }
            }
            else
            {
                Console.WriteLine($"Request failed with status code: {response.StatusCode}");
            }
        }
    }
}