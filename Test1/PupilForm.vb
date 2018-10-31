Imports System.Data.SqlClient
Public Class PupilForm
    Private Sub studentLoggedIn_Click(sender As Object, e As EventArgs) Handles studentNameLoggedIn.Click

    End Sub

    Private Sub loadPupil(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select * from Pupil where pupilNumber ='" & stuNoLoggedIn.Text & "'"

            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()

            reader.Read()
            studentNameLoggedIn.Text = reader.Item("pupilName")
            Label9.Text = reader.Item("pupilName")
            Label10.Text = reader.Item("pupilNumber")
            Label11.Text = reader.Item("class")
            Label12.Text = reader.Item("nok")
            Label13.Text = reader.Item("nokTelephone")
            Label14.Text = reader.Item("dateOfBirth")
            Label16.Text = reader.Item("nationality")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'results
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PupilResults.Show()

    End Sub

    'profile
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        profilePanel.Visible = True
        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select * from Pupil where Pupil.pupilNumber = '" & stuNoLoggedIn.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()

            Label9.Text = reader.Item("pupilName")
            Label10.Text = reader.Item("pupilNumber")
            Label11.Text = reader.Item("class")
            Label12.Text = reader.Item("nok")
            Label13.Text = reader.Item("nokTelephone")
            Label14.Text = reader.Item("dateOfBirth")
            Label16.Text = reader.Item("nationality")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim logoutBox As Integer = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If logoutBox = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

End Class