


using System;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using OpenTK.Mathematics;

public unsafe class MatLookAtBenchmark
{

    // TODO: See, if inline methods have no negative
    // impact on performance

    public static Matrix4 LookAtSSE(Vector3 eye, Vector3 target, Vector3 up)
    {
        Vector128<float> x;

        Vector128<float> y;

        Vector128<float> z;


        // Load the overloads as xmm registers
        // and process them

        Vector128<float> e;

        {
            Vector128<float> t;

            Vector128<float> u;


            // Overloads will be aligned to 8 bytes,
            // we can do a wide load no problem

            if(Environment.Is64BitProcess) // This check gets JITed away
            {
                e = Sse.LoadVector128((float*)&eye);

                t = Sse.LoadVector128((float*)&target);

                u = Sse.LoadVector128((float*)&up);
            }

            // Overloads will be aligned to 4 bytes,
            // wide loads could risk reading protected memory

            else
            {
                // Load eye vector

                *(long*)&e = *(long*)&eye; // Copy first two components

                ((int*)&e)[2] = ((int*)&eye)[2]; // Copy last component


                // Load target vector

                *(long*)&t = *(long*)&target; // Copy first two components

                ((int*)&t)[2] = ((int*)&target)[2]; // Copy last component


                // Load up vector

                *(long*)&u = *(long*)&up; // Copy first two components

                ((int*)&u)[2] = ((int*)&up)[2]; // Copy last component
            }


            // Evaluate Z

            z = Sse.Subtract(e, t);

            // Normalize Z

            {
                Vector128<float> tmp0 = Sse.Multiply(z, z); 


                Vector128<float> tmp1 = Sse.Shuffle(tmp0, tmp0, 0b00_01_00_10);

                Vector128<float> tmp2 = Sse.Shuffle(tmp0, tmp0, 0b00_00_10_01);


                tmp0 = Sse.Add(tmp0, tmp1);

                tmp0 = Sse.Add(tmp0, tmp2);


                tmp0 = Sse.ReciprocalSqrt(tmp0);


                z = Sse.Multiply(z, tmp0);
            }


            // Evaluate X (Cross product between u and z)

            {
                Vector128<float> tmp0 = Sse.Shuffle(u, u, 0b00_00_10_01);

                Vector128<float> tmp1 = Sse.Shuffle(z, z, 0b00_01_00_10);

                Vector128<float> tmp2 = Sse.Shuffle(u, u, 0b00_01_00_10);

                Vector128<float> tmp3 = Sse.Shuffle(z, z, 0b00_00_10_01);


                tmp0 = Sse.Multiply(tmp0, tmp1);

                tmp2 = Sse.Multiply(tmp2, tmp3);


                x = Sse.Subtract(tmp0, tmp2);
            }

            // Normalize X

            {
                Vector128<float> tmp0 = Sse.Multiply(x, x); 


                Vector128<float> tmp1 = Sse.Shuffle(tmp0, tmp0, 0b00_01_00_10);

                Vector128<float> tmp2 = Sse.Shuffle(tmp0, tmp0, 0b00_00_10_01);


                tmp0 = Sse.Add(tmp0, tmp1);

                tmp0 = Sse.Add(tmp0, tmp2);


                tmp0 = Sse.ReciprocalSqrt(tmp0);


                x = Sse.Multiply(x, tmp0);
            }


            // Evaluate Y (Cross product between z and x)

            {
                Vector128<float> tmp0 = Sse.Shuffle(z, z, 0b00_00_10_01);

                Vector128<float> tmp1 = Sse.Shuffle(x, x, 0b00_01_00_10);

                Vector128<float> tmp2 = Sse.Shuffle(z, z, 0b00_01_00_10);

                Vector128<float> tmp3 = Sse.Shuffle(x, x, 0b00_00_10_01);


                tmp0 = Sse.Multiply(tmp0, tmp1);

                tmp2 = Sse.Multiply(tmp2, tmp3);


                y = Sse.Subtract(tmp0, tmp2);
            }


            // Normalize Y

            {
                Vector128<float> tmp0 = Sse.Multiply(y, y); 


                Vector128<float> tmp1 = Sse.Shuffle(tmp0, tmp0, 0b00_01_00_10);

                Vector128<float> tmp2 = Sse.Shuffle(tmp0, tmp0, 0b00_00_10_01);


                tmp0 = Sse.Add(tmp0, tmp1);

                tmp0 = Sse.Add(tmp0, tmp2);


                tmp0 = Sse.ReciprocalSqrt(tmp0);


                y = Sse.Multiply(y, tmp0);
            }
        }


        Matrix4 result = new Matrix4();


        // The final step, where the results
        // get saved to the result matrix

        {
            // x.X, y.X, z.X, -

            Vector128<float> xxx;


            // x.Y, y.Y, z.Y, -

            Vector128<float> yyy;


            // x.Z, y.Z, z.Z, -

            Vector128<float> zzz;


            Vector128<float> tmp0 = Sse.Shuffle(x, y, 0b01_00_01_00);

            Vector128<float> tmp1 = Sse.Shuffle(z, z, 0b01_00_01_00);


            xxx = Sse.Shuffle(tmp0, tmp1, 0b10_00_10_00);

            yyy = Sse.Shuffle(tmp0, tmp1, 0b11_01_11_01);


            tmp0 = Sse.Shuffle(x, y, 0b10_10_10_10);

            zzz = Sse.Shuffle(tmp0, z, 0b00_10_10_00);


            // e.X, e.X, e.X, -

            Vector128<float> eX = Sse.Shuffle(e, e, 0b00_00_00_00);


            // e.Y, e.Y, e.Y, -

            Vector128<float> eY = Sse.Shuffle(e, e, 0b01_01_01_01);


            // e.Z, e.Z, e.Z, -

            Vector128<float> eZ = Sse.Shuffle(e, e, 0b10_10_10_10);


            tmp0 = Sse.Multiply(xxx, eX);

            tmp1 = Sse.Multiply(yyy, eY);

            Vector128<float> tmp2 = Sse.Multiply(zzz, eZ);

            tmp0 = Sse.Add(tmp0, tmp1);

            tmp0 = Sse.Add(tmp0, tmp2);


            tmp0 = Sse.Xor(tmp0, Vector128.Create(-0.0f, -0.0f, -0.0f, -0.0f));


            Sse.Store((float*)&result.Row0, xxx);

            Sse.Store((float*)&result.Row1, yyy);

            Sse.Store((float*)&result.Row2, zzz);

            Sse.Store((float*)&result.Row3, tmp0);


            *(int*)&result.Row0.W ^= *(int*)&result.Row0.W;

            *(int*)&result.Row1.W ^= *(int*)&result.Row1.W;

            *(int*)&result.Row2.W ^= *(int*)&result.Row2.W;

            *(int*)&result.Row3.W = 1;
        }


        return result;
    }
}
