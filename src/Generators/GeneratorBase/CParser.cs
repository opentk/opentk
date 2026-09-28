using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GeneratorBase
{
    public enum TokenType
    {
        Invalid,
        EndOfFile,

        ConstantInteger, // {D}+{IS}?
        ConstantHex,     // 0[xX]{H}+{IS}?
        ConstantOctal,   // 0{D}+{IS}?
        ConstantChar,    // L?'(\\.|[^\\'])+'
        ConstantFloat,   // {D}+{E}{FS}? | {D}*"."{D}+({E})?{FS}? | {D}+"."{D}*({E})?{FS}?

        Identifier,
        StringLiteral,

        Ellipsis,
        RightShiftAssign,
        LeftShiftAssign,
        AddAssign,
        SubtractAssign,
        MultiplyAssign,
        DivideAssign,
        ModAssign,
        AndAssign,
        XorAssign,
        OrAssign,
        RightShift,
        LeftShift,
        Increment,
        Decrement,
        PointerArrow,
        LogicalAnd,
        LogicalOr,
        LessThanOrEqual,
        GreaterThanOrEqual,
        DoubleEqual,
        NotEqual,

        Semicolon,
        LeftBrace,
        RightBrace,
        Comma,
        Colon,
        Equal,
        LeftParenthesis,
        RightParenthesis,
        LeftBracket,
        RightBracket,
        Period,
        BitwiseAnd,
        Not,
        Invert,
        Subtract,
        Add,
        Asterisk,
        Divide,
        Modulo,
        LessThan,
        GreaterThan,
        Xor,
        BitwiseOr,
        Questionmark,

        KeywordAuto,
        KeywordBreak,
        KeywordCase,
        KeywordChar,
        KeywordConst,
        KeywordContinue,
        KeywordDefault,
        KeywordDo,
        KeywordDouble,
        KeywordElse,
        KeywordEnum,
        KeywordExtern,
        KeywordFloat,
        KeywordFor,
        KeywordGoto,
        KeywordIf,
        KeywordInt,
        KeywordLong,
        KeywordRegister,
        KeywordReturn,
        KeywordShort,
        KeywordSigned,
        KeywordSizeof,
        KeywordStatic,
        KeywordStruct,
        KeywordSwitch,
        KeywordTypedef,
        KeywordUnion,
        KeywordUnsigned,
        KeywordVoid,
        KeywordVolatile,
        KeywordWhile,
    }

    public readonly ref struct RefToken
    {
        public readonly TokenType Type;
        public readonly ReadOnlySpan<char> Value;

        public RefToken(TokenType type, ReadOnlySpan<char> value)
        {
            Type = type;
            Value = value;
        }
    }

    public class CParser
    {
        public CTokenizer Tokenizer;

        public CParser(string code)
        {
            Tokenizer = new CTokenizer(code);
        }


    }

    public class CTokenizer
    {
        public string CodeStr;
        private ReadOnlySpan<char> Code => CodeStr;
        private ReadOnlySpan<char> RemainingCode => Code[Offset..];
        public int Offset;

        public CTokenizer(string code)
        {
            CodeStr = code;
            Offset = 0;
        }

        internal char Peek(int n)
        {
            var code = Code;
            int pos = Offset + n;
            if (pos >= 0 && pos < code.Length)
            {
                return code[pos];
            }
            else
            {
                return '\0';
            }
        }

        internal ReadOnlySpan<char> Advance(int n)
        {
            int startOffset = Offset;
            Offset += n;
            return Code[startOffset..Offset];
        }

        public RefToken Next()
        {
            // Eat all white space.
            char peek;
            while (char.IsWhiteSpace(peek = Peek(0)))
                Offset++;

            char peek1;
            switch (peek)
            {
                case ';': return new RefToken(TokenType.Semicolon, Advance(1));
                case '{': return new RefToken(TokenType.LeftBrace, Advance(1));
                case '}': return new RefToken(TokenType.RightBrace, Advance(1));
                case ',': return new RefToken(TokenType.Comma, Advance(1));
                case ':': return new RefToken(TokenType.Colon, Advance(1));
                case '=':
                    if (Peek(1) == '=') return new RefToken(TokenType.DoubleEqual, Advance(2));
                    else                return new RefToken(TokenType.Equal, Advance(1));
                case '(': return new RefToken(TokenType.LeftParenthesis, Advance(1));
                case ')': return new RefToken(TokenType.RightParenthesis, Advance(1));
                case '[': return new RefToken(TokenType.LeftBracket, Advance(1));
                case ']': return new RefToken(TokenType.RightBracket, Advance(1));
                case '.':
                    peek1 = Peek(1);
                    if (peek1 == '.' && Peek(2) == '.')
                         return new RefToken(TokenType.Ellipsis, Advance(3));
                    else if (char.IsAsciiDigit(peek1) || peek1 == 'E' || peek1 == 'e')
                         return ReadFloatingPointNumber();
                    else return new RefToken(TokenType.Period, Advance(1));
                case '&':
                    peek1 = Peek(1);
                    if (peek1 == '&')      return new RefToken(TokenType.LogicalAnd, Advance(2));
                    else if (peek1 == '=') return new RefToken(TokenType.OrAssign, Advance(2));
                    else                   return new RefToken(TokenType.BitwiseAnd, Advance(1));
                case '!': return new RefToken(TokenType.Not, Advance(1));
                case '~': return new RefToken(TokenType.Invert, Advance(1));
                case '-':
                    peek1 = Peek(1);
                    if (peek1 == '-')      return new RefToken(TokenType.Decrement, Advance(2));
                    else if (peek1 == '=') return new RefToken(TokenType.SubtractAssign, Advance(2));
                    else if (peek1 == '>') return new RefToken(TokenType.PointerArrow, Advance(2));
                    else                   return new RefToken(TokenType.Subtract, Advance(1));
                case '+':
                    peek1 = Peek(1);
                    if (peek1 == '+')      return new RefToken(TokenType.Increment, Advance(2));
                    else if (peek1 == '=') return new RefToken(TokenType.AddAssign, Advance(2));
                    else                   return new RefToken(TokenType.Add, Advance(1));
                case '*':
                    if (Peek(1) == '=') return new RefToken(TokenType.MultiplyAssign, Advance(2));
                    else                return new RefToken(TokenType.Asterisk, Advance(1));
                case '/':
                    if (Peek(1) == '=') return new RefToken(TokenType.DivideAssign, Advance(2));
                    else                return new RefToken(TokenType.Divide, Advance(1));
                case '%':
                    if (Peek(1) == '=') return new RefToken(TokenType.ModAssign, Advance(2));
                    else                return new RefToken(TokenType.Modulo, Advance(1));
                case '<':
                    peek1 = Peek(1);
                    if (peek1 == '<' && Peek(2) == '=')
                                           return new RefToken(TokenType.LeftShiftAssign, Advance(3));
                    else if (peek1 == '<') return new RefToken(TokenType.LeftShift, Advance(2));
                    else if (peek1 == '=') return new RefToken(TokenType.LessThanOrEqual, Advance(2));
                    else                   return new RefToken(TokenType.LessThan, Advance(1));
                case '>':
                    peek1 = Peek(1);
                    if (peek1 == '>' && Peek(2) == '=')
                                           return new RefToken(TokenType.RightShiftAssign, Advance(3));
                    else if (peek1 == '>') return new RefToken(TokenType.RightShift, Advance(2));
                    else if (peek1 == '=') return new RefToken(TokenType.GreaterThanOrEqual, Advance(2));
                    else                   return new RefToken(TokenType.GreaterThan, Advance(1));
                case '^':
                    if (Peek(1) == '=') return new RefToken(TokenType.XorAssign, Advance(2));
                    else                return new RefToken(TokenType.XorAssign, Advance(1));
                case '|':
                    peek1 = Peek(1);
                    if (peek1 == '|')      return new RefToken(TokenType.LogicalOr, Advance(2));
                    else if (peek1 == '=') return new RefToken(TokenType.OrAssign, Advance(2));
                    else                   return new RefToken(TokenType.BitwiseOr, Advance(1));
                case '?': return new RefToken(TokenType.Questionmark, Advance(1));

                // FIXME: Check that keywords end with a space or similar..
                case 'a':
                    if (IsNextKeyword("auto")) return new RefToken(TokenType.KeywordAuto, Advance("auto".Length));
                    else return ReadIdentifier();
                case 'b':
                    if (IsNextKeyword("break")) return new RefToken(TokenType.KeywordBreak, Advance("break".Length));
                    else return ReadIdentifier();
                case 'c':
                    if (IsNextKeyword("case"))          return new RefToken(TokenType.KeywordCase, Advance("case".Length));
                    else if (IsNextKeyword("char"))     return new RefToken(TokenType.KeywordChar, Advance("char".Length));
                    else if (IsNextKeyword("const"))    return new RefToken(TokenType.KeywordConst, Advance("const".Length));
                    else if (IsNextKeyword("continue")) return new RefToken(TokenType.KeywordContinue, Advance("continue".Length));
                    else return ReadIdentifier();
                case 'd':
                    if (IsNextKeyword("default"))     return new RefToken(TokenType.KeywordDefault, Advance("default".Length));
                    else if (IsNextKeyword("do"))     return new RefToken(TokenType.KeywordDo, Advance("do".Length));
                    else if (IsNextKeyword("double")) return new RefToken(TokenType.KeywordDouble, Advance("double".Length));
                    else return ReadIdentifier();
                case 'e':
                    if (IsNextKeyword("else"))        return new RefToken(TokenType.KeywordElse, Advance("else".Length));
                    else if (IsNextKeyword("enum"))   return new RefToken(TokenType.KeywordEnum, Advance("enum".Length));
                    else if (IsNextKeyword("extern")) return new RefToken(TokenType.KeywordExtern, Advance("extern".Length));
                    else return ReadIdentifier();
                case 'f':
                    if (IsNextKeyword("float"))    return new RefToken(TokenType.KeywordFloat, Advance("float".Length));
                    else if (IsNextKeyword("for")) return new RefToken(TokenType.KeywordFor, Advance("for".Length));
                    else return ReadIdentifier();
                case 'g':
                    if (IsNextKeyword("goto")) return new RefToken(TokenType.KeywordGoto, Advance("goto".Length));
                    else return ReadIdentifier();
                case 'i':
                    if (IsNextKeyword("if"))       return new RefToken(TokenType.KeywordIf, Advance("if".Length));
                    else if (IsNextKeyword("int")) return new RefToken(TokenType.KeywordInt, Advance("int".Length));
                    else return ReadIdentifier();
                case 'l':
                    if (IsNextKeyword("long")) return new RefToken(TokenType.KeywordLong, Advance("long".Length));
                    else return ReadIdentifier();
                case 'r':
                    if (IsNextKeyword("register"))    return new RefToken(TokenType.KeywordRegister, Advance("register".Length));
                    else if (IsNextKeyword("return")) return new RefToken(TokenType.KeywordReturn, Advance("return".Length));
                    else return ReadIdentifier();
                case 's':
                    if (IsNextKeyword("short"))       return new RefToken(TokenType.KeywordShort, Advance("short".Length));
                    else if (IsNextKeyword("signed")) return new RefToken(TokenType.KeywordSigned, Advance("signed".Length));
                    else if (IsNextKeyword("sizeof")) return new RefToken(TokenType.KeywordSizeof, Advance("sizeof".Length));
                    else if (IsNextKeyword("static")) return new RefToken(TokenType.KeywordStatic, Advance("static".Length));
                    else if (IsNextKeyword("struct")) return new RefToken(TokenType.KeywordStruct, Advance("struct".Length));
                    else if (IsNextKeyword("switch")) return new RefToken(TokenType.KeywordStruct, Advance("switch".Length));
                    else return ReadIdentifier();
                case 't':
                    if (IsNextKeyword("typedef")) return new RefToken(TokenType.KeywordTypedef, Advance("typedef".Length));
                    else return ReadIdentifier();
                case 'u':
                    if (IsNextKeyword("union"))         return new RefToken(TokenType.KeywordUnion, Advance("union".Length));
                    else if (IsNextKeyword("unsigned")) return new RefToken(TokenType.KeywordUnsigned, Advance("unsigned".Length));
                    else return ReadIdentifier();
                case 'v':
                    if (IsNextKeyword("void"))          return new RefToken(TokenType.KeywordVoid, Advance("void".Length));
                    else if (IsNextKeyword("volatile")) return new RefToken(TokenType.KeywordVolatile, Advance("volatile".Length));
                    else return ReadIdentifier();
                case 'w':
                    if (IsNextKeyword("while"))         return new RefToken(TokenType.KeywordWhile, Advance("while".Length));
                    else if (IsNextKeyword("volatile")) return new RefToken(TokenType.KeywordVolatile, Advance("volatile".Length));
                    else return ReadIdentifier();
                case '"':
                    return ReadStringLiteral();
                case '\'':
                    return ReadCharLiteral();
                case 'L':
                    peek1 = Peek(1);
                    if (peek1 == '"') return ReadStringLiteral();
                    else if (peek1 == '\'') return ReadCharLiteral();
                    else return ReadIdentifier();
                case '\0':
                    return new RefToken(TokenType.EndOfFile, []);
                default:
                    if (char.IsAsciiLetter(peek))
                        return ReadIdentifier();
                    else if (char.IsAsciiDigit(peek))
                        return ReadNumber();
                    else return new RefToken(TokenType.Invalid, "unknown token");
            }
        }

        static readonly SearchValues<char> Delimiters = SearchValues.Create(" ,;:\r\n\t()[]{}-+*/\0");
        private bool IsNextKeyword(string keyword)
        {
            var remainingCode = RemainingCode;
            if (remainingCode.StartsWith(keyword, StringComparison.Ordinal) == false)
                return false;

            if (remainingCode.Length > keyword.Length)
            {
                char val = remainingCode[keyword.Length];
                return Delimiters.Contains(val);
            }
            else return true;
        }

        RefToken ReadIdentifier()
        {
            // Only called when we know the current character is a letter.
            // So we don't need to check that the first character isn't a digit.
            int startOffset = Offset;
            char peek;
            while (char.IsAsciiLetterOrDigit(peek = Peek(0)) || peek == '_')
                Offset++;
            return new RefToken(TokenType.Identifier, Code[startOffset..Offset]);
        }

        static readonly SearchValues<char> FloatDelimiters = SearchValues.Create(".eEfFlL");
        static readonly SearchValues<char> FloatEe = SearchValues.Create("eE");
        static readonly SearchValues<char> SignPrefix = SearchValues.Create("+-");
        static readonly SearchValues<char> FloatPostfix = SearchValues.Create("fFlL");
        static readonly SearchValues<char> IntPostfix = SearchValues.Create("uUlL");
        RefToken ReadNumber()
        {
            // Called when the current character guaranteed is a digit.

            // Figure out what kind of token this is.
            char peek0 = Peek(0);
            char peek1 = Peek(1);

            if (peek0 == '0' && (peek1 == 'x' || peek1 == 'X'))
            {
                return ReadHexNumber();
            }
            else if (peek0 == '0' && char.IsAsciiDigit(peek1))
            {
                return ReadOctalNumber();
            }
            else
            {
                int n = 0;
                while (true)
                {
                    char peek = Peek(n++);
                    if (peek == '\0')
                    {
                        // We've gotten to the end while reading only decimal numbers.
                        return new RefToken(TokenType.ConstantInteger, Advance(n - 1));
                    }
                    else if (char.IsAsciiDigit(peek) == false)
                    {
                        if (Delimiters.Contains(peek))
                        {
                            return new RefToken(TokenType.ConstantInteger, Advance(n - 1));
                        }
                        else if (IntPostfix.Contains(peek))
                        {
                            // Read one more character to see if it's a valid whitespace
                            peek = Peek(n++);
                            if (Delimiters.Contains(peek))
                                return new RefToken(TokenType.ConstantInteger, Advance(n - 1));
                            else
                                return new RefToken(TokenType.Invalid, Advance(n));
                        }
                        else if (FloatDelimiters.Contains(peek))
                        {
                            return ReadFloatingPointNumber();
                        }
                        else
                        {
                            // Invalid number...
                            return new RefToken(TokenType.Invalid, Advance(n));
                        }
                    }
                }
            }
        }

        RefToken ReadHexNumber()
        {
            // Only called when the first two characters are '0x'
            int n = 2;

            while (true)
            {
                char peek = Peek(n++);
                if (peek == '\0')
                {
                    if (n > 3)
                        return new RefToken(TokenType.ConstantHex, Advance(n - 1));
                    else
                        return new RefToken(TokenType.Invalid, Advance(n - 1));
                }
                else if (char.IsAsciiHexDigit(peek) == false)
                {
                    if (Delimiters.Contains(peek))
                    {
                        return new RefToken(TokenType.ConstantHex, Advance(n - 1));
                    }
                    else if (IntPostfix.Contains(peek))
                    {
                        // Read one more character to see if it's a valid whitespace
                        peek = Peek(n++);
                        if (Delimiters.Contains(peek))
                            return new RefToken(TokenType.ConstantHex, Advance(n - 1));
                        else
                            return new RefToken(TokenType.Invalid, Advance(n));
                    }
                    else
                    {
                        return new RefToken(TokenType.Invalid, Advance(n));
                    }
                }
            }
        }

        RefToken ReadOctalNumber()
        {
            // Only called when the first character is '0'
            int n = 1;
            while (true)
            {
                char peek = Peek(n++);
                if (peek == '\0')
                {
                    if (n > 3)
                        return new RefToken(TokenType.ConstantOctal, Advance(n - 1));
                    else
                        return new RefToken(TokenType.Invalid, Advance(n - 1));
                }
                else if (IsAsciiOctalDigit(peek) == false)
                {
                    if (Delimiters.Contains(peek))
                    {
                        return new RefToken(TokenType.ConstantOctal, Advance(n - 1));
                    }
                    else if (IntPostfix.Contains(peek))
                    {
                        // Read one more character to see if it's a valid whitespace
                        peek = Peek(n++);
                        if (Delimiters.Contains(peek))
                            return new RefToken(TokenType.ConstantOctal, Advance(n - 1));
                        else
                            return new RefToken(TokenType.Invalid, Advance(n));
                    }
                    else
                    {
                        return new RefToken(TokenType.Invalid, Advance(n));
                    }
                }
            }

            static bool IsAsciiOctalDigit(char c) => (uint)(c - '0') <= (uint)('7' - '0');
        }

        RefToken ReadFloatingPointNumber()
        {
            int n = 0;
            // "." in D*"."D+([Ee][+-]?D+)?(f|F|l|L)?
            if (Peek(n) == '.')
            {
                n++;
                // D+
                if (char.IsAsciiDigit(Peek(n++)))
                    while (char.IsAsciiDigit(Peek(n))) n++;
                else return new RefToken(TokenType.Invalid, Advance(n));
                // [Ee] in ([Ee][+-]?D+)?
                if (FloatEe.Contains(Peek(n)))
                {
                    n++;
                    // [+-]?
                    if (SignPrefix.Contains(Peek(n))) n++;
                    // D+
                    if (char.IsAsciiDigit(Peek(n++)))
                        while (char.IsAsciiDigit(Peek(n))) n++;
                    else return new RefToken(TokenType.Invalid, Advance(n));
                }

                // (f|F|l|L)?
                if (FloatPostfix.Contains(Peek(n))) n++;

                if (Delimiters.Contains(Peek(n)))
                    return new RefToken(TokenType.ConstantFloat, Advance(n));
                else
                    return new RefToken(TokenType.Invalid, Advance(n));
            }
            else
            {
                // D+
                if (char.IsAsciiDigit(Peek(n++)))
                    while (char.IsAsciiDigit(Peek(n))) n++;
                else return new RefToken(TokenType.Invalid, Advance(n));

                char peek = Peek(n);
                if (peek == '.')
                {
                    n++;

                    // case: D+"."     D*([Ee][+-]?D+)?(f|F|l|L)?

                    // D*
                    while (char.IsAsciiDigit(Peek(n))) n++;

                    // [Ee] in ([Ee][+-]?D+)?
                    if (FloatEe.Contains(Peek(n)))
                    {
                        n++;
                        // [+-]?
                        if (SignPrefix.Contains(Peek(n))) n++;
                        // D+
                        if (char.IsAsciiDigit(Peek(n++)))
                            while (char.IsAsciiDigit(Peek(n))) n++;
                        else return new RefToken(TokenType.Invalid, Advance(n));
                    }

                    // (f|F|l|L)?
                    if (FloatPostfix.Contains(Peek(n))) n++;

                    if (Delimiters.Contains(Peek(n)))
                        return new RefToken(TokenType.ConstantFloat, Advance(n));
                    else
                        return new RefToken(TokenType.Invalid, Advance(n));
                }
                else if (FloatEe.Contains(peek))
                {
                    n++;

                    // case: D+[Ee]     [+-]?D+(f|F|l|L)?

                    // [+-]?
                    if (SignPrefix.Contains(Peek(n))) n++;

                    // D+
                    if (char.IsAsciiDigit(Peek(n++)))
                        while (char.IsAsciiDigit(Peek(n))) n++;
                    else return new RefToken(TokenType.Invalid, Advance(n));

                    // (f|F|l|L)?
                    if (FloatPostfix.Contains(Peek(n))) n++;

                    if (Delimiters.Contains(Peek(n)))
                        return new RefToken(TokenType.ConstantFloat, Advance(n));
                    else
                        return new RefToken(TokenType.Invalid, Advance(n));
                }
                else throw new UnreachableException("This function should not be called if the input stream doesn't match D+(e|E|f|F|l|L).");
            }
        }

        RefToken ReadCharLiteral()
        {
            int startOffset = Offset;
            if (Peek(0) == 'L')
                Offset++;
            if (Peek(0) != '\'')
                return new RefToken(TokenType.Invalid, "character literal needs to start with: '");
            Offset++;

            char peek;
            while ((peek = Peek(0)) != '\'')
            {
                if (peek == '\\')
                    // FIXME: Properly handle escape sequences..
                    Offset++;
                Offset++;
            }

            if (Peek(0) != '\'')
                return new RefToken(TokenType.Invalid, "character literal needs to end with: '");
            Offset++;

            return new RefToken(TokenType.ConstantChar, Code[startOffset..Offset]);
        }

        RefToken ReadStringLiteral()
        {
            int startOffset = Offset;
            if (Peek(0) == 'L')
                Offset++;
            if (Peek(0) != '"')
                return new RefToken(TokenType.Invalid, []);
            Offset++;

            char peek;
            while ((peek = Peek(0)) != '"')
            {
                if (peek == '\\')
                    // FIXME: Properly handle escape sequences..
                    Offset++;
                Offset++;
            }

            if (Peek(0) != '"')
                return new RefToken(TokenType.Invalid, []);
            Offset++;

            return new RefToken(TokenType.StringLiteral, Code[startOffset..Offset]);
        }
    }
}
