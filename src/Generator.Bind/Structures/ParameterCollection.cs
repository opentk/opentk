using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    internal class ParameterCollection : IList<ParameterDefinition>, IComparable<ParameterCollection>, IEquatable<ParameterCollection>, IDeclarable
    {
        private readonly List<ParameterDefinition> _parameters = new List<ParameterDefinition>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterCollection"/> class.
        /// </summary>
        public ParameterCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterCollection"/> class.
        /// </summary>
        /// <param name="pc">The existing <see cref="ParameterCollection"/> to copy from.</param>
        public ParameterCollection(ParameterCollection pc)
        {
            foreach (var p in pc)
            {
                Add(new ParameterDefinition(p));
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
        public string GetDeclarationString()
        {
            var sb = new StringBuilder();

            sb.Append("(");
            if (Count > 0)
            {
                foreach (var p in this)
                {
                    sb.Append(p.GetDeclarationString());
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
        }

        /// <inheritdoc/>
        public void Clear()
        {
            _parameters.Clear();
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
            return _parameters.Remove(item);
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
        }

        /// <inheritdoc/>
        public void RemoveAt(int index)
        {
            _parameters.RemoveAt(index);
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
