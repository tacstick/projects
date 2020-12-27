using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using System.Threading.Tasks;

namespace cs
{

    public class Bot
    {
        public DiscordClient client { get; private set; }
        public CommandsNextModule commands{ get; private set; }

        public async Task RunAsync()
        {
            var config = new DiscordConfiguration
            {

            };

            client = new DiscordClient(config);

            client.Ready += OnBoot;

            var commandsConfig = new CommandsNextConfiguration{};
            commands = client.UseCommandsNext(commandsConfig);

            await client.ConnectAsync();

            await Task.Delay(1);
        }
        
        private Task OnBoot(ReadyEventArgs e)
        {
            return null;
        }

    }

}
