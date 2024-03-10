Imports SpecialPricing.UVObjects

Public Class LoginForm

    Private Sub DefaultForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Application.EnableVisualStyles()
        'Application.SetCompatibleTextRenderingDefault(False)
        Program.Initialize()

        Me.User.Text = "dr05171"
        Me.Password.Text = "dr05171p"

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)

        UVObjects.Program.WrapUp()

    End Sub

    Public Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click

        Dim Successful As Boolean

        'Dim lblCSt As Label
        'lblCSt = New Label
        'lblCSt.Text = "connecting.."
        'lblCSt.Location = New Point(200, 327)
        'Me.Controls.Add(lblCSt)

        'lblCSt.Show()

        ConnectButton.Width = 150
        ConnectButton.BackColor = Color.FromKnownColor(KnownColor.ButtonFace)
        ConnectButton.Text = "Connecting.."
        ConnectButton.Enabled = False

        Successful = True ' UVObjects.Program.ConnectToEclipse(User.Text, Password.Text)

        If Successful Then
            Visible = False
            Program.StartApplication()
        Else
            Password.Text = ""
            ConnectButton.Visible = True
            Visible = True
            Password.Select()
        End If

    End Sub

    Private Sub UserIdLabel_Click(sender As Object, e As EventArgs) Handles UserIdLabel.Click

    End Sub

    Private Sub User_TextChanged(sender As Object, e As EventArgs) Handles User.TextChanged

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Application.Exit()
        End


    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter

        Button1.BackColor = Color.OrangeRed

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.BackColor = Color.FromKnownColor(KnownColor.ButtonFace)

    End Sub
    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint

    End Sub
    Private _moveForm As Boolean
    Private _moveForm_MousePosition As Point

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            _moveForm = True
            Me.Cursor = Cursors.Default
            _moveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = MouseButtons.Left Then
            _moveForm = False
            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If _moveForm Then
            Me.Location = Me.Location + (e.Location - _moveForm_MousePosition)

        End If
    End Sub
End Class