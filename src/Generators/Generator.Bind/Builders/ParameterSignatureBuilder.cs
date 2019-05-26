//
// ParameterSignatureBuilder.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Builders
{
    /// <summary>
    /// Acts as a builder for new instances of <see cref="ParameterSignature"/>s, based on existing instances.
    /// </summary>
    public class ParameterSignatureBuilder
    {
        [NotNull]
        private string _newName;

        [NotNull]
        private TypeSignature _newType;

        private FlowDirection _newFlow;

        [CanBeNull]
        private CountSignature _newCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterSignatureBuilder"/> class.
        /// </summary>
        /// <param name="parameterSignature">The signature.</param>
        public ParameterSignatureBuilder([NotNull] ParameterSignature parameterSignature)
        {
            _newName = parameterSignature.Name;
            _newType = parameterSignature.Type;
            _newFlow = parameterSignature.Flow;
            _newCount = parameterSignature.Count;
        }

        /// <summary>
        /// Sets a new name for the parameter.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ParameterSignatureBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new type for the parameter.
        /// </summary>
        /// <param name="newType">The new type.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ParameterSignatureBuilder WithType([NotNull] TypeSignature newType)
        {
            _newType = newType;
            return this;
        }

        /// <summary>
        /// Sets a new flow for the parameter.
        /// </summary>
        /// <param name="newFlow">The new flow.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ParameterSignatureBuilder WithFlow(FlowDirection newFlow)
        {
            _newFlow = newFlow;
            return this;
        }

        /// <summary>
        /// Sets a new count for the parameter.
        /// </summary>
        /// <param name="newCount">The new count.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ParameterSignatureBuilder WithCount([CanBeNull] CountSignature newCount)
        {
            _newCount = newCount;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
        public ParameterSignature Build()
        {
            return new ParameterSignature(_newName, _newType, _newFlow, _newCount);
        }
    }
}
