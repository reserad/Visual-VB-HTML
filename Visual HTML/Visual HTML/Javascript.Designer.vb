<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Javascript
    Inherits System.Windows.Forms.Form

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
        Me.btnCancelJavascript = New System.Windows.Forms.Button()
        Me.btnSaveJavascript = New System.Windows.Forms.Button()
        Me.cbInput = New System.Windows.Forms.ComboBox()
        Me.LBViewScript = New System.Windows.Forms.ListBox()
        Me.lblViewScript = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMakeVar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelJavascript
        '
        Me.btnCancelJavascript.Location = New System.Drawing.Point(109, 12)
        Me.btnCancelJavascript.Name = "btnCancelJavascript"
        Me.btnCancelJavascript.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelJavascript.TabIndex = 0
        Me.btnCancelJavascript.Text = "Close"
        Me.btnCancelJavascript.UseVisualStyleBackColor = True
        '
        'btnSaveJavascript
        '
        Me.btnSaveJavascript.Location = New System.Drawing.Point(12, 12)
        Me.btnSaveJavascript.Name = "btnSaveJavascript"
        Me.btnSaveJavascript.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveJavascript.TabIndex = 1
        Me.btnSaveJavascript.Text = "Save"
        Me.btnSaveJavascript.UseVisualStyleBackColor = True
        '
        'cbInput
        '
        Me.cbInput.FormattingEnabled = True
        Me.cbInput.Location = New System.Drawing.Point(6, 19)
        Me.cbInput.Name = "cbInput"
        Me.cbInput.Size = New System.Drawing.Size(121, 21)
        Me.cbInput.TabIndex = 2
        Me.cbInput.Text = "Select input..."
        '
        'LBViewScript
        '
        Me.LBViewScript.FormattingEnabled = True
        Me.LBViewScript.Location = New System.Drawing.Point(437, 62)
        Me.LBViewScript.Name = "LBViewScript"
        Me.LBViewScript.Size = New System.Drawing.Size(400, 472)
        Me.LBViewScript.TabIndex = 15
        '
        'lblViewScript
        '
        Me.lblViewScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewScript.Location = New System.Drawing.Point(22, 62)
        Me.lblViewScript.Multiline = True
        Me.lblViewScript.Name = "lblViewScript"
        Me.lblViewScript.Size = New System.Drawing.Size(400, 475)
        Me.lblViewScript.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMakeVar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbInput)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 557)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 137)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coding"
        '
        'btnMakeVar
        '
        Me.btnMakeVar.Location = New System.Drawing.Point(6, 46)
        Me.btnMakeVar.Name = "btnMakeVar"
        Me.btnMakeVar.Size = New System.Drawing.Size(89, 23)
        Me.btnMakeVar.TabIndex = 4
        Me.btnMakeVar.Text = "Make Variable"
        Me.btnMakeVar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Do"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Javascript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 862)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBViewScript)
        Me.Controls.Add(Me.lblViewScript)
        Me.Controls.Add(Me.btnSaveJavascript)
        Me.Controls.Add(Me.btnCancelJavascript)
        Me.Name = "Javascript"
        Me.Text = "Javascript"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelJavascript As System.Windows.Forms.Button
    Friend WithEvents btnSaveJavascript As System.Windows.Forms.Button
    Friend WithEvents cbInput As System.Windows.Forms.ComboBox
    Friend WithEvents LBViewScript As System.Windows.Forms.ListBox
    Friend WithEvents lblViewScript As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnMakeVar As System.Windows.Forms.Button
End Class
