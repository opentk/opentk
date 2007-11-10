#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
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
        public readonly string Title;
        public readonly ExampleCategory Category;
        public readonly int Order;

        public ExampleAttribute(string title, ExampleCategory category, int order)
        {
            this.Title = title;
            this.Category = category;
            this.Order = order;
        }
    }

    public enum ExampleCategory
    {
        OpenGL,
        OpenAL,
        OpenTK,
        GLSL,
        WinForms,
        Test,
    }
}
