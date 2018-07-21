Public Class kandidat

    Private Sub kandidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        animaten(Me, True)
        user()
        lnama.Text = nama_us
        lnamakan.Visible = False
        Label13.Visible = False
        pesan = ""
    End Sub
    Dim nama_us As String
    Sub user()
        konek()
        CMD = New OleDb.OleDbCommand("SELECT * FROM tbl_user WHERE username='" & login.tuserpemilih.Text & "'", cn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            nama_us = DR("nama")
        Loop
    End Sub

    Dim tp As Integer
    Sub jml()
        nocan = idcan.Text
        konek()
        CMD = New OleDb.OleDbCommand("SELECT * FROM tbl_laporan WHERE id_kandidat='" & nocan & "' ", cn)
        DR = CMD.ExecuteReader
        While DR.Read
            tp = DR.Item("jumlah_suara").ToString
        End While
        tp = tp + 1
        sql = "UPDATE tbl_laporan SET jumlah_suara = '" & tp & "' where id_kandidat='" & nocan & "'"
        msg = "Selamat " + nama_us + vbCrLf + "Anda Berhasil Memilih " + vbCrLf + pesan
        runsql()
        beranda.tampildata()
    End Sub
    Sub upstatus()
        user()
        nocan = idcan.Text
        Dim t = login.tuserpemilih.Text
        sql = "UPDATE tbl_user SET id_kandidat='" & nocan & "' where username = '" & t & "' "
        msg = "Haii !!! " + nama_us + vbCrLf + "Terimakasih Anda Telah Berpastisipasi" + vbCrLf + "Dalam Pemilihan Ketua Osis Online"
        runsql()
    End Sub
    Dim nama_kan As String
    Sub nmkan()
        konek()
        CMD = New OleDb.OleDbCommand("SELECT * FROM tbl_kandidat WHERE id_kandidat='" & idcan.Text & "'", cn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            nama_kan = DR("nama")
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button4.BackColor = Color.IndianRed
        Button3.BackColor = Color.MediumAquamarine
        Button5.BackColor = Color.IndianRed
        Label13.Text = "Pilih 1"
        Label13.Visible = True
        idcan.Text = "1"
        pesan = "Muhammad Ramdan "
        nmkan()
        lnamakan.Visible = True
        lnamakan.Text = nama_kan
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label13.Text = "Pilih 2"
        Label13.Visible = True
        Button4.BackColor = Color.MediumAquamarine
        Button3.BackColor = Color.IndianRed
        Button5.BackColor = Color.IndianRed
        idcan.Text = "2"
        pesan = "Siti Nurhania Haeriah "
        lnamakan.Visible = True
        nmkan()
        lnamakan.Text = nama_kan
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label13.Text = "Pilih 3"
        Label13.Visible = True
        Button4.BackColor = Color.IndianRed
        Button3.BackColor = Color.IndianRed
        Button5.BackColor = Color.MediumAquamarine
        idcan.Text = "3"
        pesan = "Rizaldy Sukma Perkasa "
        nmkan()
        lnamakan.Visible = True
        lnamakan.Text = nama_kan
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label13.Text = "Detail 1"
        Label13.Visible = True
        detail3.Close()
        detail2.Close()
        detail.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label13.Text = "Detail 2"
        Label13.Visible = True
        detail2.Show()
        detail.Close()
        detail3.Close()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label13.Text = "Detail 3"
        Label13.Visible = True
        detail3.Show()
        detail2.Close()
        detail.Close()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles bberanda.Click
        beranda.Show()
        lnamakan.Visible = False
        Button3.BackColor = Color.IndianRed
        Button4.BackColor = Color.IndianRed
        Button5.BackColor = Color.IndianRed
        Label13.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nmkan()
        lnamakan.Visible = True
        lnamakan.Text = nama_kan
        If pesan = "" Then
            MessageBox.Show("Pilih Kandidat Terlebih Dahulu !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button4.BackColor = Color.IndianRed
            Button3.BackColor = Color.IndianRed
            Button5.BackColor = Color.IndianRed
        ElseIf MsgBox(nama_us + vbCrLf + "Anda Yakin Akan Memilih " + nama_kan + " ?", MsgBoxStyle.YesNo, "Konfirmasi Pilihan") = MsgBoxResult.Yes Then
            jml()
            beranda.tampildata()
            upstatus()
            login.Close()

            beranda.dgvlaporan.Refresh()
            beranda.bkan.Visible = False
            beranda.lnama.Visible = False
            beranda.lkan.Visible = False
            beranda.blog.Visible = True
            beranda.llog.Visible = True
            beranda.Button1.Visible = True
            beranda.Show()
            Me.Close()
        Else
            pesan = ""
            Label13.Visible = False
            lnamakan.Visible = False
            Button4.BackColor = Color.IndianRed
            Button3.BackColor = Color.IndianRed
            Button5.BackColor = Color.IndianRed
        End If
    End Sub
End Class