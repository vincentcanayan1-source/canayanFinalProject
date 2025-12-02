<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxDiagnosis = New System.Windows.Forms.TextBox()
        Me.TextBoxRoomNumber = New System.Windows.Forms.TextBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(104, 41)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxName.TabIndex = 0
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(104, 67)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxAge.TabIndex = 1
        '
        'TextBoxDiagnosis
        '
        Me.TextBoxDiagnosis.Location = New System.Drawing.Point(104, 93)
        Me.TextBoxDiagnosis.Name = "TextBoxDiagnosis"
        Me.TextBoxDiagnosis.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxDiagnosis.TabIndex = 2
        '
        'TextBoxRoomNumber
        '
        Me.TextBoxRoomNumber.Location = New System.Drawing.Point(104, 119)
        Me.TextBoxRoomNumber.Name = "TextBoxRoomNumber"
        Me.TextBoxRoomNumber.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxRoomNumber.TabIndex = 3
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonConnect.Location = New System.Drawing.Point(267, 19)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(186, 42)
        Me.ButtonConnect.TabIndex = 6
        Me.ButtonConnect.Text = "Connect to SQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonInsert
        '
        Me.ButtonInsert.BackColor = System.Drawing.SystemColors.Info
        Me.ButtonInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonInsert.Location = New System.Drawing.Point(267, 74)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(90, 39)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "Insert"
        Me.ButtonInsert.UseVisualStyleBackColor = False
        '
        'ButtonRead
        '
        Me.ButtonRead.BackColor = System.Drawing.SystemColors.Info
        Me.ButtonRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonRead.Location = New System.Drawing.Point(267, 119)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(90, 39)
        Me.ButtonRead.TabIndex = 8
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 255)
        Me.DataGridView1.TabIndex = 9
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonUpdate.Location = New System.Drawing.Point(363, 74)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(90, 39)
        Me.ButtonUpdate.TabIndex = 10
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.SystemColors.Info
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonDelete.Location = New System.Drawing.Point(363, 119)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(90, 39)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(55, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(66, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(30, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "diagnosis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "room number"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxAge)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxDiagnosis)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxRoomNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonInsert)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonRead)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 425)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxDiagnosis As TextBox
    Friend WithEvents TextBoxRoomNumber As TextBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
