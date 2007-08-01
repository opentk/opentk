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
    public class Function : Delegate
    {
        internal static FunctionCollection Wrappers;

        private static bool loaded;
        internal static void Initialize()
        {
            if (!loaded)
            {
                Wrappers = new FunctionCollection();
                loaded = true;
            }
        }

        private static List<string> endings = new List<string>(
            new string[]
            {
                "fv",
                "f",
                "dv",
                "d",
                "i",
                "iv",
                "s",
                "sv",
                "b",
                "bv",
                "ui",
                "uiv",
                "us",
                "usv",
                "ub",
                "ubv"
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
                if (Settings.Compatibility != Settings.Legacy.Tao)
                {
                    string ext = Utilities.GetGL2Extension(value);
                    string trimmedName = value;

                    // Remove extension
                    if (!String.IsNullOrEmpty(ext))
                    {
                        trimmedName = trimmedName.Substring(0, trimmedName.Length - ext.Length);
                    }

                    // Remove overload
                    if (endings.Contains(trimmedName.Substring(trimmedName.Length - 3)))
                    {
                        TrimmedName = trimmedName.Substring(0, trimmedName.Length - 3);
                        return;
                    }

                    if (endings.Contains(trimmedName.Substring(trimmedName.Length - 2)))
                    {
                        TrimmedName = trimmedName.Substring(0, trimmedName.Length - 2);
                        return;
                    }

                    if (endings.Contains(trimmedName.Substring(trimmedName.Length - 1)))
                    {
                        // An ending 's' may be either a plural form (glCallLists), which we
                        // do not want to change, or an actual overload (glColor3s). We assume
                        // (perhaps incorrectly), that an 's' preceeded be a digit indicates an
                        // overload. If there is no digit, we assume a plural form (no change).
                        if (Char.IsDigit(trimmedName[trimmedName.Length - 2]))
                            TrimmedName = trimmedName.Substring(0, trimmedName.Length - 1);
                        return;
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
                sb.Append("gl");
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

        #region public Function GetCLSCompliantFunction(Dictionary<string, string> CSTypes)

        public Function GetCLSCompliantFunction()
        {
            Function f = new Function(this);

            bool somethingChanged = false;
            for (int i = 0; i < f.Parameters.Count; i++)
            {
                f.Parameters[i].CurrentType = f.Parameters[i].GetCLSCompliantType();
                if (f.Parameters[i].CurrentType != this.Parameters[i].CurrentType)
                    somethingChanged = true;
            }

            if (!somethingChanged)
                return null;

            f.Body.Clear();
            if (!f.NeedsWrapper)
            {
                f.Body.Add((f.ReturnType.CurrentType != "void" ? "return " + this.CallString() : this.CallString()) + ";");
            }
            else
            {
                f.Body.AddRange(this.GetBodyWithPins(true));
            }

            // The type system cannot differentiate between functions with the same parameters
            // but different return types. Tough, only CLS-Compliant function in that case.
            //f.ReturnType.Type = f.ReturnType.GetCLSCompliantType(CSTypes);

            return f;
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
            bool exists = false;
            if (Bind.Structures.Function.Wrappers.ContainsKey(f.Extension))
            {
                Function fun = Bind.Structures.Function.Wrappers[f.Extension]
                    .Find(delegate(Function target)
                        {
                            return
                                !String.IsNullOrEmpty(target.TrimmedName) &&
                                target.TrimmedName == f.TrimmedName &&
                                target.Parameters.ToString(true) == f.Parameters.ToString(true);
                        });
                if (fun != null)
                {
                    exists = true;
                    /*Debug.WriteLine("Function redefinition:");
                    Debug.WriteLine(fun.ToString());
                    Debug.WriteLine(f.ToString());*/
                }
            }

            if (!exists)
                Bind.Structures.Function.Wrappers.Add(f);
        }
    }

    #endregion
}
