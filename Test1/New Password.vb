Imports System.Data.SqlClient
Public Class New_Password

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            If Not newPassword.Text = repeatNewPassword.Text Then
                MessageBox.Show("Passwords do not match!")
            Else
                Dim strCommand = "update  Pupil set password = @newpassword where pupilNumber = @pupilNumber"
                Dim command As New SqlCommand
                command.CommandText = strCommand
                command.Connection = conn

                command.Parameters.Add("@pupilNumber", SqlDbType.VarChar).Value = pupilID.Text
                command.Parameters.Add("@newpassword", SqlDbType.VarChar).Value = repeatNewPassword.Text
                command.ExecuteNonQuery()

                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

                newPassword.Text = ""
                repeatNewPassword.Text = ""
                conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class