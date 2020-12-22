using GeneratorV2.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Writing
{
    public class ProjectNode : WriterNode
    {
        private readonly string _rootNamespace;

        public ProjectNode(string rootNamespace)
        {
            _rootNamespace = rootNamespace;
        }

        public override void Write()
        {
            Writer.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            //using (IndentationExtension.Indentation(Writer))
            {
                Writer.WriteLine("<PropertyGroup>");
                    
                //using (IndentationExtension.Indentation(Writer))
                {
                    Writer.WriteLine("<TargetFramework>net5.0</TargetFramework>");
                    Writer.WriteLine("<Nullable>enable</Nullable>");
                    Writer.WriteLine($"<RootNamespace>{_rootNamespace}</RootNamespace>");
                    Writer.WriteLine("<AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
                    Writer.WriteLine("<PackageVersion>5.0.0-pre0.0</PackageVersion>");
                    Writer.WriteLine("<Version>5.0.0</Version>");
                }

                Writer.WriteLine("</PropertyGroup>");

                Writer.WriteLine("<ItemGroup>");

                //using (IndentationExtension.Indentation(Writer))
                {
                    Writer.WriteLine("<ProjectReference Include=\"../OpenToolkit.Core/OpenToolkit.Core.csproj\" />");
                    Writer.WriteLine("<ProjectReference Include=\"../OpenToolkit.Mathematics/OpenToolkit.Mathematics.csproj\" />");
                }

                Writer.WriteLine("</ItemGroup>");
            }
            Writer.WriteLine("</Project>");
        }
    }
}
