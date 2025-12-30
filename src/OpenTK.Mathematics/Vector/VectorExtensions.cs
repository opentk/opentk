using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace OpenTK.Mathematics
{
    internal static class VectorExtensions
    {
        #region float

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

        #endregion
        #region double

        /// <summary>
        /// Reinterprets this <see cref="Vector2d"/> as a <see cref="Vector128{T}"/> leaving the new elements undefined.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec"/> reinterpreted as a new <see cref="Vector128{T}"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> AsVector256Unsafe(this Vector2d vec)
        {
            Unsafe.SkipInit(out Vector256<double> result);
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector256<double>, byte>(ref result), vec);
            return result;
        }

        /// <summary>
        /// Reinterprets this <see cref="Vector3d"/> as a <see cref="Vector128{T}"/> leaving the new elements undefined.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec"/> reinterpreted as a new <see cref="Vector128{T}"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> AsVector256Unsafe(this Vector3d vec)
        {
            Unsafe.SkipInit(out Vector256<double> result);
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector256<double>, byte>(ref result), vec);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> AsVector256(this Vector4d vec)
        {
            return Unsafe.BitCast<Vector4d, Vector256<double>>(vec);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector2d"/>.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector2d"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2d AsVector2dOtk(this Vector256<double> vec)
        {
            ref byte address = ref Unsafe.As<Vector256<double>, byte>(ref vec);
            return Unsafe.ReadUnaligned<Vector2d>(ref address);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector3d"/>.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector3d" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3d AsVector3dOtk(this Vector256<double> vec)
        {
            ref byte address = ref Unsafe.As<Vector256<double>, byte>(ref vec);
            return Unsafe.ReadUnaligned<Vector3d>(ref address);
        }

        /// <summary>Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector4"/>.</summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector4"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4d AsVector4dOtk(this Vector256<double> vec)
        {
            return Unsafe.BitCast<Vector256<double>, Vector4d>(vec);
        }

        #endregion
        #region int

        /// <summary>
        /// Reinterprets this <see cref="Vector2i"/> as a <see cref="Vector128{T}"/> leaving the new elements undefined.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec"/> reinterpreted as a new <see cref="Vector128{T}"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> AsVector128Unsafe(this Vector2i vec)
        {
            Unsafe.SkipInit(out Vector128<int> result);
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector128<int>, byte>(ref result), vec);
            return result;
        }

        /// <summary>
        /// Reinterprets this <see cref="Vector3i"/> as a <see cref="Vector128{T}"/> leaving the new elements undefined.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec"/> reinterpreted as a new <see cref="Vector128{T}"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> AsVector128Unsafe(this Vector3i vec)
        {
            Unsafe.SkipInit(out Vector128<int> result);
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector128<int>, byte>(ref result), vec);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> AsVector128(this Vector4i vec)
        {
            return Unsafe.BitCast<Vector4i, Vector128<int>>(vec);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector2"/>.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector2i"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2i AsVector2iOtk(this Vector128<int> vec)
        {
            ref byte address = ref Unsafe.As<Vector128<int>, byte>(ref vec);
            return Unsafe.ReadUnaligned<Vector2i>(ref address);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector3i"/>.
        /// </summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector3i" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3i AsVector3iOtk(this Vector128<int> vec)
        {
            ref byte address = ref Unsafe.As<Vector128<int>, byte>(ref vec);
            return Unsafe.ReadUnaligned<Vector3i>(ref address);
        }

        /// <summary>Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector4i"/>.</summary>
        /// <param name="vec">The vector to reinterpret.</param>
        /// <returns><paramref name="vec" /> reinterpreted as a new <see cref="Vector4i"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4i AsVector4iOtk(this Vector128<int> vec)
        {
            return Unsafe.BitCast<Vector128<int>, Vector4i>(vec);
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ConvertToVector128Int32(Vector256<double> vec)
        {
            if (Avx.IsSupported)
            {
                return Avx.ConvertToVector128Int32WithTruncation(vec);
            }
            else if (AdvSimd.Arm64.IsSupported)
            {
                return Vector128.Narrow(
                    AdvSimd.Arm64.ConvertToInt64RoundToZero(vec.GetLower()),
                    AdvSimd.Arm64.ConvertToInt64RoundToZero(vec.GetUpper()));
            }
            else
            {
                var vec4d = Unsafe.BitCast<Vector256<double>, Vector4d>(vec);
                return Vector128.Create(
                    (int)vec4d.X,
                    (int)vec4d.Y,
                    (int)vec4d.Z,
                    (int)vec4d.W);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> ConvertToVector256Double(Vector128<int> vec)
        {
            if (Avx.IsSupported)
            {
                return Avx.ConvertToVector256Double(vec);
            }
            else if (AdvSimd.Arm64.IsSupported)
            {
                return Vector256.Create(
                    AdvSimd.Arm64.ConvertToDouble(Vector128.WidenLower(vec)),
                    AdvSimd.Arm64.ConvertToDouble(Vector128.WidenUpper(vec)));
            }
            else
            {
                var vec4i = Unsafe.BitCast<Vector128<int>, Vector4i>(vec);
                return Vector256.Create(
                    (double)vec4i.X,
                    (double)vec4i.Y,
                    (double)vec4i.Z,
                    (double)vec4i.W);
            }
        }
    }
}
