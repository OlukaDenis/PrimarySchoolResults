Imports System.Data.SqlClient
Public Class HeadTeacher
    Dim conn As New SqlConnection("Initial Catalog = PrimarySchool; Integrated Security = True;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "insert into Teacher (teacherName, teacherNumber, gender, address, dob, telephone, email, role, nationality, password) values (@teachername, @teachernumber, @gender, @address, @dob, @telephone, @email, @role, @nationality, @password)"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn

            command.Parameters.Add("@teachername", SqlDbType.VarChar).Value = txtTeacherName.Text
            command.Parameters.Add("@teacherNumber", SqlDbType.VarChar).Value = txtTeacherNo.Text
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = TeacherGender.Text
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = txtTeacherAddress.Text
            command.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtTeacherDOB.Text
            command.Parameters.Add("@telephone", SqlDbType.VarChar).Value = txtTeacherTel.Text
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtTeacherEmail.Text
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = teacherRole.Text
            command.Parameters.Add("@nationality", SqlDbType.VarChar).Value = txtTeacherNationality.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtTeacherPass.Text
            command.ExecuteNonQuery()


            MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTeacherName.Clear()
            txtTeacherNo.Clear()
            TeacherGender.Items.Clear()
            teacherRole.Items.Clear()
            txtTeacherAddress.Clear()
            txtTeacherTel.Clear()
            txtTeacherEmail.Clear()
            txtTeacherNationality.Clear()
            txtTeacherPass.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'search teacher
    Private Sub btnSearchTeacher_Click(sender As Object, e As EventArgs) Handles btnSearchTeacher.Click
        Try
            Dim conn As New SqlConnection("Initial Catalog = PrimarySchool; Integrated Security = True;")
            conn.Open()
            Dim teacherDetails As New DataTable
            Dim Searchcommand As New SqlCommand("select Teacher.teacherNumber as 'Teacher Number', Teacher.teacherName as 'Name', Teacher.role as 'Teacher role', Teacher.gender as 'Gender', Teacher.dob as 'Date of Birth', Teacher.telephone as 'Phone', Teacher.email, Teacher.nationality " +
                                          "from Teacher where " +
                                          "Teacher.teacherNumber  like '%" & txtSearchTeacher.Text & "%'" +
                                          "or Teacher.teacherName like '%" & txtSearchTeacher.Text & "%'" +
                                          "or Teacher.email like '%" & txtSearchTeacher.Text & "%'" +
                                          "or Teacher.nationality like '%" & txtSearchTeacher.Text & "%'", conn)
            Dim adapter As New SqlDataAdapter(Searchcommand)
            Dim reader As SqlDataReader = Searchcommand.ExecuteReader()

            teacherDetails.Load(reader)
            reader.Close()
            htViewTeachersdvg.DataSource = teacherDetails
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'view pupils
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click, panelViewpupil.Click
        headteacherTabs.SelectTab(2)
        Try
            conn.Open()
            Dim searchQuery As String = "select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class', Marks.Term, Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                              "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber"
            Dim command As New SqlCommand(searchQuery, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            adapter.Fill(table2)
            htViewPupilsdvg.DataSource = table2
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' button search pupils
    Private Sub htBtnSearch_Click(sender As Object, e As EventArgs) Handles htBtnSearch.Click
        Try
            Dim conn As New SqlConnection("Initial Catalog = PrimarySchool; Integrated Security = True;")
            conn.Open()
            Dim teacherDetails As New DataTable
            Dim Searchcommand As New SqlCommand("select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class', Marks.Term, Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                              "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber where " +
                                              "concat (Pupil.pupilNumber, Pupil.pupilName, Marks.Term) like '%" & htPupilSearch.Text & "%'", conn)
            Dim adapter As New SqlDataAdapter(Searchcommand)
            Dim reader As SqlDataReader = Searchcommand.ExecuteReader()

            teacherDetails.Load(reader)
            reader.Close()
            htViewPupilsdvg.DataSource = teacherDetails
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'FilterData("htPupilSearch.Text")
    End Sub

    'view teachers
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click, panelViewteacher.Click
        headteacherTabs.SelectTab(1)
        Try
            conn.Open()
            Dim searchQuery As String = "select Teacher.teacherNumber as 'Teacher Number', Teacher.teacherName as 'Name', Teacher.role as 'Teacher role', Teacher.gender as 'Gender', Teacher.dob as 'Date of Birth', Teacher.telephone as 'Phone', Teacher.email, Teacher.nationality " +
                                          "from Teacher "
            Dim command As New SqlCommand(searchQuery, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table1 As New DataTable()
            adapter.Fill(table1)
            htViewTeachersdvg.DataSource = table1
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'add teachers
    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click, panelAddteacher.Click
        headteacherTabs.SelectTab(0)
    End Sub

    'profile
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click, panelAdminprofile.Click
        headteacherTabs.SelectTab(3)
        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select * from Teacher where Teacher.teacherNumber = '" & lblheadTeacherNo.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()

            lblTrName.Text = reader.Item("teacherName")
            lablTeachno.Text = reader.Item("teacherNumber")
            lblMale.Text = reader.Item("gender")
            lblAddress.Text = reader.Item("address")
            lblDob.Text = reader.Item("dob")
            lblTel.Text = reader.Item("telephone")
            lblEmail.Text = reader.Item("email")
            lblRole.Text = reader.Item("role")
            lblNation.Text = reader.Item("nationality")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'on load
    Private Sub HeadTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    'teacher report
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Teacher_Report.Show()
    End Sub

    'pupil report
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openReport.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click, Panel12.Click
        Dim logoutBox As Integer = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If logoutBox = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    'delete teacher
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Delete_Teacher.Show()
    End Sub
End Class