Imports System.Data.SqlClient
Public Class openReport
    Dim conn As New SqlConnection("Initial Catalog=PrimarySchool;Integrated Security=True;")

    Private Sub openReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim table As New DataSet
        Dim sqlString As String
        Dim adapter As New SqlDataAdapter

        Try
            conn.Open()
            sqlString = "select * from Pupil "
            Dim command As New SqlCommand(sqlString, conn)
            adapter.SelectCommand = command
            adapter.Fill(table, "Pupil")
            Dim report As New PupilsAloneReport
            report.SetDataSource(table)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            command.Dispose()
            table.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub searchReport_Click(sender As Object, e As EventArgs) Handles searchReport.Click
        'CrystalReportViewer1.ReportSource = Application.StartupPath + "\PupilsAloneReport.rpt"

        Dim table As New DataSet
        Dim sqlString As String
        Dim adapter As New SqlDataAdapter

        Try
            conn.Open()
            sqlString = "select * from Pupil "
            Dim command As New SqlCommand(sqlString, conn)
            adapter.SelectCommand = command
            adapter.Fill(table, "Pupil")
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{Pupil.pupilNumber} = '" & txtReportKeyword.Text.ToString & "'"
            CrystalReportViewer1.RefreshReport()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

End Class