Imports System.Security.Policy

Public Class HelpForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter

        Button1.BackColor = Color.OrangeRed

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.BackColor = Color.FromKnownColor(KnownColor.ButtonFace)

    End Sub
    Private Sub GeneralHelpButton_Click(sender As Object, e As EventArgs) Handles GeneralHelpButton.Click
        Process.Start("https://morsco.service-now.com/sp?id=sc_cat_item&sys_id=9e3114e31bfce1101d0474ce0a4bcbae")
    End Sub
End Class