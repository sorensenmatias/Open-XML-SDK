// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a (RelationshipId, OpenXmlPart) pair.
    /// </summary>
    public class IdPartPair
    {
        /// <summary>
        /// Gets the relationship ID in the pair.
        /// </summary>
        public string RelationshipId { get; }

        /// <summary>
        /// Gets the OpenXmlPart in the pair.
        /// </summary>
        public OpenXmlPart OpenXmlPart { get; }

        /// <summary>
        /// Initializes a new instance of the IdPartPair with the specified id and part.
        /// </summary>
        /// <param name="id">The relationship ID.</param>
        /// <param name="part">The OpenXmlPart.</param>
        public IdPartPair(string id, OpenXmlPart part)
        {
            RelationshipId = id;
            OpenXmlPart = part;
        }

        /// <summary>
        /// Determines whether this instance and another specified IdPartPair object have the same value.
        /// </summary>
        /// <param name="value">An IdPartPair.</param>
        /// <returns>True if the value of the value parameter is the same as this instance; otherwise, false.</returns>
        public bool Equals(IdPartPair value)
        {
            if (value is null)
            {
                return false;
            }

            return string.Equals(RelationshipId, value.RelationshipId, StringComparison.Ordinal)
                && OpenXmlPart == OpenXmlPart;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
            => obj is IdPartPair idPart ? Equals(idPart) : false;

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hash = new HashCode();

            hash.Add(RelationshipId, StringComparer.Ordinal);
            hash.Add(OpenXmlPart);

            return hash.ToHashCode();
        }
    }
}
