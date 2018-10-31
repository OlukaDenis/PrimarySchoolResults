Imports System.Data.SqlClient
Public Class ForgotPassword
    Dim conn As New SqlConnection("Initial Catalog=PrimarySchool;Integrated Security=True;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conn.Open()
            Dim command As New SqlCommand("select * from Pupil where pupilNumber = @pupilnumber", conn)
            command.Parameters.Add("@pupilNumber", SqlDbType.VarChar).Value = pupilForgotPassword.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() <= 0 Then
                MessageBox.Show("Pupil Number does not exist!")
            Else
                Me.Hide()
                New_Password.pupilID.Text = pupilForgotPassword.Text
                New_Password.Show()
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class