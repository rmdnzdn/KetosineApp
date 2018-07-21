Imports System.Data.OleDb

Module mdlkoneksi
    Public cn As OleDbConnection
    Public CMD As OleDbCommand
    Public DA As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public DS As DataSet
    Public msg, sql, pesan, nocan As String

    Public Sub runsql()
        Try
            konek()
            CMD = New OleDb.OleDbCommand(sql, cn)
            CMD.ExecuteNonQuery()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub konek()
        Try
            cn = New OleDbConnection("provider =microsoft.jet.oledb.4.0;data source=db_ketosine.mdb")
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            MsgBox("ERROR KONEKSI !!!")
        End Try
    End Sub

    Public Enum AnimateWindowFlags
        AW_HOR_POSITIVE = &H1
        AW_HOR_NEGATIVE = &H2
        AW_VER_POSITIVE = &H4
        AW_VER_NEGATIVE = &H8
        AW_CENTER = &H10
        AW_HIDE = &H10000
        AW_ACTIVATE = &H20000
        AW_SLIDE = &H40000
        AW_BLEND = &H80000
    End Enum

    Public Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean


    Sub animaten(ByVal frmToAnimate As Form, ByVal showform As Boolean)
        If showform Then
            AnimateWindow(frmToAnimate.Handle, 300, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 300, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_HIDE)
        End If

    End Sub

End Module
