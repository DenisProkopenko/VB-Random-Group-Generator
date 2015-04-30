<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rndomizer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lstBoxStudents = New System.Windows.Forms.ListBox()
        Me.lstBoxGroups = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeleteNames = New System.Windows.Forms.Button()
        Me.btnDeleteGroups = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quartz MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(88, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Random Group Generator"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(15, 65)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(88, 46)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Import Names From File"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(109, 65)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 46)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Name"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(245, 65)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 46)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Name"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Enabled = False
        Me.btnCreate.Location = New System.Drawing.Point(339, 65)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(88, 46)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create Group(s)"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lstBoxStudents
        '
        Me.lstBoxStudents.FormattingEnabled = True
        Me.lstBoxStudents.Location = New System.Drawing.Point(15, 172)
        Me.lstBoxStudents.Name = "lstBoxStudents"
        Me.lstBoxStudents.Size = New System.Drawing.Size(182, 342)
        Me.lstBoxStudents.TabIndex = 6
        '
        'lstBoxGroups
        '
        Me.lstBoxGroups.FormattingEnabled = True
        Me.lstBoxGroups.Location = New System.Drawing.Point(245, 172)
        Me.lstBoxGroups.Name = "lstBoxGroups"
        Me.lstBoxGroups.Size = New System.Drawing.Size(182, 342)
        Me.lstBoxGroups.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Students List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Groups"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(442, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem, Me.AddNamesToolStripMenuItem, Me.DeleteNamesToolStripMenuItem, Me.CreateGroupsToolStripMenuItem, Me.QuitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.QuitToolStripMenuItem.Text = "Import Names"
        '
        'AddNamesToolStripMenuItem
        '
        Me.AddNamesToolStripMenuItem.Name = "AddNamesToolStripMenuItem"
        Me.AddNamesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddNamesToolStripMenuItem.Text = "Add Name(s)"
        '
        'DeleteNamesToolStripMenuItem
        '
        Me.DeleteNamesToolStripMenuItem.Name = "DeleteNamesToolStripMenuItem"
        Me.DeleteNamesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DeleteNamesToolStripMenuItem.Text = "Delete Name(s)"
        '
        'CreateGroupsToolStripMenuItem
        '
        Me.CreateGroupsToolStripMenuItem.Name = "CreateGroupsToolStripMenuItem"
        Me.CreateGroupsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CreateGroupsToolStripMenuItem.Text = "Create Group(s)"
        '
        'QuitToolStripMenuItem1
        '
        Me.QuitToolStripMenuItem1.Name = "QuitToolStripMenuItem1"
        Me.QuitToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.QuitToolStripMenuItem1.Text = "Quit"
        '
        'btnDeleteNames
        '
        Me.btnDeleteNames.Enabled = False
        Me.btnDeleteNames.Location = New System.Drawing.Point(15, 116)
        Me.btnDeleteNames.Name = "btnDeleteNames"
        Me.btnDeleteNames.Size = New System.Drawing.Size(182, 23)
        Me.btnDeleteNames.TabIndex = 12
        Me.btnDeleteNames.Text = "Delete All Names"
        Me.btnDeleteNames.UseVisualStyleBackColor = True
        '
        'btnDeleteGroups
        '
        Me.btnDeleteGroups.Enabled = False
        Me.btnDeleteGroups.Location = New System.Drawing.Point(245, 117)
        Me.btnDeleteGroups.Name = "btnDeleteGroups"
        Me.btnDeleteGroups.Size = New System.Drawing.Size(182, 23)
        Me.btnDeleteGroups.TabIndex = 13
        Me.btnDeleteGroups.Text = "Delete All Groups"
        Me.btnDeleteGroups.UseVisualStyleBackColor = True
        '
        'Rndomizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 525)
        Me.Controls.Add(Me.btnDeleteGroups)
        Me.Controls.Add(Me.btnDeleteNames)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstBoxGroups)
        Me.Controls.Add(Me.lstBoxStudents)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Rndomizer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Randomizer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lstBoxStudents As System.Windows.Forms.ListBox
    Friend WithEvents lstBoxGroups As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeleteNames As System.Windows.Forms.Button
    Friend WithEvents btnDeleteGroups As System.Windows.Forms.Button

End Class
