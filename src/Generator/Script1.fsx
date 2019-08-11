open System.Text.RegularExpressions
let regex = new Regex("<param.*?>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>)<\/param>")

let inputText = """
<command>
    <proto>void <name>glVariantubvEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>id</name></param>
    <param len="COMPSIZE(id)">const <ptype>GLubyte</ptype> *<name>addr</name></param>
</command>
<command>
    <proto>void <name>glVariantuivEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>id</name></param>
    <param len="COMPSIZE(id)">const <ptype>GLuint</ptype> *<name>addr</name></param>
</command>
<command>
    <proto>void <name>glVariantusvEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>id</name></param>
    <param len="COMPSIZE(id)">const <ptype>GLushort</ptype> *<name>addr</name></param>
</command>
<command>
    <proto>void <name>glVertex2bOES</name></proto>
    <param><ptype>GLbyte</ptype> <name>x</name></param>
    <param><ptype>GLbyte</ptype> <name>y</name></param>
</command>
<command>
    <proto>void <name>glVertex2bvOES</name></proto>
    <param len="2">const <ptype>GLbyte</ptype> *<name>coords</name></param>
</command>
<command>
    <proto>void <name>glVertex2d</name></proto>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>x</name></param>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>y</name></param>
    <vecequiv name="glVertex2dv"/>
</command>
<command>
    <proto>void <name>glVertex2dv</name></proto>
    <param group="CoordD" len="2">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <glx type="render" opcode="65"/>
</command>
<command>
    <proto>void <name>glVertex2f</name></proto>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>x</name></param>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>y</name></param>
    <vecequiv name="glVertex2fv"/>
</command>
<command>
    <proto>void <name>glVertex2fv</name></proto>
    <param group="CoordF" len="2">const <ptype>GLfloat</ptype> *<name>v</name></param>
    <glx type="render" opcode="66"/>
</command>
<command>
    <proto>void <name>glVertex2hNV</name></proto>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>x</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>y</name></param>
    <vecequiv name="glVertex2hvNV"/>
</command>
<command>
    <proto>void <name>glVertex2hvNV</name></proto>
    <param group="Half16NV" len="2">const <ptype>GLhalfNV</ptype> *<name>v</name></param>
    <glx type="render" opcode="4240"/>
</command>
<command>
    <proto>void <name>glVertex2i</name></proto>
    <param group="CoordI"><ptype>GLint</ptype> <name>x</name></param>
    <param group="CoordI"><ptype>GLint</ptype> <name>y</name></param>
    <vecequiv name="glVertex2iv"/>
</command>
<command>
    <proto>void <name>glVertex2iv</name></proto>
    <param group="CoordI" len="2">const <ptype>GLint</ptype> *<name>v</name></param>
    <glx type="render" opcode="67"/>
</command>
<command>
    <proto>void <name>glVertex2s</name></proto>
    <param group="CoordS"><ptype>GLshort</ptype> <name>x</name></param>
    <param group="CoordS"><ptype>GLshort</ptype> <name>y</name></param>
    <vecequiv name="glVertex2sv"/>
</command>
<command>
    <proto>void <name>glVertex2sv</name></proto>
    <param group="CoordS" len="2">const <ptype>GLshort</ptype> *<name>v</name></param>
    <glx type="render" opcode="68"/>
</command>
<command>
    <proto>void <name>glVertex2xOES</name></proto>
    <param><ptype>GLfixed</ptype> <name>x</name></param>
</command>
<command>
    <proto>void <name>glVertex2xvOES</name></proto>
    <param len="2">const <ptype>GLfixed</ptype> *<name>coords</name></param>
</command>
<command>
    <proto>void <name>glVertex3bOES</name></proto>
    <param><ptype>GLbyte</ptype> <name>x</name></param>
    <param><ptype>GLbyte</ptype> <name>y</name></param>
    <param><ptype>GLbyte</ptype> <name>z</name></param>
</command>
<command>
    <proto>void <name>glVertex3bvOES</name></proto>
    <param len="3">const <ptype>GLbyte</ptype> *<name>coords</name></param>
</command>
<command>
    <proto>void <name>glVertex3d</name></proto>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>x</name></param>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>y</name></param>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>z</name></param>
    <vecequiv name="glVertex3dv"/>
</command>
<command>
    <proto>void <name>glVertex3dv</name></proto>
    <param group="CoordD" len="3">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <glx type="render" opcode="69"/>
</command>
<command>
    <proto>void <name>glVertex3f</name></proto>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>x</name></param>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>y</name></param>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>z</name></param>
    <vecequiv name="glVertex3fv"/>
</command>
<command>
    <proto>void <name>glVertex3fv</name></proto>
    <param group="CoordF" len="3">const <ptype>GLfloat</ptype> *<name>v</name></param>
    <glx type="render" opcode="70"/>
</command>
<command>
    <proto>void <name>glVertex3hNV</name></proto>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>x</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>y</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>z</name></param>
    <vecequiv name="glVertex3hvNV"/>
</command>
<command>
    <proto>void <name>glVertex3hvNV</name></proto>
    <param group="Half16NV" len="3">const <ptype>GLhalfNV</ptype> *<name>v</name></param>
    <glx type="render" opcode="4241"/>
</command>
<command>
    <proto>void <name>glVertex3i</name></proto>
    <param group="CoordI"><ptype>GLint</ptype> <name>x</name></param>
    <param group="CoordI"><ptype>GLint</ptype> <name>y</name></param>
    <param group="CoordI"><ptype>GLint</ptype> <name>z</name></param>
    <vecequiv name="glVertex3iv"/>
</command>
<command>
    <proto>void <name>glVertex3iv</name></proto>
    <param group="CoordI" len="3">const <ptype>GLint</ptype> *<name>v</name></param>
    <glx type="render" opcode="71"/>
</command>
<command>
    <proto>void <name>glVertex3s</name></proto>
    <param group="CoordS"><ptype>GLshort</ptype> <name>x</name></param>
    <param group="CoordS"><ptype>GLshort</ptype> <name>y</name></param>
    <param group="CoordS"><ptype>GLshort</ptype> <name>z</name></param>
    <vecequiv name="glVertex3sv"/>
</command>
<command>
    <proto>void <name>glVertex3sv</name></proto>
    <param group="CoordS" len="3">const <ptype>GLshort</ptype> *<name>v</name></param>
    <glx type="render" opcode="72"/>
</command>
<command>
    <proto>void <name>glVertex3xOES</name></proto>
    <param><ptype>GLfixed</ptype> <name>x</name></param>
    <param><ptype>GLfixed</ptype> <name>y</name></param>
</command>
<command>
    <proto>void <name>glVertex3xvOES</name></proto>
    <param len="3">const <ptype>GLfixed</ptype> *<name>coords</name></param>
</command>
<command>
    <proto>void <name>glVertex4bOES</name></proto>
    <param><ptype>GLbyte</ptype> <name>x</name></param>
    <param><ptype>GLbyte</ptype> <name>y</name></param>
    <param><ptype>GLbyte</ptype> <name>z</name></param>
    <param><ptype>GLbyte</ptype> <name>w</name></param>
</command>
<command>
    <proto>void <name>glVertex4bvOES</name></proto>
    <param len="4">const <ptype>GLbyte</ptype> *<name>coords</name></param>
</command>
<command>
    <proto>void <name>glVertex4d</name></proto>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>x</name></param>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>y</name></param>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>z</name></param>
    <param group="CoordD"><ptype>GLdouble</ptype> <name>w</name></param>
    <vecequiv name="glVertex4dv"/>
</command>
<command>
    <proto>void <name>glVertex4dv</name></proto>
    <param group="CoordD" len="4">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <glx type="render" opcode="73"/>
</command>
<command>
    <proto>void <name>glVertex4f</name></proto>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>x</name></param>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>y</name></param>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>z</name></param>
    <param group="CoordF"><ptype>GLfloat</ptype> <name>w</name></param>
    <vecequiv name="glVertex4fv"/>
</command>
<command>
    <proto>void <name>glVertex4fv</name></proto>
    <param group="CoordF" len="4">const <ptype>GLfloat</ptype> *<name>v</name></param>
    <glx type="render" opcode="74"/>
</command>
<command>
    <proto>void <name>glVertex4hNV</name></proto>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>x</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>y</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>z</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>w</name></param>
    <vecequiv name="glVertex4hvNV"/>
</command>
<command>
    <proto>void <name>glVertex4hvNV</name></proto>
    <param group="Half16NV" len="4">const <ptype>GLhalfNV</ptype> *<name>v</name></param>
    <glx type="render" opcode="4242"/>
</command>
<command>
    <proto>void <name>glVertex4i</name></proto>
    <param group="CoordI"><ptype>GLint</ptype> <name>x</name></param>
    <param group="CoordI"><ptype>GLint</ptype> <name>y</name></param>
    <param group="CoordI"><ptype>GLint</ptype> <name>z</name></param>
    <param group="CoordI"><ptype>GLint</ptype> <name>w</name></param>
    <vecequiv name="glVertex4iv"/>
</command>
<command>
    <proto>void <name>glVertex4iv</name></proto>
    <param group="CoordI" len="4">const <ptype>GLint</ptype> *<name>v</name></param>
    <glx type="render" opcode="75"/>
</command>
<command>
    <proto>void <name>glVertex4s</name></proto>
    <param group="CoordS"><ptype>GLshort</ptype> <name>x</name></param>
    <param group="CoordS"><ptype>GLshort</ptype> <name>y</name></param>
    <param group="CoordS"><ptype>GLshort</ptype> <name>z</name></param>
    <param group="CoordS"><ptype>GLshort</ptype> <name>w</name></param>
    <vecequiv name="glVertex4sv"/>
</command>
<command>
    <proto>void <name>glVertex4sv</name></proto>
    <param group="CoordS" len="4">const <ptype>GLshort</ptype> *<name>v</name></param>
    <glx type="render" opcode="76"/>
</command>
<command>
    <proto>void <name>glVertex4xOES</name></proto>
    <param><ptype>GLfixed</ptype> <name>x</name></param>
    <param><ptype>GLfixed</ptype> <name>y</name></param>
    <param><ptype>GLfixed</ptype> <name>z</name></param>
</command>
<command>
    <proto>void <name>glVertex4xvOES</name></proto>
    <param len="4">const <ptype>GLfixed</ptype> *<name>coords</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayAttribBinding</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLuint</ptype> <name>bindingindex</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayAttribFormat</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLboolean</ptype> <name>normalized</name></param>
    <param><ptype>GLuint</ptype> <name>relativeoffset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayAttribIFormat</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribIType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLuint</ptype> <name>relativeoffset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayAttribLFormat</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribLType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLuint</ptype> <name>relativeoffset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayBindVertexBufferEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>bindingindex</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param group="BufferOffset"><ptype>GLintptr</ptype> <name>offset</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayBindingDivisor</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>bindingindex</name></param>
    <param><ptype>GLuint</ptype> <name>divisor</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayColorOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="ColorPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayEdgeFlagOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayElementBuffer</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayFogCoordOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param group="FogCoordinatePointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayIndexOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param group="IndexPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayMultiTexCoordOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLenum</ptype> <name>texunit</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="TexCoordPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayNormalOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param group="NormalPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayParameteriAPPLE</name></proto>
    <param group="VertexArrayPNameAPPLE"><ptype>GLenum</ptype> <name>pname</name></param>
    <param><ptype>GLint</ptype> <name>param</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayRangeAPPLE</name></proto>
    <param><ptype>GLsizei</ptype> <name>length</name></param>
    <param len="length">void *<name>pointer</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayRangeNV</name></proto>
    <param><ptype>GLsizei</ptype> <name>length</name></param>
    <param len="COMPSIZE(length)">const void *<name>pointer</name></param>
</command>
<command>
    <proto>void <name>glVertexArraySecondaryColorOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="ColorPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayTexCoordOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="TexCoordPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribBindingEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLuint</ptype> <name>bindingindex</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribDivisorEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLuint</ptype> <name>divisor</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribFormatEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribType"><ptype>GLenum</ptype> <name>type</name></param>
    <param group="Boolean"><ptype>GLboolean</ptype> <name>normalized</name></param>
    <param><ptype>GLuint</ptype> <name>relativeoffset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribIFormatEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribIType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLuint</ptype> <name>relativeoffset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribIOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribLFormatEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>attribindex</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribLType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLuint</ptype> <name>relativeoffset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribLOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribLType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param group="BufferOffset"><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexAttribOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexAttribPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLboolean</ptype> <name>normalized</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexBindingDivisorEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>bindingindex</name></param>
    <param><ptype>GLuint</ptype> <name>divisor</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexBuffer</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>bindingindex</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexBuffers</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>first</name></param>
    <param><ptype>GLsizei</ptype> <name>count</name></param>
    <param>const <ptype>GLuint</ptype> *<name>buffers</name></param>
    <param>const <ptype>GLintptr</ptype> *<name>offsets</name></param>
    <param>const <ptype>GLsizei</ptype> *<name>strides</name></param>
</command>
<command>
    <proto>void <name>glVertexArrayVertexOffsetEXT</name></proto>
    <param><ptype>GLuint</ptype> <name>vaobj</name></param>
    <param><ptype>GLuint</ptype> <name>buffer</name></param>
    <param><ptype>GLint</ptype> <name>size</name></param>
    <param group="VertexPointerType"><ptype>GLenum</ptype> <name>type</name></param>
    <param><ptype>GLsizei</ptype> <name>stride</name></param>
    <param><ptype>GLintptr</ptype> <name>offset</name></param>
</command>
<command>
    <proto>void <name>glVertexAttrib1d</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLdouble</ptype> <name>x</name></param>
    <vecequiv name="glVertexAttrib1dv"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1dARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLdouble</ptype> <name>x</name></param>
    <alias name="glVertexAttrib1d"/>
    <vecequiv name="glVertexAttrib1dvARB"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1dNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLdouble</ptype> <name>x</name></param>
    <alias name="glVertexAttrib1d"/>
    <vecequiv name="glVertexAttrib1dvNV"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1dv</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <glx type="render" opcode="4197"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1dvARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib1dv"/>
    <glx type="render" opcode="4197"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1dvNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib1dv"/>
    <glx type="render" opcode="4197"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1f</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLfloat</ptype> <name>x</name></param>
    <vecequiv name="glVertexAttrib1fv"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1fARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLfloat</ptype> <name>x</name></param>
    <alias name="glVertexAttrib1f"/>
    <vecequiv name="glVertexAttrib1fvARB"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1fNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLfloat</ptype> <name>x</name></param>
    <alias name="glVertexAttrib1f"/>
    <vecequiv name="glVertexAttrib1fvNV"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1fv</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLfloat</ptype> *<name>v</name></param>
    <glx type="render" opcode="4193"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1fvARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLfloat</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib1fv"/>
    <glx type="render" opcode="4193"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1fvNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLfloat</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib1fv"/>
    <glx type="render" opcode="4193"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1hNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param group="Half16NV"><ptype>GLhalfNV</ptype> <name>x</name></param>
    <vecequiv name="glVertexAttrib1hvNV"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1hvNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param group="Half16NV" len="1">const <ptype>GLhalfNV</ptype> *<name>v</name></param>
    <glx type="render" opcode="4257"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1s</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLshort</ptype> <name>x</name></param>
    <vecequiv name="glVertexAttrib1sv"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1sARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLshort</ptype> <name>x</name></param>
    <alias name="glVertexAttrib1s"/>
    <vecequiv name="glVertexAttrib1svARB"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1sNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLshort</ptype> <name>x</name></param>
    <alias name="glVertexAttrib1s"/>
    <vecequiv name="glVertexAttrib1svNV"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1sv</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLshort</ptype> *<name>v</name></param>
    <glx type="render" opcode="4189"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1svARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLshort</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib1sv"/>
    <glx type="render" opcode="4189"/>
</command>
<command>
    <proto>void <name>glVertexAttrib1svNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="1">const <ptype>GLshort</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib1sv"/>
    <glx type="render" opcode="4189"/>
</command>
<command>
    <proto>void <name>glVertexAttrib2d</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLdouble</ptype> <name>x</name></param>
    <param><ptype>GLdouble</ptype> <name>y</name></param>
    <vecequiv name="glVertexAttrib2dv"/>
</command>
<command>
    <proto>void <name>glVertexAttrib2dARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLdouble</ptype> <name>x</name></param>
    <param><ptype>GLdouble</ptype> <name>y</name></param>
    <alias name="glVertexAttrib2d"/>
    <vecequiv name="glVertexAttrib2dvARB"/>
</command>
<command>
    <proto>void <name>glVertexAttrib2dNV</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param><ptype>GLdouble</ptype> <name>x</name></param>
    <param><ptype>GLdouble</ptype> <name>y</name></param>
    <alias name="glVertexAttrib2d"/>
    <vecequiv name="glVertexAttrib2dvNV"/>
</command>
<command>
    <proto>void <name>glVertexAttrib2dv</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="2">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <glx type="render" opcode="4198"/>
</command>
<command>
    <proto>void <name>glVertexAttrib2dvARB</name></proto>
    <param><ptype>GLuint</ptype> <name>index</name></param>
    <param len="2">const <ptype>GLdouble</ptype> *<name>v</name></param>
    <alias name="glVertexAttrib2dv"/>
    <glx type="render" opcode="4198"/>
</command>
<command>
    <proto>void <name>glVertexAttrib2dvNV</name></proto>"""

let test =
    inputText
    |> regex.Matches

for res in test do
    //let v1 = res.Groups.["f"].Value
    let v2 = res.Groups.["t"].Value
    let v3 = res.Groups.["b"].Value
    let v = v2 + v3
    printfn "%s" v
