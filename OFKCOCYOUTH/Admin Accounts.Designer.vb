<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Accounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Accounts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAfn = New System.Windows.Forms.TextBox()
        Me.Txtapass = New System.Windows.Forms.TextBox()
        Me.Txtaverpass = New System.Windows.Forms.TextBox()
        Me.Txtaemail = New System.Windows.Forms.TextBox()
        Me.Txtapho = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Btnacancel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Re-Enter Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-Mail"
        '
        'TxtAfn
        '
        Me.TxtAfn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAfn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAfn.ForeColor = System.Drawing.Color.Black
        Me.TxtAfn.Location = New System.Drawing.Point(163, 60)
        Me.TxtAfn.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAfn.Name = "TxtAfn"
        Me.TxtAfn.Size = New System.Drawing.Size(311, 23)
        Me.TxtAfn.TabIndex = 4
        '
        'Txtapass
        '
        Me.Txtapass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtapass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtapass.ForeColor = System.Drawing.Color.Black
        Me.Txtapass.Location = New System.Drawing.Point(163, 105)
        Me.Txtapass.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtapass.Name = "Txtapass"
        Me.Txtapass.Size = New System.Drawing.Size(311, 23)
        Me.Txtapass.TabIndex = 5
        Me.Txtapass.UseSystemPasswordChar = True
        '
        'Txtaverpass
        '
        Me.Txtaverpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtaverpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtaverpass.ForeColor = System.Drawing.Color.Black
        Me.Txtaverpass.Location = New System.Drawing.Point(163, 153)
        Me.Txtaverpass.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtaverpass.Name = "Txtaverpass"
        Me.Txtaverpass.Size = New System.Drawing.Size(311, 23)
        Me.Txtaverpass.TabIndex = 6
        Me.Txtaverpass.UseSystemPasswordChar = True
        '
        'Txtaemail
        '
        Me.Txtaemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtaemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtaemail.ForeColor = System.Drawing.Color.Black
        Me.Txtaemail.Location = New System.Drawing.Point(163, 200)
        Me.Txtaemail.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtaemail.Name = "Txtaemail"
        Me.Txtaemail.Size = New System.Drawing.Size(311, 23)
        Me.Txtaemail.TabIndex = 7
        '
        'Txtapho
        '
        Me.Txtapho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtapho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtapho.ForeColor = System.Drawing.Color.Black
        Me.Txtapho.Location = New System.Drawing.Point(162, 247)
        Me.Txtapho.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtapho.Name = "Txtapho"
        Me.Txtapho.Size = New System.Drawing.Size(311, 23)
        Me.Txtapho.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 250)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(183, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ADMIN SIGN UP PAGE"
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.Black
        Me.BtnRegister.Location = New System.Drawing.Point(201, 286)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(111, 28)
        Me.BtnRegister.TabIndex = 11
        Me.BtnRegister.Text = "Re&gister"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'Btnacancel
        '
        Me.Btnacancel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnacancel.ForeColor = System.Drawing.Color.Black
        Me.Btnacancel.Location = New System.Drawing.Point(327, 286)
        Me.Btnacancel.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnacancel.Name = "Btnacancel"
        Me.Btnacancel.Size = New System.Drawing.Size(111, 28)
        Me.Btnacancel.TabIndex = 12
        Me.Btnacancel.Text = "&Cancel"
        Me.Btnacancel.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.BackgroundImage = Global.OFKCOCYOUTH.My.Resources.Resources.showpass_16
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(477, 105)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(23, 22)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "    "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Admin_Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(517, 325)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Btnacancel)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtapho)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtaemail)
        Me.Controls.Add(Me.Txtaverpass)
        Me.Controls.Add(Me.Txtapass)
        Me.Controls.Add(Me.TxtAfn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin_Accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAfn As TextBox
    Friend WithEvents Txtapass As TextBox
    Friend WithEvents Txtaverpass As TextBox
    Friend WithEvents Txtaemail As TextBox
    Friend WithEvents Txtapho As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Btnacancel As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
