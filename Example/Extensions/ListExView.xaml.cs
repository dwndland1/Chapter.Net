﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="ListExView.xaml.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Example;

public partial class ListExView
{
    public ListExView()
    {
        InitializeComponent();

        DataContext = new ListExViewModel();
    }
}