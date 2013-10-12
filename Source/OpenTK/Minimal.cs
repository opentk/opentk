using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

#if IPHONE || ANDROID || MINIMAL

namespace OpenTK
{
    // Override a number of System.* classes when compiling for
    // minimal targets (e.g. MonoTouch).
    // Note: the "overriden" classes must not be fully qualified for this to work!

    // System.Diagnostics.Debug
    static class Debug
    {
        public static void Write(string message) { }
        public static void Write(object obj) { }
        public static void WriteLine(string message) { }
        public static void WriteLine(object obj) { }
        public static void Print(string message) { }
        public static void Print(string format, params object[] args) { }
        public static void Indent() { }
        public static void Unindent() { }
        public static void Flush() { }
    }

    // System.Diagnostics.Trace
    static class Trace
    {
        public static void Write(string message) { }
        public static void Write(object obj) { }
        public static void WriteLine(string message) { }
        public static void WriteLine(object obj) { }
        public static void Indent() { }
        public static void Unindent() { }
        public static void Flush() { }
    }

    // System.Diagnostics.Stopwatch
    sealed class Stopwatch
    {
        DateTime start, stop;
        bool running;

        public void Reset()
        {
            start = stop = DateTime.MinValue;
            running = false;
        }

        public void Start()
        {
            start = DateTime.Now;
            running = true;
        }

        public void Stop()
        {
            stop = DateTime.Now;
            running = false;
        }

        public TimeSpan Elapsed
        {
            get
            {
                if (running)
                    return TimeSpan.FromTicks(DateTime.Now.Ticks - start.Ticks);
                else
                    return TimeSpan.FromTicks(stop.Ticks - start.Ticks);
            }
        }
    }

    // System.Xml.XmlIgnoreAttribute
    class XmlIgnoreAttribute : Attribute
    {
    }

    // System.ComponentModel.EditorBrowrableAttribute
    class EditorBrowsableAttribute : Attribute
    {
        public EditorBrowsableAttribute(EditorBrowsableState state) { }
    }

    // System.ComponentModel.EditorBrowsableState
    enum EditorBrowsableState
    {
        Always = 0,
        Never = 1,
        Advanced = 2,
    }

    #region RegistryKey

    class RegistryKey
    {
        public RegistryKey OpenSubKey(string name)
        {
            return new RegistryKey();
        }

        public object GetValue(string name)
        {
            return "";
        }
    }

    #endregion

    #region Registry

    class Registry
    {
        public static readonly RegistryKey LocalMachine = new RegistryKey();
    }

    #endregion

    #region PointF

    public struct PointF : IEquatable<PointF>
    {
        #region Fields

        float x, y;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new PointF instance.
        /// </summary>
        /// <param name="x">The X coordinate of this instance.</param>
        /// <param name="y">The Y coordinate of this instance.</param>
        public PointF(float x, float y)
            : this()
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> that indicates whether this instance is empty or zero.
        /// </summary>
        public bool IsEmpty { get { return X == 0 && Y == 0; } }

        /// <summary>
        /// Gets or sets the X coordinate of this instance.
        /// </summary>
        public float X { get { return x; } set { x = value; } }

        /// <summary>
        /// Gets or sets the Y coordinate of this instance.
        /// </summary>
        public float Y { get { return y; } set { y = value; } }

        /// <summary>
        /// Returns the PointF (0, 0).
        /// </summary>
        public static readonly PointF Zero = new PointF();

        /// <summary>
        /// Returns the PointF (0, 0).
        /// </summary>
        public static readonly PointF Empty = new PointF();

        /// <summary>
        /// Translates the specified PointF by the specified Size.
        /// </summary>
        /// <param name="point">
        /// The <see cref="PointF"/> instance to translate.
        /// </param>
        /// <param name="size">
        /// The <see cref="Size"/> instance to translate point with.
        /// </param>
        /// <returns>
        /// A new <see cref="PointF"/> instance translated by size.
        /// </returns>
        public static PointF operator +(PointF point, SizeF size)
        {
            return new PointF(point.X + size.Width, point.Y + size.Height);
        }

        /// <summary>
        /// Translates the specified PointF by the negative of the specified Size.
        /// </summary>
        /// <param name="point">
        /// The <see cref="PointF"/> instance to translate.
        /// </param>
        /// <param name="size">
        /// The <see cref="Size"/> instance to translate point with.
        /// </param>
        /// <returns>
        /// A new <see cref="PointF"/> instance translated by size.
        /// </returns>
        public static PointF operator -(PointF point, SizeF size)
        {
            return new PointF(point.X - size.Width, point.Y - size.Height);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is equal to right; false otherwise.</returns>
        public static bool operator ==(PointF left, PointF right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(PointF left, PointF right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Indicates whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is PointF)
                return Equals((PointF)obj);

            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A <see cref="System.Int32"/> that represents the hash code for this instance./></returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return String.Format("{{{0}, {1}}}", X, Y);
        }

        #endregion

        #region IEquatable<PointF> Members

        /// <summary>
        /// Indicates whether this instance is equal to the specified PointF.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(PointF other)
        {
            return X == other.X && Y == other.Y;
        }

        #endregion
    }

    #endregion

    #region SizeF

    public struct SizeF : IEquatable<SizeF>
    {
        #region Fields

        float width, height;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new SizeF instance.
        /// </summary>
        /// <param name="width">The width of this instance.</param>
        /// <param name="height">The height of this instance.</param>
        public SizeF(float width, float height)
            : this()
        {
            Width = width;
            Height = height;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets or sets the width of this instance.
        /// </summary>
        public float Width
        {
            get { return width; }
            set
            {
                if (width < 0)
                    throw new ArgumentOutOfRangeException();
                width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of this instance.
        /// </summary>
        public float Height
        {
            get { return height; }
            set
            {
                if (height < 0)
                    throw new ArgumentOutOfRangeException();
                height = value;
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> that indicates whether this instance is empty or zero.
        /// </summary>
        public bool IsEmpty
        {
            get { return Width == 0 && Height == 0; }
        }

        /// <summary>
        /// Returns a SizeF instance equal to (0, 0).
        /// </summary>
        public static readonly SizeF Empty = new SizeF();

        /// <summary>
        /// Returns a SizeF instance equal to (0, 0).
        /// </summary>
        public static readonly SizeF Zero = new SizeF();

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is equal to right; false otherwise.</returns>
        public static bool operator ==(SizeF left, SizeF right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(SizeF left, SizeF right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Indicates whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is SizeF)
                return Equals((SizeF)obj);

            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A <see cref="System.Int32"/> that represents the hash code for this instance./></returns>
        public override int GetHashCode()
        {
            return Width.GetHashCode() ^ Height.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return String.Format("{{{0}, {1}}}", Width, Height);
        }

        #endregion

        #region IEquatable<SizeF> Members

        /// <summary>
        /// Indicates whether this instance is equal to the specified SizeF.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(SizeF other)
        {
            return Width == other.Width && Height == other.Height;
        }

        #endregion
    }

    #endregion

    #region RectangleF

    public struct RectangleF : IEquatable<RectangleF>
    {
        #region Fields

        PointF location;
        SizeF size;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new RectangleF instance.
        /// </summary>
        /// <param name="location">The top-left corner of the RectangleF.</param>
        /// <param name="SizeF">The width and height of the RectangleF.</param>
        public RectangleF(PointF location, SizeF size)
            : this()
        {
            Location = location;
            Size = size;
        }

        /// <summary>
        /// Constructs a new RectangleF instance.
        /// </summary>
        /// <param name="x">The x coordinate of the RectangleF.</param>
        /// <param name="y">The y coordinate of the RectangleF.</param>
        /// <param name="width">The width coordinate of the RectangleF.</param>
        /// <param name="height">The height coordinate of the RectangleF.</param>
        public RectangleF(float x, float y, float width, float height)
            : this(new PointF(x, y), new SizeF(width, height))
        { }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets or sets the x coordinate of the RectangleF.
        /// </summary>
        public float X
        {
            get { return Location.X; }
            set { Location = new PointF(value, Y); }
        }

        /// <summary>
        /// Gets or sets the y coordinate of the RectangleF.
        /// </summary>
        public float Y
        {
            get { return Location.Y; }
            set { Location = new PointF(X, value); }
        }

        /// <summary>
        /// Gets or sets the width of the RectangleF.
        /// </summary>
        public float Width
        {
            get { return Size.Width; }
            set { Size = new SizeF(value, Height); }
        }

        /// <summary>
        /// Gets or sets the height of the RectangleF.
        /// </summary>
        public float Height
        {
            get { return Size.Height; }
            set { Size = new SizeF(Width, value); }
        }

        /// <summary>
        /// Gets or sets a <see cref="PointF"/> representing the x and y coordinates
        /// of the RectangleF.
        /// </summary>
        public PointF Location
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// Gets or sets a <see cref="SizeF"/> representing the width and height
        /// of the RectangleF.
        /// </summary>
        public SizeF Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Gets the y coordinate of the top edge of this RectangleF.
        /// </summary>
        public float Top { get { return Y; } }

        /// <summary>
        /// Gets the x coordinate of the right edge of this RectangleF.
        /// </summary>
        public float Right { get { return X + Width; } }

        /// <summary>
        /// Gets the y coordinate of the bottom edge of this RectangleF.
        /// </summary>
        public float Bottom { get { return Y + Height; } }

        /// <summary>
        /// Gets the x coordinate of the left edge of this RectangleF.
        /// </summary>
        public float Left { get { return X; } }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> that indicates whether this
        /// RectangleF is equal to the empty RectangleF.
        /// </summary>
        public bool IsEmpty
        {
            get { return Location.IsEmpty && Size.IsEmpty; }
        }

        /// <summary>
        /// Defines the empty RectangleF.
        /// </summary>
        public static readonly RectangleF Zero = new RectangleF();

        /// <summary>
        /// Defines the empty RectangleF.
        /// </summary>
        public static readonly RectangleF Empty = new RectangleF();

        /// <summary>
        /// Constructs a new instance with the specified edges.
        /// </summary>
        /// <param name="left">The left edge of the RectangleF.</param>
        /// <param name="top">The top edge of the RectangleF.</param>
        /// <param name="right">The right edge of the RectangleF.</param>
        /// <param name="bottom">The bottom edge of the RectangleF.</param>
        /// <returns>A new RectangleF instance with the specified edges.</returns>
        public static RectangleF FromLTRB(float left, float top, float right, float bottom)
        {
            return new RectangleF(new PointF(left, top), new SizeF(right - left, bottom - top));
        }

        /// <summary>
        /// Tests whether this instance contains the specified PointF.
        /// </summary>
        /// <param name="pofloat">The <see cref="PointF"/> to test.</param>
        /// <returns>True if this instance contains pofloat; false otherwise.</returns>
        /// <remarks>The left and top edges are inclusive. The right and bottom edges
        /// are exclusive.</remarks>
        public bool Contains(PointF pofloat)
        {
            return pofloat.X >= Left && pofloat.X < Right &&
                pofloat.Y >= Top && pofloat.Y < Bottom;
        }

        /// <summary>
        /// Tests whether this instance contains the specified RectangleF.
        /// </summary>
        /// <param name="rect">The <see cref="RectangleF"/> to test.</param>
        /// <returns>True if this instance contains rect; false otherwise.</returns>
        /// <remarks>The left and top edges are inclusive. The right and bottom edges
        /// are exclusive.</remarks>
        public bool Contains(RectangleF rect)
        {
            return Contains(rect.Location) && Contains(rect.Location + rect.Size);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is equal to right; false otherwise.</returns>
        public static bool operator ==(RectangleF left, RectangleF right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(RectangleF left, RectangleF right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Indicates whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is RectangleF)
                return Equals((RectangleF)obj);

            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A <see cref="System.float32"/> that represents the hash code for this instance./></returns>
        public override int GetHashCode()
        {
            return Location.GetHashCode() & Size.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return String.Format("{{{0}-{1}}}", Location, Location + Size);
        }

        #endregion

        #region IEquatable<RectangleF> Members

        /// <summary>
        /// Indicates whether this instance is equal to the specified RectangleF.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(RectangleF other)
        {
            return Location.Equals(other.Location) &&
                Size.Equals(other.Size);
        }

        #endregion
    }

    #endregion

    #region Icon

    public sealed class Icon : IDisposable
    {
        IntPtr handle;

        public Icon(Icon icon, int width, int height)
        {
            handle = icon.Handle;
            Width = width;
            Height = height;
        }

        public IntPtr Handle { get { return handle; } set { handle = value; } }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public Bitmap ToBitmap()
        {
            return new Bitmap(Width, Height);
        }

        public void Dispose()
        { }
    }

    #endregion

    #region Image

    public abstract class Image : IDisposable
    {
        public void Dispose() { }
    }

    #endregion

    #region Bitmap

    public sealed class Bitmap : Image
    {
        int width;
        int height;

        public Bitmap() { }

        public Bitmap(int width, int height)
        {
            // TODO: Complete member initialization
            this.width = width;
            this.height = height;
        }

        public int Width { get { return width; } }
        public int Height { get { return height; } }

        public Color GetPixel(int x, int y)
        {
            return new Color();
        }

        internal void UnlockBits(BitmapData data)
        {
        }

        internal BitmapData LockBits(Rectangle rectangle, ImageLockMode imageLockMode, PixelFormat pixelFormat)
        {
            return new BitmapData(Width, Height, 0);
        }
    }

    #endregion

    #region Color

    /// <summary>
    /// Represents a color with 4 8bit components (R, G, B, A).
    /// </summary>
    [Serializable]
    public struct Color : IEquatable<Color>
    {
        #region Fields

        /// <summary>
        /// The red component of this Color structure.
        /// </summary>
        public byte R;

        /// <summary>
        /// The green component of this Color structure.
        /// </summary>
        public byte G;

        /// <summary>
        /// The blue component of this Color structure.
        /// </summary>
        public byte B;

        /// <summary>
        /// The alpha component of this Color structure.
        /// </summary>
        public byte A;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Color structure from the specified components.
        /// </summary>
        /// <param name="r">The red component of the new Color structure.</param>
        /// <param name="g">The green component of the new Color structure.</param>
        /// <param name="b">The blue component of the new Color structure.</param>
        /// <param name="a">The alpha component of the new Color structure.</param>
        public Color(int r, int g, int b, int a)
        {
            R = (byte)r;
            G = (byte)g;
            B = (byte)b;
            A = (byte)a;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Converts this color to an integer representation with 8 bits per channel.
        /// </summary>
        /// <returns>A <see cref="System.Int32"/> that represents this instance.</returns>
        /// <remarks>This method is intended only for compatibility with System.Drawing. It compresses the color into 8 bits per channel, which means color information is lost.</remarks>
        public int ToArgb()
        {
            uint value =
                (uint)(A * Byte.MaxValue) << 24 |
                (uint)(R * Byte.MaxValue) << 16 |
                (uint)(G * Byte.MaxValue) << 8 |
                (uint)(B * Byte.MaxValue);

            return unchecked((int)value);
        }

        /// <summary>
        /// Compares the specified Color structures for equality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        public static bool operator ==(Color left, Color right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified Color structures for inequality.
        /// </summary>
        /// <param name="left">The left-hand side of the comparison.</param>
        /// <param name="right">The right-hand side of the comparison.</param>
        /// <returns>True if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(Color left, Color right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Compares whether this Color structure is equal to the specified object.
        /// </summary>
        /// <param name="obj">An object to compare to.</param>
        /// <returns>True obj is a Color structure with the same components as this Color; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Color))
                return false;

            return Equals((Color)obj);
        }

        /// <summary>
        /// Calculates the hash code for this Color structure.
        /// </summary>
        /// <returns>A System.Int32 containing the hashcode of this Color structure.</returns>
        public override int GetHashCode()
        {
            return ToArgb();
        }

        /// <summary>
        /// Creates a System.String that describes this Color structure.
        /// </summary>
        /// <returns>A System.String that describes this Color structure.</returns>
        public override string ToString()
        {
            return String.Format("{{(R, G, B, A) = ({0}, {1}, {2}, {3})}}", R.ToString(), G.ToString(), B.ToString(), A.ToString());
        }

#region System colors

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 255, 0).
        /// </summary>
        public static Color Transparent { get { return new Color(255, 255, 255, 0); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 248, 255, 255).
        /// </summary>
        public static Color AliceBlue { get { return new Color(240, 248, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 235, 215, 255).
        /// </summary>
        public static Color AntiqueWhite { get { return new Color(250, 235, 215, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 255, 255).
        /// </summary>
        public static Color Aqua { get { return new Color(0, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (127, 255, 212, 255).
        /// </summary>
        public static Color Aquamarine { get { return new Color(127, 255, 212, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 255, 255, 255).
        /// </summary>
        public static Color Azure { get { return new Color(240, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 245, 220, 255).
        /// </summary>
        public static Color Beige { get { return new Color(245, 245, 220, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 196, 255).
        /// </summary>
        public static Color Bisque { get { return new Color(255, 228, 196, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 0, 255).
        /// </summary>
        public static Color Black { get { return new Color(0, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 235, 205, 255).
        /// </summary>
        public static Color BlanchedAlmond { get { return new Color(255, 235, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 255, 255).
        /// </summary>
        public static Color Blue { get { return new Color(0, 0, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (138, 43, 226, 255).
        /// </summary>
        public static Color BlueViolet { get { return new Color(138, 43, 226, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (165, 42, 42, 255).
        /// </summary>
        public static Color Brown { get { return new Color(165, 42, 42, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (222, 184, 135, 255).
        /// </summary>
        public static Color BurlyWood { get { return new Color(222, 184, 135, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (95, 158, 160, 255).
        /// </summary>
        public static Color CadetBlue { get { return new Color(95, 158, 160, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (127, 255, 0, 255).
        /// </summary>
        public static Color Chartreuse { get { return new Color(127, 255, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (210, 105, 30, 255).
        /// </summary>
        public static Color Chocolate { get { return new Color(210, 105, 30, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 127, 80, 255).
        /// </summary>
        public static Color Coral { get { return new Color(255, 127, 80, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (100, 149, 237, 255).
        /// </summary>
        public static Color CornflowerBlue { get { return new Color(100, 149, 237, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 248, 220, 255).
        /// </summary>
        public static Color Cornsilk { get { return new Color(255, 248, 220, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (220, 20, 60, 255).
        /// </summary>
        public static Color Crimson { get { return new Color(220, 20, 60, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 255, 255).
        /// </summary>
        public static Color Cyan { get { return new Color(0, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 139, 255).
        /// </summary>
        public static Color DarkBlue { get { return new Color(0, 0, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 139, 139, 255).
        /// </summary>
        public static Color DarkCyan { get { return new Color(0, 139, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (184, 134, 11, 255).
        /// </summary>
        public static Color DarkGoldenrod { get { return new Color(184, 134, 11, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (169, 169, 169, 255).
        /// </summary>
        public static Color DarkGray { get { return new Color(169, 169, 169, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 100, 0, 255).
        /// </summary>
        public static Color DarkGreen { get { return new Color(0, 100, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (189, 183, 107, 255).
        /// </summary>
        public static Color DarkKhaki { get { return new Color(189, 183, 107, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 0, 139, 255).
        /// </summary>
        public static Color DarkMagenta { get { return new Color(139, 0, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (85, 107, 47, 255).
        /// </summary>
        public static Color DarkOliveGreen { get { return new Color(85, 107, 47, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 140, 0, 255).
        /// </summary>
        public static Color DarkOrange { get { return new Color(255, 140, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (153, 50, 204, 255).
        /// </summary>
        public static Color DarkOrchid { get { return new Color(153, 50, 204, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 0, 0, 255).
        /// </summary>
        public static Color DarkRed { get { return new Color(139, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (233, 150, 122, 255).
        /// </summary>
        public static Color DarkSalmon { get { return new Color(233, 150, 122, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (143, 188, 139, 255).
        /// </summary>
        public static Color DarkSeaGreen { get { return new Color(143, 188, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (72, 61, 139, 255).
        /// </summary>
        public static Color DarkSlateBlue { get { return new Color(72, 61, 139, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (47, 79, 79, 255).
        /// </summary>
        public static Color DarkSlateGray { get { return new Color(47, 79, 79, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 206, 209, 255).
        /// </summary>
        public static Color DarkTurquoise { get { return new Color(0, 206, 209, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (148, 0, 211, 255).
        /// </summary>
        public static Color DarkViolet { get { return new Color(148, 0, 211, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 20, 147, 255).
        /// </summary>
        public static Color DeepPink { get { return new Color(255, 20, 147, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 191, 255, 255).
        /// </summary>
        public static Color DeepSkyBlue { get { return new Color(0, 191, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (105, 105, 105, 255).
        /// </summary>
        public static Color DimGray { get { return new Color(105, 105, 105, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (30, 144, 255, 255).
        /// </summary>
        public static Color DodgerBlue { get { return new Color(30, 144, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (178, 34, 34, 255).
        /// </summary>
        public static Color Firebrick { get { return new Color(178, 34, 34, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 240, 255).
        /// </summary>
        public static Color FloralWhite { get { return new Color(255, 250, 240, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (34, 139, 34, 255).
        /// </summary>
        public static Color ForestGreen { get { return new Color(34, 139, 34, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 255, 255).
        /// </summary>
        public static Color Fuchsia { get { return new Color(255, 0, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (220, 220, 220, 255).
        /// </summary>
        public static Color Gainsboro { get { return new Color(220, 220, 220, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (248, 248, 255, 255).
        /// </summary>
        public static Color GhostWhite { get { return new Color(248, 248, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 215, 0, 255).
        /// </summary>
        public static Color Gold { get { return new Color(255, 215, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (218, 165, 32, 255).
        /// </summary>
        public static Color Goldenrod { get { return new Color(218, 165, 32, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 128, 128, 255).
        /// </summary>
        public static Color Gray { get { return new Color(128, 128, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 128, 0, 255).
        /// </summary>
        public static Color Green { get { return new Color(0, 128, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (173, 255, 47, 255).
        /// </summary>
        public static Color GreenYellow { get { return new Color(173, 255, 47, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 255, 240, 255).
        /// </summary>
        public static Color Honeydew { get { return new Color(240, 255, 240, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 105, 180, 255).
        /// </summary>
        public static Color HotPink { get { return new Color(255, 105, 180, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (205, 92, 92, 255).
        /// </summary>
        public static Color IndianRed { get { return new Color(205, 92, 92, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (75, 0, 130, 255).
        /// </summary>
        public static Color Indigo { get { return new Color(75, 0, 130, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 240, 255).
        /// </summary>
        public static Color Ivory { get { return new Color(255, 255, 240, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 230, 140, 255).
        /// </summary>
        public static Color Khaki { get { return new Color(240, 230, 140, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (230, 230, 250, 255).
        /// </summary>
        public static Color Lavender { get { return new Color(230, 230, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 240, 245, 255).
        /// </summary>
        public static Color LavenderBlush { get { return new Color(255, 240, 245, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (124, 252, 0, 255).
        /// </summary>
        public static Color LawnGreen { get { return new Color(124, 252, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 205, 255).
        /// </summary>
        public static Color LemonChiffon { get { return new Color(255, 250, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (173, 216, 230, 255).
        /// </summary>
        public static Color LightBlue { get { return new Color(173, 216, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (240, 128, 128, 255).
        /// </summary>
        public static Color LightCoral { get { return new Color(240, 128, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (224, 255, 255, 255).
        /// </summary>
        public static Color LightCyan { get { return new Color(224, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 250, 210, 255).
        /// </summary>
        public static Color LightGoldenrodYellow { get { return new Color(250, 250, 210, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (144, 238, 144, 255).
        /// </summary>
        public static Color LightGreen { get { return new Color(144, 238, 144, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (211, 211, 211, 255).
        /// </summary>
        public static Color LightGray { get { return new Color(211, 211, 211, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 182, 193, 255).
        /// </summary>
        public static Color LightPink { get { return new Color(255, 182, 193, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 160, 122, 255).
        /// </summary>
        public static Color LightSalmon { get { return new Color(255, 160, 122, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (32, 178, 170, 255).
        /// </summary>
        public static Color LightSeaGreen { get { return new Color(32, 178, 170, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (135, 206, 250, 255).
        /// </summary>
        public static Color LightSkyBlue { get { return new Color(135, 206, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (119, 136, 153, 255).
        /// </summary>
        public static Color LightSlateGray { get { return new Color(119, 136, 153, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (176, 196, 222, 255).
        /// </summary>
        public static Color LightSteelBlue { get { return new Color(176, 196, 222, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 224, 255).
        /// </summary>
        public static Color LightYellow { get { return new Color(255, 255, 224, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 0, 255).
        /// </summary>
        public static Color Lime { get { return new Color(0, 255, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (50, 205, 50, 255).
        /// </summary>
        public static Color LimeGreen { get { return new Color(50, 205, 50, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 240, 230, 255).
        /// </summary>
        public static Color Linen { get { return new Color(250, 240, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 255, 255).
        /// </summary>
        public static Color Magenta { get { return new Color(255, 0, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 0, 0, 255).
        /// </summary>
        public static Color Maroon { get { return new Color(128, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (102, 205, 170, 255).
        /// </summary>
        public static Color MediumAquamarine { get { return new Color(102, 205, 170, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 205, 255).
        /// </summary>
        public static Color MediumBlue { get { return new Color(0, 0, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (186, 85, 211, 255).
        /// </summary>
        public static Color MediumOrchid { get { return new Color(186, 85, 211, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (147, 112, 219, 255).
        /// </summary>
        public static Color MediumPurple { get { return new Color(147, 112, 219, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (60, 179, 113, 255).
        /// </summary>
        public static Color MediumSeaGreen { get { return new Color(60, 179, 113, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (123, 104, 238, 255).
        /// </summary>
        public static Color MediumSlateBlue { get { return new Color(123, 104, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 250, 154, 255).
        /// </summary>
        public static Color MediumSpringGreen { get { return new Color(0, 250, 154, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (72, 209, 204, 255).
        /// </summary>
        public static Color MediumTurquoise { get { return new Color(72, 209, 204, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (199, 21, 133, 255).
        /// </summary>
        public static Color MediumVioletRed { get { return new Color(199, 21, 133, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (25, 25, 112, 255).
        /// </summary>
        public static Color MidnightBlue { get { return new Color(25, 25, 112, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 255, 250, 255).
        /// </summary>
        public static Color MintCream { get { return new Color(245, 255, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 225, 255).
        /// </summary>
        public static Color MistyRose { get { return new Color(255, 228, 225, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 228, 181, 255).
        /// </summary>
        public static Color Moccasin { get { return new Color(255, 228, 181, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 222, 173, 255).
        /// </summary>
        public static Color NavajoWhite { get { return new Color(255, 222, 173, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 0, 128, 255).
        /// </summary>
        public static Color Navy { get { return new Color(0, 0, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (253, 245, 230, 255).
        /// </summary>
        public static Color OldLace { get { return new Color(253, 245, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 128, 0, 255).
        /// </summary>
        public static Color Olive { get { return new Color(128, 128, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (107, 142, 35, 255).
        /// </summary>
        public static Color OliveDrab { get { return new Color(107, 142, 35, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 165, 0, 255).
        /// </summary>
        public static Color Orange { get { return new Color(255, 165, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 69, 0, 255).
        /// </summary>
        public static Color OrangeRed { get { return new Color(255, 69, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (218, 112, 214, 255).
        /// </summary>
        public static Color Orchid { get { return new Color(218, 112, 214, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (238, 232, 170, 255).
        /// </summary>
        public static Color PaleGoldenrod { get { return new Color(238, 232, 170, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (152, 251, 152, 255).
        /// </summary>
        public static Color PaleGreen { get { return new Color(152, 251, 152, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (175, 238, 238, 255).
        /// </summary>
        public static Color PaleTurquoise { get { return new Color(175, 238, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (219, 112, 147, 255).
        /// </summary>
        public static Color PaleVioletRed { get { return new Color(219, 112, 147, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 239, 213, 255).
        /// </summary>
        public static Color PapayaWhip { get { return new Color(255, 239, 213, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 218, 185, 255).
        /// </summary>
        public static Color PeachPuff { get { return new Color(255, 218, 185, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (205, 133, 63, 255).
        /// </summary>
        public static Color Peru { get { return new Color(205, 133, 63, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 192, 203, 255).
        /// </summary>
        public static Color Pink { get { return new Color(255, 192, 203, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (221, 160, 221, 255).
        /// </summary>
        public static Color Plum { get { return new Color(221, 160, 221, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (176, 224, 230, 255).
        /// </summary>
        public static Color PowderBlue { get { return new Color(176, 224, 230, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (128, 0, 128, 255).
        /// </summary>
        public static Color Purple { get { return new Color(128, 0, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 0, 0, 255).
        /// </summary>
        public static Color Red { get { return new Color(255, 0, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (188, 143, 143, 255).
        /// </summary>
        public static Color RosyBrown { get { return new Color(188, 143, 143, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (65, 105, 225, 255).
        /// </summary>
        public static Color RoyalBlue { get { return new Color(65, 105, 225, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (139, 69, 19, 255).
        /// </summary>
        public static Color SaddleBrown { get { return new Color(139, 69, 19, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (250, 128, 114, 255).
        /// </summary>
        public static Color Salmon { get { return new Color(250, 128, 114, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (244, 164, 96, 255).
        /// </summary>
        public static Color SandyBrown { get { return new Color(244, 164, 96, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (46, 139, 87, 255).
        /// </summary>
        public static Color SeaGreen { get { return new Color(46, 139, 87, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 245, 238, 255).
        /// </summary>
        public static Color SeaShell { get { return new Color(255, 245, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (160, 82, 45, 255).
        /// </summary>
        public static Color Sienna { get { return new Color(160, 82, 45, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (192, 192, 192, 255).
        /// </summary>
        public static Color Silver { get { return new Color(192, 192, 192, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (135, 206, 235, 255).
        /// </summary>
        public static Color SkyBlue { get { return new Color(135, 206, 235, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (106, 90, 205, 255).
        /// </summary>
        public static Color SlateBlue { get { return new Color(106, 90, 205, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (112, 128, 144, 255).
        /// </summary>
        public static Color SlateGray { get { return new Color(112, 128, 144, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 250, 250, 255).
        /// </summary>
        public static Color Snow { get { return new Color(255, 250, 250, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 255, 127, 255).
        /// </summary>
        public static Color SpringGreen { get { return new Color(0, 255, 127, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (70, 130, 180, 255).
        /// </summary>
        public static Color SteelBlue { get { return new Color(70, 130, 180, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (210, 180, 140, 255).
        /// </summary>
        public static Color Tan { get { return new Color(210, 180, 140, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (0, 128, 128, 255).
        /// </summary>
        public static Color Teal { get { return new Color(0, 128, 128, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (216, 191, 216, 255).
        /// </summary>
        public static Color Thistle { get { return new Color(216, 191, 216, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 99, 71, 255).
        /// </summary>
        public static Color Tomato { get { return new Color(255, 99, 71, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (64, 224, 208, 255).
        /// </summary>
        public static Color Turquoise { get { return new Color(64, 224, 208, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (238, 130, 238, 255).
        /// </summary>
        public static Color Violet { get { return new Color(238, 130, 238, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 222, 179, 255).
        /// </summary>
        public static Color Wheat { get { return new Color(245, 222, 179, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 255, 255).
        /// </summary>
        public static Color White { get { return new Color(255, 255, 255, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (245, 245, 245, 255).
        /// </summary>
        public static Color WhiteSmoke { get { return new Color(245, 245, 245, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (255, 255, 0, 255).
        /// </summary>
        public static Color Yellow { get { return new Color(255, 255, 0, 255); } }

        /// <summary>
        /// Gets the system color with (R, G, B, A) = (154, 205, 50, 255).
        /// </summary>
        public static Color YellowGreen { get { return new Color(154, 205, 50, 255); } }

        #endregion

        #endregion

        #region IEquatable<Color> Members

        /// <summary>
        /// Compares whether this Color structure is equal to the specified Color.
        /// </summary>
        /// <param name="other">The Color structure to compare to.</param>
        /// <returns>True if both Color structures contain the same components; false otherwise.</returns>
        public bool Equals(Color other)
        {
            return
                this.R == other.R &&
                this.G == other.G &&
                this.B == other.B &&
                this.A == other.A;
        }

        #endregion

        public static Color FromArgb(int a, int r, int g, int b)
        {
            return new Color(r, g, b, a);
        }
    }

    #endregion

    #region BitmapData

    sealed class BitmapData
    {
        internal BitmapData(int width, int height, int stride)
        {
            Width = width;
            Height = height;
            Stride = stride;
        }

        public IntPtr Scan0 { get { return IntPtr.Zero; } }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Stride { get; private set; }
    }

    #endregion

    #region ImageLockMode

    enum ImageLockMode
    {
        ReadOnly,
        WriteOnly,
        ReadWrite,
        UserInputBuffer
    }

    #endregion

    #region PixelFormat

    enum PixelFormat
    {
        Format32bppArgb
    }

    #endregion

    #region SystemEvents

    sealed class SystemEvents
    {
        public static event EventHandler DisplaySettingsChanged;
    }

    #endregion
}

// Need a different namespace to avoid clash with OpenTK.Graphics.
namespace OpenTK.Minimal
{
    #region Graphics

    sealed class Graphics : IDisposable
    {
        public static Graphics FromImage(OpenTK.Image img)
        {
            return new Graphics();
        }

        public void Dispose()
        { }

        internal void DrawImage(OpenTK.Bitmap bitmap, int p, int p_2, int p_3, int p_4)
        {
        }
    }

    #endregion
}


#endif
