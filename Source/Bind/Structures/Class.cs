#region License
//
// Class.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace Bind.Structures
{
    class Class : IComparable<Class>, IEquatable<Class>
    {
        public Class()
        {
            Fields = new FieldCollection();
            Methods = new FunctionCollection();
        }

        public string Name { get; set; }
        public FieldCollection Fields { get; private set; }
        public FunctionCollection Methods { get; private set; }

        #region IComparable implementation

        public int CompareTo(Class other)
        {
            return Name.CompareTo(other.Name);
        }

        #endregion

        #region IEquatable implementation

        public bool Equals(Class other)
        {
            return Name.Equals(other.Name);
        }

        #endregion
    }

    class ClassCollection : GenericCollection<Class>
    {
        public override void Add(Class item)
        {
            if (!Collection.ContainsKey(item.Name))
            {
                Add(item.Name, new List<Class>());
                Collection[item.Name].Add(item);
            }
            else
            {
                foreach (var m in item.Methods.Values.SelectMany(m => m))
                {
                    Collection[item.Name][0].Methods.AddChecked(m);
                }
            }
        }
    }
}

