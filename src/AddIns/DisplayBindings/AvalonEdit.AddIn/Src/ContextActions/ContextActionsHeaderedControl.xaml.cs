﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Windows;
using System.Windows.Controls;

namespace ICSharpCode.AvalonEdit.AddIn.ContextActions
{
	/// <summary>
	/// Interaction logic for ContextActionsHeaderedControl.xaml
	/// </summary>
	public partial class ContextActionsHeaderedControl : UserControl
	{		
		public ContextActionsHeaderedControl()
		{
			InitializeComponent();
		}
		
		public event EventHandler ActionExecuted
		{
			add { this.ActionsTreeView.ActionExecuted += value; }
			remove { this.ActionsTreeView.ActionExecuted -= value; }
		}
		
		public event RoutedEventHandler ActionSelected 
		{
			add { this.ActionsTreeView.ActionSelected += value; }
			remove { this.ActionsTreeView.ActionSelected -= value; }
		}
		
		public event RoutedEventHandler ActionUnselected
		{
			add { this.ActionsTreeView.ActionUnselected += value; }
			remove { this.ActionsTreeView.ActionUnselected -= value; }
		}
		
		public new void Focus()
		{
			if (this.ActionsTreeView != null)
				this.ActionsTreeView.Focus();
		}
	}
}
