using System;
using System.CodeDom.Compiler;
using System.IO;

namespace Bind.Writers
{
    /// <summary>
    /// Writer class for writing source code to a file.
    /// </summary>
    public class SourceWriter : IndentedTextWriter
    {
        /// <inheritdoc />
        public SourceWriter(TextWriter writer)
            : base(writer)
        {
        }

        /// <inheritdoc />
        public SourceWriter(TextWriter writer, string tabString)
            : base(writer, tabString)
        {
        }

        /// <summary>
        /// Writes an unindented line to the document.
        /// </summary>
        public void WriteLineNoTabs()
        {
            WriteLineNoTabs(string.Empty);
        }

        /// <summary>
        /// Indents the <see cref="SourceWriter"/> by one, and returns a handle that can be disposed to unindent the
        /// writer once the writing has been finished.
        /// </summary>
        /// <returns>An indentation handle.</returns>
        public SourceWriterIndentation BeginIndent()
        {
            return new SourceWriterIndentation(this);
        }

        /// <summary>
        /// Indents the <see cref="SourceWriter"/> by one, writes an opening brace, and returns a handle that can be
        /// disposed to unindent and close the block once writing has been finished.
        /// </summary>
        /// <param name="withSemicolon">Whether or not the closing brace should be terminated with a semicolon.</param>
        /// <returns>An indentation handle.</returns>
        public SourceWriterBlock BeginBlock(bool withSemicolon = false)
        {
            return new SourceWriterBlock(this, withSemicolon);
        }

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            Flush();
        }
    }

    /// <summary>
    /// Represents a block handle for a curly-braces block in a <see cref="SourceWriter"/>. On creation,
    /// this class indents the provided <see cref="SourceWriter"/> by one and writes an opening brace. Upon disposal,
    /// it writes a closing braces and unindents by one.
    /// </summary>
    public class SourceWriterBlock : IDisposable
    {
        private readonly SourceWriter _sourceWriter;
        private readonly bool _withSemicolon;
        private readonly SourceWriterIndentation _indentation;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceWriterBlock"/> class.
        /// </summary>
        /// <param name="sourceWriter">The source writer to manage the block of.</param>
        /// <param name="withSemicolon">Whether or not the closing brace should be terminated with a semicolon.</param>
        public SourceWriterBlock(SourceWriter sourceWriter, bool withSemicolon)
        {
            _sourceWriter = sourceWriter;
            _withSemicolon = withSemicolon;

            _sourceWriter.WriteLine("{");
            _indentation = _sourceWriter.BeginIndent();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _indentation.Dispose();

            if (_withSemicolon)
            {
                _sourceWriter.WriteLine("};");
            }
            else
            {
                _sourceWriter.WriteLine("}");
            }
        }
    }

    /// <summary>
    /// Represents an indentation handle for a level of indentation in an <see cref="SourceWriter"/>. On creation,
    /// this class indents the provided <see cref="SourceWriter"/> by one, and unindents it by one upon disposal.
    /// </summary>
    public class SourceWriterIndentation : IDisposable
    {
        private readonly SourceWriter _sourceWriter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceWriterIndentation"/> class.
        /// </summary>
        /// <param name="sourceWriter">The source writer to manage the indentation of.</param>
        public SourceWriterIndentation(SourceWriter sourceWriter)
        {
            _sourceWriter = sourceWriter;

            _sourceWriter.Indent++;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _sourceWriter.Indent--;
        }
    }
}
