using System;
using System.Collections.Generic;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Builders
{
    /// <summary>
    /// Acts as a builder for new instances of <see cref="FunctionSignature"/>s, based on existing instances.
    /// </summary>
    public sealed class FunctionSignatureBuilder
    {
        [NotNull]
        private string _newName;

        [NotNull]
        private string _newNativeEntrypoint;

        [NotNull]
        private IReadOnlyList<string> _newCategory;

        [NotNull]
        private string _newExtension;

        [NotNull]
        private Version _newIntroducedIn;

        [CanBeNull]
        private Version _newDeprecatedIn;

        [CanBeNull]
        private string _newDeprecationReason;

        [NotNull]
        private IReadOnlyList<ParameterSignature> _newParameters;

        [NotNull]
        private IReadOnlyList<GenericTypeParameterSignature> _newGenericTypeParameters;

        [NotNull]
        private TypeSignature _newReturnType;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSignatureBuilder"/> class.
        /// </summary>
        /// <param name="functionSignature">The signature.</param>
        public FunctionSignatureBuilder([NotNull] FunctionSignature functionSignature)
        {
            _newName = functionSignature.Name;
            _newNativeEntrypoint = functionSignature.NativeEntrypoint;
            _newCategory = functionSignature.Categories;
            _newExtension = functionSignature.Extension;
            _newIntroducedIn = functionSignature.IntroducedIn;
            _newDeprecatedIn = functionSignature.DeprecatedIn;
            _newDeprecationReason = functionSignature.DeprecationReason;
            _newParameters = functionSignature.Parameters;
            _newReturnType = functionSignature.ReturnType;
            _newGenericTypeParameters = functionSignature.GenericTypeParameters;
        }

        /// <summary>
        /// Sets a new name for the function.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new native entrypoint for the function.
        /// </summary>
        /// <param name="newNativeEntrypoint">The new native entrypoint.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithNativeEntrypoint([NotNull] string newNativeEntrypoint)
        {
            _newNativeEntrypoint = newNativeEntrypoint;
            return this;
        }

        /// <summary>
        /// Sets new categories for the function.
        /// </summary>
        /// <param name="newCategories">The new categories.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithCategories([NotNull] IReadOnlyList<string> newCategories)
        {
            _newCategory = newCategories;
            return this;
        }

        /// <summary>
        /// Sets a new extension for the function.
        /// </summary>
        /// <param name="newExtension">The new extension.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithExtension([NotNull] string newExtension)
        {
            _newExtension = newExtension;
            return this;
        }

        /// <summary>
        /// Sets a new introduced-in version for the function.
        /// </summary>
        /// <param name="newIntroducedIn">The new introduced-in version.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithIntroducedIn([NotNull] Version newIntroducedIn)
        {
            _newIntroducedIn = newIntroducedIn;
            return this;
        }

        /// <summary>
        /// Sets a new deprecated-in version for the function.
        /// </summary>
        /// <param name="newDeprecatedIn">The new deprecated-in version.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithDeprecatedIn(Version newDeprecatedIn)
        {
            _newDeprecatedIn = newDeprecatedIn;
            return this;
        }

        /// <summary>
        /// Sets a new deprecation reason for the function.
        /// </summary>
        /// <param name="newDeprecationReason">The new deprecation reason.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithDeprecationReason(string newDeprecationReason)
        {
            _newDeprecationReason = newDeprecationReason;
            return this;
        }

        /// <summary>
        /// Sets new parameters for the function.
        /// </summary>
        /// <param name="newParameters">The new parameters.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithParameters([NotNull] IReadOnlyList<ParameterSignature> newParameters)
        {
            _newParameters = newParameters;
            return this;
        }

        /// <summary>
        /// Sets new generic type parameters for the function.
        /// </summary>
        /// <param name="newGenericTypeParameters">The new generic type parameters.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithGenericTypeParameters
        (
            [NotNull] IReadOnlyList<GenericTypeParameterSignature> newGenericTypeParameters
        )
        {
            _newGenericTypeParameters = newGenericTypeParameters;
            return this;
        }

        /// <summary>
        /// Sets a new return type for the function.
        /// </summary>
        /// <param name="newReturnType">The new return type.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithReturnType([NotNull] TypeSignature newReturnType)
        {
            _newReturnType = newReturnType;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
        public FunctionSignature Build()
        {
            return new FunctionSignature
            (
                _newName,
                _newNativeEntrypoint,
                _newCategory,
                _newExtension,
                _newIntroducedIn,
                _newReturnType,
                _newParameters,
                _newDeprecatedIn,
                _newDeprecationReason,
                _newGenericTypeParameters
            );
        }
    }
}
