//
// Sphere.cs
//
// Copyright (C) 2021 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Mathematics.Geometry {

    /// <summary>
    /// Defines a sphere in 3d space.
    /// </summary>
    public struct Sphere {

        /// <summary>
        /// Center of the sphere.
        /// </summary>
        public Vector3 Origin { get; set; }
        /// <summary>
        /// Radius of the sphere.
        /// </summary>
        public float Radius { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object obj) {
            return obj is Sphere sphere && Equals(sphere);
        }

        /// <inheritdoc/>
        public bool Equals(Sphere other) {
            return Origin.Equals(other.Origin) &&
                Radius == other.Radius;
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            return HashCode.Combine(Origin, Radius);
        }

        /// <inheritdoc/>
        public override string ToString() {
            return $"O:{Origin} R:{Radius}";
        }

    }
}
