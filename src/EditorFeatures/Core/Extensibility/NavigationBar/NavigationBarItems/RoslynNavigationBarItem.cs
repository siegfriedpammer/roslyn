﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Editor.Extensibility.NavigationBar
{
    /// <summary>
    /// Base type of all C#/VB navigation bar items.  Only for use internally to roslyn.
    /// </summary>
    internal abstract partial class RoslynNavigationBarItem : NavigationBarItem
    {
        [DataMember(Order = 7)]
        public readonly RoslynNavigationBarItemKind Kind;

        protected RoslynNavigationBarItem(
            RoslynNavigationBarItemKind kind,
            string text,
            Glyph glyph,
            IList<TextSpan> spans,
            IList<NavigationBarItem>? childItems = null,
            int indent = 0,
            bool bolded = false,
            bool grayed = false)
            : base(text, glyph, spans, childItems, indent, bolded, grayed)
        {
            Kind = kind;
        }
    }
}
