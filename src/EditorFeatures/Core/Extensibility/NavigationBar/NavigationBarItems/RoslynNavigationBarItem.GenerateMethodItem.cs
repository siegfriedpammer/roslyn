﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace Microsoft.CodeAnalysis.Editor.Extensibility.NavigationBar
{
    internal abstract partial class RoslynNavigationBarItem
    {
        public class GenerateMethod : AbstractGenerateCodeItem
        {
            [DataMember(Order = 9)]
            public readonly SymbolKey MethodToReplicateSymbolKey;

            public GenerateMethod(string text, Glyph glyph, SymbolKey destinationTypeSymbolId, SymbolKey methodToReplicateSymbolId)
                : base(RoslynNavigationBarItemKind.GenerateMethod, text, glyph, destinationTypeSymbolId)
            {
                MethodToReplicateSymbolKey = methodToReplicateSymbolId;
            }
        }
    }
}
