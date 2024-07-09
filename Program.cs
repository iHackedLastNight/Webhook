using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Webhook
{
    static async Task Main(string[] args)
    {
        // your Webhook Here
        string webhookUrl = "";
        // your Message
        string jsonPayload = "{\"content\": \"**l0rl0rl0rl0rl0rl0r**\"}";

        using (HttpClient client = new HttpClient())
        {

            while (true)
            {
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(webhookUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Message sent successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to send message. Status code: {response.StatusCode}");
                }; 
            }
        }
    }
}
