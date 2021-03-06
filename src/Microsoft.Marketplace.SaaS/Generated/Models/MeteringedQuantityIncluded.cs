// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Marketplace.SaaS.Models
{
    /// <summary> The MeteringedQuantityIncluded. </summary>
    public partial class MeteringedQuantityIncluded
    {
        /// <summary> Initializes a new instance of MeteringedQuantityIncluded. </summary>
        internal MeteringedQuantityIncluded()
        {
        }

        /// <summary> Initializes a new instance of MeteringedQuantityIncluded. </summary>
        /// <param name="dimensionId"> . </param>
        /// <param name="units"> . </param>
        internal MeteringedQuantityIncluded(string dimensionId, string units)
        {
            DimensionId = dimensionId;
            Units = units;
        }

        public string DimensionId { get; }
        public string Units { get; }
    }
}
