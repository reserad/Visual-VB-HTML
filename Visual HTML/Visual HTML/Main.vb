Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing.Text

Public Class Main
    Public location As String
    Public justlocation As String
    Public count As Integer = 0
    Public redo(50) As String
    Public extrafile As String
    Public selection As Integer
    Public FileLength As Integer
    Public item As Integer
    Public nameofitem As String
    Public textbox As String
    Public list As String
    Public titleText As String = "Visual HTML"
    Public listofCSSElements() As String
    Public listElementCount As Integer
    Public nameOfSelector As String
    Public title As String = ""
    Public headerLarge As String
    Public theText As String
    Public countOfStyles As Integer
    Public styleName(50) As String
    Public styleExists As Boolean
    Public selectedStyle As String = ""
    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click

        lblViewFile.Clear()
        LBViewFile.Items.Clear()
        Dim openfile As OpenFileDialog = New OpenFileDialog()

        Dim strFileName As String

        openfile.Title = "Open File Dialog"
        openfile.InitialDirectory = "C:\"
        openfile.Filter = "HTML file (*.html*)|*.html*|Text file (*.txt*)|*.*"
        openfile.FilterIndex = 1
        openfile.RestoreDirectory = True
        '--------------------------------------------------------------------------------------------------------
        If openfile.ShowDialog() = DialogResult.OK Then
            strFileName = openfile.FileName
            Try
                Dim FileReader = New StreamReader(strFileName)
                location = (strFileName)
                FileLength = IO.File.ReadAllLines(location).Length
                Dim readText() As String = File.ReadAllLines(location)
                lblViewFile.Text = FileReader.ReadToEnd
                Dim s As String
                For Each s In readText
                    LBViewFile.Items.Add(s)
                Next
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            For Each Con As Control In (gbHeaders.Controls)
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next

            For Each Con As Control In (gbInput.Controls)
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next

            For Each Con As Control In (gbAttach.Controls)
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next

            For Each Con As Control In (gbJavascript.Controls)
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next
            For Each Con As Control In gbCSS.Controls
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next
            For Each Con As Control In gbTextManip.Controls
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next

            For Each Con As Control In gbTableWidthandHeight.Controls
                If Con.GetType Is GetType(Button) Then
                    Con.Enabled = True
                End If
            Next

            Me.webPreview.Navigate(location)
        End If
        If Me.Text <> titleText Then
            Me.Text = titleText

        End If
        Me.Text += ": " + location
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim myStream As Stream
        Dim savefile As New SaveFileDialog()

        savefile.Filter = "HTML file (*.html*)|*.html*|Text file (*.txt*)|*.*"
        savefile.FilterIndex = 1
        savefile.RestoreDirectory = True
        savefile.InitialDirectory = "C:\Users\Alec\Desktop"
        '--------------------------------------------------------------------------------------------------------
        If savefile.ShowDialog() = DialogResult.OK Then
            myStream = savefile.OpenFile()
            If (myStream IsNot Nothing) Then
                Dim FileWriter = New StreamWriter(savefile.FileName + ".html")
                FileWriter.Write("<!DOCTYPE HTML>" + ControlChars.NewLine + "<html>" + ControlChars.NewLine + "<head>" + ControlChars.NewLine + "<meta charset='utf-8'>" + ControlChars.NewLine + "<title></title>" + ControlChars.NewLine + "</head>" + ControlChars.NewLine + "<body>" + ControlChars.NewLine + "<p>Your Mother</p>" + ControlChars.NewLine + "</body>" + ControlChars.NewLine + "</html>")
                FileWriter.Close()
                myStream.Close()

                '--------------------------------------------------------------------------------------------------------
                Try
                    Dim FileReader = New StreamReader(savefile.FileName + ".html")
                    location = (savefile.FileName + ".html")
                    justlocation = savefile.FileName
                    FileLength = IO.File.ReadAllLines(location).Length

                    Dim readText() As String = File.ReadAllLines(location)
                    lblViewFile.Text = FileReader.ReadToEnd
                    Dim s As String
                    For Each s In readText
                        LBViewFile.Items.Add(s)
                    Next
                    extrafile = savefile.FileName
                    FileReader.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                '--------------------------------------------------------------------------------------------------------
                If My.Computer.FileSystem.FileExists(extrafile) Then
                    My.Computer.FileSystem.DeleteFile(extrafile)
                End If
                Me.webPreview.Navigate(location)

                For Each Con As Control In (gbHeaders.Controls)
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next

                For Each Con As Control In (gbInput.Controls)
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next

                For Each Con As Control In (gbAttach.Controls)
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next

                For Each Con As Control In gbJavascript.Controls
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next
                For Each Con As Control In gbCSS.Controls
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next
                For Each Con As Control In gbTextManip.Controls
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next

                For Each Con As Control In gbTableWidthandHeight.Controls
                    If Con.GetType Is GetType(Button) Then
                        Con.Enabled = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Dim refresh As String = lblViewFile.Text.ToString
        If lblViewFile.Text <> "" Then
            Try
                Dim renew = New StreamWriter(location, False)
                renew.Write(refresh)
                renew.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            '--------------------------------------------------------------------------------------------------------
            Dim readText() As String = File.ReadAllLines(location)

            Dim s As String

            LBViewFile.Items.Clear()
            '--------------------------------------------------------------------------------------------------------
            For Each s In readText
                LBViewFile.Items.Add(s)
            Next

            Me.webPreview.Navigate(location)

            redo(count) = (lblViewFile.Text)
            count += 1

            If My.Computer.FileSystem.FileExists(extrafile) Then
                My.Computer.FileSystem.DeleteFile(extrafile)
            End If
        End If
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        Try
            count -= 1
            lblViewFile.Text = redo(count)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnHLarge_Click(sender As System.Object, e As System.EventArgs) Handles btnHLarge.Click
        listElementCount += 1
        item = (LBViewFile.SelectedIndex)
        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)

            headerLarge = InputBox("Please enter text for your header", "<h1>")
            '--------------------------------------------------------------------------------------------------------
            If headerLarge <> "" Then
                Try
                    
                        If styleExists = False Then

                            Lines(item) = (nameofitem + ControlChars.NewLine + "<h1>" + headerLarge + "</h1>")
                            System.IO.File.WriteAllLines(location, Lines)
                        End If

                    If styleExists = True Then
                        Stylesheet_List.ShowDialog()
                        If Stylesheet_List.check = True Then
                            Lines(item) = (nameofitem + ControlChars.NewLine + "<h1 class='" + selectedStyle + "'>" + headerLarge + "</h1>")
                            System.IO.File.WriteAllLines(location, Lines)
                        End If
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Dim installed_fonts As New InstalledFontCollection

        ' Get an array of the system's font families.
        Dim font_families() As FontFamily = installed_fonts.Families()
        ' Display the font families.
        For Each font_family As FontFamily In font_families
            Dim newFont As String = Mid(font_family.ToString(), 19)
            Dim removeLength As Integer = newFont.Length
            newFont = Mid(newFont, 1, removeLength - 1)
            CbFonts.Items.Add(newFont)
        Next font_family

        For Each Con As Control In gbHeaders.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next

        For Each Con As Control In gbInput.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next

        For Each Con As Control In gbAttach.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next

        For Each Con As Control In gbJavascript.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next
        For Each Con As Control In gbCSS.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next
        For Each Con As Control In gbTextManip.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next

        For Each Con As Control In gbTableWidthandHeight.Controls
            If Con.GetType Is GetType(Button) Then
                Con.Enabled = False
            End If
        Next

    End Sub
    Private Sub btnHMedium_Click(sender As System.Object, e As System.EventArgs) Handles btnHMedium.Click
        listElementCount += 1
        item = (LBViewFile.SelectedIndex)
        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            Dim headerMedium = InputBox("Please enter text for your header", "<h2>")

            '--------------------------------------------------------------------------------------------------------
            If headerMedium <> "" Then

                Try
                    Lines(item) = (nameofitem + ControlChars.NewLine + "<h2>" + headerMedium + "</h2>")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub btnHSmall_Click(sender As System.Object, e As System.EventArgs) Handles btnHSmall.Click
        listElementCount += 1
        item = (LBViewFile.SelectedIndex)
        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            Dim headerSmall = InputBox("Please enter text for your header", "<h3>")

            '--------------------------------------------------------------------------------------------------------
            If headerSmall <> "" Then

                Try
                    Lines(item) = (nameofitem + ControlChars.NewLine + "<h3>" + headerSmall + "</h3>")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub btnInputText_Click(sender As System.Object, e As System.EventArgs) Handles btnInputText.Click
        listElementCount += 1
        item = (LBViewFile.SelectedIndex)
        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            Dim textInFront = InputBox("Please input what text you would like out infront of your input:", "<input>")
            Dim nameOfTextInput = InputBox("Please input the name of your text box:", "<input>")
            MessageBox.Show(nameOfTextInput)
            list += nameOfTextInput + ControlChars.NewLine
            '--------------------------------------------------------------------------------------------------------
            If textInFront & nameOfTextInput <> "" Then

                Try
                    Lines(item) = (nameofitem + ControlChars.NewLine + textInFront + "<input type='text' name = '" + nameOfTextInput + "' />")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub btnInputButton_Click(sender As System.Object, e As System.EventArgs) Handles btnInputButton.Click
        listElementCount += 1
        item = (LBViewFile.SelectedIndex)
        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            Dim textOnButton = InputBox("Please input what text you would like on your button:", "<input>")
            Dim nameOfButtonInput = InputBox("Please input the name of your button:", "<input>")
            list += nameOfButtonInput + ControlChars.NewLine
            '--------------------------------------------------------------------------------------------------------
            If textOnButton & nameOfButtonInput <> "" Then

                Try
                    Lines(item) = (nameofitem + ControlChars.NewLine + "<button type='button' name = '" + nameOfButtonInput + "'>" + textOnButton + "</button>")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub btnCSS_Click(sender As System.Object, e As System.EventArgs) Handles btnCSS.Click

        Dim Lines() As String = System.IO.File.ReadAllLines(location)
        nameofitem = (Lines(2))
        Dim openfile As OpenFileDialog = New OpenFileDialog()
        Dim strCSSFileName As String

        openfile.Title = "Open File Dialog"
        openfile.InitialDirectory = "C:\"
        openfile.Filter = "CSS (*.css*)|*.css*|CSS (*.css*)|*.*"
        openfile.FilterIndex = 1
        openfile.RestoreDirectory = True
        '--------------------------------------------------------------------------------------------------------
        If openfile.ShowDialog() = DialogResult.OK Then
            strCSSFileName = openfile.FileName
            '--------------------------------------------------------------------------------------------------------
            Try
                Lines(2) = (nameofitem + ControlChars.NewLine + "<link rel='stylesheet' type='text/css' href='" + strCSSFileName + "' />")
                System.IO.File.WriteAllLines(location, Lines)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub btnScript_Click(sender As System.Object, e As System.EventArgs) Handles btnScript.Click
        item = (LBViewFile.SelectedIndex)
        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            '--------------------------------------------------------------------------------------------------------
            Dim openfile As OpenFileDialog = New OpenFileDialog()
            Dim strScriptFileName As String

            openfile.Title = "Open File Dialog"
            openfile.InitialDirectory = "C:\"
            openfile.Filter = "js (*.js*)|*.js*|js (*.js*)|*.*"
            openfile.FilterIndex = 1
            openfile.RestoreDirectory = True
            '--------------------------------------------------------------------------------------------------------
            If openfile.ShowDialog() = DialogResult.OK Then
                strScriptFileName = openfile.FileName

                Try
                    Lines(item) = (nameofitem + ControlChars.NewLine + "<script type='text/javascript' src='" + strScriptFileName + "'>" + ControlChars.NewLine + "</script>")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                '--------------------------------------------------------------------------------------------------------
                Try
                    Dim FileReader = New StreamReader(location, FileMode.Append)
                    lblViewFile.Text = FileReader.ReadToEnd
                    FileReader.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If


            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub btnOpenJavascript_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenJavascript.Click
        Dim inputlist = Me.list

        Try
            Dim writelist As New StreamWriter("C:\temp\visualhtml\list.txt")
            writelist.Write(inputlist)
            writelist.Close()
        Catch ex As Exception
        End Try
        Javascript.Show()
    End Sub

    Private Sub btnInputRadio_Click(sender As System.Object, e As System.EventArgs) Handles btnInputRadio.Click
        listElementCount += 1
        item = (LBViewFile.SelectedIndex)

        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            nameofitem = (LBViewFile.Text)

            '--------------------------------------------------------------------------------------------------------
            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            Dim textOnRButton = InputBox("Please input what text you would like out in front of your radio button:", "<input>")
            Dim nameOfButtonInput = InputBox("Please input the name of your radio button:", "<input>")
            MessageBox.Show(nameOfButtonInput)
            list += nameOfButtonInput + ControlChars.NewLine
            '--------------------------------------------------------------------------------------------------------
            If textOnRButton & nameOfButtonInput <> "" Then

                Try
                    Lines(item) = (nameofitem + ControlChars.NewLine + "<input type='radio' name = '" + nameOfButtonInput + "'>" + textOnRButton + "</input>")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            '--------------------------------------------------------------------------------------------------------
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub
    Private Sub btnHideLbl_Click(sender As System.Object, e As System.EventArgs) Handles btnHideLbl.Click
        If lblViewFile.Width = 400 And LBViewFile.Width = 400 Then
            Label1.Hide()
            Label2.Hide()
            btnDeleteRow.Hide()
            lblViewFile.Width = 50
            LBViewFile.Width = 50
            LBViewFile.Location = New Point(100, 62)
            btnHideLbl.Location = New Point(580, 543)
            webPreview.Location = New Point(172, 62)
            webPreview.Width = 1080
            Label1.Hide()
            Label2.Hide()
            btnHideLbl.Text = "Unhide both tables"

        Else
            lblViewFile.Width = 400
            LBViewFile.Width = 400
            LBViewFile.Location = New Point(437, 62)
            btnHideLbl.Location = New Point(951, 543)
            webPreview.Location = New Point(852, 62)
            webPreview.Width = 400
            btnDeleteRow.Show()
            Label1.Show()
            Label2.Show()
            btnHideLbl.Text = "Show only web preview"
        End If
    End Sub

    Private Sub btnDeleteRow_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteRow.Click
        item = (LBViewFile.SelectedIndex)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            LBViewFile.Items.RemoveAt(item)
            lblViewFile.Text = ""
            For l_index As Integer = 0 To LBViewFile.Items.Count - 1
                lblViewFile.Text += CStr(LBViewFile.Items(l_index) + ControlChars.NewLine)
            Next
        End If
    End Sub

    Private Sub btnCreateCSS_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateCSS.Click
        CSS.Show()
    End Sub

    Private Sub btnCreateTable_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateTable.Click
        item = (LBViewFile.SelectedIndex)
        Dim tableH As Integer = TbTableHeight.Value
        Dim tableW As Integer = TbTableWidth.Value
        Dim tableR As Integer = CounterR.Value
        Dim tableC As Integer = CounterC.Value
        Dim TableRNumber As String = ""
        Dim i As Integer = 0
        Dim k As Integer = 0


        nameofitem = (LBViewFile.Text)
        If Regex.IsMatch(item.ToString, "^[0-9 ]+$") Then
            Do
                TableRNumber += ("<tr>" + ControlChars.NewLine)
                Do While (i <> tableC)
                    TableRNumber += ("<td>" + ControlChars.NewLine + "&nbsp;" + ControlChars.NewLine + "</td>" + ControlChars.NewLine)
                    i += 1
                Loop
                TableRNumber += ("</tr>" + ControlChars.NewLine)
                k += 1
                i = 0
            Loop Until (k = tableR)

            Dim Lines() As String = System.IO.File.ReadAllLines(location)
            Try
                Lines(item) = (nameofitem + ControlChars.NewLine + "<table width='" + tableW.ToString + "' height='" + tableH.ToString + "' border='1'>" + ControlChars.NewLine + TableRNumber + "</table>")
                System.IO.File.WriteAllLines(location, Lines)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Try
                Dim FileReader = New StreamReader(location, FileMode.Append)
                lblViewFile.Text = FileReader.ReadToEnd
                FileReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.webPreview.Navigate(location)
        End If
    End Sub

    Private Sub TbTableWidth_Scroll(sender As System.Object, e As System.EventArgs) Handles TbTableWidth.Scroll
        lblTableWidth.Text = TbTableWidth.Value
    End Sub

    Private Sub TbTableHeight_Scroll(sender As System.Object, e As System.EventArgs) Handles TbTableHeight.Scroll
        lblTableHeight.Text = TbTableHeight.Value
    End Sub

    Private Sub PicCenter_Click(sender As System.Object, e As System.EventArgs) Handles PicCenter.Click
        If LBViewFile.SelectedItems.Count > 0 Then
            item = (LBViewFile.SelectedIndex)
            Dim prev = (LBViewFile.SelectedItem)
            Dim userSelect(LBViewFile.SelectedItems.Count) As String
            Dim SelectionLength As Integer = (LBViewFile.SelectedItems.Count)


            Try
                Dim Lines() As String = System.IO.File.ReadAllLines(location)
                Try
                    'MessageBox.Show(prev)
                    Lines(item) = ("<center>" + ControlChars.NewLine + prev)

                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Try
                    Dim FileReader = New StreamReader(location, FileMode.Append)
                    lblViewFile.Text = FileReader.ReadToEnd
                    FileReader.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.webPreview.Navigate(location)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'MessageBox.Show(item + (SelectionLength - 1))
            Dim lastPrev As String = LBViewFile.Items(item + (SelectionLength - 1))
            'MessageBox.Show(lastPrev)

            Try
                Dim Lines() As String = System.IO.File.ReadAllLines(location)
                Try
                    Lines(item + (SelectionLength)) = (lastPrev + ControlChars.NewLine + "</center>")
                    System.IO.File.WriteAllLines(location, Lines)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Try
                    Dim FileReader = New StreamReader(location, FileMode.Append)
                    lblViewFile.Text = FileReader.ReadToEnd
                    FileReader.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.webPreview.Navigate(location)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub CbFonts_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbFonts.SelectedIndexChanged
        If LBViewFile.SelectedItems.Count > 0 Then
            item = (LBViewFile.SelectedIndex)
            Dim i As Integer = 0
            Dim nameOfElement As String
            Dim prev = (LBViewFile.SelectedItem)
            Dim prevStringofChars As String = Mid(prev, 1, 11)
            MessageBox.Show(prevStringofChars)
            Dim l As Integer = 0
            If prevStringofChars = "font-family" Then

                Try
                    Dim replaceLine As String = LBViewFile.SelectedItem
                    Dim Lines() As String = System.IO.File.ReadAllLines(location)
                    Try
                        Lines(item) = ("font-family:" + CbFonts.SelectedItem + ";")

                        System.IO.File.WriteAllLines(location, Lines)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    Try
                        Dim FileReader = New StreamReader(location, FileMode.Append)
                        lblViewFile.Text = FileReader.ReadToEnd
                        FileReader.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    Me.webPreview.Navigate(location)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                While prev.Chars(i) <> ">"
                    i += 1
                End While
                nameOfElement = Mid(prev, 2, i - 1)

                Dim elementCount As Integer = nameOfElement.Length()
                Dim saveTitle As String = title
                If saveTitle = "" Then
                    saveTitle = "<title>Untitled Document</title>"
                End If
                Dim a As Integer = 0
                Do Until prev.chars(a) = ">"
                    a += 1
                Loop
                Dim k As Integer = prev.Length
                MessageBox.Show(k)
                k -= a
                k -= a
                k -= 3
                MessageBox.Show(a)
                MessageBox.Show(k)

                theText = Mid(prev, (a + 2), k)
                MessageBox.Show(theText)
                Try
                    Dim replaceLine As String = LBViewFile.SelectedItem
                    Dim Lines() As String = System.IO.File.ReadAllLines(location)
                    Try
                        If nameOfElement <> "p" Or nameOfElement <> "h1" Or nameOfElement <> "h2" Or nameOfElement <> "h3" Or nameOfElement <> "body" Then
                            nameOfSelector = InputBox("Please enter what name you would like to call the element of your selection:", prev)
                            Lines(4) = ("<style type='text/css'>" + ControlChars.NewLine + "." + nameOfSelector + "{" + ControlChars.NewLine + "font-family: " + CbFonts.SelectedItem + ";" + ControlChars.NewLine + "}" + ControlChars.NewLine + "</style>" + ControlChars.NewLine + saveTitle)
                        Else
                            Lines(4) = ("<style type='text/css'>" + ControlChars.NewLine + nameOfElement + "{" + ControlChars.NewLine + "font-family: " + CbFonts.SelectedItem + ";" + ControlChars.NewLine + "}" + ControlChars.NewLine + "</style>" + ControlChars.NewLine + saveTitle)
                        End If

                        System.IO.File.WriteAllLines(location, Lines)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    Try
                        Lines(item) = ("<" + nameOfElement + " class = '" + nameOfSelector + "'>" + theText + "</" + nameOfElement + ">")
                        System.IO.File.WriteAllLines(location, Lines)
                    Catch ex As Exception
                    End Try
                    Try
                        Dim FileReader = New StreamReader(location, FileMode.Append)
                        lblViewFile.Text = FileReader.ReadToEnd
                        FileReader.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    Me.webPreview.Navigate(location)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            styleExists = True
            countOfStyles += 1
            MessageBox.Show(countOfStyles)
            If countOfStyles > 0 Then
                For q As Integer = countOfStyles - 1 To countOfStyles Step 1
                    styleName(q) = nameOfSelector.ToString
                Next
            End If
        End If
    End Sub
End Class
