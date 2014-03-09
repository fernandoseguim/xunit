﻿using System;
using Xunit.Sdk;

namespace Xunit
{
    /// <summary>
    /// Attribute used to decorate a test method with arbitrary name/value pairs ("traits").
    /// </summary>
    [TraitDiscoverer("Xunit.Sdk.TraitDiscoverer", "xunit.execution")]
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public sealed class TraitAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Creates a new instance of the <see cref="TraitAttribute"/> class.
        /// </summary>
        /// <param name="name">The trait name</param>
        /// <param name="value">The trait value</param>
        public TraitAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets the trait name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the trait value.
        /// </summary>
        public string Value { get; private set; }
    }
}