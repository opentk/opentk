using System;
using System.Text;
using OpenTK.Mathematics;
using OpenTK.Core.Utility;

namespace OpenTK.Platform.Native
{
    internal static unsafe class EDID
    {
        public struct EDIDInfo
        {
            public string? DisplayName;
            public string? SerialNumberString;
            public int SerialNumber;

            public string? UnspecifiedText;

            public byte EDIDMajorVersion;
            public byte EDIDMinorVersion;

            public bool IsDigitalInput;
            public int BitDepth;
            public VideoInterface VideoInterface;

            // What if vertical size is 0?
            public int HorizontalScreenSize;
            public int VerticalScreenSize;

            // FIXME: What if gamma was 255?
            public float DisplayGamma;

            public Vector2 RedCIE;
            public Vector2 GreenCIE;
            public Vector2 BlueCIE;
            public Vector2 WhiteCIE;

            public byte Checksum;
        }


        public enum VideoInterface : byte
        {
            Undefined = 0b000,
            DVI = 0b0001,
            HDMIa = 0b0010,
            HDMIb = 0b0011,
            MDDI = 0b0100,
            DisplayPort = 0b0101,
        }

        // This code assumes little-endian.
        // - 2023-06-07 Noggin_bops
        public static EDIDInfo Parse(byte* data, ILogger? logger)
        {
            EDIDInfo info;

            byte checksum = 0;
            byte* checksumPtr = data;
            for (int i = 0; i < 128; i++)
            {
                checksum += *checksumPtr++;
            }

            if (checksum != 0)
            {
                logger?.LogWarning($"EDID checksum failed! Got {checksum}, should have been equal to 0.");
            }
            info.Checksum = checksum;

            ReadOnlySpan<byte> header = new byte[] { 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00 };
            for (int i = 0; i < header.Length; i++)
            {
                if (*data++ != header[i])
                {
                    throw new Exception("Wrong header!");
                }
            }

            // Manufacturer ID 2 bytes
            // For now we skip this as we are not interested
            data += 2;

            short productCode = *(short*)data;
            data += 2;

            info.SerialNumber = *(int*)data;
            data += 4;

            // Week of manifacture, skip
            data += 1;

            // Year of manifacture, skip
            data += 1;

            info.EDIDMajorVersion = *data++;
            info.EDIDMinorVersion = *data++;

            byte videoParameters = *data++;

            if ((videoParameters & 0x80) != 0)
            {
                // Digital input

                info.IsDigitalInput = true;

                int bitDepth;
                switch ((videoParameters & 0b01110000) >> 4)
                {
                    case 0: bitDepth = 0; break;
                    case 1: bitDepth = 6; break;
                    case 2: bitDepth = 8; break;
                    case 3: bitDepth = 10; break;
                    case 4: bitDepth = 12; break;
                    case 5: bitDepth = 14; break;
                    case 6: bitDepth = 16; break;
                    default: bitDepth = 0; break;
                }
                info.BitDepth = bitDepth;

                info.VideoInterface = (VideoInterface)(videoParameters & 0b1111);
            }
            else
            {
                // Analog input
                info.IsDigitalInput = false;
                info.BitDepth = 0;
                info.VideoInterface = default;

                // FIXME: read this data
            }

            // FIXME: If vertical screen size is 0, then horizontal screen size describes the aspect ratio.
            info.HorizontalScreenSize = *data++;
            info.VerticalScreenSize = *data++;

            byte gamma = *data++;
            if (gamma != 255)
            {
                info.DisplayGamma = (gamma + 100) / 100f;
            }
            else
            {
                // FIXME: Gamma defined in DI-EXT block.
                info.DisplayGamma = -1;
            }

            // Supported features bitmap, 1 byte
            byte featuresBitmap = *data++;
            if (info.IsDigitalInput)
            {

            }
            else
            {

            }

            // Chromaticity coordinates
            byte rglsb = *data++;
            byte bwlsb = *data++;
            byte redxmsb = *data++;
            byte redymsb = *data++;
            byte greenxmsb = *data++;
            byte greenymsb = *data++;
            byte bluexmsb = *data++;
            byte blueymsb = *data++;
            byte whitexmsb = *data++;
            byte whiteymsb = *data++;

            float redx = (redxmsb << 2 | ((rglsb & 0b11000000) >> 6)) / 1024f;
            float redy = (redymsb << 2 | ((rglsb & 0b00110000) >> 4)) / 1024f;
            info.RedCIE = (redx, redy);

            float greenx = (greenxmsb << 2 | ((rglsb & 0b00001100) >> 2)) / 1024f;
            float greeny = (greenymsb << 2 | ((rglsb & 0b00000011) >> 0)) / 1024f;
            info.GreenCIE = (greenx, greeny);

            float bluex = (bluexmsb << 2 | ((bwlsb & 0b11000000) >> 6)) / 1024f;
            float bluey = (blueymsb << 2 | ((bwlsb & 0b00110000) >> 4)) / 1024f;
            info.BlueCIE = (bluex, bluey);

            float whitex = (whitexmsb << 2 | ((bwlsb & 0b00001100) >> 2)) / 1024f;
            float whitey = (whiteymsb << 2 | ((bwlsb & 0b00000011) >> 0)) / 1024f;
            info.WhiteCIE = (whitex, whitey);

            // Old timing modes, skip
            data += 3;

            // Standard timing information, skip
            data += 8 * 2;

            info.DisplayName = null;
            info.SerialNumberString = null;
            info.UnspecifiedText = null;

            // 4 descriptors
            for (int i = 0; i < 4; i++)
            {
                byte* desc = data + i * 18;

                short pixelClock = *(short*)desc;
                if (pixelClock != 0)
                {
                    // This is a detailed timing descriptor
                }
                else
                {
                    // This is a display descriptor
                    desc += 2;

                    // reserved
                    desc += 1;

                    byte descriptorType = *desc++;

                    if (descriptorType == 0xFF)
                    {
                        // Serial number

                        // reserved
                        desc += 1;

                        ReadOnlySpan<byte> serial = new ReadOnlySpan<byte>(desc, 13);
                        int index = serial.IndexOf((byte)'\n');
                        if (index != -1) serial = serial[0..index];

                        info.SerialNumberString = Encoding.ASCII.GetString(serial);
                    }
                    else if (descriptorType == 0xFC)
                    {
                        // Display name

                        // reserved
                        desc += 1;

                        ReadOnlySpan<byte> name = new ReadOnlySpan<byte>(desc, 13);
                        int index = name.IndexOf((byte)'\n');
                        if (index != -1) name = name[0..index];

                        info.DisplayName = Encoding.ASCII.GetString(name);
                    }
                    else if (descriptorType == 0xFE)
                    {
                        // Unspecified text

                        // reserved
                        desc += 1;

                        ReadOnlySpan<byte> text = new ReadOnlySpan<byte>(desc, 13);
                        int index = text.IndexOf((byte)'\n');
                        if (index != -1) text = text[0..index];

                        // FIXME: What if there is more than one unspecified text?
                        info.UnspecifiedText = Encoding.ASCII.GetString(text);
                    }
                }
            }
            data += 4 * 18;

            byte extensions = *data++;

            // Checksum byte
            data += 1;

            return info;
        }
    }
}

