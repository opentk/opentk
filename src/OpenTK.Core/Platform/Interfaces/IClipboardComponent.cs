using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    // GOAL: We want to support unicode text, rich text and images.
    public interface IClipboardComponent : IPalComponent
    {
        void SetClipboardText(string text);

        string GetClipboardText();
    }
}
