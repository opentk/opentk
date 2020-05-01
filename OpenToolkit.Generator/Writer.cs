using System.IO;
using System.Text;

namespace OpenToolkit.Generator
{
    public static class Writer
    {
        public static void Write(Class c)
        {
            Logger.Info("Beginning to write files.");

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

            //Namespace
            AppendLine($"namespace {c.Namespace}");
            IncreaseTab();

            //Class declaration
            AppendLine($"public class {c.Name}");
            IncreaseTab();

            //Methods
            foreach (var m in c.Methods)
            {
                var parameters = "";
                for (int i = 0; i < m.Parameters.Length; i++)
                {
                    var spacing = i == m.Parameters.Length - 1 ? "" : ", ";
                    parameters += $"{m.Parameters[i].Type} {m.Parameters[i].Name}{spacing}";
                }
                AppendLine($"public {m.ReturnType} {m.Name}({parameters})");
                //Body
                var preMTab = tab;
                IncreaseTab();

                foreach (var str in m.Body)
                {
                    if (str == "{")
                    {
                        IncreaseTab();
                    }
                    else if (str == "}")
                    {
                        DecreaseTabbing(1);
                    }
                    else
                    {
                        AppendLine(str);
                    }
                }

                DecreaseTabbingTo(preMTab);
                AppendLine("");
            }

            //Closing tabs and curley brackets
            DecreaseTabbingTo("");

            File.WriteAllText("GL.cs", builder.ToString());
        }
    }
}
