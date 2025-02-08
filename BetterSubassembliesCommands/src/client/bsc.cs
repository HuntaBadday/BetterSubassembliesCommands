using LogicAPI.Client;
using LICC;

namespace BetterSubassembliesCommands.BetterSubassembliesCommands.src.client {
    public class BSC : ClientMod {
        [Command("savesub", Description = "Shortcut for Subassemblies.SaveCurrentSelection")]
        public static void savesub(string name) {
            CommandConsole.Current.RunCommand("Subassemblies.SaveCurrentSelection \"" + name + "\"");
        }
        
        [Command("addsub", Description = "Shortcut for Subassemblies.AddToHotbar")]
        public static void addsub(string id) {
            CommandConsole.Current.RunCommand("Subassemblies.AddToHotbar \"" + id + "\"");
        }
    }
}

