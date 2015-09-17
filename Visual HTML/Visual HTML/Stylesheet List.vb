Public Class Stylesheet_List
    Public check As Boolean = False
    Private Sub Stylesheet_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        check = False
        CBexistingStyles.Items.Clear()
        Dim lengthof As Integer = Main.LBViewFile.Items.Count()
        Dim ifFound As Integer = 0
        MessageBox.Show(lengthof)
        MessageBox.Show("lengthof")
        Dim SearchForThis As String = "<style type='text/css'>"
            Dim countForLine As Integer = 0
            Do Until ifFound = 0

            Dim line As String = Main.LBViewFile.Items(countForLine).ToString
            MessageBox.Show(line)
            ifFound = line.IndexOf(SearchForThis)
            MessageBox.Show(ifFound)
            MessageBox.Show("ifFound")
                countForLine += 1
        Loop
        '0
        MessageBox.Show(countForLine)
        MessageBox.Show("countForLine")
        Dim SearchForEnd As String = "</style>"
        Dim countForLine2 As Integer = 0
        ifFound = 0
        Do Until ifFound = 0
            Dim line As String = Main.LBViewFile.Items(countForLine2).ToString
            ifFound = line.IndexOf(SearchForEnd)
            countForLine2 += 1
        Loop
        MessageBox.Show(countForLine2)
        MessageBox.Show("countForLine2")
        Dim numOfInstances As Integer = 0
        Dim searchClass As String = "class="
        Dim nameofClass() As String
        For o As Integer = countForLine To countForLine2 Step 1
            Dim IndLine As String = Main.LBViewFile.Items(countForLine).ToString
            ifFound = IndLine.IndexOf(searchClass)
            If ifFound = 0 Then
                Dim lineData As Integer = 0

                numOfInstances += 1
                While IndLine.Chars(lineData) <> "{"
                    nameofClass(o) += Mid(IndLine.Chars(lineData), 2)
                    MessageBox.Show(nameofClass(o))
                    MessageBox.Show("nameofClass")
                End While


            End If


        Next
        If Main.countOfStyles > 0 Then
            For i As Integer = 1 To Main.countOfStyles Step 1
                CBexistingStyles.Items.Add(Main.styleName(i))
            Next
        End If
    End Sub

    Private Sub btnAddexistingStyle_Click(sender As System.Object, e As System.EventArgs) Handles btnAddexistingStyle.Click
        Main.selectedStyle = (CBexistingStyles.SelectedItem)
        check = True
        Me.Close()
    End Sub
End Class