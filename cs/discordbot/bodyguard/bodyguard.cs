using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace bodyguardns
{

    public class Bodyguard
    {
        public DiscordClient client { get; private set; }
        public CommandsNextExtension commands{ get; private set; }

        public async Task RunAsync()
        {
            var json = string.Empty;

            using(var fs = File.OpenRead("/home/tomas/projects/cs/discordbot/bodyguard/config.json"))
            using(var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            var jsonConfig = JsonConvert.DeserializeObject<ConfigJson>(json);

            var config = new DiscordConfiguration
            {
                Token = jsonConfig.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
            };

            client = new DiscordClient(config);

            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { jsonConfig.prefix },
                EnableMentionPrefix = true,
                EnableDms = false,
                IgnoreExtraArguments = true
            };
            commands = client.UseCommandsNext(commandsConfig);

            commands.RegisterCommands<Commands>();

            await client.ConnectAsync();

            

            await Task.Delay(-1);

        }
        
        public Task OnClientReady(ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }

    }

}
