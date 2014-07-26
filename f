[33mcommit 67b9517fc44be0f0f20ef726270dbdda5996f0ee[m
Author: Collin <collin@adnetindo.com>
Date:   Sat Jul 26 18:24:06 2014 +0700

    first upload

[1mdiff --git a/Backend/WindowsApplication1.sln b/Backend/WindowsApplication1.sln[m
[1mnew file mode 100644[m
[1mindex 0000000..2dae281[m
[1m--- /dev/null[m
[1m+++ b/Backend/WindowsApplication1.sln[m
[36m@@ -0,0 +1,20 @@[m
[32m+[m[32m﻿[m
[32m+[m[32mMicrosoft Visual Studio Solution File, Format Version 10.00[m
[32m+[m[32m# Visual Studio 2008[m
[32m+[m[32mProject("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "TokoMadjuBackend", "WindowsApplication1\TokoMadjuBackend.vbproj", "{99067F12-C7D4-4584-9BD5-CD742132C639}"[m
[32m+[m[32mEndProject[m
[32m+[m[32mGlobal[m
[32m+[m	[32mGlobalSection(SolutionConfigurationPlatforms) = preSolution[m
[32m+[m		[32mDebug|Any CPU = Debug|Any CPU[m
[32m+[m		[32mRelease|Any CPU = Release|Any CPU[m
[32m+[m	[32mEndGlobalSection[m
[32m+[m	[32mGlobalSection(ProjectConfigurationPlatforms) = postSolution[m
[32m+[m		[32m{99067F12-C7D4-4584-9BD5-CD742132C639}.Debug|Any CPU.ActiveCfg = Debug|Any CPU[m
[32m+[m		[32m{99067F12-C7D4-4584-9BD5-CD742132C639}.Debug|Any CPU.Build.0 = Debug|Any CPU[m
[32m+[m		[32m{99067F12-C7D4-4584-9BD5-CD742132C639}.Release|Any CPU.ActiveCfg = Release|Any CPU[m
[32m+[m		[32m{99067F12-C7D4-4584-9BD5-CD742132C639}.Release|Any CPU.Build.0 = Release|Any CPU[m
[32m+[m	[32mEndGlobalSection[m
[32m+[m	[32mGlobalSection(SolutionProperties) = preSolution[m
[32m+[m		[32mHideSolutionNode = FALSE[m
[32m+[m	[32mEndGlobalSection[m
[32m+[m[32mEndGlobal[m
[1mdiff --git a/Backend/WindowsApplication1.suo b/Backend/WindowsApplication1.suo[m
[1mnew file mode 100644[m
[1mindex 0000000..779bfb0[m
Binary files /dev/null and b/Backend/WindowsApplication1.suo differ
[1mdiff --git a/Backend/WindowsApplication1/Class/clsCombo.vb b/Backend/WindowsApplication1/Class/clsCombo.vb[m
[1mnew file mode 100644[m
[1mindex 0000000..03c2e0d[m
[1m--- /dev/null[m
[1m+++ b/Backend/WindowsApplication1/Class/clsCombo.vb[m
[36m@@ -0,0 +1,21 @@[m
[32m+[m[32m﻿Public Class clsCombo[m
[32m+[m[32m    Public Property code() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_code[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_code = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_code As String[m
[32m+[m
[32m+[m[32m    Public Property name() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_name[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_name = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_name As String[m
[32m+[m[32mEnd Class[m
[1mdiff --git a/Backend/WindowsApplication1/Class/clsReport.vb b/Backend/WindowsApplication1/Class/clsReport.vb[m
[1mnew file mode 100644[m
[1mindex 0000000..dc99074[m
[1m--- /dev/null[m
[1m+++ b/Backend/WindowsApplication1/Class/clsReport.vb[m
[36m@@ -0,0 +1,293 @@[m
[32m+[m[32m﻿Public Class clsReport[m
[32m+[m[32m    Public Property f1() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f1[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f1 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f1 As String[m
[32m+[m
[32m+[m[32m    Public Property f2() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f2[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f2 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f2 As String[m
[32m+[m
[32m+[m[32m    Public Property f3() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f3[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f3 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f3 As String[m
[32m+[m
[32m+[m[32m    Public Property f4() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f4[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f4 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f4 As String[m
[32m+[m
[32m+[m[32m    Public Property f5() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f5[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f5 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f5 As String[m
[32m+[m
[32m+[m[32m    Public Property f6() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f6[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f6 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f6 As String[m
[32m+[m
[32m+[m[32m    Public Property f7() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f7[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f7 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f7 As String[m
[32m+[m
[32m+[m[32m    Public Property f8() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f8[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f8 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f8 As String[m
[32m+[m
[32m+[m[32m    Public Property f9() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f9[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f9 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f9 As String[m
[32m+[m
[32m+[m[32m    Public Property f10() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f10[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f10 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f10 As String[m
[32m+[m
[32m+[m[32m    Public Property f11() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f11[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f11 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f11 As String[m
[32m+[m
[32m+[m[32m    Public Property f12() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f12[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f12 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f12 As String[m
[32m+[m
[32m+[m[32m    Public Property f13() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f13[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f13 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f13 As String[m
[32m+[m
[32m+[m[32m    Public Property f14() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f14[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f14 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f14 As String[m
[32m+[m
[32m+[m[32m    Public Property f15() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f15[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f15 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f15 As String[m
[32m+[m
[32m+[m[32m    Public Property f16() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f16[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f16 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f16 As String[m
[32m+[m
[32m+[m[32m    Public Property f17() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f17[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f17 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f17 As String[m
[32m+[m
[32m+[m[32m    Public Property f18() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f18[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f18 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f18 As String[m
[32m+[m
[32m+[m[32m    Public Property f19() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f19[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f19 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f19 As String[m
[32m+[m
[32m+[m[32m    Public Property f20() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f20[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f20 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f20 As String[m
[32m+[m
[32m+[m[32m    Public Property f21() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f21[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f21 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f21 As String[m
[32m+[m
[32m+[m[32m    Public Property f22() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f22[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f22 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f22 As String[m
[32m+[m
[32m+[m[32m    Public Property f23() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f23[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f23 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f23 As String[m
[32m+[m
[32m+[m[32m    Public Property f24() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f24[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f24 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f24 As String[m
[32m+[m
[32m+[m[32m    Public Property f25() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_f25[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_f25 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_f25 As String[m
[32m+[m
[32m+[m[32m    Public Property a1() As Long[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_a1[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As Long)[m
[32m+[m[32m            m_a1 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_a1 As Long[m
[32m+[m
[32m+[m[32m    Public Property a2() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_a2[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_a2 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_a2 As String[m
[32m+[m
[32m+[m[32m    Public Property a3() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_a3[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_a3 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_a3 As String[m
[32m+[m
[32m+[m[32m    Public Property a4() As String[m
[32m+[m[32m        Get[m
[32m+[m[32m            Return m_a4[m
[32m+[m[32m        End Get[m
[32m+[m[32m        Set(ByVal value As String)[m
[32m+[m[32m            m_a4 = value[m
[32m+[m[32m        End Set[m
[32m+[m[32m    End Property[m
[32m+[m[32m    Private m_a4 As String[m
[32m+[m
[32m+[m
[32m+[m[32mEnd Class[m
[1mdiff --git a/Backend/WindowsApplication1/Master/frmBank.designer.vb b/Backend/WindowsApplication1/Master/frmBank.designer.vb[m
[1mnew file mode 100644[m
[1mindex 0000000..4b57ce5[m
[1m--- /dev/null[m
[1m+++ b/Backend/WindowsApplication1/Master/frmBank.designer.vb[m
[36m@@ -0,0 +1,200 @@[m
[32m+[m[32m<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _[m
[32m+[m[32mPartial Class frmBank[m
[32m+[m[32m    Inherits DevComponents.DotNetBar.Office2007Form[m
[32m+[m
[32m+[m[32m    'Form overrides dispose to clean up the component list.[m
[32m+[m[32m    <System.Diagnostics.DebuggerNonUserCode()> _[m
[32m+[m[32m    Protected Overrides Sub Dispose(ByVal disposing As Boolean)[m
[32m+[m[32m        Try[m
[32m+[m[32m            If disposing AndAlso components IsNot Nothing Then[m
[32m+[m[32m                components.Dispose()[m
[32m+[m[32m            End If[m
[32m+[m[32m        Finally[m
[32m+[m[32m            MyBase.Dispose(disposing)[m
[32m+[m[32m        End Try[m
[32m+[m[32m    End Sub[m
[32m+[m
[32m+[m[32m    'Required by the Windows Form Designer[m
[32m+[m[32m    Private components As System.ComponentModel.IContainer[m
[32m+[m
[32m+[m[32m    'NOTE: The following procedure is required by the Windows Form Designer[m
[32m+[m[32m    'It can be modified using the Windows Form Designer.[m[41m  [m
[32m+[m[32m    'Do not modify it using the code editor.[m
[32m+[m[32m    <System.Diagnostics.DebuggerStepThrough()> _[m
[32m+[m[32m    Private Sub InitializeComponent()[m
[32m+[m[32m        Me.components = New System.ComponentModel.Container[m
[32m+[m[32m        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBank))[m
[32m+[m[32m        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)[m
[32m+[m[32m        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel[m
[32m+[m[32m        Me.LabelX1 = New DevComponents.DotNetBar.LabelX[m
[32m+[m[32m        Me.t1 = New DevComponents.DotNetBar.Controls.TextBoxX[m
[32m+[m[32m        Me.LabelX2 = New DevComponents.DotNetBar.LabelX[m
[32m+[m[32m        Me.t2 = New 