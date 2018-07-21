Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animaten(Me, True)
        logshow()
        adminhide()
        pemilihhide()
        Label2.Visible = False
        user()
        admin()

    End Sub
    Dim nama_us, nama_adm, id_kan, us, ps As String
    Sub user()
        konek()
        CMD = New OleDb.OleDbCommand("SELECT * FROM tbl_user WHERE username='" & tuserpemilih.Text & "'", cn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            us = DR("username")
            ps = DR("password")
            nama_us = DR("nama")
            id_kan = DR("id_kandidat")
        Loop
    End Sub
    Sub admin()
        konek()
        CMD = New OleDb.OleDbCommand("SELECT * FROM tbl_admin   WHERE username='" & tuseradmin.Text & "'", cn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            nama_adm = DR("nama")
        Loop
    End Sub
    Sub logshow()
        animaten(Me, True)
        Pnllog.Location = New Point(480, 257)
        Pnllog.Visible = True
        llog.Visible = True
        badmin.Visible = True
        bpemilih.Visible = True
    End Sub
    Sub loghide()
        Pnllog.Visible = False
        llog.Visible = False
        badmin.Visible = False
        bpemilih.Visible = False
    End Sub

    Sub adminshow()
        animaten(Me, True)
        Pnladmin.Location = New Point(480, 257)
        Pnladmin.Visible = True
        luseradmin.Visible = True
        tuseradmin.Visible = True
        lpassadmin.Visible = True
        tpassadmin.Visible = True
        bloginadmin.Visible = True
        bbackadmin.Visible = True
        tuseradmin.Focus()
    End Sub
    Sub adminhide()
        Pnladmin.Visible = False
        luseradmin.Visible = False
        tuseradmin.Visible = False
        lpassadmin.Visible = False
        tpassadmin.Visible = False
        bloginadmin.Visible = False
        bbackadmin.Visible = False
    End Sub

    Sub pemilihshow()
        animaten(Me, True)
        pnlpemilih.Location = New Point(480, 257)
        pnlpemilih.Visible = True
        luserpemilih.Visible = True
        tuserpemilih.Visible = True
        lpasspemilih.Visible = True
        tpasspemilih.Visible = True
        bloginpemilih.Visible = True
        bbackpemilih.Visible = True
        tuserpemilih.Focus()
    End Sub

    Sub pemilihhide()
        pnlpemilih.Visible = False
        luserpemilih.Visible = False
        tuserpemilih.Visible = False
        lpasspemilih.Visible = False
        tpasspemilih.Visible = False
        bloginpemilih.Visible = False
        bbackpemilih.Visible = False
    End Sub

    Private Sub bpemilih_Click(sender As Object, e As EventArgs) Handles bpemilih.Click
        pemilihshow()
        Label2.Visible = True
        Label2.Text = "Pemilih"
        loghide()
        adminhide()

    End Sub

    Private Sub badmin_Click(sender As Object, e As EventArgs) Handles badmin.Click
        adminshow()
        Label2.Visible = True
        Label2.Text = "Admin"
        loghide()
        pemilihhide()

    End Sub

    Private Sub bbackpemilih_Click(sender As Object, e As EventArgs) Handles bbackpemilih.Click
        logshow()
        Label2.Visible = False
        pemilihhide()
        adminhide()
        tuserpemilih.Text = ""
        tpasspemilih.Text = ""

    End Sub
    Private Sub bbackadmin_Click_1(sender As Object, e As EventArgs) Handles bbackadmin.Click
        logshow()
        Label2.Visible = False
        adminhide()
        pemilihhide()
        tuseradmin.Text = ""
        tpassadmin.Text = ""
    End Sub
    Private Sub bloginpemilih_Click(sender As Object, e As EventArgs) Handles bloginpemilih.Click
        user()
        Dim objcmd As New OleDb.OleDbCommand
        konek()
        sql = "Select * from tbl_user where username='" & tuserpemilih.Text & "' and password='" & tpasspemilih.Text & "'  and id_kandidat='0' "
        Try
            objcmd.Connection = cn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sql

            If tuserpemilih.Text = "" Or tpasspemilih.Text = "" Then
                MessageBox.Show("Ada Data Yang Tidak Lengkap !!!", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf id_kan <> "0" And tuserpemilih.Text = us And tpasspemilih.Text = ps Then
                MessageBox.Show(nama_us + vbCrLf + "Anda Sudah Melalukan Pemilihan  !!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tuserpemilih.Focus()
                tuserpemilih.Text = ""
                tpasspemilih.Text = ""
            ElseIf tuserpemilih.Text <> us Or tpasspemilih.Text <> ps Then
                MessageBox.Show(" Kombinasi Username Dan Password Anda Salah !!!", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tuserpemilih.Focus()
                tuserpemilih.Text = ""
                tpasspemilih.Text = ""
            ElseIf objcmd.ExecuteReader.Read Then
                user()
                MsgBox("Selamat Datang " + vbCrLf + nama_us)
                beranda.lnama.Visible = True
                beranda.lnama.Text = nama_us
                beranda.kanshow()
                beranda.Button1.Visible = False
                Me.Hide()
                beranda.Show()
            Else
                MessageBox.Show(" Kombinasi Username Dan Password Anda Salah !!!", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tuserpemilih.Focus()
                tuserpemilih.Text = ""
                tpasspemilih.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bloginadmin_Click(sender As Object, e As EventArgs) Handles bloginadmin.Click
        Dim objcmd As New OleDb.OleDbCommand
        konek()
        sql = "select * from tbl_admin where username='" & tuseradmin.Text & "' and password='" & tpassadmin.Text & "'"
        Try
            objcmd.Connection = cn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sql
            If tuseradmin.Text = "" Or tpassadmin.Text = "" Then
                MessageBox.Show("Ada Data Yang Tidak Lengkap !!!", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf objcmd.ExecuteReader.Read Then
                admin()
                MsgBox("Selamat Datang " + vbCrLf + nama_adm)
                beranda.Button1.Visible = False
                beranda.tampildata()
                beranda.hasilshow()
                beranda.loghide()
                beranda.tatahide()
                beranda.Ptengah.Visible = False
                beranda.lnama.Text = nama_adm
                beranda.lnama.Visible = True
                beranda.dasshow()
                beranda.binkan.BackColor = Color.MediumAquamarine
                beranda.binsis.BackColor = Color.MediumAquamarine
                beranda.blapor.BackColor = Color.SlateGray
                beranda.blogout.BackColor = Color.MediumAquamarine
                Me.Close()
                beranda.Show()
            Else
                MessageBox.Show("kombinasi username dan password salah", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tuseradmin.Focus()
            End If
            tuseradmin.Text = ""
            tpassadmin.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        beranda.Show()
        beranda.tampildata()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tpassadmin_TextChanged(sender As Object, e As EventArgs) Handles tpassadmin.TextChanged

    End Sub
End Class