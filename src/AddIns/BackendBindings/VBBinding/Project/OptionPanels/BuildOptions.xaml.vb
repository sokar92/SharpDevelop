' Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
' This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

Imports System.Collections.Generic
Imports ICSharpCode.SharpDevelop.Gui.OptionPanels
Imports ICSharpCode.SharpDevelop.Project

Namespace OptionPanels
	''' <summary>
	''' Interaction logic for BuildOptionsXaml.xaml
	''' </summary>
	Public Partial Class BuildOptions
		Inherits ProjectOptionPanel
		Public Sub New()
			InitializeComponent()
			DataContext = Me


			m_optionExplicitItems = New List(Of KeyItemPair)()
			m_optionExplicitItems.Add(New KeyItemPair("Off", "Explicit Off"))
			m_optionExplicitItems.Add(New KeyItemPair("On", "Explicit On"))
			OptionExplicitItems = m_optionExplicitItems

			m_optionStrictItems = New List(Of KeyItemPair)()
			m_optionStrictItems.Add(New KeyItemPair("Off", "Strict Off"))
			m_optionStrictItems.Add(New KeyItemPair("On", "Strict On"))
			OptionStrictItems = m_optionStrictItems


			m_optionCompareItems = New List(Of KeyItemPair)()
			m_optionCompareItems.Add(New KeyItemPair("Binary", "Compare Binary"))
			m_optionCompareItems.Add(New KeyItemPair("Text", "Compare Text"))
			OptionCompareItems = m_optionCompareItems

			m_optionInferItems = New List(Of KeyItemPair)()
			m_optionInferItems.Add(New KeyItemPair("Off", "Infer Off"))
			m_optionInferItems.Add(New KeyItemPair("On", "Infer On"))
			OptionInferItems = m_optionInferItems
		End Sub


		Public ReadOnly Property DefineConstants() As ProjectProperty(Of String)
			Get
				Return GetProperty("DefineConstants", "", TextBoxEditMode.EditRawProperty)
			End Get
		End Property

		Public ReadOnly Property Optimize() As ProjectProperty(Of Boolean)
			Get
				Return GetProperty("Optimize", False, PropertyStorageLocations.ConfigurationSpecific)
			End Get
		End Property

		Public ReadOnly Property RemoveIntegerChecks() As ProjectProperty(Of String)
			Get
				Return GetProperty("RemoveIntegerChecks", "", TextBoxEditMode.EditRawProperty)
			End Get
		End Property

		Public ReadOnly Property OptionExplicit() As ProjectProperty(Of String)
			Get
				Return GetProperty("OptionExplicit", "", TextBoxEditMode.EditRawProperty)
			End Get
		End Property

		Public ReadOnly Property OptionStrict() As ProjectProperty(Of String)
			Get
				Return GetProperty("OptionStrict", "Off", TextBoxEditMode.EditRawProperty)
			End Get
		End Property

		Public ReadOnly Property OptionCompare() As ProjectProperty(Of String)
			Get
				Return GetProperty("OptionCompare", "Binary", TextBoxEditMode.EditRawProperty)
			End Get
		End Property

		Public ReadOnly Property OptionInfer() As ProjectProperty(Of String)
			Get
				Return GetProperty("OptionInfer", "Off", TextBoxEditMode.EditRawProperty)
			End Get
		End Property


		#Region "OptionItems"

		Private m_optionExplicitItems As List(Of KeyItemPair)

		Public Property OptionExplicitItems() As List(Of KeyItemPair)
			Get
				Return m_optionExplicitItems
			End Get
			Set
				m_optionExplicitItems = value
				MyBase.RaisePropertyChanged(Function() OptionExplicitItems)
			End Set
		End Property


		Private m_optionStrictItems As List(Of KeyItemPair)

		Public Property OptionStrictItems() As List(Of KeyItemPair)
			Get
				Return m_optionStrictItems
			End Get
			Set
				m_optionStrictItems = value
				MyBase.RaisePropertyChanged(Function() OptionStrictItems)
			End Set
		End Property


		Private m_optionCompareItems As List(Of KeyItemPair)

		Public Property OptionCompareItems() As List(Of KeyItemPair)
			Get
				Return m_optionCompareItems
			End Get
			Set
				m_optionCompareItems = value
				MyBase.RaisePropertyChanged(Function() OptionCompareItems)
			End Set
		End Property


		Private m_optionInferItems As List(Of KeyItemPair)

		Public Property OptionInferItems() As List(Of KeyItemPair)
			Get
				Return m_optionInferItems
			End Get
			Set
				m_optionInferItems = value
				MyBase.RaisePropertyChanged(Function() OptionInferItems)
			End Set
		End Property


		#End Region

		#Region "overrides"


		Protected Overrides Sub Initialize()
			MyBase.Initialize()
			buildOutput.Initialize(Me)
			Me.buildAdvanced.Initialize(Me)
			Me.errorsAndWarnings.Initialize(Me)
			Me.treatErrorsAndWarnings.Initialize(Me)
		End Sub
		#End Region
	End Class
End Namespace
