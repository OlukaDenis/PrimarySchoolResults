<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Password
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.newPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.repeatNewPassword = New System.Windows.Forms.TextBox()
        Me.pupilID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(239, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'newPassword
        '
        Me.newPassword.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.newPassword.Location = New System.Drawing.Point(165, 125)
        Me.newPassword.Multiline = True
        Me.newPassword.Name = "newPassword"
        Me.newPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(111)
        Me.newPassword.Size = New System.Drawing.Size(269, 41)
        Me.newPassword.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 62)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(133, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREATE NEW PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(160, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter new password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(160, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Repeat new password"
        '
        'repeatNewPassword
        '
        Me.repeatNewPassword.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.repeatNewPassword.Location = New System.Drawing.Point(165, 211)
        Me.repeatNewPassword.Multiline = True
        Me.repeatNewPassword.Name = "repeatNewPassword"
        Me.repeatNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(111)
        Me.repeatNewPassword.Size = New System.Drawing.Size(269, 41)
        Me.repeatNewPassword.TabIndex = 7
        '
        'pupilID
        '
        Me.pupilID.AutoSize = True
        Me.pupilID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pupilID.Location = New System.Drawing.Point(272, 255)
        Me.pupilID.Name = "pupilID"
        Me.pupilID.Size = New System.Drawing.Size(41, 13)
        Me.pupilID.TabIndex = 9
        Me.pupilID.Text = "Pupil id"
        Me.pupilID.Visible = False
        '
        'New_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 365)
        Me.Controls.Add(Me.pupilID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.repeatNewPassword)
        Me.Controls.Add(Me.newPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "New_Password"
        Me.Text = "New_Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents newPassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents repeatNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents pupilID As System.Windows.Forms.Label
End Class
