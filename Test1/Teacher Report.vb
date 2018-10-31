Imports System.Data.SqlClient
Public Class Teacher_Report
    Dim conn As New SqlConnection("Initial Catalog=PrimarySchool;Integrated Security=True;")
    Private Sub searchReport_Click(sender As Object, e As EventArgs) Handles searchReport.Click
        'teacherCrystalView.ReportSource = Application.StartupPath + "\TeacherCrystalReport.rpt"
       
        Dim table As New DataSet
        Dim sqlString As String
        Dim adapter As New SqlDataAdapter
        Try
            conn.Open()
            sqlString = "select * from Teacher"
            Dim command As New SqlCommand(sqlString, conn)
            adapter.SelectCommand = command
            adapter.Fill(table, "Teacher")
            teacherCrystalView.RefreshReport()
            teacherCrystalView.SelectionFormula = "{Teacher.teacherName} = '" & txtReportKeyword.Text.ToString & "'"
            teacherCrystalView.RefreshReport()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Teacher_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As New DataSet
        Dim sqlString As String
        Dim adapter As New SqlDataAdapter

        Try
            conn.Open()
            sqlString = "select * from Teacher"
            Dim command As New SqlCommand(sqlString, conn)
            adapter.SelectCommand = command
            adapter.Fill(table, "Teacher")
            Dim report As New TeacherCrystalReport
            report.SetDataSource(table)
            teacherCrystalView.ReportSource = report
            teacherCrystalView.Refresh()
            command.Dispose()
            table.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class