namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    internal static class Delegates
    {
        static Delegates()
        {
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NewList(UInt32 list, GL.Enums.ListMode mode);
        internal static NewList glNewList = (NewList)GL.GetDelegateForExtensionMethod("glNewList", typeof(NewList)) ?? new NewList(Imports.NewList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndList();
        internal static EndList glEndList = (EndList)GL.GetDelegateForExtensionMethod("glEndList", typeof(EndList)) ?? new EndList(Imports.EndList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CallList(UInt32 list);
        internal static CallList glCallList = (CallList)GL.GetDelegateForExtensionMethod("glCallList", typeof(CallList)) ?? new CallList(Imports.CallList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CallLists(Int32 n, GL.Enums.ListNameType type, void* lists);
        internal unsafe static CallLists glCallLists = (CallLists)GL.GetDelegateForExtensionMethod("glCallLists", typeof(CallLists)) ?? new CallLists(Imports.CallLists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteLists(UInt32 list, Int32 range);
        internal static DeleteLists glDeleteLists = (DeleteLists)GL.GetDelegateForExtensionMethod("glDeleteLists", typeof(DeleteLists)) ?? new DeleteLists(Imports.DeleteLists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenLists(Int32 range);
        internal static GenLists glGenLists = (GenLists)GL.GetDelegateForExtensionMethod("glGenLists", typeof(GenLists)) ?? new GenLists(Imports.GenLists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListBase(UInt32 @base);
        internal static ListBase glListBase = (ListBase)GL.GetDelegateForExtensionMethod("glListBase", typeof(ListBase)) ?? new ListBase(Imports.ListBase);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Begin(GL.Enums.BeginMode mode);
        internal static Begin glBegin = (Begin)GL.GetDelegateForExtensionMethod("glBegin", typeof(Begin)) ?? new Begin(Imports.Begin);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
        internal unsafe static Bitmap glBitmap = (Bitmap)GL.GetDelegateForExtensionMethod("glBitmap", typeof(Bitmap)) ?? new Bitmap(Imports.Bitmap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3b(SByte red, SByte green, SByte blue);
        internal static Color3b glColor3b = (Color3b)GL.GetDelegateForExtensionMethod("glColor3b", typeof(Color3b)) ?? new Color3b(Imports.Color3b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3bv(SByte* v);
        internal unsafe static Color3bv glColor3bv = (Color3bv)GL.GetDelegateForExtensionMethod("glColor3bv", typeof(Color3bv)) ?? new Color3bv(Imports.Color3bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3d(Double red, Double green, Double blue);
        internal static Color3d glColor3d = (Color3d)GL.GetDelegateForExtensionMethod("glColor3d", typeof(Color3d)) ?? new Color3d(Imports.Color3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3dv(Double* v);
        internal unsafe static Color3dv glColor3dv = (Color3dv)GL.GetDelegateForExtensionMethod("glColor3dv", typeof(Color3dv)) ?? new Color3dv(Imports.Color3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3f(Single red, Single green, Single blue);
        internal static Color3f glColor3f = (Color3f)GL.GetDelegateForExtensionMethod("glColor3f", typeof(Color3f)) ?? new Color3f(Imports.Color3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3fv(Single* v);
        internal unsafe static Color3fv glColor3fv = (Color3fv)GL.GetDelegateForExtensionMethod("glColor3fv", typeof(Color3fv)) ?? new Color3fv(Imports.Color3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3i(Int32 red, Int32 green, Int32 blue);
        internal static Color3i glColor3i = (Color3i)GL.GetDelegateForExtensionMethod("glColor3i", typeof(Color3i)) ?? new Color3i(Imports.Color3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3iv(Int32* v);
        internal unsafe static Color3iv glColor3iv = (Color3iv)GL.GetDelegateForExtensionMethod("glColor3iv", typeof(Color3iv)) ?? new Color3iv(Imports.Color3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3s(Int16 red, Int16 green, Int16 blue);
        internal static Color3s glColor3s = (Color3s)GL.GetDelegateForExtensionMethod("glColor3s", typeof(Color3s)) ?? new Color3s(Imports.Color3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3sv(Int16* v);
        internal unsafe static Color3sv glColor3sv = (Color3sv)GL.GetDelegateForExtensionMethod("glColor3sv", typeof(Color3sv)) ?? new Color3sv(Imports.Color3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3ub(Byte red, Byte green, Byte blue);
        internal static Color3ub glColor3ub = (Color3ub)GL.GetDelegateForExtensionMethod("glColor3ub", typeof(Color3ub)) ?? new Color3ub(Imports.Color3ub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3ubv(Byte* v);
        internal unsafe static Color3ubv glColor3ubv = (Color3ubv)GL.GetDelegateForExtensionMethod("glColor3ubv", typeof(Color3ubv)) ?? new Color3ubv(Imports.Color3ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
        internal static Color3ui glColor3ui = (Color3ui)GL.GetDelegateForExtensionMethod("glColor3ui", typeof(Color3ui)) ?? new Color3ui(Imports.Color3ui);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3uiv(UInt32* v);
        internal unsafe static Color3uiv glColor3uiv = (Color3uiv)GL.GetDelegateForExtensionMethod("glColor3uiv", typeof(Color3uiv)) ?? new Color3uiv(Imports.Color3uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3us(UInt16 red, UInt16 green, UInt16 blue);
        internal static Color3us glColor3us = (Color3us)GL.GetDelegateForExtensionMethod("glColor3us", typeof(Color3us)) ?? new Color3us(Imports.Color3us);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3usv(UInt16* v);
        internal unsafe static Color3usv glColor3usv = (Color3usv)GL.GetDelegateForExtensionMethod("glColor3usv", typeof(Color3usv)) ?? new Color3usv(Imports.Color3usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
        internal static Color4b glColor4b = (Color4b)GL.GetDelegateForExtensionMethod("glColor4b", typeof(Color4b)) ?? new Color4b(Imports.Color4b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4bv(SByte* v);
        internal unsafe static Color4bv glColor4bv = (Color4bv)GL.GetDelegateForExtensionMethod("glColor4bv", typeof(Color4bv)) ?? new Color4bv(Imports.Color4bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4d(Double red, Double green, Double blue, Double alpha);
        internal static Color4d glColor4d = (Color4d)GL.GetDelegateForExtensionMethod("glColor4d", typeof(Color4d)) ?? new Color4d(Imports.Color4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4dv(Double* v);
        internal unsafe static Color4dv glColor4dv = (Color4dv)GL.GetDelegateForExtensionMethod("glColor4dv", typeof(Color4dv)) ?? new Color4dv(Imports.Color4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
        internal static Color4f glColor4f = (Color4f)GL.GetDelegateForExtensionMethod("glColor4f", typeof(Color4f)) ?? new Color4f(Imports.Color4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4fv(Single* v);
        internal unsafe static Color4fv glColor4fv = (Color4fv)GL.GetDelegateForExtensionMethod("glColor4fv", typeof(Color4fv)) ?? new Color4fv(Imports.Color4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
        internal static Color4i glColor4i = (Color4i)GL.GetDelegateForExtensionMethod("glColor4i", typeof(Color4i)) ?? new Color4i(Imports.Color4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4iv(Int32* v);
        internal unsafe static Color4iv glColor4iv = (Color4iv)GL.GetDelegateForExtensionMethod("glColor4iv", typeof(Color4iv)) ?? new Color4iv(Imports.Color4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
        internal static Color4s glColor4s = (Color4s)GL.GetDelegateForExtensionMethod("glColor4s", typeof(Color4s)) ?? new Color4s(Imports.Color4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4sv(Int16* v);
        internal unsafe static Color4sv glColor4sv = (Color4sv)GL.GetDelegateForExtensionMethod("glColor4sv", typeof(Color4sv)) ?? new Color4sv(Imports.Color4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
        internal static Color4ub glColor4ub = (Color4ub)GL.GetDelegateForExtensionMethod("glColor4ub", typeof(Color4ub)) ?? new Color4ub(Imports.Color4ub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubv(Byte* v);
        internal unsafe static Color4ubv glColor4ubv = (Color4ubv)GL.GetDelegateForExtensionMethod("glColor4ubv", typeof(Color4ubv)) ?? new Color4ubv(Imports.Color4ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
        internal static Color4ui glColor4ui = (Color4ui)GL.GetDelegateForExtensionMethod("glColor4ui", typeof(Color4ui)) ?? new Color4ui(Imports.Color4ui);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4uiv(UInt32* v);
        internal unsafe static Color4uiv glColor4uiv = (Color4uiv)GL.GetDelegateForExtensionMethod("glColor4uiv", typeof(Color4uiv)) ?? new Color4uiv(Imports.Color4uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
        internal static Color4us glColor4us = (Color4us)GL.GetDelegateForExtensionMethod("glColor4us", typeof(Color4us)) ?? new Color4us(Imports.Color4us);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4usv(UInt16* v);
        internal unsafe static Color4usv glColor4usv = (Color4usv)GL.GetDelegateForExtensionMethod("glColor4usv", typeof(Color4usv)) ?? new Color4usv(Imports.Color4usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EdgeFlag(GL.Enums.Boolean flag);
        internal static EdgeFlag glEdgeFlag = (EdgeFlag)GL.GetDelegateForExtensionMethod("glEdgeFlag", typeof(EdgeFlag)) ?? new EdgeFlag(Imports.EdgeFlag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagv(GL.Enums.Boolean* flag);
        internal unsafe static EdgeFlagv glEdgeFlagv = (EdgeFlagv)GL.GetDelegateForExtensionMethod("glEdgeFlagv", typeof(EdgeFlagv)) ?? new EdgeFlagv(Imports.EdgeFlagv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void End();
        internal static End glEnd = (End)GL.GetDelegateForExtensionMethod("glEnd", typeof(End)) ?? new End(Imports.End);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexd(Double c);
        internal static Indexd glIndexd = (Indexd)GL.GetDelegateForExtensionMethod("glIndexd", typeof(Indexd)) ?? new Indexd(Imports.Indexd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexdv(Double* c);
        internal unsafe static Indexdv glIndexdv = (Indexdv)GL.GetDelegateForExtensionMethod("glIndexdv", typeof(Indexdv)) ?? new Indexdv(Imports.Indexdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexf(Single c);
        internal static Indexf glIndexf = (Indexf)GL.GetDelegateForExtensionMethod("glIndexf", typeof(Indexf)) ?? new Indexf(Imports.Indexf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexfv(Single* c);
        internal unsafe static Indexfv glIndexfv = (Indexfv)GL.GetDelegateForExtensionMethod("glIndexfv", typeof(Indexfv)) ?? new Indexfv(Imports.Indexfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexi(Int32 c);
        internal static Indexi glIndexi = (Indexi)GL.GetDelegateForExtensionMethod("glIndexi", typeof(Indexi)) ?? new Indexi(Imports.Indexi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexiv(Int32* c);
        internal unsafe static Indexiv glIndexiv = (Indexiv)GL.GetDelegateForExtensionMethod("glIndexiv", typeof(Indexiv)) ?? new Indexiv(Imports.Indexiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexs(Int16 c);
        internal static Indexs glIndexs = (Indexs)GL.GetDelegateForExtensionMethod("glIndexs", typeof(Indexs)) ?? new Indexs(Imports.Indexs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexsv(Int16* c);
        internal unsafe static Indexsv glIndexsv = (Indexsv)GL.GetDelegateForExtensionMethod("glIndexsv", typeof(Indexsv)) ?? new Indexsv(Imports.Indexsv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3b(SByte nx, SByte ny, SByte nz);
        internal static Normal3b glNormal3b = (Normal3b)GL.GetDelegateForExtensionMethod("glNormal3b", typeof(Normal3b)) ?? new Normal3b(Imports.Normal3b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3bv(SByte* v);
        internal unsafe static Normal3bv glNormal3bv = (Normal3bv)GL.GetDelegateForExtensionMethod("glNormal3bv", typeof(Normal3bv)) ?? new Normal3bv(Imports.Normal3bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3d(Double nx, Double ny, Double nz);
        internal static Normal3d glNormal3d = (Normal3d)GL.GetDelegateForExtensionMethod("glNormal3d", typeof(Normal3d)) ?? new Normal3d(Imports.Normal3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3dv(Double* v);
        internal unsafe static Normal3dv glNormal3dv = (Normal3dv)GL.GetDelegateForExtensionMethod("glNormal3dv", typeof(Normal3dv)) ?? new Normal3dv(Imports.Normal3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3f(Single nx, Single ny, Single nz);
        internal static Normal3f glNormal3f = (Normal3f)GL.GetDelegateForExtensionMethod("glNormal3f", typeof(Normal3f)) ?? new Normal3f(Imports.Normal3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3fv(Single* v);
        internal unsafe static Normal3fv glNormal3fv = (Normal3fv)GL.GetDelegateForExtensionMethod("glNormal3fv", typeof(Normal3fv)) ?? new Normal3fv(Imports.Normal3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3i(Int32 nx, Int32 ny, Int32 nz);
        internal static Normal3i glNormal3i = (Normal3i)GL.GetDelegateForExtensionMethod("glNormal3i", typeof(Normal3i)) ?? new Normal3i(Imports.Normal3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3iv(Int32* v);
        internal unsafe static Normal3iv glNormal3iv = (Normal3iv)GL.GetDelegateForExtensionMethod("glNormal3iv", typeof(Normal3iv)) ?? new Normal3iv(Imports.Normal3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3s(Int16 nx, Int16 ny, Int16 nz);
        internal static Normal3s glNormal3s = (Normal3s)GL.GetDelegateForExtensionMethod("glNormal3s", typeof(Normal3s)) ?? new Normal3s(Imports.Normal3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3sv(Int16* v);
        internal unsafe static Normal3sv glNormal3sv = (Normal3sv)GL.GetDelegateForExtensionMethod("glNormal3sv", typeof(Normal3sv)) ?? new Normal3sv(Imports.Normal3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2d(Double x, Double y);
        internal static RasterPos2d glRasterPos2d = (RasterPos2d)GL.GetDelegateForExtensionMethod("glRasterPos2d", typeof(RasterPos2d)) ?? new RasterPos2d(Imports.RasterPos2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2dv(Double* v);
        internal unsafe static RasterPos2dv glRasterPos2dv = (RasterPos2dv)GL.GetDelegateForExtensionMethod("glRasterPos2dv", typeof(RasterPos2dv)) ?? new RasterPos2dv(Imports.RasterPos2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2f(Single x, Single y);
        internal static RasterPos2f glRasterPos2f = (RasterPos2f)GL.GetDelegateForExtensionMethod("glRasterPos2f", typeof(RasterPos2f)) ?? new RasterPos2f(Imports.RasterPos2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2fv(Single* v);
        internal unsafe static RasterPos2fv glRasterPos2fv = (RasterPos2fv)GL.GetDelegateForExtensionMethod("glRasterPos2fv", typeof(RasterPos2fv)) ?? new RasterPos2fv(Imports.RasterPos2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2i(Int32 x, Int32 y);
        internal static RasterPos2i glRasterPos2i = (RasterPos2i)GL.GetDelegateForExtensionMethod("glRasterPos2i", typeof(RasterPos2i)) ?? new RasterPos2i(Imports.RasterPos2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2iv(Int32* v);
        internal unsafe static RasterPos2iv glRasterPos2iv = (RasterPos2iv)GL.GetDelegateForExtensionMethod("glRasterPos2iv", typeof(RasterPos2iv)) ?? new RasterPos2iv(Imports.RasterPos2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2s(Int16 x, Int16 y);
        internal static RasterPos2s glRasterPos2s = (RasterPos2s)GL.GetDelegateForExtensionMethod("glRasterPos2s", typeof(RasterPos2s)) ?? new RasterPos2s(Imports.RasterPos2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2sv(Int16* v);
        internal unsafe static RasterPos2sv glRasterPos2sv = (RasterPos2sv)GL.GetDelegateForExtensionMethod("glRasterPos2sv", typeof(RasterPos2sv)) ?? new RasterPos2sv(Imports.RasterPos2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3d(Double x, Double y, Double z);
        internal static RasterPos3d glRasterPos3d = (RasterPos3d)GL.GetDelegateForExtensionMethod("glRasterPos3d", typeof(RasterPos3d)) ?? new RasterPos3d(Imports.RasterPos3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3dv(Double* v);
        internal unsafe static RasterPos3dv glRasterPos3dv = (RasterPos3dv)GL.GetDelegateForExtensionMethod("glRasterPos3dv", typeof(RasterPos3dv)) ?? new RasterPos3dv(Imports.RasterPos3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3f(Single x, Single y, Single z);
        internal static RasterPos3f glRasterPos3f = (RasterPos3f)GL.GetDelegateForExtensionMethod("glRasterPos3f", typeof(RasterPos3f)) ?? new RasterPos3f(Imports.RasterPos3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3fv(Single* v);
        internal unsafe static RasterPos3fv glRasterPos3fv = (RasterPos3fv)GL.GetDelegateForExtensionMethod("glRasterPos3fv", typeof(RasterPos3fv)) ?? new RasterPos3fv(Imports.RasterPos3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3i(Int32 x, Int32 y, Int32 z);
        internal static RasterPos3i glRasterPos3i = (RasterPos3i)GL.GetDelegateForExtensionMethod("glRasterPos3i", typeof(RasterPos3i)) ?? new RasterPos3i(Imports.RasterPos3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3iv(Int32* v);
        internal unsafe static RasterPos3iv glRasterPos3iv = (RasterPos3iv)GL.GetDelegateForExtensionMethod("glRasterPos3iv", typeof(RasterPos3iv)) ?? new RasterPos3iv(Imports.RasterPos3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3s(Int16 x, Int16 y, Int16 z);
        internal static RasterPos3s glRasterPos3s = (RasterPos3s)GL.GetDelegateForExtensionMethod("glRasterPos3s", typeof(RasterPos3s)) ?? new RasterPos3s(Imports.RasterPos3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3sv(Int16* v);
        internal unsafe static RasterPos3sv glRasterPos3sv = (RasterPos3sv)GL.GetDelegateForExtensionMethod("glRasterPos3sv", typeof(RasterPos3sv)) ?? new RasterPos3sv(Imports.RasterPos3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4d(Double x, Double y, Double z, Double w);
        internal static RasterPos4d glRasterPos4d = (RasterPos4d)GL.GetDelegateForExtensionMethod("glRasterPos4d", typeof(RasterPos4d)) ?? new RasterPos4d(Imports.RasterPos4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4dv(Double* v);
        internal unsafe static RasterPos4dv glRasterPos4dv = (RasterPos4dv)GL.GetDelegateForExtensionMethod("glRasterPos4dv", typeof(RasterPos4dv)) ?? new RasterPos4dv(Imports.RasterPos4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4f(Single x, Single y, Single z, Single w);
        internal static RasterPos4f glRasterPos4f = (RasterPos4f)GL.GetDelegateForExtensionMethod("glRasterPos4f", typeof(RasterPos4f)) ?? new RasterPos4f(Imports.RasterPos4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4fv(Single* v);
        internal unsafe static RasterPos4fv glRasterPos4fv = (RasterPos4fv)GL.GetDelegateForExtensionMethod("glRasterPos4fv", typeof(RasterPos4fv)) ?? new RasterPos4fv(Imports.RasterPos4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
        internal static RasterPos4i glRasterPos4i = (RasterPos4i)GL.GetDelegateForExtensionMethod("glRasterPos4i", typeof(RasterPos4i)) ?? new RasterPos4i(Imports.RasterPos4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4iv(Int32* v);
        internal unsafe static RasterPos4iv glRasterPos4iv = (RasterPos4iv)GL.GetDelegateForExtensionMethod("glRasterPos4iv", typeof(RasterPos4iv)) ?? new RasterPos4iv(Imports.RasterPos4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
        internal static RasterPos4s glRasterPos4s = (RasterPos4s)GL.GetDelegateForExtensionMethod("glRasterPos4s", typeof(RasterPos4s)) ?? new RasterPos4s(Imports.RasterPos4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4sv(Int16* v);
        internal unsafe static RasterPos4sv glRasterPos4sv = (RasterPos4sv)GL.GetDelegateForExtensionMethod("glRasterPos4sv", typeof(RasterPos4sv)) ?? new RasterPos4sv(Imports.RasterPos4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rectd(Double x1, Double y1, Double x2, Double y2);
        internal static Rectd glRectd = (Rectd)GL.GetDelegateForExtensionMethod("glRectd", typeof(Rectd)) ?? new Rectd(Imports.Rectd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectdv(Double* v1, Double* v2);
        internal unsafe static Rectdv glRectdv = (Rectdv)GL.GetDelegateForExtensionMethod("glRectdv", typeof(Rectdv)) ?? new Rectdv(Imports.Rectdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rectf(Single x1, Single y1, Single x2, Single y2);
        internal static Rectf glRectf = (Rectf)GL.GetDelegateForExtensionMethod("glRectf", typeof(Rectf)) ?? new Rectf(Imports.Rectf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectfv(Single* v1, Single* v2);
        internal unsafe static Rectfv glRectfv = (Rectfv)GL.GetDelegateForExtensionMethod("glRectfv", typeof(Rectfv)) ?? new Rectfv(Imports.Rectfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
        internal static Recti glRecti = (Recti)GL.GetDelegateForExtensionMethod("glRecti", typeof(Recti)) ?? new Recti(Imports.Recti);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectiv(Int32* v1, Int32* v2);
        internal unsafe static Rectiv glRectiv = (Rectiv)GL.GetDelegateForExtensionMethod("glRectiv", typeof(Rectiv)) ?? new Rectiv(Imports.Rectiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
        internal static Rects glRects = (Rects)GL.GetDelegateForExtensionMethod("glRects", typeof(Rects)) ?? new Rects(Imports.Rects);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectsv(Int16* v1, Int16* v2);
        internal unsafe static Rectsv glRectsv = (Rectsv)GL.GetDelegateForExtensionMethod("glRectsv", typeof(Rectsv)) ?? new Rectsv(Imports.Rectsv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1d(Double s);
        internal static TexCoord1d glTexCoord1d = (TexCoord1d)GL.GetDelegateForExtensionMethod("glTexCoord1d", typeof(TexCoord1d)) ?? new TexCoord1d(Imports.TexCoord1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1dv(Double* v);
        internal unsafe static TexCoord1dv glTexCoord1dv = (TexCoord1dv)GL.GetDelegateForExtensionMethod("glTexCoord1dv", typeof(TexCoord1dv)) ?? new TexCoord1dv(Imports.TexCoord1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1f(Single s);
        internal static TexCoord1f glTexCoord1f = (TexCoord1f)GL.GetDelegateForExtensionMethod("glTexCoord1f", typeof(TexCoord1f)) ?? new TexCoord1f(Imports.TexCoord1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1fv(Single* v);
        internal unsafe static TexCoord1fv glTexCoord1fv = (TexCoord1fv)GL.GetDelegateForExtensionMethod("glTexCoord1fv", typeof(TexCoord1fv)) ?? new TexCoord1fv(Imports.TexCoord1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1i(Int32 s);
        internal static TexCoord1i glTexCoord1i = (TexCoord1i)GL.GetDelegateForExtensionMethod("glTexCoord1i", typeof(TexCoord1i)) ?? new TexCoord1i(Imports.TexCoord1i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1iv(Int32* v);
        internal unsafe static TexCoord1iv glTexCoord1iv = (TexCoord1iv)GL.GetDelegateForExtensionMethod("glTexCoord1iv", typeof(TexCoord1iv)) ?? new TexCoord1iv(Imports.TexCoord1iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1s(Int16 s);
        internal static TexCoord1s glTexCoord1s = (TexCoord1s)GL.GetDelegateForExtensionMethod("glTexCoord1s", typeof(TexCoord1s)) ?? new TexCoord1s(Imports.TexCoord1s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1sv(Int16* v);
        internal unsafe static TexCoord1sv glTexCoord1sv = (TexCoord1sv)GL.GetDelegateForExtensionMethod("glTexCoord1sv", typeof(TexCoord1sv)) ?? new TexCoord1sv(Imports.TexCoord1sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2d(Double s, Double t);
        internal static TexCoord2d glTexCoord2d = (TexCoord2d)GL.GetDelegateForExtensionMethod("glTexCoord2d", typeof(TexCoord2d)) ?? new TexCoord2d(Imports.TexCoord2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2dv(Double* v);
        internal unsafe static TexCoord2dv glTexCoord2dv = (TexCoord2dv)GL.GetDelegateForExtensionMethod("glTexCoord2dv", typeof(TexCoord2dv)) ?? new TexCoord2dv(Imports.TexCoord2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2f(Single s, Single t);
        internal static TexCoord2f glTexCoord2f = (TexCoord2f)GL.GetDelegateForExtensionMethod("glTexCoord2f", typeof(TexCoord2f)) ?? new TexCoord2f(Imports.TexCoord2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fv(Single* v);
        internal unsafe static TexCoord2fv glTexCoord2fv = (TexCoord2fv)GL.GetDelegateForExtensionMethod("glTexCoord2fv", typeof(TexCoord2fv)) ?? new TexCoord2fv(Imports.TexCoord2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2i(Int32 s, Int32 t);
        internal static TexCoord2i glTexCoord2i = (TexCoord2i)GL.GetDelegateForExtensionMethod("glTexCoord2i", typeof(TexCoord2i)) ?? new TexCoord2i(Imports.TexCoord2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2iv(Int32* v);
        internal unsafe static TexCoord2iv glTexCoord2iv = (TexCoord2iv)GL.GetDelegateForExtensionMethod("glTexCoord2iv", typeof(TexCoord2iv)) ?? new TexCoord2iv(Imports.TexCoord2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2s(Int16 s, Int16 t);
        internal static TexCoord2s glTexCoord2s = (TexCoord2s)GL.GetDelegateForExtensionMethod("glTexCoord2s", typeof(TexCoord2s)) ?? new TexCoord2s(Imports.TexCoord2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2sv(Int16* v);
        internal unsafe static TexCoord2sv glTexCoord2sv = (TexCoord2sv)GL.GetDelegateForExtensionMethod("glTexCoord2sv", typeof(TexCoord2sv)) ?? new TexCoord2sv(Imports.TexCoord2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3d(Double s, Double t, Double r);
        internal static TexCoord3d glTexCoord3d = (TexCoord3d)GL.GetDelegateForExtensionMethod("glTexCoord3d", typeof(TexCoord3d)) ?? new TexCoord3d(Imports.TexCoord3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3dv(Double* v);
        internal unsafe static TexCoord3dv glTexCoord3dv = (TexCoord3dv)GL.GetDelegateForExtensionMethod("glTexCoord3dv", typeof(TexCoord3dv)) ?? new TexCoord3dv(Imports.TexCoord3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3f(Single s, Single t, Single r);
        internal static TexCoord3f glTexCoord3f = (TexCoord3f)GL.GetDelegateForExtensionMethod("glTexCoord3f", typeof(TexCoord3f)) ?? new TexCoord3f(Imports.TexCoord3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3fv(Single* v);
        internal unsafe static TexCoord3fv glTexCoord3fv = (TexCoord3fv)GL.GetDelegateForExtensionMethod("glTexCoord3fv", typeof(TexCoord3fv)) ?? new TexCoord3fv(Imports.TexCoord3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3i(Int32 s, Int32 t, Int32 r);
        internal static TexCoord3i glTexCoord3i = (TexCoord3i)GL.GetDelegateForExtensionMethod("glTexCoord3i", typeof(TexCoord3i)) ?? new TexCoord3i(Imports.TexCoord3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3iv(Int32* v);
        internal unsafe static TexCoord3iv glTexCoord3iv = (TexCoord3iv)GL.GetDelegateForExtensionMethod("glTexCoord3iv", typeof(TexCoord3iv)) ?? new TexCoord3iv(Imports.TexCoord3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3s(Int16 s, Int16 t, Int16 r);
        internal static TexCoord3s glTexCoord3s = (TexCoord3s)GL.GetDelegateForExtensionMethod("glTexCoord3s", typeof(TexCoord3s)) ?? new TexCoord3s(Imports.TexCoord3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3sv(Int16* v);
        internal unsafe static TexCoord3sv glTexCoord3sv = (TexCoord3sv)GL.GetDelegateForExtensionMethod("glTexCoord3sv", typeof(TexCoord3sv)) ?? new TexCoord3sv(Imports.TexCoord3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4d(Double s, Double t, Double r, Double q);
        internal static TexCoord4d glTexCoord4d = (TexCoord4d)GL.GetDelegateForExtensionMethod("glTexCoord4d", typeof(TexCoord4d)) ?? new TexCoord4d(Imports.TexCoord4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4dv(Double* v);
        internal unsafe static TexCoord4dv glTexCoord4dv = (TexCoord4dv)GL.GetDelegateForExtensionMethod("glTexCoord4dv", typeof(TexCoord4dv)) ?? new TexCoord4dv(Imports.TexCoord4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4f(Single s, Single t, Single r, Single q);
        internal static TexCoord4f glTexCoord4f = (TexCoord4f)GL.GetDelegateForExtensionMethod("glTexCoord4f", typeof(TexCoord4f)) ?? new TexCoord4f(Imports.TexCoord4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fv(Single* v);
        internal unsafe static TexCoord4fv glTexCoord4fv = (TexCoord4fv)GL.GetDelegateForExtensionMethod("glTexCoord4fv", typeof(TexCoord4fv)) ?? new TexCoord4fv(Imports.TexCoord4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
        internal static TexCoord4i glTexCoord4i = (TexCoord4i)GL.GetDelegateForExtensionMethod("glTexCoord4i", typeof(TexCoord4i)) ?? new TexCoord4i(Imports.TexCoord4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4iv(Int32* v);
        internal unsafe static TexCoord4iv glTexCoord4iv = (TexCoord4iv)GL.GetDelegateForExtensionMethod("glTexCoord4iv", typeof(TexCoord4iv)) ?? new TexCoord4iv(Imports.TexCoord4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
        internal static TexCoord4s glTexCoord4s = (TexCoord4s)GL.GetDelegateForExtensionMethod("glTexCoord4s", typeof(TexCoord4s)) ?? new TexCoord4s(Imports.TexCoord4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4sv(Int16* v);
        internal unsafe static TexCoord4sv glTexCoord4sv = (TexCoord4sv)GL.GetDelegateForExtensionMethod("glTexCoord4sv", typeof(TexCoord4sv)) ?? new TexCoord4sv(Imports.TexCoord4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2d(Double x, Double y);
        internal static Vertex2d glVertex2d = (Vertex2d)GL.GetDelegateForExtensionMethod("glVertex2d", typeof(Vertex2d)) ?? new Vertex2d(Imports.Vertex2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2dv(Double* v);
        internal unsafe static Vertex2dv glVertex2dv = (Vertex2dv)GL.GetDelegateForExtensionMethod("glVertex2dv", typeof(Vertex2dv)) ?? new Vertex2dv(Imports.Vertex2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2f(Single x, Single y);
        internal static Vertex2f glVertex2f = (Vertex2f)GL.GetDelegateForExtensionMethod("glVertex2f", typeof(Vertex2f)) ?? new Vertex2f(Imports.Vertex2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2fv(Single* v);
        internal unsafe static Vertex2fv glVertex2fv = (Vertex2fv)GL.GetDelegateForExtensionMethod("glVertex2fv", typeof(Vertex2fv)) ?? new Vertex2fv(Imports.Vertex2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2i(Int32 x, Int32 y);
        internal static Vertex2i glVertex2i = (Vertex2i)GL.GetDelegateForExtensionMethod("glVertex2i", typeof(Vertex2i)) ?? new Vertex2i(Imports.Vertex2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2iv(Int32* v);
        internal unsafe static Vertex2iv glVertex2iv = (Vertex2iv)GL.GetDelegateForExtensionMethod("glVertex2iv", typeof(Vertex2iv)) ?? new Vertex2iv(Imports.Vertex2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2s(Int16 x, Int16 y);
        internal static Vertex2s glVertex2s = (Vertex2s)GL.GetDelegateForExtensionMethod("glVertex2s", typeof(Vertex2s)) ?? new Vertex2s(Imports.Vertex2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2sv(Int16* v);
        internal unsafe static Vertex2sv glVertex2sv = (Vertex2sv)GL.GetDelegateForExtensionMethod("glVertex2sv", typeof(Vertex2sv)) ?? new Vertex2sv(Imports.Vertex2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3d(Double x, Double y, Double z);
        internal static Vertex3d glVertex3d = (Vertex3d)GL.GetDelegateForExtensionMethod("glVertex3d", typeof(Vertex3d)) ?? new Vertex3d(Imports.Vertex3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3dv(Double* v);
        internal unsafe static Vertex3dv glVertex3dv = (Vertex3dv)GL.GetDelegateForExtensionMethod("glVertex3dv", typeof(Vertex3dv)) ?? new Vertex3dv(Imports.Vertex3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3f(Single x, Single y, Single z);
        internal static Vertex3f glVertex3f = (Vertex3f)GL.GetDelegateForExtensionMethod("glVertex3f", typeof(Vertex3f)) ?? new Vertex3f(Imports.Vertex3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3fv(Single* v);
        internal unsafe static Vertex3fv glVertex3fv = (Vertex3fv)GL.GetDelegateForExtensionMethod("glVertex3fv", typeof(Vertex3fv)) ?? new Vertex3fv(Imports.Vertex3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3i(Int32 x, Int32 y, Int32 z);
        internal static Vertex3i glVertex3i = (Vertex3i)GL.GetDelegateForExtensionMethod("glVertex3i", typeof(Vertex3i)) ?? new Vertex3i(Imports.Vertex3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3iv(Int32* v);
        internal unsafe static Vertex3iv glVertex3iv = (Vertex3iv)GL.GetDelegateForExtensionMethod("glVertex3iv", typeof(Vertex3iv)) ?? new Vertex3iv(Imports.Vertex3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3s(Int16 x, Int16 y, Int16 z);
        internal static Vertex3s glVertex3s = (Vertex3s)GL.GetDelegateForExtensionMethod("glVertex3s", typeof(Vertex3s)) ?? new Vertex3s(Imports.Vertex3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3sv(Int16* v);
        internal unsafe static Vertex3sv glVertex3sv = (Vertex3sv)GL.GetDelegateForExtensionMethod("glVertex3sv", typeof(Vertex3sv)) ?? new Vertex3sv(Imports.Vertex3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4d(Double x, Double y, Double z, Double w);
        internal static Vertex4d glVertex4d = (Vertex4d)GL.GetDelegateForExtensionMethod("glVertex4d", typeof(Vertex4d)) ?? new Vertex4d(Imports.Vertex4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4dv(Double* v);
        internal unsafe static Vertex4dv glVertex4dv = (Vertex4dv)GL.GetDelegateForExtensionMethod("glVertex4dv", typeof(Vertex4dv)) ?? new Vertex4dv(Imports.Vertex4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4f(Single x, Single y, Single z, Single w);
        internal static Vertex4f glVertex4f = (Vertex4f)GL.GetDelegateForExtensionMethod("glVertex4f", typeof(Vertex4f)) ?? new Vertex4f(Imports.Vertex4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4fv(Single* v);
        internal unsafe static Vertex4fv glVertex4fv = (Vertex4fv)GL.GetDelegateForExtensionMethod("glVertex4fv", typeof(Vertex4fv)) ?? new Vertex4fv(Imports.Vertex4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
        internal static Vertex4i glVertex4i = (Vertex4i)GL.GetDelegateForExtensionMethod("glVertex4i", typeof(Vertex4i)) ?? new Vertex4i(Imports.Vertex4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4iv(Int32* v);
        internal unsafe static Vertex4iv glVertex4iv = (Vertex4iv)GL.GetDelegateForExtensionMethod("glVertex4iv", typeof(Vertex4iv)) ?? new Vertex4iv(Imports.Vertex4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
        internal static Vertex4s glVertex4s = (Vertex4s)GL.GetDelegateForExtensionMethod("glVertex4s", typeof(Vertex4s)) ?? new Vertex4s(Imports.Vertex4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4sv(Int16* v);
        internal unsafe static Vertex4sv glVertex4sv = (Vertex4sv)GL.GetDelegateForExtensionMethod("glVertex4sv", typeof(Vertex4sv)) ?? new Vertex4sv(Imports.Vertex4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ClipPlane(GL.Enums.ClipPlaneName plane, Double* equation);
        internal unsafe static ClipPlane glClipPlane = (ClipPlane)GL.GetDelegateForExtensionMethod("glClipPlane", typeof(ClipPlane)) ?? new ClipPlane(Imports.ClipPlane);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaterial(GL.Enums.MaterialFace face, GL.Enums.ColorMaterialParameter mode);
        internal static ColorMaterial glColorMaterial = (ColorMaterial)GL.GetDelegateForExtensionMethod("glColorMaterial", typeof(ColorMaterial)) ?? new ColorMaterial(Imports.ColorMaterial);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CullFace(GL.Enums.CullFaceMode mode);
        internal static CullFace glCullFace = (CullFace)GL.GetDelegateForExtensionMethod("glCullFace", typeof(CullFace)) ?? new CullFace(Imports.CullFace);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Fogf(GL.Enums.FogParameter pname, Single param);
        internal static Fogf glFogf = (Fogf)GL.GetDelegateForExtensionMethod("glFogf", typeof(Fogf)) ?? new Fogf(Imports.Fogf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Fogfv(GL.Enums.FogParameter pname, Single* @params);
        internal unsafe static Fogfv glFogfv = (Fogfv)GL.GetDelegateForExtensionMethod("glFogfv", typeof(Fogfv)) ?? new Fogfv(Imports.Fogfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Fogi(GL.Enums.FogParameter pname, Int32 param);
        internal static Fogi glFogi = (Fogi)GL.GetDelegateForExtensionMethod("glFogi", typeof(Fogi)) ?? new Fogi(Imports.Fogi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Fogiv(GL.Enums.FogParameter pname, Int32* @params);
        internal unsafe static Fogiv glFogiv = (Fogiv)GL.GetDelegateForExtensionMethod("glFogiv", typeof(Fogiv)) ?? new Fogiv(Imports.Fogiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrontFace(GL.Enums.FrontFaceDirection mode);
        internal static FrontFace glFrontFace = (FrontFace)GL.GetDelegateForExtensionMethod("glFrontFace", typeof(FrontFace)) ?? new FrontFace(Imports.FrontFace);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Hint(GL.Enums.HintTarget target, GL.Enums.HintMode mode);
        internal static Hint glHint = (Hint)GL.GetDelegateForExtensionMethod("glHint", typeof(Hint)) ?? new Hint(Imports.Hint);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Lightf(GL.Enums.LightName light, GL.Enums.LightParameter pname, Single param);
        internal static Lightf glLightf = (Lightf)GL.GetDelegateForExtensionMethod("glLightf", typeof(Lightf)) ?? new Lightf(Imports.Lightf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Lightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, Single* @params);
        internal unsafe static Lightfv glLightfv = (Lightfv)GL.GetDelegateForExtensionMethod("glLightfv", typeof(Lightfv)) ?? new Lightfv(Imports.Lightfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Lighti(GL.Enums.LightName light, GL.Enums.LightParameter pname, Int32 param);
        internal static Lighti glLighti = (Lighti)GL.GetDelegateForExtensionMethod("glLighti", typeof(Lighti)) ?? new Lighti(Imports.Lighti);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Lightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, Int32* @params);
        internal unsafe static Lightiv glLightiv = (Lightiv)GL.GetDelegateForExtensionMethod("glLightiv", typeof(Lightiv)) ?? new Lightiv(Imports.Lightiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightModelf(GL.Enums.LightModelParameter pname, Single param);
        internal static LightModelf glLightModelf = (LightModelf)GL.GetDelegateForExtensionMethod("glLightModelf", typeof(LightModelf)) ?? new LightModelf(Imports.LightModelf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LightModelfv(GL.Enums.LightModelParameter pname, Single* @params);
        internal unsafe static LightModelfv glLightModelfv = (LightModelfv)GL.GetDelegateForExtensionMethod("glLightModelfv", typeof(LightModelfv)) ?? new LightModelfv(Imports.LightModelfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightModeli(GL.Enums.LightModelParameter pname, Int32 param);
        internal static LightModeli glLightModeli = (LightModeli)GL.GetDelegateForExtensionMethod("glLightModeli", typeof(LightModeli)) ?? new LightModeli(Imports.LightModeli);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LightModeliv(GL.Enums.LightModelParameter pname, Int32* @params);
        internal unsafe static LightModeliv glLightModeliv = (LightModeliv)GL.GetDelegateForExtensionMethod("glLightModeliv", typeof(LightModeliv)) ?? new LightModeliv(Imports.LightModeliv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineStipple(Int32 factor, UInt16 pattern);
        internal static LineStipple glLineStipple = (LineStipple)GL.GetDelegateForExtensionMethod("glLineStipple", typeof(LineStipple)) ?? new LineStipple(Imports.LineStipple);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineWidth(Single width);
        internal static LineWidth glLineWidth = (LineWidth)GL.GetDelegateForExtensionMethod("glLineWidth", typeof(LineWidth)) ?? new LineWidth(Imports.LineWidth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Materialf(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single param);
        internal static Materialf glMaterialf = (Materialf)GL.GetDelegateForExtensionMethod("glMaterialf", typeof(Materialf)) ?? new Materialf(Imports.Materialf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Materialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single* @params);
        internal unsafe static Materialfv glMaterialfv = (Materialfv)GL.GetDelegateForExtensionMethod("glMaterialfv", typeof(Materialfv)) ?? new Materialfv(Imports.Materialfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Materiali(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32 param);
        internal static Materiali glMateriali = (Materiali)GL.GetDelegateForExtensionMethod("glMateriali", typeof(Materiali)) ?? new Materiali(Imports.Materiali);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Materialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32* @params);
        internal unsafe static Materialiv glMaterialiv = (Materialiv)GL.GetDelegateForExtensionMethod("glMaterialiv", typeof(Materialiv)) ?? new Materialiv(Imports.Materialiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointSize(Single size);
        internal static PointSize glPointSize = (PointSize)GL.GetDelegateForExtensionMethod("glPointSize", typeof(PointSize)) ?? new PointSize(Imports.PointSize);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonMode(GL.Enums.MaterialFace face, GL.Enums.PolygonMode mode);
        internal static PolygonMode glPolygonMode = (PolygonMode)GL.GetDelegateForExtensionMethod("glPolygonMode", typeof(PolygonMode)) ?? new PolygonMode(Imports.PolygonMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PolygonStipple(Byte* mask);
        internal unsafe static PolygonStipple glPolygonStipple = (PolygonStipple)GL.GetDelegateForExtensionMethod("glPolygonStipple", typeof(PolygonStipple)) ?? new PolygonStipple(Imports.PolygonStipple);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
        internal static Scissor glScissor = (Scissor)GL.GetDelegateForExtensionMethod("glScissor", typeof(Scissor)) ?? new Scissor(Imports.Scissor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShadeModel(GL.Enums.ShadingModel mode);
        internal static ShadeModel glShadeModel = (ShadeModel)GL.GetDelegateForExtensionMethod("glShadeModel", typeof(ShadeModel)) ?? new ShadeModel(Imports.ShadeModel);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameterf(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Single param);
        internal static TexParameterf glTexParameterf = (TexParameterf)GL.GetDelegateForExtensionMethod("glTexParameterf", typeof(TexParameterf)) ?? new TexParameterf(Imports.TexParameterf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterfv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Single* @params);
        internal unsafe static TexParameterfv glTexParameterfv = (TexParameterfv)GL.GetDelegateForExtensionMethod("glTexParameterfv", typeof(TexParameterfv)) ?? new TexParameterfv(Imports.TexParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameteri(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Int32 param);
        internal static TexParameteri glTexParameteri = (TexParameteri)GL.GetDelegateForExtensionMethod("glTexParameteri", typeof(TexParameteri)) ?? new TexParameteri(Imports.TexParameteri);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameteriv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Int32* @params);
        internal unsafe static TexParameteriv glTexParameteriv = (TexParameteriv)GL.GetDelegateForExtensionMethod("glTexParameteriv", typeof(TexParameteriv)) ?? new TexParameteriv(Imports.TexParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexImage1D glTexImage1D = (TexImage1D)GL.GetDelegateForExtensionMethod("glTexImage1D", typeof(TexImage1D)) ?? new TexImage1D(Imports.TexImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexImage2D glTexImage2D = (TexImage2D)GL.GetDelegateForExtensionMethod("glTexImage2D", typeof(TexImage2D)) ?? new TexImage2D(Imports.TexImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexEnvf(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Single param);
        internal static TexEnvf glTexEnvf = (TexEnvf)GL.GetDelegateForExtensionMethod("glTexEnvf", typeof(TexEnvf)) ?? new TexEnvf(Imports.TexEnvf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Single* @params);
        internal unsafe static TexEnvfv glTexEnvfv = (TexEnvfv)GL.GetDelegateForExtensionMethod("glTexEnvfv", typeof(TexEnvfv)) ?? new TexEnvfv(Imports.TexEnvfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexEnvi(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Int32 param);
        internal static TexEnvi glTexEnvi = (TexEnvi)GL.GetDelegateForExtensionMethod("glTexEnvi", typeof(TexEnvi)) ?? new TexEnvi(Imports.TexEnvi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Int32* @params);
        internal unsafe static TexEnviv glTexEnviv = (TexEnviv)GL.GetDelegateForExtensionMethod("glTexEnviv", typeof(TexEnviv)) ?? new TexEnviv(Imports.TexEnviv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGend(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Double param);
        internal static TexGend glTexGend = (TexGend)GL.GetDelegateForExtensionMethod("glTexGend", typeof(TexGend)) ?? new TexGend(Imports.TexGend);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Double* @params);
        internal unsafe static TexGendv glTexGendv = (TexGendv)GL.GetDelegateForExtensionMethod("glTexGendv", typeof(TexGendv)) ?? new TexGendv(Imports.TexGendv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGenf(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Single param);
        internal static TexGenf glTexGenf = (TexGenf)GL.GetDelegateForExtensionMethod("glTexGenf", typeof(TexGenf)) ?? new TexGenf(Imports.TexGenf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Single* @params);
        internal unsafe static TexGenfv glTexGenfv = (TexGenfv)GL.GetDelegateForExtensionMethod("glTexGenfv", typeof(TexGenfv)) ?? new TexGenfv(Imports.TexGenfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGeni(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Int32 param);
        internal static TexGeni glTexGeni = (TexGeni)GL.GetDelegateForExtensionMethod("glTexGeni", typeof(TexGeni)) ?? new TexGeni(Imports.TexGeni);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Int32* @params);
        internal unsafe static TexGeniv glTexGeniv = (TexGeniv)GL.GetDelegateForExtensionMethod("glTexGeniv", typeof(TexGeniv)) ?? new TexGeniv(Imports.TexGeniv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FeedbackBuffer(Int32 size, GL.Enums.FeedbackType type, [Out] Single* buffer);
        internal unsafe static FeedbackBuffer glFeedbackBuffer = (FeedbackBuffer)GL.GetDelegateForExtensionMethod("glFeedbackBuffer", typeof(FeedbackBuffer)) ?? new FeedbackBuffer(Imports.FeedbackBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SelectBuffer(Int32 size, [Out] UInt32* buffer);
        internal unsafe static SelectBuffer glSelectBuffer = (SelectBuffer)GL.GetDelegateForExtensionMethod("glSelectBuffer", typeof(SelectBuffer)) ?? new SelectBuffer(Imports.SelectBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 RenderMode(GL.Enums.RenderingMode mode);
        internal static RenderMode glRenderMode = (RenderMode)GL.GetDelegateForExtensionMethod("glRenderMode", typeof(RenderMode)) ?? new RenderMode(Imports.RenderMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InitNames();
        internal static InitNames glInitNames = (InitNames)GL.GetDelegateForExtensionMethod("glInitNames", typeof(InitNames)) ?? new InitNames(Imports.InitNames);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadName(UInt32 name);
        internal static LoadName glLoadName = (LoadName)GL.GetDelegateForExtensionMethod("glLoadName", typeof(LoadName)) ?? new LoadName(Imports.LoadName);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PassThrough(Single token);
        internal static PassThrough glPassThrough = (PassThrough)GL.GetDelegateForExtensionMethod("glPassThrough", typeof(PassThrough)) ?? new PassThrough(Imports.PassThrough);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopName();
        internal static PopName glPopName = (PopName)GL.GetDelegateForExtensionMethod("glPopName", typeof(PopName)) ?? new PopName(Imports.PopName);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushName(UInt32 name);
        internal static PushName glPushName = (PushName)GL.GetDelegateForExtensionMethod("glPushName", typeof(PushName)) ?? new PushName(Imports.PushName);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawBuffer(GL.Enums.DrawBufferMode mode);
        internal static DrawBuffer glDrawBuffer = (DrawBuffer)GL.GetDelegateForExtensionMethod("glDrawBuffer", typeof(DrawBuffer)) ?? new DrawBuffer(Imports.DrawBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Clear(GL.Enums.ClearBufferMask mask);
        internal static Clear glClear = (Clear)GL.GetDelegateForExtensionMethod("glClear", typeof(Clear)) ?? new Clear(Imports.Clear);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearAccum(Single red, Single green, Single blue, Single alpha);
        internal static ClearAccum glClearAccum = (ClearAccum)GL.GetDelegateForExtensionMethod("glClearAccum", typeof(ClearAccum)) ?? new ClearAccum(Imports.ClearAccum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearIndex(Single c);
        internal static ClearIndex glClearIndex = (ClearIndex)GL.GetDelegateForExtensionMethod("glClearIndex", typeof(ClearIndex)) ?? new ClearIndex(Imports.ClearIndex);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
        internal static ClearColor glClearColor = (ClearColor)GL.GetDelegateForExtensionMethod("glClearColor", typeof(ClearColor)) ?? new ClearColor(Imports.ClearColor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearStencil(Int32 s);
        internal static ClearStencil glClearStencil = (ClearStencil)GL.GetDelegateForExtensionMethod("glClearStencil", typeof(ClearStencil)) ?? new ClearStencil(Imports.ClearStencil);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepth(Double depth);
        internal static ClearDepth glClearDepth = (ClearDepth)GL.GetDelegateForExtensionMethod("glClearDepth", typeof(ClearDepth)) ?? new ClearDepth(Imports.ClearDepth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMask(UInt32 mask);
        internal static StencilMask glStencilMask = (StencilMask)GL.GetDelegateForExtensionMethod("glStencilMask", typeof(StencilMask)) ?? new StencilMask(Imports.StencilMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMask(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
        internal static ColorMask glColorMask = (ColorMask)GL.GetDelegateForExtensionMethod("glColorMask", typeof(ColorMask)) ?? new ColorMask(Imports.ColorMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthMask(GL.Enums.Boolean flag);
        internal static DepthMask glDepthMask = (DepthMask)GL.GetDelegateForExtensionMethod("glDepthMask", typeof(DepthMask)) ?? new DepthMask(Imports.DepthMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexMask(UInt32 mask);
        internal static IndexMask glIndexMask = (IndexMask)GL.GetDelegateForExtensionMethod("glIndexMask", typeof(IndexMask)) ?? new IndexMask(Imports.IndexMask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Accum(GL.Enums.AccumOp op, Single value);
        internal static Accum glAccum = (Accum)GL.GetDelegateForExtensionMethod("glAccum", typeof(Accum)) ?? new Accum(Imports.Accum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Disable(GL.Enums.EnableCap cap);
        internal static Disable glDisable = (Disable)GL.GetDelegateForExtensionMethod("glDisable", typeof(Disable)) ?? new Disable(Imports.Disable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Enable(GL.Enums.EnableCap cap);
        internal static Enable glEnable = (Enable)GL.GetDelegateForExtensionMethod("glEnable", typeof(Enable)) ?? new Enable(Imports.Enable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Finish();
        internal static Finish glFinish = (Finish)GL.GetDelegateForExtensionMethod("glFinish", typeof(Finish)) ?? new Finish(Imports.Finish);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Flush();
        internal static Flush glFlush = (Flush)GL.GetDelegateForExtensionMethod("glFlush", typeof(Flush)) ?? new Flush(Imports.Flush);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopAttrib();
        internal static PopAttrib glPopAttrib = (PopAttrib)GL.GetDelegateForExtensionMethod("glPopAttrib", typeof(PopAttrib)) ?? new PopAttrib(Imports.PopAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushAttrib(GL.Enums.AttribMask mask);
        internal static PushAttrib glPushAttrib = (PushAttrib)GL.GetDelegateForExtensionMethod("glPushAttrib", typeof(PushAttrib)) ?? new PushAttrib(Imports.PushAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map1d(GL.Enums.MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
        internal unsafe static Map1d glMap1d = (Map1d)GL.GetDelegateForExtensionMethod("glMap1d", typeof(Map1d)) ?? new Map1d(Imports.Map1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map1f(GL.Enums.MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
        internal unsafe static Map1f glMap1f = (Map1f)GL.GetDelegateForExtensionMethod("glMap1f", typeof(Map1f)) ?? new Map1f(Imports.Map1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map2d(GL.Enums.MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
        internal unsafe static Map2d glMap2d = (Map2d)GL.GetDelegateForExtensionMethod("glMap2d", typeof(Map2d)) ?? new Map2d(Imports.Map2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map2f(GL.Enums.MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
        internal unsafe static Map2f glMap2f = (Map2f)GL.GetDelegateForExtensionMethod("glMap2f", typeof(Map2f)) ?? new Map2f(Imports.Map2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid1d(Int32 un, Double u1, Double u2);
        internal static MapGrid1d glMapGrid1d = (MapGrid1d)GL.GetDelegateForExtensionMethod("glMapGrid1d", typeof(MapGrid1d)) ?? new MapGrid1d(Imports.MapGrid1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid1f(Int32 un, Single u1, Single u2);
        internal static MapGrid1f glMapGrid1f = (MapGrid1f)GL.GetDelegateForExtensionMethod("glMapGrid1f", typeof(MapGrid1f)) ?? new MapGrid1f(Imports.MapGrid1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
        internal static MapGrid2d glMapGrid2d = (MapGrid2d)GL.GetDelegateForExtensionMethod("glMapGrid2d", typeof(MapGrid2d)) ?? new MapGrid2d(Imports.MapGrid2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
        internal static MapGrid2f glMapGrid2f = (MapGrid2f)GL.GetDelegateForExtensionMethod("glMapGrid2f", typeof(MapGrid2f)) ?? new MapGrid2f(Imports.MapGrid2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord1d(Double u);
        internal static EvalCoord1d glEvalCoord1d = (EvalCoord1d)GL.GetDelegateForExtensionMethod("glEvalCoord1d", typeof(EvalCoord1d)) ?? new EvalCoord1d(Imports.EvalCoord1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord1dv(Double* u);
        internal unsafe static EvalCoord1dv glEvalCoord1dv = (EvalCoord1dv)GL.GetDelegateForExtensionMethod("glEvalCoord1dv", typeof(EvalCoord1dv)) ?? new EvalCoord1dv(Imports.EvalCoord1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord1f(Single u);
        internal static EvalCoord1f glEvalCoord1f = (EvalCoord1f)GL.GetDelegateForExtensionMethod("glEvalCoord1f", typeof(EvalCoord1f)) ?? new EvalCoord1f(Imports.EvalCoord1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord1fv(Single* u);
        internal unsafe static EvalCoord1fv glEvalCoord1fv = (EvalCoord1fv)GL.GetDelegateForExtensionMethod("glEvalCoord1fv", typeof(EvalCoord1fv)) ?? new EvalCoord1fv(Imports.EvalCoord1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord2d(Double u, Double v);
        internal static EvalCoord2d glEvalCoord2d = (EvalCoord2d)GL.GetDelegateForExtensionMethod("glEvalCoord2d", typeof(EvalCoord2d)) ?? new EvalCoord2d(Imports.EvalCoord2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord2dv(Double* u);
        internal unsafe static EvalCoord2dv glEvalCoord2dv = (EvalCoord2dv)GL.GetDelegateForExtensionMethod("glEvalCoord2dv", typeof(EvalCoord2dv)) ?? new EvalCoord2dv(Imports.EvalCoord2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord2f(Single u, Single v);
        internal static EvalCoord2f glEvalCoord2f = (EvalCoord2f)GL.GetDelegateForExtensionMethod("glEvalCoord2f", typeof(EvalCoord2f)) ?? new EvalCoord2f(Imports.EvalCoord2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord2fv(Single* u);
        internal unsafe static EvalCoord2fv glEvalCoord2fv = (EvalCoord2fv)GL.GetDelegateForExtensionMethod("glEvalCoord2fv", typeof(EvalCoord2fv)) ?? new EvalCoord2fv(Imports.EvalCoord2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMesh1(GL.Enums.MeshMode1 mode, Int32 i1, Int32 i2);
        internal static EvalMesh1 glEvalMesh1 = (EvalMesh1)GL.GetDelegateForExtensionMethod("glEvalMesh1", typeof(EvalMesh1)) ?? new EvalMesh1(Imports.EvalMesh1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalPoint1(Int32 i);
        internal static EvalPoint1 glEvalPoint1 = (EvalPoint1)GL.GetDelegateForExtensionMethod("glEvalPoint1", typeof(EvalPoint1)) ?? new EvalPoint1(Imports.EvalPoint1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMesh2(GL.Enums.MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
        internal static EvalMesh2 glEvalMesh2 = (EvalMesh2)GL.GetDelegateForExtensionMethod("glEvalMesh2", typeof(EvalMesh2)) ?? new EvalMesh2(Imports.EvalMesh2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalPoint2(Int32 i, Int32 j);
        internal static EvalPoint2 glEvalPoint2 = (EvalPoint2)GL.GetDelegateForExtensionMethod("glEvalPoint2", typeof(EvalPoint2)) ?? new EvalPoint2(Imports.EvalPoint2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFunc(GL.Enums.AlphaFunction func, Single @ref);
        internal static AlphaFunc glAlphaFunc = (AlphaFunc)GL.GetDelegateForExtensionMethod("glAlphaFunc", typeof(AlphaFunc)) ?? new AlphaFunc(Imports.AlphaFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFunc(GL.Enums.BlendingFactorSrc sfactor, GL.Enums.BlendingFactorDest dfactor);
        internal static BlendFunc glBlendFunc = (BlendFunc)GL.GetDelegateForExtensionMethod("glBlendFunc", typeof(BlendFunc)) ?? new BlendFunc(Imports.BlendFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LogicOp(GL.Enums.LogicOp opcode);
        internal static LogicOp glLogicOp = (LogicOp)GL.GetDelegateForExtensionMethod("glLogicOp", typeof(LogicOp)) ?? new LogicOp(Imports.LogicOp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFunc(GL.Enums.StencilFunction func, Int32 @ref, UInt32 mask);
        internal static StencilFunc glStencilFunc = (StencilFunc)GL.GetDelegateForExtensionMethod("glStencilFunc", typeof(StencilFunc)) ?? new StencilFunc(Imports.StencilFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOp(GL.Enums.StencilOp fail, GL.Enums.StencilOp zfail, GL.Enums.StencilOp zpass);
        internal static StencilOp glStencilOp = (StencilOp)GL.GetDelegateForExtensionMethod("glStencilOp", typeof(StencilOp)) ?? new StencilOp(Imports.StencilOp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthFunc(GL.Enums.DepthFunction func);
        internal static DepthFunc glDepthFunc = (DepthFunc)GL.GetDelegateForExtensionMethod("glDepthFunc", typeof(DepthFunc)) ?? new DepthFunc(Imports.DepthFunc);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelZoom(Single xfactor, Single yfactor);
        internal static PixelZoom glPixelZoom = (PixelZoom)GL.GetDelegateForExtensionMethod("glPixelZoom", typeof(PixelZoom)) ?? new PixelZoom(Imports.PixelZoom);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransferf(GL.Enums.PixelTransferParameter pname, Single param);
        internal static PixelTransferf glPixelTransferf = (PixelTransferf)GL.GetDelegateForExtensionMethod("glPixelTransferf", typeof(PixelTransferf)) ?? new PixelTransferf(Imports.PixelTransferf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransferi(GL.Enums.PixelTransferParameter pname, Int32 param);
        internal static PixelTransferi glPixelTransferi = (PixelTransferi)GL.GetDelegateForExtensionMethod("glPixelTransferi", typeof(PixelTransferi)) ?? new PixelTransferi(Imports.PixelTransferi);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStoref(GL.Enums.PixelStoreParameter pname, Single param);
        internal static PixelStoref glPixelStoref = (PixelStoref)GL.GetDelegateForExtensionMethod("glPixelStoref", typeof(PixelStoref)) ?? new PixelStoref(Imports.PixelStoref);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStorei(GL.Enums.PixelStoreParameter pname, Int32 param);
        internal static PixelStorei glPixelStorei = (PixelStorei)GL.GetDelegateForExtensionMethod("glPixelStorei", typeof(PixelStorei)) ?? new PixelStorei(Imports.PixelStorei);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapfv(GL.Enums.PixelMap map, Int32 mapsize, Single* values);
        internal unsafe static PixelMapfv glPixelMapfv = (PixelMapfv)GL.GetDelegateForExtensionMethod("glPixelMapfv", typeof(PixelMapfv)) ?? new PixelMapfv(Imports.PixelMapfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapuiv(GL.Enums.PixelMap map, Int32 mapsize, UInt32* values);
        internal unsafe static PixelMapuiv glPixelMapuiv = (PixelMapuiv)GL.GetDelegateForExtensionMethod("glPixelMapuiv", typeof(PixelMapuiv)) ?? new PixelMapuiv(Imports.PixelMapuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapusv(GL.Enums.PixelMap map, Int32 mapsize, UInt16* values);
        internal unsafe static PixelMapusv glPixelMapusv = (PixelMapusv)GL.GetDelegateForExtensionMethod("glPixelMapusv", typeof(PixelMapusv)) ?? new PixelMapusv(Imports.PixelMapusv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadBuffer(GL.Enums.ReadBufferMode mode);
        internal static ReadBuffer glReadBuffer = (ReadBuffer)GL.GetDelegateForExtensionMethod("glReadBuffer", typeof(ReadBuffer)) ?? new ReadBuffer(Imports.ReadBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, GL.Enums.PixelCopyType type);
        internal static CopyPixels glCopyPixels = (CopyPixels)GL.GetDelegateForExtensionMethod("glCopyPixels", typeof(CopyPixels)) ?? new CopyPixels(Imports.CopyPixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* pixels);
        internal unsafe static ReadPixels glReadPixels = (ReadPixels)GL.GetDelegateForExtensionMethod("glReadPixels", typeof(ReadPixels)) ?? new ReadPixels(Imports.ReadPixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawPixels(Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static DrawPixels glDrawPixels = (DrawPixels)GL.GetDelegateForExtensionMethod("glDrawPixels", typeof(DrawPixels)) ?? new DrawPixels(Imports.DrawPixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanv(GL.Enums.GetPName pname, [Out] GL.Enums.Boolean* @params);
        internal unsafe static GetBooleanv glGetBooleanv = (GetBooleanv)GL.GetDelegateForExtensionMethod("glGetBooleanv", typeof(GetBooleanv)) ?? new GetBooleanv(Imports.GetBooleanv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetClipPlane(GL.Enums.ClipPlaneName plane, [Out] Double* equation);
        internal unsafe static GetClipPlane glGetClipPlane = (GetClipPlane)GL.GetDelegateForExtensionMethod("glGetClipPlane", typeof(GetClipPlane)) ?? new GetClipPlane(Imports.GetClipPlane);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDoublev(GL.Enums.GetPName pname, [Out] Double* @params);
        internal unsafe static GetDoublev glGetDoublev = (GetDoublev)GL.GetDelegateForExtensionMethod("glGetDoublev", typeof(GetDoublev)) ?? new GetDoublev(Imports.GetDoublev);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GL.Enums.All GetError();
        internal static GetError glGetError = (GetError)GL.GetDelegateForExtensionMethod("glGetError", typeof(GetError)) ?? new GetError(Imports.GetError);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFloatv(GL.Enums.GetPName pname, [Out] Single* @params);
        internal unsafe static GetFloatv glGetFloatv = (GetFloatv)GL.GetDelegateForExtensionMethod("glGetFloatv", typeof(GetFloatv)) ?? new GetFloatv(Imports.GetFloatv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerv(GL.Enums.GetPName pname, [Out] Int32* @params);
        internal unsafe static GetIntegerv glGetIntegerv = (GetIntegerv)GL.GetDelegateForExtensionMethod("glGetIntegerv", typeof(GetIntegerv)) ?? new GetIntegerv(Imports.GetIntegerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, [Out] Single* @params);
        internal unsafe static GetLightfv glGetLightfv = (GetLightfv)GL.GetDelegateForExtensionMethod("glGetLightfv", typeof(GetLightfv)) ?? new GetLightfv(Imports.GetLightfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, [Out] Int32* @params);
        internal unsafe static GetLightiv glGetLightiv = (GetLightiv)GL.GetDelegateForExtensionMethod("glGetLightiv", typeof(GetLightiv)) ?? new GetLightiv(Imports.GetLightiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapdv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, [Out] Double* v);
        internal unsafe static GetMapdv glGetMapdv = (GetMapdv)GL.GetDelegateForExtensionMethod("glGetMapdv", typeof(GetMapdv)) ?? new GetMapdv(Imports.GetMapdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapfv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, [Out] Single* v);
        internal unsafe static GetMapfv glGetMapfv = (GetMapfv)GL.GetDelegateForExtensionMethod("glGetMapfv", typeof(GetMapfv)) ?? new GetMapfv(Imports.GetMapfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapiv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, [Out] Int32* v);
        internal unsafe static GetMapiv glGetMapiv = (GetMapiv)GL.GetDelegateForExtensionMethod("glGetMapiv", typeof(GetMapiv)) ?? new GetMapiv(Imports.GetMapiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMaterialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Single* @params);
        internal unsafe static GetMaterialfv glGetMaterialfv = (GetMaterialfv)GL.GetDelegateForExtensionMethod("glGetMaterialfv", typeof(GetMaterialfv)) ?? new GetMaterialfv(Imports.GetMaterialfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMaterialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Int32* @params);
        internal unsafe static GetMaterialiv glGetMaterialiv = (GetMaterialiv)GL.GetDelegateForExtensionMethod("glGetMaterialiv", typeof(GetMaterialiv)) ?? new GetMaterialiv(Imports.GetMaterialiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapfv(GL.Enums.PixelMap map, [Out] Single* values);
        internal unsafe static GetPixelMapfv glGetPixelMapfv = (GetPixelMapfv)GL.GetDelegateForExtensionMethod("glGetPixelMapfv", typeof(GetPixelMapfv)) ?? new GetPixelMapfv(Imports.GetPixelMapfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapuiv(GL.Enums.PixelMap map, [Out] UInt32* values);
        internal unsafe static GetPixelMapuiv glGetPixelMapuiv = (GetPixelMapuiv)GL.GetDelegateForExtensionMethod("glGetPixelMapuiv", typeof(GetPixelMapuiv)) ?? new GetPixelMapuiv(Imports.GetPixelMapuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapusv(GL.Enums.PixelMap map, [Out] UInt16* values);
        internal unsafe static GetPixelMapusv glGetPixelMapusv = (GetPixelMapusv)GL.GetDelegateForExtensionMethod("glGetPixelMapusv", typeof(GetPixelMapusv)) ?? new GetPixelMapusv(Imports.GetPixelMapusv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPolygonStipple([Out] Byte* mask);
        internal unsafe static GetPolygonStipple glGetPolygonStipple = (GetPolygonStipple)GL.GetDelegateForExtensionMethod("glGetPolygonStipple", typeof(GetPolygonStipple)) ?? new GetPolygonStipple(Imports.GetPolygonStipple);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetString(GL.Enums.StringName name);
        internal static GetString glGetString = (GetString)GL.GetDelegateForExtensionMethod("glGetString", typeof(GetString)) ?? new GetString(Imports.GetString);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, [Out] Single* @params);
        internal unsafe static GetTexEnvfv glGetTexEnvfv = (GetTexEnvfv)GL.GetDelegateForExtensionMethod("glGetTexEnvfv", typeof(GetTexEnvfv)) ?? new GetTexEnvfv(Imports.GetTexEnvfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, [Out] Int32* @params);
        internal unsafe static GetTexEnviv glGetTexEnviv = (GetTexEnviv)GL.GetDelegateForExtensionMethod("glGetTexEnviv", typeof(GetTexEnviv)) ?? new GetTexEnviv(Imports.GetTexEnviv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, [Out] Double* @params);
        internal unsafe static GetTexGendv glGetTexGendv = (GetTexGendv)GL.GetDelegateForExtensionMethod("glGetTexGendv", typeof(GetTexGendv)) ?? new GetTexGendv(Imports.GetTexGendv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, [Out] Single* @params);
        internal unsafe static GetTexGenfv glGetTexGenfv = (GetTexGenfv)GL.GetDelegateForExtensionMethod("glGetTexGenfv", typeof(GetTexGenfv)) ?? new GetTexGenfv(Imports.GetTexGenfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, [Out] Int32* @params);
        internal unsafe static GetTexGeniv glGetTexGeniv = (GetTexGeniv)GL.GetDelegateForExtensionMethod("glGetTexGeniv", typeof(GetTexGeniv)) ?? new GetTexGeniv(Imports.GetTexGeniv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexImage(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* pixels);
        internal unsafe static GetTexImage glGetTexImage = (GetTexImage)GL.GetDelegateForExtensionMethod("glGetTexImage", typeof(GetTexImage)) ?? new GetTexImage(Imports.GetTexImage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterfv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] Single* @params);
        internal unsafe static GetTexParameterfv glGetTexParameterfv = (GetTexParameterfv)GL.GetDelegateForExtensionMethod("glGetTexParameterfv", typeof(GetTexParameterfv)) ?? new GetTexParameterfv(Imports.GetTexParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameteriv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] Int32* @params);
        internal unsafe static GetTexParameteriv glGetTexParameteriv = (GetTexParameteriv)GL.GetDelegateForExtensionMethod("glGetTexParameteriv", typeof(GetTexParameteriv)) ?? new GetTexParameteriv(Imports.GetTexParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameterfv(GL.Enums.TextureTarget target, Int32 level, GL.Enums.GetTextureParameter pname, [Out] Single* @params);
        internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv = (GetTexLevelParameterfv)GL.GetDelegateForExtensionMethod("glGetTexLevelParameterfv", typeof(GetTexLevelParameterfv)) ?? new GetTexLevelParameterfv(Imports.GetTexLevelParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameteriv(GL.Enums.TextureTarget target, Int32 level, GL.Enums.GetTextureParameter pname, [Out] Int32* @params);
        internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv = (GetTexLevelParameteriv)GL.GetDelegateForExtensionMethod("glGetTexLevelParameteriv", typeof(GetTexLevelParameteriv)) ?? new GetTexLevelParameteriv(Imports.GetTexLevelParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsEnabled(GL.Enums.EnableCap cap);
        internal static IsEnabled glIsEnabled = (IsEnabled)GL.GetDelegateForExtensionMethod("glIsEnabled", typeof(IsEnabled)) ?? new IsEnabled(Imports.IsEnabled);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsList(UInt32 list);
        internal static IsList glIsList = (IsList)GL.GetDelegateForExtensionMethod("glIsList", typeof(IsList)) ?? new IsList(Imports.IsList);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRange(Double near, Double far);
        internal static DepthRange glDepthRange = (DepthRange)GL.GetDelegateForExtensionMethod("glDepthRange", typeof(DepthRange)) ?? new DepthRange(Imports.DepthRange);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
        internal static Frustum glFrustum = (Frustum)GL.GetDelegateForExtensionMethod("glFrustum", typeof(Frustum)) ?? new Frustum(Imports.Frustum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadIdentity();
        internal static LoadIdentity glLoadIdentity = (LoadIdentity)GL.GetDelegateForExtensionMethod("glLoadIdentity", typeof(LoadIdentity)) ?? new LoadIdentity(Imports.LoadIdentity);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadMatrixf(Single* m);
        internal unsafe static LoadMatrixf glLoadMatrixf = (LoadMatrixf)GL.GetDelegateForExtensionMethod("glLoadMatrixf", typeof(LoadMatrixf)) ?? new LoadMatrixf(Imports.LoadMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadMatrixd(Double* m);
        internal unsafe static LoadMatrixd glLoadMatrixd = (LoadMatrixd)GL.GetDelegateForExtensionMethod("glLoadMatrixd", typeof(LoadMatrixd)) ?? new LoadMatrixd(Imports.LoadMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MatrixMode(GL.Enums.MatrixMode mode);
        internal static MatrixMode glMatrixMode = (MatrixMode)GL.GetDelegateForExtensionMethod("glMatrixMode", typeof(MatrixMode)) ?? new MatrixMode(Imports.MatrixMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultMatrixf(Single* m);
        internal unsafe static MultMatrixf glMultMatrixf = (MultMatrixf)GL.GetDelegateForExtensionMethod("glMultMatrixf", typeof(MultMatrixf)) ?? new MultMatrixf(Imports.MultMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultMatrixd(Double* m);
        internal unsafe static MultMatrixd glMultMatrixd = (MultMatrixd)GL.GetDelegateForExtensionMethod("glMultMatrixd", typeof(MultMatrixd)) ?? new MultMatrixd(Imports.MultMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
        internal static Ortho glOrtho = (Ortho)GL.GetDelegateForExtensionMethod("glOrtho", typeof(Ortho)) ?? new Ortho(Imports.Ortho);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopMatrix();
        internal static PopMatrix glPopMatrix = (PopMatrix)GL.GetDelegateForExtensionMethod("glPopMatrix", typeof(PopMatrix)) ?? new PopMatrix(Imports.PopMatrix);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushMatrix();
        internal static PushMatrix glPushMatrix = (PushMatrix)GL.GetDelegateForExtensionMethod("glPushMatrix", typeof(PushMatrix)) ?? new PushMatrix(Imports.PushMatrix);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rotated(Double angle, Double x, Double y, Double z);
        internal static Rotated glRotated = (Rotated)GL.GetDelegateForExtensionMethod("glRotated", typeof(Rotated)) ?? new Rotated(Imports.Rotated);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
        internal static Rotatef glRotatef = (Rotatef)GL.GetDelegateForExtensionMethod("glRotatef", typeof(Rotatef)) ?? new Rotatef(Imports.Rotatef);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scaled(Double x, Double y, Double z);
        internal static Scaled glScaled = (Scaled)GL.GetDelegateForExtensionMethod("glScaled", typeof(Scaled)) ?? new Scaled(Imports.Scaled);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scalef(Single x, Single y, Single z);
        internal static Scalef glScalef = (Scalef)GL.GetDelegateForExtensionMethod("glScalef", typeof(Scalef)) ?? new Scalef(Imports.Scalef);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Translated(Double x, Double y, Double z);
        internal static Translated glTranslated = (Translated)GL.GetDelegateForExtensionMethod("glTranslated", typeof(Translated)) ?? new Translated(Imports.Translated);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Translatef(Single x, Single y, Single z);
        internal static Translatef glTranslatef = (Translatef)GL.GetDelegateForExtensionMethod("glTranslatef", typeof(Translatef)) ?? new Translatef(Imports.Translatef);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
        internal static Viewport glViewport = (Viewport)GL.GetDelegateForExtensionMethod("glViewport", typeof(Viewport)) ?? new Viewport(Imports.Viewport);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayElement(Int32 i);
        internal static ArrayElement glArrayElement = (ArrayElement)GL.GetDelegateForExtensionMethod("glArrayElement", typeof(ArrayElement)) ?? new ArrayElement(Imports.ArrayElement);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointer(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer);
        internal unsafe static ColorPointer glColorPointer = (ColorPointer)GL.GetDelegateForExtensionMethod("glColorPointer", typeof(ColorPointer)) ?? new ColorPointer(Imports.ColorPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableClientState(GL.Enums.EnableCap array);
        internal static DisableClientState glDisableClientState = (DisableClientState)GL.GetDelegateForExtensionMethod("glDisableClientState", typeof(DisableClientState)) ?? new DisableClientState(Imports.DisableClientState);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArrays(GL.Enums.BeginMode mode, Int32 first, Int32 count);
        internal static DrawArrays glDrawArrays = (DrawArrays)GL.GetDelegateForExtensionMethod("glDrawArrays", typeof(DrawArrays)) ?? new DrawArrays(Imports.DrawArrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawElements(GL.Enums.BeginMode mode, Int32 count, GL.Enums.All type, void* indices);
        internal unsafe static DrawElements glDrawElements = (DrawElements)GL.GetDelegateForExtensionMethod("glDrawElements", typeof(DrawElements)) ?? new DrawElements(Imports.DrawElements);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointer(Int32 stride, void* pointer);
        internal unsafe static EdgeFlagPointer glEdgeFlagPointer = (EdgeFlagPointer)GL.GetDelegateForExtensionMethod("glEdgeFlagPointer", typeof(EdgeFlagPointer)) ?? new EdgeFlagPointer(Imports.EdgeFlagPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableClientState(GL.Enums.EnableCap array);
        internal static EnableClientState glEnableClientState = (EnableClientState)GL.GetDelegateForExtensionMethod("glEnableClientState", typeof(EnableClientState)) ?? new EnableClientState(Imports.EnableClientState);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPointerv(GL.Enums.GetPointervPName pname, [Out] void* @params);
        internal unsafe static GetPointerv glGetPointerv = (GetPointerv)GL.GetDelegateForExtensionMethod("glGetPointerv", typeof(GetPointerv)) ?? new GetPointerv(Imports.GetPointerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointer(GL.Enums.IndexPointerType type, Int32 stride, void* pointer);
        internal unsafe static IndexPointer glIndexPointer = (IndexPointer)GL.GetDelegateForExtensionMethod("glIndexPointer", typeof(IndexPointer)) ?? new IndexPointer(Imports.IndexPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InterleavedArrays(GL.Enums.InterleavedArrayFormat format, Int32 stride, void* pointer);
        internal unsafe static InterleavedArrays glInterleavedArrays = (InterleavedArrays)GL.GetDelegateForExtensionMethod("glInterleavedArrays", typeof(InterleavedArrays)) ?? new InterleavedArrays(Imports.InterleavedArrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointer(GL.Enums.NormalPointerType type, Int32 stride, void* pointer);
        internal unsafe static NormalPointer glNormalPointer = (NormalPointer)GL.GetDelegateForExtensionMethod("glNormalPointer", typeof(NormalPointer)) ?? new NormalPointer(Imports.NormalPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointer(Int32 size, GL.Enums.TexCoordPointerType type, Int32 stride, void* pointer);
        internal unsafe static TexCoordPointer glTexCoordPointer = (TexCoordPointer)GL.GetDelegateForExtensionMethod("glTexCoordPointer", typeof(TexCoordPointer)) ?? new TexCoordPointer(Imports.TexCoordPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointer(Int32 size, GL.Enums.VertexPointerType type, Int32 stride, void* pointer);
        internal unsafe static VertexPointer glVertexPointer = (VertexPointer)GL.GetDelegateForExtensionMethod("glVertexPointer", typeof(VertexPointer)) ?? new VertexPointer(Imports.VertexPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffset(Single factor, Single units);
        internal static PolygonOffset glPolygonOffset = (PolygonOffset)GL.GetDelegateForExtensionMethod("glPolygonOffset", typeof(PolygonOffset)) ?? new PolygonOffset(Imports.PolygonOffset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
        internal static CopyTexImage1D glCopyTexImage1D = (CopyTexImage1D)GL.GetDelegateForExtensionMethod("glCopyTexImage1D", typeof(CopyTexImage1D)) ?? new CopyTexImage1D(Imports.CopyTexImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        internal static CopyTexImage2D glCopyTexImage2D = (CopyTexImage2D)GL.GetDelegateForExtensionMethod("glCopyTexImage2D", typeof(CopyTexImage2D)) ?? new CopyTexImage2D(Imports.CopyTexImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        internal static CopyTexSubImage1D glCopyTexSubImage1D = (CopyTexSubImage1D)GL.GetDelegateForExtensionMethod("glCopyTexSubImage1D", typeof(CopyTexSubImage1D)) ?? new CopyTexSubImage1D(Imports.CopyTexSubImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage2D glCopyTexSubImage2D = (CopyTexSubImage2D)GL.GetDelegateForExtensionMethod("glCopyTexSubImage2D", typeof(CopyTexSubImage2D)) ?? new CopyTexSubImage2D(Imports.CopyTexSubImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage1D glTexSubImage1D = (TexSubImage1D)GL.GetDelegateForExtensionMethod("glTexSubImage1D", typeof(TexSubImage1D)) ?? new TexSubImage1D(Imports.TexSubImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage2D glTexSubImage2D = (TexSubImage2D)GL.GetDelegateForExtensionMethod("glTexSubImage2D", typeof(TexSubImage2D)) ?? new TexSubImage2D(Imports.TexSubImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Boolean AreTexturesResident(Int32 n, UInt32* textures, [Out] GL.Enums.Boolean* residences);
        internal unsafe static AreTexturesResident glAreTexturesResident = (AreTexturesResident)GL.GetDelegateForExtensionMethod("glAreTexturesResident", typeof(AreTexturesResident)) ?? new AreTexturesResident(Imports.AreTexturesResident);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTexture(GL.Enums.TextureTarget target, UInt32 texture);
        internal static BindTexture glBindTexture = (BindTexture)GL.GetDelegateForExtensionMethod("glBindTexture", typeof(BindTexture)) ?? new BindTexture(Imports.BindTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
        internal unsafe static DeleteTextures glDeleteTextures = (DeleteTextures)GL.GetDelegateForExtensionMethod("glDeleteTextures", typeof(DeleteTextures)) ?? new DeleteTextures(Imports.DeleteTextures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTextures(Int32 n, [Out] UInt32* textures);
        internal unsafe static GenTextures glGenTextures = (GenTextures)GL.GetDelegateForExtensionMethod("glGenTextures", typeof(GenTextures)) ?? new GenTextures(Imports.GenTextures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsTexture(UInt32 texture);
        internal static IsTexture glIsTexture = (IsTexture)GL.GetDelegateForExtensionMethod("glIsTexture", typeof(IsTexture)) ?? new IsTexture(Imports.IsTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
        internal unsafe static PrioritizeTextures glPrioritizeTextures = (PrioritizeTextures)GL.GetDelegateForExtensionMethod("glPrioritizeTextures", typeof(PrioritizeTextures)) ?? new PrioritizeTextures(Imports.PrioritizeTextures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexub(Byte c);
        internal static Indexub glIndexub = (Indexub)GL.GetDelegateForExtensionMethod("glIndexub", typeof(Indexub)) ?? new Indexub(Imports.Indexub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexubv(Byte* c);
        internal unsafe static Indexubv glIndexubv = (Indexubv)GL.GetDelegateForExtensionMethod("glIndexubv", typeof(Indexubv)) ?? new Indexubv(Imports.Indexubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopClientAttrib();
        internal static PopClientAttrib glPopClientAttrib = (PopClientAttrib)GL.GetDelegateForExtensionMethod("glPopClientAttrib", typeof(PopClientAttrib)) ?? new PopClientAttrib(Imports.PopClientAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushClientAttrib(GL.Enums.ClientAttribMask mask);
        internal static PushClientAttrib glPushClientAttrib = (PushClientAttrib)GL.GetDelegateForExtensionMethod("glPushClientAttrib", typeof(PushClientAttrib)) ?? new PushClientAttrib(Imports.PushClientAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
        internal static BlendColor glBlendColor = (BlendColor)GL.GetDelegateForExtensionMethod("glBlendColor", typeof(BlendColor)) ?? new BlendColor(Imports.BlendColor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquation(GL.Enums.VERSION_1_2 mode);
        internal static BlendEquation glBlendEquation = (BlendEquation)GL.GetDelegateForExtensionMethod("glBlendEquation", typeof(BlendEquation)) ?? new BlendEquation(Imports.BlendEquation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawRangeElements(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 count, GL.Enums.VERSION_1_2 type, void* indices);
        internal unsafe static DrawRangeElements glDrawRangeElements = (DrawRangeElements)GL.GetDelegateForExtensionMethod("glDrawRangeElements", typeof(DrawRangeElements)) ?? new DrawRangeElements(Imports.DrawRangeElements);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal unsafe static ColorTable glColorTable = (ColorTable)GL.GetDelegateForExtensionMethod("glColorTable", typeof(ColorTable)) ?? new ColorTable(Imports.ColorTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Single* @params);
        internal unsafe static ColorTableParameterfv glColorTableParameterfv = (ColorTableParameterfv)GL.GetDelegateForExtensionMethod("glColorTableParameterfv", typeof(ColorTableParameterfv)) ?? new ColorTableParameterfv(Imports.ColorTableParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Int32* @params);
        internal unsafe static ColorTableParameteriv glColorTableParameteriv = (ColorTableParameteriv)GL.GetDelegateForExtensionMethod("glColorTableParameteriv", typeof(ColorTableParameteriv)) ?? new ColorTableParameteriv(Imports.ColorTableParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyColorTable glCopyColorTable = (CopyColorTable)GL.GetDelegateForExtensionMethod("glCopyColorTable", typeof(CopyColorTable)) ?? new CopyColorTable(Imports.CopyColorTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* table);
        internal unsafe static GetColorTable glGetColorTable = (GetColorTable)GL.GetDelegateForExtensionMethod("glGetColorTable", typeof(GetColorTable)) ?? new GetColorTable(Imports.GetColorTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
        internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv = (GetColorTableParameterfv)GL.GetDelegateForExtensionMethod("glGetColorTableParameterfv", typeof(GetColorTableParameterfv)) ?? new GetColorTableParameterfv(Imports.GetColorTableParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
        internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv = (GetColorTableParameteriv)GL.GetDelegateForExtensionMethod("glGetColorTableParameteriv", typeof(GetColorTableParameteriv)) ?? new GetColorTableParameteriv(Imports.GetColorTableParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorSubTable(GL.Enums.VERSION_1_2 target, Int32 start, Int32 count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        internal unsafe static ColorSubTable glColorSubTable = (ColorSubTable)GL.GetDelegateForExtensionMethod("glColorSubTable", typeof(ColorSubTable)) ?? new ColorSubTable(Imports.ColorSubTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorSubTable(GL.Enums.VERSION_1_2 target, Int32 start, Int32 x, Int32 y, Int32 width);
        internal static CopyColorSubTable glCopyColorSubTable = (CopyColorSubTable)GL.GetDelegateForExtensionMethod("glCopyColorSubTable", typeof(CopyColorSubTable)) ?? new CopyColorSubTable(Imports.CopyColorSubTable);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal unsafe static ConvolutionFilter1D glConvolutionFilter1D = (ConvolutionFilter1D)GL.GetDelegateForExtensionMethod("glConvolutionFilter1D", typeof(ConvolutionFilter1D)) ?? new ConvolutionFilter1D(Imports.ConvolutionFilter1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal unsafe static ConvolutionFilter2D glConvolutionFilter2D = (ConvolutionFilter2D)GL.GetDelegateForExtensionMethod("glConvolutionFilter2D", typeof(ConvolutionFilter2D)) ?? new ConvolutionFilter2D(Imports.ConvolutionFilter2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameterf(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Single @params);
        internal static ConvolutionParameterf glConvolutionParameterf = (ConvolutionParameterf)GL.GetDelegateForExtensionMethod("glConvolutionParameterf", typeof(ConvolutionParameterf)) ?? new ConvolutionParameterf(Imports.ConvolutionParameterf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Single* @params);
        internal unsafe static ConvolutionParameterfv glConvolutionParameterfv = (ConvolutionParameterfv)GL.GetDelegateForExtensionMethod("glConvolutionParameterfv", typeof(ConvolutionParameterfv)) ?? new ConvolutionParameterfv(Imports.ConvolutionParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameteri(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Int32 @params);
        internal static ConvolutionParameteri glConvolutionParameteri = (ConvolutionParameteri)GL.GetDelegateForExtensionMethod("glConvolutionParameteri", typeof(ConvolutionParameteri)) ?? new ConvolutionParameteri(Imports.ConvolutionParameteri);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Int32* @params);
        internal unsafe static ConvolutionParameteriv glConvolutionParameteriv = (ConvolutionParameteriv)GL.GetDelegateForExtensionMethod("glConvolutionParameteriv", typeof(ConvolutionParameteriv)) ?? new ConvolutionParameteriv(Imports.ConvolutionParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D = (CopyConvolutionFilter1D)GL.GetDelegateForExtensionMethod("glCopyConvolutionFilter1D", typeof(CopyConvolutionFilter1D)) ?? new CopyConvolutionFilter1D(Imports.CopyConvolutionFilter1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D = (CopyConvolutionFilter2D)GL.GetDelegateForExtensionMethod("glCopyConvolutionFilter2D", typeof(CopyConvolutionFilter2D)) ?? new CopyConvolutionFilter2D(Imports.CopyConvolutionFilter2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* image);
        internal unsafe static GetConvolutionFilter glGetConvolutionFilter = (GetConvolutionFilter)GL.GetDelegateForExtensionMethod("glGetConvolutionFilter", typeof(GetConvolutionFilter)) ?? new GetConvolutionFilter(Imports.GetConvolutionFilter);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
        internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv = (GetConvolutionParameterfv)GL.GetDelegateForExtensionMethod("glGetConvolutionParameterfv", typeof(GetConvolutionParameterfv)) ?? new GetConvolutionParameterfv(Imports.GetConvolutionParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
        internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv = (GetConvolutionParameteriv)GL.GetDelegateForExtensionMethod("glGetConvolutionParameteriv", typeof(GetConvolutionParameteriv)) ?? new GetConvolutionParameteriv(Imports.GetConvolutionParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSeparableFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* row, [Out] void* column, [Out] void* span);
        internal unsafe static GetSeparableFilter glGetSeparableFilter = (GetSeparableFilter)GL.GetDelegateForExtensionMethod("glGetSeparableFilter", typeof(GetSeparableFilter)) ?? new GetSeparableFilter(Imports.GetSeparableFilter);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SeparableFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
        internal unsafe static SeparableFilter2D glSeparableFilter2D = (SeparableFilter2D)GL.GetDelegateForExtensionMethod("glSeparableFilter2D", typeof(SeparableFilter2D)) ?? new SeparableFilter2D(Imports.SeparableFilter2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogram(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
        internal unsafe static GetHistogram glGetHistogram = (GetHistogram)GL.GetDelegateForExtensionMethod("glGetHistogram", typeof(GetHistogram)) ?? new GetHistogram(Imports.GetHistogram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
        internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv = (GetHistogramParameterfv)GL.GetDelegateForExtensionMethod("glGetHistogramParameterfv", typeof(GetHistogramParameterfv)) ?? new GetHistogramParameterfv(Imports.GetHistogramParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
        internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv = (GetHistogramParameteriv)GL.GetDelegateForExtensionMethod("glGetHistogramParameteriv", typeof(GetHistogramParameteriv)) ?? new GetHistogramParameteriv(Imports.GetHistogramParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmax(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
        internal unsafe static GetMinmax glGetMinmax = (GetMinmax)GL.GetDelegateForExtensionMethod("glGetMinmax", typeof(GetMinmax)) ?? new GetMinmax(Imports.GetMinmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
        internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv = (GetMinmaxParameterfv)GL.GetDelegateForExtensionMethod("glGetMinmaxParameterfv", typeof(GetMinmaxParameterfv)) ?? new GetMinmaxParameterfv(Imports.GetMinmaxParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
        internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv = (GetMinmaxParameteriv)GL.GetDelegateForExtensionMethod("glGetMinmaxParameteriv", typeof(GetMinmaxParameteriv)) ?? new GetMinmaxParameteriv(Imports.GetMinmaxParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Histogram(GL.Enums.VERSION_1_2 target, Int32 width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static Histogram glHistogram = (Histogram)GL.GetDelegateForExtensionMethod("glHistogram", typeof(Histogram)) ?? new Histogram(Imports.Histogram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Minmax(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static Minmax glMinmax = (Minmax)GL.GetDelegateForExtensionMethod("glMinmax", typeof(Minmax)) ?? new Minmax(Imports.Minmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetHistogram(GL.Enums.VERSION_1_2 target);
        internal static ResetHistogram glResetHistogram = (ResetHistogram)GL.GetDelegateForExtensionMethod("glResetHistogram", typeof(ResetHistogram)) ?? new ResetHistogram(Imports.ResetHistogram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetMinmax(GL.Enums.VERSION_1_2 target);
        internal static ResetMinmax glResetMinmax = (ResetMinmax)GL.GetDelegateForExtensionMethod("glResetMinmax", typeof(ResetMinmax)) ?? new ResetMinmax(Imports.ResetMinmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexImage3D glTexImage3D = (TexImage3D)GL.GetDelegateForExtensionMethod("glTexImage3D", typeof(TexImage3D)) ?? new TexImage3D(Imports.TexImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage3D glTexSubImage3D = (TexSubImage3D)GL.GetDelegateForExtensionMethod("glTexSubImage3D", typeof(TexSubImage3D)) ?? new TexSubImage3D(Imports.TexSubImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage3D glCopyTexSubImage3D = (CopyTexSubImage3D)GL.GetDelegateForExtensionMethod("glCopyTexSubImage3D", typeof(CopyTexSubImage3D)) ?? new CopyTexSubImage3D(Imports.CopyTexSubImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTexture(GL.Enums.VERSION_1_3 texture);
        internal static ActiveTexture glActiveTexture = (ActiveTexture)GL.GetDelegateForExtensionMethod("glActiveTexture", typeof(ActiveTexture)) ?? new ActiveTexture(Imports.ActiveTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveTexture(GL.Enums.VERSION_1_3 texture);
        internal static ClientActiveTexture glClientActiveTexture = (ClientActiveTexture)GL.GetDelegateForExtensionMethod("glClientActiveTexture", typeof(ClientActiveTexture)) ?? new ClientActiveTexture(Imports.ClientActiveTexture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1d(GL.Enums.VERSION_1_3 target, Double s);
        internal static MultiTexCoord1d glMultiTexCoord1d = (MultiTexCoord1d)GL.GetDelegateForExtensionMethod("glMultiTexCoord1d", typeof(MultiTexCoord1d)) ?? new MultiTexCoord1d(Imports.MultiTexCoord1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1dv(GL.Enums.VERSION_1_3 target, Double* v);
        internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv = (MultiTexCoord1dv)GL.GetDelegateForExtensionMethod("glMultiTexCoord1dv", typeof(MultiTexCoord1dv)) ?? new MultiTexCoord1dv(Imports.MultiTexCoord1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1f(GL.Enums.VERSION_1_3 target, Single s);
        internal static MultiTexCoord1f glMultiTexCoord1f = (MultiTexCoord1f)GL.GetDelegateForExtensionMethod("glMultiTexCoord1f", typeof(MultiTexCoord1f)) ?? new MultiTexCoord1f(Imports.MultiTexCoord1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1fv(GL.Enums.VERSION_1_3 target, Single* v);
        internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv = (MultiTexCoord1fv)GL.GetDelegateForExtensionMethod("glMultiTexCoord1fv", typeof(MultiTexCoord1fv)) ?? new MultiTexCoord1fv(Imports.MultiTexCoord1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1i(GL.Enums.VERSION_1_3 target, Int32 s);
        internal static MultiTexCoord1i glMultiTexCoord1i = (MultiTexCoord1i)GL.GetDelegateForExtensionMethod("glMultiTexCoord1i", typeof(MultiTexCoord1i)) ?? new MultiTexCoord1i(Imports.MultiTexCoord1i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1iv(GL.Enums.VERSION_1_3 target, Int32* v);
        internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv = (MultiTexCoord1iv)GL.GetDelegateForExtensionMethod("glMultiTexCoord1iv", typeof(MultiTexCoord1iv)) ?? new MultiTexCoord1iv(Imports.MultiTexCoord1iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1s(GL.Enums.VERSION_1_3 target, Int16 s);
        internal static MultiTexCoord1s glMultiTexCoord1s = (MultiTexCoord1s)GL.GetDelegateForExtensionMethod("glMultiTexCoord1s", typeof(MultiTexCoord1s)) ?? new MultiTexCoord1s(Imports.MultiTexCoord1s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1sv(GL.Enums.VERSION_1_3 target, Int16* v);
        internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv = (MultiTexCoord1sv)GL.GetDelegateForExtensionMethod("glMultiTexCoord1sv", typeof(MultiTexCoord1sv)) ?? new MultiTexCoord1sv(Imports.MultiTexCoord1sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2d(GL.Enums.VERSION_1_3 target, Double s, Double t);
        internal static MultiTexCoord2d glMultiTexCoord2d = (MultiTexCoord2d)GL.GetDelegateForExtensionMethod("glMultiTexCoord2d", typeof(MultiTexCoord2d)) ?? new MultiTexCoord2d(Imports.MultiTexCoord2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2dv(GL.Enums.VERSION_1_3 target, Double* v);
        internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv = (MultiTexCoord2dv)GL.GetDelegateForExtensionMethod("glMultiTexCoord2dv", typeof(MultiTexCoord2dv)) ?? new MultiTexCoord2dv(Imports.MultiTexCoord2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2f(GL.Enums.VERSION_1_3 target, Single s, Single t);
        internal static MultiTexCoord2f glMultiTexCoord2f = (MultiTexCoord2f)GL.GetDelegateForExtensionMethod("glMultiTexCoord2f", typeof(MultiTexCoord2f)) ?? new MultiTexCoord2f(Imports.MultiTexCoord2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2fv(GL.Enums.VERSION_1_3 target, Single* v);
        internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv = (MultiTexCoord2fv)GL.GetDelegateForExtensionMethod("glMultiTexCoord2fv", typeof(MultiTexCoord2fv)) ?? new MultiTexCoord2fv(Imports.MultiTexCoord2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2i(GL.Enums.VERSION_1_3 target, Int32 s, Int32 t);
        internal static MultiTexCoord2i glMultiTexCoord2i = (MultiTexCoord2i)GL.GetDelegateForExtensionMethod("glMultiTexCoord2i", typeof(MultiTexCoord2i)) ?? new MultiTexCoord2i(Imports.MultiTexCoord2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2iv(GL.Enums.VERSION_1_3 target, Int32* v);
        internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv = (MultiTexCoord2iv)GL.GetDelegateForExtensionMethod("glMultiTexCoord2iv", typeof(MultiTexCoord2iv)) ?? new MultiTexCoord2iv(Imports.MultiTexCoord2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2s(GL.Enums.VERSION_1_3 target, Int16 s, Int16 t);
        internal static MultiTexCoord2s glMultiTexCoord2s = (MultiTexCoord2s)GL.GetDelegateForExtensionMethod("glMultiTexCoord2s", typeof(MultiTexCoord2s)) ?? new MultiTexCoord2s(Imports.MultiTexCoord2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2sv(GL.Enums.VERSION_1_3 target, Int16* v);
        internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv = (MultiTexCoord2sv)GL.GetDelegateForExtensionMethod("glMultiTexCoord2sv", typeof(MultiTexCoord2sv)) ?? new MultiTexCoord2sv(Imports.MultiTexCoord2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3d(GL.Enums.VERSION_1_3 target, Double s, Double t, Double r);
        internal static MultiTexCoord3d glMultiTexCoord3d = (MultiTexCoord3d)GL.GetDelegateForExtensionMethod("glMultiTexCoord3d", typeof(MultiTexCoord3d)) ?? new MultiTexCoord3d(Imports.MultiTexCoord3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3dv(GL.Enums.VERSION_1_3 target, Double* v);
        internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv = (MultiTexCoord3dv)GL.GetDelegateForExtensionMethod("glMultiTexCoord3dv", typeof(MultiTexCoord3dv)) ?? new MultiTexCoord3dv(Imports.MultiTexCoord3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3f(GL.Enums.VERSION_1_3 target, Single s, Single t, Single r);
        internal static MultiTexCoord3f glMultiTexCoord3f = (MultiTexCoord3f)GL.GetDelegateForExtensionMethod("glMultiTexCoord3f", typeof(MultiTexCoord3f)) ?? new MultiTexCoord3f(Imports.MultiTexCoord3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3fv(GL.Enums.VERSION_1_3 target, Single* v);
        internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv = (MultiTexCoord3fv)GL.GetDelegateForExtensionMethod("glMultiTexCoord3fv", typeof(MultiTexCoord3fv)) ?? new MultiTexCoord3fv(Imports.MultiTexCoord3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3i(GL.Enums.VERSION_1_3 target, Int32 s, Int32 t, Int32 r);
        internal static MultiTexCoord3i glMultiTexCoord3i = (MultiTexCoord3i)GL.GetDelegateForExtensionMethod("glMultiTexCoord3i", typeof(MultiTexCoord3i)) ?? new MultiTexCoord3i(Imports.MultiTexCoord3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3iv(GL.Enums.VERSION_1_3 target, Int32* v);
        internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv = (MultiTexCoord3iv)GL.GetDelegateForExtensionMethod("glMultiTexCoord3iv", typeof(MultiTexCoord3iv)) ?? new MultiTexCoord3iv(Imports.MultiTexCoord3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3s(GL.Enums.VERSION_1_3 target, Int16 s, Int16 t, Int16 r);
        internal static MultiTexCoord3s glMultiTexCoord3s = (MultiTexCoord3s)GL.GetDelegateForExtensionMethod("glMultiTexCoord3s", typeof(MultiTexCoord3s)) ?? new MultiTexCoord3s(Imports.MultiTexCoord3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3sv(GL.Enums.VERSION_1_3 target, Int16* v);
        internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv = (MultiTexCoord3sv)GL.GetDelegateForExtensionMethod("glMultiTexCoord3sv", typeof(MultiTexCoord3sv)) ?? new MultiTexCoord3sv(Imports.MultiTexCoord3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4d(GL.Enums.VERSION_1_3 target, Double s, Double t, Double r, Double q);
        internal static MultiTexCoord4d glMultiTexCoord4d = (MultiTexCoord4d)GL.GetDelegateForExtensionMethod("glMultiTexCoord4d", typeof(MultiTexCoord4d)) ?? new MultiTexCoord4d(Imports.MultiTexCoord4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4dv(GL.Enums.VERSION_1_3 target, Double* v);
        internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv = (MultiTexCoord4dv)GL.GetDelegateForExtensionMethod("glMultiTexCoord4dv", typeof(MultiTexCoord4dv)) ?? new MultiTexCoord4dv(Imports.MultiTexCoord4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4f(GL.Enums.VERSION_1_3 target, Single s, Single t, Single r, Single q);
        internal static MultiTexCoord4f glMultiTexCoord4f = (MultiTexCoord4f)GL.GetDelegateForExtensionMethod("glMultiTexCoord4f", typeof(MultiTexCoord4f)) ?? new MultiTexCoord4f(Imports.MultiTexCoord4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4fv(GL.Enums.VERSION_1_3 target, Single* v);
        internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv = (MultiTexCoord4fv)GL.GetDelegateForExtensionMethod("glMultiTexCoord4fv", typeof(MultiTexCoord4fv)) ?? new MultiTexCoord4fv(Imports.MultiTexCoord4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4i(GL.Enums.VERSION_1_3 target, Int32 s, Int32 t, Int32 r, Int32 q);
        internal static MultiTexCoord4i glMultiTexCoord4i = (MultiTexCoord4i)GL.GetDelegateForExtensionMethod("glMultiTexCoord4i", typeof(MultiTexCoord4i)) ?? new MultiTexCoord4i(Imports.MultiTexCoord4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4iv(GL.Enums.VERSION_1_3 target, Int32* v);
        internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv = (MultiTexCoord4iv)GL.GetDelegateForExtensionMethod("glMultiTexCoord4iv", typeof(MultiTexCoord4iv)) ?? new MultiTexCoord4iv(Imports.MultiTexCoord4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4s(GL.Enums.VERSION_1_3 target, Int16 s, Int16 t, Int16 r, Int16 q);
        internal static MultiTexCoord4s glMultiTexCoord4s = (MultiTexCoord4s)GL.GetDelegateForExtensionMethod("glMultiTexCoord4s", typeof(MultiTexCoord4s)) ?? new MultiTexCoord4s(Imports.MultiTexCoord4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4sv(GL.Enums.VERSION_1_3 target, Int16* v);
        internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv = (MultiTexCoord4sv)GL.GetDelegateForExtensionMethod("glMultiTexCoord4sv", typeof(MultiTexCoord4sv)) ?? new MultiTexCoord4sv(Imports.MultiTexCoord4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixf(Single* m);
        internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf = (LoadTransposeMatrixf)GL.GetDelegateForExtensionMethod("glLoadTransposeMatrixf", typeof(LoadTransposeMatrixf)) ?? new LoadTransposeMatrixf(Imports.LoadTransposeMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixd(Double* m);
        internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd = (LoadTransposeMatrixd)GL.GetDelegateForExtensionMethod("glLoadTransposeMatrixd", typeof(LoadTransposeMatrixd)) ?? new LoadTransposeMatrixd(Imports.LoadTransposeMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixf(Single* m);
        internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf = (MultTransposeMatrixf)GL.GetDelegateForExtensionMethod("glMultTransposeMatrixf", typeof(MultTransposeMatrixf)) ?? new MultTransposeMatrixf(Imports.MultTransposeMatrixf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixd(Double* m);
        internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd = (MultTransposeMatrixd)GL.GetDelegateForExtensionMethod("glMultTransposeMatrixd", typeof(MultTransposeMatrixd)) ?? new MultTransposeMatrixd(Imports.MultTransposeMatrixd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverage(Single value, GL.Enums.Boolean invert);
        internal static SampleCoverage glSampleCoverage = (SampleCoverage)GL.GetDelegateForExtensionMethod("glSampleCoverage", typeof(SampleCoverage)) ?? new SampleCoverage(Imports.SampleCoverage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage3D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage3D glCompressedTexImage3D = (CompressedTexImage3D)GL.GetDelegateForExtensionMethod("glCompressedTexImage3D", typeof(CompressedTexImage3D)) ?? new CompressedTexImage3D(Imports.CompressedTexImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage2D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage2D glCompressedTexImage2D = (CompressedTexImage2D)GL.GetDelegateForExtensionMethod("glCompressedTexImage2D", typeof(CompressedTexImage2D)) ?? new CompressedTexImage2D(Imports.CompressedTexImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage1D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage1D glCompressedTexImage1D = (CompressedTexImage1D)GL.GetDelegateForExtensionMethod("glCompressedTexImage1D", typeof(CompressedTexImage1D)) ?? new CompressedTexImage1D(Imports.CompressedTexImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage3D glCompressedTexSubImage3D = (CompressedTexSubImage3D)GL.GetDelegateForExtensionMethod("glCompressedTexSubImage3D", typeof(CompressedTexSubImage3D)) ?? new CompressedTexSubImage3D(Imports.CompressedTexSubImage3D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage2D glCompressedTexSubImage2D = (CompressedTexSubImage2D)GL.GetDelegateForExtensionMethod("glCompressedTexSubImage2D", typeof(CompressedTexSubImage2D)) ?? new CompressedTexSubImage2D(Imports.CompressedTexSubImage2D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage1D glCompressedTexSubImage1D = (CompressedTexSubImage1D)GL.GetDelegateForExtensionMethod("glCompressedTexSubImage1D", typeof(CompressedTexSubImage1D)) ?? new CompressedTexSubImage1D(Imports.CompressedTexSubImage1D);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCompressedTexImage(GL.Enums.TextureTarget target, Int32 level, [Out] void* img);
        internal unsafe static GetCompressedTexImage glGetCompressedTexImage = (GetCompressedTexImage)GL.GetDelegateForExtensionMethod("glGetCompressedTexImage", typeof(GetCompressedTexImage)) ?? new GetCompressedTexImage(Imports.GetCompressedTexImage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparate(GL.Enums.VERSION_1_4 sfactorRGB, GL.Enums.VERSION_1_4 dfactorRGB, GL.Enums.VERSION_1_4 sfactorAlpha, GL.Enums.VERSION_1_4 dfactorAlpha);
        internal static BlendFuncSeparate glBlendFuncSeparate = (BlendFuncSeparate)GL.GetDelegateForExtensionMethod("glBlendFuncSeparate", typeof(BlendFuncSeparate)) ?? new BlendFuncSeparate(Imports.BlendFuncSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordf(Single coord);
        internal static FogCoordf glFogCoordf = (FogCoordf)GL.GetDelegateForExtensionMethod("glFogCoordf", typeof(FogCoordf)) ?? new FogCoordf(Imports.FogCoordf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordfv(Single* coord);
        internal unsafe static FogCoordfv glFogCoordfv = (FogCoordfv)GL.GetDelegateForExtensionMethod("glFogCoordfv", typeof(FogCoordfv)) ?? new FogCoordfv(Imports.FogCoordfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordd(Double coord);
        internal static FogCoordd glFogCoordd = (FogCoordd)GL.GetDelegateForExtensionMethod("glFogCoordd", typeof(FogCoordd)) ?? new FogCoordd(Imports.FogCoordd);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoorddv(Double* coord);
        internal unsafe static FogCoorddv glFogCoorddv = (FogCoorddv)GL.GetDelegateForExtensionMethod("glFogCoorddv", typeof(FogCoorddv)) ?? new FogCoorddv(Imports.FogCoorddv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointer(GL.Enums.VERSION_1_4 type, Int32 stride, void* pointer);
        internal unsafe static FogCoordPointer glFogCoordPointer = (FogCoordPointer)GL.GetDelegateForExtensionMethod("glFogCoordPointer", typeof(FogCoordPointer)) ?? new FogCoordPointer(Imports.FogCoordPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArrays(GL.Enums.BeginMode mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
        internal unsafe static MultiDrawArrays glMultiDrawArrays = (MultiDrawArrays)GL.GetDelegateForExtensionMethod("glMultiDrawArrays", typeof(MultiDrawArrays)) ?? new MultiDrawArrays(Imports.MultiDrawArrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElements(GL.Enums.BeginMode mode, Int32* count, GL.Enums.VERSION_1_4 type, void* indices, Int32 primcount);
        internal unsafe static MultiDrawElements glMultiDrawElements = (MultiDrawElements)GL.GetDelegateForExtensionMethod("glMultiDrawElements", typeof(MultiDrawElements)) ?? new MultiDrawElements(Imports.MultiDrawElements);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterf(GL.Enums.VERSION_1_4 pname, Single param);
        internal static PointParameterf glPointParameterf = (PointParameterf)GL.GetDelegateForExtensionMethod("glPointParameterf", typeof(PointParameterf)) ?? new PointParameterf(Imports.PointParameterf);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfv(GL.Enums.VERSION_1_4 pname, Single* @params);
        internal unsafe static PointParameterfv glPointParameterfv = (PointParameterfv)GL.GetDelegateForExtensionMethod("glPointParameterfv", typeof(PointParameterfv)) ?? new PointParameterfv(Imports.PointParameterfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteri(GL.Enums.VERSION_1_4 pname, Int32 param);
        internal static PointParameteri glPointParameteri = (PointParameteri)GL.GetDelegateForExtensionMethod("glPointParameteri", typeof(PointParameteri)) ?? new PointParameteri(Imports.PointParameteri);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameteriv(GL.Enums.VERSION_1_4 pname, Int32* @params);
        internal unsafe static PointParameteriv glPointParameteriv = (PointParameteriv)GL.GetDelegateForExtensionMethod("glPointParameteriv", typeof(PointParameteriv)) ?? new PointParameteriv(Imports.PointParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3b(SByte red, SByte green, SByte blue);
        internal static SecondaryColor3b glSecondaryColor3b = (SecondaryColor3b)GL.GetDelegateForExtensionMethod("glSecondaryColor3b", typeof(SecondaryColor3b)) ?? new SecondaryColor3b(Imports.SecondaryColor3b);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3bv(SByte* v);
        internal unsafe static SecondaryColor3bv glSecondaryColor3bv = (SecondaryColor3bv)GL.GetDelegateForExtensionMethod("glSecondaryColor3bv", typeof(SecondaryColor3bv)) ?? new SecondaryColor3bv(Imports.SecondaryColor3bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3d(Double red, Double green, Double blue);
        internal static SecondaryColor3d glSecondaryColor3d = (SecondaryColor3d)GL.GetDelegateForExtensionMethod("glSecondaryColor3d", typeof(SecondaryColor3d)) ?? new SecondaryColor3d(Imports.SecondaryColor3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3dv(Double* v);
        internal unsafe static SecondaryColor3dv glSecondaryColor3dv = (SecondaryColor3dv)GL.GetDelegateForExtensionMethod("glSecondaryColor3dv", typeof(SecondaryColor3dv)) ?? new SecondaryColor3dv(Imports.SecondaryColor3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3f(Single red, Single green, Single blue);
        internal static SecondaryColor3f glSecondaryColor3f = (SecondaryColor3f)GL.GetDelegateForExtensionMethod("glSecondaryColor3f", typeof(SecondaryColor3f)) ?? new SecondaryColor3f(Imports.SecondaryColor3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3fv(Single* v);
        internal unsafe static SecondaryColor3fv glSecondaryColor3fv = (SecondaryColor3fv)GL.GetDelegateForExtensionMethod("glSecondaryColor3fv", typeof(SecondaryColor3fv)) ?? new SecondaryColor3fv(Imports.SecondaryColor3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
        internal static SecondaryColor3i glSecondaryColor3i = (SecondaryColor3i)GL.GetDelegateForExtensionMethod("glSecondaryColor3i", typeof(SecondaryColor3i)) ?? new SecondaryColor3i(Imports.SecondaryColor3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3iv(Int32* v);
        internal unsafe static SecondaryColor3iv glSecondaryColor3iv = (SecondaryColor3iv)GL.GetDelegateForExtensionMethod("glSecondaryColor3iv", typeof(SecondaryColor3iv)) ?? new SecondaryColor3iv(Imports.SecondaryColor3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
        internal static SecondaryColor3s glSecondaryColor3s = (SecondaryColor3s)GL.GetDelegateForExtensionMethod("glSecondaryColor3s", typeof(SecondaryColor3s)) ?? new SecondaryColor3s(Imports.SecondaryColor3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3sv(Int16* v);
        internal unsafe static SecondaryColor3sv glSecondaryColor3sv = (SecondaryColor3sv)GL.GetDelegateForExtensionMethod("glSecondaryColor3sv", typeof(SecondaryColor3sv)) ?? new SecondaryColor3sv(Imports.SecondaryColor3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ub(Byte red, Byte green, Byte blue);
        internal static SecondaryColor3ub glSecondaryColor3ub = (SecondaryColor3ub)GL.GetDelegateForExtensionMethod("glSecondaryColor3ub", typeof(SecondaryColor3ub)) ?? new SecondaryColor3ub(Imports.SecondaryColor3ub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ubv(Byte* v);
        internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv = (SecondaryColor3ubv)GL.GetDelegateForExtensionMethod("glSecondaryColor3ubv", typeof(SecondaryColor3ubv)) ?? new SecondaryColor3ubv(Imports.SecondaryColor3ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
        internal static SecondaryColor3ui glSecondaryColor3ui = (SecondaryColor3ui)GL.GetDelegateForExtensionMethod("glSecondaryColor3ui", typeof(SecondaryColor3ui)) ?? new SecondaryColor3ui(Imports.SecondaryColor3ui);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
        internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv = (SecondaryColor3uiv)GL.GetDelegateForExtensionMethod("glSecondaryColor3uiv", typeof(SecondaryColor3uiv)) ?? new SecondaryColor3uiv(Imports.SecondaryColor3uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
        internal static SecondaryColor3us glSecondaryColor3us = (SecondaryColor3us)GL.GetDelegateForExtensionMethod("glSecondaryColor3us", typeof(SecondaryColor3us)) ?? new SecondaryColor3us(Imports.SecondaryColor3us);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3usv(UInt16* v);
        internal unsafe static SecondaryColor3usv glSecondaryColor3usv = (SecondaryColor3usv)GL.GetDelegateForExtensionMethod("glSecondaryColor3usv", typeof(SecondaryColor3usv)) ?? new SecondaryColor3usv(Imports.SecondaryColor3usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointer(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer);
        internal unsafe static SecondaryColorPointer glSecondaryColorPointer = (SecondaryColorPointer)GL.GetDelegateForExtensionMethod("glSecondaryColorPointer", typeof(SecondaryColorPointer)) ?? new SecondaryColorPointer(Imports.SecondaryColorPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2d(Double x, Double y);
        internal static WindowPos2d glWindowPos2d = (WindowPos2d)GL.GetDelegateForExtensionMethod("glWindowPos2d", typeof(WindowPos2d)) ?? new WindowPos2d(Imports.WindowPos2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dv(Double* v);
        internal unsafe static WindowPos2dv glWindowPos2dv = (WindowPos2dv)GL.GetDelegateForExtensionMethod("glWindowPos2dv", typeof(WindowPos2dv)) ?? new WindowPos2dv(Imports.WindowPos2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2f(Single x, Single y);
        internal static WindowPos2f glWindowPos2f = (WindowPos2f)GL.GetDelegateForExtensionMethod("glWindowPos2f", typeof(WindowPos2f)) ?? new WindowPos2f(Imports.WindowPos2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fv(Single* v);
        internal unsafe static WindowPos2fv glWindowPos2fv = (WindowPos2fv)GL.GetDelegateForExtensionMethod("glWindowPos2fv", typeof(WindowPos2fv)) ?? new WindowPos2fv(Imports.WindowPos2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2i(Int32 x, Int32 y);
        internal static WindowPos2i glWindowPos2i = (WindowPos2i)GL.GetDelegateForExtensionMethod("glWindowPos2i", typeof(WindowPos2i)) ?? new WindowPos2i(Imports.WindowPos2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2iv(Int32* v);
        internal unsafe static WindowPos2iv glWindowPos2iv = (WindowPos2iv)GL.GetDelegateForExtensionMethod("glWindowPos2iv", typeof(WindowPos2iv)) ?? new WindowPos2iv(Imports.WindowPos2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2s(Int16 x, Int16 y);
        internal static WindowPos2s glWindowPos2s = (WindowPos2s)GL.GetDelegateForExtensionMethod("glWindowPos2s", typeof(WindowPos2s)) ?? new WindowPos2s(Imports.WindowPos2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2sv(Int16* v);
        internal unsafe static WindowPos2sv glWindowPos2sv = (WindowPos2sv)GL.GetDelegateForExtensionMethod("glWindowPos2sv", typeof(WindowPos2sv)) ?? new WindowPos2sv(Imports.WindowPos2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3d(Double x, Double y, Double z);
        internal static WindowPos3d glWindowPos3d = (WindowPos3d)GL.GetDelegateForExtensionMethod("glWindowPos3d", typeof(WindowPos3d)) ?? new WindowPos3d(Imports.WindowPos3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dv(Double* v);
        internal unsafe static WindowPos3dv glWindowPos3dv = (WindowPos3dv)GL.GetDelegateForExtensionMethod("glWindowPos3dv", typeof(WindowPos3dv)) ?? new WindowPos3dv(Imports.WindowPos3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3f(Single x, Single y, Single z);
        internal static WindowPos3f glWindowPos3f = (WindowPos3f)GL.GetDelegateForExtensionMethod("glWindowPos3f", typeof(WindowPos3f)) ?? new WindowPos3f(Imports.WindowPos3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fv(Single* v);
        internal unsafe static WindowPos3fv glWindowPos3fv = (WindowPos3fv)GL.GetDelegateForExtensionMethod("glWindowPos3fv", typeof(WindowPos3fv)) ?? new WindowPos3fv(Imports.WindowPos3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3i(Int32 x, Int32 y, Int32 z);
        internal static WindowPos3i glWindowPos3i = (WindowPos3i)GL.GetDelegateForExtensionMethod("glWindowPos3i", typeof(WindowPos3i)) ?? new WindowPos3i(Imports.WindowPos3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3iv(Int32* v);
        internal unsafe static WindowPos3iv glWindowPos3iv = (WindowPos3iv)GL.GetDelegateForExtensionMethod("glWindowPos3iv", typeof(WindowPos3iv)) ?? new WindowPos3iv(Imports.WindowPos3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3s(Int16 x, Int16 y, Int16 z);
        internal static WindowPos3s glWindowPos3s = (WindowPos3s)GL.GetDelegateForExtensionMethod("glWindowPos3s", typeof(WindowPos3s)) ?? new WindowPos3s(Imports.WindowPos3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3sv(Int16* v);
        internal unsafe static WindowPos3sv glWindowPos3sv = (WindowPos3sv)GL.GetDelegateForExtensionMethod("glWindowPos3sv", typeof(WindowPos3sv)) ?? new WindowPos3sv(Imports.WindowPos3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueries(Int32 n, [Out] UInt32* ids);
        internal unsafe static GenQueries glGenQueries = (GenQueries)GL.GetDelegateForExtensionMethod("glGenQueries", typeof(GenQueries)) ?? new GenQueries(Imports.GenQueries);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
        internal unsafe static DeleteQueries glDeleteQueries = (DeleteQueries)GL.GetDelegateForExtensionMethod("glDeleteQueries", typeof(DeleteQueries)) ?? new DeleteQueries(Imports.DeleteQueries);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsQuery(UInt32 id);
        internal static IsQuery glIsQuery = (IsQuery)GL.GetDelegateForExtensionMethod("glIsQuery", typeof(IsQuery)) ?? new IsQuery(Imports.IsQuery);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQuery(GL.Enums.VERSION_1_5 target, UInt32 id);
        internal static BeginQuery glBeginQuery = (BeginQuery)GL.GetDelegateForExtensionMethod("glBeginQuery", typeof(BeginQuery)) ?? new BeginQuery(Imports.BeginQuery);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQuery(GL.Enums.VERSION_1_5 target);
        internal static EndQuery glEndQuery = (EndQuery)GL.GetDelegateForExtensionMethod("glEndQuery", typeof(EndQuery)) ?? new EndQuery(Imports.EndQuery);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryiv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, [Out] Int32* @params);
        internal unsafe static GetQueryiv glGetQueryiv = (GetQueryiv)GL.GetDelegateForExtensionMethod("glGetQueryiv", typeof(GetQueryiv)) ?? new GetQueryiv(Imports.GetQueryiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectiv(UInt32 id, GL.Enums.VERSION_1_5 pname, [Out] Int32* @params);
        internal unsafe static GetQueryObjectiv glGetQueryObjectiv = (GetQueryObjectiv)GL.GetDelegateForExtensionMethod("glGetQueryObjectiv", typeof(GetQueryObjectiv)) ?? new GetQueryObjectiv(Imports.GetQueryObjectiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuiv(UInt32 id, GL.Enums.VERSION_1_5 pname, [Out] UInt32* @params);
        internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv = (GetQueryObjectuiv)GL.GetDelegateForExtensionMethod("glGetQueryObjectuiv", typeof(GetQueryObjectuiv)) ?? new GetQueryObjectuiv(Imports.GetQueryObjectuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBuffer(GL.Enums.VERSION_1_5 target, UInt32 buffer);
        internal static BindBuffer glBindBuffer = (BindBuffer)GL.GetDelegateForExtensionMethod("glBindBuffer", typeof(BindBuffer)) ?? new BindBuffer(Imports.BindBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
        internal unsafe static DeleteBuffers glDeleteBuffers = (DeleteBuffers)GL.GetDelegateForExtensionMethod("glDeleteBuffers", typeof(DeleteBuffers)) ?? new DeleteBuffers(Imports.DeleteBuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffers(Int32 n, [Out] UInt32* buffers);
        internal unsafe static GenBuffers glGenBuffers = (GenBuffers)GL.GetDelegateForExtensionMethod("glGenBuffers", typeof(GenBuffers)) ?? new GenBuffers(Imports.GenBuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsBuffer(UInt32 buffer);
        internal static IsBuffer glIsBuffer = (IsBuffer)GL.GetDelegateForExtensionMethod("glIsBuffer", typeof(IsBuffer)) ?? new IsBuffer(Imports.IsBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferData(GL.Enums.VERSION_1_5 target, IntPtr size, void* data, GL.Enums.VERSION_1_5 usage);
        internal unsafe static BufferData glBufferData = (BufferData)GL.GetDelegateForExtensionMethod("glBufferData", typeof(BufferData)) ?? new BufferData(Imports.BufferData);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferSubData(GL.Enums.VERSION_1_5 target, IntPtr offset, IntPtr size, void* data);
        internal unsafe static BufferSubData glBufferSubData = (BufferSubData)GL.GetDelegateForExtensionMethod("glBufferSubData", typeof(BufferSubData)) ?? new BufferSubData(Imports.BufferSubData);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferSubData(GL.Enums.VERSION_1_5 target, IntPtr offset, IntPtr size, [Out] void* data);
        internal unsafe static GetBufferSubData glGetBufferSubData = (GetBufferSubData)GL.GetDelegateForExtensionMethod("glGetBufferSubData", typeof(GetBufferSubData)) ?? new GetBufferSubData(Imports.GetBufferSubData);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr MapBuffer(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 access);
        internal static MapBuffer glMapBuffer = (MapBuffer)GL.GetDelegateForExtensionMethod("glMapBuffer", typeof(MapBuffer)) ?? new MapBuffer(Imports.MapBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean UnmapBuffer(GL.Enums.VERSION_1_5 target);
        internal static UnmapBuffer glUnmapBuffer = (UnmapBuffer)GL.GetDelegateForExtensionMethod("glUnmapBuffer", typeof(UnmapBuffer)) ?? new UnmapBuffer(Imports.UnmapBuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameteriv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, [Out] Int32* @params);
        internal unsafe static GetBufferParameteriv glGetBufferParameteriv = (GetBufferParameteriv)GL.GetDelegateForExtensionMethod("glGetBufferParameteriv", typeof(GetBufferParameteriv)) ?? new GetBufferParameteriv(Imports.GetBufferParameteriv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferPointerv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, [Out] void* @params);
        internal unsafe static GetBufferPointerv glGetBufferPointerv = (GetBufferPointerv)GL.GetDelegateForExtensionMethod("glGetBufferPointerv", typeof(GetBufferPointerv)) ?? new GetBufferPointerv(Imports.GetBufferPointerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparate(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
        internal static BlendEquationSeparate glBlendEquationSeparate = (BlendEquationSeparate)GL.GetDelegateForExtensionMethod("glBlendEquationSeparate", typeof(BlendEquationSeparate)) ?? new BlendEquationSeparate(Imports.BlendEquationSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffers(Int32 n, GL.Enums.VERSION_2_0* bufs);
        internal unsafe static DrawBuffers glDrawBuffers = (DrawBuffers)GL.GetDelegateForExtensionMethod("glDrawBuffers", typeof(DrawBuffers)) ?? new DrawBuffers(Imports.DrawBuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparate(GL.Enums.VERSION_2_0 face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
        internal static StencilOpSeparate glStencilOpSeparate = (StencilOpSeparate)GL.GetDelegateForExtensionMethod("glStencilOpSeparate", typeof(StencilOpSeparate)) ?? new StencilOpSeparate(Imports.StencilOpSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparate(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, Int32 @ref, UInt32 mask);
        internal static StencilFuncSeparate glStencilFuncSeparate = (StencilFuncSeparate)GL.GetDelegateForExtensionMethod("glStencilFuncSeparate", typeof(StencilFuncSeparate)) ?? new StencilFuncSeparate(Imports.StencilFuncSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMaskSeparate(GL.Enums.VERSION_2_0 face, UInt32 mask);
        internal static StencilMaskSeparate glStencilMaskSeparate = (StencilMaskSeparate)GL.GetDelegateForExtensionMethod("glStencilMaskSeparate", typeof(StencilMaskSeparate)) ?? new StencilMaskSeparate(Imports.StencilMaskSeparate);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachShader(UInt32 program, UInt32 shader);
        internal static AttachShader glAttachShader = (AttachShader)GL.GetDelegateForExtensionMethod("glAttachShader", typeof(AttachShader)) ?? new AttachShader(Imports.AttachShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindAttribLocation(UInt32 program, UInt32 index, System.String name);
        internal static BindAttribLocation glBindAttribLocation = (BindAttribLocation)GL.GetDelegateForExtensionMethod("glBindAttribLocation", typeof(BindAttribLocation)) ?? new BindAttribLocation(Imports.BindAttribLocation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShader(UInt32 shader);
        internal static CompileShader glCompileShader = (CompileShader)GL.GetDelegateForExtensionMethod("glCompileShader", typeof(CompileShader)) ?? new CompileShader(Imports.CompileShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateProgram();
        internal static CreateProgram glCreateProgram = (CreateProgram)GL.GetDelegateForExtensionMethod("glCreateProgram", typeof(CreateProgram)) ?? new CreateProgram(Imports.CreateProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateShader(GL.Enums.VERSION_2_0 type);
        internal static CreateShader glCreateShader = (CreateShader)GL.GetDelegateForExtensionMethod("glCreateShader", typeof(CreateShader)) ?? new CreateShader(Imports.CreateShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteProgram(UInt32 program);
        internal static DeleteProgram glDeleteProgram = (DeleteProgram)GL.GetDelegateForExtensionMethod("glDeleteProgram", typeof(DeleteProgram)) ?? new DeleteProgram(Imports.DeleteProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteShader(UInt32 shader);
        internal static DeleteShader glDeleteShader = (DeleteShader)GL.GetDelegateForExtensionMethod("glDeleteShader", typeof(DeleteShader)) ?? new DeleteShader(Imports.DeleteShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachShader(UInt32 program, UInt32 shader);
        internal static DetachShader glDetachShader = (DetachShader)GL.GetDelegateForExtensionMethod("glDetachShader", typeof(DetachShader)) ?? new DetachShader(Imports.DetachShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArray(UInt32 index);
        internal static DisableVertexAttribArray glDisableVertexAttribArray = (DisableVertexAttribArray)GL.GetDelegateForExtensionMethod("glDisableVertexAttribArray", typeof(DisableVertexAttribArray)) ?? new DisableVertexAttribArray(Imports.DisableVertexAttribArray);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArray(UInt32 index);
        internal static EnableVertexAttribArray glEnableVertexAttribArray = (EnableVertexAttribArray)GL.GetDelegateForExtensionMethod("glEnableVertexAttribArray", typeof(EnableVertexAttribArray)) ?? new EnableVertexAttribArray(Imports.EnableVertexAttribArray);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.VERSION_2_0* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveAttrib glGetActiveAttrib = (GetActiveAttrib)GL.GetDelegateForExtensionMethod("glGetActiveAttrib", typeof(GetActiveAttrib)) ?? new GetActiveAttrib(Imports.GetActiveAttrib);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.VERSION_2_0* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveUniform glGetActiveUniform = (GetActiveUniform)GL.GetDelegateForExtensionMethod("glGetActiveUniform", typeof(GetActiveUniform)) ?? new GetActiveUniform(Imports.GetActiveUniform);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
        internal unsafe static GetAttachedShaders glGetAttachedShaders = (GetAttachedShaders)GL.GetDelegateForExtensionMethod("glGetAttachedShaders", typeof(GetAttachedShaders)) ?? new GetAttachedShaders(Imports.GetAttachedShaders);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetAttribLocation(UInt32 program, System.String name);
        internal static GetAttribLocation glGetAttribLocation = (GetAttribLocation)GL.GetDelegateForExtensionMethod("glGetAttribLocation", typeof(GetAttribLocation)) ?? new GetAttribLocation(Imports.GetAttribLocation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramiv(UInt32 program, GL.Enums.VERSION_2_0 pname, [Out] Int32* @params);
        internal unsafe static GetProgramiv glGetProgramiv = (GetProgramiv)GL.GetDelegateForExtensionMethod("glGetProgramiv", typeof(GetProgramiv)) ?? new GetProgramiv(Imports.GetProgramiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        internal unsafe static GetProgramInfoLog glGetProgramInfoLog = (GetProgramInfoLog)GL.GetDelegateForExtensionMethod("glGetProgramInfoLog", typeof(GetProgramInfoLog)) ?? new GetProgramInfoLog(Imports.GetProgramInfoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderiv(UInt32 shader, GL.Enums.VERSION_2_0 pname, [Out] Int32* @params);
        internal unsafe static GetShaderiv glGetShaderiv = (GetShaderiv)GL.GetDelegateForExtensionMethod("glGetShaderiv", typeof(GetShaderiv)) ?? new GetShaderiv(Imports.GetShaderiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        internal unsafe static GetShaderInfoLog glGetShaderInfoLog = (GetShaderInfoLog)GL.GetDelegateForExtensionMethod("glGetShaderInfoLog", typeof(GetShaderInfoLog)) ?? new GetShaderInfoLog(Imports.GetShaderInfoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
        internal unsafe static GetShaderSource glGetShaderSource = (GetShaderSource)GL.GetDelegateForExtensionMethod("glGetShaderSource", typeof(GetShaderSource)) ?? new GetShaderSource(Imports.GetShaderSource);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformLocation(UInt32 program, System.String name);
        internal static GetUniformLocation glGetUniformLocation = (GetUniformLocation)GL.GetDelegateForExtensionMethod("glGetUniformLocation", typeof(GetUniformLocation)) ?? new GetUniformLocation(Imports.GetUniformLocation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
        internal unsafe static GetUniformfv glGetUniformfv = (GetUniformfv)GL.GetDelegateForExtensionMethod("glGetUniformfv", typeof(GetUniformfv)) ?? new GetUniformfv(Imports.GetUniformfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
        internal unsafe static GetUniformiv glGetUniformiv = (GetUniformiv)GL.GetDelegateForExtensionMethod("glGetUniformiv", typeof(GetUniformiv)) ?? new GetUniformiv(Imports.GetUniformiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] Double* @params);
        internal unsafe static GetVertexAttribdv glGetVertexAttribdv = (GetVertexAttribdv)GL.GetDelegateForExtensionMethod("glGetVertexAttribdv", typeof(GetVertexAttribdv)) ?? new GetVertexAttribdv(Imports.GetVertexAttribdv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribfv glGetVertexAttribfv = (GetVertexAttribfv)GL.GetDelegateForExtensionMethod("glGetVertexAttribfv", typeof(GetVertexAttribfv)) ?? new GetVertexAttribfv(Imports.GetVertexAttribfv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribiv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribiv glGetVertexAttribiv = (GetVertexAttribiv)GL.GetDelegateForExtensionMethod("glGetVertexAttribiv", typeof(GetVertexAttribiv)) ?? new GetVertexAttribiv(Imports.GetVertexAttribiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointerv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] void* pointer);
        internal unsafe static GetVertexAttribPointerv glGetVertexAttribPointerv = (GetVertexAttribPointerv)GL.GetDelegateForExtensionMethod("glGetVertexAttribPointerv", typeof(GetVertexAttribPointerv)) ?? new GetVertexAttribPointerv(Imports.GetVertexAttribPointerv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsProgram(UInt32 program);
        internal static IsProgram glIsProgram = (IsProgram)GL.GetDelegateForExtensionMethod("glIsProgram", typeof(IsProgram)) ?? new IsProgram(Imports.IsProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsShader(UInt32 shader);
        internal static IsShader glIsShader = (IsShader)GL.GetDelegateForExtensionMethod("glIsShader", typeof(IsShader)) ?? new IsShader(Imports.IsShader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgram(UInt32 program);
        internal static LinkProgram glLinkProgram = (LinkProgram)GL.GetDelegateForExtensionMethod("glLinkProgram", typeof(LinkProgram)) ?? new LinkProgram(Imports.LinkProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, System.String[] @string, Int32* length);
        internal unsafe static ShaderSource glShaderSource = (ShaderSource)GL.GetDelegateForExtensionMethod("glShaderSource", typeof(ShaderSource)) ?? new ShaderSource(Imports.ShaderSource);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgram(UInt32 program);
        internal static UseProgram glUseProgram = (UseProgram)GL.GetDelegateForExtensionMethod("glUseProgram", typeof(UseProgram)) ?? new UseProgram(Imports.UseProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1f(Int32 location, Single v0);
        internal static Uniform1f glUniform1f = (Uniform1f)GL.GetDelegateForExtensionMethod("glUniform1f", typeof(Uniform1f)) ?? new Uniform1f(Imports.Uniform1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
        internal static Uniform2f glUniform2f = (Uniform2f)GL.GetDelegateForExtensionMethod("glUniform2f", typeof(Uniform2f)) ?? new Uniform2f(Imports.Uniform2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
        internal static Uniform3f glUniform3f = (Uniform3f)GL.GetDelegateForExtensionMethod("glUniform3f", typeof(Uniform3f)) ?? new Uniform3f(Imports.Uniform3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
        internal static Uniform4f glUniform4f = (Uniform4f)GL.GetDelegateForExtensionMethod("glUniform4f", typeof(Uniform4f)) ?? new Uniform4f(Imports.Uniform4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1i(Int32 location, Int32 v0);
        internal static Uniform1i glUniform1i = (Uniform1i)GL.GetDelegateForExtensionMethod("glUniform1i", typeof(Uniform1i)) ?? new Uniform1i(Imports.Uniform1i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
        internal static Uniform2i glUniform2i = (Uniform2i)GL.GetDelegateForExtensionMethod("glUniform2i", typeof(Uniform2i)) ?? new Uniform2i(Imports.Uniform2i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        internal static Uniform3i glUniform3i = (Uniform3i)GL.GetDelegateForExtensionMethod("glUniform3i", typeof(Uniform3i)) ?? new Uniform3i(Imports.Uniform3i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        internal static Uniform4i glUniform4i = (Uniform4i)GL.GetDelegateForExtensionMethod("glUniform4i", typeof(Uniform4i)) ?? new Uniform4i(Imports.Uniform4i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform1fv glUniform1fv = (Uniform1fv)GL.GetDelegateForExtensionMethod("glUniform1fv", typeof(Uniform1fv)) ?? new Uniform1fv(Imports.Uniform1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform2fv glUniform2fv = (Uniform2fv)GL.GetDelegateForExtensionMethod("glUniform2fv", typeof(Uniform2fv)) ?? new Uniform2fv(Imports.Uniform2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform3fv glUniform3fv = (Uniform3fv)GL.GetDelegateForExtensionMethod("glUniform3fv", typeof(Uniform3fv)) ?? new Uniform3fv(Imports.Uniform3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform4fv glUniform4fv = (Uniform4fv)GL.GetDelegateForExtensionMethod("glUniform4fv", typeof(Uniform4fv)) ?? new Uniform4fv(Imports.Uniform4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform1iv glUniform1iv = (Uniform1iv)GL.GetDelegateForExtensionMethod("glUniform1iv", typeof(Uniform1iv)) ?? new Uniform1iv(Imports.Uniform1iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform2iv glUniform2iv = (Uniform2iv)GL.GetDelegateForExtensionMethod("glUniform2iv", typeof(Uniform2iv)) ?? new Uniform2iv(Imports.Uniform2iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform3iv glUniform3iv = (Uniform3iv)GL.GetDelegateForExtensionMethod("glUniform3iv", typeof(Uniform3iv)) ?? new Uniform3iv(Imports.Uniform3iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform4iv glUniform4iv = (Uniform4iv)GL.GetDelegateForExtensionMethod("glUniform4iv", typeof(Uniform4iv)) ?? new Uniform4iv(Imports.Uniform4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix2fv glUniformMatrix2fv = (UniformMatrix2fv)GL.GetDelegateForExtensionMethod("glUniformMatrix2fv", typeof(UniformMatrix2fv)) ?? new UniformMatrix2fv(Imports.UniformMatrix2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix3fv glUniformMatrix3fv = (UniformMatrix3fv)GL.GetDelegateForExtensionMethod("glUniformMatrix3fv", typeof(UniformMatrix3fv)) ?? new UniformMatrix3fv(Imports.UniformMatrix3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix4fv glUniformMatrix4fv = (UniformMatrix4fv)GL.GetDelegateForExtensionMethod("glUniformMatrix4fv", typeof(UniformMatrix4fv)) ?? new UniformMatrix4fv(Imports.UniformMatrix4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgram(UInt32 program);
        internal static ValidateProgram glValidateProgram = (ValidateProgram)GL.GetDelegateForExtensionMethod("glValidateProgram", typeof(ValidateProgram)) ?? new ValidateProgram(Imports.ValidateProgram);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1d(UInt32 index, Double x);
        internal static VertexAttrib1d glVertexAttrib1d = (VertexAttrib1d)GL.GetDelegateForExtensionMethod("glVertexAttrib1d", typeof(VertexAttrib1d)) ?? new VertexAttrib1d(Imports.VertexAttrib1d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib1dv glVertexAttrib1dv = (VertexAttrib1dv)GL.GetDelegateForExtensionMethod("glVertexAttrib1dv", typeof(VertexAttrib1dv)) ?? new VertexAttrib1dv(Imports.VertexAttrib1dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1f(UInt32 index, Single x);
        internal static VertexAttrib1f glVertexAttrib1f = (VertexAttrib1f)GL.GetDelegateForExtensionMethod("glVertexAttrib1f", typeof(VertexAttrib1f)) ?? new VertexAttrib1f(Imports.VertexAttrib1f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib1fv glVertexAttrib1fv = (VertexAttrib1fv)GL.GetDelegateForExtensionMethod("glVertexAttrib1fv", typeof(VertexAttrib1fv)) ?? new VertexAttrib1fv(Imports.VertexAttrib1fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
        internal static VertexAttrib1s glVertexAttrib1s = (VertexAttrib1s)GL.GetDelegateForExtensionMethod("glVertexAttrib1s", typeof(VertexAttrib1s)) ?? new VertexAttrib1s(Imports.VertexAttrib1s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib1sv glVertexAttrib1sv = (VertexAttrib1sv)GL.GetDelegateForExtensionMethod("glVertexAttrib1sv", typeof(VertexAttrib1sv)) ?? new VertexAttrib1sv(Imports.VertexAttrib1sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
        internal static VertexAttrib2d glVertexAttrib2d = (VertexAttrib2d)GL.GetDelegateForExtensionMethod("glVertexAttrib2d", typeof(VertexAttrib2d)) ?? new VertexAttrib2d(Imports.VertexAttrib2d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib2dv glVertexAttrib2dv = (VertexAttrib2dv)GL.GetDelegateForExtensionMethod("glVertexAttrib2dv", typeof(VertexAttrib2dv)) ?? new VertexAttrib2dv(Imports.VertexAttrib2dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
        internal static VertexAttrib2f glVertexAttrib2f = (VertexAttrib2f)GL.GetDelegateForExtensionMethod("glVertexAttrib2f", typeof(VertexAttrib2f)) ?? new VertexAttrib2f(Imports.VertexAttrib2f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib2fv glVertexAttrib2fv = (VertexAttrib2fv)GL.GetDelegateForExtensionMethod("glVertexAttrib2fv", typeof(VertexAttrib2fv)) ?? new VertexAttrib2fv(Imports.VertexAttrib2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
        internal static VertexAttrib2s glVertexAttrib2s = (VertexAttrib2s)GL.GetDelegateForExtensionMethod("glVertexAttrib2s", typeof(VertexAttrib2s)) ?? new VertexAttrib2s(Imports.VertexAttrib2s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib2sv glVertexAttrib2sv = (VertexAttrib2sv)GL.GetDelegateForExtensionMethod("glVertexAttrib2sv", typeof(VertexAttrib2sv)) ?? new VertexAttrib2sv(Imports.VertexAttrib2sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
        internal static VertexAttrib3d glVertexAttrib3d = (VertexAttrib3d)GL.GetDelegateForExtensionMethod("glVertexAttrib3d", typeof(VertexAttrib3d)) ?? new VertexAttrib3d(Imports.VertexAttrib3d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib3dv glVertexAttrib3dv = (VertexAttrib3dv)GL.GetDelegateForExtensionMethod("glVertexAttrib3dv", typeof(VertexAttrib3dv)) ?? new VertexAttrib3dv(Imports.VertexAttrib3dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
        internal static VertexAttrib3f glVertexAttrib3f = (VertexAttrib3f)GL.GetDelegateForExtensionMethod("glVertexAttrib3f", typeof(VertexAttrib3f)) ?? new VertexAttrib3f(Imports.VertexAttrib3f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib3fv glVertexAttrib3fv = (VertexAttrib3fv)GL.GetDelegateForExtensionMethod("glVertexAttrib3fv", typeof(VertexAttrib3fv)) ?? new VertexAttrib3fv(Imports.VertexAttrib3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
        internal static VertexAttrib3s glVertexAttrib3s = (VertexAttrib3s)GL.GetDelegateForExtensionMethod("glVertexAttrib3s", typeof(VertexAttrib3s)) ?? new VertexAttrib3s(Imports.VertexAttrib3s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib3sv glVertexAttrib3sv = (VertexAttrib3sv)GL.GetDelegateForExtensionMethod("glVertexAttrib3sv", typeof(VertexAttrib3sv)) ?? new VertexAttrib3sv(Imports.VertexAttrib3sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv = (VertexAttrib4Nbv)GL.GetDelegateForExtensionMethod("glVertexAttrib4Nbv", typeof(VertexAttrib4Nbv)) ?? new VertexAttrib4Nbv(Imports.VertexAttrib4Nbv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv = (VertexAttrib4Niv)GL.GetDelegateForExtensionMethod("glVertexAttrib4Niv", typeof(VertexAttrib4Niv)) ?? new VertexAttrib4Niv(Imports.VertexAttrib4Niv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv = (VertexAttrib4Nsv)GL.GetDelegateForExtensionMethod("glVertexAttrib4Nsv", typeof(VertexAttrib4Nsv)) ?? new VertexAttrib4Nsv(Imports.VertexAttrib4Nsv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        internal static VertexAttrib4Nub glVertexAttrib4Nub = (VertexAttrib4Nub)GL.GetDelegateForExtensionMethod("glVertexAttrib4Nub", typeof(VertexAttrib4Nub)) ?? new VertexAttrib4Nub(Imports.VertexAttrib4Nub);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv = (VertexAttrib4Nubv)GL.GetDelegateForExtensionMethod("glVertexAttrib4Nubv", typeof(VertexAttrib4Nubv)) ?? new VertexAttrib4Nubv(Imports.VertexAttrib4Nubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv = (VertexAttrib4Nuiv)GL.GetDelegateForExtensionMethod("glVertexAttrib4Nuiv", typeof(VertexAttrib4Nuiv)) ?? new VertexAttrib4Nuiv(Imports.VertexAttrib4Nuiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv = (VertexAttrib4Nusv)GL.GetDelegateForExtensionMethod("glVertexAttrib4Nusv", typeof(VertexAttrib4Nusv)) ?? new VertexAttrib4Nusv(Imports.VertexAttrib4Nusv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4bv glVertexAttrib4bv = (VertexAttrib4bv)GL.GetDelegateForExtensionMethod("glVertexAttrib4bv", typeof(VertexAttrib4bv)) ?? new VertexAttrib4bv(Imports.VertexAttrib4bv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
        internal static VertexAttrib4d glVertexAttrib4d = (VertexAttrib4d)GL.GetDelegateForExtensionMethod("glVertexAttrib4d", typeof(VertexAttrib4d)) ?? new VertexAttrib4d(Imports.VertexAttrib4d);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
        internal unsafe static VertexAttrib4dv glVertexAttrib4dv = (VertexAttrib4dv)GL.GetDelegateForExtensionMethod("glVertexAttrib4dv", typeof(VertexAttrib4dv)) ?? new VertexAttrib4dv(Imports.VertexAttrib4dv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
        internal static VertexAttrib4f glVertexAttrib4f = (VertexAttrib4f)GL.GetDelegateForExtensionMethod("glVertexAttrib4f", typeof(VertexAttrib4f)) ?? new VertexAttrib4f(Imports.VertexAttrib4f);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
        internal unsafe static VertexAttrib4fv glVertexAttrib4fv = (VertexAttrib4fv)GL.GetDelegateForExtensionMethod("glVertexAttrib4fv", typeof(VertexAttrib4fv)) ?? new VertexAttrib4fv(Imports.VertexAttrib4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4iv glVertexAttrib4iv = (VertexAttrib4iv)GL.GetDelegateForExtensionMethod("glVertexAttrib4iv", typeof(VertexAttrib4iv)) ?? new VertexAttrib4iv(Imports.VertexAttrib4iv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexAttrib4s glVertexAttrib4s = (VertexAttrib4s)GL.GetDelegateForExtensionMethod("glVertexAttrib4s", typeof(VertexAttrib4s)) ?? new VertexAttrib4s(Imports.VertexAttrib4s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4sv glVertexAttrib4sv = (VertexAttrib4sv)GL.GetDelegateForExtensionMethod("glVertexAttrib4sv", typeof(VertexAttrib4sv)) ?? new VertexAttrib4sv(Imports.VertexAttrib4sv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv = (VertexAttrib4ubv)GL.GetDelegateForExtensionMethod("glVertexAttrib4ubv", typeof(VertexAttrib4ubv)) ?? new VertexAttrib4ubv(Imports.VertexAttrib4ubv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv = (VertexAttrib4uiv)GL.GetDelegateForExtensionMethod("glVertexAttrib4uiv", typeof(VertexAttrib4uiv)) ?? new VertexAttrib4uiv(Imports.VertexAttrib4uiv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4usv glVertexAttrib4usv = (VertexAttrib4usv)GL.GetDelegateForExtensionMethod("glVertexAttrib4usv", typeof(VertexAttrib4usv)) ?? new VertexAttrib4usv(Imports.VertexAttrib4usv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointer(UInt32 index, Int32 size, GL.Enums.VERSION_2_0 type, GL.Enums.Boolean normalized, Int32 stride, void* pointer);
        internal unsafe static VertexAttribPointer glVertexAttribPointer = (VertexAttribPointer)GL.GetDelegateForExtensionMethod("glVertexAttribPointer", typeof(VertexAttribPointer)) ?? new VertexAttribPointer(Imports.VertexAttribPointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv = (UniformMatrix2x3fv)GL.GetDelegateForExtensionMethod("glUniformMatrix2x3fv", typeof(UniformMatrix2x3fv)) ?? new UniformMatrix2x3fv(Imports.UniformMatrix2x3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv = (UniformMatrix3x2fv)GL.GetDelegateForExtensionMethod("glUniformMatrix3x2fv", typeof(UniformMatrix3x2fv)) ?? new UniformMatrix3x2fv(Imports.UniformMatrix3x2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv = (UniformMatrix2x4fv)GL.GetDelegateForExtensionMethod("glUniformMatrix2x4fv", typeof(UniformMatrix2x4fv)) ?? new UniformMatrix2x4fv(Imports.UniformMatrix2x4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv = (UniformMatrix4x2fv)GL.GetDelegateForExtensionMethod("glUniformMatrix4x2fv", typeof(UniformMatrix4x2fv)) ?? new UniformMatrix4x2fv(Imports.UniformMatrix4x2fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv = (UniformMatrix3x4fv)GL.GetDelegateForExtensionMethod("glUniformMatrix3x4fv", typeof(UniformMatrix3x4fv)) ?? new UniformMatrix3x4fv(Imports.UniformMatrix3x4fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv = (UniformMatrix4x3fv)GL.GetDelegateForExtensionMethod("glUniformMatrix4x3fv", typeof(UniformMatrix4x3fv)) ?? new UniformMatrix4x3fv(Imports.UniformMatrix4x3fv);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTextureARB(GL.Enums.ARB_multitexture texture);
        internal static ActiveTextureARB glActiveTextureARB = (ActiveTextureARB)GL.GetDelegateForExtensionMethod("glActiveTextureARB", typeof(ActiveTextureARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveTextureARB(GL.Enums.ARB_multitexture texture);
        internal static ClientActiveTextureARB glClientActiveTextureARB = (ClientActiveTextureARB)GL.GetDelegateForExtensionMethod("glClientActiveTextureARB", typeof(ClientActiveTextureARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1dARB(GL.Enums.ARB_multitexture target, Double s);
        internal static MultiTexCoord1dARB glMultiTexCoord1dARB = (MultiTexCoord1dARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1dARB", typeof(MultiTexCoord1dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1dvARB(GL.Enums.ARB_multitexture target, Double* v);
        internal unsafe static MultiTexCoord1dvARB glMultiTexCoord1dvARB = (MultiTexCoord1dvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1dvARB", typeof(MultiTexCoord1dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1fARB(GL.Enums.ARB_multitexture target, Single s);
        internal static MultiTexCoord1fARB glMultiTexCoord1fARB = (MultiTexCoord1fARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1fARB", typeof(MultiTexCoord1fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1fvARB(GL.Enums.ARB_multitexture target, Single* v);
        internal unsafe static MultiTexCoord1fvARB glMultiTexCoord1fvARB = (MultiTexCoord1fvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1fvARB", typeof(MultiTexCoord1fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1iARB(GL.Enums.ARB_multitexture target, Int32 s);
        internal static MultiTexCoord1iARB glMultiTexCoord1iARB = (MultiTexCoord1iARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1iARB", typeof(MultiTexCoord1iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1ivARB(GL.Enums.ARB_multitexture target, Int32* v);
        internal unsafe static MultiTexCoord1ivARB glMultiTexCoord1ivARB = (MultiTexCoord1ivARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1ivARB", typeof(MultiTexCoord1ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1sARB(GL.Enums.ARB_multitexture target, Int16 s);
        internal static MultiTexCoord1sARB glMultiTexCoord1sARB = (MultiTexCoord1sARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1sARB", typeof(MultiTexCoord1sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1svARB(GL.Enums.ARB_multitexture target, Int16* v);
        internal unsafe static MultiTexCoord1svARB glMultiTexCoord1svARB = (MultiTexCoord1svARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord1svARB", typeof(MultiTexCoord1svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2dARB(GL.Enums.ARB_multitexture target, Double s, Double t);
        internal static MultiTexCoord2dARB glMultiTexCoord2dARB = (MultiTexCoord2dARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2dARB", typeof(MultiTexCoord2dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2dvARB(GL.Enums.ARB_multitexture target, Double* v);
        internal unsafe static MultiTexCoord2dvARB glMultiTexCoord2dvARB = (MultiTexCoord2dvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2dvARB", typeof(MultiTexCoord2dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2fARB(GL.Enums.ARB_multitexture target, Single s, Single t);
        internal static MultiTexCoord2fARB glMultiTexCoord2fARB = (MultiTexCoord2fARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2fARB", typeof(MultiTexCoord2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2fvARB(GL.Enums.ARB_multitexture target, Single* v);
        internal unsafe static MultiTexCoord2fvARB glMultiTexCoord2fvARB = (MultiTexCoord2fvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2fvARB", typeof(MultiTexCoord2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2iARB(GL.Enums.ARB_multitexture target, Int32 s, Int32 t);
        internal static MultiTexCoord2iARB glMultiTexCoord2iARB = (MultiTexCoord2iARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2iARB", typeof(MultiTexCoord2iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2ivARB(GL.Enums.ARB_multitexture target, Int32* v);
        internal unsafe static MultiTexCoord2ivARB glMultiTexCoord2ivARB = (MultiTexCoord2ivARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2ivARB", typeof(MultiTexCoord2ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2sARB(GL.Enums.ARB_multitexture target, Int16 s, Int16 t);
        internal static MultiTexCoord2sARB glMultiTexCoord2sARB = (MultiTexCoord2sARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2sARB", typeof(MultiTexCoord2sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2svARB(GL.Enums.ARB_multitexture target, Int16* v);
        internal unsafe static MultiTexCoord2svARB glMultiTexCoord2svARB = (MultiTexCoord2svARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord2svARB", typeof(MultiTexCoord2svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3dARB(GL.Enums.ARB_multitexture target, Double s, Double t, Double r);
        internal static MultiTexCoord3dARB glMultiTexCoord3dARB = (MultiTexCoord3dARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3dARB", typeof(MultiTexCoord3dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3dvARB(GL.Enums.ARB_multitexture target, Double* v);
        internal unsafe static MultiTexCoord3dvARB glMultiTexCoord3dvARB = (MultiTexCoord3dvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3dvARB", typeof(MultiTexCoord3dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3fARB(GL.Enums.ARB_multitexture target, Single s, Single t, Single r);
        internal static MultiTexCoord3fARB glMultiTexCoord3fARB = (MultiTexCoord3fARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3fARB", typeof(MultiTexCoord3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3fvARB(GL.Enums.ARB_multitexture target, Single* v);
        internal unsafe static MultiTexCoord3fvARB glMultiTexCoord3fvARB = (MultiTexCoord3fvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3fvARB", typeof(MultiTexCoord3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3iARB(GL.Enums.ARB_multitexture target, Int32 s, Int32 t, Int32 r);
        internal static MultiTexCoord3iARB glMultiTexCoord3iARB = (MultiTexCoord3iARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3iARB", typeof(MultiTexCoord3iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3ivARB(GL.Enums.ARB_multitexture target, Int32* v);
        internal unsafe static MultiTexCoord3ivARB glMultiTexCoord3ivARB = (MultiTexCoord3ivARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3ivARB", typeof(MultiTexCoord3ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3sARB(GL.Enums.ARB_multitexture target, Int16 s, Int16 t, Int16 r);
        internal static MultiTexCoord3sARB glMultiTexCoord3sARB = (MultiTexCoord3sARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3sARB", typeof(MultiTexCoord3sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3svARB(GL.Enums.ARB_multitexture target, Int16* v);
        internal unsafe static MultiTexCoord3svARB glMultiTexCoord3svARB = (MultiTexCoord3svARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord3svARB", typeof(MultiTexCoord3svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4dARB(GL.Enums.ARB_multitexture target, Double s, Double t, Double r, Double q);
        internal static MultiTexCoord4dARB glMultiTexCoord4dARB = (MultiTexCoord4dARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4dARB", typeof(MultiTexCoord4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4dvARB(GL.Enums.ARB_multitexture target, Double* v);
        internal unsafe static MultiTexCoord4dvARB glMultiTexCoord4dvARB = (MultiTexCoord4dvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4dvARB", typeof(MultiTexCoord4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4fARB(GL.Enums.ARB_multitexture target, Single s, Single t, Single r, Single q);
        internal static MultiTexCoord4fARB glMultiTexCoord4fARB = (MultiTexCoord4fARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4fARB", typeof(MultiTexCoord4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4fvARB(GL.Enums.ARB_multitexture target, Single* v);
        internal unsafe static MultiTexCoord4fvARB glMultiTexCoord4fvARB = (MultiTexCoord4fvARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4fvARB", typeof(MultiTexCoord4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4iARB(GL.Enums.ARB_multitexture target, Int32 s, Int32 t, Int32 r, Int32 q);
        internal static MultiTexCoord4iARB glMultiTexCoord4iARB = (MultiTexCoord4iARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4iARB", typeof(MultiTexCoord4iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4ivARB(GL.Enums.ARB_multitexture target, Int32* v);
        internal unsafe static MultiTexCoord4ivARB glMultiTexCoord4ivARB = (MultiTexCoord4ivARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4ivARB", typeof(MultiTexCoord4ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4sARB(GL.Enums.ARB_multitexture target, Int16 s, Int16 t, Int16 r, Int16 q);
        internal static MultiTexCoord4sARB glMultiTexCoord4sARB = (MultiTexCoord4sARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4sARB", typeof(MultiTexCoord4sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4svARB(GL.Enums.ARB_multitexture target, Int16* v);
        internal unsafe static MultiTexCoord4svARB glMultiTexCoord4svARB = (MultiTexCoord4svARB)GL.GetDelegateForExtensionMethod("glMultiTexCoord4svARB", typeof(MultiTexCoord4svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixfARB(Single* m);
        internal unsafe static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB = (LoadTransposeMatrixfARB)GL.GetDelegateForExtensionMethod("glLoadTransposeMatrixfARB", typeof(LoadTransposeMatrixfARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixdARB(Double* m);
        internal unsafe static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB = (LoadTransposeMatrixdARB)GL.GetDelegateForExtensionMethod("glLoadTransposeMatrixdARB", typeof(LoadTransposeMatrixdARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixfARB(Single* m);
        internal unsafe static MultTransposeMatrixfARB glMultTransposeMatrixfARB = (MultTransposeMatrixfARB)GL.GetDelegateForExtensionMethod("glMultTransposeMatrixfARB", typeof(MultTransposeMatrixfARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixdARB(Double* m);
        internal unsafe static MultTransposeMatrixdARB glMultTransposeMatrixdARB = (MultTransposeMatrixdARB)GL.GetDelegateForExtensionMethod("glMultTransposeMatrixdARB", typeof(MultTransposeMatrixdARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverageARB(Single value, GL.Enums.Boolean invert);
        internal static SampleCoverageARB glSampleCoverageARB = (SampleCoverageARB)GL.GetDelegateForExtensionMethod("glSampleCoverageARB", typeof(SampleCoverageARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage3DARB(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage3DARB glCompressedTexImage3DARB = (CompressedTexImage3DARB)GL.GetDelegateForExtensionMethod("glCompressedTexImage3DARB", typeof(CompressedTexImage3DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage2DARB(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage2DARB glCompressedTexImage2DARB = (CompressedTexImage2DARB)GL.GetDelegateForExtensionMethod("glCompressedTexImage2DARB", typeof(CompressedTexImage2DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage1DARB(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
        internal unsafe static CompressedTexImage1DARB glCompressedTexImage1DARB = (CompressedTexImage1DARB)GL.GetDelegateForExtensionMethod("glCompressedTexImage1DARB", typeof(CompressedTexImage1DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage3DARB(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB = (CompressedTexSubImage3DARB)GL.GetDelegateForExtensionMethod("glCompressedTexSubImage3DARB", typeof(CompressedTexSubImage3DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage2DARB(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB = (CompressedTexSubImage2DARB)GL.GetDelegateForExtensionMethod("glCompressedTexSubImage2DARB", typeof(CompressedTexSubImage2DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage1DARB(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
        internal unsafe static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB = (CompressedTexSubImage1DARB)GL.GetDelegateForExtensionMethod("glCompressedTexSubImage1DARB", typeof(CompressedTexSubImage1DARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCompressedTexImageARB(GL.Enums.TextureTarget target, Int32 level, [Out] void* img);
        internal unsafe static GetCompressedTexImageARB glGetCompressedTexImageARB = (GetCompressedTexImageARB)GL.GetDelegateForExtensionMethod("glGetCompressedTexImageARB", typeof(GetCompressedTexImageARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfARB(GL.Enums.ARB_point_parameters pname, Single param);
        internal static PointParameterfARB glPointParameterfARB = (PointParameterfARB)GL.GetDelegateForExtensionMethod("glPointParameterfARB", typeof(PointParameterfARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvARB(GL.Enums.ARB_point_parameters pname, Single* @params);
        internal unsafe static PointParameterfvARB glPointParameterfvARB = (PointParameterfvARB)GL.GetDelegateForExtensionMethod("glPointParameterfvARB", typeof(PointParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightbvARB(Int32 size, SByte* weights);
        internal unsafe static WeightbvARB glWeightbvARB = (WeightbvARB)GL.GetDelegateForExtensionMethod("glWeightbvARB", typeof(WeightbvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightsvARB(Int32 size, Int16* weights);
        internal unsafe static WeightsvARB glWeightsvARB = (WeightsvARB)GL.GetDelegateForExtensionMethod("glWeightsvARB", typeof(WeightsvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightivARB(Int32 size, Int32* weights);
        internal unsafe static WeightivARB glWeightivARB = (WeightivARB)GL.GetDelegateForExtensionMethod("glWeightivARB", typeof(WeightivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightfvARB(Int32 size, Single* weights);
        internal unsafe static WeightfvARB glWeightfvARB = (WeightfvARB)GL.GetDelegateForExtensionMethod("glWeightfvARB", typeof(WeightfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightdvARB(Int32 size, Double* weights);
        internal unsafe static WeightdvARB glWeightdvARB = (WeightdvARB)GL.GetDelegateForExtensionMethod("glWeightdvARB", typeof(WeightdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightubvARB(Int32 size, Byte* weights);
        internal unsafe static WeightubvARB glWeightubvARB = (WeightubvARB)GL.GetDelegateForExtensionMethod("glWeightubvARB", typeof(WeightubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightusvARB(Int32 size, UInt16* weights);
        internal unsafe static WeightusvARB glWeightusvARB = (WeightusvARB)GL.GetDelegateForExtensionMethod("glWeightusvARB", typeof(WeightusvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightuivARB(Int32 size, UInt32* weights);
        internal unsafe static WeightuivARB glWeightuivARB = (WeightuivARB)GL.GetDelegateForExtensionMethod("glWeightuivARB", typeof(WeightuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightPointerARB(Int32 size, GL.Enums.ARB_vertex_blend type, Int32 stride, void* pointer);
        internal unsafe static WeightPointerARB glWeightPointerARB = (WeightPointerARB)GL.GetDelegateForExtensionMethod("glWeightPointerARB", typeof(WeightPointerARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendARB(Int32 count);
        internal static VertexBlendARB glVertexBlendARB = (VertexBlendARB)GL.GetDelegateForExtensionMethod("glVertexBlendARB", typeof(VertexBlendARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CurrentPaletteMatrixARB(Int32 index);
        internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB = (CurrentPaletteMatrixARB)GL.GetDelegateForExtensionMethod("glCurrentPaletteMatrixARB", typeof(CurrentPaletteMatrixARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexubvARB(Int32 size, Byte* indices);
        internal unsafe static MatrixIndexubvARB glMatrixIndexubvARB = (MatrixIndexubvARB)GL.GetDelegateForExtensionMethod("glMatrixIndexubvARB", typeof(MatrixIndexubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexusvARB(Int32 size, UInt16* indices);
        internal unsafe static MatrixIndexusvARB glMatrixIndexusvARB = (MatrixIndexusvARB)GL.GetDelegateForExtensionMethod("glMatrixIndexusvARB", typeof(MatrixIndexusvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexuivARB(Int32 size, UInt32* indices);
        internal unsafe static MatrixIndexuivARB glMatrixIndexuivARB = (MatrixIndexuivARB)GL.GetDelegateForExtensionMethod("glMatrixIndexuivARB", typeof(MatrixIndexuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexPointerARB(Int32 size, GL.Enums.ARB_matrix_palette type, Int32 stride, void* pointer);
        internal unsafe static MatrixIndexPointerARB glMatrixIndexPointerARB = (MatrixIndexPointerARB)GL.GetDelegateForExtensionMethod("glMatrixIndexPointerARB", typeof(MatrixIndexPointerARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2dARB(Double x, Double y);
        internal static WindowPos2dARB glWindowPos2dARB = (WindowPos2dARB)GL.GetDelegateForExtensionMethod("glWindowPos2dARB", typeof(WindowPos2dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dvARB(Double* v);
        internal unsafe static WindowPos2dvARB glWindowPos2dvARB = (WindowPos2dvARB)GL.GetDelegateForExtensionMethod("glWindowPos2dvARB", typeof(WindowPos2dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2fARB(Single x, Single y);
        internal static WindowPos2fARB glWindowPos2fARB = (WindowPos2fARB)GL.GetDelegateForExtensionMethod("glWindowPos2fARB", typeof(WindowPos2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fvARB(Single* v);
        internal unsafe static WindowPos2fvARB glWindowPos2fvARB = (WindowPos2fvARB)GL.GetDelegateForExtensionMethod("glWindowPos2fvARB", typeof(WindowPos2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2iARB(Int32 x, Int32 y);
        internal static WindowPos2iARB glWindowPos2iARB = (WindowPos2iARB)GL.GetDelegateForExtensionMethod("glWindowPos2iARB", typeof(WindowPos2iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2ivARB(Int32* v);
        internal unsafe static WindowPos2ivARB glWindowPos2ivARB = (WindowPos2ivARB)GL.GetDelegateForExtensionMethod("glWindowPos2ivARB", typeof(WindowPos2ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2sARB(Int16 x, Int16 y);
        internal static WindowPos2sARB glWindowPos2sARB = (WindowPos2sARB)GL.GetDelegateForExtensionMethod("glWindowPos2sARB", typeof(WindowPos2sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2svARB(Int16* v);
        internal unsafe static WindowPos2svARB glWindowPos2svARB = (WindowPos2svARB)GL.GetDelegateForExtensionMethod("glWindowPos2svARB", typeof(WindowPos2svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3dARB(Double x, Double y, Double z);
        internal static WindowPos3dARB glWindowPos3dARB = (WindowPos3dARB)GL.GetDelegateForExtensionMethod("glWindowPos3dARB", typeof(WindowPos3dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dvARB(Double* v);
        internal unsafe static WindowPos3dvARB glWindowPos3dvARB = (WindowPos3dvARB)GL.GetDelegateForExtensionMethod("glWindowPos3dvARB", typeof(WindowPos3dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3fARB(Single x, Single y, Single z);
        internal static WindowPos3fARB glWindowPos3fARB = (WindowPos3fARB)GL.GetDelegateForExtensionMethod("glWindowPos3fARB", typeof(WindowPos3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fvARB(Single* v);
        internal unsafe static WindowPos3fvARB glWindowPos3fvARB = (WindowPos3fvARB)GL.GetDelegateForExtensionMethod("glWindowPos3fvARB", typeof(WindowPos3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
        internal static WindowPos3iARB glWindowPos3iARB = (WindowPos3iARB)GL.GetDelegateForExtensionMethod("glWindowPos3iARB", typeof(WindowPos3iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3ivARB(Int32* v);
        internal unsafe static WindowPos3ivARB glWindowPos3ivARB = (WindowPos3ivARB)GL.GetDelegateForExtensionMethod("glWindowPos3ivARB", typeof(WindowPos3ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
        internal static WindowPos3sARB glWindowPos3sARB = (WindowPos3sARB)GL.GetDelegateForExtensionMethod("glWindowPos3sARB", typeof(WindowPos3sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3svARB(Int16* v);
        internal unsafe static WindowPos3svARB glWindowPos3svARB = (WindowPos3svARB)GL.GetDelegateForExtensionMethod("glWindowPos3svARB", typeof(WindowPos3svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dARB(UInt32 index, Double x);
        internal static VertexAttrib1dARB glVertexAttrib1dARB = (VertexAttrib1dARB)GL.GetDelegateForExtensionMethod("glVertexAttrib1dARB", typeof(VertexAttrib1dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib1dvARB glVertexAttrib1dvARB = (VertexAttrib1dvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib1dvARB", typeof(VertexAttrib1dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fARB(UInt32 index, Single x);
        internal static VertexAttrib1fARB glVertexAttrib1fARB = (VertexAttrib1fARB)GL.GetDelegateForExtensionMethod("glVertexAttrib1fARB", typeof(VertexAttrib1fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib1fvARB glVertexAttrib1fvARB = (VertexAttrib1fvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib1fvARB", typeof(VertexAttrib1fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sARB(UInt32 index, Int16 x);
        internal static VertexAttrib1sARB glVertexAttrib1sARB = (VertexAttrib1sARB)GL.GetDelegateForExtensionMethod("glVertexAttrib1sARB", typeof(VertexAttrib1sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib1svARB glVertexAttrib1svARB = (VertexAttrib1svARB)GL.GetDelegateForExtensionMethod("glVertexAttrib1svARB", typeof(VertexAttrib1svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dARB(UInt32 index, Double x, Double y);
        internal static VertexAttrib2dARB glVertexAttrib2dARB = (VertexAttrib2dARB)GL.GetDelegateForExtensionMethod("glVertexAttrib2dARB", typeof(VertexAttrib2dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib2dvARB glVertexAttrib2dvARB = (VertexAttrib2dvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib2dvARB", typeof(VertexAttrib2dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fARB(UInt32 index, Single x, Single y);
        internal static VertexAttrib2fARB glVertexAttrib2fARB = (VertexAttrib2fARB)GL.GetDelegateForExtensionMethod("glVertexAttrib2fARB", typeof(VertexAttrib2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib2fvARB glVertexAttrib2fvARB = (VertexAttrib2fvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib2fvARB", typeof(VertexAttrib2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
        internal static VertexAttrib2sARB glVertexAttrib2sARB = (VertexAttrib2sARB)GL.GetDelegateForExtensionMethod("glVertexAttrib2sARB", typeof(VertexAttrib2sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib2svARB glVertexAttrib2svARB = (VertexAttrib2svARB)GL.GetDelegateForExtensionMethod("glVertexAttrib2svARB", typeof(VertexAttrib2svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
        internal static VertexAttrib3dARB glVertexAttrib3dARB = (VertexAttrib3dARB)GL.GetDelegateForExtensionMethod("glVertexAttrib3dARB", typeof(VertexAttrib3dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib3dvARB glVertexAttrib3dvARB = (VertexAttrib3dvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib3dvARB", typeof(VertexAttrib3dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
        internal static VertexAttrib3fARB glVertexAttrib3fARB = (VertexAttrib3fARB)GL.GetDelegateForExtensionMethod("glVertexAttrib3fARB", typeof(VertexAttrib3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib3fvARB glVertexAttrib3fvARB = (VertexAttrib3fvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib3fvARB", typeof(VertexAttrib3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
        internal static VertexAttrib3sARB glVertexAttrib3sARB = (VertexAttrib3sARB)GL.GetDelegateForExtensionMethod("glVertexAttrib3sARB", typeof(VertexAttrib3sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib3svARB glVertexAttrib3svARB = (VertexAttrib3svARB)GL.GetDelegateForExtensionMethod("glVertexAttrib3svARB", typeof(VertexAttrib3svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NbvARB(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4NbvARB glVertexAttrib4NbvARB = (VertexAttrib4NbvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NbvARB", typeof(VertexAttrib4NbvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NivARB(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4NivARB glVertexAttrib4NivARB = (VertexAttrib4NivARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NivARB", typeof(VertexAttrib4NivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NsvARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4NsvARB glVertexAttrib4NsvARB = (VertexAttrib4NsvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NsvARB", typeof(VertexAttrib4NsvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        internal static VertexAttrib4NubARB glVertexAttrib4NubARB = (VertexAttrib4NubARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NubARB", typeof(VertexAttrib4NubARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NubvARB(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4NubvARB glVertexAttrib4NubvARB = (VertexAttrib4NubvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NubvARB", typeof(VertexAttrib4NubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4NuivARB glVertexAttrib4NuivARB = (VertexAttrib4NuivARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NuivARB", typeof(VertexAttrib4NuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4NusvARB glVertexAttrib4NusvARB = (VertexAttrib4NusvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4NusvARB", typeof(VertexAttrib4NusvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bvARB(UInt32 index, SByte* v);
        internal unsafe static VertexAttrib4bvARB glVertexAttrib4bvARB = (VertexAttrib4bvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4bvARB", typeof(VertexAttrib4bvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
        internal static VertexAttrib4dARB glVertexAttrib4dARB = (VertexAttrib4dARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4dARB", typeof(VertexAttrib4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvARB(UInt32 index, Double* v);
        internal unsafe static VertexAttrib4dvARB glVertexAttrib4dvARB = (VertexAttrib4dvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4dvARB", typeof(VertexAttrib4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
        internal static VertexAttrib4fARB glVertexAttrib4fARB = (VertexAttrib4fARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4fARB", typeof(VertexAttrib4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvARB(UInt32 index, Single* v);
        internal unsafe static VertexAttrib4fvARB glVertexAttrib4fvARB = (VertexAttrib4fvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4fvARB", typeof(VertexAttrib4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ivARB(UInt32 index, Int32* v);
        internal unsafe static VertexAttrib4ivARB glVertexAttrib4ivARB = (VertexAttrib4ivARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4ivARB", typeof(VertexAttrib4ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexAttrib4sARB glVertexAttrib4sARB = (VertexAttrib4sARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4sARB", typeof(VertexAttrib4sARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svARB(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4svARB glVertexAttrib4svARB = (VertexAttrib4svARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4svARB", typeof(VertexAttrib4svARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvARB(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4ubvARB glVertexAttrib4ubvARB = (VertexAttrib4ubvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4ubvARB", typeof(VertexAttrib4ubvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uivARB(UInt32 index, UInt32* v);
        internal unsafe static VertexAttrib4uivARB glVertexAttrib4uivARB = (VertexAttrib4uivARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4uivARB", typeof(VertexAttrib4uivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usvARB(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4usvARB glVertexAttrib4usvARB = (VertexAttrib4usvARB)GL.GetDelegateForExtensionMethod("glVertexAttrib4usvARB", typeof(VertexAttrib4usvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointerARB(UInt32 index, Int32 size, GL.Enums.ARB_vertex_program type, GL.Enums.Boolean normalized, Int32 stride, void* pointer);
        internal unsafe static VertexAttribPointerARB glVertexAttribPointerARB = (VertexAttribPointerARB)GL.GetDelegateForExtensionMethod("glVertexAttribPointerARB", typeof(VertexAttribPointerARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArrayARB(UInt32 index);
        internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB = (EnableVertexAttribArrayARB)GL.GetDelegateForExtensionMethod("glEnableVertexAttribArrayARB", typeof(EnableVertexAttribArrayARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArrayARB(UInt32 index);
        internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB = (DisableVertexAttribArrayARB)GL.GetDelegateForExtensionMethod("glDisableVertexAttribArrayARB", typeof(DisableVertexAttribArrayARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program format, Int32 len, void* @string);
        internal unsafe static ProgramStringARB glProgramStringARB = (ProgramStringARB)GL.GetDelegateForExtensionMethod("glProgramStringARB", typeof(ProgramStringARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramARB(GL.Enums.ARB_vertex_program target, UInt32 program);
        internal static BindProgramARB glBindProgramARB = (BindProgramARB)GL.GetDelegateForExtensionMethod("glBindProgramARB", typeof(BindProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramsARB(Int32 n, UInt32* programs);
        internal unsafe static DeleteProgramsARB glDeleteProgramsARB = (DeleteProgramsARB)GL.GetDelegateForExtensionMethod("glDeleteProgramsARB", typeof(DeleteProgramsARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramsARB(Int32 n, [Out] UInt32* programs);
        internal unsafe static GenProgramsARB glGenProgramsARB = (GenProgramsARB)GL.GetDelegateForExtensionMethod("glGenProgramsARB", typeof(GenProgramsARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameter4dARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double x, Double y, Double z, Double w);
        internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB = (ProgramEnvParameter4dARB)GL.GetDelegateForExtensionMethod("glProgramEnvParameter4dARB", typeof(ProgramEnvParameter4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameter4dvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double* @params);
        internal unsafe static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB = (ProgramEnvParameter4dvARB)GL.GetDelegateForExtensionMethod("glProgramEnvParameter4dvARB", typeof(ProgramEnvParameter4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameter4fARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single x, Single y, Single z, Single w);
        internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB = (ProgramEnvParameter4fARB)GL.GetDelegateForExtensionMethod("glProgramEnvParameter4fARB", typeof(ProgramEnvParameter4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameter4fvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single* @params);
        internal unsafe static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB = (ProgramEnvParameter4fvARB)GL.GetDelegateForExtensionMethod("glProgramEnvParameter4fvARB", typeof(ProgramEnvParameter4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameter4dARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double x, Double y, Double z, Double w);
        internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB = (ProgramLocalParameter4dARB)GL.GetDelegateForExtensionMethod("glProgramLocalParameter4dARB", typeof(ProgramLocalParameter4dARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameter4dvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double* @params);
        internal unsafe static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB = (ProgramLocalParameter4dvARB)GL.GetDelegateForExtensionMethod("glProgramLocalParameter4dvARB", typeof(ProgramLocalParameter4dvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameter4fARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single x, Single y, Single z, Single w);
        internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB = (ProgramLocalParameter4fARB)GL.GetDelegateForExtensionMethod("glProgramLocalParameter4fARB", typeof(ProgramLocalParameter4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameter4fvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single* @params);
        internal unsafe static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB = (ProgramLocalParameter4fvARB)GL.GetDelegateForExtensionMethod("glProgramLocalParameter4fvARB", typeof(ProgramLocalParameter4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterdvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Double* @params);
        internal unsafe static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB = (GetProgramEnvParameterdvARB)GL.GetDelegateForExtensionMethod("glGetProgramEnvParameterdvARB", typeof(GetProgramEnvParameterdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterfvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Single* @params);
        internal unsafe static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB = (GetProgramEnvParameterfvARB)GL.GetDelegateForExtensionMethod("glGetProgramEnvParameterfvARB", typeof(GetProgramEnvParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterdvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Double* @params);
        internal unsafe static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB = (GetProgramLocalParameterdvARB)GL.GetDelegateForExtensionMethod("glGetProgramLocalParameterdvARB", typeof(GetProgramLocalParameterdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterfvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Single* @params);
        internal unsafe static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB = (GetProgramLocalParameterfvARB)GL.GetDelegateForExtensionMethod("glGetProgramLocalParameterfvARB", typeof(GetProgramLocalParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, [Out] Int32* @params);
        internal unsafe static GetProgramivARB glGetProgramivARB = (GetProgramivARB)GL.GetDelegateForExtensionMethod("glGetProgramivARB", typeof(GetProgramivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, [Out] void* @string);
        internal unsafe static GetProgramStringARB glGetProgramStringARB = (GetProgramStringARB)GL.GetDelegateForExtensionMethod("glGetProgramStringARB", typeof(GetProgramStringARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] Double* @params);
        internal unsafe static GetVertexAttribdvARB glGetVertexAttribdvARB = (GetVertexAttribdvARB)GL.GetDelegateForExtensionMethod("glGetVertexAttribdvARB", typeof(GetVertexAttribdvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribfvARB glGetVertexAttribfvARB = (GetVertexAttribfvARB)GL.GetDelegateForExtensionMethod("glGetVertexAttribfvARB", typeof(GetVertexAttribfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribivARB glGetVertexAttribivARB = (GetVertexAttribivARB)GL.GetDelegateForExtensionMethod("glGetVertexAttribivARB", typeof(GetVertexAttribivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointervARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] void* pointer);
        internal unsafe static GetVertexAttribPointervARB glGetVertexAttribPointervARB = (GetVertexAttribPointervARB)GL.GetDelegateForExtensionMethod("glGetVertexAttribPointervARB", typeof(GetVertexAttribPointervARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsProgramARB(UInt32 program);
        internal static IsProgramARB glIsProgramARB = (IsProgramARB)GL.GetDelegateForExtensionMethod("glIsProgramARB", typeof(IsProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferARB(GL.Enums.ARB_vertex_buffer_object target, UInt32 buffer);
        internal static BindBufferARB glBindBufferARB = (BindBufferARB)GL.GetDelegateForExtensionMethod("glBindBufferARB", typeof(BindBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffersARB(Int32 n, UInt32* buffers);
        internal unsafe static DeleteBuffersARB glDeleteBuffersARB = (DeleteBuffersARB)GL.GetDelegateForExtensionMethod("glDeleteBuffersARB", typeof(DeleteBuffersARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffersARB(Int32 n, [Out] UInt32* buffers);
        internal unsafe static GenBuffersARB glGenBuffersARB = (GenBuffersARB)GL.GetDelegateForExtensionMethod("glGenBuffersARB", typeof(GenBuffersARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsBufferARB(UInt32 buffer);
        internal static IsBufferARB glIsBufferARB = (IsBufferARB)GL.GetDelegateForExtensionMethod("glIsBufferARB", typeof(IsBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferDataARB(GL.Enums.ARB_vertex_buffer_object target, IntPtr size, void* data, GL.Enums.ARB_vertex_buffer_object usage);
        internal unsafe static BufferDataARB glBufferDataARB = (BufferDataARB)GL.GetDelegateForExtensionMethod("glBufferDataARB", typeof(BufferDataARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, IntPtr offset, IntPtr size, void* data);
        internal unsafe static BufferSubDataARB glBufferSubDataARB = (BufferSubDataARB)GL.GetDelegateForExtensionMethod("glBufferSubDataARB", typeof(BufferSubDataARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, IntPtr offset, IntPtr size, [Out] void* data);
        internal unsafe static GetBufferSubDataARB glGetBufferSubDataARB = (GetBufferSubDataARB)GL.GetDelegateForExtensionMethod("glGetBufferSubDataARB", typeof(GetBufferSubDataARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr MapBufferARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object access);
        internal static MapBufferARB glMapBufferARB = (MapBufferARB)GL.GetDelegateForExtensionMethod("glMapBufferARB", typeof(MapBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean UnmapBufferARB(GL.Enums.ARB_vertex_buffer_object target);
        internal static UnmapBufferARB glUnmapBufferARB = (UnmapBufferARB)GL.GetDelegateForExtensionMethod("glUnmapBufferARB", typeof(UnmapBufferARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameterivARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, [Out] Int32* @params);
        internal unsafe static GetBufferParameterivARB glGetBufferParameterivARB = (GetBufferParameterivARB)GL.GetDelegateForExtensionMethod("glGetBufferParameterivARB", typeof(GetBufferParameterivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferPointervARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, [Out] void* @params);
        internal unsafe static GetBufferPointervARB glGetBufferPointervARB = (GetBufferPointervARB)GL.GetDelegateForExtensionMethod("glGetBufferPointervARB", typeof(GetBufferPointervARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueriesARB(Int32 n, [Out] UInt32* ids);
        internal unsafe static GenQueriesARB glGenQueriesARB = (GenQueriesARB)GL.GetDelegateForExtensionMethod("glGenQueriesARB", typeof(GenQueriesARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueriesARB(Int32 n, UInt32* ids);
        internal unsafe static DeleteQueriesARB glDeleteQueriesARB = (DeleteQueriesARB)GL.GetDelegateForExtensionMethod("glDeleteQueriesARB", typeof(DeleteQueriesARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsQueryARB(UInt32 id);
        internal static IsQueryARB glIsQueryARB = (IsQueryARB)GL.GetDelegateForExtensionMethod("glIsQueryARB", typeof(IsQueryARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQueryARB(GL.Enums.ARB_occlusion_query target, UInt32 id);
        internal static BeginQueryARB glBeginQueryARB = (BeginQueryARB)GL.GetDelegateForExtensionMethod("glBeginQueryARB", typeof(BeginQueryARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQueryARB(GL.Enums.ARB_occlusion_query target);
        internal static EndQueryARB glEndQueryARB = (EndQueryARB)GL.GetDelegateForExtensionMethod("glEndQueryARB", typeof(EndQueryARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryivARB(GL.Enums.ARB_occlusion_query target, GL.Enums.ARB_occlusion_query pname, [Out] Int32* @params);
        internal unsafe static GetQueryivARB glGetQueryivARB = (GetQueryivARB)GL.GetDelegateForExtensionMethod("glGetQueryivARB", typeof(GetQueryivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectivARB(UInt32 id, GL.Enums.ARB_occlusion_query pname, [Out] Int32* @params);
        internal unsafe static GetQueryObjectivARB glGetQueryObjectivARB = (GetQueryObjectivARB)GL.GetDelegateForExtensionMethod("glGetQueryObjectivARB", typeof(GetQueryObjectivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuivARB(UInt32 id, GL.Enums.ARB_occlusion_query pname, [Out] UInt32* @params);
        internal unsafe static GetQueryObjectuivARB glGetQueryObjectuivARB = (GetQueryObjectuivARB)GL.GetDelegateForExtensionMethod("glGetQueryObjectuivARB", typeof(GetQueryObjectuivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteObjectARB(UInt32 obj);
        internal static DeleteObjectARB glDeleteObjectARB = (DeleteObjectARB)GL.GetDelegateForExtensionMethod("glDeleteObjectARB", typeof(DeleteObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetHandleARB(GL.Enums.ARB_shader_objects pname);
        internal static GetHandleARB glGetHandleARB = (GetHandleARB)GL.GetDelegateForExtensionMethod("glGetHandleARB", typeof(GetHandleARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
        internal static DetachObjectARB glDetachObjectARB = (DetachObjectARB)GL.GetDelegateForExtensionMethod("glDetachObjectARB", typeof(DetachObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateShaderObjectARB(GL.Enums.ARB_shader_objects shaderType);
        internal static CreateShaderObjectARB glCreateShaderObjectARB = (CreateShaderObjectARB)GL.GetDelegateForExtensionMethod("glCreateShaderObjectARB", typeof(CreateShaderObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSourceARB(UInt32 shaderObj, Int32 count, System.String[] @string, Int32* length);
        internal unsafe static ShaderSourceARB glShaderSourceARB = (ShaderSourceARB)GL.GetDelegateForExtensionMethod("glShaderSourceARB", typeof(ShaderSourceARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShaderARB(UInt32 shaderObj);
        internal static CompileShaderARB glCompileShaderARB = (CompileShaderARB)GL.GetDelegateForExtensionMethod("glCompileShaderARB", typeof(CompileShaderARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 CreateProgramObjectARB();
        internal static CreateProgramObjectARB glCreateProgramObjectARB = (CreateProgramObjectARB)GL.GetDelegateForExtensionMethod("glCreateProgramObjectARB", typeof(CreateProgramObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachObjectARB(UInt32 containerObj, UInt32 obj);
        internal static AttachObjectARB glAttachObjectARB = (AttachObjectARB)GL.GetDelegateForExtensionMethod("glAttachObjectARB", typeof(AttachObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgramARB(UInt32 programObj);
        internal static LinkProgramARB glLinkProgramARB = (LinkProgramARB)GL.GetDelegateForExtensionMethod("glLinkProgramARB", typeof(LinkProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgramObjectARB(UInt32 programObj);
        internal static UseProgramObjectARB glUseProgramObjectARB = (UseProgramObjectARB)GL.GetDelegateForExtensionMethod("glUseProgramObjectARB", typeof(UseProgramObjectARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgramARB(UInt32 programObj);
        internal static ValidateProgramARB glValidateProgramARB = (ValidateProgramARB)GL.GetDelegateForExtensionMethod("glValidateProgramARB", typeof(ValidateProgramARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1fARB(Int32 location, Single v0);
        internal static Uniform1fARB glUniform1fARB = (Uniform1fARB)GL.GetDelegateForExtensionMethod("glUniform1fARB", typeof(Uniform1fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2fARB(Int32 location, Single v0, Single v1);
        internal static Uniform2fARB glUniform2fARB = (Uniform2fARB)GL.GetDelegateForExtensionMethod("glUniform2fARB", typeof(Uniform2fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
        internal static Uniform3fARB glUniform3fARB = (Uniform3fARB)GL.GetDelegateForExtensionMethod("glUniform3fARB", typeof(Uniform3fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
        internal static Uniform4fARB glUniform4fARB = (Uniform4fARB)GL.GetDelegateForExtensionMethod("glUniform4fARB", typeof(Uniform4fARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1iARB(Int32 location, Int32 v0);
        internal static Uniform1iARB glUniform1iARB = (Uniform1iARB)GL.GetDelegateForExtensionMethod("glUniform1iARB", typeof(Uniform1iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
        internal static Uniform2iARB glUniform2iARB = (Uniform2iARB)GL.GetDelegateForExtensionMethod("glUniform2iARB", typeof(Uniform2iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        internal static Uniform3iARB glUniform3iARB = (Uniform3iARB)GL.GetDelegateForExtensionMethod("glUniform3iARB", typeof(Uniform3iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        internal static Uniform4iARB glUniform4iARB = (Uniform4iARB)GL.GetDelegateForExtensionMethod("glUniform4iARB", typeof(Uniform4iARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform1fvARB glUniform1fvARB = (Uniform1fvARB)GL.GetDelegateForExtensionMethod("glUniform1fvARB", typeof(Uniform1fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform2fvARB glUniform2fvARB = (Uniform2fvARB)GL.GetDelegateForExtensionMethod("glUniform2fvARB", typeof(Uniform2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform3fvARB glUniform3fvARB = (Uniform3fvARB)GL.GetDelegateForExtensionMethod("glUniform3fvARB", typeof(Uniform3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fvARB(Int32 location, Int32 count, Single* value);
        internal unsafe static Uniform4fvARB glUniform4fvARB = (Uniform4fvARB)GL.GetDelegateForExtensionMethod("glUniform4fvARB", typeof(Uniform4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform1ivARB glUniform1ivARB = (Uniform1ivARB)GL.GetDelegateForExtensionMethod("glUniform1ivARB", typeof(Uniform1ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform2ivARB glUniform2ivARB = (Uniform2ivARB)GL.GetDelegateForExtensionMethod("glUniform2ivARB", typeof(Uniform2ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform3ivARB glUniform3ivARB = (Uniform3ivARB)GL.GetDelegateForExtensionMethod("glUniform3ivARB", typeof(Uniform3ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
        internal unsafe static Uniform4ivARB glUniform4ivARB = (Uniform4ivARB)GL.GetDelegateForExtensionMethod("glUniform4ivARB", typeof(Uniform4ivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fvARB(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix2fvARB glUniformMatrix2fvARB = (UniformMatrix2fvARB)GL.GetDelegateForExtensionMethod("glUniformMatrix2fvARB", typeof(UniformMatrix2fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fvARB(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix3fvARB glUniformMatrix3fvARB = (UniformMatrix3fvARB)GL.GetDelegateForExtensionMethod("glUniformMatrix3fvARB", typeof(UniformMatrix3fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fvARB(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
        internal unsafe static UniformMatrix4fvARB glUniformMatrix4fvARB = (UniformMatrix4fvARB)GL.GetDelegateForExtensionMethod("glUniformMatrix4fvARB", typeof(UniformMatrix4fvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectParameterfvARB(UInt32 obj, GL.Enums.ARB_shader_objects pname, [Out] Single* @params);
        internal unsafe static GetObjectParameterfvARB glGetObjectParameterfvARB = (GetObjectParameterfvARB)GL.GetDelegateForExtensionMethod("glGetObjectParameterfvARB", typeof(GetObjectParameterfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectParameterivARB(UInt32 obj, GL.Enums.ARB_shader_objects pname, [Out] Int32* @params);
        internal unsafe static GetObjectParameterivARB glGetObjectParameterivARB = (GetObjectParameterivARB)GL.GetDelegateForExtensionMethod("glGetObjectParameterivARB", typeof(GetObjectParameterivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInfoLogARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
        internal unsafe static GetInfoLogARB glGetInfoLogARB = (GetInfoLogARB)GL.GetDelegateForExtensionMethod("glGetInfoLogARB", typeof(GetInfoLogARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
        internal unsafe static GetAttachedObjectsARB glGetAttachedObjectsARB = (GetAttachedObjectsARB)GL.GetDelegateForExtensionMethod("glGetAttachedObjectsARB", typeof(GetAttachedObjectsARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformLocationARB(UInt32 programObj, System.String name);
        internal static GetUniformLocationARB glGetUniformLocationARB = (GetUniformLocationARB)GL.GetDelegateForExtensionMethod("glGetUniformLocationARB", typeof(GetUniformLocationARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.ARB_shader_objects* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveUniformARB glGetActiveUniformARB = (GetActiveUniformARB)GL.GetDelegateForExtensionMethod("glGetActiveUniformARB", typeof(GetActiveUniformARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfvARB(UInt32 programObj, Int32 location, [Out] Single* @params);
        internal unsafe static GetUniformfvARB glGetUniformfvARB = (GetUniformfvARB)GL.GetDelegateForExtensionMethod("glGetUniformfvARB", typeof(GetUniformfvARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformivARB(UInt32 programObj, Int32 location, [Out] Int32* @params);
        internal unsafe static GetUniformivARB glGetUniformivARB = (GetUniformivARB)GL.GetDelegateForExtensionMethod("glGetUniformivARB", typeof(GetUniformivARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
        internal unsafe static GetShaderSourceARB glGetShaderSourceARB = (GetShaderSourceARB)GL.GetDelegateForExtensionMethod("glGetShaderSourceARB", typeof(GetShaderSourceARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindAttribLocationARB(UInt32 programObj, UInt32 index, System.String name);
        internal static BindAttribLocationARB glBindAttribLocationARB = (BindAttribLocationARB)GL.GetDelegateForExtensionMethod("glBindAttribLocationARB", typeof(BindAttribLocationARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.ARB_vertex_shader* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveAttribARB glGetActiveAttribARB = (GetActiveAttribARB)GL.GetDelegateForExtensionMethod("glGetActiveAttribARB", typeof(GetActiveAttribARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetAttribLocationARB(UInt32 programObj, System.String name);
        internal static GetAttribLocationARB glGetAttribLocationARB = (GetAttribLocationARB)GL.GetDelegateForExtensionMethod("glGetAttribLocationARB", typeof(GetAttribLocationARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersARB(Int32 n, GL.Enums.ARB_draw_buffers* bufs);
        internal unsafe static DrawBuffersARB glDrawBuffersARB = (DrawBuffersARB)GL.GetDelegateForExtensionMethod("glDrawBuffersARB", typeof(DrawBuffersARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClampColorARB(GL.Enums.ARB_color_buffer_float target, GL.Enums.ARB_color_buffer_float clamp);
        internal static ClampColorARB glClampColorARB = (ClampColorARB)GL.GetDelegateForExtensionMethod("glClampColorARB", typeof(ClampColorARB));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
        internal static BlendColorEXT glBlendColorEXT = (BlendColorEXT)GL.GetDelegateForExtensionMethod("glBlendColorEXT", typeof(BlendColorEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffsetEXT(Single factor, Single bias);
        internal static PolygonOffsetEXT glPolygonOffsetEXT = (PolygonOffsetEXT)GL.GetDelegateForExtensionMethod("glPolygonOffsetEXT", typeof(PolygonOffsetEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage3DEXT(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexImage3DEXT glTexImage3DEXT = (TexImage3DEXT)GL.GetDelegateForExtensionMethod("glTexImage3DEXT", typeof(TexImage3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage3DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage3DEXT glTexSubImage3DEXT = (TexSubImage3DEXT)GL.GetDelegateForExtensionMethod("glTexSubImage3DEXT", typeof(TexSubImage3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, [Out] Single* weights);
        internal unsafe static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS = (GetTexFilterFuncSGIS)GL.GetDelegateForExtensionMethod("glGetTexFilterFuncSGIS", typeof(GetTexFilterFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, Int32 n, Single* weights);
        internal unsafe static TexFilterFuncSGIS glTexFilterFuncSGIS = (TexFilterFuncSGIS)GL.GetDelegateForExtensionMethod("glTexFilterFuncSGIS", typeof(TexFilterFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage1DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage1DEXT glTexSubImage1DEXT = (TexSubImage1DEXT)GL.GetDelegateForExtensionMethod("glTexSubImage1DEXT", typeof(TexSubImage1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage2DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage2DEXT glTexSubImage2DEXT = (TexSubImage2DEXT)GL.GetDelegateForExtensionMethod("glTexSubImage2DEXT", typeof(TexSubImage2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1DEXT(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
        internal static CopyTexImage1DEXT glCopyTexImage1DEXT = (CopyTexImage1DEXT)GL.GetDelegateForExtensionMethod("glCopyTexImage1DEXT", typeof(CopyTexImage1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2DEXT(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        internal static CopyTexImage2DEXT glCopyTexImage2DEXT = (CopyTexImage2DEXT)GL.GetDelegateForExtensionMethod("glCopyTexImage2DEXT", typeof(CopyTexImage2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT = (CopyTexSubImage1DEXT)GL.GetDelegateForExtensionMethod("glCopyTexSubImage1DEXT", typeof(CopyTexSubImage1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT = (CopyTexSubImage2DEXT)GL.GetDelegateForExtensionMethod("glCopyTexSubImage2DEXT", typeof(CopyTexSubImage2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT = (CopyTexSubImage3DEXT)GL.GetDelegateForExtensionMethod("glCopyTexSubImage3DEXT", typeof(CopyTexSubImage3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
        internal unsafe static GetHistogramEXT glGetHistogramEXT = (GetHistogramEXT)GL.GetDelegateForExtensionMethod("glGetHistogramEXT", typeof(GetHistogramEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterfvEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, [Out] Single* @params);
        internal unsafe static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT = (GetHistogramParameterfvEXT)GL.GetDelegateForExtensionMethod("glGetHistogramParameterfvEXT", typeof(GetHistogramParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterivEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, [Out] Int32* @params);
        internal unsafe static GetHistogramParameterivEXT glGetHistogramParameterivEXT = (GetHistogramParameterivEXT)GL.GetDelegateForExtensionMethod("glGetHistogramParameterivEXT", typeof(GetHistogramParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
        internal unsafe static GetMinmaxEXT glGetMinmaxEXT = (GetMinmaxEXT)GL.GetDelegateForExtensionMethod("glGetMinmaxEXT", typeof(GetMinmaxEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterfvEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, [Out] Single* @params);
        internal unsafe static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT = (GetMinmaxParameterfvEXT)GL.GetDelegateForExtensionMethod("glGetMinmaxParameterfvEXT", typeof(GetMinmaxParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterivEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, [Out] Int32* @params);
        internal unsafe static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT = (GetMinmaxParameterivEXT)GL.GetDelegateForExtensionMethod("glGetMinmaxParameterivEXT", typeof(GetMinmaxParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void HistogramEXT(GL.Enums.HistogramTargetEXT target, Int32 width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static HistogramEXT glHistogramEXT = (HistogramEXT)GL.GetDelegateForExtensionMethod("glHistogramEXT", typeof(HistogramEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static MinmaxEXT glMinmaxEXT = (MinmaxEXT)GL.GetDelegateForExtensionMethod("glMinmaxEXT", typeof(MinmaxEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetHistogramEXT(GL.Enums.HistogramTargetEXT target);
        internal static ResetHistogramEXT glResetHistogramEXT = (ResetHistogramEXT)GL.GetDelegateForExtensionMethod("glResetHistogramEXT", typeof(ResetHistogramEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetMinmaxEXT(GL.Enums.MinmaxTargetEXT target);
        internal static ResetMinmaxEXT glResetMinmaxEXT = (ResetMinmaxEXT)GL.GetDelegateForExtensionMethod("glResetMinmaxEXT", typeof(ResetMinmaxEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal unsafe static ConvolutionFilter1DEXT glConvolutionFilter1DEXT = (ConvolutionFilter1DEXT)GL.GetDelegateForExtensionMethod("glConvolutionFilter1DEXT", typeof(ConvolutionFilter1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal unsafe static ConvolutionFilter2DEXT glConvolutionFilter2DEXT = (ConvolutionFilter2DEXT)GL.GetDelegateForExtensionMethod("glConvolutionFilter2DEXT", typeof(ConvolutionFilter2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameterfEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Single @params);
        internal static ConvolutionParameterfEXT glConvolutionParameterfEXT = (ConvolutionParameterfEXT)GL.GetDelegateForExtensionMethod("glConvolutionParameterfEXT", typeof(ConvolutionParameterfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Single* @params);
        internal unsafe static ConvolutionParameterfvEXT glConvolutionParameterfvEXT = (ConvolutionParameterfvEXT)GL.GetDelegateForExtensionMethod("glConvolutionParameterfvEXT", typeof(ConvolutionParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameteriEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Int32 @params);
        internal static ConvolutionParameteriEXT glConvolutionParameteriEXT = (ConvolutionParameteriEXT)GL.GetDelegateForExtensionMethod("glConvolutionParameteriEXT", typeof(ConvolutionParameteriEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Int32* @params);
        internal unsafe static ConvolutionParameterivEXT glConvolutionParameterivEXT = (ConvolutionParameterivEXT)GL.GetDelegateForExtensionMethod("glConvolutionParameterivEXT", typeof(ConvolutionParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT = (CopyConvolutionFilter1DEXT)GL.GetDelegateForExtensionMethod("glCopyConvolutionFilter1DEXT", typeof(CopyConvolutionFilter1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
        internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT = (CopyConvolutionFilter2DEXT)GL.GetDelegateForExtensionMethod("glCopyConvolutionFilter2DEXT", typeof(CopyConvolutionFilter2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionFilterEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* image);
        internal unsafe static GetConvolutionFilterEXT glGetConvolutionFilterEXT = (GetConvolutionFilterEXT)GL.GetDelegateForExtensionMethod("glGetConvolutionFilterEXT", typeof(GetConvolutionFilterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, [Out] Single* @params);
        internal unsafe static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT = (GetConvolutionParameterfvEXT)GL.GetDelegateForExtensionMethod("glGetConvolutionParameterfvEXT", typeof(GetConvolutionParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, [Out] Int32* @params);
        internal unsafe static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT = (GetConvolutionParameterivEXT)GL.GetDelegateForExtensionMethod("glGetConvolutionParameterivEXT", typeof(GetConvolutionParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSeparableFilterEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* row, [Out] void* column, [Out] void* span);
        internal unsafe static GetSeparableFilterEXT glGetSeparableFilterEXT = (GetSeparableFilterEXT)GL.GetDelegateForExtensionMethod("glGetSeparableFilterEXT", typeof(GetSeparableFilterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SeparableFilter2DEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
        internal unsafe static SeparableFilter2DEXT glSeparableFilter2DEXT = (SeparableFilter2DEXT)GL.GetDelegateForExtensionMethod("glSeparableFilter2DEXT", typeof(SeparableFilter2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal unsafe static ColorTableSGI glColorTableSGI = (ColorTableSGI)GL.GetDelegateForExtensionMethod("glColorTableSGI", typeof(ColorTableSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, Single* @params);
        internal unsafe static ColorTableParameterfvSGI glColorTableParameterfvSGI = (ColorTableParameterfvSGI)GL.GetDelegateForExtensionMethod("glColorTableParameterfvSGI", typeof(ColorTableParameterfvSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, Int32* @params);
        internal unsafe static ColorTableParameterivSGI glColorTableParameterivSGI = (ColorTableParameterivSGI)GL.GetDelegateForExtensionMethod("glColorTableParameterivSGI", typeof(ColorTableParameterivSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
        internal static CopyColorTableSGI glCopyColorTableSGI = (CopyColorTableSGI)GL.GetDelegateForExtensionMethod("glCopyColorTableSGI", typeof(CopyColorTableSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* table);
        internal unsafe static GetColorTableSGI glGetColorTableSGI = (GetColorTableSGI)GL.GetDelegateForExtensionMethod("glGetColorTableSGI", typeof(GetColorTableSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, [Out] Single* @params);
        internal unsafe static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI = (GetColorTableParameterfvSGI)GL.GetDelegateForExtensionMethod("glGetColorTableParameterfvSGI", typeof(GetColorTableParameterfvSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, [Out] Int32* @params);
        internal unsafe static GetColorTableParameterivSGI glGetColorTableParameterivSGI = (GetColorTableParameterivSGI)GL.GetDelegateForExtensionMethod("glGetColorTableParameterivSGI", typeof(GetColorTableParameterivSGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenSGIX(GL.Enums.SGIX_pixel_texture mode);
        internal static PixelTexGenSGIX glPixelTexGenSGIX = (PixelTexGenSGIX)GL.GetDelegateForExtensionMethod("glPixelTexGenSGIX", typeof(PixelTexGenSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenParameteriSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Int32 param);
        internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS = (PixelTexGenParameteriSGIS)GL.GetDelegateForExtensionMethod("glPixelTexGenParameteriSGIS", typeof(PixelTexGenParameteriSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Int32* @params);
        internal unsafe static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS = (PixelTexGenParameterivSGIS)GL.GetDelegateForExtensionMethod("glPixelTexGenParameterivSGIS", typeof(PixelTexGenParameterivSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenParameterfSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Single param);
        internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS = (PixelTexGenParameterfSGIS)GL.GetDelegateForExtensionMethod("glPixelTexGenParameterfSGIS", typeof(PixelTexGenParameterfSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Single* @params);
        internal unsafe static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS = (PixelTexGenParameterfvSGIS)GL.GetDelegateForExtensionMethod("glPixelTexGenParameterfvSGIS", typeof(PixelTexGenParameterfvSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, [Out] Int32* @params);
        internal unsafe static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS = (GetPixelTexGenParameterivSGIS)GL.GetDelegateForExtensionMethod("glGetPixelTexGenParameterivSGIS", typeof(GetPixelTexGenParameterivSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, [Out] Single* @params);
        internal unsafe static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS = (GetPixelTexGenParameterfvSGIS)GL.GetDelegateForExtensionMethod("glGetPixelTexGenParameterfvSGIS", typeof(GetPixelTexGenParameterfvSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage4DSGIS(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexImage4DSGIS glTexImage4DSGIS = (TexImage4DSGIS)GL.GetDelegateForExtensionMethod("glTexImage4DSGIS", typeof(TexImage4DSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage4DSGIS(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal unsafe static TexSubImage4DSGIS glTexSubImage4DSGIS = (TexSubImage4DSGIS)GL.GetDelegateForExtensionMethod("glTexSubImage4DSGIS", typeof(TexSubImage4DSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Boolean AreTexturesResidentEXT(Int32 n, UInt32* textures, [Out] GL.Enums.Boolean* residences);
        internal unsafe static AreTexturesResidentEXT glAreTexturesResidentEXT = (AreTexturesResidentEXT)GL.GetDelegateForExtensionMethod("glAreTexturesResidentEXT", typeof(AreTexturesResidentEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTextureEXT(GL.Enums.TextureTarget target, UInt32 texture);
        internal static BindTextureEXT glBindTextureEXT = (BindTextureEXT)GL.GetDelegateForExtensionMethod("glBindTextureEXT", typeof(BindTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTexturesEXT(Int32 n, UInt32* textures);
        internal unsafe static DeleteTexturesEXT glDeleteTexturesEXT = (DeleteTexturesEXT)GL.GetDelegateForExtensionMethod("glDeleteTexturesEXT", typeof(DeleteTexturesEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTexturesEXT(Int32 n, [Out] UInt32* textures);
        internal unsafe static GenTexturesEXT glGenTexturesEXT = (GenTexturesEXT)GL.GetDelegateForExtensionMethod("glGenTexturesEXT", typeof(GenTexturesEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsTextureEXT(UInt32 texture);
        internal static IsTextureEXT glIsTextureEXT = (IsTextureEXT)GL.GetDelegateForExtensionMethod("glIsTextureEXT", typeof(IsTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
        internal unsafe static PrioritizeTexturesEXT glPrioritizeTexturesEXT = (PrioritizeTexturesEXT)GL.GetDelegateForExtensionMethod("glPrioritizeTexturesEXT", typeof(PrioritizeTexturesEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DetailTexFuncSGIS(GL.Enums.TextureTarget target, Int32 n, Single* points);
        internal unsafe static DetailTexFuncSGIS glDetailTexFuncSGIS = (DetailTexFuncSGIS)GL.GetDelegateForExtensionMethod("glDetailTexFuncSGIS", typeof(DetailTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDetailTexFuncSGIS(GL.Enums.TextureTarget target, [Out] Single* points);
        internal unsafe static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS = (GetDetailTexFuncSGIS)GL.GetDelegateForExtensionMethod("glGetDetailTexFuncSGIS", typeof(GetDetailTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SharpenTexFuncSGIS(GL.Enums.TextureTarget target, Int32 n, Single* points);
        internal unsafe static SharpenTexFuncSGIS glSharpenTexFuncSGIS = (SharpenTexFuncSGIS)GL.GetDelegateForExtensionMethod("glSharpenTexFuncSGIS", typeof(SharpenTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSharpenTexFuncSGIS(GL.Enums.TextureTarget target, [Out] Single* points);
        internal unsafe static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS = (GetSharpenTexFuncSGIS)GL.GetDelegateForExtensionMethod("glGetSharpenTexFuncSGIS", typeof(GetSharpenTexFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskSGIS(Single value, GL.Enums.Boolean invert);
        internal static SampleMaskSGIS glSampleMaskSGIS = (SampleMaskSGIS)GL.GetDelegateForExtensionMethod("glSampleMaskSGIS", typeof(SampleMaskSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplePatternSGIS(GL.Enums.SamplePatternSGIS pattern);
        internal static SamplePatternSGIS glSamplePatternSGIS = (SamplePatternSGIS)GL.GetDelegateForExtensionMethod("glSamplePatternSGIS", typeof(SamplePatternSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayElementEXT(Int32 i);
        internal static ArrayElementEXT glArrayElementEXT = (ArrayElementEXT)GL.GetDelegateForExtensionMethod("glArrayElementEXT", typeof(ArrayElementEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointerEXT(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static ColorPointerEXT glColorPointerEXT = (ColorPointerEXT)GL.GetDelegateForExtensionMethod("glColorPointerEXT", typeof(ColorPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysEXT(GL.Enums.BeginMode mode, Int32 first, Int32 count);
        internal static DrawArraysEXT glDrawArraysEXT = (DrawArraysEXT)GL.GetDelegateForExtensionMethod("glDrawArraysEXT", typeof(DrawArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointerEXT(Int32 stride, Int32 count, GL.Enums.Boolean* pointer);
        internal unsafe static EdgeFlagPointerEXT glEdgeFlagPointerEXT = (EdgeFlagPointerEXT)GL.GetDelegateForExtensionMethod("glEdgeFlagPointerEXT", typeof(EdgeFlagPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPointervEXT(GL.Enums.GetPointervPName pname, [Out] void* @params);
        internal unsafe static GetPointervEXT glGetPointervEXT = (GetPointervEXT)GL.GetDelegateForExtensionMethod("glGetPointervEXT", typeof(GetPointervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointerEXT(GL.Enums.IndexPointerType type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static IndexPointerEXT glIndexPointerEXT = (IndexPointerEXT)GL.GetDelegateForExtensionMethod("glIndexPointerEXT", typeof(IndexPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointerEXT(GL.Enums.NormalPointerType type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static NormalPointerEXT glNormalPointerEXT = (NormalPointerEXT)GL.GetDelegateForExtensionMethod("glNormalPointerEXT", typeof(NormalPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointerEXT(Int32 size, GL.Enums.TexCoordPointerType type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static TexCoordPointerEXT glTexCoordPointerEXT = (TexCoordPointerEXT)GL.GetDelegateForExtensionMethod("glTexCoordPointerEXT", typeof(TexCoordPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointerEXT(Int32 size, GL.Enums.VertexPointerType type, Int32 stride, Int32 count, void* pointer);
        internal unsafe static VertexPointerEXT glVertexPointerEXT = (VertexPointerEXT)GL.GetDelegateForExtensionMethod("glVertexPointerEXT", typeof(VertexPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationEXT(GL.Enums.BlendEquationModeEXT mode);
        internal static BlendEquationEXT glBlendEquationEXT = (BlendEquationEXT)GL.GetDelegateForExtensionMethod("glBlendEquationEXT", typeof(BlendEquationEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SpriteParameterfSGIX(GL.Enums.SGIX_sprite pname, Single param);
        internal static SpriteParameterfSGIX glSpriteParameterfSGIX = (SpriteParameterfSGIX)GL.GetDelegateForExtensionMethod("glSpriteParameterfSGIX", typeof(SpriteParameterfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SpriteParameterfvSGIX(GL.Enums.SGIX_sprite pname, Single* @params);
        internal unsafe static SpriteParameterfvSGIX glSpriteParameterfvSGIX = (SpriteParameterfvSGIX)GL.GetDelegateForExtensionMethod("glSpriteParameterfvSGIX", typeof(SpriteParameterfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SpriteParameteriSGIX(GL.Enums.SGIX_sprite pname, Int32 param);
        internal static SpriteParameteriSGIX glSpriteParameteriSGIX = (SpriteParameteriSGIX)GL.GetDelegateForExtensionMethod("glSpriteParameteriSGIX", typeof(SpriteParameteriSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SpriteParameterivSGIX(GL.Enums.SGIX_sprite pname, Int32* @params);
        internal unsafe static SpriteParameterivSGIX glSpriteParameterivSGIX = (SpriteParameterivSGIX)GL.GetDelegateForExtensionMethod("glSpriteParameterivSGIX", typeof(SpriteParameterivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfEXT(GL.Enums.EXT_point_parameters pname, Single param);
        internal static PointParameterfEXT glPointParameterfEXT = (PointParameterfEXT)GL.GetDelegateForExtensionMethod("glPointParameterfEXT", typeof(PointParameterfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvEXT(GL.Enums.EXT_point_parameters pname, Single* @params);
        internal unsafe static PointParameterfvEXT glPointParameterfvEXT = (PointParameterfvEXT)GL.GetDelegateForExtensionMethod("glPointParameterfvEXT", typeof(PointParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfSGIS(GL.Enums.SGIS_point_parameters pname, Single param);
        internal static PointParameterfSGIS glPointParameterfSGIS = (PointParameterfSGIS)GL.GetDelegateForExtensionMethod("glPointParameterfSGIS", typeof(PointParameterfSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvSGIS(GL.Enums.SGIS_point_parameters pname, Single* @params);
        internal unsafe static PointParameterfvSGIS glPointParameterfvSGIS = (PointParameterfvSGIS)GL.GetDelegateForExtensionMethod("glPointParameterfvSGIS", typeof(PointParameterfvSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetInstrumentsSGIX();
        internal static GetInstrumentsSGIX glGetInstrumentsSGIX = (GetInstrumentsSGIX)GL.GetDelegateForExtensionMethod("glGetInstrumentsSGIX", typeof(GetInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InstrumentsBufferSGIX(Int32 size, [Out] Int32* buffer);
        internal unsafe static InstrumentsBufferSGIX glInstrumentsBufferSGIX = (InstrumentsBufferSGIX)GL.GetDelegateForExtensionMethod("glInstrumentsBufferSGIX", typeof(InstrumentsBufferSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 PollInstrumentsSGIX([Out] Int32* marker_p);
        internal unsafe static PollInstrumentsSGIX glPollInstrumentsSGIX = (PollInstrumentsSGIX)GL.GetDelegateForExtensionMethod("glPollInstrumentsSGIX", typeof(PollInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadInstrumentsSGIX(Int32 marker);
        internal static ReadInstrumentsSGIX glReadInstrumentsSGIX = (ReadInstrumentsSGIX)GL.GetDelegateForExtensionMethod("glReadInstrumentsSGIX", typeof(ReadInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StartInstrumentsSGIX();
        internal static StartInstrumentsSGIX glStartInstrumentsSGIX = (StartInstrumentsSGIX)GL.GetDelegateForExtensionMethod("glStartInstrumentsSGIX", typeof(StartInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StopInstrumentsSGIX(Int32 marker);
        internal static StopInstrumentsSGIX glStopInstrumentsSGIX = (StopInstrumentsSGIX)GL.GetDelegateForExtensionMethod("glStopInstrumentsSGIX", typeof(StopInstrumentsSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrameZoomSGIX(Int32 factor);
        internal static FrameZoomSGIX glFrameZoomSGIX = (FrameZoomSGIX)GL.GetDelegateForExtensionMethod("glFrameZoomSGIX", typeof(FrameZoomSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TagSampleBufferSGIX();
        internal static TagSampleBufferSGIX glTagSampleBufferSGIX = (TagSampleBufferSGIX)GL.GetDelegateForExtensionMethod("glTagSampleBufferSGIX", typeof(TagSampleBufferSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeformationMap3dSGIX(GL.Enums.FfdTargetSGIX target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
        internal unsafe static DeformationMap3dSGIX glDeformationMap3dSGIX = (DeformationMap3dSGIX)GL.GetDelegateForExtensionMethod("glDeformationMap3dSGIX", typeof(DeformationMap3dSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeformationMap3fSGIX(GL.Enums.FfdTargetSGIX target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
        internal unsafe static DeformationMap3fSGIX glDeformationMap3fSGIX = (DeformationMap3fSGIX)GL.GetDelegateForExtensionMethod("glDeformationMap3fSGIX", typeof(DeformationMap3fSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeformSGIX(GL.Enums.FfdMaskSGIX mask);
        internal static DeformSGIX glDeformSGIX = (DeformSGIX)GL.GetDelegateForExtensionMethod("glDeformSGIX", typeof(DeformSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadIdentityDeformationMapSGIX(GL.Enums.FfdMaskSGIX mask);
        internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX = (LoadIdentityDeformationMapSGIX)GL.GetDelegateForExtensionMethod("glLoadIdentityDeformationMapSGIX", typeof(LoadIdentityDeformationMapSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReferencePlaneSGIX(Double* equation);
        internal unsafe static ReferencePlaneSGIX glReferencePlaneSGIX = (ReferencePlaneSGIX)GL.GetDelegateForExtensionMethod("glReferencePlaneSGIX", typeof(ReferencePlaneSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushRasterSGIX();
        internal static FlushRasterSGIX glFlushRasterSGIX = (FlushRasterSGIX)GL.GetDelegateForExtensionMethod("glFlushRasterSGIX", typeof(FlushRasterSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogFuncSGIS(Int32 n, Single* points);
        internal unsafe static FogFuncSGIS glFogFuncSGIS = (FogFuncSGIS)GL.GetDelegateForExtensionMethod("glFogFuncSGIS", typeof(FogFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFogFuncSGIS([Out] Single* points);
        internal unsafe static GetFogFuncSGIS glGetFogFuncSGIS = (GetFogFuncSGIS)GL.GetDelegateForExtensionMethod("glGetFogFuncSGIS", typeof(GetFogFuncSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ImageTransformParameteriHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Int32 param);
        internal static ImageTransformParameteriHP glImageTransformParameteriHP = (ImageTransformParameteriHP)GL.GetDelegateForExtensionMethod("glImageTransformParameteriHP", typeof(ImageTransformParameteriHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ImageTransformParameterfHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Single param);
        internal static ImageTransformParameterfHP glImageTransformParameterfHP = (ImageTransformParameterfHP)GL.GetDelegateForExtensionMethod("glImageTransformParameterfHP", typeof(ImageTransformParameterfHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Int32* @params);
        internal unsafe static ImageTransformParameterivHP glImageTransformParameterivHP = (ImageTransformParameterivHP)GL.GetDelegateForExtensionMethod("glImageTransformParameterivHP", typeof(ImageTransformParameterivHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Single* @params);
        internal unsafe static ImageTransformParameterfvHP glImageTransformParameterfvHP = (ImageTransformParameterfvHP)GL.GetDelegateForExtensionMethod("glImageTransformParameterfvHP", typeof(ImageTransformParameterfvHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, [Out] Int32* @params);
        internal unsafe static GetImageTransformParameterivHP glGetImageTransformParameterivHP = (GetImageTransformParameterivHP)GL.GetDelegateForExtensionMethod("glGetImageTransformParameterivHP", typeof(GetImageTransformParameterivHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, [Out] Single* @params);
        internal unsafe static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP = (GetImageTransformParameterfvHP)GL.GetDelegateForExtensionMethod("glGetImageTransformParameterfvHP", typeof(GetImageTransformParameterfvHP));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorSubTableEXT(GL.Enums.EXT_color_subtable target, Int32 start, Int32 count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        internal unsafe static ColorSubTableEXT glColorSubTableEXT = (ColorSubTableEXT)GL.GetDelegateForExtensionMethod("glColorSubTableEXT", typeof(ColorSubTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorSubTableEXT(GL.Enums.EXT_color_subtable target, Int32 start, Int32 x, Int32 y, Int32 width);
        internal static CopyColorSubTableEXT glCopyColorSubTableEXT = (CopyColorSubTableEXT)GL.GetDelegateForExtensionMethod("glCopyColorSubTableEXT", typeof(CopyColorSubTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void HintPGI(GL.Enums.PGI_misc_hints target, Int32 mode);
        internal static HintPGI glHintPGI = (HintPGI)GL.GetDelegateForExtensionMethod("glHintPGI", typeof(HintPGI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelInternalFormat internalFormat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal unsafe static ColorTableEXT glColorTableEXT = (ColorTableEXT)GL.GetDelegateForExtensionMethod("glColorTableEXT", typeof(ColorTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* data);
        internal unsafe static GetColorTableEXT glGetColorTableEXT = (GetColorTableEXT)GL.GetDelegateForExtensionMethod("glGetColorTableEXT", typeof(GetColorTableEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterivEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, [Out] Int32* @params);
        internal unsafe static GetColorTableParameterivEXT glGetColorTableParameterivEXT = (GetColorTableParameterivEXT)GL.GetDelegateForExtensionMethod("glGetColorTableParameterivEXT", typeof(GetColorTableParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfvEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, [Out] Single* @params);
        internal unsafe static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT = (GetColorTableParameterfvEXT)GL.GetDelegateForExtensionMethod("glGetColorTableParameterfvEXT", typeof(GetColorTableParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetListParameterfvSGIX(UInt32 list, GL.Enums.ListParameterName pname, [Out] Single* @params);
        internal unsafe static GetListParameterfvSGIX glGetListParameterfvSGIX = (GetListParameterfvSGIX)GL.GetDelegateForExtensionMethod("glGetListParameterfvSGIX", typeof(GetListParameterfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetListParameterivSGIX(UInt32 list, GL.Enums.ListParameterName pname, [Out] Int32* @params);
        internal unsafe static GetListParameterivSGIX glGetListParameterivSGIX = (GetListParameterivSGIX)GL.GetDelegateForExtensionMethod("glGetListParameterivSGIX", typeof(GetListParameterivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListParameterfSGIX(UInt32 list, GL.Enums.ListParameterName pname, Single param);
        internal static ListParameterfSGIX glListParameterfSGIX = (ListParameterfSGIX)GL.GetDelegateForExtensionMethod("glListParameterfSGIX", typeof(ListParameterfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ListParameterfvSGIX(UInt32 list, GL.Enums.ListParameterName pname, Single* @params);
        internal unsafe static ListParameterfvSGIX glListParameterfvSGIX = (ListParameterfvSGIX)GL.GetDelegateForExtensionMethod("glListParameterfvSGIX", typeof(ListParameterfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListParameteriSGIX(UInt32 list, GL.Enums.ListParameterName pname, Int32 param);
        internal static ListParameteriSGIX glListParameteriSGIX = (ListParameteriSGIX)GL.GetDelegateForExtensionMethod("glListParameteriSGIX", typeof(ListParameteriSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ListParameterivSGIX(UInt32 list, GL.Enums.ListParameterName pname, Int32* @params);
        internal unsafe static ListParameterivSGIX glListParameterivSGIX = (ListParameterivSGIX)GL.GetDelegateForExtensionMethod("glListParameterivSGIX", typeof(ListParameterivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.EXT_index_material mode);
        internal static IndexMaterialEXT glIndexMaterialEXT = (IndexMaterialEXT)GL.GetDelegateForExtensionMethod("glIndexMaterialEXT", typeof(IndexMaterialEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexFuncEXT(GL.Enums.EXT_index_func func, Single @ref);
        internal static IndexFuncEXT glIndexFuncEXT = (IndexFuncEXT)GL.GetDelegateForExtensionMethod("glIndexFuncEXT", typeof(IndexFuncEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LockArraysEXT(Int32 first, Int32 count);
        internal static LockArraysEXT glLockArraysEXT = (LockArraysEXT)GL.GetDelegateForExtensionMethod("glLockArraysEXT", typeof(LockArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UnlockArraysEXT();
        internal static UnlockArraysEXT glUnlockArraysEXT = (UnlockArraysEXT)GL.GetDelegateForExtensionMethod("glUnlockArraysEXT", typeof(UnlockArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CullParameterdvEXT(GL.Enums.EXT_cull_vertex pname, [Out] Double* @params);
        internal unsafe static CullParameterdvEXT glCullParameterdvEXT = (CullParameterdvEXT)GL.GetDelegateForExtensionMethod("glCullParameterdvEXT", typeof(CullParameterdvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CullParameterfvEXT(GL.Enums.EXT_cull_vertex pname, [Out] Single* @params);
        internal unsafe static CullParameterfvEXT glCullParameterfvEXT = (CullParameterfvEXT)GL.GetDelegateForExtensionMethod("glCullParameterfvEXT", typeof(CullParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentColorMaterialSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
        internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX = (FragmentColorMaterialSGIX)GL.GetDelegateForExtensionMethod("glFragmentColorMaterialSGIX", typeof(FragmentColorMaterialSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightfSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Single param);
        internal static FragmentLightfSGIX glFragmentLightfSGIX = (FragmentLightfSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightfSGIX", typeof(FragmentLightfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Single* @params);
        internal unsafe static FragmentLightfvSGIX glFragmentLightfvSGIX = (FragmentLightfvSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightfvSGIX", typeof(FragmentLightfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightiSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Int32 param);
        internal static FragmentLightiSGIX glFragmentLightiSGIX = (FragmentLightiSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightiSGIX", typeof(FragmentLightiSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Int32* @params);
        internal unsafe static FragmentLightivSGIX glFragmentLightivSGIX = (FragmentLightivSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightivSGIX", typeof(FragmentLightivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightModelfSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Single param);
        internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX = (FragmentLightModelfSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightModelfSGIX", typeof(FragmentLightModelfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightModelfvSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Single* @params);
        internal unsafe static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX = (FragmentLightModelfvSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightModelfvSGIX", typeof(FragmentLightModelfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightModeliSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Int32 param);
        internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX = (FragmentLightModeliSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightModeliSGIX", typeof(FragmentLightModeliSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightModelivSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Int32* @params);
        internal unsafe static FragmentLightModelivSGIX glFragmentLightModelivSGIX = (FragmentLightModelivSGIX)GL.GetDelegateForExtensionMethod("glFragmentLightModelivSGIX", typeof(FragmentLightModelivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentMaterialfSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single param);
        internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX = (FragmentMaterialfSGIX)GL.GetDelegateForExtensionMethod("glFragmentMaterialfSGIX", typeof(FragmentMaterialfSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single* @params);
        internal unsafe static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX = (FragmentMaterialfvSGIX)GL.GetDelegateForExtensionMethod("glFragmentMaterialfvSGIX", typeof(FragmentMaterialfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentMaterialiSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32 param);
        internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX = (FragmentMaterialiSGIX)GL.GetDelegateForExtensionMethod("glFragmentMaterialiSGIX", typeof(FragmentMaterialiSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32* @params);
        internal unsafe static FragmentMaterialivSGIX glFragmentMaterialivSGIX = (FragmentMaterialivSGIX)GL.GetDelegateForExtensionMethod("glFragmentMaterialivSGIX", typeof(FragmentMaterialivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, [Out] Single* @params);
        internal unsafe static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX = (GetFragmentLightfvSGIX)GL.GetDelegateForExtensionMethod("glGetFragmentLightfvSGIX", typeof(GetFragmentLightfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, [Out] Int32* @params);
        internal unsafe static GetFragmentLightivSGIX glGetFragmentLightivSGIX = (GetFragmentLightivSGIX)GL.GetDelegateForExtensionMethod("glGetFragmentLightivSGIX", typeof(GetFragmentLightivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Single* @params);
        internal unsafe static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX = (GetFragmentMaterialfvSGIX)GL.GetDelegateForExtensionMethod("glGetFragmentMaterialfvSGIX", typeof(GetFragmentMaterialfvSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Int32* @params);
        internal unsafe static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX = (GetFragmentMaterialivSGIX)GL.GetDelegateForExtensionMethod("glGetFragmentMaterialivSGIX", typeof(GetFragmentMaterialivSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightEnviSGIX(GL.Enums.LightEnvParameterSGIX pname, Int32 param);
        internal static LightEnviSGIX glLightEnviSGIX = (LightEnviSGIX)GL.GetDelegateForExtensionMethod("glLightEnviSGIX", typeof(LightEnviSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawRangeElementsEXT(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 count, GL.Enums.EXT_draw_range_elements type, void* indices);
        internal unsafe static DrawRangeElementsEXT glDrawRangeElementsEXT = (DrawRangeElementsEXT)GL.GetDelegateForExtensionMethod("glDrawRangeElementsEXT", typeof(DrawRangeElementsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ApplyTextureEXT(GL.Enums.EXT_light_texture mode);
        internal static ApplyTextureEXT glApplyTextureEXT = (ApplyTextureEXT)GL.GetDelegateForExtensionMethod("glApplyTextureEXT", typeof(ApplyTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureLightEXT(GL.Enums.EXT_light_texture pname);
        internal static TextureLightEXT glTextureLightEXT = (TextureLightEXT)GL.GetDelegateForExtensionMethod("glTextureLightEXT", typeof(TextureLightEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
        internal static TextureMaterialEXT glTextureMaterialEXT = (TextureMaterialEXT)GL.GetDelegateForExtensionMethod("glTextureMaterialEXT", typeof(TextureMaterialEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AsyncMarkerSGIX(UInt32 marker);
        internal static AsyncMarkerSGIX glAsyncMarkerSGIX = (AsyncMarkerSGIX)GL.GetDelegateForExtensionMethod("glAsyncMarkerSGIX", typeof(AsyncMarkerSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 FinishAsyncSGIX([Out] UInt32* markerp);
        internal unsafe static FinishAsyncSGIX glFinishAsyncSGIX = (FinishAsyncSGIX)GL.GetDelegateForExtensionMethod("glFinishAsyncSGIX", typeof(FinishAsyncSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 PollAsyncSGIX([Out] UInt32* markerp);
        internal unsafe static PollAsyncSGIX glPollAsyncSGIX = (PollAsyncSGIX)GL.GetDelegateForExtensionMethod("glPollAsyncSGIX", typeof(PollAsyncSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenAsyncMarkersSGIX(Int32 range);
        internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX = (GenAsyncMarkersSGIX)GL.GetDelegateForExtensionMethod("glGenAsyncMarkersSGIX", typeof(GenAsyncMarkersSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
        internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX = (DeleteAsyncMarkersSGIX)GL.GetDelegateForExtensionMethod("glDeleteAsyncMarkersSGIX", typeof(DeleteAsyncMarkersSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsAsyncMarkerSGIX(UInt32 marker);
        internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX = (IsAsyncMarkerSGIX)GL.GetDelegateForExtensionMethod("glIsAsyncMarkerSGIX", typeof(IsAsyncMarkerSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointervINTEL(Int32 size, GL.Enums.VertexPointerType type, void* pointer);
        internal unsafe static VertexPointervINTEL glVertexPointervINTEL = (VertexPointervINTEL)GL.GetDelegateForExtensionMethod("glVertexPointervINTEL", typeof(VertexPointervINTEL)) ?? new VertexPointervINTEL(Imports.VertexPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointervINTEL(GL.Enums.NormalPointerType type, void* pointer);
        internal unsafe static NormalPointervINTEL glNormalPointervINTEL = (NormalPointervINTEL)GL.GetDelegateForExtensionMethod("glNormalPointervINTEL", typeof(NormalPointervINTEL)) ?? new NormalPointervINTEL(Imports.NormalPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointervINTEL(Int32 size, GL.Enums.VertexPointerType type, void* pointer);
        internal unsafe static ColorPointervINTEL glColorPointervINTEL = (ColorPointervINTEL)GL.GetDelegateForExtensionMethod("glColorPointervINTEL", typeof(ColorPointervINTEL)) ?? new ColorPointervINTEL(Imports.ColorPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointervINTEL(Int32 size, GL.Enums.VertexPointerType type, void* pointer);
        internal unsafe static TexCoordPointervINTEL glTexCoordPointervINTEL = (TexCoordPointervINTEL)GL.GetDelegateForExtensionMethod("glTexCoordPointervINTEL", typeof(TexCoordPointervINTEL)) ?? new TexCoordPointervINTEL(Imports.TexCoordPointervINTEL);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransformParameteriEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Int32 param);
        internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT = (PixelTransformParameteriEXT)GL.GetDelegateForExtensionMethod("glPixelTransformParameteriEXT", typeof(PixelTransformParameteriEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransformParameterfEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Single param);
        internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT = (PixelTransformParameterfEXT)GL.GetDelegateForExtensionMethod("glPixelTransformParameterfEXT", typeof(PixelTransformParameterfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTransformParameterivEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Int32* @params);
        internal unsafe static PixelTransformParameterivEXT glPixelTransformParameterivEXT = (PixelTransformParameterivEXT)GL.GetDelegateForExtensionMethod("glPixelTransformParameterivEXT", typeof(PixelTransformParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTransformParameterfvEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Single* @params);
        internal unsafe static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT = (PixelTransformParameterfvEXT)GL.GetDelegateForExtensionMethod("glPixelTransformParameterfvEXT", typeof(PixelTransformParameterfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
        internal static SecondaryColor3bEXT glSecondaryColor3bEXT = (SecondaryColor3bEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3bEXT", typeof(SecondaryColor3bEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3bvEXT(SByte* v);
        internal unsafe static SecondaryColor3bvEXT glSecondaryColor3bvEXT = (SecondaryColor3bvEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3bvEXT", typeof(SecondaryColor3bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3dEXT(Double red, Double green, Double blue);
        internal static SecondaryColor3dEXT glSecondaryColor3dEXT = (SecondaryColor3dEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3dEXT", typeof(SecondaryColor3dEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3dvEXT(Double* v);
        internal unsafe static SecondaryColor3dvEXT glSecondaryColor3dvEXT = (SecondaryColor3dvEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3dvEXT", typeof(SecondaryColor3dvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3fEXT(Single red, Single green, Single blue);
        internal static SecondaryColor3fEXT glSecondaryColor3fEXT = (SecondaryColor3fEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3fEXT", typeof(SecondaryColor3fEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3fvEXT(Single* v);
        internal unsafe static SecondaryColor3fvEXT glSecondaryColor3fvEXT = (SecondaryColor3fvEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3fvEXT", typeof(SecondaryColor3fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
        internal static SecondaryColor3iEXT glSecondaryColor3iEXT = (SecondaryColor3iEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3iEXT", typeof(SecondaryColor3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ivEXT(Int32* v);
        internal unsafe static SecondaryColor3ivEXT glSecondaryColor3ivEXT = (SecondaryColor3ivEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3ivEXT", typeof(SecondaryColor3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
        internal static SecondaryColor3sEXT glSecondaryColor3sEXT = (SecondaryColor3sEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3sEXT", typeof(SecondaryColor3sEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3svEXT(Int16* v);
        internal unsafe static SecondaryColor3svEXT glSecondaryColor3svEXT = (SecondaryColor3svEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3svEXT", typeof(SecondaryColor3svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
        internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT = (SecondaryColor3ubEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3ubEXT", typeof(SecondaryColor3ubEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ubvEXT(Byte* v);
        internal unsafe static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT = (SecondaryColor3ubvEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3ubvEXT", typeof(SecondaryColor3ubvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
        internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT = (SecondaryColor3uiEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3uiEXT", typeof(SecondaryColor3uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3uivEXT(UInt32* v);
        internal unsafe static SecondaryColor3uivEXT glSecondaryColor3uivEXT = (SecondaryColor3uivEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3uivEXT", typeof(SecondaryColor3uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
        internal static SecondaryColor3usEXT glSecondaryColor3usEXT = (SecondaryColor3usEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3usEXT", typeof(SecondaryColor3usEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3usvEXT(UInt16* v);
        internal unsafe static SecondaryColor3usvEXT glSecondaryColor3usvEXT = (SecondaryColor3usvEXT)GL.GetDelegateForExtensionMethod("glSecondaryColor3usvEXT", typeof(SecondaryColor3usvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointerEXT(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer);
        internal unsafe static SecondaryColorPointerEXT glSecondaryColorPointerEXT = (SecondaryColorPointerEXT)GL.GetDelegateForExtensionMethod("glSecondaryColorPointerEXT", typeof(SecondaryColorPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureNormalEXT(GL.Enums.EXT_texture_perturb_normal mode);
        internal static TextureNormalEXT glTextureNormalEXT = (TextureNormalEXT)GL.GetDelegateForExtensionMethod("glTextureNormalEXT", typeof(TextureNormalEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArraysEXT(GL.Enums.BeginMode mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
        internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT = (MultiDrawArraysEXT)GL.GetDelegateForExtensionMethod("glMultiDrawArraysEXT", typeof(MultiDrawArraysEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementsEXT(GL.Enums.BeginMode mode, Int32* count, GL.Enums.EXT_multi_draw_arrays type, void* indices, Int32 primcount);
        internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT = (MultiDrawElementsEXT)GL.GetDelegateForExtensionMethod("glMultiDrawElementsEXT", typeof(MultiDrawElementsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordfEXT(Single coord);
        internal static FogCoordfEXT glFogCoordfEXT = (FogCoordfEXT)GL.GetDelegateForExtensionMethod("glFogCoordfEXT", typeof(FogCoordfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordfvEXT(Single* coord);
        internal unsafe static FogCoordfvEXT glFogCoordfvEXT = (FogCoordfvEXT)GL.GetDelegateForExtensionMethod("glFogCoordfvEXT", typeof(FogCoordfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoorddEXT(Double coord);
        internal static FogCoorddEXT glFogCoorddEXT = (FogCoorddEXT)GL.GetDelegateForExtensionMethod("glFogCoorddEXT", typeof(FogCoorddEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoorddvEXT(Double* coord);
        internal unsafe static FogCoorddvEXT glFogCoorddvEXT = (FogCoorddvEXT)GL.GetDelegateForExtensionMethod("glFogCoorddvEXT", typeof(FogCoorddvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointerEXT(GL.Enums.EXT_fog_coord type, Int32 stride, void* pointer);
        internal unsafe static FogCoordPointerEXT glFogCoordPointerEXT = (FogCoordPointerEXT)GL.GetDelegateForExtensionMethod("glFogCoordPointerEXT", typeof(FogCoordPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
        internal static Tangent3bEXT glTangent3bEXT = (Tangent3bEXT)GL.GetDelegateForExtensionMethod("glTangent3bEXT", typeof(Tangent3bEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3bvEXT(SByte* v);
        internal unsafe static Tangent3bvEXT glTangent3bvEXT = (Tangent3bvEXT)GL.GetDelegateForExtensionMethod("glTangent3bvEXT", typeof(Tangent3bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3dEXT(Double tx, Double ty, Double tz);
        internal static Tangent3dEXT glTangent3dEXT = (Tangent3dEXT)GL.GetDelegateForExtensionMethod("glTangent3dEXT", typeof(Tangent3dEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3dvEXT(Double* v);
        internal unsafe static Tangent3dvEXT glTangent3dvEXT = (Tangent3dvEXT)GL.GetDelegateForExtensionMethod("glTangent3dvEXT", typeof(Tangent3dvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3fEXT(Single tx, Single ty, Single tz);
        internal static Tangent3fEXT glTangent3fEXT = (Tangent3fEXT)GL.GetDelegateForExtensionMethod("glTangent3fEXT", typeof(Tangent3fEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3fvEXT(Single* v);
        internal unsafe static Tangent3fvEXT glTangent3fvEXT = (Tangent3fvEXT)GL.GetDelegateForExtensionMethod("glTangent3fvEXT", typeof(Tangent3fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
        internal static Tangent3iEXT glTangent3iEXT = (Tangent3iEXT)GL.GetDelegateForExtensionMethod("glTangent3iEXT", typeof(Tangent3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3ivEXT(Int32* v);
        internal unsafe static Tangent3ivEXT glTangent3ivEXT = (Tangent3ivEXT)GL.GetDelegateForExtensionMethod("glTangent3ivEXT", typeof(Tangent3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
        internal static Tangent3sEXT glTangent3sEXT = (Tangent3sEXT)GL.GetDelegateForExtensionMethod("glTangent3sEXT", typeof(Tangent3sEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3svEXT(Int16* v);
        internal unsafe static Tangent3svEXT glTangent3svEXT = (Tangent3svEXT)GL.GetDelegateForExtensionMethod("glTangent3svEXT", typeof(Tangent3svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3bEXT(SByte bx, SByte by, SByte bz);
        internal static Binormal3bEXT glBinormal3bEXT = (Binormal3bEXT)GL.GetDelegateForExtensionMethod("glBinormal3bEXT", typeof(Binormal3bEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3bvEXT(SByte* v);
        internal unsafe static Binormal3bvEXT glBinormal3bvEXT = (Binormal3bvEXT)GL.GetDelegateForExtensionMethod("glBinormal3bvEXT", typeof(Binormal3bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3dEXT(Double bx, Double by, Double bz);
        internal static Binormal3dEXT glBinormal3dEXT = (Binormal3dEXT)GL.GetDelegateForExtensionMethod("glBinormal3dEXT", typeof(Binormal3dEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3dvEXT(Double* v);
        internal unsafe static Binormal3dvEXT glBinormal3dvEXT = (Binormal3dvEXT)GL.GetDelegateForExtensionMethod("glBinormal3dvEXT", typeof(Binormal3dvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3fEXT(Single bx, Single by, Single bz);
        internal static Binormal3fEXT glBinormal3fEXT = (Binormal3fEXT)GL.GetDelegateForExtensionMethod("glBinormal3fEXT", typeof(Binormal3fEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3fvEXT(Single* v);
        internal unsafe static Binormal3fvEXT glBinormal3fvEXT = (Binormal3fvEXT)GL.GetDelegateForExtensionMethod("glBinormal3fvEXT", typeof(Binormal3fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
        internal static Binormal3iEXT glBinormal3iEXT = (Binormal3iEXT)GL.GetDelegateForExtensionMethod("glBinormal3iEXT", typeof(Binormal3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3ivEXT(Int32* v);
        internal unsafe static Binormal3ivEXT glBinormal3ivEXT = (Binormal3ivEXT)GL.GetDelegateForExtensionMethod("glBinormal3ivEXT", typeof(Binormal3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
        internal static Binormal3sEXT glBinormal3sEXT = (Binormal3sEXT)GL.GetDelegateForExtensionMethod("glBinormal3sEXT", typeof(Binormal3sEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3svEXT(Int16* v);
        internal unsafe static Binormal3svEXT glBinormal3svEXT = (Binormal3svEXT)GL.GetDelegateForExtensionMethod("glBinormal3svEXT", typeof(Binormal3svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TangentPointerEXT(GL.Enums.EXT_coordinate_frame type, Int32 stride, void* pointer);
        internal unsafe static TangentPointerEXT glTangentPointerEXT = (TangentPointerEXT)GL.GetDelegateForExtensionMethod("glTangentPointerEXT", typeof(TangentPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BinormalPointerEXT(GL.Enums.EXT_coordinate_frame type, Int32 stride, void* pointer);
        internal unsafe static BinormalPointerEXT glBinormalPointerEXT = (BinormalPointerEXT)GL.GetDelegateForExtensionMethod("glBinormalPointerEXT", typeof(BinormalPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishTextureSUNX();
        internal static FinishTextureSUNX glFinishTextureSUNX = (FinishTextureSUNX)GL.GetDelegateForExtensionMethod("glFinishTextureSUNX", typeof(FinishTextureSUNX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorbSUN(SByte factor);
        internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN = (GlobalAlphaFactorbSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactorbSUN", typeof(GlobalAlphaFactorbSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorsSUN(Int16 factor);
        internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN = (GlobalAlphaFactorsSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactorsSUN", typeof(GlobalAlphaFactorsSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactoriSUN(Int32 factor);
        internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN = (GlobalAlphaFactoriSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactoriSUN", typeof(GlobalAlphaFactoriSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorfSUN(Single factor);
        internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN = (GlobalAlphaFactorfSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactorfSUN", typeof(GlobalAlphaFactorfSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactordSUN(Double factor);
        internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN = (GlobalAlphaFactordSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactordSUN", typeof(GlobalAlphaFactordSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorubSUN(Byte factor);
        internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN = (GlobalAlphaFactorubSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactorubSUN", typeof(GlobalAlphaFactorubSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorusSUN(UInt16 factor);
        internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN = (GlobalAlphaFactorusSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactorusSUN", typeof(GlobalAlphaFactorusSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactoruiSUN(UInt32 factor);
        internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN = (GlobalAlphaFactoruiSUN)GL.GetDelegateForExtensionMethod("glGlobalAlphaFactoruiSUN", typeof(GlobalAlphaFactoruiSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiSUN(UInt32 code);
        internal static ReplacementCodeuiSUN glReplacementCodeuiSUN = (ReplacementCodeuiSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiSUN", typeof(ReplacementCodeuiSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeusSUN(UInt16 code);
        internal static ReplacementCodeusSUN glReplacementCodeusSUN = (ReplacementCodeusSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeusSUN", typeof(ReplacementCodeusSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeubSUN(Byte code);
        internal static ReplacementCodeubSUN glReplacementCodeubSUN = (ReplacementCodeubSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeubSUN", typeof(ReplacementCodeubSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuivSUN(UInt32* code);
        internal unsafe static ReplacementCodeuivSUN glReplacementCodeuivSUN = (ReplacementCodeuivSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuivSUN", typeof(ReplacementCodeuivSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeusvSUN(UInt16* code);
        internal unsafe static ReplacementCodeusvSUN glReplacementCodeusvSUN = (ReplacementCodeusvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeusvSUN", typeof(ReplacementCodeusvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeubvSUN(Byte* code);
        internal unsafe static ReplacementCodeubvSUN glReplacementCodeubvSUN = (ReplacementCodeubvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeubvSUN", typeof(ReplacementCodeubvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodePointerSUN(GL.Enums.SUN_triangle_list type, Int32 stride, void* pointer);
        internal unsafe static ReplacementCodePointerSUN glReplacementCodePointerSUN = (ReplacementCodePointerSUN)GL.GetDelegateForExtensionMethod("glReplacementCodePointerSUN", typeof(ReplacementCodePointerSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
        internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN = (Color4ubVertex2fSUN)GL.GetDelegateForExtensionMethod("glColor4ubVertex2fSUN", typeof(Color4ubVertex2fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubVertex2fvSUN(Byte* c, Single* v);
        internal unsafe static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN = (Color4ubVertex2fvSUN)GL.GetDelegateForExtensionMethod("glColor4ubVertex2fvSUN", typeof(Color4ubVertex2fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN = (Color4ubVertex3fSUN)GL.GetDelegateForExtensionMethod("glColor4ubVertex3fSUN", typeof(Color4ubVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubVertex3fvSUN(Byte* c, Single* v);
        internal unsafe static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN = (Color4ubVertex3fvSUN)GL.GetDelegateForExtensionMethod("glColor4ubVertex3fvSUN", typeof(Color4ubVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
        internal static Color3fVertex3fSUN glColor3fVertex3fSUN = (Color3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glColor3fVertex3fSUN", typeof(Color3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3fVertex3fvSUN(Single* c, Single* v);
        internal unsafe static Color3fVertex3fvSUN glColor3fVertex3fvSUN = (Color3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glColor3fVertex3fvSUN", typeof(Color3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN = (Normal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glNormal3fVertex3fSUN", typeof(Normal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3fVertex3fvSUN(Single* n, Single* v);
        internal unsafe static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN = (Normal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glNormal3fVertex3fvSUN", typeof(Normal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN = (Color4fNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glColor4fNormal3fVertex3fSUN", typeof(Color4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
        internal unsafe static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN = (Color4fNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glColor4fNormal3fVertex3fvSUN", typeof(Color4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
        internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN = (TexCoord2fVertex3fSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fVertex3fSUN", typeof(TexCoord2fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
        internal unsafe static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN = (TexCoord2fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fVertex3fvSUN", typeof(TexCoord2fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
        internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN = (TexCoord4fVertex4fSUN)GL.GetDelegateForExtensionMethod("glTexCoord4fVertex4fSUN", typeof(TexCoord4fVertex4fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
        internal unsafe static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN = (TexCoord4fVertex4fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord4fVertex4fvSUN", typeof(TexCoord4fVertex4fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN = (TexCoord2fColor4ubVertex3fSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fColor4ubVertex3fSUN", typeof(TexCoord2fColor4ubVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
        internal unsafe static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN = (TexCoord2fColor4ubVertex3fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fColor4ubVertex3fvSUN", typeof(TexCoord2fColor4ubVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
        internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN = (TexCoord2fColor3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fColor3fVertex3fSUN", typeof(TexCoord2fColor3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
        internal unsafe static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN = (TexCoord2fColor3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fColor3fVertex3fvSUN", typeof(TexCoord2fColor3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN = (TexCoord2fNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fNormal3fVertex3fSUN", typeof(TexCoord2fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
        internal unsafe static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN = (TexCoord2fNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fNormal3fVertex3fvSUN", typeof(TexCoord2fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN = (TexCoord2fColor4fNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fColor4fNormal3fVertex3fSUN", typeof(TexCoord2fColor4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
        internal unsafe static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN = (TexCoord2fColor4fNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(TexCoord2fColor4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
        internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN = (TexCoord4fColor4fNormal3fVertex4fSUN)GL.GetDelegateForExtensionMethod("glTexCoord4fColor4fNormal3fVertex4fSUN", typeof(TexCoord4fColor4fNormal3fVertex4fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
        internal unsafe static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN = (TexCoord4fColor4fNormal3fVertex4fvSUN)GL.GetDelegateForExtensionMethod("glTexCoord4fColor4fNormal3fVertex4fvSUN", typeof(TexCoord4fColor4fNormal3fVertex4fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
        internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN = (ReplacementCodeuiVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiVertex3fSUN", typeof(ReplacementCodeuiVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
        internal unsafe static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN = (ReplacementCodeuiVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiVertex3fvSUN", typeof(ReplacementCodeuiVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
        internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN = (ReplacementCodeuiColor4ubVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiColor4ubVertex3fSUN", typeof(ReplacementCodeuiColor4ubVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
        internal unsafe static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN = (ReplacementCodeuiColor4ubVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiColor4ubVertex3fvSUN", typeof(ReplacementCodeuiColor4ubVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
        internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN = (ReplacementCodeuiColor3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiColor3fVertex3fSUN", typeof(ReplacementCodeuiColor3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
        internal unsafe static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN = (ReplacementCodeuiColor3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiColor3fVertex3fvSUN", typeof(ReplacementCodeuiColor3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN = (ReplacementCodeuiNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiNormal3fVertex3fSUN", typeof(ReplacementCodeuiNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN = (ReplacementCodeuiNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiNormal3fVertex3fvSUN", typeof(ReplacementCodeuiNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN = (ReplacementCodeuiColor4fNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiColor4fNormal3fVertex3fSUN", typeof(ReplacementCodeuiColor4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN = (ReplacementCodeuiColor4fNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", typeof(ReplacementCodeuiColor4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
        internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN = (ReplacementCodeuiTexCoord2fVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fVertex3fSUN", typeof(ReplacementCodeuiTexCoord2fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
        internal unsafe static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN = (ReplacementCodeuiTexCoord2fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fVertex3fvSUN", typeof(ReplacementCodeuiTexCoord2fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = (ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", typeof(ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = (ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", typeof(ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
        internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = (ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", typeof(ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
        internal unsafe static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = (ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN)GL.GetDelegateForExtensionMethod("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateEXT(GL.Enums.EXT_blend_func_separate sfactorRGB, GL.Enums.EXT_blend_func_separate dfactorRGB, GL.Enums.EXT_blend_func_separate sfactorAlpha, GL.Enums.EXT_blend_func_separate dfactorAlpha);
        internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT = (BlendFuncSeparateEXT)GL.GetDelegateForExtensionMethod("glBlendFuncSeparateEXT", typeof(BlendFuncSeparateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateINGR(GL.Enums.All sfactorRGB, GL.Enums.All dfactorRGB, GL.Enums.All sfactorAlpha, GL.Enums.All dfactorAlpha);
        internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR = (BlendFuncSeparateINGR)GL.GetDelegateForExtensionMethod("glBlendFuncSeparateINGR", typeof(BlendFuncSeparateINGR));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexWeightfEXT(Single weight);
        internal static VertexWeightfEXT glVertexWeightfEXT = (VertexWeightfEXT)GL.GetDelegateForExtensionMethod("glVertexWeightfEXT", typeof(VertexWeightfEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeightfvEXT(Single* weight);
        internal unsafe static VertexWeightfvEXT glVertexWeightfvEXT = (VertexWeightfvEXT)GL.GetDelegateForExtensionMethod("glVertexWeightfvEXT", typeof(VertexWeightfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeightPointerEXT(Int32 size, GL.Enums.EXT_vertex_weighting type, Int32 stride, void* pointer);
        internal unsafe static VertexWeightPointerEXT glVertexWeightPointerEXT = (VertexWeightPointerEXT)GL.GetDelegateForExtensionMethod("glVertexWeightPointerEXT", typeof(VertexWeightPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushVertexArrayRangeNV();
        internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV = (FlushVertexArrayRangeNV)GL.GetDelegateForExtensionMethod("glFlushVertexArrayRangeNV", typeof(FlushVertexArrayRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexArrayRangeNV(Int32 length, void* pointer);
        internal unsafe static VertexArrayRangeNV glVertexArrayRangeNV = (VertexArrayRangeNV)GL.GetDelegateForExtensionMethod("glVertexArrayRangeNV", typeof(VertexArrayRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerParameterfvNV(GL.Enums.NV_register_combiners pname, Single* @params);
        internal unsafe static CombinerParameterfvNV glCombinerParameterfvNV = (CombinerParameterfvNV)GL.GetDelegateForExtensionMethod("glCombinerParameterfvNV", typeof(CombinerParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerParameterfNV(GL.Enums.NV_register_combiners pname, Single param);
        internal static CombinerParameterfNV glCombinerParameterfNV = (CombinerParameterfNV)GL.GetDelegateForExtensionMethod("glCombinerParameterfNV", typeof(CombinerParameterfNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerParameterivNV(GL.Enums.NV_register_combiners pname, Int32* @params);
        internal unsafe static CombinerParameterivNV glCombinerParameterivNV = (CombinerParameterivNV)GL.GetDelegateForExtensionMethod("glCombinerParameterivNV", typeof(CombinerParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerParameteriNV(GL.Enums.NV_register_combiners pname, Int32 param);
        internal static CombinerParameteriNV glCombinerParameteriNV = (CombinerParameteriNV)GL.GetDelegateForExtensionMethod("glCombinerParameteriNV", typeof(CombinerParameteriNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerInputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
        internal static CombinerInputNV glCombinerInputNV = (CombinerInputNV)GL.GetDelegateForExtensionMethod("glCombinerInputNV", typeof(CombinerInputNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerOutputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners abOutput, GL.Enums.NV_register_combiners cdOutput, GL.Enums.NV_register_combiners sumOutput, GL.Enums.NV_register_combiners scale, GL.Enums.NV_register_combiners bias, GL.Enums.Boolean abDotProduct, GL.Enums.Boolean cdDotProduct, GL.Enums.Boolean muxSum);
        internal static CombinerOutputNV glCombinerOutputNV = (CombinerOutputNV)GL.GetDelegateForExtensionMethod("glCombinerOutputNV", typeof(CombinerOutputNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinalCombinerInputNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
        internal static FinalCombinerInputNV glFinalCombinerInputNV = (FinalCombinerInputNV)GL.GetDelegateForExtensionMethod("glFinalCombinerInputNV", typeof(FinalCombinerInputNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerInputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Single* @params);
        internal unsafe static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV = (GetCombinerInputParameterfvNV)GL.GetDelegateForExtensionMethod("glGetCombinerInputParameterfvNV", typeof(GetCombinerInputParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerInputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Int32* @params);
        internal unsafe static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV = (GetCombinerInputParameterivNV)GL.GetDelegateForExtensionMethod("glGetCombinerInputParameterivNV", typeof(GetCombinerInputParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerOutputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, [Out] Single* @params);
        internal unsafe static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV = (GetCombinerOutputParameterfvNV)GL.GetDelegateForExtensionMethod("glGetCombinerOutputParameterfvNV", typeof(GetCombinerOutputParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerOutputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, [Out] Int32* @params);
        internal unsafe static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV = (GetCombinerOutputParameterivNV)GL.GetDelegateForExtensionMethod("glGetCombinerOutputParameterivNV", typeof(GetCombinerOutputParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFinalCombinerInputParameterfvNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Single* @params);
        internal unsafe static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV = (GetFinalCombinerInputParameterfvNV)GL.GetDelegateForExtensionMethod("glGetFinalCombinerInputParameterfvNV", typeof(GetFinalCombinerInputParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFinalCombinerInputParameterivNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Int32* @params);
        internal unsafe static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV = (GetFinalCombinerInputParameterivNV)GL.GetDelegateForExtensionMethod("glGetFinalCombinerInputParameterivNV", typeof(GetFinalCombinerInputParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResizeBuffersMESA();
        internal static ResizeBuffersMESA glResizeBuffersMESA = (ResizeBuffersMESA)GL.GetDelegateForExtensionMethod("glResizeBuffersMESA", typeof(ResizeBuffersMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2dMESA(Double x, Double y);
        internal static WindowPos2dMESA glWindowPos2dMESA = (WindowPos2dMESA)GL.GetDelegateForExtensionMethod("glWindowPos2dMESA", typeof(WindowPos2dMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dvMESA(Double* v);
        internal unsafe static WindowPos2dvMESA glWindowPos2dvMESA = (WindowPos2dvMESA)GL.GetDelegateForExtensionMethod("glWindowPos2dvMESA", typeof(WindowPos2dvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2fMESA(Single x, Single y);
        internal static WindowPos2fMESA glWindowPos2fMESA = (WindowPos2fMESA)GL.GetDelegateForExtensionMethod("glWindowPos2fMESA", typeof(WindowPos2fMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fvMESA(Single* v);
        internal unsafe static WindowPos2fvMESA glWindowPos2fvMESA = (WindowPos2fvMESA)GL.GetDelegateForExtensionMethod("glWindowPos2fvMESA", typeof(WindowPos2fvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2iMESA(Int32 x, Int32 y);
        internal static WindowPos2iMESA glWindowPos2iMESA = (WindowPos2iMESA)GL.GetDelegateForExtensionMethod("glWindowPos2iMESA", typeof(WindowPos2iMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2ivMESA(Int32* v);
        internal unsafe static WindowPos2ivMESA glWindowPos2ivMESA = (WindowPos2ivMESA)GL.GetDelegateForExtensionMethod("glWindowPos2ivMESA", typeof(WindowPos2ivMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2sMESA(Int16 x, Int16 y);
        internal static WindowPos2sMESA glWindowPos2sMESA = (WindowPos2sMESA)GL.GetDelegateForExtensionMethod("glWindowPos2sMESA", typeof(WindowPos2sMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2svMESA(Int16* v);
        internal unsafe static WindowPos2svMESA glWindowPos2svMESA = (WindowPos2svMESA)GL.GetDelegateForExtensionMethod("glWindowPos2svMESA", typeof(WindowPos2svMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3dMESA(Double x, Double y, Double z);
        internal static WindowPos3dMESA glWindowPos3dMESA = (WindowPos3dMESA)GL.GetDelegateForExtensionMethod("glWindowPos3dMESA", typeof(WindowPos3dMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dvMESA(Double* v);
        internal unsafe static WindowPos3dvMESA glWindowPos3dvMESA = (WindowPos3dvMESA)GL.GetDelegateForExtensionMethod("glWindowPos3dvMESA", typeof(WindowPos3dvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3fMESA(Single x, Single y, Single z);
        internal static WindowPos3fMESA glWindowPos3fMESA = (WindowPos3fMESA)GL.GetDelegateForExtensionMethod("glWindowPos3fMESA", typeof(WindowPos3fMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fvMESA(Single* v);
        internal unsafe static WindowPos3fvMESA glWindowPos3fvMESA = (WindowPos3fvMESA)GL.GetDelegateForExtensionMethod("glWindowPos3fvMESA", typeof(WindowPos3fvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
        internal static WindowPos3iMESA glWindowPos3iMESA = (WindowPos3iMESA)GL.GetDelegateForExtensionMethod("glWindowPos3iMESA", typeof(WindowPos3iMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3ivMESA(Int32* v);
        internal unsafe static WindowPos3ivMESA glWindowPos3ivMESA = (WindowPos3ivMESA)GL.GetDelegateForExtensionMethod("glWindowPos3ivMESA", typeof(WindowPos3ivMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
        internal static WindowPos3sMESA glWindowPos3sMESA = (WindowPos3sMESA)GL.GetDelegateForExtensionMethod("glWindowPos3sMESA", typeof(WindowPos3sMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3svMESA(Int16* v);
        internal unsafe static WindowPos3svMESA glWindowPos3svMESA = (WindowPos3svMESA)GL.GetDelegateForExtensionMethod("glWindowPos3svMESA", typeof(WindowPos3svMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4dMESA(Double x, Double y, Double z, Double w);
        internal static WindowPos4dMESA glWindowPos4dMESA = (WindowPos4dMESA)GL.GetDelegateForExtensionMethod("glWindowPos4dMESA", typeof(WindowPos4dMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4dvMESA(Double* v);
        internal unsafe static WindowPos4dvMESA glWindowPos4dvMESA = (WindowPos4dvMESA)GL.GetDelegateForExtensionMethod("glWindowPos4dvMESA", typeof(WindowPos4dvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4fMESA(Single x, Single y, Single z, Single w);
        internal static WindowPos4fMESA glWindowPos4fMESA = (WindowPos4fMESA)GL.GetDelegateForExtensionMethod("glWindowPos4fMESA", typeof(WindowPos4fMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4fvMESA(Single* v);
        internal unsafe static WindowPos4fvMESA glWindowPos4fvMESA = (WindowPos4fvMESA)GL.GetDelegateForExtensionMethod("glWindowPos4fvMESA", typeof(WindowPos4fvMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
        internal static WindowPos4iMESA glWindowPos4iMESA = (WindowPos4iMESA)GL.GetDelegateForExtensionMethod("glWindowPos4iMESA", typeof(WindowPos4iMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4ivMESA(Int32* v);
        internal unsafe static WindowPos4ivMESA glWindowPos4ivMESA = (WindowPos4ivMESA)GL.GetDelegateForExtensionMethod("glWindowPos4ivMESA", typeof(WindowPos4ivMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
        internal static WindowPos4sMESA glWindowPos4sMESA = (WindowPos4sMESA)GL.GetDelegateForExtensionMethod("glWindowPos4sMESA", typeof(WindowPos4sMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4svMESA(Int16* v);
        internal unsafe static WindowPos4svMESA glWindowPos4svMESA = (WindowPos4svMESA)GL.GetDelegateForExtensionMethod("glWindowPos4svMESA", typeof(WindowPos4svMESA));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
        internal unsafe static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM = (MultiModeDrawArraysIBM)GL.GetDelegateForExtensionMethod("glMultiModeDrawArraysIBM", typeof(MultiModeDrawArraysIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, Int32* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, Int32 primcount, Int32 modestride);
        internal unsafe static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM = (MultiModeDrawElementsIBM)GL.GetDelegateForExtensionMethod("glMultiModeDrawElementsIBM", typeof(MultiModeDrawElementsIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointerListIBM(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static ColorPointerListIBM glColorPointerListIBM = (ColorPointerListIBM)GL.GetDelegateForExtensionMethod("glColorPointerListIBM", typeof(ColorPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointerListIBM(Int32 size, GL.Enums.IBM_vertex_array_lists type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM = (SecondaryColorPointerListIBM)GL.GetDelegateForExtensionMethod("glSecondaryColorPointerListIBM", typeof(SecondaryColorPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointerListIBM(Int32 stride, Boolean* pointer, Int32 ptrstride);
        internal unsafe static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM = (EdgeFlagPointerListIBM)GL.GetDelegateForExtensionMethod("glEdgeFlagPointerListIBM", typeof(EdgeFlagPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointerListIBM(GL.Enums.IBM_vertex_array_lists type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static FogCoordPointerListIBM glFogCoordPointerListIBM = (FogCoordPointerListIBM)GL.GetDelegateForExtensionMethod("glFogCoordPointerListIBM", typeof(FogCoordPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointerListIBM(GL.Enums.IndexPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static IndexPointerListIBM glIndexPointerListIBM = (IndexPointerListIBM)GL.GetDelegateForExtensionMethod("glIndexPointerListIBM", typeof(IndexPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointerListIBM(GL.Enums.NormalPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static NormalPointerListIBM glNormalPointerListIBM = (NormalPointerListIBM)GL.GetDelegateForExtensionMethod("glNormalPointerListIBM", typeof(NormalPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointerListIBM(Int32 size, GL.Enums.TexCoordPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static TexCoordPointerListIBM glTexCoordPointerListIBM = (TexCoordPointerListIBM)GL.GetDelegateForExtensionMethod("glTexCoordPointerListIBM", typeof(TexCoordPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointerListIBM(Int32 size, GL.Enums.VertexPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
        internal unsafe static VertexPointerListIBM glVertexPointerListIBM = (VertexPointerListIBM)GL.GetDelegateForExtensionMethod("glVertexPointerListIBM", typeof(VertexPointerListIBM));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TbufferMask3DFX(UInt32 mask);
        internal static TbufferMask3DFX glTbufferMask3DFX = (TbufferMask3DFX)GL.GetDelegateForExtensionMethod("glTbufferMask3DFX", typeof(TbufferMask3DFX)) ?? new TbufferMask3DFX(Imports.TbufferMask3DFX);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskEXT(Single value, GL.Enums.Boolean invert);
        internal static SampleMaskEXT glSampleMaskEXT = (SampleMaskEXT)GL.GetDelegateForExtensionMethod("glSampleMaskEXT", typeof(SampleMaskEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplePatternEXT(GL.Enums.EXT_multisample pattern);
        internal static SamplePatternEXT glSamplePatternEXT = (SamplePatternEXT)GL.GetDelegateForExtensionMethod("glSamplePatternEXT", typeof(SamplePatternEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureColorMaskSGIS(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
        internal static TextureColorMaskSGIS glTextureColorMaskSGIS = (TextureColorMaskSGIS)GL.GetDelegateForExtensionMethod("glTextureColorMaskSGIS", typeof(TextureColorMaskSGIS));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IglooInterfaceSGIX(GL.Enums.All pname, void* @params);
        internal unsafe static IglooInterfaceSGIX glIglooInterfaceSGIX = (IglooInterfaceSGIX)GL.GetDelegateForExtensionMethod("glIglooInterfaceSGIX", typeof(IglooInterfaceSGIX));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
        internal unsafe static DeleteFencesNV glDeleteFencesNV = (DeleteFencesNV)GL.GetDelegateForExtensionMethod("glDeleteFencesNV", typeof(DeleteFencesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFencesNV(Int32 n, [Out] UInt32* fences);
        internal unsafe static GenFencesNV glGenFencesNV = (GenFencesNV)GL.GetDelegateForExtensionMethod("glGenFencesNV", typeof(GenFencesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsFenceNV(UInt32 fence);
        internal static IsFenceNV glIsFenceNV = (IsFenceNV)GL.GetDelegateForExtensionMethod("glIsFenceNV", typeof(IsFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean TestFenceNV(UInt32 fence);
        internal static TestFenceNV glTestFenceNV = (TestFenceNV)GL.GetDelegateForExtensionMethod("glTestFenceNV", typeof(TestFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFenceivNV(UInt32 fence, GL.Enums.NV_fence pname, [Out] Int32* @params);
        internal unsafe static GetFenceivNV glGetFenceivNV = (GetFenceivNV)GL.GetDelegateForExtensionMethod("glGetFenceivNV", typeof(GetFenceivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishFenceNV(UInt32 fence);
        internal static FinishFenceNV glFinishFenceNV = (FinishFenceNV)GL.GetDelegateForExtensionMethod("glFinishFenceNV", typeof(FinishFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SetFenceNV(UInt32 fence, GL.Enums.NV_fence condition);
        internal static SetFenceNV glSetFenceNV = (SetFenceNV)GL.GetDelegateForExtensionMethod("glSetFenceNV", typeof(SetFenceNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapControlPointsNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, GL.Enums.Boolean packed, void* points);
        internal unsafe static MapControlPointsNV glMapControlPointsNV = (MapControlPointsNV)GL.GetDelegateForExtensionMethod("glMapControlPointsNV", typeof(MapControlPointsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, Int32* @params);
        internal unsafe static MapParameterivNV glMapParameterivNV = (MapParameterivNV)GL.GetDelegateForExtensionMethod("glMapParameterivNV", typeof(MapParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, Single* @params);
        internal unsafe static MapParameterfvNV glMapParameterfvNV = (MapParameterfvNV)GL.GetDelegateForExtensionMethod("glMapParameterfvNV", typeof(MapParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapControlPointsNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators type, Int32 ustride, Int32 vstride, GL.Enums.Boolean packed, [Out] void* points);
        internal unsafe static GetMapControlPointsNV glGetMapControlPointsNV = (GetMapControlPointsNV)GL.GetDelegateForExtensionMethod("glGetMapControlPointsNV", typeof(GetMapControlPointsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, [Out] Int32* @params);
        internal unsafe static GetMapParameterivNV glGetMapParameterivNV = (GetMapParameterivNV)GL.GetDelegateForExtensionMethod("glGetMapParameterivNV", typeof(GetMapParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, [Out] Single* @params);
        internal unsafe static GetMapParameterfvNV glGetMapParameterfvNV = (GetMapParameterfvNV)GL.GetDelegateForExtensionMethod("glGetMapParameterfvNV", typeof(GetMapParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapAttribParameterivNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators pname, [Out] Int32* @params);
        internal unsafe static GetMapAttribParameterivNV glGetMapAttribParameterivNV = (GetMapAttribParameterivNV)GL.GetDelegateForExtensionMethod("glGetMapAttribParameterivNV", typeof(GetMapAttribParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapAttribParameterfvNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators pname, [Out] Single* @params);
        internal unsafe static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV = (GetMapAttribParameterfvNV)GL.GetDelegateForExtensionMethod("glGetMapAttribParameterfvNV", typeof(GetMapAttribParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMapsNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators mode);
        internal static EvalMapsNV glEvalMapsNV = (EvalMapsNV)GL.GetDelegateForExtensionMethod("glEvalMapsNV", typeof(EvalMapsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, Single* @params);
        internal unsafe static CombinerStageParameterfvNV glCombinerStageParameterfvNV = (CombinerStageParameterfvNV)GL.GetDelegateForExtensionMethod("glCombinerStageParameterfvNV", typeof(CombinerStageParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, [Out] Single* @params);
        internal unsafe static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV = (GetCombinerStageParameterfvNV)GL.GetDelegateForExtensionMethod("glGetCombinerStageParameterfvNV", typeof(GetCombinerStageParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Boolean AreProgramsResidentNV(Int32 n, UInt32* programs, [Out] GL.Enums.Boolean* residences);
        internal unsafe static AreProgramsResidentNV glAreProgramsResidentNV = (AreProgramsResidentNV)GL.GetDelegateForExtensionMethod("glAreProgramsResidentNV", typeof(AreProgramsResidentNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramNV(GL.Enums.NV_vertex_program target, UInt32 id);
        internal static BindProgramNV glBindProgramNV = (BindProgramNV)GL.GetDelegateForExtensionMethod("glBindProgramNV", typeof(BindProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramsNV(Int32 n, UInt32* programs);
        internal unsafe static DeleteProgramsNV glDeleteProgramsNV = (DeleteProgramsNV)GL.GetDelegateForExtensionMethod("glDeleteProgramsNV", typeof(DeleteProgramsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ExecuteProgramNV(GL.Enums.NV_vertex_program target, UInt32 id, Single* @params);
        internal unsafe static ExecuteProgramNV glExecuteProgramNV = (ExecuteProgramNV)GL.GetDelegateForExtensionMethod("glExecuteProgramNV", typeof(ExecuteProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramsNV(Int32 n, [Out] UInt32* programs);
        internal unsafe static GenProgramsNV glGenProgramsNV = (GenProgramsNV)GL.GetDelegateForExtensionMethod("glGenProgramsNV", typeof(GenProgramsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramParameterdvNV(GL.Enums.NV_vertex_program target, UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Double* @params);
        internal unsafe static GetProgramParameterdvNV glGetProgramParameterdvNV = (GetProgramParameterdvNV)GL.GetDelegateForExtensionMethod("glGetProgramParameterdvNV", typeof(GetProgramParameterdvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramParameterfvNV(GL.Enums.NV_vertex_program target, UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Single* @params);
        internal unsafe static GetProgramParameterfvNV glGetProgramParameterfvNV = (GetProgramParameterfvNV)GL.GetDelegateForExtensionMethod("glGetProgramParameterfvNV", typeof(GetProgramParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivNV(UInt32 id, GL.Enums.NV_vertex_program pname, [Out] Int32* @params);
        internal unsafe static GetProgramivNV glGetProgramivNV = (GetProgramivNV)GL.GetDelegateForExtensionMethod("glGetProgramivNV", typeof(GetProgramivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStringNV(UInt32 id, GL.Enums.NV_vertex_program pname, [Out] Byte* program);
        internal unsafe static GetProgramStringNV glGetProgramStringNV = (GetProgramStringNV)GL.GetDelegateForExtensionMethod("glGetProgramStringNV", typeof(GetProgramStringNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTrackMatrixivNV(GL.Enums.NV_vertex_program target, UInt32 address, GL.Enums.NV_vertex_program pname, [Out] Int32* @params);
        internal unsafe static GetTrackMatrixivNV glGetTrackMatrixivNV = (GetTrackMatrixivNV)GL.GetDelegateForExtensionMethod("glGetTrackMatrixivNV", typeof(GetTrackMatrixivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Double* @params);
        internal unsafe static GetVertexAttribdvNV glGetVertexAttribdvNV = (GetVertexAttribdvNV)GL.GetDelegateForExtensionMethod("glGetVertexAttribdvNV", typeof(GetVertexAttribdvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribfvNV glGetVertexAttribfvNV = (GetVertexAttribfvNV)GL.GetDelegateForExtensionMethod("glGetVertexAttribfvNV", typeof(GetVertexAttribfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribivNV glGetVertexAttribivNV = (GetVertexAttribivNV)GL.GetDelegateForExtensionMethod("glGetVertexAttribivNV", typeof(GetVertexAttribivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointervNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] void* pointer);
        internal unsafe static GetVertexAttribPointervNV glGetVertexAttribPointervNV = (GetVertexAttribPointervNV)GL.GetDelegateForExtensionMethod("glGetVertexAttribPointervNV", typeof(GetVertexAttribPointervNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsProgramNV(UInt32 id);
        internal static IsProgramNV glIsProgramNV = (IsProgramNV)GL.GetDelegateForExtensionMethod("glIsProgramNV", typeof(IsProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadProgramNV(GL.Enums.NV_vertex_program target, UInt32 id, Int32 len, Byte* program);
        internal unsafe static LoadProgramNV glLoadProgramNV = (LoadProgramNV)GL.GetDelegateForExtensionMethod("glLoadProgramNV", typeof(LoadProgramNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameter4dNV(GL.Enums.NV_vertex_program target, UInt32 index, Double x, Double y, Double z, Double w);
        internal static ProgramParameter4dNV glProgramParameter4dNV = (ProgramParameter4dNV)GL.GetDelegateForExtensionMethod("glProgramParameter4dNV", typeof(ProgramParameter4dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameter4dvNV(GL.Enums.NV_vertex_program target, UInt32 index, Double* v);
        internal unsafe static ProgramParameter4dvNV glProgramParameter4dvNV = (ProgramParameter4dvNV)GL.GetDelegateForExtensionMethod("glProgramParameter4dvNV", typeof(ProgramParameter4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameter4fNV(GL.Enums.NV_vertex_program target, UInt32 index, Single x, Single y, Single z, Single w);
        internal static ProgramParameter4fNV glProgramParameter4fNV = (ProgramParameter4fNV)GL.GetDelegateForExtensionMethod("glProgramParameter4fNV", typeof(ProgramParameter4fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameter4fvNV(GL.Enums.NV_vertex_program target, UInt32 index, Single* v);
        internal unsafe static ProgramParameter4fvNV glProgramParameter4fvNV = (ProgramParameter4fvNV)GL.GetDelegateForExtensionMethod("glProgramParameter4fvNV", typeof(ProgramParameter4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameters4dvNV(GL.Enums.NV_vertex_program target, UInt32 index, UInt32 count, Double* v);
        internal unsafe static ProgramParameters4dvNV glProgramParameters4dvNV = (ProgramParameters4dvNV)GL.GetDelegateForExtensionMethod("glProgramParameters4dvNV", typeof(ProgramParameters4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameters4fvNV(GL.Enums.NV_vertex_program target, UInt32 index, UInt32 count, Single* v);
        internal unsafe static ProgramParameters4fvNV glProgramParameters4fvNV = (ProgramParameters4fvNV)GL.GetDelegateForExtensionMethod("glProgramParameters4fvNV", typeof(ProgramParameters4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RequestResidentProgramsNV(Int32 n, UInt32* programs);
        internal unsafe static RequestResidentProgramsNV glRequestResidentProgramsNV = (RequestResidentProgramsNV)GL.GetDelegateForExtensionMethod("glRequestResidentProgramsNV", typeof(RequestResidentProgramsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TrackMatrixNV(GL.Enums.NV_vertex_program target, UInt32 address, GL.Enums.NV_vertex_program matrix, GL.Enums.NV_vertex_program transform);
        internal static TrackMatrixNV glTrackMatrixNV = (TrackMatrixNV)GL.GetDelegateForExtensionMethod("glTrackMatrixNV", typeof(TrackMatrixNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointerNV(UInt32 index, Int32 fsize, GL.Enums.NV_vertex_program type, Int32 stride, void* pointer);
        internal unsafe static VertexAttribPointerNV glVertexAttribPointerNV = (VertexAttribPointerNV)GL.GetDelegateForExtensionMethod("glVertexAttribPointerNV", typeof(VertexAttribPointerNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dNV(UInt32 index, Double x);
        internal static VertexAttrib1dNV glVertexAttrib1dNV = (VertexAttrib1dNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1dNV", typeof(VertexAttrib1dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib1dvNV glVertexAttrib1dvNV = (VertexAttrib1dvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1dvNV", typeof(VertexAttrib1dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fNV(UInt32 index, Single x);
        internal static VertexAttrib1fNV glVertexAttrib1fNV = (VertexAttrib1fNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1fNV", typeof(VertexAttrib1fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib1fvNV glVertexAttrib1fvNV = (VertexAttrib1fvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1fvNV", typeof(VertexAttrib1fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sNV(UInt32 index, Int16 x);
        internal static VertexAttrib1sNV glVertexAttrib1sNV = (VertexAttrib1sNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1sNV", typeof(VertexAttrib1sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib1svNV glVertexAttrib1svNV = (VertexAttrib1svNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1svNV", typeof(VertexAttrib1svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dNV(UInt32 index, Double x, Double y);
        internal static VertexAttrib2dNV glVertexAttrib2dNV = (VertexAttrib2dNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2dNV", typeof(VertexAttrib2dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib2dvNV glVertexAttrib2dvNV = (VertexAttrib2dvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2dvNV", typeof(VertexAttrib2dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fNV(UInt32 index, Single x, Single y);
        internal static VertexAttrib2fNV glVertexAttrib2fNV = (VertexAttrib2fNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2fNV", typeof(VertexAttrib2fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib2fvNV glVertexAttrib2fvNV = (VertexAttrib2fvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2fvNV", typeof(VertexAttrib2fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
        internal static VertexAttrib2sNV glVertexAttrib2sNV = (VertexAttrib2sNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2sNV", typeof(VertexAttrib2sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib2svNV glVertexAttrib2svNV = (VertexAttrib2svNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2svNV", typeof(VertexAttrib2svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
        internal static VertexAttrib3dNV glVertexAttrib3dNV = (VertexAttrib3dNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3dNV", typeof(VertexAttrib3dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib3dvNV glVertexAttrib3dvNV = (VertexAttrib3dvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3dvNV", typeof(VertexAttrib3dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
        internal static VertexAttrib3fNV glVertexAttrib3fNV = (VertexAttrib3fNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3fNV", typeof(VertexAttrib3fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib3fvNV glVertexAttrib3fvNV = (VertexAttrib3fvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3fvNV", typeof(VertexAttrib3fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
        internal static VertexAttrib3sNV glVertexAttrib3sNV = (VertexAttrib3sNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3sNV", typeof(VertexAttrib3sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib3svNV glVertexAttrib3svNV = (VertexAttrib3svNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3svNV", typeof(VertexAttrib3svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
        internal static VertexAttrib4dNV glVertexAttrib4dNV = (VertexAttrib4dNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4dNV", typeof(VertexAttrib4dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvNV(UInt32 index, Double* v);
        internal unsafe static VertexAttrib4dvNV glVertexAttrib4dvNV = (VertexAttrib4dvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4dvNV", typeof(VertexAttrib4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
        internal static VertexAttrib4fNV glVertexAttrib4fNV = (VertexAttrib4fNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4fNV", typeof(VertexAttrib4fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvNV(UInt32 index, Single* v);
        internal unsafe static VertexAttrib4fvNV glVertexAttrib4fvNV = (VertexAttrib4fvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4fvNV", typeof(VertexAttrib4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexAttrib4sNV glVertexAttrib4sNV = (VertexAttrib4sNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4sNV", typeof(VertexAttrib4sNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svNV(UInt32 index, Int16* v);
        internal unsafe static VertexAttrib4svNV glVertexAttrib4svNV = (VertexAttrib4svNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4svNV", typeof(VertexAttrib4svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
        internal static VertexAttrib4ubNV glVertexAttrib4ubNV = (VertexAttrib4ubNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4ubNV", typeof(VertexAttrib4ubNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvNV(UInt32 index, Byte* v);
        internal unsafe static VertexAttrib4ubvNV glVertexAttrib4ubvNV = (VertexAttrib4ubvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4ubvNV", typeof(VertexAttrib4ubvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs1dvNV glVertexAttribs1dvNV = (VertexAttribs1dvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs1dvNV", typeof(VertexAttribs1dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs1fvNV glVertexAttribs1fvNV = (VertexAttribs1fvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs1fvNV", typeof(VertexAttribs1fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs1svNV glVertexAttribs1svNV = (VertexAttribs1svNV)GL.GetDelegateForExtensionMethod("glVertexAttribs1svNV", typeof(VertexAttribs1svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs2dvNV glVertexAttribs2dvNV = (VertexAttribs2dvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs2dvNV", typeof(VertexAttribs2dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs2fvNV glVertexAttribs2fvNV = (VertexAttribs2fvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs2fvNV", typeof(VertexAttribs2fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs2svNV glVertexAttribs2svNV = (VertexAttribs2svNV)GL.GetDelegateForExtensionMethod("glVertexAttribs2svNV", typeof(VertexAttribs2svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs3dvNV glVertexAttribs3dvNV = (VertexAttribs3dvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs3dvNV", typeof(VertexAttribs3dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs3fvNV glVertexAttribs3fvNV = (VertexAttribs3fvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs3fvNV", typeof(VertexAttribs3fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs3svNV glVertexAttribs3svNV = (VertexAttribs3svNV)GL.GetDelegateForExtensionMethod("glVertexAttribs3svNV", typeof(VertexAttribs3svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
        internal unsafe static VertexAttribs4dvNV glVertexAttribs4dvNV = (VertexAttribs4dvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs4dvNV", typeof(VertexAttribs4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
        internal unsafe static VertexAttribs4fvNV glVertexAttribs4fvNV = (VertexAttribs4fvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs4fvNV", typeof(VertexAttribs4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
        internal unsafe static VertexAttribs4svNV glVertexAttribs4svNV = (VertexAttribs4svNV)GL.GetDelegateForExtensionMethod("glVertexAttribs4svNV", typeof(VertexAttribs4svNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
        internal unsafe static VertexAttribs4ubvNV glVertexAttribs4ubvNV = (VertexAttribs4ubvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs4ubvNV", typeof(VertexAttribs4ubvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, Int32* param);
        internal unsafe static TexBumpParameterivATI glTexBumpParameterivATI = (TexBumpParameterivATI)GL.GetDelegateForExtensionMethod("glTexBumpParameterivATI", typeof(TexBumpParameterivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, Single* param);
        internal unsafe static TexBumpParameterfvATI glTexBumpParameterfvATI = (TexBumpParameterfvATI)GL.GetDelegateForExtensionMethod("glTexBumpParameterfvATI", typeof(TexBumpParameterfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, [Out] Int32* param);
        internal unsafe static GetTexBumpParameterivATI glGetTexBumpParameterivATI = (GetTexBumpParameterivATI)GL.GetDelegateForExtensionMethod("glGetTexBumpParameterivATI", typeof(GetTexBumpParameterivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, [Out] Single* param);
        internal unsafe static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI = (GetTexBumpParameterfvATI)GL.GetDelegateForExtensionMethod("glGetTexBumpParameterfvATI", typeof(GetTexBumpParameterfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenFragmentShadersATI(UInt32 range);
        internal static GenFragmentShadersATI glGenFragmentShadersATI = (GenFragmentShadersATI)GL.GetDelegateForExtensionMethod("glGenFragmentShadersATI", typeof(GenFragmentShadersATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragmentShaderATI(UInt32 id);
        internal static BindFragmentShaderATI glBindFragmentShaderATI = (BindFragmentShaderATI)GL.GetDelegateForExtensionMethod("glBindFragmentShaderATI", typeof(BindFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteFragmentShaderATI(UInt32 id);
        internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI = (DeleteFragmentShaderATI)GL.GetDelegateForExtensionMethod("glDeleteFragmentShaderATI", typeof(DeleteFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginFragmentShaderATI();
        internal static BeginFragmentShaderATI glBeginFragmentShaderATI = (BeginFragmentShaderATI)GL.GetDelegateForExtensionMethod("glBeginFragmentShaderATI", typeof(BeginFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndFragmentShaderATI();
        internal static EndFragmentShaderATI glEndFragmentShaderATI = (EndFragmentShaderATI)GL.GetDelegateForExtensionMethod("glEndFragmentShaderATI", typeof(EndFragmentShaderATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PassTexCoordATI(UInt32 dst, UInt32 coord, GL.Enums.ATI_fragment_shader swizzle);
        internal static PassTexCoordATI glPassTexCoordATI = (PassTexCoordATI)GL.GetDelegateForExtensionMethod("glPassTexCoordATI", typeof(PassTexCoordATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMapATI(UInt32 dst, UInt32 interp, GL.Enums.ATI_fragment_shader swizzle);
        internal static SampleMapATI glSampleMapATI = (SampleMapATI)GL.GetDelegateForExtensionMethod("glSampleMapATI", typeof(SampleMapATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
        internal static ColorFragmentOp1ATI glColorFragmentOp1ATI = (ColorFragmentOp1ATI)GL.GetDelegateForExtensionMethod("glColorFragmentOp1ATI", typeof(ColorFragmentOp1ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
        internal static ColorFragmentOp2ATI glColorFragmentOp2ATI = (ColorFragmentOp2ATI)GL.GetDelegateForExtensionMethod("glColorFragmentOp2ATI", typeof(ColorFragmentOp2ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
        internal static ColorFragmentOp3ATI glColorFragmentOp3ATI = (ColorFragmentOp3ATI)GL.GetDelegateForExtensionMethod("glColorFragmentOp3ATI", typeof(ColorFragmentOp3ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
        internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI = (AlphaFragmentOp1ATI)GL.GetDelegateForExtensionMethod("glAlphaFragmentOp1ATI", typeof(AlphaFragmentOp1ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
        internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI = (AlphaFragmentOp2ATI)GL.GetDelegateForExtensionMethod("glAlphaFragmentOp2ATI", typeof(AlphaFragmentOp2ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
        internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI = (AlphaFragmentOp3ATI)GL.GetDelegateForExtensionMethod("glAlphaFragmentOp3ATI", typeof(AlphaFragmentOp3ATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
        internal unsafe static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI = (SetFragmentShaderConstantATI)GL.GetDelegateForExtensionMethod("glSetFragmentShaderConstantATI", typeof(SetFragmentShaderConstantATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PNTrianglesiATI(GL.Enums.ATI_pn_triangles pname, Int32 param);
        internal static PNTrianglesiATI glPNTrianglesiATI = (PNTrianglesiATI)GL.GetDelegateForExtensionMethod("glPNTrianglesiATI", typeof(PNTrianglesiATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PNTrianglesfATI(GL.Enums.ATI_pn_triangles pname, Single param);
        internal static PNTrianglesfATI glPNTrianglesfATI = (PNTrianglesfATI)GL.GetDelegateForExtensionMethod("glPNTrianglesfATI", typeof(PNTrianglesfATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate Int32 NewObjectBufferATI(Int32 size, void* pointer, GL.Enums.ATI_vertex_array_object usage);
        internal unsafe static NewObjectBufferATI glNewObjectBufferATI = (NewObjectBufferATI)GL.GetDelegateForExtensionMethod("glNewObjectBufferATI", typeof(NewObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsObjectBufferATI(UInt32 buffer);
        internal static IsObjectBufferATI glIsObjectBufferATI = (IsObjectBufferATI)GL.GetDelegateForExtensionMethod("glIsObjectBufferATI", typeof(IsObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, void* pointer, GL.Enums.ATI_vertex_array_object preserve);
        internal unsafe static UpdateObjectBufferATI glUpdateObjectBufferATI = (UpdateObjectBufferATI)GL.GetDelegateForExtensionMethod("glUpdateObjectBufferATI", typeof(UpdateObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectBufferfvATI(UInt32 buffer, GL.Enums.ATI_vertex_array_object pname, [Out] Single* @params);
        internal unsafe static GetObjectBufferfvATI glGetObjectBufferfvATI = (GetObjectBufferfvATI)GL.GetDelegateForExtensionMethod("glGetObjectBufferfvATI", typeof(GetObjectBufferfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectBufferivATI(UInt32 buffer, GL.Enums.ATI_vertex_array_object pname, [Out] Int32* @params);
        internal unsafe static GetObjectBufferivATI glGetObjectBufferivATI = (GetObjectBufferivATI)GL.GetDelegateForExtensionMethod("glGetObjectBufferivATI", typeof(GetObjectBufferivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FreeObjectBufferATI(UInt32 buffer);
        internal static FreeObjectBufferATI glFreeObjectBufferATI = (FreeObjectBufferATI)GL.GetDelegateForExtensionMethod("glFreeObjectBufferATI", typeof(FreeObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayObjectATI(GL.Enums.EnableCap array, Int32 size, GL.Enums.ATI_vertex_array_object type, Int32 stride, UInt32 buffer, UInt32 offset);
        internal static ArrayObjectATI glArrayObjectATI = (ArrayObjectATI)GL.GetDelegateForExtensionMethod("glArrayObjectATI", typeof(ArrayObjectATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetArrayObjectfvATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, [Out] Single* @params);
        internal unsafe static GetArrayObjectfvATI glGetArrayObjectfvATI = (GetArrayObjectfvATI)GL.GetDelegateForExtensionMethod("glGetArrayObjectfvATI", typeof(GetArrayObjectfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetArrayObjectivATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, [Out] Int32* @params);
        internal unsafe static GetArrayObjectivATI glGetArrayObjectivATI = (GetArrayObjectivATI)GL.GetDelegateForExtensionMethod("glGetArrayObjectivATI", typeof(GetArrayObjectivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VariantArrayObjectATI(UInt32 id, GL.Enums.ATI_vertex_array_object type, Int32 stride, UInt32 buffer, UInt32 offset);
        internal static VariantArrayObjectATI glVariantArrayObjectATI = (VariantArrayObjectATI)GL.GetDelegateForExtensionMethod("glVariantArrayObjectATI", typeof(VariantArrayObjectATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantArrayObjectfvATI(UInt32 id, GL.Enums.ATI_vertex_array_object pname, [Out] Single* @params);
        internal unsafe static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI = (GetVariantArrayObjectfvATI)GL.GetDelegateForExtensionMethod("glGetVariantArrayObjectfvATI", typeof(GetVariantArrayObjectfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantArrayObjectivATI(UInt32 id, GL.Enums.ATI_vertex_array_object pname, [Out] Int32* @params);
        internal unsafe static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI = (GetVariantArrayObjectivATI)GL.GetDelegateForExtensionMethod("glGetVariantArrayObjectivATI", typeof(GetVariantArrayObjectivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginVertexShaderEXT();
        internal static BeginVertexShaderEXT glBeginVertexShaderEXT = (BeginVertexShaderEXT)GL.GetDelegateForExtensionMethod("glBeginVertexShaderEXT", typeof(BeginVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndVertexShaderEXT();
        internal static EndVertexShaderEXT glEndVertexShaderEXT = (EndVertexShaderEXT)GL.GetDelegateForExtensionMethod("glEndVertexShaderEXT", typeof(EndVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexShaderEXT(UInt32 id);
        internal static BindVertexShaderEXT glBindVertexShaderEXT = (BindVertexShaderEXT)GL.GetDelegateForExtensionMethod("glBindVertexShaderEXT", typeof(BindVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenVertexShadersEXT(UInt32 range);
        internal static GenVertexShadersEXT glGenVertexShadersEXT = (GenVertexShadersEXT)GL.GetDelegateForExtensionMethod("glGenVertexShadersEXT", typeof(GenVertexShadersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteVertexShaderEXT(UInt32 id);
        internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT = (DeleteVertexShaderEXT)GL.GetDelegateForExtensionMethod("glDeleteVertexShaderEXT", typeof(DeleteVertexShaderEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp1EXT(GL.Enums.EXT_vertex_shader op, UInt32 res, UInt32 arg1);
        internal static ShaderOp1EXT glShaderOp1EXT = (ShaderOp1EXT)GL.GetDelegateForExtensionMethod("glShaderOp1EXT", typeof(ShaderOp1EXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp2EXT(GL.Enums.EXT_vertex_shader op, UInt32 res, UInt32 arg1, UInt32 arg2);
        internal static ShaderOp2EXT glShaderOp2EXT = (ShaderOp2EXT)GL.GetDelegateForExtensionMethod("glShaderOp2EXT", typeof(ShaderOp2EXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp3EXT(GL.Enums.EXT_vertex_shader op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
        internal static ShaderOp3EXT glShaderOp3EXT = (ShaderOp3EXT)GL.GetDelegateForExtensionMethod("glShaderOp3EXT", typeof(ShaderOp3EXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SwizzleEXT(UInt32 res, UInt32 @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
        internal static SwizzleEXT glSwizzleEXT = (SwizzleEXT)GL.GetDelegateForExtensionMethod("glSwizzleEXT", typeof(SwizzleEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WriteMaskEXT(UInt32 res, UInt32 @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
        internal static WriteMaskEXT glWriteMaskEXT = (WriteMaskEXT)GL.GetDelegateForExtensionMethod("glWriteMaskEXT", typeof(WriteMaskEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
        internal static InsertComponentEXT glInsertComponentEXT = (InsertComponentEXT)GL.GetDelegateForExtensionMethod("glInsertComponentEXT", typeof(InsertComponentEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
        internal static ExtractComponentEXT glExtractComponentEXT = (ExtractComponentEXT)GL.GetDelegateForExtensionMethod("glExtractComponentEXT", typeof(ExtractComponentEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GenSymbolsEXT(GL.Enums.EXT_vertex_shader datatype, GL.Enums.EXT_vertex_shader storagetype, GL.Enums.EXT_vertex_shader range, UInt32 components);
        internal static GenSymbolsEXT glGenSymbolsEXT = (GenSymbolsEXT)GL.GetDelegateForExtensionMethod("glGenSymbolsEXT", typeof(GenSymbolsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetInvariantEXT(UInt32 id, GL.Enums.EXT_vertex_shader type, void* addr);
        internal unsafe static SetInvariantEXT glSetInvariantEXT = (SetInvariantEXT)GL.GetDelegateForExtensionMethod("glSetInvariantEXT", typeof(SetInvariantEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetLocalConstantEXT(UInt32 id, GL.Enums.EXT_vertex_shader type, void* addr);
        internal unsafe static SetLocalConstantEXT glSetLocalConstantEXT = (SetLocalConstantEXT)GL.GetDelegateForExtensionMethod("glSetLocalConstantEXT", typeof(SetLocalConstantEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantbvEXT(UInt32 id, SByte* addr);
        internal unsafe static VariantbvEXT glVariantbvEXT = (VariantbvEXT)GL.GetDelegateForExtensionMethod("glVariantbvEXT", typeof(VariantbvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantsvEXT(UInt32 id, Int16* addr);
        internal unsafe static VariantsvEXT glVariantsvEXT = (VariantsvEXT)GL.GetDelegateForExtensionMethod("glVariantsvEXT", typeof(VariantsvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantivEXT(UInt32 id, Int32* addr);
        internal unsafe static VariantivEXT glVariantivEXT = (VariantivEXT)GL.GetDelegateForExtensionMethod("glVariantivEXT", typeof(VariantivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantfvEXT(UInt32 id, Single* addr);
        internal unsafe static VariantfvEXT glVariantfvEXT = (VariantfvEXT)GL.GetDelegateForExtensionMethod("glVariantfvEXT", typeof(VariantfvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantdvEXT(UInt32 id, Double* addr);
        internal unsafe static VariantdvEXT glVariantdvEXT = (VariantdvEXT)GL.GetDelegateForExtensionMethod("glVariantdvEXT", typeof(VariantdvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantubvEXT(UInt32 id, Byte* addr);
        internal unsafe static VariantubvEXT glVariantubvEXT = (VariantubvEXT)GL.GetDelegateForExtensionMethod("glVariantubvEXT", typeof(VariantubvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantusvEXT(UInt32 id, UInt16* addr);
        internal unsafe static VariantusvEXT glVariantusvEXT = (VariantusvEXT)GL.GetDelegateForExtensionMethod("glVariantusvEXT", typeof(VariantusvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantuivEXT(UInt32 id, UInt32* addr);
        internal unsafe static VariantuivEXT glVariantuivEXT = (VariantuivEXT)GL.GetDelegateForExtensionMethod("glVariantuivEXT", typeof(VariantuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantPointerEXT(UInt32 id, GL.Enums.EXT_vertex_shader type, UInt32 stride, void* addr);
        internal unsafe static VariantPointerEXT glVariantPointerEXT = (VariantPointerEXT)GL.GetDelegateForExtensionMethod("glVariantPointerEXT", typeof(VariantPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVariantClientStateEXT(UInt32 id);
        internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT = (EnableVariantClientStateEXT)GL.GetDelegateForExtensionMethod("glEnableVariantClientStateEXT", typeof(EnableVariantClientStateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVariantClientStateEXT(UInt32 id);
        internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT = (DisableVariantClientStateEXT)GL.GetDelegateForExtensionMethod("glDisableVariantClientStateEXT", typeof(DisableVariantClientStateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindLightParameterEXT(GL.Enums.LightName light, GL.Enums.LightParameter value);
        internal static BindLightParameterEXT glBindLightParameterEXT = (BindLightParameterEXT)GL.GetDelegateForExtensionMethod("glBindLightParameterEXT", typeof(BindLightParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindMaterialParameterEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter value);
        internal static BindMaterialParameterEXT glBindMaterialParameterEXT = (BindMaterialParameterEXT)GL.GetDelegateForExtensionMethod("glBindMaterialParameterEXT", typeof(BindMaterialParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindTexGenParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter value);
        internal static BindTexGenParameterEXT glBindTexGenParameterEXT = (BindTexGenParameterEXT)GL.GetDelegateForExtensionMethod("glBindTexGenParameterEXT", typeof(BindTexGenParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindTextureUnitParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.EXT_vertex_shader value);
        internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT = (BindTextureUnitParameterEXT)GL.GetDelegateForExtensionMethod("glBindTextureUnitParameterEXT", typeof(BindTextureUnitParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 BindParameterEXT(GL.Enums.EXT_vertex_shader value);
        internal static BindParameterEXT glBindParameterEXT = (BindParameterEXT)GL.GetDelegateForExtensionMethod("glBindParameterEXT", typeof(BindParameterEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsVariantEnabledEXT(UInt32 id, GL.Enums.EXT_vertex_shader cap);
        internal static IsVariantEnabledEXT glIsVariantEnabledEXT = (IsVariantEnabledEXT)GL.GetDelegateForExtensionMethod("glIsVariantEnabledEXT", typeof(IsVariantEnabledEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantBooleanvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] GL.Enums.Boolean* data);
        internal unsafe static GetVariantBooleanvEXT glGetVariantBooleanvEXT = (GetVariantBooleanvEXT)GL.GetDelegateForExtensionMethod("glGetVariantBooleanvEXT", typeof(GetVariantBooleanvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantIntegervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Int32* data);
        internal unsafe static GetVariantIntegervEXT glGetVariantIntegervEXT = (GetVariantIntegervEXT)GL.GetDelegateForExtensionMethod("glGetVariantIntegervEXT", typeof(GetVariantIntegervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantFloatvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Single* data);
        internal unsafe static GetVariantFloatvEXT glGetVariantFloatvEXT = (GetVariantFloatvEXT)GL.GetDelegateForExtensionMethod("glGetVariantFloatvEXT", typeof(GetVariantFloatvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantPointervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] void* data);
        internal unsafe static GetVariantPointervEXT glGetVariantPointervEXT = (GetVariantPointervEXT)GL.GetDelegateForExtensionMethod("glGetVariantPointervEXT", typeof(GetVariantPointervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantBooleanvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] GL.Enums.Boolean* data);
        internal unsafe static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT = (GetInvariantBooleanvEXT)GL.GetDelegateForExtensionMethod("glGetInvariantBooleanvEXT", typeof(GetInvariantBooleanvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantIntegervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Int32* data);
        internal unsafe static GetInvariantIntegervEXT glGetInvariantIntegervEXT = (GetInvariantIntegervEXT)GL.GetDelegateForExtensionMethod("glGetInvariantIntegervEXT", typeof(GetInvariantIntegervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantFloatvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Single* data);
        internal unsafe static GetInvariantFloatvEXT glGetInvariantFloatvEXT = (GetInvariantFloatvEXT)GL.GetDelegateForExtensionMethod("glGetInvariantFloatvEXT", typeof(GetInvariantFloatvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantBooleanvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] GL.Enums.Boolean* data);
        internal unsafe static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT = (GetLocalConstantBooleanvEXT)GL.GetDelegateForExtensionMethod("glGetLocalConstantBooleanvEXT", typeof(GetLocalConstantBooleanvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantIntegervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Int32* data);
        internal unsafe static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT = (GetLocalConstantIntegervEXT)GL.GetDelegateForExtensionMethod("glGetLocalConstantIntegervEXT", typeof(GetLocalConstantIntegervEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantFloatvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Single* data);
        internal unsafe static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT = (GetLocalConstantFloatvEXT)GL.GetDelegateForExtensionMethod("glGetLocalConstantFloatvEXT", typeof(GetLocalConstantFloatvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1sATI(GL.Enums.ATI_vertex_streams stream, Int16 x);
        internal static VertexStream1sATI glVertexStream1sATI = (VertexStream1sATI)GL.GetDelegateForExtensionMethod("glVertexStream1sATI", typeof(VertexStream1sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
        internal unsafe static VertexStream1svATI glVertexStream1svATI = (VertexStream1svATI)GL.GetDelegateForExtensionMethod("glVertexStream1svATI", typeof(VertexStream1svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1iATI(GL.Enums.ATI_vertex_streams stream, Int32 x);
        internal static VertexStream1iATI glVertexStream1iATI = (VertexStream1iATI)GL.GetDelegateForExtensionMethod("glVertexStream1iATI", typeof(VertexStream1iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
        internal unsafe static VertexStream1ivATI glVertexStream1ivATI = (VertexStream1ivATI)GL.GetDelegateForExtensionMethod("glVertexStream1ivATI", typeof(VertexStream1ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1fATI(GL.Enums.ATI_vertex_streams stream, Single x);
        internal static VertexStream1fATI glVertexStream1fATI = (VertexStream1fATI)GL.GetDelegateForExtensionMethod("glVertexStream1fATI", typeof(VertexStream1fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
        internal unsafe static VertexStream1fvATI glVertexStream1fvATI = (VertexStream1fvATI)GL.GetDelegateForExtensionMethod("glVertexStream1fvATI", typeof(VertexStream1fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1dATI(GL.Enums.ATI_vertex_streams stream, Double x);
        internal static VertexStream1dATI glVertexStream1dATI = (VertexStream1dATI)GL.GetDelegateForExtensionMethod("glVertexStream1dATI", typeof(VertexStream1dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
        internal unsafe static VertexStream1dvATI glVertexStream1dvATI = (VertexStream1dvATI)GL.GetDelegateForExtensionMethod("glVertexStream1dvATI", typeof(VertexStream1dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2sATI(GL.Enums.ATI_vertex_streams stream, Int16 x, Int16 y);
        internal static VertexStream2sATI glVertexStream2sATI = (VertexStream2sATI)GL.GetDelegateForExtensionMethod("glVertexStream2sATI", typeof(VertexStream2sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
        internal unsafe static VertexStream2svATI glVertexStream2svATI = (VertexStream2svATI)GL.GetDelegateForExtensionMethod("glVertexStream2svATI", typeof(VertexStream2svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2iATI(GL.Enums.ATI_vertex_streams stream, Int32 x, Int32 y);
        internal static VertexStream2iATI glVertexStream2iATI = (VertexStream2iATI)GL.GetDelegateForExtensionMethod("glVertexStream2iATI", typeof(VertexStream2iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
        internal unsafe static VertexStream2ivATI glVertexStream2ivATI = (VertexStream2ivATI)GL.GetDelegateForExtensionMethod("glVertexStream2ivATI", typeof(VertexStream2ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2fATI(GL.Enums.ATI_vertex_streams stream, Single x, Single y);
        internal static VertexStream2fATI glVertexStream2fATI = (VertexStream2fATI)GL.GetDelegateForExtensionMethod("glVertexStream2fATI", typeof(VertexStream2fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
        internal unsafe static VertexStream2fvATI glVertexStream2fvATI = (VertexStream2fvATI)GL.GetDelegateForExtensionMethod("glVertexStream2fvATI", typeof(VertexStream2fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2dATI(GL.Enums.ATI_vertex_streams stream, Double x, Double y);
        internal static VertexStream2dATI glVertexStream2dATI = (VertexStream2dATI)GL.GetDelegateForExtensionMethod("glVertexStream2dATI", typeof(VertexStream2dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
        internal unsafe static VertexStream2dvATI glVertexStream2dvATI = (VertexStream2dvATI)GL.GetDelegateForExtensionMethod("glVertexStream2dvATI", typeof(VertexStream2dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3sATI(GL.Enums.ATI_vertex_streams stream, Int16 x, Int16 y, Int16 z);
        internal static VertexStream3sATI glVertexStream3sATI = (VertexStream3sATI)GL.GetDelegateForExtensionMethod("glVertexStream3sATI", typeof(VertexStream3sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
        internal unsafe static VertexStream3svATI glVertexStream3svATI = (VertexStream3svATI)GL.GetDelegateForExtensionMethod("glVertexStream3svATI", typeof(VertexStream3svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3iATI(GL.Enums.ATI_vertex_streams stream, Int32 x, Int32 y, Int32 z);
        internal static VertexStream3iATI glVertexStream3iATI = (VertexStream3iATI)GL.GetDelegateForExtensionMethod("glVertexStream3iATI", typeof(VertexStream3iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
        internal unsafe static VertexStream3ivATI glVertexStream3ivATI = (VertexStream3ivATI)GL.GetDelegateForExtensionMethod("glVertexStream3ivATI", typeof(VertexStream3ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3fATI(GL.Enums.ATI_vertex_streams stream, Single x, Single y, Single z);
        internal static VertexStream3fATI glVertexStream3fATI = (VertexStream3fATI)GL.GetDelegateForExtensionMethod("glVertexStream3fATI", typeof(VertexStream3fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
        internal unsafe static VertexStream3fvATI glVertexStream3fvATI = (VertexStream3fvATI)GL.GetDelegateForExtensionMethod("glVertexStream3fvATI", typeof(VertexStream3fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3dATI(GL.Enums.ATI_vertex_streams stream, Double x, Double y, Double z);
        internal static VertexStream3dATI glVertexStream3dATI = (VertexStream3dATI)GL.GetDelegateForExtensionMethod("glVertexStream3dATI", typeof(VertexStream3dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
        internal unsafe static VertexStream3dvATI glVertexStream3dvATI = (VertexStream3dvATI)GL.GetDelegateForExtensionMethod("glVertexStream3dvATI", typeof(VertexStream3dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4sATI(GL.Enums.ATI_vertex_streams stream, Int16 x, Int16 y, Int16 z, Int16 w);
        internal static VertexStream4sATI glVertexStream4sATI = (VertexStream4sATI)GL.GetDelegateForExtensionMethod("glVertexStream4sATI", typeof(VertexStream4sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
        internal unsafe static VertexStream4svATI glVertexStream4svATI = (VertexStream4svATI)GL.GetDelegateForExtensionMethod("glVertexStream4svATI", typeof(VertexStream4svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4iATI(GL.Enums.ATI_vertex_streams stream, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static VertexStream4iATI glVertexStream4iATI = (VertexStream4iATI)GL.GetDelegateForExtensionMethod("glVertexStream4iATI", typeof(VertexStream4iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
        internal unsafe static VertexStream4ivATI glVertexStream4ivATI = (VertexStream4ivATI)GL.GetDelegateForExtensionMethod("glVertexStream4ivATI", typeof(VertexStream4ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4fATI(GL.Enums.ATI_vertex_streams stream, Single x, Single y, Single z, Single w);
        internal static VertexStream4fATI glVertexStream4fATI = (VertexStream4fATI)GL.GetDelegateForExtensionMethod("glVertexStream4fATI", typeof(VertexStream4fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
        internal unsafe static VertexStream4fvATI glVertexStream4fvATI = (VertexStream4fvATI)GL.GetDelegateForExtensionMethod("glVertexStream4fvATI", typeof(VertexStream4fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4dATI(GL.Enums.ATI_vertex_streams stream, Double x, Double y, Double z, Double w);
        internal static VertexStream4dATI glVertexStream4dATI = (VertexStream4dATI)GL.GetDelegateForExtensionMethod("glVertexStream4dATI", typeof(VertexStream4dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
        internal unsafe static VertexStream4dvATI glVertexStream4dvATI = (VertexStream4dvATI)GL.GetDelegateForExtensionMethod("glVertexStream4dvATI", typeof(VertexStream4dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3bATI(GL.Enums.ATI_vertex_streams stream, SByte nx, SByte ny, SByte nz);
        internal static NormalStream3bATI glNormalStream3bATI = (NormalStream3bATI)GL.GetDelegateForExtensionMethod("glNormalStream3bATI", typeof(NormalStream3bATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3bvATI(GL.Enums.ATI_vertex_streams stream, SByte* coords);
        internal unsafe static NormalStream3bvATI glNormalStream3bvATI = (NormalStream3bvATI)GL.GetDelegateForExtensionMethod("glNormalStream3bvATI", typeof(NormalStream3bvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3sATI(GL.Enums.ATI_vertex_streams stream, Int16 nx, Int16 ny, Int16 nz);
        internal static NormalStream3sATI glNormalStream3sATI = (NormalStream3sATI)GL.GetDelegateForExtensionMethod("glNormalStream3sATI", typeof(NormalStream3sATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
        internal unsafe static NormalStream3svATI glNormalStream3svATI = (NormalStream3svATI)GL.GetDelegateForExtensionMethod("glNormalStream3svATI", typeof(NormalStream3svATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3iATI(GL.Enums.ATI_vertex_streams stream, Int32 nx, Int32 ny, Int32 nz);
        internal static NormalStream3iATI glNormalStream3iATI = (NormalStream3iATI)GL.GetDelegateForExtensionMethod("glNormalStream3iATI", typeof(NormalStream3iATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
        internal unsafe static NormalStream3ivATI glNormalStream3ivATI = (NormalStream3ivATI)GL.GetDelegateForExtensionMethod("glNormalStream3ivATI", typeof(NormalStream3ivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3fATI(GL.Enums.ATI_vertex_streams stream, Single nx, Single ny, Single nz);
        internal static NormalStream3fATI glNormalStream3fATI = (NormalStream3fATI)GL.GetDelegateForExtensionMethod("glNormalStream3fATI", typeof(NormalStream3fATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
        internal unsafe static NormalStream3fvATI glNormalStream3fvATI = (NormalStream3fvATI)GL.GetDelegateForExtensionMethod("glNormalStream3fvATI", typeof(NormalStream3fvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3dATI(GL.Enums.ATI_vertex_streams stream, Double nx, Double ny, Double nz);
        internal static NormalStream3dATI glNormalStream3dATI = (NormalStream3dATI)GL.GetDelegateForExtensionMethod("glNormalStream3dATI", typeof(NormalStream3dATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
        internal unsafe static NormalStream3dvATI glNormalStream3dvATI = (NormalStream3dvATI)GL.GetDelegateForExtensionMethod("glNormalStream3dvATI", typeof(NormalStream3dvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveVertexStreamATI(GL.Enums.ATI_vertex_streams stream);
        internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI = (ClientActiveVertexStreamATI)GL.GetDelegateForExtensionMethod("glClientActiveVertexStreamATI", typeof(ClientActiveVertexStreamATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendEnviATI(GL.Enums.ATI_vertex_streams pname, Int32 param);
        internal static VertexBlendEnviATI glVertexBlendEnviATI = (VertexBlendEnviATI)GL.GetDelegateForExtensionMethod("glVertexBlendEnviATI", typeof(VertexBlendEnviATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendEnvfATI(GL.Enums.ATI_vertex_streams pname, Single param);
        internal static VertexBlendEnvfATI glVertexBlendEnvfATI = (VertexBlendEnvfATI)GL.GetDelegateForExtensionMethod("glVertexBlendEnvfATI", typeof(VertexBlendEnvfATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ElementPointerATI(GL.Enums.ATI_element_array type, void* pointer);
        internal unsafe static ElementPointerATI glElementPointerATI = (ElementPointerATI)GL.GetDelegateForExtensionMethod("glElementPointerATI", typeof(ElementPointerATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementArrayATI(GL.Enums.BeginMode mode, Int32 count);
        internal static DrawElementArrayATI glDrawElementArrayATI = (DrawElementArrayATI)GL.GetDelegateForExtensionMethod("glDrawElementArrayATI", typeof(DrawElementArrayATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementArrayATI(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 count);
        internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI = (DrawRangeElementArrayATI)GL.GetDelegateForExtensionMethod("glDrawRangeElementArrayATI", typeof(DrawRangeElementArrayATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawMeshArraysSUN(GL.Enums.BeginMode mode, Int32 first, Int32 count, Int32 width);
        internal static DrawMeshArraysSUN glDrawMeshArraysSUN = (DrawMeshArraysSUN)GL.GetDelegateForExtensionMethod("glDrawMeshArraysSUN", typeof(DrawMeshArraysSUN));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenOcclusionQueriesNV(Int32 n, [Out] UInt32* ids);
        internal unsafe static GenOcclusionQueriesNV glGenOcclusionQueriesNV = (GenOcclusionQueriesNV)GL.GetDelegateForExtensionMethod("glGenOcclusionQueriesNV", typeof(GenOcclusionQueriesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
        internal unsafe static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV = (DeleteOcclusionQueriesNV)GL.GetDelegateForExtensionMethod("glDeleteOcclusionQueriesNV", typeof(DeleteOcclusionQueriesNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsOcclusionQueryNV(UInt32 id);
        internal static IsOcclusionQueryNV glIsOcclusionQueryNV = (IsOcclusionQueryNV)GL.GetDelegateForExtensionMethod("glIsOcclusionQueryNV", typeof(IsOcclusionQueryNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginOcclusionQueryNV(UInt32 id);
        internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV = (BeginOcclusionQueryNV)GL.GetDelegateForExtensionMethod("glBeginOcclusionQueryNV", typeof(BeginOcclusionQueryNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndOcclusionQueryNV();
        internal static EndOcclusionQueryNV glEndOcclusionQueryNV = (EndOcclusionQueryNV)GL.GetDelegateForExtensionMethod("glEndOcclusionQueryNV", typeof(EndOcclusionQueryNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetOcclusionQueryivNV(UInt32 id, GL.Enums.NV_occlusion_query pname, [Out] Int32* @params);
        internal unsafe static GetOcclusionQueryivNV glGetOcclusionQueryivNV = (GetOcclusionQueryivNV)GL.GetDelegateForExtensionMethod("glGetOcclusionQueryivNV", typeof(GetOcclusionQueryivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetOcclusionQueryuivNV(UInt32 id, GL.Enums.NV_occlusion_query pname, [Out] UInt32* @params);
        internal unsafe static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV = (GetOcclusionQueryuivNV)GL.GetDelegateForExtensionMethod("glGetOcclusionQueryuivNV", typeof(GetOcclusionQueryuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteriNV(GL.Enums.NV_point_sprite pname, Int32 param);
        internal static PointParameteriNV glPointParameteriNV = (PointParameteriNV)GL.GetDelegateForExtensionMethod("glPointParameteriNV", typeof(PointParameteriNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterivNV(GL.Enums.NV_point_sprite pname, Int32* @params);
        internal unsafe static PointParameterivNV glPointParameterivNV = (PointParameterivNV)GL.GetDelegateForExtensionMethod("glPointParameterivNV", typeof(PointParameterivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveStencilFaceEXT(GL.Enums.EXT_stencil_two_side face);
        internal static ActiveStencilFaceEXT glActiveStencilFaceEXT = (ActiveStencilFaceEXT)GL.GetDelegateForExtensionMethod("glActiveStencilFaceEXT", typeof(ActiveStencilFaceEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ElementPointerAPPLE(GL.Enums.APPLE_element_array type, void* pointer);
        internal unsafe static ElementPointerAPPLE glElementPointerAPPLE = (ElementPointerAPPLE)GL.GetDelegateForExtensionMethod("glElementPointerAPPLE", typeof(ElementPointerAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementArrayAPPLE(GL.Enums.BeginMode mode, Int32 first, Int32 count);
        internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE = (DrawElementArrayAPPLE)GL.GetDelegateForExtensionMethod("glDrawElementArrayAPPLE", typeof(DrawElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
        internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE = (DrawRangeElementArrayAPPLE)GL.GetDelegateForExtensionMethod("glDrawRangeElementArrayAPPLE", typeof(DrawRangeElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementArrayAPPLE(GL.Enums.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
        internal unsafe static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE = (MultiDrawElementArrayAPPLE)GL.GetDelegateForExtensionMethod("glMultiDrawElementArrayAPPLE", typeof(MultiDrawElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
        internal unsafe static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE = (MultiDrawRangeElementArrayAPPLE)GL.GetDelegateForExtensionMethod("glMultiDrawRangeElementArrayAPPLE", typeof(MultiDrawRangeElementArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFencesAPPLE(Int32 n, [Out] UInt32* fences);
        internal unsafe static GenFencesAPPLE glGenFencesAPPLE = (GenFencesAPPLE)GL.GetDelegateForExtensionMethod("glGenFencesAPPLE", typeof(GenFencesAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFencesAPPLE(Int32 n, UInt32* fences);
        internal unsafe static DeleteFencesAPPLE glDeleteFencesAPPLE = (DeleteFencesAPPLE)GL.GetDelegateForExtensionMethod("glDeleteFencesAPPLE", typeof(DeleteFencesAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SetFenceAPPLE(UInt32 fence);
        internal static SetFenceAPPLE glSetFenceAPPLE = (SetFenceAPPLE)GL.GetDelegateForExtensionMethod("glSetFenceAPPLE", typeof(SetFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsFenceAPPLE(UInt32 fence);
        internal static IsFenceAPPLE glIsFenceAPPLE = (IsFenceAPPLE)GL.GetDelegateForExtensionMethod("glIsFenceAPPLE", typeof(IsFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean TestFenceAPPLE(UInt32 fence);
        internal static TestFenceAPPLE glTestFenceAPPLE = (TestFenceAPPLE)GL.GetDelegateForExtensionMethod("glTestFenceAPPLE", typeof(TestFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishFenceAPPLE(UInt32 fence);
        internal static FinishFenceAPPLE glFinishFenceAPPLE = (FinishFenceAPPLE)GL.GetDelegateForExtensionMethod("glFinishFenceAPPLE", typeof(FinishFenceAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean TestObjectAPPLE(GL.Enums.APPLE_fence @object, UInt32 name);
        internal static TestObjectAPPLE glTestObjectAPPLE = (TestObjectAPPLE)GL.GetDelegateForExtensionMethod("glTestObjectAPPLE", typeof(TestObjectAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishObjectAPPLE(GL.Enums.APPLE_fence @object, Int32 name);
        internal static FinishObjectAPPLE glFinishObjectAPPLE = (FinishObjectAPPLE)GL.GetDelegateForExtensionMethod("glFinishObjectAPPLE", typeof(FinishObjectAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexArrayAPPLE(UInt32 array);
        internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE = (BindVertexArrayAPPLE)GL.GetDelegateForExtensionMethod("glBindVertexArrayAPPLE", typeof(BindVertexArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
        internal unsafe static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE = (DeleteVertexArraysAPPLE)GL.GetDelegateForExtensionMethod("glDeleteVertexArraysAPPLE", typeof(DeleteVertexArraysAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenVertexArraysAPPLE(Int32 n, [Out] UInt32* arrays);
        internal unsafe static GenVertexArraysAPPLE glGenVertexArraysAPPLE = (GenVertexArraysAPPLE)GL.GetDelegateForExtensionMethod("glGenVertexArraysAPPLE", typeof(GenVertexArraysAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsVertexArrayAPPLE(UInt32 array);
        internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE = (IsVertexArrayAPPLE)GL.GetDelegateForExtensionMethod("glIsVertexArrayAPPLE", typeof(IsVertexArrayAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
        internal unsafe static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE = (VertexArrayRangeAPPLE)GL.GetDelegateForExtensionMethod("glVertexArrayRangeAPPLE", typeof(VertexArrayRangeAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FlushVertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
        internal unsafe static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE = (FlushVertexArrayRangeAPPLE)GL.GetDelegateForExtensionMethod("glFlushVertexArrayRangeAPPLE", typeof(FlushVertexArrayRangeAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexArrayParameteriAPPLE(GL.Enums.APPLE_vertex_array_range pname, Int32 param);
        internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE = (VertexArrayParameteriAPPLE)GL.GetDelegateForExtensionMethod("glVertexArrayParameteriAPPLE", typeof(VertexArrayParameteriAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersATI(Int32 n, GL.Enums.ATI_draw_buffers* bufs);
        internal unsafe static DrawBuffersATI glDrawBuffersATI = (DrawBuffersATI)GL.GetDelegateForExtensionMethod("glDrawBuffersATI", typeof(DrawBuffersATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
        internal unsafe static ProgramNamedParameter4fNV glProgramNamedParameter4fNV = (ProgramNamedParameter4fNV)GL.GetDelegateForExtensionMethod("glProgramNamedParameter4fNV", typeof(ProgramNamedParameter4fNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
        internal unsafe static ProgramNamedParameter4dNV glProgramNamedParameter4dNV = (ProgramNamedParameter4dNV)GL.GetDelegateForExtensionMethod("glProgramNamedParameter4dNV", typeof(ProgramNamedParameter4dNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
        internal unsafe static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV = (ProgramNamedParameter4fvNV)GL.GetDelegateForExtensionMethod("glProgramNamedParameter4fvNV", typeof(ProgramNamedParameter4fvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
        internal unsafe static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV = (ProgramNamedParameter4dvNV)GL.GetDelegateForExtensionMethod("glProgramNamedParameter4dvNV", typeof(ProgramNamedParameter4dvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [Out] Single* @params);
        internal unsafe static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV = (GetProgramNamedParameterfvNV)GL.GetDelegateForExtensionMethod("glGetProgramNamedParameterfvNV", typeof(GetProgramNamedParameterfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [Out] Double* @params);
        internal unsafe static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV = (GetProgramNamedParameterdvNV)GL.GetDelegateForExtensionMethod("glGetProgramNamedParameterdvNV", typeof(GetProgramNamedParameterdvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2hNV(UInt16 x, UInt16 y);
        internal static Vertex2hNV glVertex2hNV = (Vertex2hNV)GL.GetDelegateForExtensionMethod("glVertex2hNV", typeof(Vertex2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2hvNV(UInt16* v);
        internal unsafe static Vertex2hvNV glVertex2hvNV = (Vertex2hvNV)GL.GetDelegateForExtensionMethod("glVertex2hvNV", typeof(Vertex2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3hNV(UInt16 x, UInt16 y, UInt16 z);
        internal static Vertex3hNV glVertex3hNV = (Vertex3hNV)GL.GetDelegateForExtensionMethod("glVertex3hNV", typeof(Vertex3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3hvNV(UInt16* v);
        internal unsafe static Vertex3hvNV glVertex3hvNV = (Vertex3hvNV)GL.GetDelegateForExtensionMethod("glVertex3hvNV", typeof(Vertex3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);
        internal static Vertex4hNV glVertex4hNV = (Vertex4hNV)GL.GetDelegateForExtensionMethod("glVertex4hNV", typeof(Vertex4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4hvNV(UInt16* v);
        internal unsafe static Vertex4hvNV glVertex4hvNV = (Vertex4hvNV)GL.GetDelegateForExtensionMethod("glVertex4hvNV", typeof(Vertex4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);
        internal static Normal3hNV glNormal3hNV = (Normal3hNV)GL.GetDelegateForExtensionMethod("glNormal3hNV", typeof(Normal3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3hvNV(UInt16* v);
        internal unsafe static Normal3hvNV glNormal3hvNV = (Normal3hvNV)GL.GetDelegateForExtensionMethod("glNormal3hvNV", typeof(Normal3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3hNV(UInt16 red, UInt16 green, UInt16 blue);
        internal static Color3hNV glColor3hNV = (Color3hNV)GL.GetDelegateForExtensionMethod("glColor3hNV", typeof(Color3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3hvNV(UInt16* v);
        internal unsafe static Color3hvNV glColor3hvNV = (Color3hvNV)GL.GetDelegateForExtensionMethod("glColor3hvNV", typeof(Color3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
        internal static Color4hNV glColor4hNV = (Color4hNV)GL.GetDelegateForExtensionMethod("glColor4hNV", typeof(Color4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4hvNV(UInt16* v);
        internal unsafe static Color4hvNV glColor4hvNV = (Color4hvNV)GL.GetDelegateForExtensionMethod("glColor4hvNV", typeof(Color4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1hNV(UInt16 s);
        internal static TexCoord1hNV glTexCoord1hNV = (TexCoord1hNV)GL.GetDelegateForExtensionMethod("glTexCoord1hNV", typeof(TexCoord1hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1hvNV(UInt16* v);
        internal unsafe static TexCoord1hvNV glTexCoord1hvNV = (TexCoord1hvNV)GL.GetDelegateForExtensionMethod("glTexCoord1hvNV", typeof(TexCoord1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2hNV(UInt16 s, UInt16 t);
        internal static TexCoord2hNV glTexCoord2hNV = (TexCoord2hNV)GL.GetDelegateForExtensionMethod("glTexCoord2hNV", typeof(TexCoord2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2hvNV(UInt16* v);
        internal unsafe static TexCoord2hvNV glTexCoord2hvNV = (TexCoord2hvNV)GL.GetDelegateForExtensionMethod("glTexCoord2hvNV", typeof(TexCoord2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);
        internal static TexCoord3hNV glTexCoord3hNV = (TexCoord3hNV)GL.GetDelegateForExtensionMethod("glTexCoord3hNV", typeof(TexCoord3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3hvNV(UInt16* v);
        internal unsafe static TexCoord3hvNV glTexCoord3hvNV = (TexCoord3hvNV)GL.GetDelegateForExtensionMethod("glTexCoord3hvNV", typeof(TexCoord3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);
        internal static TexCoord4hNV glTexCoord4hNV = (TexCoord4hNV)GL.GetDelegateForExtensionMethod("glTexCoord4hNV", typeof(TexCoord4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4hvNV(UInt16* v);
        internal unsafe static TexCoord4hvNV glTexCoord4hvNV = (TexCoord4hvNV)GL.GetDelegateForExtensionMethod("glTexCoord4hvNV", typeof(TexCoord4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1hNV(GL.Enums.NV_half_float target, UInt16 s);
        internal static MultiTexCoord1hNV glMultiTexCoord1hNV = (MultiTexCoord1hNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord1hNV", typeof(MultiTexCoord1hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1hvNV(GL.Enums.NV_half_float target, UInt16* v);
        internal unsafe static MultiTexCoord1hvNV glMultiTexCoord1hvNV = (MultiTexCoord1hvNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord1hvNV", typeof(MultiTexCoord1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2hNV(GL.Enums.NV_half_float target, UInt16 s, UInt16 t);
        internal static MultiTexCoord2hNV glMultiTexCoord2hNV = (MultiTexCoord2hNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord2hNV", typeof(MultiTexCoord2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2hvNV(GL.Enums.NV_half_float target, UInt16* v);
        internal unsafe static MultiTexCoord2hvNV glMultiTexCoord2hvNV = (MultiTexCoord2hvNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord2hvNV", typeof(MultiTexCoord2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3hNV(GL.Enums.NV_half_float target, UInt16 s, UInt16 t, UInt16 r);
        internal static MultiTexCoord3hNV glMultiTexCoord3hNV = (MultiTexCoord3hNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord3hNV", typeof(MultiTexCoord3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3hvNV(GL.Enums.NV_half_float target, UInt16* v);
        internal unsafe static MultiTexCoord3hvNV glMultiTexCoord3hvNV = (MultiTexCoord3hvNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord3hvNV", typeof(MultiTexCoord3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4hNV(GL.Enums.NV_half_float target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);
        internal static MultiTexCoord4hNV glMultiTexCoord4hNV = (MultiTexCoord4hNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord4hNV", typeof(MultiTexCoord4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4hvNV(GL.Enums.NV_half_float target, UInt16* v);
        internal unsafe static MultiTexCoord4hvNV glMultiTexCoord4hvNV = (MultiTexCoord4hvNV)GL.GetDelegateForExtensionMethod("glMultiTexCoord4hvNV", typeof(MultiTexCoord4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordhNV(UInt16 fog);
        internal static FogCoordhNV glFogCoordhNV = (FogCoordhNV)GL.GetDelegateForExtensionMethod("glFogCoordhNV", typeof(FogCoordhNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordhvNV(UInt16* fog);
        internal unsafe static FogCoordhvNV glFogCoordhvNV = (FogCoordhvNV)GL.GetDelegateForExtensionMethod("glFogCoordhvNV", typeof(FogCoordhvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
        internal static SecondaryColor3hNV glSecondaryColor3hNV = (SecondaryColor3hNV)GL.GetDelegateForExtensionMethod("glSecondaryColor3hNV", typeof(SecondaryColor3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3hvNV(UInt16* v);
        internal unsafe static SecondaryColor3hvNV glSecondaryColor3hvNV = (SecondaryColor3hvNV)GL.GetDelegateForExtensionMethod("glSecondaryColor3hvNV", typeof(SecondaryColor3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexWeighthNV(UInt16 weight);
        internal static VertexWeighthNV glVertexWeighthNV = (VertexWeighthNV)GL.GetDelegateForExtensionMethod("glVertexWeighthNV", typeof(VertexWeighthNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeighthvNV(UInt16* weight);
        internal unsafe static VertexWeighthvNV glVertexWeighthvNV = (VertexWeighthvNV)GL.GetDelegateForExtensionMethod("glVertexWeighthvNV", typeof(VertexWeighthvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1hNV(UInt32 index, UInt16 x);
        internal static VertexAttrib1hNV glVertexAttrib1hNV = (VertexAttrib1hNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1hNV", typeof(VertexAttrib1hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib1hvNV glVertexAttrib1hvNV = (VertexAttrib1hvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib1hvNV", typeof(VertexAttrib1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);
        internal static VertexAttrib2hNV glVertexAttrib2hNV = (VertexAttrib2hNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2hNV", typeof(VertexAttrib2hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib2hvNV glVertexAttrib2hvNV = (VertexAttrib2hvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib2hvNV", typeof(VertexAttrib2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);
        internal static VertexAttrib3hNV glVertexAttrib3hNV = (VertexAttrib3hNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3hNV", typeof(VertexAttrib3hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib3hvNV glVertexAttrib3hvNV = (VertexAttrib3hvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib3hvNV", typeof(VertexAttrib3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);
        internal static VertexAttrib4hNV glVertexAttrib4hNV = (VertexAttrib4hNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4hNV", typeof(VertexAttrib4hNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4hvNV(UInt32 index, UInt16* v);
        internal unsafe static VertexAttrib4hvNV glVertexAttrib4hvNV = (VertexAttrib4hvNV)GL.GetDelegateForExtensionMethod("glVertexAttrib4hvNV", typeof(VertexAttrib4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs1hvNV glVertexAttribs1hvNV = (VertexAttribs1hvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs1hvNV", typeof(VertexAttribs1hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs2hvNV glVertexAttribs2hvNV = (VertexAttribs2hvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs2hvNV", typeof(VertexAttribs2hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs3hvNV glVertexAttribs3hvNV = (VertexAttribs3hvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs3hvNV", typeof(VertexAttribs3hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);
        internal unsafe static VertexAttribs4hvNV glVertexAttribs4hvNV = (VertexAttribs4hvNV)GL.GetDelegateForExtensionMethod("glVertexAttribs4hvNV", typeof(VertexAttribs4hvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelDataRangeNV(GL.Enums.NV_pixel_data_range target, Int32 length, [Out] void* pointer);
        internal unsafe static PixelDataRangeNV glPixelDataRangeNV = (PixelDataRangeNV)GL.GetDelegateForExtensionMethod("glPixelDataRangeNV", typeof(PixelDataRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushPixelDataRangeNV(GL.Enums.NV_pixel_data_range target);
        internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV = (FlushPixelDataRangeNV)GL.GetDelegateForExtensionMethod("glFlushPixelDataRangeNV", typeof(FlushPixelDataRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartNV();
        internal static PrimitiveRestartNV glPrimitiveRestartNV = (PrimitiveRestartNV)GL.GetDelegateForExtensionMethod("glPrimitiveRestartNV", typeof(PrimitiveRestartNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartIndexNV(UInt32 index);
        internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV = (PrimitiveRestartIndexNV)GL.GetDelegateForExtensionMethod("glPrimitiveRestartIndexNV", typeof(PrimitiveRestartIndexNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr MapObjectBufferATI(UInt32 buffer);
        internal static MapObjectBufferATI glMapObjectBufferATI = (MapObjectBufferATI)GL.GetDelegateForExtensionMethod("glMapObjectBufferATI", typeof(MapObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UnmapObjectBufferATI(UInt32 buffer);
        internal static UnmapObjectBufferATI glUnmapObjectBufferATI = (UnmapObjectBufferATI)GL.GetDelegateForExtensionMethod("glUnmapObjectBufferATI", typeof(UnmapObjectBufferATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparateATI(GL.Enums.ATI_separate_stencil face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
        internal static StencilOpSeparateATI glStencilOpSeparateATI = (StencilOpSeparateATI)GL.GetDelegateForExtensionMethod("glStencilOpSeparateATI", typeof(StencilOpSeparateATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparateATI(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, Int32 @ref, UInt32 mask);
        internal static StencilFuncSeparateATI glStencilFuncSeparateATI = (StencilFuncSeparateATI)GL.GetDelegateForExtensionMethod("glStencilFuncSeparateATI", typeof(StencilFuncSeparateATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribArrayObjectATI(UInt32 index, Int32 size, GL.Enums.ATI_vertex_attrib_array_object type, GL.Enums.Boolean normalized, Int32 stride, UInt32 buffer, UInt32 offset);
        internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI = (VertexAttribArrayObjectATI)GL.GetDelegateForExtensionMethod("glVertexAttribArrayObjectATI", typeof(VertexAttribArrayObjectATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribArrayObjectfvATI(UInt32 index, GL.Enums.ATI_vertex_attrib_array_object pname, [Out] Single* @params);
        internal unsafe static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI = (GetVertexAttribArrayObjectfvATI)GL.GetDelegateForExtensionMethod("glGetVertexAttribArrayObjectfvATI", typeof(GetVertexAttribArrayObjectfvATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribArrayObjectivATI(UInt32 index, GL.Enums.ATI_vertex_attrib_array_object pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI = (GetVertexAttribArrayObjectivATI)GL.GetDelegateForExtensionMethod("glGetVertexAttribArrayObjectivATI", typeof(GetVertexAttribArrayObjectivATI));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthBoundsEXT(Double zmin, Double zmax);
        internal static DepthBoundsEXT glDepthBoundsEXT = (DepthBoundsEXT)GL.GetDelegateForExtensionMethod("glDepthBoundsEXT", typeof(DepthBoundsEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparateEXT(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
        internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT = (BlendEquationSeparateEXT)GL.GetDelegateForExtensionMethod("glBlendEquationSeparateEXT", typeof(BlendEquationSeparateEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsRenderbufferEXT(UInt32 renderbuffer);
        internal static IsRenderbufferEXT glIsRenderbufferEXT = (IsRenderbufferEXT)GL.GetDelegateForExtensionMethod("glIsRenderbufferEXT", typeof(IsRenderbufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, UInt32 renderbuffer);
        internal static BindRenderbufferEXT glBindRenderbufferEXT = (BindRenderbufferEXT)GL.GetDelegateForExtensionMethod("glBindRenderbufferEXT", typeof(BindRenderbufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
        internal unsafe static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT = (DeleteRenderbuffersEXT)GL.GetDelegateForExtensionMethod("glDeleteRenderbuffersEXT", typeof(DeleteRenderbuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenRenderbuffersEXT(Int32 n, [Out] UInt32* renderbuffers);
        internal unsafe static GenRenderbuffersEXT glGenRenderbuffersEXT = (GenRenderbuffersEXT)GL.GetDelegateForExtensionMethod("glGenRenderbuffersEXT", typeof(GenRenderbuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object internalformat, Int32 width, Int32 height);
        internal static RenderbufferStorageEXT glRenderbufferStorageEXT = (RenderbufferStorageEXT)GL.GetDelegateForExtensionMethod("glRenderbufferStorageEXT", typeof(RenderbufferStorageEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetRenderbufferParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object pname, [Out] Int32* @params);
        internal unsafe static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT = (GetRenderbufferParameterivEXT)GL.GetDelegateForExtensionMethod("glGetRenderbufferParameterivEXT", typeof(GetRenderbufferParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsFramebufferEXT(UInt32 framebuffer);
        internal static IsFramebufferEXT glIsFramebufferEXT = (IsFramebufferEXT)GL.GetDelegateForExtensionMethod("glIsFramebufferEXT", typeof(IsFramebufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFramebufferEXT(GL.Enums.EXT_framebuffer_object target, UInt32 framebuffer);
        internal static BindFramebufferEXT glBindFramebufferEXT = (BindFramebufferEXT)GL.GetDelegateForExtensionMethod("glBindFramebufferEXT", typeof(BindFramebufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
        internal unsafe static DeleteFramebuffersEXT glDeleteFramebuffersEXT = (DeleteFramebuffersEXT)GL.GetDelegateForExtensionMethod("glDeleteFramebuffersEXT", typeof(DeleteFramebuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFramebuffersEXT(Int32 n, [Out] UInt32* framebuffers);
        internal unsafe static GenFramebuffersEXT glGenFramebuffersEXT = (GenFramebuffersEXT)GL.GetDelegateForExtensionMethod("glGenFramebuffersEXT", typeof(GenFramebuffersEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GL.Enums.All CheckFramebufferStatusEXT(GL.Enums.EXT_framebuffer_object target);
        internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT = (CheckFramebufferStatusEXT)GL.GetDelegateForExtensionMethod("glCheckFramebufferStatusEXT", typeof(CheckFramebufferStatusEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture1DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object textarget, UInt32 texture, Int32 level);
        internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT = (FramebufferTexture1DEXT)GL.GetDelegateForExtensionMethod("glFramebufferTexture1DEXT", typeof(FramebufferTexture1DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture2DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object textarget, UInt32 texture, Int32 level);
        internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT = (FramebufferTexture2DEXT)GL.GetDelegateForExtensionMethod("glFramebufferTexture2DEXT", typeof(FramebufferTexture2DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture3DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object textarget, UInt32 texture, Int32 level, Int32 zoffset);
        internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT = (FramebufferTexture3DEXT)GL.GetDelegateForExtensionMethod("glFramebufferTexture3DEXT", typeof(FramebufferTexture3DEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object renderbuffertarget, UInt32 renderbuffer);
        internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT = (FramebufferRenderbufferEXT)GL.GetDelegateForExtensionMethod("glFramebufferRenderbufferEXT", typeof(FramebufferRenderbufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object pname, [Out] Int32* @params);
        internal unsafe static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT = (GetFramebufferAttachmentParameterivEXT)GL.GetDelegateForExtensionMethod("glGetFramebufferAttachmentParameterivEXT", typeof(GetFramebufferAttachmentParameterivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GenerateMipmapEXT(GL.Enums.EXT_framebuffer_object target);
        internal static GenerateMipmapEXT glGenerateMipmapEXT = (GenerateMipmapEXT)GL.GetDelegateForExtensionMethod("glGenerateMipmapEXT", typeof(GenerateMipmapEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void StringMarkerGREMEDY(Int32 len, void* @string);
        internal unsafe static StringMarkerGREMEDY glStringMarkerGREMEDY = (StringMarkerGREMEDY)GL.GetDelegateForExtensionMethod("glStringMarkerGREMEDY", typeof(StringMarkerGREMEDY));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
        internal static StencilClearTagEXT glStencilClearTagEXT = (StencilClearTagEXT)GL.GetDelegateForExtensionMethod("glStencilClearTagEXT", typeof(StencilClearTagEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, GL.Enums.ClearBufferMask mask, GL.Enums.EXT_framebuffer_blit filter);
        internal static BlitFramebufferEXT glBlitFramebufferEXT = (BlitFramebufferEXT)GL.GetDelegateForExtensionMethod("glBlitFramebufferEXT", typeof(BlitFramebufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampleEXT(GL.Enums.EXT_framebuffer_multisample target, Int32 samples, GL.Enums.EXT_framebuffer_multisample internalformat, Int32 width, Int32 height);
        internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT = (RenderbufferStorageMultisampleEXT)GL.GetDelegateForExtensionMethod("glRenderbufferStorageMultisampleEXT", typeof(RenderbufferStorageMultisampleEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, GL.Enums.EXT_timer_query pname, [Out] Int64* @params);
        internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT = (GetQueryObjecti64vEXT)GL.GetDelegateForExtensionMethod("glGetQueryObjecti64vEXT", typeof(GetQueryObjecti64vEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, GL.Enums.EXT_timer_query pname, [Out] UInt64* @params);
        internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT = (GetQueryObjectui64vEXT)GL.GetDelegateForExtensionMethod("glGetQueryObjectui64vEXT", typeof(GetQueryObjectui64vEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, UInt32 index, Int32 count, Single* @params);
        internal unsafe static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT = (ProgramEnvParameters4fvEXT)GL.GetDelegateForExtensionMethod("glProgramEnvParameters4fvEXT", typeof(ProgramEnvParameters4fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, UInt32 index, Int32 count, Single* @params);
        internal unsafe static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT = (ProgramLocalParameters4fvEXT)GL.GetDelegateForExtensionMethod("glProgramLocalParameters4fvEXT", typeof(ProgramLocalParameters4fvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BufferParameteriAPPLE(GL.Enums.APPLE_flush_buffer_range target, GL.Enums.APPLE_flush_buffer_range pname, Int32 param);
        internal static BufferParameteriAPPLE glBufferParameteriAPPLE = (BufferParameteriAPPLE)GL.GetDelegateForExtensionMethod("glBufferParameteriAPPLE", typeof(BufferParameteriAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushMappedBufferRangeAPPLE(GL.Enums.APPLE_flush_buffer_range target, IntPtr offset, IntPtr size);
        internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE = (FlushMappedBufferRangeAPPLE)GL.GetDelegateForExtensionMethod("glFlushMappedBufferRangeAPPLE", typeof(FlushMappedBufferRangeAPPLE));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameterI4iNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV = (ProgramLocalParameterI4iNV)GL.GetDelegateForExtensionMethod("glProgramLocalParameterI4iNV", typeof(ProgramLocalParameterI4iNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameterI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32* @params);
        internal unsafe static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV = (ProgramLocalParameterI4ivNV)GL.GetDelegateForExtensionMethod("glProgramLocalParameterI4ivNV", typeof(ProgramLocalParameterI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParametersI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, Int32* @params);
        internal unsafe static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV = (ProgramLocalParametersI4ivNV)GL.GetDelegateForExtensionMethod("glProgramLocalParametersI4ivNV", typeof(ProgramLocalParametersI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameterI4uiNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV = (ProgramLocalParameterI4uiNV)GL.GetDelegateForExtensionMethod("glProgramLocalParameterI4uiNV", typeof(ProgramLocalParameterI4uiNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameterI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32* @params);
        internal unsafe static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV = (ProgramLocalParameterI4uivNV)GL.GetDelegateForExtensionMethod("glProgramLocalParameterI4uivNV", typeof(ProgramLocalParameterI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParametersI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, UInt32* @params);
        internal unsafe static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV = (ProgramLocalParametersI4uivNV)GL.GetDelegateForExtensionMethod("glProgramLocalParametersI4uivNV", typeof(ProgramLocalParametersI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameterI4iNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV = (ProgramEnvParameterI4iNV)GL.GetDelegateForExtensionMethod("glProgramEnvParameterI4iNV", typeof(ProgramEnvParameterI4iNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameterI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32* @params);
        internal unsafe static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV = (ProgramEnvParameterI4ivNV)GL.GetDelegateForExtensionMethod("glProgramEnvParameterI4ivNV", typeof(ProgramEnvParameterI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParametersI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, Int32* @params);
        internal unsafe static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV = (ProgramEnvParametersI4ivNV)GL.GetDelegateForExtensionMethod("glProgramEnvParametersI4ivNV", typeof(ProgramEnvParametersI4ivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameterI4uiNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV = (ProgramEnvParameterI4uiNV)GL.GetDelegateForExtensionMethod("glProgramEnvParameterI4uiNV", typeof(ProgramEnvParameterI4uiNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameterI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32* @params);
        internal unsafe static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV = (ProgramEnvParameterI4uivNV)GL.GetDelegateForExtensionMethod("glProgramEnvParameterI4uivNV", typeof(ProgramEnvParameterI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParametersI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, UInt32* @params);
        internal unsafe static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV = (ProgramEnvParametersI4uivNV)GL.GetDelegateForExtensionMethod("glProgramEnvParametersI4uivNV", typeof(ProgramEnvParametersI4uivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterIivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] Int32* @params);
        internal unsafe static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV = (GetProgramLocalParameterIivNV)GL.GetDelegateForExtensionMethod("glGetProgramLocalParameterIivNV", typeof(GetProgramLocalParameterIivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterIuivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] UInt32* @params);
        internal unsafe static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV = (GetProgramLocalParameterIuivNV)GL.GetDelegateForExtensionMethod("glGetProgramLocalParameterIuivNV", typeof(GetProgramLocalParameterIuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterIivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] Int32* @params);
        internal unsafe static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV = (GetProgramEnvParameterIivNV)GL.GetDelegateForExtensionMethod("glGetProgramEnvParameterIivNV", typeof(GetProgramEnvParameterIivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterIuivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] UInt32* @params);
        internal unsafe static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV = (GetProgramEnvParameterIuivNV)GL.GetDelegateForExtensionMethod("glGetProgramEnvParameterIuivNV", typeof(GetProgramEnvParameterIuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramVertexLimitNV(GL.Enums.NV_geometry_program4 target, Int32 limit);
        internal static ProgramVertexLimitNV glProgramVertexLimitNV = (ProgramVertexLimitNV)GL.GetDelegateForExtensionMethod("glProgramVertexLimitNV", typeof(ProgramVertexLimitNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, UInt32 texture, Int32 level);
        internal static FramebufferTextureEXT glFramebufferTextureEXT = (FramebufferTextureEXT)GL.GetDelegateForExtensionMethod("glFramebufferTextureEXT", typeof(FramebufferTextureEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureLayerEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, UInt32 texture, Int32 level, Int32 layer);
        internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT = (FramebufferTextureLayerEXT)GL.GetDelegateForExtensionMethod("glFramebufferTextureLayerEXT", typeof(FramebufferTextureLayerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureFaceEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, UInt32 texture, Int32 level, GL.Enums.TextureTarget face);
        internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT = (FramebufferTextureFaceEXT)GL.GetDelegateForExtensionMethod("glFramebufferTextureFaceEXT", typeof(FramebufferTextureFaceEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameteriEXT(UInt32 program, GL.Enums.EXT_geometry_shader4 pname, Int32 value);
        internal static ProgramParameteriEXT glProgramParameteriEXT = (ProgramParameteriEXT)GL.GetDelegateForExtensionMethod("glProgramParameteriEXT", typeof(ProgramParameteriEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1iEXT(UInt32 index, Int32 x);
        internal static VertexAttribI1iEXT glVertexAttribI1iEXT = (VertexAttribI1iEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI1iEXT", typeof(VertexAttribI1iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
        internal static VertexAttribI2iEXT glVertexAttribI2iEXT = (VertexAttribI2iEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI2iEXT", typeof(VertexAttribI2iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
        internal static VertexAttribI3iEXT glVertexAttribI3iEXT = (VertexAttribI3iEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI3iEXT", typeof(VertexAttribI3iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
        internal static VertexAttribI4iEXT glVertexAttribI4iEXT = (VertexAttribI4iEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4iEXT", typeof(VertexAttribI4iEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
        internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT = (VertexAttribI1uiEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI1uiEXT", typeof(VertexAttribI1uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
        internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT = (VertexAttribI2uiEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI2uiEXT", typeof(VertexAttribI2uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
        internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT = (VertexAttribI3uiEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI3uiEXT", typeof(VertexAttribI3uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
        internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT = (VertexAttribI4uiEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4uiEXT", typeof(VertexAttribI4uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI1ivEXT glVertexAttribI1ivEXT = (VertexAttribI1ivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI1ivEXT", typeof(VertexAttribI1ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI2ivEXT glVertexAttribI2ivEXT = (VertexAttribI2ivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI2ivEXT", typeof(VertexAttribI2ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI3ivEXT glVertexAttribI3ivEXT = (VertexAttribI3ivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI3ivEXT", typeof(VertexAttribI3ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ivEXT(UInt32 index, Int32* v);
        internal unsafe static VertexAttribI4ivEXT glVertexAttribI4ivEXT = (VertexAttribI4ivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4ivEXT", typeof(VertexAttribI4ivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI1uivEXT glVertexAttribI1uivEXT = (VertexAttribI1uivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI1uivEXT", typeof(VertexAttribI1uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI2uivEXT glVertexAttribI2uivEXT = (VertexAttribI2uivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI2uivEXT", typeof(VertexAttribI2uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI3uivEXT glVertexAttribI3uivEXT = (VertexAttribI3uivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI3uivEXT", typeof(VertexAttribI3uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
        internal unsafe static VertexAttribI4uivEXT glVertexAttribI4uivEXT = (VertexAttribI4uivEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4uivEXT", typeof(VertexAttribI4uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4bvEXT(UInt32 index, SByte* v);
        internal unsafe static VertexAttribI4bvEXT glVertexAttribI4bvEXT = (VertexAttribI4bvEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4bvEXT", typeof(VertexAttribI4bvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4svEXT(UInt32 index, Int16* v);
        internal unsafe static VertexAttribI4svEXT glVertexAttribI4svEXT = (VertexAttribI4svEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4svEXT", typeof(VertexAttribI4svEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
        internal unsafe static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT = (VertexAttribI4ubvEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4ubvEXT", typeof(VertexAttribI4ubvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
        internal unsafe static VertexAttribI4usvEXT glVertexAttribI4usvEXT = (VertexAttribI4usvEXT)GL.GetDelegateForExtensionMethod("glVertexAttribI4usvEXT", typeof(VertexAttribI4usvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribIPointerEXT(UInt32 index, Int32 size, GL.Enums.NV_vertex_program4 type, Int32 stride, void* pointer);
        internal unsafe static VertexAttribIPointerEXT glVertexAttribIPointerEXT = (VertexAttribIPointerEXT)GL.GetDelegateForExtensionMethod("glVertexAttribIPointerEXT", typeof(VertexAttribIPointerEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIivEXT(UInt32 index, GL.Enums.NV_vertex_program4 pname, [Out] Int32* @params);
        internal unsafe static GetVertexAttribIivEXT glGetVertexAttribIivEXT = (GetVertexAttribIivEXT)GL.GetDelegateForExtensionMethod("glGetVertexAttribIivEXT", typeof(GetVertexAttribIivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIuivEXT(UInt32 index, GL.Enums.NV_vertex_program4 pname, [Out] UInt32* @params);
        internal unsafe static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT = (GetVertexAttribIuivEXT)GL.GetDelegateForExtensionMethod("glGetVertexAttribIuivEXT", typeof(GetVertexAttribIuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformuivEXT(UInt32 program, Int32 location, [Out] UInt32* @params);
        internal unsafe static GetUniformuivEXT glGetUniformuivEXT = (GetUniformuivEXT)GL.GetDelegateForExtensionMethod("glGetUniformuivEXT", typeof(GetUniformuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragDataLocationEXT(UInt32 program, UInt32 color, System.String name);
        internal static BindFragDataLocationEXT glBindFragDataLocationEXT = (BindFragDataLocationEXT)GL.GetDelegateForExtensionMethod("glBindFragDataLocationEXT", typeof(BindFragDataLocationEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetFragDataLocationEXT(UInt32 program, System.String name);
        internal static GetFragDataLocationEXT glGetFragDataLocationEXT = (GetFragDataLocationEXT)GL.GetDelegateForExtensionMethod("glGetFragDataLocationEXT", typeof(GetFragDataLocationEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1uiEXT(Int32 location, UInt32 v0);
        internal static Uniform1uiEXT glUniform1uiEXT = (Uniform1uiEXT)GL.GetDelegateForExtensionMethod("glUniform1uiEXT", typeof(Uniform1uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
        internal static Uniform2uiEXT glUniform2uiEXT = (Uniform2uiEXT)GL.GetDelegateForExtensionMethod("glUniform2uiEXT", typeof(Uniform2uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
        internal static Uniform3uiEXT glUniform3uiEXT = (Uniform3uiEXT)GL.GetDelegateForExtensionMethod("glUniform3uiEXT", typeof(Uniform3uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
        internal static Uniform4uiEXT glUniform4uiEXT = (Uniform4uiEXT)GL.GetDelegateForExtensionMethod("glUniform4uiEXT", typeof(Uniform4uiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform1uivEXT glUniform1uivEXT = (Uniform1uivEXT)GL.GetDelegateForExtensionMethod("glUniform1uivEXT", typeof(Uniform1uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform2uivEXT glUniform2uivEXT = (Uniform2uivEXT)GL.GetDelegateForExtensionMethod("glUniform2uivEXT", typeof(Uniform2uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform3uivEXT glUniform3uivEXT = (Uniform3uivEXT)GL.GetDelegateForExtensionMethod("glUniform3uivEXT", typeof(Uniform3uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
        internal unsafe static Uniform4uivEXT glUniform4uivEXT = (Uniform4uivEXT)GL.GetDelegateForExtensionMethod("glUniform4uivEXT", typeof(Uniform4uivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysInstancedEXT(GL.Enums.BeginMode mode, Int32 start, Int32 count, Int32 primcount);
        internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT = (DrawArraysInstancedEXT)GL.GetDelegateForExtensionMethod("glDrawArraysInstancedEXT", typeof(DrawArraysInstancedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawElementsInstancedEXT(GL.Enums.BeginMode mode, Int32 count, GL.Enums.EXT_draw_instanced type, void* indices, Int32 primcount);
        internal unsafe static DrawElementsInstancedEXT glDrawElementsInstancedEXT = (DrawElementsInstancedEXT)GL.GetDelegateForExtensionMethod("glDrawElementsInstancedEXT", typeof(DrawElementsInstancedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexBufferEXT(GL.Enums.TextureTarget target, GL.Enums.EXT_texture_buffer_object internalformat, UInt32 buffer);
        internal static TexBufferEXT glTexBufferEXT = (TexBufferEXT)GL.GetDelegateForExtensionMethod("glTexBufferEXT", typeof(TexBufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRangedNV(Double zNear, Double zFar);
        internal static DepthRangedNV glDepthRangedNV = (DepthRangedNV)GL.GetDelegateForExtensionMethod("glDepthRangedNV", typeof(DepthRangedNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepthdNV(Double depth);
        internal static ClearDepthdNV glClearDepthdNV = (ClearDepthdNV)GL.GetDelegateForExtensionMethod("glClearDepthdNV", typeof(ClearDepthdNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthBoundsdNV(Double zmin, Double zmax);
        internal static DepthBoundsdNV glDepthBoundsdNV = (DepthBoundsdNV)GL.GetDelegateForExtensionMethod("glDepthBoundsdNV", typeof(DepthBoundsdNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampleCoverageNV(GL.Enums.NV_framebuffer_multisample_coverage target, Int32 coverageSamples, Int32 colorSamples, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height);
        internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV = (RenderbufferStorageMultisampleCoverageNV)GL.GetDelegateForExtensionMethod("glRenderbufferStorageMultisampleCoverageNV", typeof(RenderbufferStorageMultisampleCoverageNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersfvNV(GL.Enums.NV_parameter_buffer_object target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
        internal unsafe static ProgramBufferParametersfvNV glProgramBufferParametersfvNV = (ProgramBufferParametersfvNV)GL.GetDelegateForExtensionMethod("glProgramBufferParametersfvNV", typeof(ProgramBufferParametersfvNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersIivNV(GL.Enums.NV_parameter_buffer_object target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
        internal unsafe static ProgramBufferParametersIivNV glProgramBufferParametersIivNV = (ProgramBufferParametersIivNV)GL.GetDelegateForExtensionMethod("glProgramBufferParametersIivNV", typeof(ProgramBufferParametersIivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersIuivNV(GL.Enums.NV_parameter_buffer_object target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
        internal unsafe static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV = (ProgramBufferParametersIuivNV)GL.GetDelegateForExtensionMethod("glProgramBufferParametersIuivNV", typeof(ProgramBufferParametersIuivNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaskIndexedEXT(UInt32 index, GL.Enums.Boolean r, GL.Enums.Boolean g, GL.Enums.Boolean b, GL.Enums.Boolean a);
        internal static ColorMaskIndexedEXT glColorMaskIndexedEXT = (ColorMaskIndexedEXT)GL.GetDelegateForExtensionMethod("glColorMaskIndexedEXT", typeof(ColorMaskIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanIndexedvEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index, [Out] GL.Enums.Boolean* data);
        internal unsafe static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT = (GetBooleanIndexedvEXT)GL.GetDelegateForExtensionMethod("glGetBooleanIndexedvEXT", typeof(GetBooleanIndexedvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerIndexedvEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index, [Out] Int32* data);
        internal unsafe static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT = (GetIntegerIndexedvEXT)GL.GetDelegateForExtensionMethod("glGetIntegerIndexedvEXT", typeof(GetIntegerIndexedvEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableIndexedEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index);
        internal static EnableIndexedEXT glEnableIndexedEXT = (EnableIndexedEXT)GL.GetDelegateForExtensionMethod("glEnableIndexedEXT", typeof(EnableIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableIndexedEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index);
        internal static DisableIndexedEXT glDisableIndexedEXT = (DisableIndexedEXT)GL.GetDelegateForExtensionMethod("glDisableIndexedEXT", typeof(DisableIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Boolean IsEnabledIndexedEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index);
        internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT = (IsEnabledIndexedEXT)GL.GetDelegateForExtensionMethod("glIsEnabledIndexedEXT", typeof(IsEnabledIndexedEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginTransformFeedbackNV(GL.Enums.NV_transform_feedback primitiveMode);
        internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV = (BeginTransformFeedbackNV)GL.GetDelegateForExtensionMethod("glBeginTransformFeedbackNV", typeof(BeginTransformFeedbackNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndTransformFeedbackNV();
        internal static EndTransformFeedbackNV glEndTransformFeedbackNV = (EndTransformFeedbackNV)GL.GetDelegateForExtensionMethod("glEndTransformFeedbackNV", typeof(EndTransformFeedbackNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, GL.Enums.NV_transform_feedback bufferMode);
        internal unsafe static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV = (TransformFeedbackAttribsNV)GL.GetDelegateForExtensionMethod("glTransformFeedbackAttribsNV", typeof(TransformFeedbackAttribsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferRangeNV(GL.Enums.NV_transform_feedback target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
        internal static BindBufferRangeNV glBindBufferRangeNV = (BindBufferRangeNV)GL.GetDelegateForExtensionMethod("glBindBufferRangeNV", typeof(BindBufferRangeNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferOffsetNV(GL.Enums.NV_transform_feedback target, UInt32 index, UInt32 buffer, IntPtr offset);
        internal static BindBufferOffsetNV glBindBufferOffsetNV = (BindBufferOffsetNV)GL.GetDelegateForExtensionMethod("glBindBufferOffsetNV", typeof(BindBufferOffsetNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferBaseNV(GL.Enums.NV_transform_feedback target, UInt32 index, UInt32 buffer);
        internal static BindBufferBaseNV glBindBufferBaseNV = (BindBufferBaseNV)GL.GetDelegateForExtensionMethod("glBindBufferBaseNV", typeof(BindBufferBaseNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, GL.Enums.NV_transform_feedback bufferMode);
        internal unsafe static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV = (TransformFeedbackVaryingsNV)GL.GetDelegateForExtensionMethod("glTransformFeedbackVaryingsNV", typeof(TransformFeedbackVaryingsNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveVaryingNV(UInt32 program, System.String name);
        internal static ActiveVaryingNV glActiveVaryingNV = (ActiveVaryingNV)GL.GetDelegateForExtensionMethod("glActiveVaryingNV", typeof(ActiveVaryingNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetVaryingLocationNV(UInt32 program, System.String name);
        internal static GetVaryingLocationNV glGetVaryingLocationNV = (GetVaryingLocationNV)GL.GetDelegateForExtensionMethod("glGetVaryingLocationNV", typeof(GetVaryingLocationNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.NV_transform_feedback* type, [Out] System.Text.StringBuilder name);
        internal unsafe static GetActiveVaryingNV glGetActiveVaryingNV = (GetActiveVaryingNV)GL.GetDelegateForExtensionMethod("glGetActiveVaryingNV", typeof(GetActiveVaryingNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [Out] Int32* location);
        internal unsafe static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV = (GetTransformFeedbackVaryingNV)GL.GetDelegateForExtensionMethod("glGetTransformFeedbackVaryingNV", typeof(GetTransformFeedbackVaryingNV));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
        internal static UniformBufferEXT glUniformBufferEXT = (UniformBufferEXT)GL.GetDelegateForExtensionMethod("glUniformBufferEXT", typeof(UniformBufferEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
        internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT = (GetUniformBufferSizeEXT)GL.GetDelegateForExtensionMethod("glGetUniformBufferSizeEXT", typeof(GetUniformBufferSizeEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
        internal static GetUniformOffsetEXT glGetUniformOffsetEXT = (GetUniformOffsetEXT)GL.GetDelegateForExtensionMethod("glGetUniformOffsetEXT", typeof(GetUniformOffsetEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Int32* @params);
        internal unsafe static TexParameterIivEXT glTexParameterIivEXT = (TexParameterIivEXT)GL.GetDelegateForExtensionMethod("glTexParameterIivEXT", typeof(TexParameterIivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, UInt32* @params);
        internal unsafe static TexParameterIuivEXT glTexParameterIuivEXT = (TexParameterIuivEXT)GL.GetDelegateForExtensionMethod("glTexParameterIuivEXT", typeof(TexParameterIuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] Int32* @params);
        internal unsafe static GetTexParameterIivEXT glGetTexParameterIivEXT = (GetTexParameterIivEXT)GL.GetDelegateForExtensionMethod("glGetTexParameterIivEXT", typeof(GetTexParameterIivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] UInt32* @params);
        internal unsafe static GetTexParameterIuivEXT glGetTexParameterIuivEXT = (GetTexParameterIuivEXT)GL.GetDelegateForExtensionMethod("glGetTexParameterIuivEXT", typeof(GetTexParameterIuivEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
        internal static ClearColorIiEXT glClearColorIiEXT = (ClearColorIiEXT)GL.GetDelegateForExtensionMethod("glClearColorIiEXT", typeof(ClearColorIiEXT));
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
        internal static ClearColorIuiEXT glClearColorIuiEXT = (ClearColorIuiEXT)GL.GetDelegateForExtensionMethod("glClearColorIuiEXT", typeof(ClearColorIuiEXT));
    }
}
