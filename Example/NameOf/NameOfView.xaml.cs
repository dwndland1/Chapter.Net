﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="NameOfView.xaml.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using Example.NameOfNamespace;

// ReSharper disable once CheckNamespace

namespace Example;

public partial class NameOfView
{
    public NameOfView()
    {
        InitializeComponent();

        DataContext = new NameOfViewModel();
    }
}