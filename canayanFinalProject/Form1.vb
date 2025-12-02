Imports System.Data.SqlClient
Imports MySqlConnector

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=canayanfinalprojectdb"

        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Dim query As String = "INSERT INTO hospital_records (name, age, diagnosis, room_number) VALUES (@name, @age, @diagnosis, @room_number)"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=canayanfinalprojectdb")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", TextBoxAge.Text)
                    cmd.Parameters.AddWithValue("@diagnosis", TextBoxDiagnosis.Text)
                    cmd.Parameters.AddWithValue("@room_number", TextBoxRoomNumber.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Inserted Successfully")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBoxAge.Clear()
        TextBoxName.Clear()
        TextBoxDiagnosis.Clear()
        TextBoxRoomNumber.Clear()
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT * FROM canayanfinalprojectdb.hospital_records;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=canayanfinalprojectdb")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("is_deleted").Visible = False
                TextBoxAge.Clear()
                TextBoxName.Clear()
                TextBoxDiagnosis.Clear()
                TextBoxRoomNumber.Clear()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                TextBoxName.Text = row.Cells("name").Value.ToString()
                TextBoxAge.Text = row.Cells("age").Value.ToString()
                TextBoxDiagnosis.Text = row.Cells("diagnosis").Value.ToString()
                TextBoxRoomNumber.Text = row.Cells("roomnumber").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
