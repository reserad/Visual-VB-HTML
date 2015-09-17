<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSS))
        Me.lblViewCSS = New System.Windows.Forms.TextBox()
        Me.btnNewCSSstyle = New System.Windows.Forms.Button()
        Me.btnLoadCSS = New System.Windows.Forms.Button()
        Me.btnExitCSS = New System.Windows.Forms.Button()
        Me.btnSaveCSS = New System.Windows.Forms.Button()
        Me.cbProperties = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblViewCSS
        '
        Me.lblViewCSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViewCSS.Location = New System.Drawing.Point(22, 62)
        Me.lblViewCSS.Multiline = True
        Me.lblViewCSS.Name = "lblViewCSS"
        Me.lblViewCSS.Size = New System.Drawing.Size(400, 475)
        Me.lblViewCSS.TabIndex = 15
        '
        'btnNewCSSstyle
        '
        Me.btnNewCSSstyle.Location = New System.Drawing.Point(22, 18)
        Me.btnNewCSSstyle.Name = "btnNewCSSstyle"
        Me.btnNewCSSstyle.Size = New System.Drawing.Size(101, 23)
        Me.btnNewCSSstyle.TabIndex = 16
        Me.btnNewCSSstyle.Text = "New Style Sheet"
        Me.btnNewCSSstyle.UseVisualStyleBackColor = True
        '
        'btnLoadCSS
        '
        Me.btnLoadCSS.Location = New System.Drawing.Point(155, 18)
        Me.btnLoadCSS.Name = "btnLoadCSS"
        Me.btnLoadCSS.Size = New System.Drawing.Size(92, 23)
        Me.btnLoadCSS.TabIndex = 17
        Me.btnLoadCSS.Text = "Load Existing"
        Me.btnLoadCSS.UseVisualStyleBackColor = True
        '
        'btnExitCSS
        '
        Me.btnExitCSS.Location = New System.Drawing.Point(384, 18)
        Me.btnExitCSS.Name = "btnExitCSS"
        Me.btnExitCSS.Size = New System.Drawing.Size(92, 23)
        Me.btnExitCSS.TabIndex = 18
        Me.btnExitCSS.Text = "Back"
        Me.btnExitCSS.UseVisualStyleBackColor = True
        '
        'btnSaveCSS
        '
        Me.btnSaveCSS.Location = New System.Drawing.Point(277, 18)
        Me.btnSaveCSS.Name = "btnSaveCSS"
        Me.btnSaveCSS.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCSS.TabIndex = 19
        Me.btnSaveCSS.Text = "Save"
        Me.btnSaveCSS.UseVisualStyleBackColor = True
        '
        'cbProperties
        '
        Me.cbProperties.FormattingEnabled = True
        Me.cbProperties.Items.AddRange(New Object() {"body", "h1", "h2", "h3", "p"})
        Me.cbProperties.Location = New System.Drawing.Point(557, 210)
        Me.cbProperties.Name = "cbProperties"
        Me.cbProperties.Size = New System.Drawing.Size(121, 21)
        Me.cbProperties.TabIndex = 20
        Me.cbProperties.Text = "Properties"
        '
        'CSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 862)
        Me.Controls.Add(Me.cbProperties)
        Me.Controls.Add(Me.btnSaveCSS)
        Me.Controls.Add(Me.btnExitCSS)
        Me.Controls.Add(Me.btnLoadCSS)
        Me.Controls.Add(Me.btnNewCSSstyle)
        Me.Controls.Add(Me.lblViewCSS)
        Me.Name = "CSS"
        Me.Text = "CSS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblViewCSS As System.Windows.Forms.TextBox
    Friend WithEvents btnNewCSSstyle As System.Windows.Forms.Button
    Friend WithEvents btnLoadCSS As System.Windows.Forms.Button
    Friend WithEvents btnExitCSS As System.Windows.Forms.Button
    Friend WithEvents btnSaveCSS As System.Windows.Forms.Button
    Friend WithEvents cbProperties As System.Windows.Forms.ComboBox
End Class
