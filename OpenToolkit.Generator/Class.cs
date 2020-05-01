using System.Text;

namespace OpenToolkit.Generator
{
    public struct Class
    {
        public string Name { get; }
        public IMethod[] Methods { get; }

        public Class(string ns, string name, IMethod[] methods)
        {
            Name = name;
            Methods = methods;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            var tab = "";
            void AppendLine(string str)
            {
                builder.Append(tab);
                builder.AppendLine(str);
            }
            void IncreaseTab()
            {
                AppendLine("{");
                tab += "\t";
            }
            void DecreaseTabbingTo(string t)
            {
                DecreaseTabbing(tab.Length - t.Length);
            }
            void DecreaseTabbing(int amount)
            {
                for (int i = 0; i < amount; i++)
                {
                    tab = tab.Remove(0, 1);
                    AppendLine("}");
                }
            }

            //Class declaration
            AppendLine($"public class {Name}");
            IncreaseTab();

            //Methods
            foreach (var m in Methods)
            {
                var method = m.ToString().Replace("\n", '\n' + tab);
                AppendLine(method);
            }

            //Closing tabs and curley brackets
            DecreaseTabbingTo("");
            return builder.ToString();
        }
    }
}
