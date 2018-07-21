Public Class inkandidat

    Private Sub inkandidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 202
        Me.Top = 132
        konek()
        animaten(Me, True)
        tampildata()
        bersih()
        cari()
    End Sub
    Sub tampildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("select id_kandidat,nis,nama,rombel,rayon from tbl_kandidat", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kandidat")
        With dgvkandidat
            .DataSource = DS.Tables("tbl_kandidat")
            .Enabled = True
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.SlateGray
            .GridColor = Color.Red

            .Columns(0).Width = 40
            .Columns(1).Width = 100
            .Columns(2).Width = 250
            .Columns(3).Width = 100
            .Columns(4).Width = 126
            .Refresh()
        End With
        DA.Dispose()
        DS.Dispose()
        cn.Close()
    End Sub
    Sub bersih()
        tno.Text = ""
        tnis.Text = ""
        trombel.Text = ""
        trayon.Text = ""
        tnama.Text = ""
        bsimpan.Enabled = True
        bedit.Enabled = False
        bhapus.Enabled = False
    End Sub
    Sub cari()
        konek()
        DA = New OleDb.OleDbDataAdapter("select id_kandidat,nis,nama,rombel,rayon from tbl_kandidat where id_kandidat LIKE '%" & tcari.Text & "%' OR nis LIKE '%" & tcari.Text & "%'  OR nama LIKE '%" & tcari.Text & "%' OR rombel LIKE '%" & tcari.Text & "%' OR rayon LIKE '%" & tcari.Text & "%' ", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kandidat")
        With dgvkandidat
            .DataSource = DS.Tables("tbl_kandidat")
            .Enabled = True
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.SlateGray
            .GridColor = Color.Red

            .Columns(0).Width = 40
            .Columns(1).Width = 100
            .Columns(2).Width = 250
            .Columns(3).Width = 100
            .Columns(4).Width = 126
            .Refresh()
        End With
        DA.Dispose()
        DS.Dispose()
        cn.Close()
    End Sub
    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        If tno.Text = "" Or tnis.Text = "" Or tnama.Text = "" Or trombel.Text = "" Or trayon.Text = "" Then
            MessageBox.Show("Ada Data Yang Tidak Lengkap !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql = "insert into tbl_kandidat values('" & tno.Text & "','" & tnis.Text & "','" & tnama.Text & "','" & trombel.Text & "','" & trayon.Text & "')"
            msg = "Data Berhasil Disimpan"
            runsql()
            tampildata()
            bersih()
        End If
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        sql = "update tbl_kandidat set  `id_kandidat`='" & tno.Text & "', nis='" & tnis.Text & "' , nama='" & tnama.Text & "',rombel='" & trombel.Text & "',rayon='" & trayon.Text & "' where `id_kandidat`='" & tno.Text & "'"
        msg = "Data Berhasil Di edit"

        runsql()
        tampildata()
        bersih()
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        If MsgBox("Yakin Akan Menghapus " + tnama.Text + " ?", MsgBoxStyle.YesNo, "Konfirmasi Penghapusan") = MsgBoxResult.Yes Then
            sql = "delete from tbl_kandidat where id_kandidat='" & tno.Text & "'"
            msg = "Kandidat Tersebut Berhasil Dihapus"
            runsql()
            tampildata()
            bersih()

        End If
    End Sub

    Private Sub dgvkandidat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkandidat.CellContentClick

    End Sub

    Private Sub dgvkandidat_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvkandidat.RowHeaderMouseClick
        Dim i As Integer
        i = e.RowIndex
        tno.Text = dgvkandidat.Item(0, i).Value
        tnis.Text = dgvkandidat.Item(1, i).Value
        tnama.Text = dgvkandidat.Item(2, i).Value
        trombel.Text = dgvkandidat.Item(3, i).Value
        trayon.Text = dgvkandidat.Item(4, i).Value
        bsimpan.Enabled = False
        bedit.Enabled = True
        bhapus.Enabled = True
        breset.Enabled = True
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        bersih()
    End Sub

    Private Sub tcari_KeyUp(sender As Object, e As KeyEventArgs) Handles tcari.KeyUp
        cari()
    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged

    End Sub
End Class