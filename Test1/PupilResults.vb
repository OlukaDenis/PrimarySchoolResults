
Imports System.Data.SqlClient
Public Class PupilResults
    Private Sub PupilResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class', Marks.Term, Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                          "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber where Pupil.pupilNumber = '" & rstPupilNumber.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                If reader.Read() Then
                    Dim newEngMark As Integer = reader.Item("English")
                    Dim newMtcMark As Integer = reader.Item("Mathematics")
                    Dim newSciMark As Integer = reader.Item("Science")
                    Dim newSstMark As Integer = reader.Item("SocialStudies")

                    engMark.Text = newEngMark
                    mtcMark.Text = newMtcMark
                    sciMark.Text = newSciMark
                    sstMark.Text = newSstMark

                    'grading for english
                    Select Case newEngMark
                        Case Is >= 90
                            gradeEng.Text = "D1"
                        Case Is >= 80
                            gradeEng.Text = "D2"
                        Case Is >= 75
                            gradeEng.Text = "C3"
                        Case Is >= 65
                            gradeEng.Text = "C4"
                        Case Is >= 65
                            gradeEng.Text = "C4"
                        Case Is >= 60
                            gradeEng.Text = "C5"
                        Case Is >= 55
                            gradeEng.Text = "C6"
                        Case Is >= 50
                            gradeEng.Text = "P7"
                        Case Is >= 45
                            gradeEng.Text = "P8"
                        Case Is < 45
                            gradeEng.Text = "F9"
                    End Select

                    'grading for mathematics
                    Select Case newMtcMark
                        Case Is >= 90
                            gradeMTC.Text = "D1"
                        Case Is >= 80
                            gradeMTC.Text = "D2"
                        Case Is >= 75
                            gradeMTC.Text = "C3"
                        Case Is >= 65
                            gradeMTC.Text = "C4"
                        Case Is >= 65
                            gradeMTC.Text = "C4"
                        Case Is >= 60
                            gradeMTC.Text = "C5"
                        Case Is >= 55
                            gradeMTC.Text = "C6"
                        Case Is >= 50
                            gradeMTC.Text = "P7"
                        Case Is >= 45
                            gradeMTC.Text = "P8"
                        Case Is < 45
                            gradeMTC.Text = "F9"
                    End Select

                    'grading for science
                    Select Case newSciMark
                        Case Is >= 90
                            gradeSci.Text = "D1"
                        Case Is >= 80
                            gradeSci.Text = "D2"
                        Case Is >= 75
                            gradeSci.Text = "C3"
                        Case Is >= 65
                            gradeSci.Text = "C4"
                        Case Is >= 65
                            gradeSci.Text = "C4"
                        Case Is >= 60
                            gradeSci.Text = "C5"
                        Case Is >= 55
                            gradeSci.Text = "C6"
                        Case Is >= 50
                            gradeSci.Text = "P7"
                        Case Is >= 45
                            gradeSci.Text = "P8"
                        Case Is < 45
                            gradeSci.Text = "F9"
                    End Select


                    'grading for sst
                    Select Case newSstMark
                        Case Is >= 90
                            gradeSST.Text = "D1"
                        Case Is >= 80
                            gradeSST.Text = "D2"
                        Case Is >= 75
                            gradeSST.Text = "C3"
                        Case Is >= 65
                            gradeSST.Text = "C4"
                        Case Is >= 65
                            gradeSST.Text = "C4"
                        Case Is >= 60
                            gradeSST.Text = "C5"
                        Case Is >= 55
                            gradeSST.Text = "C6"
                        Case Is >= 50
                            gradeSST.Text = "P7"
                        Case Is >= 45
                            gradeSST.Text = "P8"
                        Case Is < 45
                            gradeSST.Text = "F9"
                    End Select
                    'getting the total marks
                    Dim total As Integer
                    total = newEngMark + newMtcMark + newSciMark + newSstMark
                    totalMarks.Text = total

                    reader.Close()
                End If

            Else
                reader.Close()
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'term one results
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim term1 As String = "Term 1"
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class', Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                          "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber where Marks.Term = '" & term1 & "' and Pupil.pupilNumber = '" & rstPupilNumber.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()

            Dim newEngMark As Integer = reader.Item("English")
            Dim newMtcMark As Integer = reader.Item("Mathematics")
            Dim newSciMark As Integer = reader.Item("Science")
            Dim newSstMark As Integer = reader.Item("SocialStudies")

            engMark.Text = newEngMark
            mtcMark.Text = newMtcMark
            sciMark.Text = newSciMark
            sstMark.Text = newSstMark

            'grading for english
            Select Case newEngMark
                Case Is >= 90
                    gradeEng.Text = "D1"
                Case Is >= 80
                    gradeEng.Text = "D2"
                Case Is >= 75
                    gradeEng.Text = "C3"
                Case Is >= 65
                    gradeEng.Text = "C4"
                Case Is >= 65
                    gradeEng.Text = "C4"
                Case Is >= 60
                    gradeEng.Text = "C5"
                Case Is >= 55
                    gradeEng.Text = "C6"
                Case Is >= 50
                    gradeEng.Text = "P7"
                Case Is >= 45
                    gradeEng.Text = "P8"
                Case Is < 45
                    gradeEng.Text = "F9"
            End Select

            'grading for mathematics
            Select Case newMtcMark
                Case Is >= 90
                    gradeMTC.Text = "D1"
                Case Is >= 80
                    gradeMTC.Text = "D2"
                Case Is >= 75
                    gradeMTC.Text = "C3"
                Case Is >= 65
                    gradeMTC.Text = "C4"
                Case Is >= 65
                    gradeMTC.Text = "C4"
                Case Is >= 60
                    gradeMTC.Text = "C5"
                Case Is >= 55
                    gradeMTC.Text = "C6"
                Case Is >= 50
                    gradeMTC.Text = "P7"
                Case Is >= 45
                    gradeMTC.Text = "P8"
                Case Is < 45
                    gradeMTC.Text = "F9"
            End Select

            'grading for science
            Select Case newSciMark
                Case Is >= 90
                    gradeSci.Text = "D1"
                Case Is >= 80
                    gradeSci.Text = "D2"
                Case Is >= 75
                    gradeSci.Text = "C3"
                Case Is >= 65
                    gradeSci.Text = "C4"
                Case Is >= 65
                    gradeSci.Text = "C4"
                Case Is >= 60
                    gradeSci.Text = "C5"
                Case Is >= 55
                    gradeSci.Text = "C6"
                Case Is >= 50
                    gradeSci.Text = "P7"
                Case Is >= 45
                    gradeSci.Text = "P8"
                Case Is < 45
                    gradeSci.Text = "F9"
            End Select


            'grading for sst
            Select Case newSstMark
                Case Is >= 90
                    gradeSST.Text = "D1"
                Case Is >= 80
                    gradeSST.Text = "D2"
                Case Is >= 75
                    gradeSST.Text = "C3"
                Case Is >= 65
                    gradeSST.Text = "C4"
                Case Is >= 65
                    gradeSST.Text = "C4"
                Case Is >= 60
                    gradeSST.Text = "C5"
                Case Is >= 55
                    gradeSST.Text = "C6"
                Case Is >= 50
                    gradeSST.Text = "P7"
                Case Is >= 45
                    gradeSST.Text = "P8"
                Case Is < 45
                    gradeSST.Text = "F9"
            End Select

            'getting the total marks
            Dim total As Integer
            total = newEngMark + newMtcMark + newSciMark + newSstMark
            totalMarks.Text = total

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    'term2 results
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim term2 As String = "Term 2"
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class',  Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                          "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber where Marks.Term = '" & term2 & "' and Pupil.pupilNumber = '" & rstPupilNumber.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()
            Dim newEngMark As Integer = reader.Item("English")
            Dim newMtcMark As Integer = reader.Item("Mathematics")
            Dim newSciMark As Integer = reader.Item("Science")
            Dim newSstMark As Integer = reader.Item("SocialStudies")

            engMark.Text = newEngMark
            mtcMark.Text = newMtcMark
            sciMark.Text = newSciMark
            sstMark.Text = newSstMark

            'grading for english
            Select Case newEngMark
                Case Is >= 90
                    gradeEng.Text = "D1"
                Case Is >= 80
                    gradeEng.Text = "D2"
                Case Is >= 75
                    gradeEng.Text = "C3"
                Case Is >= 65
                    gradeEng.Text = "C4"
                Case Is >= 65
                    gradeEng.Text = "C4"
                Case Is >= 60
                    gradeEng.Text = "C5"
                Case Is >= 55
                    gradeEng.Text = "C6"
                Case Is >= 50
                    gradeEng.Text = "P7"
                Case Is >= 45
                    gradeEng.Text = "P8"
                Case Is < 45
                    gradeEng.Text = "F9"
            End Select

            'grading for mathematics
            Select Case newMtcMark
                Case Is >= 90
                    gradeMTC.Text = "D1"
                Case Is >= 80
                    gradeMTC.Text = "D2"
                Case Is >= 75
                    gradeMTC.Text = "C3"
                Case Is >= 65
                    gradeMTC.Text = "C4"
                Case Is >= 65
                    gradeMTC.Text = "C4"
                Case Is >= 60
                    gradeMTC.Text = "C5"
                Case Is >= 55
                    gradeMTC.Text = "C6"
                Case Is >= 50
                    gradeMTC.Text = "P7"
                Case Is >= 45
                    gradeMTC.Text = "P8"
                Case Is < 45
                    gradeMTC.Text = "F9"
            End Select

            'grading for science
            Select Case newSciMark
                Case Is >= 90
                    gradeSci.Text = "D1"
                Case Is >= 80
                    gradeSci.Text = "D2"
                Case Is >= 75
                    gradeSci.Text = "C3"
                Case Is >= 65
                    gradeSci.Text = "C4"
                Case Is >= 65
                    gradeSci.Text = "C4"
                Case Is >= 60
                    gradeSci.Text = "C5"
                Case Is >= 55
                    gradeSci.Text = "C6"
                Case Is >= 50
                    gradeSci.Text = "P7"
                Case Is >= 45
                    gradeSci.Text = "P8"
                Case Is < 45
                    gradeSci.Text = "F9"
            End Select


            'grading for sst
            Select Case newSstMark
                Case Is >= 90
                    gradeSST.Text = "D1"
                Case Is >= 80
                    gradeSST.Text = "D2"
                Case Is >= 75
                    gradeSST.Text = "C3"
                Case Is >= 65
                    gradeSST.Text = "C4"
                Case Is >= 65
                    gradeSST.Text = "C4"
                Case Is >= 60
                    gradeSST.Text = "C5"
                Case Is >= 55
                    gradeSST.Text = "C6"
                Case Is >= 50
                    gradeSST.Text = "P7"
                Case Is >= 45
                    gradeSST.Text = "P8"
                Case Is < 45
                    gradeSST.Text = "F9"
            End Select
            'getting the total
            Dim total As Integer
            total = newEngMark + newMtcMark + newSciMark + newSstMark
            totalMarks.Text = total
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'term 3 results
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim term3 As String = "Term 3"
            Dim dtPupil As New DataTable
            Dim strConn As String = "Initial Catalog = PrimarySchool; Integrated Security = True;"
            Dim conn As New SqlConnection
            conn.ConnectionString = strConn
            conn.Open()

            Dim strCommand = "select Pupil.pupilNumber as 'Pupil Number', Pupil.pupilName as 'Name', Pupil.gender as 'Gender', Pupil.dateOfBirth as 'Date of Birth', Pupil.class as 'Class',  Marks.English, Marks.Mathematics, Marks.Science, Marks.SocialStudies " +
                                          "from Pupil full outer join Marks on Pupil.pupilNumber = Marks.PupilNumber where Marks.Term = '" & term3 & "' and Pupil.pupilNumber = '" & rstPupilNumber.Text & "'"
            Dim command As New SqlCommand
            command.CommandText = strCommand
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(dtPupil)

            Dim reader As SqlDataReader = command.ExecuteReader()

            reader.Read()
            Dim newEngMark As Integer = reader.Item("English")
            Dim newMtcMark As Integer = reader.Item("Mathematics")
            Dim newSciMark As Integer = reader.Item("Science")
            Dim newSstMark As Integer = reader.Item("SocialStudies")

            engMark.Text = newEngMark
            mtcMark.Text = newMtcMark
            sciMark.Text = newSciMark
            sstMark.Text = newSstMark

            'grading for english
            Select Case newEngMark
                Case Is >= 90
                    gradeEng.Text = "D1"
                Case Is >= 80
                    gradeEng.Text = "D2"
                Case Is >= 75
                    gradeEng.Text = "C3"
                Case Is >= 65
                    gradeEng.Text = "C4"
                Case Is >= 65
                    gradeEng.Text = "C4"
                Case Is >= 60
                    gradeEng.Text = "C5"
                Case Is >= 55
                    gradeEng.Text = "C6"
                Case Is >= 50
                    gradeEng.Text = "P7"
                Case Is >= 45
                    gradeEng.Text = "P8"
                Case Is < 45
                    gradeEng.Text = "F9"
            End Select

            'grading for mathematics
            Select Case newMtcMark
                Case Is >= 90
                    gradeMTC.Text = "D1"
                Case Is >= 80
                    gradeMTC.Text = "D2"
                Case Is >= 75
                    gradeMTC.Text = "C3"
                Case Is >= 65
                    gradeMTC.Text = "C4"
                Case Is >= 65
                    gradeMTC.Text = "C4"
                Case Is >= 60
                    gradeMTC.Text = "C5"
                Case Is >= 55
                    gradeMTC.Text = "C6"
                Case Is >= 50
                    gradeMTC.Text = "P7"
                Case Is >= 45
                    gradeMTC.Text = "P8"
                Case Is < 45
                    gradeMTC.Text = "F9"
            End Select

            'grading for science
            Select Case newSciMark
                Case Is >= 90
                    gradeSci.Text = "D1"
                Case Is >= 80
                    gradeSci.Text = "D2"
                Case Is >= 75
                    gradeSci.Text = "C3"
                Case Is >= 65
                    gradeSci.Text = "C4"
                Case Is >= 65
                    gradeSci.Text = "C4"
                Case Is >= 60
                    gradeSci.Text = "C5"
                Case Is >= 55
                    gradeSci.Text = "C6"
                Case Is >= 50
                    gradeSci.Text = "P7"
                Case Is >= 45
                    gradeSci.Text = "P8"
                Case Is < 45
                    gradeSci.Text = "F9"
            End Select


            'grading for sst
            Select Case newSstMark
                Case Is >= 90
                    gradeSST.Text = "D1"
                Case Is >= 80
                    gradeSST.Text = "D2"
                Case Is >= 75
                    gradeSST.Text = "C3"
                Case Is >= 65
                    gradeSST.Text = "C4"
                Case Is >= 65
                    gradeSST.Text = "C4"
                Case Is >= 60
                    gradeSST.Text = "C5"
                Case Is >= 55
                    gradeSST.Text = "C6"
                Case Is >= 50
                    gradeSST.Text = "P7"
                Case Is >= 45
                    gradeSST.Text = "P8"
                Case Is < 45
                    gradeSST.Text = "F9"
            End Select

            'getting the total marks
            Dim total As Integer
            total = newEngMark + newMtcMark + newSciMark + newSstMark
            totalMarks.Text = total
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class