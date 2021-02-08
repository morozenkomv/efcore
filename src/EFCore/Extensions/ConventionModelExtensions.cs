﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#nullable enable

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Extension methods for <see cref="IConventionModel" />.
    /// </summary>
    [Obsolete("Use IConventionModel")]
    public static class ConventionModelExtensions
    {
        /// <summary>
        ///     Gets the entity types matching the given name.
        /// </summary>
        /// <param name="model"> The model to find the entity type in. </param>
        /// <param name="name"> The name of the entity type to find. </param>
        /// <returns> The entity types found. </returns>
        [DebuggerStepThrough]
        [Obsolete("Use GetEntityTypes(Type) or FindEntityType(string)")]
        public static IReadOnlyCollection<IConventionEntityType> GetEntityTypes(
            [NotNull] this IConventionModel model,
            [NotNull] string name)
            => ((Model)model).GetEntityTypes(name);
    }
}
