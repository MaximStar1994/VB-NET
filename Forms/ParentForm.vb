Imports System.Windows.Forms
Imports SpecialPricing.UVObjects
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ParentForm

    Private Sub DefaultForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'UVObjects.Program.Main()

        'Dim lf As New LoginForm
        'lf.User.Text = "dr05171"
        'lf.Password.Text = "dr05171p"
        'lf.Visible = True

    End Sub
    Private lf As LoginForm


    Private Sub MDIParent_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown



        'Dim qf As New QueryForm
        'qf.MdiParent = Me



        'Dim queryForm As New QueryResult
        'QueryResult.MdiParent = Me

        'Dim reviewForm As New ReviewForm
        'reviewForm.MdiParent = Me

        'Dim lf As New LoginForm
        'lf.MdiParent = Me


        ''CreateModifyToolStripMenuItem.BackColor = Color.FromName("ControlDark")

        'UVObjects.Program.Initialize()

        '' Program.LaunchLoginForm()

        'lf = New LoginForm
        'lf.MdiParent = Me
        'lf.User.Text = "dr05171"
        'lf.Password.Text = "dr05171p"
        'lf.Visible = True


        ''UVObjects.Program.Initialize()

    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Program.WrapUp()
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MDIParent_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Program.WrapUp()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UVObjects.Program.WrapUp()
        'lf.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UVObjects.Program.WrapUp()
        'lf.Visible = True
    End Sub

    Private Sub ReviewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'CreateModifyToolStripMenuItem.BackColor = Color.FromName("Control")
        'ReviewToolStripMenuItem.BackColor = Color.FromName("ControlDark")
        ''ReviewToolStripMenuItem.Text = ReviewToolStripMenuItem.Text + "(1)"
        'QueryResult.Visible = False
        'HomeForm.Visible = False
        'ReviewForm.MdiParent = Me
        'ReviewForm.StartPosition = FormStartPosition.CenterParent
        'ReviewForm.Visible = True

    End Sub

    Private Sub CreateModifyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'ReviewToolStripMenuItem.BackColor = Color.FromName("Control")
        'CreateModifyToolStripMenuItem.BackColor = Color.FromName("ControlDark")
        ''ReviewToolStripMenuItem.Text = ReviewToolStripMenuItem.Text + "(1)"
        'HomeForm.Visible = False
        'ReviewForm.Visible = False
        'QueryResult.Visible = True
    End Sub

    Private Sub QueryToolStripMenuItem_Click(sender As Object, e As EventArgs)

        QueryForm.MdiParent = MdiParent
        QueryForm.StartPosition = FormStartPosition.CenterParent
        QueryForm.Visible = True

    End Sub

    Private Sub ParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        btnLogOut.Visible = True


        ' lf.Visible = True
    End Sub

    Private Sub ReviewButton_Click(sender As Object, e As EventArgs) Handles ReviewButton.Click

        Program.ShowReviewForm()

    End Sub

    Private Sub CreateModifyButton_Click(sender As Object, e As EventArgs) Handles CreateModifyButton.Click
        Program.ShowQueryResultForm()
    End Sub


    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TopPanel.Paint

    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Program.ShowNewQueryForm()
    End Sub

    Private Sub bar3_Click(sender As Object, e As EventArgs) Handles bar3.Click

    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        HelpForm.Show()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        UVObjects.Program.WrapUp()
    End Sub
    Private Sub btnLogOut_leave(sender As Object, e As EventArgs) Handles btnLogOut.MouseLeave
        btnLogOut.Hide()
    End Sub
End Class
