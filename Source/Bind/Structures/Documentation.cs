// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;

namespace Bind.Structures
{
    class Documentation
    {
        public string Summary { get; set; }
        public List<DocumentationParameter> Parameters { get; set; }
    }

    class DocumentationParameter
    {
        public string Name { get; set; }
        public string Documentation { get; set; }

        public DocumentationParameter(string name, string doc)
        {
            Name = name;
            Documentation = doc;
        }
    }
}

