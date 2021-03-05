Public Class Form1

    Private Sub OpenFormInPanel(Of Miform As {Form, New})()
        Dim ServiceForm As Form
        ServiceForm = Panel2.Controls.OfType(Of Miform)().FirstOrDefault()
        If ServiceForm Is Nothing Then
            ServiceForm = New Miform()
            ServiceForm.TopLevel = False
            ServiceForm.FormBorderStyle = FormBorderStyle.None
            ServiceForm.Dock = DockStyle.Fill
            Panel2.Controls.Add(ServiceForm)
            Panel2.Tag = ServiceForm
            ServiceForm.Show()
        Else
            ServiceForm.BringToFront()
        End If
    End Sub


    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
        End
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


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
