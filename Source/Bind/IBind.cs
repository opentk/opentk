#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

namespace Bind
{
    interface IBind : ISpecReader, ISpecWriter
    {
        void Process();
    }
}
