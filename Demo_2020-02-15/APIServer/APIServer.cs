﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisApiServer
{
    public class APIServer
    {
        public static ServerOption ServerOpt;

        static public void Init(string[] args)
        {
            ServerOpt = (CommandLine.Parser.Default.ParseArguments<ServerOption>(args) as CommandLine.Parsed<ServerOption>).Value;
        }
    }
}
