using Business.IBusiness;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class Authentication : IAuthentication
    {
        public async Task<bool> AuthenticateAsync()
        {
            string apiUrl = "https://localhost:7099/api/Authenticate/Login";

            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Create an object with the data you want to send
                    var data = new
                    {
                        username = "Vibhavg",
                        password = "Test@1234"
                    };

                    // Serialize the data object to JSON
                    string jsonData = JsonConvert.SerializeObject(data);

                    // Create a StringContent object with the JSON data
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Send a POST request to the API endpoint with the JSON data
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Check if the request was successful (status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Get the response content
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + responseContent);
                        return true;
                    }
                    else
                    {
                        // If the request failed, print the status code
                        Console.WriteLine("Error: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    // If an exception occurred, print the error message
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return false;
            }
        }
    }
}
