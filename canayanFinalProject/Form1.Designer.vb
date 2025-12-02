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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(380, 57)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 0
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(380, 83)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAge.TabIndex = 1
        '
        'TextBoxDiagnosis
        '
        Me.TextBoxDiagnosis.Location = New System.Drawing.Point(380, 109)
        Me.TextBoxDiagnosis.Name = "TextBoxDiagnosis"
        Me.TextBoxDiagnosis.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDiagnosis.TabIndex = 2
        '
        'TextBoxRoomNumber
        '
        Me.TextBoxRoomNumber.Location = New System.Drawing.Point(380, 135)
        Me.TextBoxRoomNumber.Name = "TextBoxRoomNumber"
        Me.TextBoxRoomNumber.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRoomNumber.TabIndex = 3
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(380, 28)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(100, 23)
        Me.ButtonConnect.TabIndex = 6
        Me.ButtonConnect.Text = "Connect to SQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(380, 161)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "Insert"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(380, 190)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRead.TabIndex = 8
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(297, 216)
        Me.DataGridView1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.TextBoxRoomNumber)
        Me.Controls.Add(Me.TextBoxDiagnosis)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.TextBoxName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxDiagnosis As TextBox
    Friend WithEvents TextBoxRoomNumber As TextBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
