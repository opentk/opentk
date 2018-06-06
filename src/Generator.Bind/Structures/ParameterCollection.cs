using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    internal class ParameterCollection : IList<ParameterDefinition>, IComparable<ParameterCollection>, IEquatable<ParameterCollection>
    {
        private readonly List<ParameterDefinition> _parameters = new List<ParameterDefinition>();

        private bool _hasPointerParameters;
        private bool _hasReferenceParameters;
        private bool _hasUnsignedParameters;
        private bool _hasGenericParameters;

        public bool Rebuild { get; set; }

        public ParameterCollection()
        {
        }

        public ParameterCollection(ParameterCollection pc)
        {
            foreach (var p in pc)
            {
                Add(new ParameterDefinition(p));
            }
        }

        private void BuildCache()
        {
            BuildReferenceAndPointerParametersCache();
            Rebuild = false;
        }

        public bool HasUnsignedParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return _hasUnsignedParameters;
            }
        }

        public bool HasGenericParameters
        {
            get
            {
                if (Rebuild)
                {
                    BuildCache();
                }

                return _hasGenericParameters;
            }
        }


        private void BuildReferenceAndPointerParametersCache()
        {
            foreach (var p in this)
            {
                if (p.Pointer != 0 || p.CurrentType.Contains("IntPtr"))
                {
                    _hasPointerParameters = true;
                }

                if (p.Reference)
                {
                    _hasReferenceParameters = true;
                }

                if (p.Unsigned)
                {
                    _hasUnsignedParameters = true;
                }

                if (p.Generic)
                {
                    _hasGenericParameters = true;
                }
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("(");
            if (Count > 0)
            {
                foreach (var p in this)
                {
                    sb.Append(p);
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
            {
                sb.Append(")");
            }

            return sb.ToString();
        }

        /// <inheritdoc/>
        public void Add(ParameterDefinition p)
        {
            _parameters.Add(p);
            Rebuild = true;
        }

        /// <inheritdoc/>
        public void Clear()
        {
            _parameters.Clear();
            Rebuild = true;
        }

        /// <inheritdoc/>
        public bool Contains(ParameterDefinition item)
        {
            return _parameters.Contains(item);
        }

        /// <inheritdoc/>
        public void CopyTo(ParameterDefinition[] array, int arrayIndex)
        {
            _parameters.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc/>
        public int Count => _parameters.Count;

        /// <inheritdoc/>
        public bool IsReadOnly => (_parameters as ICollection<ParameterDefinition>).IsReadOnly;

        /// <inheritdoc/>
        public bool Remove(ParameterDefinition item)
        {
            var result = _parameters.Remove(item);
            if (result)
            {
                Rebuild = true;
            }
            return result;
        }

        /// <inheritdoc/>
        public IEnumerator<ParameterDefinition> GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        /// <inheritdoc/>
        public int IndexOf(ParameterDefinition item)
        {
            return _parameters.IndexOf(item);
        }

        /// <inheritdoc/>
        public void Insert(int index, ParameterDefinition item)
        {
            _parameters.Insert(index, item);
            Rebuild = true;
        }

        /// <inheritdoc/>
        public void RemoveAt(int index)
        {
            _parameters.RemoveAt(index);
            Rebuild = true;
        }

        /// <inheritdoc/>
        public ParameterDefinition this[int index]
        {
            get => _parameters[index];
            set => _parameters[index] = value;
        }

        /// <inheritdoc/>
        public int CompareTo(ParameterCollection other)
        {
            if (Count < other.Count)
            {
                return -1;
            }

            if (Count > other.Count)
            {
                return 1;
            }

            for (var i = 0; i < Count; i++)
            {
                var result = this[i].CompareTo(other[i]);
                if (result != 0)
                {
                    return result;
                }
            }
            return 0;
        }

        /// <inheritdoc/>
        public bool Equals(ParameterCollection other)
        {
            if (Count != other.Count)
            {
                return false;
            }

            var result = true;
            for (var i = 0; i < Count && result; i++)
            {
                result &= this[i].Equals(other[i]);
            }
            return result;
        }
    }
}
