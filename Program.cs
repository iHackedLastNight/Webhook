using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string webhookUrl = "https://discord.com/api/webhooks/1259507523720052819/F5U50YMBPWxw5jx-lN-r0JNSW1DfHrFM2cfs4w5vVdu30nx7jzkeHoBcYF-yakYK59kz";

        string jsonPayload = "{\"content\": \"**Hey Babe I'm L0rHacker C# Webhook Sender !**\"}";

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
