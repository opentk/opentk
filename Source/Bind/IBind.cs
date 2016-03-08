// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using Bind.Structures;
using System.Collections.Generic;

namespace Bind
{
    interface IBind
    {
        DelegateCollection Delegates { get; }
        EnumCollection Enums { get; }
        FunctionCollection Wrappers { get; }
        Settings Settings { get; }

        IDictionary<string, string> GLTypes { get; }
        IDictionary<string, string> CSTypes { get; }

        void Process();
    }
}
