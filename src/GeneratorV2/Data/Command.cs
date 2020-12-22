using System.Collections.Generic;
using System.Linq;

namespace GeneratorV2.Data
{
    public class Command
    {
        public Method Method { get; set; }

        public string Name { get; }

        public List<Overload> Overloads { get; }

        public Command(Method method, string name, List<Overload>? overloads = null)
        {
            Method = method;
            Name = name;
            Overloads = overloads ?? new List<Overload>();
        }

        public virtual bool IsHandleArb => false;

        public virtual Command CloneCommand(string newName)
        {
            var clonedCommand = new Command(Method, newName, Overloads.ToList());
            return clonedCommand;
        }
    }

    public class HandleARBCommand : Command
    {
        public Method Apple { get; }

        public Overload BaseOverload { get; }

        public HandleARBCommand(Method other, string name, Method apple, Overload baseOverload, List<Overload>? overloads = null)
            : base(other, name, overloads)
        {
            Apple = apple;
            BaseOverload = baseOverload;
        }

        public override bool IsHandleArb => true;

        public override Command CloneCommand(string newName)
        {
            return new HandleARBCommand(Method, newName, Apple, BaseOverload, Overloads);
        }
    }

    public class Command2
    {
        public readonly GLMethod Method;

        public readonly string Name;

        //public List<Overload> Overloads { get; }

        public Command2(GLMethod method, string name)
        {
            Method = method;
            Name = name;
        }
    }
}
