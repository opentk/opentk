using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    public class PlatformSpecific
    {
        public static PlatformSpecific CreatePlatformMethods()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                    Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                return new WindowsPlatform();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                return new X11Platform();
            }
            else
            {
                // return an object which implements the base methods, using "safe" .net fallback routines.
                return new PlatformSpecific();

                //throw new PlatformNotSupportedException("The platform on which you are trying to run this program is not currently supported. Sorry for the inconvenience.");
            }
        }

        protected PlatformSpecific()
        {
        }

        public virtual bool IsIdle()
        {
            return false;
        }

        public virtual bool ProcessEvents()
        {
            return false;
        }
    }
}
