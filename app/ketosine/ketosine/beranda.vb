Public Class beranda
    Private Sub beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animaten(Me, True)
        lnama.Visible = False
        tampildata()
        kanhide()
        dashide()
        logshow()
    End Sub
    Sub tampildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("select * from tbl_laporan order by jumlah_suara desc", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_laporan")
        With dgvlaporan
            .DataSource = DS.Tables("tbl_laporan")
            .Enabled = False
            .ColumnHeadersHeight = 40
            .Columns(0).HeaderText = "No Kandidat"
            .Columns(1).HeaderText = "Nama Kandidat"
            .Columns(2).HeaderText = "Hasil Semnentara"
            .Columns(0).Width = 100
            .Columns(1).Width = 300
            .Columns(2).Width = 200
            .Rows(0).Height = 70
            .Rows(1).Height = 70
            .Rows(2).Height = 70
            .Refresh()
        End With
        DA.Dispose()
        DS.Dispose()
        cn.Close()
    End Sub
    Sub hasilshow()
        tampildata()
        lhasil.Location = New Point(500, 250)
        dgvlaporan.Location = New Point(470, 332)
        lhasil.Visible = True
        dgvlaporan.Visible = True
        Ptengah.Visible = False
    End Sub
    Sub hasilshow2()
        lhasil.Location = New Point(750, 187)
        dgvlaporan.Location = New Point(715, 307)
        lhasil.Visible = True
        dgvlaporan.Visible = True
        Ptengah.Visible = True
    End Sub
    Sub tatashow()
        ptata.Visible = True
        lt1.Visible = True
        lt2.Visible = True
        lt3.Visible = True
        lt4.Visible = True
        lt5.Visible = True
        lt6.Visible = True
        lt7.Visible = True
        lt8.Visible = True
        lt9.Visible = True
        lt10.Visible = True
        lt11.Visible = True
        lt12.Visible = True
        lt13.Visible = True
        lt14.Visible = True
    End Sub
    Sub tatahide()
        ptata.Visible = False
        lt1.Visible = False
        lt2.Visible = False
        lt3.Visible = False
        lt4.Visible = False
        lt5.Visible = False
        lt6.Visible = False
        lt7.Visible = False
        lt8.Visible = False
        lt9.Visible = False
        lt10.Visible = False
        lt11.Visible = False
        lt12.Visible = False
        lt13.Visible = False
        lt14.Visible = False
    End Sub
    Sub logshow()
        llog.Visible = True
        blog.Visible = True
    End Sub
    Sub loghide()
        llog.Visible = False
        blog.Visible = False
    End Sub
    Sub kanshow()
        bkan.Location = New Point(204, 52)
        lkan.Location = New Point(326, 5)
        lkan.Visible = True
        bkan.Visible = True
    End Sub
    Sub kanhide()
        lkan.Visible = False
        bkan.Visible = False
    End Sub

    Sub dasshow()
        bdas.Location = New Point(204, 52)
        Ldas.Location = New Point(326, 5)
        Ldas.Visible = True
        bdas.Visible = True
        pdash.Visible = True
        binkan.Visible = True
        binsis.Visible = True
        blogout.Visible = True
        blapor.Visible = True
    End Sub
    Sub dashide()
        Ldas.Visible = False
        bdas.Visible = False
        pdash.Visible = False
        binkan.Visible = False
        binsis.Visible = False
        blogout.Visible = False
        blapor.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loading.Close()
        kandidat.Close()
        inkandidat.Close()
        siswa.Close()
        login.Close()
        detail.Close()
        detail2.Close()
        detail3.Close()
        Me.Close()

    End Sub
    Private Sub bdas_Click(sender As Object, e As EventArgs) Handles bdas.Click

    End Sub
    Private Sub bkan_Click(sender As Object, e As EventArgs) Handles bkan.Click
        kandidat.Show()
        kandidat.lnamakan.Visible = False
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles blog.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub binkan_Click(sender As Object, e As EventArgs) Handles binkan.Click
        binkan.BackColor = Color.SlateGray
        binsis.BackColor = Color.MediumAquamarine
        blapor.BackColor = Color.MediumAquamarine
        blogout.BackColor = Color.MediumAquamarine
        inkandidat.Show()
        siswa.Close()
    End Sub

    Private Sub binsis_Click(sender As Object, e As EventArgs) Handles binsis.Click
        binsis.BackColor = Color.SlateGray
        binkan.BackColor = Color.MediumAquamarine
        blapor.BackColor = Color.MediumAquamarine
        blogout.BackColor = Color.MediumAquamarine
        siswa.Show()
        inkandidat.Close()
    End Sub

    Private Sub blapor_Click(sender As Object, e As EventArgs) Handles blapor.Click
        blapor.BackColor = Color.SlateGray
        binsis.BackColor = Color.MediumAquamarine
        binkan.BackColor = Color.MediumAquamarine
        blogout.BackColor = Color.MediumAquamarine
        siswa.Close()
        inkandidat.Close()
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        If MsgBox("Admin Anda Yakin Akan Keluar ?", MsgBoxStyle.YesNo, "Konfirmasi Penghapusan") = MsgBoxResult.Yes Then
            lnama.Visible = False
            tampildata()
            kanhide()
            dashide()
            tatashow()
            hasilshow2()
            logshow()
            dgvlaporan.Refresh()
            lnama.Visible = False
            lkan.Visible = False
            blog.Visible = True
            llog.Visible = True
            Button1.Visible = True
        End If
    End Sub

    Private Sub pdash_Paint(sender As Object, e As PaintEventArgs) Handles pdash.Paint

    End Sub
End Class