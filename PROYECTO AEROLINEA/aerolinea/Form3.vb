﻿Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.lblNombreEmpresa.Text = TextBox1.Text
        Me.Close()
    End Sub
End Class