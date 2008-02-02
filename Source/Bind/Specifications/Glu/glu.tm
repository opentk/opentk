#GLUnurbs        GLUnurbs
#GLUTesselator   GLUTesselator
#GLUquadric      GLUquadric

# Unknown types (try to infer!)
NurbsObj        IntPtr		# Nurbs
QuadricObj      IntPtr		# Quadric
TesselatorObj   IntPtr		# Tesselator
FunctionPointer Delegate #IntPtr

VoidPointer     GLvoid*		# VoidPointer
Float64         Float64
Float64Pointer  Float64Pointer
Float32         Float32
Float32Pointer  Float32Pointer
SizeI		    GLsizei
Sizei		    GLsizei
UInt8           GLubyte
Uint8           GLubyte

# Enum types (find Tao-compatible solution!)
TextureTarget   TextureTarget
PixelFormat     PixelFormat
PixelType       PixelType
MapTarget       MapTarget
Boolean			GLboolean

SGIS_texture_filter4 SgisTextureFilter4