Imports System.Data.SqlClient
Public Class TeacherForm
    Dim conn As New SqlConnection("Initial Catalog=PrimarySchool;Integrated Security=True;")
    Dim pupilDetails As New DataTable

    'Save pupil to the database
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        
    End Sub
    'reset fields
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtPupilNo.Clear()
        txtPName.Clear()
        pGender.Items.Clear()
        pClass.Items.Clear()
        txtPass.Clear()
    End Sub

    
    'add pupils
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "insert into Pupil (pupilNumber, pupilName, dateOfBirth, gender, class, nok, nokTelephone, nationality, password) values (@pupilnumber, @name, @dob, @gender, @class, @nok, @noktel, @nationality, @password)"
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


            MessageBox.Show("Pupil added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub panelAddPupil(sender As Object, e As EventArgs) Handles Panel6.Click, Label11.Click
        teacherTabs.SelectTab(0)

        Panel6.BackColor = Color.AliceBlue
        Label11.ForeColor = Color.FromArgb(0, 115, 153)
        Panel8.BackColor = Color.FromArgb(0, 115, 153)
        Label12.ForeColor = Color.White
        Panel14.BackColor = Color.FromArgb(0, 115, 153)
        Label15.ForeColor = Color.White
        Panel10.BackColor = Color.FromArgb(0, 115, 153)
        Label13.ForeColor = Color.White

        Panel7.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px_2blue
        Panel9.BackgroundImage = My.Resources.Add_Property_40px
        Panel15.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px
        Panel11.BackgroundImage = My.Resources.User_40px

    End Sub

    Private Sub lblAddMarks(sender As Object, e As EventArgs) Handles Panel8.Click, Label12.Click
        teacherTabs.SelectTab(1)
        Panel6.BackColor = Color.FromArgb(0, 115, 153)
        Label11.ForeColor = Color.White
        Panel8.BackColor = Color.AliceBlue
        Label12.ForeColor = Color.FromArgb(0, 115, 153)
        Panel14.BackColor = Color.FromArgb(0, 115, 153)
        Label15.ForeColor = Color.White
        Panel10.BackColor = Color.FromArgb(0, 115, 153)
        Label13.ForeColor = Color.White

        Panel7.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px
        Panel9.BackgroundImage = My.Resources.Add_Property_40px_2blue
        Panel15.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px
        Panel11.BackgroundImage = My.Resources.User_40px
    End Sub

    'populate pupils to the datagridview
    Private Sub lblViewPupils(sender As Object, e As EventArgs) Handles Panel14.Click, Label15.Click
        teacherTabs.SelectTab(2)
        Panel6.BackColor = Color.FromArgb(0, 115, 153)
        Label11.ForeColor = Color.White
        Panel8.BackColor = Color.FromArgb(0, 115, 153)
        Label12.ForeColor = Color.White
        Panel14.BackColor = Color.AliceBlue
        Label15.ForeColor = Color.FromArgb(0, 115, 153)
        Panel10.BackColor = Color.FromArgb(0, 115, 153)
        Label13.ForeColor = Color.White

        Panel7.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px
        Panel9.BackgroundImage = My.Resources.Add_Property_40px
        Panel15.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px_2blue
        Panel11.BackgroundImage = My.Resources.User_40px

        Try
            conn.Open()
            Dim searchQuery As String = "select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class', Marks.Term, Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                              "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber"
            Dim command As New SqlCommand(searchQuery, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            adapter.Fill(table2)
            dgvViewPupils.DataSource = table2
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    'profile
    Private Sub lblProfile(sender As Object, e As EventArgs) Handles Panel10.Click, Label13.Click
        teacherTabs.SelectTab(3)
        Panel6.BackColor = Color.FromArgb(0, 115, 153)
        Label11.ForeColor = Color.White
        Panel8.BackColor = Color.FromArgb(0, 115, 153)
        Label12.ForeColor = Color.White
        Panel14.BackColor = Color.FromArgb(0, 115, 153)
        Label15.ForeColor = Color.White
        Panel10.BackColor = Color.AliceBlue
        Label13.ForeColor = Color.FromArgb(0, 115, 153)


        Panel7.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px
        Panel9.BackgroundImage = My.Resources.Add_Property_40px
        Panel15.BackgroundImage = My.Resources.Add_User_Group_Man_Man_40px
        Panel11.BackgroundImage = My.Resources.User_40px_2blue

        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select * from Teacher where Teacher.teacherNumber = '" & labelteacherNumber.Text & "'"
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

    'logout
    Private Sub lblLogout(sender As Object, e As EventArgs) Handles Panel12.Click, Label14.Click
        Dim logoutBox As Integer = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If logoutBox = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    'add pupils marks
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "insert into Marks (PupilNumber, Term, English, Mathematics, Science, SocialStudies ) values (@pupilnumber, @term, @english, @math, @sci, @sst)"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn

            Dim EngVal As Integer = txtEnglish.Text
            Dim MathVal As Integer = txtMath.Text
            Dim SciVal As Integer = txtScience.Text
            Dim sstVal As Integer = txtSST.Text
            command.Parameters.Add("@pupilnumber", SqlDbType.VarChar).Value = txtPupilNumber.Text
            command.Parameters.Add("@term", SqlDbType.VarChar).Value = txtTerm.Text
            command.Parameters.Add("@english", SqlDbType.VarChar).Value = EngVal
            command.Parameters.Add("@math", SqlDbType.VarChar).Value = MathVal
            command.Parameters.Add("@sci", SqlDbType.VarChar).Value = SciVal
            command.Parameters.Add("@sst", SqlDbType.VarChar).Value = sstVal
            command.ExecuteNonQuery()

            MessageBox.Show("Pupil's marks added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPupilNumber.Clear()
            txtTerm.Items.Clear()
            txtEnglish.Clear()
            txtMath.Clear()
            txtScience.Clear()
            txtSST.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'button search
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            conn.Open()
            Dim dtTable2 As New DataTable
            Dim Searchcommand As New SqlCommand("select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class', Marks.Term, Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                          "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber where " +
                                          "Pupil.pupilNumber like '%" & txtSearch.Text & "%'" +
                                          "or Pupil.pupilName like '%" & txtSearch.Text & "%'" +
                                          "or Pupil.class like '%" & txtSearch.Text & "%'" +
                                          "or Marks.Term like '%" & txtSearch.Text & "%'" +
                                          "or Pupil.gender like '%" & txtSearch.Text & "%'", conn)
            Dim adapter As New SqlDataAdapter(Searchcommand)
            Dim reader As SqlDataReader = Searchcommand.ExecuteReader()
            dtTable2.Load(reader)
            reader.Close()
            dgvViewPupils.DataSource = dtTable2
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'update pupils marks
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Marks_Update.Show()
    End Sub

    'update pupil details
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Update_Pupil_Details.Show()

    End Sub

    'show pupil report
    Private Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click
        openReport.Show()

    End Sub

    'delete pupil
    Private Sub delPupil_Click(sender As Object, e As EventArgs) Handles delPupil.Click
        Delete_Pupil.Show()
    End Sub
End Class