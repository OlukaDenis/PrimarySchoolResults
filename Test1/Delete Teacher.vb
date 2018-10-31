Imports System.Data.SqlClient
Public Class Delete_Teacher
    Dim conn As New SqlConnection("Initial Catalog=PrimarySchool;Integrated Security=True;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sqlString As String
            conn.Open()
            sqlString = "DELETE FROM Teacher where Teacher.teacherNumber = '" & TextBox1.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = sqlString
            command.Connection = conn
            command.ExecuteNonQuery()

            MessageBox.Show("Teacher deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class