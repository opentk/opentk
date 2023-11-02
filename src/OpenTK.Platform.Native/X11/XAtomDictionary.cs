using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    internal class XAtomDictionary : IReadOnlyDictionary<string, XAtom>
    {
        private readonly XAtom[] _knownAtoms = new XAtom[(int)KnownAtoms.KNOWN_ATOMS_MAX];
        private readonly Dictionary<string, XAtom> _namedAtoms = new Dictionary<string, XAtom>();

        public XAtom this[string key]
        {
            get
            {
                if (_namedAtoms.TryGetValue(key, out XAtom atom) == false)
                {
                    atom = XInternAtom(X11.Display, key, true);
                    if (atom.IsNone == false)
                    {
                        _namedAtoms.Add(key, atom);
                    }
                }
                return atom;
            }
        }

        public XAtom this[KnownAtoms key] => _knownAtoms[(int)key];

        public IEnumerable<string> Keys => _namedAtoms.Keys;

        public IEnumerable<XAtom> Values => _namedAtoms.Values;

        public int Count => _namedAtoms.Count;

        public XAtomDictionary(XDisplayPtr display)
        {
            for (int i = 0; i < (int)KnownAtoms.KNOWN_ATOMS_MAX; i++)
            {
                string name = ((KnownAtoms)i).ToString();
                XAtom atom = XInternAtom(display, name, true);
                _knownAtoms[i] = atom;
                _namedAtoms.Add(name, atom);
            }
        }

        public XAtom CreateAtom(string name)
        {
            XAtom atom = XInternAtom(X11.Display, name, false);
            _namedAtoms.Add(name, atom);
            return atom;
        }

        public bool ContainsKey(string key)
        {
            if (_namedAtoms.ContainsKey(key))
                return true;

            XAtom atom = XInternAtom(X11.Display, key, true);

            if (atom.IsNone)
                return false;

            _namedAtoms.Add(key, atom);
            return true;
        }

        public IEnumerator<KeyValuePair<string, XAtom>> GetEnumerator()
        {
            return _namedAtoms.GetEnumerator();
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out XAtom value)
        {
            if (_namedAtoms.TryGetValue(key, out value))
                return true;

            XAtom atom = XInternAtom(X11.Display, key, true);

            if (atom.IsNone)
                return false;

            _namedAtoms.Add(key, atom);
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_namedAtoms).GetEnumerator();
        }
    }
}
