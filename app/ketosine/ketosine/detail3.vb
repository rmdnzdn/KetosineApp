Public Class detail3

    Private Sub detail3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kandidat.Enabled = False
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = 129
        animaten(Me, True)
        identitas()
        lnama.Text = nama_kan
        lnis.Text = nis_kan
        lrombel.Text = rombel_kan
        lrayon.Text = rayon_kan

    End Sub
    Dim nama_kan, nis_kan, rombel_kan, rayon_kan As String
    Sub identitas()
        konek()
        CMD = New OleDb.OleDbCommand("SELECT * FROM tbl_kandidat WHERE id_kandidat='3'", cn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            nis_kan = DR("nis")
            nama_kan = DR("nama")
            rombel_kan = DR("rombel")
            rayon_kan = DR("rayon")
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kandidat.Enabled = True
        kandidat.idcan.Text = "3"
        pesan = "Rizaldy Sukma Perkasa "
        identitas()
        kandidat.lnamakan.Visible = True
        kandidat.lnamakan.Text = nama_kan
        kandidat.Label13.Text = "Pilih 3"
        kandidat.Label13.Visible = True
        Me.Close()
        kandidat.Button5.BackColor = Color.MediumAquamarine
        kandidat.Button4.BackColor = Color.IndianRed
        kandidat.Button3.BackColor = Color.IndianRed

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kandidat.Enabled = True
        kandidat.Label13.Visible = False
        kandidat.Button4.BackColor = Color.IndianRed
        kandidat.Button3.BackColor = Color.IndianRed
        kandidat.Button5.BackColor = Color.IndianRed
        Me.Close()

    End Sub
End Class