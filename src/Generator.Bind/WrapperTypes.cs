using System;

namespace Bind
{
    /// <summary>
    /// Defines different types of parameter wrapper identifiers, which are used for hinting at how the method
    /// signatures should be generated.
    /// </summary>
    [Flags]
    public enum WrapperTypes
    {
        /// <summary>
        /// No wrapper needed.
        /// </summary>
        None = 0,

        /// <summary>
        /// Function takes bool parameter - C uses Int for bools, so we have to marshal.
        /// </summary>
        BoolParameter = 1 << 0,

        /// <summary>
        /// Function takes generic parameters - add ref/out generic and generic overloads.
        /// </summary>
        GenericParameter = 1 << 1,

        /// <summary>
        /// Function takes arrays as parameters - add ref/out and ([Out]) array overloads.
        /// </summary>
        ArrayParameter = 1 << 2,

        /// <summary>
        /// Function with bitmask parameters. Bitmask parameters map to UInt, but since we can only use signed
        /// types (for CLS compliance), we must add the unchecked keyword.
        /// Usually found in bitmasks
        /// </summary>
        UncheckedParameter = 1 << 3,

        /// <summary>
        /// Function that takes (in/ref/out) a naked pointer as a parameter - we pass an IntPtr.
        /// </summary>
        PointerParameter = 1 << 4,

        /// <summary>
        /// Function that takes a reference to a struct.
        /// </summary>
        ReferenceParameter = 1 << 5,

        /// <summary>
        /// Function returns string - needs manual marshalling through IntPtr to prevent the managed GC
        /// from freeing memory allocated on the unmanaged side (e.g. glGetString).
        /// </summary>
        StringReturnType = 1 << 6,

        /// <summary>
        /// Function returns a void pointer - maps to IntPtr, and the user has to manually marshal the type.
        /// </summary>
        GenericReturnType = 1 << 7,

        /// <summary>
        /// Function returns a typed pointer - we have to copy the data to an array to protect it from the GC.
        /// </summary>
        ArrayReturnType = 1 << 8,

        /// <summary>
        /// Function normally returns a value via an out parameter.
        /// This overload returns a single item directly.
        /// e.g. void GetIntegerv(enum pname, out int value) => int GetInteger(enum pname)
        /// </summary>
        ConvenienceReturnType = 1 << 9,

        /// <summary>
        /// Function normally returns an array via an out parameter.
        /// This overload returns a single item directly.
        /// e.g. void GenBuffers(int count, int[] ids) => int GenBuffer()
        /// </summary>
        ConvenienceArrayReturnType = 1 << 10,

        /// <summary>
        /// Function normally takes an array in parameter.
        /// This overload takes a single item directly.
        /// e.g. void DeleteBuffers(int count, int[] ids) => DeleteBuffer(int id)
        /// </summary>
        ConvenienceArrayType = 1 << 11,

        /// <summary>
        /// Function takes a String or StringBuilder parameter
        /// </summary>
        StringParameter = 1 << 12,

        /// <summary>
        /// Function takes a String[] parameter
        /// </summary>
        StringArrayParameter = 1 << 13,

        /// <summary>
        /// Functions takes an IntPtr that corresponds to a size_t.
        /// Add an int32 overload for convenience.
        /// </summary>
        SizeParameter = 1 << 14
    }
}
