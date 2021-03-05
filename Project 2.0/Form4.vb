Public Class Form4

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlStocks.Visible = False
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        pnlStats.Height = btnStocks.Height
        pnlStats.Top = btnStocks.Top
        pnlStocks.Visible = True
        pnlTata.Visible = False
        pnlStatebank.Visible = False
        pnlAirtel.Visible = False
        pnlMutual.Visible = False
    End Sub

    Private Sub btnMutual_Click(sender As Object, e As EventArgs) Handles btnMutual.Click
        pnlStats.Height = btnMutual.Height
        pnlStats.Top = btnMutual.Top
        pnlStocks.Visible = False
        pnlMutual.Visible = True
    End Sub

    Private Sub btnFds_Click(sender As Object, e As EventArgs) Handles btnFds.Click
        pnlStats.Height = btnFds.Height
        pnlStats.Top = btnFds.Top
        pnlStocks.Visible = False
        pnlMutual.Visible = True
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        pnlStats.Height = btnProfile.Height
        pnlStats.Top = btnProfile.Top
        pnlStocks.Visible = False
    End Sub

    Private Sub btnForeign_Click(sender As Object, e As EventArgs) Handles btnForeign.Click
        pnlStats.Height = btnForeign.Height
        pnlStats.Top = btnForeign.Top
        pnlStocks.Visible = False
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        pnlStatebank.Visible = True
        pnlAirtel.Visible = False
        pnlTata.Visible = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        pnlTata.Visible = True
        pnlAirtel.Visible = False

        pnlStatebank.Visible = False
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        pnlAirtel.Visible = True
        pnlStatebank.Visible = False
        pnlTata.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox20.Visible = True Then
            PictureBox20.Visible = False
        Else
            PictureBox20.Visible = True
        End If
    End Sub
End Class