﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] argument = args.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string commandName = argument[0];
            string[] commandArgs = argument.Skip(1).ToArray();

            Type commandType = Assembly.GetEntryAssembly().GetTypes()
                .FirstOrDefault(t=>t.Name == $"{commandName}Command");



            ICommand commandInstance = Activator.CreateInstance(commandType) as ICommand;
            string result = commandInstance.Execute(commandArgs);
            return result;
        }
    }
}
