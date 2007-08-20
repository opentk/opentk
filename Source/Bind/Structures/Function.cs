#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Bind.Structures
{
    public class Function : Delegate, IEquatable<Function>
    {
        internal static FunctionCollection Wrappers;

        private static bool loaded;
        
        #region internal static void Initialize()
        
        internal static void Initialize()
        {
            if (!loaded)
            {
                Wrappers = new FunctionCollection();
                loaded = true;
            }
        }
        
        #endregion

        Regex functionsNotToTrim = new Regex(@"(Coord1|Attrib(I?)1(u?)|Stream1|Uniform2(u?))[dfis]v");
        
        //Regex endings = new Regex(@"(.)+[df(u?[isb])]v?");
        
        private static List<string> endings = new List<string>(
            new string[]
            {
                "fv", "f",
                "dv", "d",
                "i",  "iv",
                "s",  "sv",
                "b",  "bv",
                "ui", "uiv",
                "us", "usv",
                "ub", "ubv"
            });

        #region --- Constructors ---

        public Function()
            : base()
        {
            Body = new FunctionBody();
        }
        /*
        public Function(Function f)
            : base(f)
        {
            this.Body = new FunctionBody(f.Body);
            this.Name = f.Name;
        }
        */
        public Function(Delegate d)
            : base(d)
        {
            if (d is Function)
                this.Body = new FunctionBody((d as Function).Body);
            else
                this.Body = new FunctionBody();
            this.Name = d.Name;
        }

        #endregion

        #region public override bool Unsafe

        public override bool Unsafe
        {
            get
            {
                if (Settings.Compatibility == Settings.Legacy.Tao)
                    return false;

                return base.Unsafe;
            }
        }

        #endregion

        #region public FunctionBody Body

        FunctionBody _body;

        public FunctionBody Body
        {
            get { return _body; }
            set { _body = value; }
        }

        #endregion

        #region public string TrimmedName

        string trimmedName;
        /// <summary>
        /// Gets or sets the name of the opengl function, trimming the excess 234dfubsiv endings.
        /// </summary>
        public string TrimmedName
        {
            get { return trimmedName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    trimmedName = value.Trim();
            }
        }

        #endregion

        #region public override string Name

        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// If no Tao compatibility is set, set TrimmedName to Name, after removing
        /// [u][bsifd][v].
        /// </summary>
        public override string Name
        {
            get { return base.Name; }
            set
            {
                base.Name = value;

                // If we don't need compatibility with Tao,
                // remove the Extension and the overload information from the name
                // (Extension == "ARB", "EXT", etc, overload == [u][bsidf][v])
                // TODO: Use some regex's here, to reduce clutter.
                TrimmedName = value;

                if (Settings.Compatibility == Settings.Legacy.Tao)
                {
                }
                else
                {
                    TrimmedName = Utilities.StripGL2Extension(value);
                    
                    //if (TrimmedName.Contains("Uniform2iv"))
                    {
                    	//Console.Write("niar");
                    }

                    // Remove overload
                    for (int i = 3; i >= 1; i--)
                    {
		                if (endings.Contains(TrimmedName.Substring(TrimmedName.Length - i)))
		                {
		                	// If there is a digit before the ending (e.g. 3fv) then we will remove
		                	// the ending (some functions are blacklisted for CLS-Compliance).
		                	// Otherwise, if there is no digit, but it ends with a 'v', do not remove
		                	// the 'v' (CLS-Compliance). If no digit and it ends with a (plural) 's',
		                	// do not remove anything (e.g. glCallLists)
		                	// TODO: Add better handling for CLS-Compliance on ref ('v') functions.
		                	if (Char.IsDigit(TrimmedName[TrimmedName.Length - (i + 1)]))
		                	{
	                	    	if (!functionsNotToTrim.IsMatch(Name))
	                	    	{
		                    		TrimmedName = TrimmedName.Substring(0, TrimmedName.Length - i);	
	                	    	}
	                	    	else
	                	    	{
	                	    		Console.WriteLine("Function {0} blacklisted from trimming (CLS-Compliance).", Name);
	                	    	}
		                	}
		                	else if (TrimmedName.EndsWith("v"))
		                	{
		                        TrimmedName = TrimmedName.Substring(0, TrimmedName.Length - i) + "v";
		                	}
		                    return;
		                }
                    }
                }
            }
        }

        #endregion

        #region public override string ToString()

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                sb.Append(Settings.FunctionPrefix);
            }
            sb.Append(!String.IsNullOrEmpty(TrimmedName) ? TrimmedName : Name);
            sb.Append(Parameters.ToString(true));
            if (Body.Count > 0)
            {
                sb.AppendLine();
                sb.Append(Body.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region IEquatable<Function> Members

        public bool Equals(Function other)
        {
            return !String.IsNullOrEmpty(this.TrimmedName) && !String.IsNullOrEmpty(other.TrimmedName) &&
                this.TrimmedName == other.TrimmedName &&
                this.Parameters.ToString(true) == other.Parameters.ToString(true);
        }

        #endregion
    }

    #region class FunctionBody : List<string>

    public class FunctionBody : List<string>
    {
        public FunctionBody()
        {
        }

        public FunctionBody(FunctionBody fb)
        {
            foreach (string s in fb)
            {
                this.Add(s);
            }
        }

        private string indent = "";

        public void Indent()
        {
            indent += "    ";
        }

        public void Unindent()
        {
            if (indent.Length >= 4)
                indent = indent.Substring(4);
        }

        new public void Add(string s)
        {
            base.Add(indent + s);
        }

        new public void AddRange(IEnumerable<string> collection)
        {
            foreach (string t in collection)
            {
                this.Add(t);
            }
        }

        public override string ToString()
        {
            if (this.Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(this.Count);

            sb.AppendLine("{");
            foreach (string s in this)
            {
                sb.AppendLine("    " + s);
            }
            sb.AppendLine("}");

            return sb.ToString();
        }
    }

    #endregion

    #region class FunctionCollection : Dictionary<string, List<Function>>

    class FunctionCollection : Dictionary<string, List<Function>>
    {
        Regex unsignedFunctions = new Regex(@".+(u[dfisb]v?)", RegexOptions.Compiled);

        public void Add(Function f)
        {
            if (!this.ContainsKey(f.Extension))
            {
                this.Add(f.Extension, new List<Function>());
                this[f.Extension].Add(f);
            }
            else
            {
                this[f.Extension].Add(f);
            }
        }

        public void AddRange(IEnumerable<Function> functions)
        {
            foreach (Function f in functions)
            {
                this.Add(f);
            }
        }

        /// <summary>
        /// Adds the function to the collection, if a function with the same
        /// name and parameters doesn't already exist.
        /// </summary>
        /// <param name="f">The Function to add.</param>
        public void AddChecked(Function f)
        {
            if (Bind.Structures.Function.Wrappers.ContainsKey(f.Extension))
            {
                int index = Bind.Structures.Function.Wrappers[f.Extension].IndexOf(f);
                if (index == -1)
                {
                    Bind.Structures.Function.Wrappers.Add(f);
                }
                else
                {
                    if (unsignedFunctions.IsMatch(Utilities.StripGL2Extension(f.Name)))// &&
                        //!unsignedFunctions.IsMatch(
                        //    Utilities.StripGL2Extension(Bind.Structures.Function.Wrappers[f.Extension][index].Name)))
                    {
                        Bind.Structures.Function.Wrappers[f.Extension].RemoveAt(index);
                        Bind.Structures.Function.Wrappers[f.Extension].Add(f);
                    }
                }
            }
            else
            {
                Bind.Structures.Function.Wrappers.Add(f);
            }
        }
    }

    #endregion
}
