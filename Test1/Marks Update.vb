Imports System.Data.SqlClient
Public Class Marks_Update

    'find pupil number
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select * from Marks where PupilNumber  = '" & txtPupilNumber.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()

            txtTerm.Text = reader.Item("Term")
            txtEnglish.Text = reader.Item("English")
            txtMath.Text = reader.Item("Mathematics")
            txtScience.Text = reader.Item("Science")
            txtSST.Text = reader.Item("SocialStudies")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "UPDATE Marks  SET PupilNumber = @pupilnumber, Term = @term , English = @eng , Mathematics = @mtc, Science = @sci, SocialStudies = @sst" +
                " WHERE PupilNumber = @pupilnumber "
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn

            command.Parameters.Add("@pupilnumber", SqlDbType.VarChar).Value = txtPupilNumber.Text
            command.Parameters.Add("@term", SqlDbType.VarChar).Value = txtTerm.Text
            command.Parameters.Add("@eng", SqlDbType.VarChar).Value = txtEnglish.Text
            command.Parameters.Add("@mtc", SqlDbType.VarChar).Value = txtMath.Text
            command.Parameters.Add("@sci", SqlDbType.VarChar).Value = txtScience.Text
            command.Parameters.Add("@sst", SqlDbType.VarChar).Value = txtSST.Text
            command.ExecuteNonQuery()


            MessageBox.Show("Pupil's details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPupilNumber.Clear()
            txtEnglish.Clear()
            txtMath.Clear()
            txtTerm.Text = ""
            txtScience.Clear()
            txtSST.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class