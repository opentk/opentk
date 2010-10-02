#region --- License ---
/* Copyright (c) 2006-2008 the OpenTK team
 * See license.txt for licensing details
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExampleAttribute : System.Attribute
    {
        string title;
        bool visible = true;
        public string Title { get { return title; } internal set { title = value; } }
        public readonly ExampleCategory Category;
        public readonly string Subcategory;
        public int Difficulty;
        public string Documentation;
        public bool Visible { get { return visible; } set { visible = value; } }

        public ExampleAttribute(string title, ExampleCategory category, string subcategory)
            : this(title, category, subcategory, Int32.MaxValue, true) { }

        public ExampleAttribute(string title, ExampleCategory category, string subcategory, int difficulty)
            : this(title, category, subcategory, difficulty, true) { }

        public ExampleAttribute(string title, ExampleCategory category, string subcategory, bool visible)
            : this(title, category, subcategory, Int32.MaxValue, visible) { }

        public ExampleAttribute(string title, ExampleCategory category, string subcategory, int difficulty, bool visible)
        {
            this.Title = title;
            this.Category = category;
            this.Subcategory = subcategory;
            this.Difficulty = difficulty;
            this.Visible = visible;
        }

        public override string ToString()
        {
            if (Difficulty != 0)
                return String.Format("{0} {1}: {2}", Category, Difficulty, Title);
            return String.Format("{0}: {1}", Category, Title);
        }
    }

    public enum ExampleCategory
    {
        OpenTK = 0,
        OpenGL,
        OpenAL,
        OpenCL,
        OpenGLES
    }
}
