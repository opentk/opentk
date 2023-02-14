using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public enum XError : byte
    {
        /// <summary>
        /// No error.
        /// </summary>
        Success = 0,

        /// <summary>
        /// The major or minor opcode does not specify a valid request.
        /// This usually is an Xlib or server error.
        /// </summary>
        BadRequest = 1,

        /// <summary>
        /// <para>
        /// A client attempts to grab a key/button combination already grabbed by another client.
        /// </para>
        /// <para>
        /// A client attempts to free a colormap entry that it had not already allocated or to free
        /// an entry in a colormap that was created with all entries writable.
        /// </para>
        /// <para>
        /// A client attempts to store into a read-only or unallocated colormap entry.
        /// </para>
        /// <para>
        /// A client attempts to modify the access control list from other than the local (or otherwise authorized) host.
        /// </para>
        /// <para>
        /// A client attempts to select an event type that another client has already selected.
        /// </para>
        /// </summary>
        BadAccess = 10,

        /// <summary>
        /// The server fails to allocate the requested resource.
        /// Note that the explicit listing of BadAlloc errors in requests only covers allocation errors at
        /// a very coarse level and is not intended to (nor can it in practice hope to)
        /// cover all cases of a server running out of allocation space in the middle of service.
        /// The semantics when a server runs out of allocation space are left unspecified,
        /// but a server may generate a BadAlloc error on any request for this reason,
        /// and clients should be prepared to receive such errors and handle or discard them.
        /// </summary>
        BadAlloc = 11,

        /// <summary>
        /// A value for a colormap argument does not name a defined colormap.
        /// </summary>
        BadColor = 12,

        /// <summary>
        /// A value for a GContext argument does not name a defined GContext.
        /// </summary>
        BadGC = 13,

        /// <summary>
        /// The value chosen for a resource identifier either is not included
        /// in the range assigned to the client or is already in use.
        /// Under normal circumstances,
        /// this cannot occur and should be considered a server or Xlib error.
        /// </summary>
        BadIDChoice = 14,

        /// <summary>
        /// A font or color of the specified name does not exist.
        /// </summary>
        BadName = 15,

        /// <summary>
        /// <para>
        /// The length of a request is shorter or longer than that required to contain the arguments.
        /// This is an internal Xlib or server error.
        /// </para>
        /// <para>
        /// The length of a request exceeds the maximum length accepted by the server.
        /// </para>
        /// </summary>
        BadLength = 16,

        /// <summary>
        /// The server does not implement some aspect of the request.
        /// A server that generates this error for a core request is deficient.
        /// As such, this error is not listed for any of the requests,
        /// but clients should be prepared to receive such errors and handle or discard them.
        /// </summary>
        BadImplementation = 17,

        /// <summary>
        /// Some numeric value falls outside of the range of values accepted by the request.
        /// Unless a specific range is specified for an argument,
        /// the full range defined by the argument's type is accepted.
        /// Any argument defined as a set of alternatives typically can generate this error (due to the encoding).
        /// </summary>
        BadValue = 2,

        /// <summary>
        /// A value for a window argument does not name a defined window.
        /// </summary>
        BadWindow = 3,

        /// <summary>
        /// A value for a pixmap argument does not name a defined pixmap.
        /// </summary>
        BadPixmap = 4,

        /// <summary>
        /// A value for an atom argument does not name a defined atom.
        /// </summary>
        BadAtom = 5,

        /// <summary>
        /// A value for a cursor argument does not name a defined cursor.
        /// </summary>
        BadCursor = 6,

        /// <summary>
        /// A value for a font argument does not name a defined font (or, in some cases, GContext).
        /// </summary>
        BadFont = 7,

        /// <summary>
        /// <para>
        /// In a graphics request, the root and depth of the graphics context does not match that of the drawable.
        /// </para>
        /// <para>
        /// An InputOnly window is used as a drawable.
        /// </para>
        /// <para>
        /// Some argument or pair of arguments has the correct type and range, but it fails to match in some other way required by the request.
        /// </para>
        /// <para>
        /// An InputOnly window lacks this attribute.
        /// </para>
        /// </summary>
        BadMatch = 8,

        /// <summary>
        /// A value for a drawable argument does not name a defined window or pixmap.
        /// </summary>
        BadDrawable = 9,

        FirstExtensionError = 128,
        LastExtensionError = 255,
    }
}
