using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace Noubot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task Test()
        {
            await ReplyAsync("Hello!");
        }
    }
}
