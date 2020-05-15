using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Command
    {
        public Method Method { get; }

        public string Name { get; }

        public Overload[] Overloads { get; }

        public Command(Method method, string name)
        {
            Method = method;
            Name = name;
        }

        public virtual bool IsHandleArb => false;

        public virtual Command CloneCommand(string newName)
        {
            return new Command(Method, newName);
        }
    }

    public class HandleARBCommand : Command
    {
        public Method Apple { get; }

        public Overload BaseOverload { get; }

        public HandleARBCommand(Method other, string name, Method apple, Overload baseOverload)
            : base(other, name)
        {
            Apple = apple;
            BaseOverload = baseOverload;
        }

        public override bool IsHandleArb => true;

        public override Command CloneCommand(string newName)
        {
            return new HandleARBCommand(Method, newName, Apple, BaseOverload);
        }
    }
}
