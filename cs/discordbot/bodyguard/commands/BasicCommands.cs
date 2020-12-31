using System;
using DSharpPlus.CommandsNext;
using DSharpPlus;
using DSharpPlus.Interactivity;
using DSharpPlus.CommandsNext.Attributes;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using DSharpPlus.Entities;
using System.Diagnostics;

namespace overlord
{
    public class Commands : BaseCommandModule
    {
        //needed stuff for commands

        [Command("ping")]
        public async Task pingus(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("pongeame esta").ConfigureAwait(false);
        }

        [Command("rtd")]
        [Description("hacer un dado de tantos lados")]
        public async Task rtd(CommandContext ctx,[Description("cantidad de lados")] int sides)
        {
            Random rnd = new Random();
            int rolled = rnd.Next(1, sides);
            await ctx.Channel.SendMessageAsync("sacaste " + rolled).ConfigureAwait(false);
        }
        [Command("quesoy")]
        public async Task quesoy(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("todavia no terminado").ConfigureAwait(false);
        }
        [Command("nick")]
        [Description("poner un nickname")]
        public async Task nick(CommandContext ctx, string name)
        {
                await ctx.Member.ModifyAsync(x =>
                {
                    x.Nickname = name;
                }).ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("nick changed to " + name);
        }
        [Command("homedefense")]
        [Description("a copypasta")]
        public async Task musketforhomedefense(CommandContext ctx)
        {

            var embed = new DiscordEmbedBuilder
            {
                Title = "Own a musket for home defense",
                Description =  @"Own a musket for home defense, since that's what the founding fathers intended. Four ruffians break into my house. ""What the devil?"" As I grab my powdered wig and Kentucky rifle. Blow a golf ball sized hole through the first man, he's dead on the spot. Draw my pistol on the second man, miss him entirely because it's smoothbore and nails the neighbors dog. I have to resort to the cannon mounted at the top of the stairs loaded with grape shot, ""Tally ho lads"" the grape shot shreds two men in the blast, the sound and extra shrapnel set off car alarms. Fix bayonet and charge the last terrified rapscallion. He Bleeds out waiting on the police to arrive since triangular bayonet wounds are impossible to stitch up. Just as the founding fathers intended.",
            };
            await ctx.Channel.SendMessageAsync(embed: embed).ConfigureAwait(false);
        }


    }

}