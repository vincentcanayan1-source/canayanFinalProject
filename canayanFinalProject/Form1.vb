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
                    cmd.Parameters.AddWithValue("@id", TextBoxId.Text)
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
        TextBoxId.Clear()
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
                TextBoxId.Clear()
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
                TextBoxId.Text = row.Cells("id").Value.ToString()
                TextBoxName.Text = row.Cells("name").Value.ToString()
                TextBoxAge.Text = row.Cells("age").Value.ToString()
                TextBoxDiagnosis.Text = row.Cells("diagnosis").Value.ToString()
                TextBoxRoomNumber.Text = row.Cells("room_number").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Please select a row first.")
            Exit Sub
        End If

        Dim selectedID As Integer = DataGridView1.CurrentRow.Cells("id").Value

        Dim query As String = "UPDATE hospital_records SET name=@name, age=@age, diagnosis=@diagnosis, room_number=@room_number WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=canayanfinalprojectdb")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", TextBoxAge.Text)
                    cmd.Parameters.AddWithValue("@diagnosis", TextBoxDiagnosis.Text)
                    cmd.Parameters.AddWithValue("@room_number", TextBoxRoomNumber.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Updated Successfully")
                    TextBoxId.Clear()
                    TextBoxAge.Clear()
                    TextBoxName.Clear()
                    TextBoxDiagnosis.Clear()
                    TextBoxRoomNumber.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        LoadData()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("there is no item left")
            Exit Sub
        End If

        Dim selectedID As Integer = DataGridView1.CurrentRow.Cells("id").Value

        Dim query As String = "DELETE FROM hospital_records WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=canayanfinalprojectdb")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record Deleted Successfully")
                    TextBoxId.Clear()
                    TextBoxAge.Clear()
                    TextBoxName.Clear()
                    TextBoxDiagnosis.Clear()
                    TextBoxRoomNumber.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        LoadData()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBoxName.Text = selectedRow.Cells("name").Value.ToString()
            TextBoxAge.Text = selectedRow.Cells("age").Value.ToString()
            TextBoxDiagnosis.Text = selectedRow.Cells("diagnosis").Value.ToString()
            TextBoxRoomNumber.Text = selectedRow.Cells("room_number").Value.ToString()
            TextBoxId.Text = selectedRow.Cells("id").Value.ToString()
        End If
    End Sub
End Class
