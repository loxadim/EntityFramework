// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;

namespace Microsoft.Data.Entity
{
    public interface IEntityConfigurationConstruction
    {
        IModel Model { [param: CanBeNull] set; }
        void AddExtension<TExtension>([NotNull] TExtension configurationExtension) where TExtension : EntityConfigurationExtension;
        void Lock();
    }
}