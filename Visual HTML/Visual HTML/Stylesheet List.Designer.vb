<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stylesheet_List
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
        Me.CBexistingStyles = New System.Windows.Forms.ComboBox()
        Me.btnAddexistingStyle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBexistingStyles
        '
        Me.CBexistingStyles.FormattingEnabled = True
        Me.CBexistingStyles.Location = New System.Drawing.Point(12, 12)
        Me.CBexistingStyles.Name = "CBexistingStyles"
        Me.CBexistingStyles.Size = New System.Drawing.Size(121, 21)
        Me.CBexistingStyles.TabIndex = 2
        '
        'btnAddexistingStyle
        '
        Me.btnAddexistingStyle.Location = New System.Drawing.Point(177, 12)
        Me.btnAddexistingStyle.Name = "btnAddexistingStyle"
        Me.btnAddexistingStyle.Size = New System.Drawing.Size(75, 23)
        Me.btnAddexistingStyle.TabIndex = 3
        Me.btnAddexistingStyle.Text = "Add"
        Me.btnAddexistingStyle.UseVisualStyleBackColor = True
        '
        'Stylesheet_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 46)
        Me.Controls.Add(Me.btnAddexistingStyle)
        Me.Controls.Add(Me.CBexistingStyles)
        Me.Name = "Stylesheet_List"
        Me.Text = "Stylesheet List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBexistingStyles As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddexistingStyle As System.Windows.Forms.Button
End Class
