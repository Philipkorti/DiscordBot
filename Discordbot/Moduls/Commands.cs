using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Discordbot.Moduls
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong");
        }
        [Command("Jannek")]
        public async Task Jannek()
        {
             await ReplyAsync("Jannek du stinkst!!!!!!");
        }
        [Command("Philip")]
        public async Task Philip()
        {
            await ReplyAsync("Jannek wollen wir ow spielen");
        }

    }
}
