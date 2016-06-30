// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Context;
using Avalonia.Markup.Xaml.Converters;
using Avalonia.Styling;
using Moq;
using OmniXaml;
using OmniXaml.ObjectAssembler.Commands;
using OmniXaml.TypeConversion;
using OmniXaml.Typing;
using System;
using System.Reactive;
using Xunit;

namespace Avalonia.Markup.Xaml.UnitTests.Context
{
    public class AvaloniaNamespaceRegistryTest
    {
        [Fact]
        public void Should_Return_Same_ClrNameSpace()
        {
            string name = "clr-namespace:Avalonia.Markup.Xaml.UnitTests.Context;assembly=Avalonia.Markup.Xaml.UnitTests";

            var target = new AvaloniaNamespaceRegistry();

            var ns1 = target.GetNamespace(name);
            var ns2 = target.GetNamespace(name);

            //AvaloniaNamespaceRegistry should not create new CreateClrNamespace
            //for the same namespace
            Assert.Same(ns1, ns2);
        }
    }
}