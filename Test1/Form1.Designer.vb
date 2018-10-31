<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPupil = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPupilPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPupilNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabTeacher = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtTrPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTrNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tabHM = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtHmPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHmNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblPupil = New System.Windows.Forms.Label()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tabPupil.SuspendLayout()
        Me.tabTeacher.SuspendLayout()
        Me.tabHM.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPupil)
        Me.TabControl1.Controls.Add(Me.tabTeacher)
        Me.TabControl1.Controls.Add(Me.tabHM)
        Me.TabControl1.Location = New System.Drawing.Point(309, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(485, 405)
        Me.TabControl1.TabIndex = 0
        '
        'tabPupil
        '
        Me.tabPupil.BackColor = System.Drawing.Color.LightSeaGreen
        Me.tabPupil.Controls.Add(Me.Label11)
        Me.tabPupil.Controls.Add(Me.Panel5)
        Me.tabPupil.Controls.Add(Me.Button1)
        Me.tabPupil.Controls.Add(Me.txtPupilPass)
        Me.tabPupil.Controls.Add(Me.Label2)
        Me.tabPupil.Controls.Add(Me.txtPupilNo)
        Me.tabPupil.Controls.Add(Me.Label1)
        Me.tabPupil.Location = New System.Drawing.Point(4, 22)
        Me.tabPupil.Name = "tabPupil"
        Me.tabPupil.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPupil.Size = New System.Drawing.Size(477, 379)
        Me.tabPupil.TabIndex = 0
        Me.tabPupil.Text = "Pupils"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(184, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Forgot password?"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.Test1.My.Resources.Resources.Student_Male_100px_2
        Me.Panel5.Location = New System.Drawing.Point(173, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(109, 100)
        Me.Panel5.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(192, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtPupilPass
        '
        Me.txtPupilPass.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtPupilPass.Location = New System.Drawing.Point(142, 238)
        Me.txtPupilPass.Name = "txtPupilPass"
        Me.txtPupilPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPupilPass.Size = New System.Drawing.Size(216, 31)
        Me.txtPupilPass.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(137, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'txtPupilNo
        '
        Me.txtPupilNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPupilNo.Location = New System.Drawing.Point(142, 173)
        Me.txtPupilNo.Name = "txtPupilNo"
        Me.txtPupilNo.Size = New System.Drawing.Size(216, 29)
        Me.txtPupilNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(137, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number "
        '
        'tabTeacher
        '
        Me.tabTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tabTeacher.Controls.Add(Me.Label12)
        Me.tabTeacher.Controls.Add(Me.Panel4)
        Me.tabTeacher.Controls.Add(Me.txtTrPass)
        Me.tabTeacher.Controls.Add(Me.Label4)
        Me.tabTeacher.Controls.Add(Me.txtTrNumber)
        Me.tabTeacher.Controls.Add(Me.Label3)
        Me.tabTeacher.Controls.Add(Me.Button2)
        Me.tabTeacher.Location = New System.Drawing.Point(4, 22)
        Me.tabTeacher.Name = "tabTeacher"
        Me.tabTeacher.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTeacher.Size = New System.Drawing.Size(477, 379)
        Me.tabTeacher.TabIndex = 1
        Me.tabTeacher.Text = "Academic Teacher"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(190, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Forgot password?"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Test1.My.Resources.Resources.Classroom_100px
        Me.Panel4.Location = New System.Drawing.Point(182, 14)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(107, 97)
        Me.Panel4.TabIndex = 3
        '
        'txtTrPass
        '
        Me.txtTrPass.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtTrPass.Location = New System.Drawing.Point(131, 226)
        Me.txtTrPass.Name = "txtTrPass"
        Me.txtTrPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtTrPass.Size = New System.Drawing.Size(233, 31)
        Me.txtTrPass.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(126, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password:"
        '
        'txtTrNumber
        '
        Me.txtTrNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrNumber.Location = New System.Drawing.Point(131, 152)
        Me.txtTrNumber.Name = "txtTrNumber"
        Me.txtTrNumber.Size = New System.Drawing.Size(233, 29)
        Me.txtTrNumber.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(126, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Teacher Number: "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(193, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "LOGIN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tabHM
        '
        Me.tabHM.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.tabHM.Controls.Add(Me.Label13)
        Me.tabHM.Controls.Add(Me.Button3)
        Me.tabHM.Controls.Add(Me.txtHmPass)
        Me.tabHM.Controls.Add(Me.Label9)
        Me.tabHM.Controls.Add(Me.txtHmNumber)
        Me.tabHM.Controls.Add(Me.Label8)
        Me.tabHM.Controls.Add(Me.Panel3)
        Me.tabHM.Location = New System.Drawing.Point(4, 22)
        Me.tabHM.Name = "tabHM"
        Me.tabHM.Size = New System.Drawing.Size(477, 379)
        Me.tabHM.TabIndex = 2
        Me.tabHM.Text = "Head Teacher"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(171, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Forgot password?"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lavender
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(173, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "LOGIN"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtHmPass
        '
        Me.txtHmPass.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHmPass.Location = New System.Drawing.Point(145, 220)
        Me.txtHmPass.Name = "txtHmPass"
        Me.txtHmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtHmPass.Size = New System.Drawing.Size(193, 31)
        Me.txtHmPass.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(140, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Password:"
        '
        'txtHmNumber
        '
        Me.txtHmNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHmNumber.Location = New System.Drawing.Point(145, 155)
        Me.txtHmNumber.Name = "txtHmNumber"
        Me.txtHmNumber.Size = New System.Drawing.Size(193, 26)
        Me.txtHmNumber.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(140, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Teacher Number: "
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Test1.My.Resources.Resources.School_Director_100px
        Me.Panel3.Location = New System.Drawing.Point(185, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 94)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lblHead)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 94)
        Me.Panel1.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel6.Controls.Add(Me.lblPupil)
        Me.Panel6.Location = New System.Drawing.Point(314, 61)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(155, 34)
        Me.Panel6.TabIndex = 4
        '
        'lblPupil
        '
        Me.lblPupil.AutoSize = True
        Me.lblPupil.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblPupil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPupil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPupil.Location = New System.Drawing.Point(54, 0)
        Me.lblPupil.Name = "lblPupil"
        Me.lblPupil.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPupil.Size = New System.Drawing.Size(62, 34)
        Me.lblPupil.TabIndex = 1
        Me.lblPupil.Text = "Pupil"
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHead.Location = New System.Drawing.Point(472, 14)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(135, 26)
        Me.lblHead.TabIndex = 4
        Me.lblHead.Text = "Pupil's Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(648, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(142, 34)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Head Teacher"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(467, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(181, 34)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Academic Teacher"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(36, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(226, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = " MANAGEMENT SYSTEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(0, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NDEJJE PRIMARY SCHOOL RESULTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 342)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPupil.ResumeLayout(False)
        Me.tabPupil.PerformLayout()
        Me.tabTeacher.ResumeLayout(False)
        Me.tabTeacher.PerformLayout()
        Me.tabHM.ResumeLayout(False)
        Me.tabHM.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPupil As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPupilPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPupilNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabTeacher As System.Windows.Forms.TabPage
    Friend WithEvents txtTrPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTrNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPupil As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tabHM As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents txtHmPass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHmNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
