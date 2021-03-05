Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class Form2
    Dim connection As New SqlConnection
    Dim command As New SqlCommand


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




    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter a Username")
            e.Cancel = True
        Else
            If IsNumeric(TextBox1.Text) Then
                ErrorProvider1.SetError(TextBox1, "Enter a correct Username")
                e.Cancel = True
            Else
                ErrorProvider1.SetError(TextBox1, "")
            End If
        End If
    End Sub



    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Please Enter a Password")
            e.Cancel = True
        Else
            If (Len(TextBox2.Text) > 8) Then
                ErrorProvider1.SetError(TextBox2, " Please Enter a password upto 8 characters")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter the credentials")
            ErrorProvider1.SetError(TextBox1, "Please Enter the credentials")
        Else
            connection = New SqlConnection("Data Source=AXXIDENTLY\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True")
            connection.Open()
            command = New SqlCommand("select * from Customers where Username('" + TextBox1.Text + "') and Password('" + TextBox2.Text + "'))", connection)
            reader = command.ExecuteReader
            If reader.Read = True Then
                user = TextBox1.Text
                Me.Hide()
                Form4.Show()
            Else
                MsgBox("Username and Password Required", MsgBoxStyle.Critical)
            End If
        End If
        connection.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class