Imports System.IO

Public Class CSS

    Private Sub btnExitCSS_Click(sender As System.Object, e As System.EventArgs) Handles btnExitCSS.Click
        Dim Answer As Integer
        If lblViewCSS.Text <> "" Then
            Answer = MsgBox("If you exit without saving, your work will be lost. Are you sure you wish to exit the CSS Editor without saving?", vbYesNoCancel, "Exit")
            If Answer = 6 Then
                Me.Close()
            ElseIf Answer = 7 Then
                btnSaveCSS.PerformClick()
                MessageBox.Show("Save Complete")
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnSaveCSS_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCSS.Click
        Dim outputLocation = Main.justlocation
        Try
            Dim CSSWriter As New StreamWriter(outputLocation)
            CSSWriter.Write(lblViewCSS)
            CSSWriter.Close()
            MessageBox.Show("Data succesfully saved:")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CSS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim readthelist() As String = File.ReadAllLines("C:\temp\visualhtml\list.txt")

        For Each q In readthelist
            lblViewCSS.Text = q
        Next
    End Sub
End Class