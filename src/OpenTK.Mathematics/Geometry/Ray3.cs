//
// Ray.cs
//
// Copyright (C) 2021 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//


using System;
using System.Diagnostics.Contracts;

namespace OpenTK.Mathematics.Geometry {

    /// <summary>
    /// Defines a ray in 3d space.
    /// </summary>
    public struct Ray3 {

        /// <summary>
        /// Starting point of the ray.
        /// </summary>
        public Vector3 Origin { get; set; }

        private Vector3 _direction { get; set; }

        /// <summary>
        /// Direction of the ray.
        /// </summary>
        public Vector3 Direction {
            get => _direction;
            set => _direction = value.Normalized();
        }


        /// <inheritdoc/>
        public override bool Equals(object obj) {
            return obj is Ray3 ray && Equals(ray);
        }

        /// <inheritdoc/>
        public bool Equals(Ray3 other) {
            return Origin.Equals(other.Origin) &&
                Direction.Equals(other.Direction);
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            return HashCode.Combine(Origin, Direction);
        }

        /// <inheritdoc/>
        public override string ToString() {
            return $"{Origin} -> {Direction}";
        }

        /// <param name="ray">The ray.</param>
        /// <param name="distance">The distance to travel along the ray.</param>
        /// <returns>The point <paramref name="distance"/> units along the ray. </returns>
        [Pure]
        public Vector3 GetPoint(float distance) {
            return GetPoint(in this, distance);
        }

        /// <summary>
        /// Get the closest point along the ray to a vector, with optional range clamping.
        /// </summary>
        /// <param name="ray">The ray</param>
        /// <param name="vector">The vector</param>
        /// <param name="nearClamp">Near clamp</param>
        /// <param name="farClamp">Far clamp</param>
        /// <returns>The closest point to the <paramref name="vector"/> along the <paramref name="ray"/>, within the clamped range.</returns>
        [Pure]
        public Vector3 GetClosestPoint(in Vector3 vector, float nearClamp = 0, float farClamp = float.PositiveInfinity) {
            return GetClosestPoint(in this, in vector, nearClamp, farClamp);
        }

        /// <param name="ray">The ray.</param>
        /// <param name="distance">The distance to travel along the ray.</param>
        /// <returns>The point <paramref name="distance"/> units along the ray. </returns>
        public static Vector3 GetPoint(in Ray3 ray, float distance) {
            return ray.Origin + ray.Direction * distance;
        }

        /// <summary>
        /// Get the closest point along the ray to a vector, with optional range clamping.
        /// </summary>
        /// <param name="ray">The ray</param>
        /// <param name="vector">The vector</param>
        /// <param name="nearClamp">Near clamp</param>
        /// <param name="farClamp">Far clamp</param>
        /// <returns>The closest point to the <paramref name="vector"/> along the <paramref name="ray"/>, within the clamped range.</returns>
        public static Vector3 GetClosestPoint(in Ray3 ray, in Vector3 vector, float nearClamp = 0, float farClamp = float.PositiveInfinity) {
            (nearClamp, farClamp) = (Math.Min(nearClamp, farClamp), Math.Max(nearClamp, farClamp));
            float scalar = Vector3.Dot(vector - ray.Origin, ray.Direction);
            scalar = Math.Clamp(scalar, nearClamp, farClamp);
            return GetPoint(in ray, scalar);
        }

        /// <summary>
        /// Checks if a ray overlaps a sphere.
        /// </summary>
        /// <param name="ray">The ray to test.</param>
        /// <param name="sphere">The sphere to test.</param>
        /// <param name="hit">The nearest hit location, if applicable.</param>
        /// <param name="nearClamp">Distance to clamp the line on the near side. Defaults to 0 to avoid objects behind the origin from being included. Set to float.NegativeInfinity to simulate a regular line.</param>
        /// <param name="farClamp">Distance to clamp the line to the far side. Sets the max length of the ray for the intersection query.</param>
        /// <returns></returns>
        public static bool Intersects(in Ray3 ray, in Sphere sphere, out Vector3 hit, float nearClamp = 0, float farClamp = float.PositiveInfinity) {
            hit = Vector3.Zero;

            bool intersected = Intersects(in ray, in sphere, out float t);

            if(intersected && nearClamp < t && t < farClamp) {
                hit = GetPoint(in ray, t);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if a ray overlaps a sphere.
        /// </summary>
        /// <param name="ray">The ray to test.</param>
        /// <param name="sphere">The sphere to test.</param>
        /// <param name="t">The distance alone the ray the intersection occured.</param>
        /// <returns></returns>
        public static bool Intersects(in Ray3 ray, in Sphere sphere, out float t) {
            t = 0;
            float scalar = Vector3.Dot(sphere.Origin - ray.Origin, ray.Direction);
            Vector3 closestPoint = GetPoint(in ray, scalar);
            float distanceSquared = Vector3.DistanceSquared(closestPoint, sphere.Origin);
            float radiusSquared = sphere.Radius * sphere.Radius;
            if (distanceSquared < radiusSquared) {
                t = scalar - (float) Math.Sqrt(Math.Abs(radiusSquared - distanceSquared));
                return true;
            }
            return false;
        }

    }
}
