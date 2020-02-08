using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisApiServer
{
    public class ServerOption
    {        
        [Option("lobbyServerIP", Required = true, HelpText = "Lobby Server IP")]
        public string LobbyServerIP { get; set; }

        [Option("lobbyServerPort", Required = true, HelpText = "Lobby Server Port")]
        public UInt16 LobbyServerPort { get; set; }
    }
}
