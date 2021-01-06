Imports System.Globalization

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Load_Data()
        PGNAME.Text = My.Resources.resLang.PGNAME
        VERSTR.Text = My.Resources.resLang.VERSTR
        APPEND.Text = My.Resources.resLang.APPEND
        APPLY.Text = My.Resources.resLang.APPLY
        EDITING.Text = My.Resources.resLang.EDITING
        APPLIED.Text = My.Resources.resLang.APPLIED
        QUIT.Text = My.Resources.resLang.QUIT
        UNBLOCK.Text = My.Resources.resLang.UNBLOCK
        INFO_GEN_1.Text = My.Resources.resLang.INFO_GEN_1
        INFO_GEN_2.Text = My.Resources.resLang.INFO_GEN_2
        INFO_WARN_1.Text = My.Resources.resLang.INFO_WARN_1
        EDITING.Visible = False
    End Sub

    Sub Refresh_Lang()
        PGNAME.Text = My.Resources.resLang.PGNAME
        VERSTR.Text = My.Resources.resLang.VERSTR
        APPEND.Text = My.Resources.resLang.APPEND
        APPLY.Text = My.Resources.resLang.APPLY
        EDITING.Text = My.Resources.resLang.EDITING
        APPLIED.Text = My.Resources.resLang.APPLIED
        QUIT.Text = My.Resources.resLang.QUIT
        UNBLOCK.Text = My.Resources.resLang.UNBLOCK
        INFO_GEN_1.Text = My.Resources.resLang.INFO_GEN_1
        INFO_GEN_2.Text = My.Resources.resLang.INFO_GEN_2
        INFO_WARN_1.Text = My.Resources.resLang.INFO_WARN_1
    End Sub

    Sub Load_Data()
        Dim readlist As ListBox.ObjectCollection
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Windows\System32\drivers\etc\hosts")
        Dim fileSplit() As String = Split(fileReader, vbNewLine)
        Dim reset As Boolean = False

        If fileSplit.Length > 0 And Not (fileSplit(0) = "# Copyright (c) 2019-2021 BFY") Then
            MsgBox(My.Resources.resLang.ERR_INVALID_CONFIG)
            reset = True
        ElseIf fileSplit.Length > 1 And Not (fileSplit(1) = "# This file is Generated Automatically by NetFilter") Then
            MsgBox(My.Resources.resLang.ERR_INVALID_CONFIG)
            reset = True
        ElseIf fileSplit.Length > 2 And Not (fileSplit(2) = "# DO NOT MODIFY THIS FILE if you don't know what you are doing.") Then
            MsgBox(My.Resources.resLang.ERR_INVALID_CONFIG)
            reset = True
        ElseIf fileSplit.Length > 3 And Not (fileSplit(3) = "# Modifying this file incorrectly can cause problem to system and BFY NetFilter.") Then
            MsgBox(My.Resources.resLang.ERR_INVALID_CONFIG)
            reset = True
        End If

        If reset = True Then
            Dim towrite As String = "# Copyright (c) 2019-2021 BFY" + vbNewLine + "# This file is Generated Automatically by NetFilter" + vbNewLine + "# DO NOT MODIFY THIS FILE if you don't know what you are doing." + vbNewLine + "# Modifying this file incorrectly can cause problem to system and BFY NetFilter."
            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", towrite, False)
        End If

        Dim i As Integer = 4
        readlist = ListBox1.Items
        readlist.Clear()

        Dim listChk As Boolean = False
        Dim j As Long = 0

        While fileSplit.Length > i
            If Strings.Left(fileSplit(i), 9) = "127.0.0.1" Then
                For j = 0 To readlist.Count - 1
                    If readlist(j) = Strings.Mid(fileSplit(i), 11) Then listChk = True
                Next
                If listChk = False Then
                    readlist.Add(Strings.Mid(fileSplit(i), 11))
                Else
                    MsgBox(My.Resources.resLang.ERR_INVALID_CONFIG)
                    reset = True
                    Exit While
                End If
            Else
                MsgBox(My.Resources.resLang.ERR_INVALID_CONFIG)
                reset = True
                Exit While
            End If
            i += 1
        End While

        If reset = True Then
            readlist.Clear()
            Dim towrite As String = "# Copyright (c) 2019-2021 BFY" + vbNewLine + "# This file is Generated Automatically by NetFilter" + vbNewLine + "# DO NOT MODIFY THIS FILE if you don't know what you are doing." + vbNewLine + "# Modifying this file incorrectly can cause problem to system and BFY NetFilter."
            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", towrite, False)
        End If

        Return
    End Sub

    Dim point As New System.Drawing.Point()
    Dim X, Y As Integer

    Private Sub Bar_MouseDown(sender As Object, e As MouseEventArgs) Handles Bar.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Bar_MouseMove(sender As Object, e As MouseEventArgs) Handles Bar.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            point = Control.MousePosition
            point.X -= (X)
            point.Y -= (Y)
            Me.Location = point
        End If
    End Sub

    Private Sub APPEND_Click(sender As Object, e As EventArgs) Handles APPEND.Click
        Dim listChk As Boolean = False
        Dim i As Long = 0
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i) = sitetxt.Text Then listChk = True
        Next
        If sitetxt.Text = "" Then
            MsgBox(My.Resources.resLang.ERR_NO_VALUE)
        ElseIf listChk = False Then
            ListBox1.Items.Add(sitetxt.Text)
        Else
            MsgBox(My.Resources.resLang.ERR_EXISTING_VALUE)
        End If
        EDITING.Visible = True
        APPLIED.Visible = False
        sitetxt.Text = ""
    End Sub

    Private Sub APPLY_Click(sender As Object, e As EventArgs) Handles APPLY.Click
        Dim i As Long = 0
        Dim towrite As String
        towrite = "# Copyright (c) 2019-2021 BFY" + vbNewLine + "# This file is Generated Automatically by NetFilter" + vbNewLine + "# DO NOT MODIFY THIS FILE if you don't know what you are doing." + vbNewLine + "# Modifying this file incorrectly can cause problem to system and BFY NetFilter."
        My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", towrite, False)
        For i = 0 To ListBox1.Items.Count - 1
            towrite = vbNewLine + "127.0.0.1 " + ListBox1.Items(i).ToString()
            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", towrite, True)
        Next
        EDITING.Visible = False
        APPLIED.Visible = True
    End Sub

    Private Sub UNBLOCK_Click(sender As Object, e As EventArgs) Handles UNBLOCK.Click
        Dim str As String
        Try
            str = ListBox1.SelectedItem.ToString()
        Catch ex As NullReferenceException
            MsgBox(My.Resources.resLang.ERR_NOTHING_SELECTED_TO_DELETE)
            Return
        Finally
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End Try
        EDITING.Visible = True
        APPLIED.Visible = False
    End Sub

    Private Sub QUIT_Click(sender As Object, e As EventArgs) Handles QUIT.Click
        Application.Exit()
    End Sub
End Class
