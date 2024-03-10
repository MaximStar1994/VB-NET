Public Class TestForm
    Private Property _qr As QueryResult
    Private Property _qf As QueryForm
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _qf = New QueryForm
        _qf.TopLevel = False
        _qf.FormBorderStyle = FormBorderStyle.None
        _qf.Dock = DockStyle.Fill
        TabPage1.Controls.Add(_qf)


        _qr = New QueryResult




    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        _qr.TopLevel = False
        _qr.FormBorderStyle = FormBorderStyle.None
        _qr.Dock = DockStyle.Fill
        TabPage2.Controls.Add(_qr)
        _qr.Show()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        _qf.Show()

    End Sub
End Class