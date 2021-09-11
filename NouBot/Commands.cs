using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Discord.Commands;

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
        public async Task SendMessage(string message)
        {
            await client.PostAsJsonAsync("https://localhost:44333/message", new { Body = message, User = "James" });

            await ReplyAsync("Message sent succesfully");
        }
    }
}
