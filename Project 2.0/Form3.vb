Imports System.ComponentModel

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter Username"
        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New SqlClient.SqlConnection("Data Source=AXXIDENTLY\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True")
        connection.Open()
        command = New SqlClient.SqlCommand("insert into Customers values('" + TextBox1.Text + "', '" + TextBox2.Text + "'," + TextBox3.Text + ", '" + DateTimePicker1.Text + "', '" + TextBox4.Text + "', " + TextBox5.Text + ", " + TextBox6.Text + ", '" + TextBox7.Text + "','" + TextBox8.Text + "')", connection)
        command.ExecuteNonQuery()
        CheckBox1.Checked = True
        connection.Close()
        Me.Hide()
        Form4.Show()
    End Sub


End Class