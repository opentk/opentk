using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace OpenTK.Mathematics
{
    internal static class VectorExtensions
    {
        /// <summary>
        /// Reinterprets this <see cref="Vector2"/> as a <see cref="Vector128{T}"/> leaving the new elements undefined.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec"/> reinterpreted as a new <see cref="Vector128{T}"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> AsVector128Unsafe(this Vector2 vec)
        {
            Unsafe.SkipInit(out Vector128<float> result);
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector128<float>, byte>(ref result), vec);
            return result;
        }

        /// <summary>
        /// Reinterprets this <see cref="Vector3"/> as a <see cref="Vector128{T}"/> leaving the new elements undefined.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec"/> reinterpreted as a new <see cref="Vector128{T}"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> AsVector128Unsafe(this Vector3 vec)
        {
            Unsafe.SkipInit(out Vector128<float> result);
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector128<float>, byte>(ref result), vec);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> AsVector128(this Vector4 vec)
        {
            return Unsafe.BitCast<Vector4, Vector128<float>>(vec);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector2"/>.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector2"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 AsVector2Otk(this Vector128<float> vec)
        {
            ref byte address = ref Unsafe.As<Vector128<float>, byte>(ref vec);
            return Unsafe.ReadUnaligned<Vector2>(ref address);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector3" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 AsVector3Otk(this Vector128<float> vec)
        {
            ref byte address = ref Unsafe.As<Vector128<float>, byte>(ref vec);
            return Unsafe.ReadUnaligned<Vector3>(ref address);
        }

        /// <summary>Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector4"/>.</summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector4"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AsVector4Otk(this Vector128<float> vec)
        {
            return Unsafe.BitCast<Vector128<float>, Vector4>(vec);
        }
    }
}
