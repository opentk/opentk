#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;

namespace OpenTK
{

    #region public class ContextExistsException : ApplicationException

    /// <summary>
    /// This exception is thrown when a GraphicsContext property cannot be changed after creation.
    /// </summary>
    public class ContextExistsException : ApplicationException
    {
        string msg;

        public ContextExistsException(string message)
        {
            msg = message;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }

    #endregion
}