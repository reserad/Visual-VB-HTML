Imports System.IO
Imports System.Text.RegularExpressions

Public Class Javascript
    Public script As String
    Public functions As String
    Public item As Integer
    Public nameofitem As String
    Public addVar As String
    Public output As String
    Private Sub btnCancelJavascript_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelJavascript.Click
        Dim Answer As Integer
        Answer = MsgBox("If you exit without saving, your work will be lost. Are you sure you wish to exit the Javascript Editor?", vbYesNoCancel, "Exit")
        If Answer = 6 Then
            Me.Close()
        ElseIf Answer = 7 Then
            btnSaveJavascript.PerformClick()
            MessageBox.Show("Save Complete")
            Me.Close()
        End If
    End Sub
    Private Sub Javascript_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        functions = InputBox("Name your main function!", "Function")

        output = ("Function " + functions + "() {" + ControlChars.NewLine + "}")
        lblViewScript.Text = output.ToString()
        script = Main.justlocation + ".js"
        Dim FileWriter = New StreamWriter(script)
        FileWriter.Write(output)
        FileWriter.Close()

        Dim readthelist() As String = File.ReadAllLines("C:\temp\visualhtml\list.txt")
        For Each q In readthelist
            cbInput.Items.Add(q)
        Next

        Dim FileReader = New StreamReader(script)
        Dim readText() As String = File.ReadAllLines(script)
        Dim s As String
        For Each s In readText
            LBViewScript.Items.Add(s)
        Next
        FileReader.Close()

        If My.Computer.FileSystem.FileExists("C:\temp\visualhtml\list.txt") Then
            My.Computer.FileSystem.DeleteFile("C:\temp\visualhtml\list.txt")
        End If

    End Sub

    Private Sub btnSaveJavascript_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveJavascript.Click
        Dim refresh As String = lblViewScript.Text.ToString
        Try
            Dim renew = New StreamWriter(script, False)
            renew.Write(refresh)
            renew.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '------------------------------------------------------------------------------------
        Dim myStream As Stream
        Dim savefile As New SaveFileDialog()

        savefile.Filter = "js (*.js*)|*.js*|jS (*.js*)|*.*"
        savefile.FilterIndex = 1
        savefile.RestoreDirectory = True
        savefile.InitialDirectory = "C:\Users\Alec\Desktop"
        '--------------------------------------------------------------------------------------------------------
        If savefile.ShowDialog() = DialogResult.OK Then
            myStream = savefile.OpenFile()
            If My.Computer.FileSystem.FileExists(script) Then
                My.Computer.FileSystem.DeleteFile(script)
            End If
            If (myStream IsNot Nothing) Then
                Dim FileWriter = New StreamWriter(savefile.FileName + ".js")
                FileWriter.Write(lblViewScript.Text)
                FileWriter.Close()
                myStream.Close()
            End If
        End If
        If My.Computer.FileSystem.FileExists(savefile.FileName) Then
            My.Computer.FileSystem.DeleteFile(savefile.FileName)
        End If
    End Sub

    Private Sub btnMakeVar_Click(sender As System.Object, e As System.EventArgs) Handles btnMakeVar.Click
        Dim nameOfVar = InputBox("Please input the name of your variable.", "var")
        Dim VarInfo As String = InputBox("Please input the data for the variable.", "var")
        Dim checkNumber As Boolean
        For i As Integer = 0 To nameOfVar.Length() Step 1
            If Regex.IsMatch(VarInfo, "^[0-9 ]+$") Then
                checkNumber = True
            Else
                checkNumber = False
            End If

            If InStr(1, VarInfo, "+") > 0 Then
                checkNumber = True
            End If
            If InStr(1, VarInfo, "-") > 0 Then
                checkNumber = True
            End If
            If InStr(1, VarInfo, "*") > 0 Then
                checkNumber = True
            End If
            If InStr(1, VarInfo, "/") > 0 Then
                checkNumber = True
            End If

            If checkNumber = True Then
                addVar = ("var " + nameOfVar + " = " + VarInfo + ";" + ControlChars.NewLine)
            Else
                addVar = ("var " + nameOfVar + " = " + "'" + VarInfo + "';" + ControlChars.NewLine)
            End If
        Next
        ReUpdate(addVar)
    End Sub

    Private Sub ReUpdate(addVar As String)
        item = (LBViewScript.SelectedIndex)
        nameofitem = (LBViewScript.Text)
        Dim Lines() As String = System.IO.File.ReadAllLines(script)
        MessageBox.Show(item)
        MessageBox.Show(nameofitem)
        Try
            Lines(item) = (nameofitem + ControlChars.NewLine + addVar)
            System.IO.File.WriteAllLines(script, Lines)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '--------------------------------------------------------------------------------------------------------
        Try
            Dim FileReader = New StreamReader(script, FileMode.Append)
            lblViewScript.Text = FileReader.ReadToEnd
            FileReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim updateLB() As String = File.ReadAllLines(script)
        LBViewScript.Items.Clear()
        For Each l In updateLB
            LBViewScript.Items.Add(l)
        Next
    End Sub
End Class