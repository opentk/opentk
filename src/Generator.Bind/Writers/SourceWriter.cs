﻿using System;
using System.CodeDom.Compiler;
using System.IO;

namespace Bind.Writers
{
    /// <summary>
    /// Writer class for writing source code to a file.
    /// </summary>
    public class SourceWriter : IndentedTextWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceWriter"/> class.
        /// </summary>
        /// <param name="writer">The <see cref="TextWriter"/> to wrap.</param>
        public SourceWriter(TextWriter writer)
            : base(writer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceWriter"/> class.
        /// </summary>
        /// <param name="writer">The <see cref="TextWriter"/> to wrap.</param>
        /// <param name="tabString">The string of characters to use as a tabulation sequence.</param>
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
}
