﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(31, 254)
        Me.labelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(57, 16)
        Me.labelControl2.TabIndex = 12
        Me.labelControl2.Text = "Starting..."
        '
        'labelControl1
        '
        Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelControl1.Location = New System.Drawing.Point(31, 352)
        Me.labelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(135, 16)
        Me.labelControl1.TabIndex = 11
        Me.labelControl1.Text = "Copyright © 2012-2015"
        '
        'marqueeProgressBarControl1
        '
        Me.marqueeProgressBarControl1.EditValue = 0
        Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(31, 284)
        Me.marqueeProgressBarControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
        Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(539, 15)
        Me.marqueeProgressBarControl1.TabIndex = 10
        '
        'pictureEdit2
        '
        Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit2.EditValue = Global.Lexrecmgr.My.Resources.Resources.Lexicon
        Me.pictureEdit2.Location = New System.Drawing.Point(16, 15)
        Me.pictureEdit2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pictureEdit2.Name = "pictureEdit2"
        Me.pictureEdit2.Properties.AllowFocused = False
        Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit2.Properties.ShowMenu = False
        Me.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pictureEdit2.Properties.ZoomPercent = 50.0R
        Me.pictureEdit2.Size = New System.Drawing.Size(568, 222)
        Me.pictureEdit2.TabIndex = 14
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 394)
        Me.Controls.Add(Me.pictureEdit2)
        Me.Controls.Add(Me.labelControl2)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.marqueeProgressBarControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SplashScreen"
        Me.Text = "Form1"
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class
