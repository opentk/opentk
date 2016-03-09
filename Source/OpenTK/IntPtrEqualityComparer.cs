// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.


using System;
using System.Collections.Generic;

namespace OpenTK
{
    // Simple equality comparer to allow IntPtrs as keys in dictionaries
    // without causing boxing/garbage generation.
    // Seriously, Microsoft, shouldn't this have been in the BCL out of the box?
    class IntPtrEqualityComparer : IEqualityComparer<IntPtr>
    {
        public bool Equals(IntPtr x, IntPtr y)
        {
            return x == y;
        }

        public int GetHashCode(IntPtr obj)
        {
            return obj.GetHashCode();
        }
    }
}

