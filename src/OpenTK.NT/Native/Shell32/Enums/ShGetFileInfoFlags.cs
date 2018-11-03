using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in
    /// <see cref="Shell32.SHGetFileInfo(string, FileAttributeFlags, ref SHFileInfo, uint, ShGetFileInfoFlags)"/> to
    /// specify the type of file information to retrieve.
    /// </summary>
    [Flags]
    public enum ShGetFileInfoFlags : uint
    {
        /// <summary>
        /// Modify <see cref="Icon"/>, causing the function to retrieve the file's large icon.
        /// The <see cref="Icon"/> flag must also be set.
        /// </summary>
        LargeIcon = 0x000000000,

        /// <summary>
        /// Modify <see cref="Icon"/>, causing the function to retrieve the file's small icon.
        /// Also used to modify <see cref="SysIconIndex"/>, causing the function to return the handle
        /// to the system image list that contains small icon images. The <see cref="Icon"/>
        /// and/or <see cref="SysIconIndex"/> flag must also be set.
        /// </summary>
        SmallIcon = 0x000000001,

        /// <summary>
        /// Modify <see cref="Icon"/>, causing the function to retrieve the file's open icon.
        /// Also used to modify <see cref="SysIconIndex"/>, causing the function to return the handle
        /// to the system image list that contains the file's small open icon. A container
        /// object displays an open icon to indicate that the container is open.
        /// The <see cref="Icon"/> and/or <see cref="SysIconIndex"/> flag must also be set.
        /// </summary>
        OpenIcon = 0x000000002,

        /// <summary>
        /// Modify <see cref="Icon"/>, causing the function to retrieve a Shell-sized icon.
        /// If this flag is not specified the function sizes the icon according to
        /// the system metric values. The <see cref="Icon"/> flag must also be set.
        /// </summary>
        ShellIconSize = 0x000000004,

        /// <summary>
        /// Indicate that pszPath is the address of an ITEMIDLIST structure rather than a path name.
        /// </summary>
        Pidl = 0x000000008,

        /// <summary>
        /// Indicates that the function should not attempt to access the file specified by pszPath.
        /// Rather, it should act as if the file specified by pszPath exists with the file attributes
        /// passed in dwFileAttributes. This flag cannot be combined with the <see cref="Attributes"/>,
        /// <see cref="ExeType"/>, or <see cref="Pidl"/> flags.
        /// </summary>
        UseFileAttributes = 0x000000010,

        /// <summary>
        /// Apply the appropriate overlays to the file's icon. The <see cref="Icon"/> flag must also be set.
        /// </summary>
        AddOverlays = 0x000000020,

        /// <summary>
        /// Return the index of the overlay icon. The value of the overlay index is returned in the upper
        /// eight bits of the iIcon member of the structure specified by psfi.
        /// This flag requires that the <see cref="Icon"/> be set as well.
        /// </summary>
        OverlayIndex = 0x000000040,

        /// <summary>
        /// Retrieve the handle to the icon that represents the file and the index of the icon within the
        /// system image list. The handle is copied to the hIcon member of the structure specified by psfi,
        /// and the index is copied to the iIcon member.
        /// </summary>
        Icon = 0x000000100,

        /// <summary>
        /// Retrieve the display name for the file, which is the name as it appears in Windows Explorer.
        /// The name is copied to the szDisplayName member of the structure specified in psfi.
        /// The returned display name uses the long file name, if there is one, rather than the
        /// 8.3 form of the file name. Note that the display name can be affected by settings such
        /// as whether extensions are shown.
        /// </summary>
        DisplayName = 0x000000200,

        /// <summary>
        /// Retrieve the string that describes the file's type. The string is copied to
        /// the szTypeName member of the structure specified in psfi.
        /// </summary>
        TypeName = 0x000000400,

        /// <summary>
        /// Retrieve the item attributes. The attributes are copied to the dwAttributes member
        /// of the structure specified in the psfi parameter.
        /// </summary>
        Attributes = 0x000000800,

        /// <summary>
        /// Retrieve the name of the file that contains the icon representing the file specified
        /// by pszPath, as returned by the IExtractIcon::GetIconLocation method of the file's icon handler.
        /// Also retrieve the icon index within that file. The name of the file containing the icon is
        /// copied to the szDisplayName member of the structure specified by psfi.
        /// The icon's index is copied to that structure's iIcon member.
        /// </summary>
        IconLocation = 0x000001000,

        /// <summary>
        /// Retrieve the type of the executable file if pszPath identifies an executable file.
        /// The information is packed into the return value. This flag cannot be specified with any other flags.
        /// </summary>
        ExeType = 0x000002000,

        /// <summary>
        /// Retrieve the index of a system image list icon. If successful, the index is copied to the
        /// iIcon member of psfi. The return value is a handle to the system image list. Only those
        /// images whose indices are successfully copied to iIcon are valid. Attempting to access
        /// other images in the system image list will result in undefined behavior.
        /// </summary>
        SysIconIndex = 0x000004000,

        /// <summary>
        /// Modify <see cref="Icon"/>, causing the function to add the link overlay to the file's icon.
        /// The <see cref="Icon"/> flag must also be set.
        /// </summary>
        LinkOverlay = 0x000008000,

        /// <summary>
        /// Modify <see cref="Icon"/>, causing the function to blend the file's icon with the system highlight color.
        /// The <see cref="Icon"/> flag must also be set.
        /// </summary>
        Selected = 0x000010000,

        /// <summary>
        /// Modify <see cref="Attributes"/> to indicate that the dwAttributes member of the <see cref="SHFileInfo"/>
        /// structure at psfi contains the specific attributes that are desired. These attributes are passed to
        /// IShellFolder::GetAttributesOf. If this flag is not specified, 0xFFFFFFFF is passed to
        /// IShellFolder::GetAttributesOf, requesting all attributes. This flag cannot be specified with the
        /// <see cref="Icon"/> flag.
        /// </summary>
        AttributeSpecified = 0x000020000,
    }
}
