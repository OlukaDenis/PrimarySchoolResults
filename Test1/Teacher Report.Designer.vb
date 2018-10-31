<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.searchReport = New System.Windows.Forms.Button()
        Me.txtReportKeyword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teacherCrystalView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TeacherCrystalReport2 = New Test1.TeacherCrystalReport()
        Me.TeacherCrystalReport1 = New Test1.TeacherCrystalReport()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.searchReport)
        Me.Panel1.Controls.Add(Me.txtReportKeyword)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 69)
        Me.Panel1.TabIndex = 1
        '
        'searchReport
        '
        Me.searchReport.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReport.Location = New System.Drawing.Point(766, 25)
        Me.searchReport.Name = "searchReport"
        Me.searchReport.Size = New System.Drawing.Size(75, 27)
        Me.searchReport.TabIndex = 2
        Me.searchReport.Text = "Search"
        Me.searchReport.UseVisualStyleBackColor = False
        '
        'txtReportKeyword
        '
        Me.txtReportKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportKeyword.Location = New System.Drawing.Point(573, 25)
        Me.txtReportKeyword.Name = "txtReportKeyword"
        Me.txtReportKeyword.Size = New System.Drawing.Size(187, 26)
        Me.txtReportKeyword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reports"
        '
        'teacherCrystalView
        '
        Me.teacherCrystalView.ActiveViewIndex = 0
        Me.teacherCrystalView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teacherCrystalView.Cursor = System.Windows.Forms.Cursors.Default
        Me.teacherCrystalView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teacherCrystalView.Location = New System.Drawing.Point(0, 69)
        Me.teacherCrystalView.Name = "teacherCrystalView"
        Me.teacherCrystalView.ReportSource = Me.TeacherCrystalReport2
        Me.teacherCrystalView.Size = New System.Drawing.Size(951, 470)
        Me.teacherCrystalView.TabIndex = 2
        Me.teacherCrystalView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Teacher_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 539)
        Me.Controls.Add(Me.teacherCrystalView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Teacher_Report"
        Me.Text = "Teacher_Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents searchReport As System.Windows.Forms.Button
    Friend WithEvents txtReportKeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teacherCrystalView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TeacherCrystalReport1 As Test1.TeacherCrystalReport
    Friend WithEvents TeacherCrystalReport2 As Test1.TeacherCrystalReport
End Class
