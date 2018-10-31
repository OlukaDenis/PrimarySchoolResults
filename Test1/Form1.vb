Imports System.Data.SqlClient
Public Class Form1
    Dim conn As New SqlConnection("Initial Catalog=PrimarySchool;Integrated Security=True;")

    'Pupil login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim command As New SqlCommand("select * from Pupil where pupilNumber = @pupilnumber and password = @password", conn)
            command.Parameters.Add("@pupilnumber", SqlDbType.VarChar).Value = txtPupilNo.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPupilPass.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            'setting the student number in the pupil form window
            PupilForm.stuNoLoggedIn.Text = txtPupilNo.Text
            If table.Rows.Count() <= 0 Then

                MessageBox.Show("Wrong Studentnummber or Password")
            Else
                Me.Hide()
                PupilForm.Show()
                'setting the student number in the pupil form window
                PupilResults.rstPupilNumber.Text = txtPupilNo.Text


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblPupil_Click(sender As Object, e As EventArgs) Handles lblPupil.Click
        TabControl1.SelectTab(0)
        lblHead.Text = "Pupil's Login "
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TabControl1.SelectTab(1)
        lblHead.Text = "Teacher's Login "
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TabControl1.SelectTab(2)
        lblHead.Text = "Headteacher's Login "
    End Sub

    'ACademic teachers login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim command As New SqlCommand("select * from Teacher where teacherNumber = @teachernumber and password = @password and role = 'Academic Teacher'", conn)
            command.Parameters.Add("@teachernumber", SqlDbType.VarChar).Value = txtTrNumber.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtTrPass.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                If txtTrNumber.Text Is Nothing Then
                    MessageBox.Show("Empty Teacher number field")
                ElseIf txtTrPass.Text Is Nothing Then
                    MessageBox.Show("Empty Teacher password field")
               
                End If
                MessageBox.Show("Wrong Teacher nummber or Password")
            Else
                txtTrNumber.Clear()
                txtTrPass.Clear()
                Me.Hide()
                TeacherForm.Show()
                TeacherForm.labelteacherNumber.Text = txtTrNumber.Text

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Headteacher login
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim command As New SqlCommand("select * from Teacher where teacherNumber = @teachernumber and password = @password and role = 'Head Teacher'", conn)
            command.Parameters.Add("@teachernumber", SqlDbType.VarChar).Value = txtHmNumber.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtHmPass.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then

                MessageBox.Show("Wrong Teacher nummber or Password")
            Else
                Me.Hide()
                HeadTeacher.Show()
                HeadTeacher.lblheadTeacherNo.Text = txtHmNumber.Text

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'forgot password
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ForgotPassword.Show()
    End Sub
End Class
