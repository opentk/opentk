using System;
using JetBrains.Annotations;

namespace Bind.Writers
{
    /// <summary>
    /// Represents an indentation handle for a level of indentation in a <see cref="SourceWriter"/>. On creation,
    /// this class indents the provided <see cref="SourceWriter"/> by one, and unindents it by one upon disposal.
    /// </summary>
    public class SourceWriterIndentation : IDisposable
    {
        [NotNull]
        private readonly SourceWriter _sourceWriter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceWriterIndentation"/> class.
        /// </summary>
        /// <param name="sourceWriter">The source writer to manage the indentation of.</param>
        public SourceWriterIndentation([NotNull] SourceWriter sourceWriter)
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
