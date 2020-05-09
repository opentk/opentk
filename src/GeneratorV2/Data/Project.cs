using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Project
    {
        public Command[] Commands { get; }

        public Project(Command[] commands)
        {
            Commands = commands;
        }
    }
}
