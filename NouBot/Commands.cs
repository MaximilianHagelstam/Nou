using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Discord.Commands;
using NouBot;

namespace Noubot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        static HttpClient client = new HttpClient();

        [Command("test")]
        public async Task Test()
        {
            await ReplyAsync("Hello!");
        }

        [Command("message")]
        public async Task SendMessage(string body)
        {
            Message message = new Message(body, "James");

            HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:44333/message", message);

            Console.WriteLine(response);

            await ReplyAsync("Message sent succesfully");
        }
    }
}
