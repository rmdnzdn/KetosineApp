<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class siswa
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tuser = New System.Windows.Forms.TextBox()
        Me.dgvsiswa = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bedit = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.breset = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Location = New System.Drawing.Point(372, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Input Siswa"
        '
        'tuser
        '
        Me.tuser.BackColor = System.Drawing.SystemColors.Menu
        Me.tuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tuser.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuser.ForeColor = System.Drawing.Color.IndianRed
        Me.tuser.Location = New System.Drawing.Point(45, 138)
        Me.tuser.MaxLength = 8
        Me.tuser.Multiline = True
        Me.tuser.Name = "tuser"
        Me.tuser.Size = New System.Drawing.Size(400, 40)
        Me.tuser.TabIndex = 1
        '
        'dgvsiswa
        '
        Me.dgvsiswa.AllowUserToDeleteRows = False
        Me.dgvsiswa.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgvsiswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvsiswa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvsiswa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.IndianRed
        Me.dgvsiswa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvsiswa.ColumnHeadersHeight = 25
        Me.dgvsiswa.ColumnHeadersVisible = False
        Me.dgvsiswa.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsiswa.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgvsiswa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvsiswa.Location = New System.Drawing.Point(469, 222)
        Me.dgvsiswa.Name = "dgvsiswa"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsiswa.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvsiswa.RowHeadersWidth = 20
        Me.dgvsiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsiswa.Size = New System.Drawing.Size(636, 319)
        Me.dgvsiswa.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SlateGray
        Me.Label2.Location = New System.Drawing.Point(186, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SlateGray
        Me.Label3.Location = New System.Drawing.Point(186, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SlateGray
        Me.Label4.Location = New System.Drawing.Point(205, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NAMA"
        '
        'bsimpan
        '
        Me.bsimpan.BackColor = System.Drawing.Color.SlateGray
        Me.bsimpan.FlatAppearance.BorderSize = 0
        Me.bsimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsimpan.Font = New System.Drawing.Font("Courier New", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bsimpan.Location = New System.Drawing.Point(45, 363)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(400, 40)
        Me.bsimpan.TabIndex = 11
        Me.bsimpan.Text = "SIMPAN"
        Me.bsimpan.UseVisualStyleBackColor = False
        '
        'bedit
        '
        Me.bedit.BackColor = System.Drawing.Color.SlateGray
        Me.bedit.FlatAppearance.BorderSize = 0
        Me.bedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bedit.Font = New System.Drawing.Font("Courier New", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bedit.Location = New System.Drawing.Point(45, 409)
        Me.bedit.Name = "bedit"
        Me.bedit.Size = New System.Drawing.Size(400, 40)
        Me.bedit.TabIndex = 12
        Me.bedit.Text = "EDIT"
        Me.bedit.UseVisualStyleBackColor = False
        '
        'bhapus
        '
        Me.bhapus.BackColor = System.Drawing.Color.SlateGray
        Me.bhapus.FlatAppearance.BorderSize = 0
        Me.bhapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bhapus.Font = New System.Drawing.Font("Courier New", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bhapus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bhapus.Location = New System.Drawing.Point(45, 455)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(400, 40)
        Me.bhapus.TabIndex = 13
        Me.bhapus.Text = "HAPUS"
        Me.bhapus.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SlateGray
        Me.Label5.Location = New System.Drawing.Point(465, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PENCARIAN"
        '
        'tpass
        '
        Me.tpass.BackColor = System.Drawing.SystemColors.Menu
        Me.tpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpass.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpass.ForeColor = System.Drawing.Color.IndianRed
        Me.tpass.Location = New System.Drawing.Point(45, 222)
        Me.tpass.Multiline = True
        Me.tpass.Name = "tpass"
        Me.tpass.Size = New System.Drawing.Size(400, 40)
        Me.tpass.TabIndex = 16
        '
        'tnama
        '
        Me.tnama.BackColor = System.Drawing.SystemColors.Menu
        Me.tnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tnama.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnama.ForeColor = System.Drawing.Color.IndianRed
        Me.tnama.Location = New System.Drawing.Point(45, 307)
        Me.tnama.Multiline = True
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(400, 40)
        Me.tnama.TabIndex = 17
        '
        'tcari
        '
        Me.tcari.BackColor = System.Drawing.SystemColors.Menu
        Me.tcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcari.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcari.ForeColor = System.Drawing.Color.IndianRed
        Me.tcari.Location = New System.Drawing.Point(469, 138)
        Me.tcari.Multiline = True
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(636, 40)
        Me.tcari.TabIndex = 18
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.SlateGray
        Me.breset.FlatAppearance.BorderSize = 0
        Me.breset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.breset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.breset.Font = New System.Drawing.Font("Courier New", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.breset.Location = New System.Drawing.Point(45, 501)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(400, 40)
        Me.breset.TabIndex = 19
        Me.breset.Text = "RESET"
        Me.breset.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SlateGray
        Me.Label6.Location = New System.Drawing.Point(464, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(643, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "|  USERNAME  |  PASSWORD  |                     NAMA                       |"
        '
        'siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1160, 600)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.breset)
        Me.Controls.Add(Me.tcari)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bedit)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvsiswa)
        Me.Controls.Add(Me.tuser)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "siswa"
        Me.Text = "siswa"
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tuser As TextBox
    Friend WithEvents dgvsiswa As DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bsimpan As Button
    Friend WithEvents bedit As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tpass As TextBox
    Friend WithEvents tnama As TextBox
    Friend WithEvents tcari As TextBox
    Friend WithEvents breset As Button
    Friend WithEvents Label6 As Label
End Class
