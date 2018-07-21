Public Class siswa
    Private Sub siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 202
        Me.Top = 132
        animaten(Me, True)
        konek()
        tampildata()
        bersih()
        cari()
    End Sub
    Sub tampildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("select * from tbl_user order by username asc", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_user")
        With dgvsiswa
            .DataSource = DS.Tables("tbl_user")
            .Enabled = True
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.SlateGray
            .GridColor = Color.Red


            .Columns(0).HeaderText = "Username"
            .Columns(1).HeaderText = "Password"
            .Columns(2).HeaderText = "Nama Siswa"
            .Columns(0).Width = 150
            .Columns(1).Width = 140
            .Columns(2).Width = 324
            .Refresh()
        End With
        DA.Dispose()
        DS.Dispose()
        cn.Close()
        bersih()
    End Sub
    Sub bersih()
        tuser.Text = ""
        tpass.Text = ""
        tnama.Text = ""
        bsimpan.Enabled = True
        bedit.Enabled = False
        bhapus.Enabled = False
    End Sub
    Sub cari()
        konek()
        DA = New OleDb.OleDbDataAdapter("select username,password,nama from tbl_user where username LIKE '%" & tcari.Text & "%' OR nama LIKE '%" & tcari.Text & "%'", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_user")
        With dgvsiswa
            .DataSource = DS.Tables("tbl_user")
            .Enabled = True
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.SlateGray
            .GridColor = Color.Red


            .Columns(0).HeaderText = "Username"
            .Columns(1).HeaderText = "Password"
            .Columns(2).HeaderText = "Nama Siswa"
            .Columns(0).Width = 150
            .Columns(1).Width = 140
            .Columns(2).Width = 324
            .Refresh()
        End With
        DA.Dispose()
        DS.Dispose()
        cn.Close()
        bersih()
    End Sub

    Private Sub dgvsiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsiswa.CellContentClick

    End Sub

    Private Sub dgvsiswa_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvsiswa.RowHeaderMouseClick
        Dim i As Integer
        i = e.RowIndex
        tuser.Text = dgvsiswa.Item(0, i).Value
        tpass.Text = dgvsiswa.Item(1, i).Value
        tnama.Text = dgvsiswa.Item(2, i).Value
        tuser.Enabled = False
        bsimpan.Enabled = False
        bedit.Enabled = True
        bhapus.Enabled = True
        breset.Enabled = True
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        If tuser.Text = "" Or tpass.Text = "" Or tnama.Text = "" Then
            MessageBox.Show("Ada Data Yang Tidak Lengkap !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql = "insert into tbl_user values('" & tuser.Text & "','" & tpass.Text & "','" & tnama.Text & "','0')"
            msg = "Data Berhasil Disimpan"
            runsql()
            tampildata()
            bersih()
        End If
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        bersih()
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        sql = "update tbl_user set `password`='" & tpass.Text & "', nama='" & tnama.Text & "' where `username`='" & tuser.Text & "'"
        msg = "Data Berhasil Di edit"
        tuser.Enabled = True
        tuser.Focus()
        runsql()
        tampildata()
        bersih()
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        If MsgBox("Yakin Akan Menghapus " + tuser.Text + " ?", MsgBoxStyle.YesNo, "Konfirmasi Penghapusan") = MsgBoxResult.Yes Then
            sql = "delete from tbl_user where username='" & tuser.Text & "'"
            msg = "Siswa Tersebut Berhasil Dihapus"
            runsql()
            tampildata()
            bersih()
        End If

    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged

    End Sub

    Private Sub tcari_KeyUp(sender As Object, e As KeyEventArgs) Handles tcari.KeyUp
        cari()
    End Sub
End Class