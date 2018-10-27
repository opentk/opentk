using System;
using JetBrains.Annotations;

namespace Bind.Writers
{
    /// <summary>
    /// Represents a block handle for a curly-braces block in a <see cref="SourceWriter"/>. On creation,
    /// this class indents the provided <see cref="SourceWriter"/> by one and writes an opening brace. Upon disposal,
    /// it writes a closing braces and unindents by one.
    /// </summary>
    public struct SourceWriterBlock : IDisposable
    {
        [NotNull]
        private readonly SourceWriter _sourceWriter;

        private readonly bool _withSemicolon;

        [NotNull]
        private readonly SourceWriterIndentation _indentation;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceWriterBlock"/> struct.
        /// </summary>
        /// <param name="sourceWriter">The source writer to manage the block of.</param>
        /// <param name="withSemicolon">Whether or not the closing brace should be terminated with a semicolon.</param>
        public SourceWriterBlock([NotNull] SourceWriter sourceWriter, bool withSemicolon)
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
}
