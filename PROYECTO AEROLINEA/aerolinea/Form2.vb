Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("El Boleto No." & Form1.txtbuenlo.Text & Date.Today & " a sido impreso ", vbInformation)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.cbxClase.Text
        TextBox2.Text = Form1.txthorabordaje.Text
        TextBox3.Text = Form1.txtbuenlo.Text
        TextBox4.Text = Form1.txtfecha.Text
        TextBox5.Text = "----"
        TextBox6.Text = Form1.cbxAsientos.Text
        TextBox7.Text = Form1.txtde.Text
        TextBox8.Text = Form1.txta.Text
        TextBox9.Text = Form1.TextBox1.Text
        TextBox10.Text = TextBox9.Text
        TextBox11.Text = TextBox6.Text
        TextBox12.Text = TextBox7.Text
        TextBox13.Text = TextBox8.Text
        TextBox14.Text = TextBox3.Text & " / " & TextBox4.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.limpiar()
        Me.Close()
    End Sub
End Class