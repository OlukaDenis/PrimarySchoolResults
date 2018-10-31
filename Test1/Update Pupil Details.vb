Imports System.Data.SqlClient
Public Class Update_Pupil_Details

    Private Sub selectPupilNumber(sender As Object, e As KeyPressEventArgs) Handles txtPupilNo.KeyPress
        
    End Sub

    'find pupil number
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select * from Pupil where Pupil.pupilNumber = '" & txtPupilNo.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()

            txtPName.Text = reader.Item("pupilName")
            txtDOB.Text = reader.Item("dateOfBirth")
            txtNationality.Text = reader.Item("nationality")
            txtNok.Text = reader.Item("nok")
            txtNokTel.Text = reader.Item("nokTelephone")
            txtPass.Text = reader.Item("password")
            pGender.Text = reader.Item("gender")
            pClass.Text = reader.Item("class")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'update students details
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "UPDATE Pupil  SET pupilNumber = @pupilnumber, pupilName = @name , dateOfBirth = @dob , gender = @gender, class = @class, nok = @nok, nokTelephone = @noktel, nationality = @nationality," +
                " password = @password WHERE pupilNumber = @pupilnumber "
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn

            command.Parameters.Add("@pupilnumber", SqlDbType.VarChar).Value = txtPupilNo.Text
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = txtPName.Text
            command.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtDOB.Text
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = pGender.Text
            command.Parameters.Add("@class", SqlDbType.VarChar).Value = pClass.Text
            command.Parameters.Add("@nok", SqlDbType.VarChar).Value = txtNok.Text
            command.Parameters.Add("@noktel", SqlDbType.VarChar).Value = txtNokTel.Text
            command.Parameters.Add("@nationality", SqlDbType.VarChar).Value = txtNationality.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPass.Text
            command.ExecuteNonQuery()


            MessageBox.Show("Pupil's details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPupilNo.Clear()
            txtPName.Clear()
            pGender.Items.Clear()
            pClass.Items.Clear()
            txtPass.Clear()
            txtNok.Clear()
            txtNokTel.Clear()
            txtNationality.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class