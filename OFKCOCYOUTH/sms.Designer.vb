<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSms
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSms))
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioIndividual = New System.Windows.Forms.RadioButton()
        Me.radioAll = New System.Windows.Forms.RadioButton()
        Me.radioMen = New System.Windows.Forms.RadioButton()
        Me.radioWomen = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.radioYouth = New System.Windows.Forms.RadioButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.smsgridview = New System.Windows.Forms.DataGridView()
        Me.Name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.smsgridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(12, 31)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(543, 86)
        Me.txtMsg.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type Message here"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(12, 139)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(154, 20)
        Me.txtContact.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contact No"
        '
        'radioIndividual
        '
        Me.radioIndividual.AutoSize = True
        Me.radioIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioIndividual.Location = New System.Drawing.Point(177, 118)
        Me.radioIndividual.Name = "radioIndividual"
        Me.radioIndividual.Size = New System.Drawing.Size(92, 20)
        Me.radioIndividual.TabIndex = 4
        Me.radioIndividual.TabStop = True
        Me.radioIndividual.Text = "Individual"
        Me.radioIndividual.UseVisualStyleBackColor = True
        '
        'radioAll
        '
        Me.radioAll.AutoSize = True
        Me.radioAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAll.Location = New System.Drawing.Point(177, 144)
        Me.radioAll.Name = "radioAll"
        Me.radioAll.Size = New System.Drawing.Size(43, 20)
        Me.radioAll.TabIndex = 5
        Me.radioAll.TabStop = True
        Me.radioAll.Text = "All"
        Me.radioAll.UseVisualStyleBackColor = True
        '
        'radioMen
        '
        Me.radioMen.AutoSize = True
        Me.radioMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioMen.Location = New System.Drawing.Point(294, 143)
        Me.radioMen.Name = "radioMen"
        Me.radioMen.Size = New System.Drawing.Size(54, 20)
        Me.radioMen.TabIndex = 6
        Me.radioMen.TabStop = True
        Me.radioMen.Text = "Men"
        Me.radioMen.UseVisualStyleBackColor = True
        '
        'radioWomen
        '
        Me.radioWomen.AutoSize = True
        Me.radioWomen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioWomen.Location = New System.Drawing.Point(294, 120)
        Me.radioWomen.Name = "radioWomen"
        Me.radioWomen.Size = New System.Drawing.Size(77, 20)
        Me.radioWomen.TabIndex = 7
        Me.radioWomen.TabStop = True
        Me.radioWomen.Text = "Women"
        Me.radioWomen.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.radioIndividual)
        Me.SplitContainer1.Panel1.Controls.Add(Me.radioAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.radioMen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.radioWomen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.radioYouth)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(555, 479)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 8
        '
        'radioYouth
        '
        Me.radioYouth.AutoSize = True
        Me.radioYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioYouth.Location = New System.Drawing.Point(382, 120)
        Me.radioYouth.Name = "radioYouth"
        Me.radioYouth.Size = New System.Drawing.Size(64, 20)
        Me.radioYouth.TabIndex = 0
        Me.radioYouth.TabStop = True
        Me.radioYouth.Text = "Youth"
        Me.radioYouth.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.smsgridview)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnSend)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnRemove)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnAdd)
        Me.SplitContainer2.Size = New System.Drawing.Size(581, 286)
        Me.SplitContainer2.SplitterDistance = 396
        Me.SplitContainer2.TabIndex = 0
        '
        'smsgridview
        '
        Me.smsgridview.AllowUserToAddRows = False
        Me.smsgridview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.smsgridview.ColumnHeadersHeight = 34
        Me.smsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.smsgridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name1, Me.Contact, Me.Status})
        Me.smsgridview.Location = New System.Drawing.Point(0, 0)
        Me.smsgridview.Name = "smsgridview"
        Me.smsgridview.RowHeadersWidth = 62
        Me.smsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.smsgridview.Size = New System.Drawing.Size(417, 283)
        Me.smsgridview.TabIndex = 0
        '
        'Name1
        '
        Me.Name1.HeaderText = "Name"
        Me.Name1.MinimumWidth = 8
        Me.Name1.Name = "Name1"
        Me.Name1.Width = 130
        '
        'Contact
        '
        Me.Contact.HeaderText = "Contact"
        Me.Contact.MinimumWidth = 8
        Me.Contact.Name = "Contact"
        Me.Contact.Width = 130
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 8
        Me.Status.Name = "Status"
        Me.Status.Width = 120
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(13, 221)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 37)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(13, 171)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(124, 37)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send SMS"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(13, 68)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(124, 37)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmSms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(559, 479)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSms"
        Me.ShowIcon = False
        Me.Text = "SMS Portal"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.smsgridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMsg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents radioIndividual As RadioButton
    Friend WithEvents radioAll As RadioButton
    Friend WithEvents radioMen As RadioButton
    Friend WithEvents radioWomen As RadioButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents radioYouth As RadioButton
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents smsgridview As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Name1 As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
