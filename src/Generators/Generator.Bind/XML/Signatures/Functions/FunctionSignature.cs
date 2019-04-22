using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Functions
{
    /// <summary>
    /// Represents a function signature in an API.
    /// </summary>
    public class FunctionSignature : INamedExtensionScopedEntity
    {
        /// <inheritdoc />
        public string Name { get; }

        /// <summary>
        /// Gets the name of the native entrypoint of the function. Typically, this is the same name as
        /// <see cref="Name"/>, but may diverge if the name is trimmed at any point to facilitate overloading.
        /// </summary>
        [NotNull]
        public string NativeEntrypoint { get; }

        /// <summary>
        /// Gets the categories the function belongs to.
        /// </summary>
        [NotNull]
        public IReadOnlyList<string> Categories { get; }

        /// <inheritdoc/>
        [NotNull]
        public string Extension { get; }

        /// <summary>
        /// Gets the version the function was introduced in.
        /// </summary>
        [NotNull]
        public Version IntroducedIn { get; }

        /// <summary>
        /// Gets the version that the function was deprecated in.
        /// </summary>
        [CanBeNull]
        public Version DeprecatedIn { get; }

        /// <summary>
        /// Gets the reason the function was deprecated. Typically given via additional annotations in override files.
        /// </summary>
        [CanBeNull]
        public string DeprecationReason { get; }

        /// <summary>
        /// Gets the parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<ParameterSignature> Parameters { get; }

        /// <summary>
        /// Gets the generic type parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<GenericTypeParameterSignature> GenericTypeParameters { get; }

        /// <summary>
        /// Gets the return type of the function.
        /// </summary>
        [NotNull]
        public TypeSignature ReturnType { get; }

        /// <summary>
        /// Gets a value indicating whether the function has generic type parameters.
        /// </summary>
        public bool HasGenericTypeParameters => GenericTypeParameters.Count > 0;

        /// <summary>
        /// Gets a value indicating whether the function is deprecated.
        /// </summary>
        public bool IsDeprecated => !(DeprecatedIn is null);

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="nativeEntrypoint">The name of the native entrypoint of the function.</param>
        /// <param name="categories">The categories the function belongs to.</param>
        /// <param name="extension">The extension the function belongs to.</param>
        /// <param name="introducedIn">The version the function was introduced in.</param>
        /// <param name="returnType">The return type of the function.</param>
        /// <param name="parameters">The parameters the function accepts. Optional.</param>
        /// <param name="deprecatedIn">The version the function was deprecated in, if any.</param>
        /// <param name="deprecationReason">The reason the function was deprecated.</param>
        /// <param name="genericTypeParameters">The generic type parameters in the function, if any.</param>
        public FunctionSignature
        (
            [NotNull] string name,
            [NotNull] string nativeEntrypoint,
            [NotNull] IReadOnlyList<string> categories,
            [NotNull] string extension,
            [NotNull] Version introducedIn,
            [NotNull] TypeSignature returnType,
            [CanBeNull] IReadOnlyList<ParameterSignature> parameters = null,
            [CanBeNull] Version deprecatedIn = null,
            [CanBeNull] string deprecationReason = null,
            [CanBeNull] IReadOnlyList<GenericTypeParameterSignature> genericTypeParameters = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            NativeEntrypoint = nativeEntrypoint;
            Categories = categories ?? throw new ArgumentNullException(nameof(categories));
            Extension = extension ?? throw new ArgumentNullException(nameof(extension));
            IntroducedIn = introducedIn ?? throw new ArgumentNullException(nameof(introducedIn));
            DeprecatedIn = deprecatedIn;
            DeprecationReason = deprecationReason;
            Parameters = parameters ?? new List<ParameterSignature>();
            ReturnType = returnType ?? throw new ArgumentNullException(nameof(returnType));
            GenericTypeParameters = genericTypeParameters ?? new List<GenericTypeParameterSignature>();
        }

        /// <summary>
        /// Determines whether or not the given function has the same signature as this function.
        /// </summary>
        /// <param name="f">The function.</param>
        /// <returns>true if the functions have the same signature; otherwise, false.</returns>
        public bool HasSameSignatureAs([NotNull] FunctionSignature f)
        {
            if (f.ReturnType != ReturnType)
            {
                return false;
            }

            if (f.Name != Name)
            {
                return false;
            }

            if (f.Parameters.Count != Parameters.Count)
            {
                return false;
            }

            for (int i = 0; i < f.Parameters.Count; ++i)
            {
                var otherParameter = f.Parameters[i];
                var thisParameter = Parameters[i];

                if (otherParameter.Type != thisParameter.Type)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{ReturnType} {Name}({string.Join(", ", Parameters)})";
        }
    }
}
