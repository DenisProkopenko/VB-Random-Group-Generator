Imports System.IO

Public Class Rndomizer
    Public Class GlobalVariables
        Public Shared studentNames As List(Of Integer)
        Public Shared combinations As List(Of Integer)
        Public Shared classSize As Integer
        Public Shared groupSize As Integer
        Public Shared initializer As Boolean
    End Class

    Private Sub Rndomizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim openfile = New OpenFileDialog()

        openfile.Filter = "Text (*.txt)|*.txt"

        MsgBox("Select text file of students to open", MsgBoxStyle.Information)

        If (openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Dim i As Integer = 0

            Dim myfile As String = openfile.FileName
            Dim allLines As String() = File.ReadAllLines(myfile)
            lstBoxStudents.Items.Clear()

            For Each line As String In allLines
                lstBoxStudents.Items.Add(line)
            Next
        End If

        If lstBoxStudents.Items.Count > 0 Then
            btnCreate.Enabled = True
            btnDelete.Enabled = True
            btnDeleteNames.Enabled = True
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addName As String

        addName = InputBox("Enter student to add.")
        While (addName <> "0")
            If addName = "" Then
                addName = "0"
            Else
                lstBoxStudents.Items.Add(addName)
                addName = InputBox("Enter student to add.")
            End If

        End While

        If lstBoxStudents.Items.Count > 0 Then
            btnCreate.Enabled = True
            btnDelete.Enabled = True
            btnDeleteNames.Enabled = True
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteName As String

        deleteName = InputBox("Enter name to delete.")
        While (deleteName <> "0")
            If deleteName = "" Then
                deleteName = "0"
            Else
                lstBoxStudents.Items.Remove(deleteName)
                deleteName = InputBox("Enter name to delete.")
            End If
        End While

        If lstBoxStudents.Items.Count = 0 Then
            btnCreate.Enabled = False
            btnDelete.Enabled = False
            btnDeleteNames.Enabled = False
        End If

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Try
            GlobalVariables.groupSize = InputBox("How many people per group?")
        Catch exception As Exception

        End Try

        Dim studentsList(lstBoxStudents.Items.Count) As String
        Dim index As Integer = 0
        Dim count As Integer = lstBoxStudents.Items.Count
        Dim counter As Integer = 0
        Dim student As String
        
        lstBoxGroups.Items.Clear()

        While index < count
            studentsList(index) = lstBoxStudents.Items(index)
            index += 1
        End While

        'start randomization
        index = 0
        While index < count / 2
            Dim max_index As Integer = lstBoxStudents.Items.Count - 1
            Dim rnd As New Random
            For i As Integer = 0 To max_index - 1
                ' Pick an item for position i.
                Dim j As Integer = rnd.Next(i, max_index + 1)

                ' Swap them.
                Dim temp As String = studentsList(i)
                studentsList(i) = studentsList(j)
                studentsList(j) = temp
            Next i
            index += 1
        End While
        'end randomization

        index = 0
        Dim groupCount As Integer = 0
        Dim ix As Integer = 1

        lstBoxGroups.Items.Add("Group #" & ix)
        While index < count
            student = studentsList(index)

            lstBoxGroups.Items.Add(student)
            
            index += 1
            groupCount += 1
            If groupCount = GlobalVariables.groupSize Then
                groupCount = 0
                ix += 1
                If index >= count Then
                Else
                    lstBoxGroups.Items.Add(" ")
                    lstBoxGroups.Items.Add("Group #" & ix)
                    End If
            End If
        End While
        btnDeleteGroups.Enabled = True
    End Sub

    Private Sub btnDeleteNames_Click(sender As Object, e As EventArgs) Handles btnDeleteNames.Click
        lstBoxStudents.Items.Clear()
        btnDelete.Enabled = False
        btnDeleteNames.Enabled = False
        btnCreate.Enabled = False
    End Sub

    Private Sub btnDeleteGroups_Click(sender As Object, e As EventArgs) Handles btnDeleteGroups.Click
        lstBoxGroups.Items.Clear()
        btnDeleteGroups.Enabled = False
    End Sub

    'Dropdown Menu codes
    Private Sub QuitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        btnEnter_Click(e, AcceptButton)
    End Sub

    Private Sub AddNamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNamesToolStripMenuItem.Click
        btnAdd_Click(e, AcceptButton)
    End Sub

    Private Sub DeleteNamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteNamesToolStripMenuItem.Click
        btnDelete_Click(e, AcceptButton)
    End Sub

    Private Sub CreateGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateGroupsToolStripMenuItem.Click
        btnCreate_Click(e, AcceptButton)
    End Sub

End Class
