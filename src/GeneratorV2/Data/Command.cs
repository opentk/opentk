using System.Collections.Generic;
using System.Linq;

namespace GeneratorV2.Data
{
    public class Command
    {
        public Method Method { get; set; }

        public string Name { get; }

        public List<OverloadOld> Overloads { get; }

        public Command(Method method, string name, List<OverloadOld>? overloads = null)
        {
            Method = method;
            Name = name;
            Overloads = overloads ?? new List<OverloadOld>();
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

        public OverloadOld BaseOverload { get; }

        public HandleARBCommand(Method other, string name, Method apple, OverloadOld baseOverload, List<OverloadOld>? overloads = null)
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
        public readonly string EntryPoint;
        public readonly PType2 ReturnType;
        public GLParameter[] Parameters;

        public Command2(string entryPoint, PType2 returnType, GLParameter[] parameters)
        {
            EntryPoint = entryPoint;
            ReturnType = returnType;
            Parameters = parameters;
        }
    }
}
