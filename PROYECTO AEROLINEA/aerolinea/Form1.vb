Public Class Form1

    Dim PrimeraC(4) As Integer
    Dim SegundaC(4) As Integer
    Dim contador As Integer = 0

    'estos arrays se encargan de traducir el programa tanto al ingles como al español mismo...
    '                                    0                       1           2       3     4       5         6               7               8       9           10      11          12                          13                      14                  15          16              17
    Dim opcionEspañol As String() = {"Seleccionar Idioma", "Registro", "Nombre:", "De:", "A:", "Clase:", "Asiento:", "Hora de Abordaje:", "Fecha:", "Vuelo:", "Aceptar", "Limpiar", "Vista Previa", "Numero De Asientos Disponibles", "Primera Clase", "Clase Económica", "Disponible", "Reservado", "Español", "Ingles"}
    Dim opcionIngles As String() = {"Select language", "Registry", "Name:", "From:", "To:", "Class:", "Seat:", "Boarding Time:", "Date:", "Flight:", "Accept", "Clean", "Preview", "Number of Seats Available", "First class", "Economy Class", "Available", "Reserved", "Spanish", "English"}

    Public Sub cargar()
        cbxClase.Items.Add(opcionEspañol(14))
        cbxClase.Items.Add(opcionEspañol(15))
        ComboBox3.Items.Add(opcionEspañol(18))
        ComboBox3.Items.Add(opcionEspañol(19))

        cbxClase.SelectedIndex = 0
        cbxAsientos.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxClase.SelectedIndexChanged
        cbxAsientos.Items.Clear()

        If cbxClase.Text = opcionIngles(14) Or cbxClase.Text = opcionIngles(15) Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(opcionIngles(18))
            ComboBox3.Items.Add(opcionIngles(19))

        End If

        If cbxClase.SelectedIndex = 0 Then
            Dim i As Integer
            For i = 0 To 4
                cbxAsientos.Items.Add(i + 1)
            Next
        End If

        If cbxClase.SelectedIndex = 1 Then
            Dim i As Integer
            For i = 5 To 9
                cbxAsientos.Items.Add(i + 1)
            Next
        End If

        cbxAsientos.SelectedIndex = 0

    End Sub

    Public Sub asientosDiversasClasaes(ByVal asiento)
        If asiento = 1 Then
            a1.Text = "R"
            a1.BackColor = Color.Red
        ElseIf asiento = 2 Then
            a2.Text = "R"
            a2.BackColor = Color.Red
        ElseIf asiento = 3 Then
            a3.Text = "R"
            a3.BackColor = Color.Red
        ElseIf asiento = 4 Then
            a4.Text = "R"
            a4.BackColor = Color.Red
        ElseIf asiento = 5 Then
            a5.Text = "R"
            a5.BackColor = Color.Red
        ElseIf asiento = 6 Then
            a6.Text = "R"
            a6.BackColor = Color.Red
        ElseIf asiento = 7 Then
            a7.Text = "R"
            a7.BackColor = Color.Red
        ElseIf asiento = 8 Then
            a8.Text = "R"
            a8.BackColor = Color.Red
        ElseIf asiento = 9 Then
            a9.Text = "R"
            a9.BackColor = Color.Red
        ElseIf asiento = 10 Then
            a10.Text = "R"
            a10.BackColor = Color.Red
        End If
        Form2.Show()
    End Sub

    Public Sub aumento()
        contador = contador + 1
        lblcontador2.Text = contador
        lblcontador1.Text = 10 - Val(lblcontador2.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim asiento, asiento2 As String
        Dim bus As Boolean = False

        asiento = Val(cbxAsientos.Text)

        If contador = 10 Then
            MsgBox("El avion esta listo para despegar", vbInformation)
            btnDespegar.Enabled = True
        Else

            If cbxClase.Text = "Primera Clase" Or cbxClase.Text = "First class" Then
                If Val(txtContadorPC.Text) = 0 Then
                    MsgBox("No hay asientos disponibles en Primera Clase")
                Else

                    For i = 0 To (asiento - 1)
                        If PrimeraC(i) = 0 Then
                            bus = True
                        End If
                    Next

                    If bus = True Then
                        aumento()
                        txtContadorPC.Text = Val(txtContadorPC.Text) - 1

                        For i = 0 To asiento - 1
                            PrimeraC(i) = asiento
                        Next
                        asientosDiversasClasaes(asiento)
                    Else
                        MsgBox("El haciento V" & asiento & " no esta disponible", vbCritical)
                    End If
                End If

            Else

                If Val(txtContadorSC.Text) = 0 Then
                    MsgBox("No hay asientos disponibles Clase Económica clase")
                Else

                    Dim i As Integer = 0
                    Dim j As Integer = 0
                    asiento2 = cbxAsientos.SelectedIndex

                    For i = 0 To asiento2
                        If SegundaC(i) = 0 Then
                            bus = True
                        End If
                    Next

                    If bus = True Then
                        aumento()
                        txtContadorSC.Text = Val(txtContadorSC.Text) - 1

                        For j = 0 To asiento2
                            SegundaC(j) = asiento
                        Next
                        asientosDiversasClasaes(asiento)
                    Else
                        MsgBox("El haciento V" & asiento & " no esta disponible", vbCritical)
                    End If
                End If
            End If
        End If

    End Sub

    Public Sub limpiar()
        TextBox1.Clear()
        txtde.Clear()
        txta.Clear()
        txthorabordaje.Clear()
        txtbuenlo.Clear()
        cbxClase.SelectedIndex = 0
        cbxAsientos.SelectedIndex = 0
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpíar.Click
        limpiar()
    End Sub

    Private Sub diversidades()
        cbxClase.Items.Clear()

        If ComboBox3.SelectedIndex = 1 Then
            cbxClase.Items.Add(opcionIngles(14))
            cbxClase.Items.Add(opcionIngles(15))
            ComboBox3.Items.Add(opcionIngles(18))
            ComboBox3.Items.Add(opcionIngles(19))

            cbxClase.SelectedIndex = 0
            cbxAsientos.SelectedIndex = 0
        Else
            cbxClase.Items.Add(opcionEspañol(14))
            cbxClase.Items.Add(opcionEspañol(15))

            cbxClase.SelectedIndex = 0
            cbxAsientos.SelectedIndex = 0
        End If

    End Sub

    Private Sub CargarLosComponentesEnEspañol()

        Label28.Text = opcionEspañol(0)
        lblnombre.Text = opcionEspañol(2)
        lblde.Text = opcionEspañol(3)
        lbla.Text = opcionEspañol(4)
        lblclase.Text = opcionEspañol(5)
        lblasiento.Text = opcionEspañol(6)
        lblhoradeabordaje.Text = opcionEspañol(7)
        lblfecha.Text = opcionEspañol(8)
        lblvuelo.Text = opcionEspañol(9)
        btnAceptar.Text = opcionEspañol(10)
        btnLimpíar.Text = opcionEspañol(11)
        gbnombre.Text = opcionEspañol(1)
        gbvista.Text = opcionEspañol(12)
        Label23.Text = opcionEspañol(13)
        Label24.Text = opcionEspañol(14)
        Label25.Text = opcionEspañol(15)
        Label21.Text = opcionEspañol(16)
        Label22.Text = opcionEspañol(17)
        diversidades()

    End Sub

    Private Sub CargarLosComponentesEnIngles()

        Label28.Text = opcionIngles(0)
        lblnombre.Text = opcionIngles(2)
        lblde.Text = opcionIngles(3)
        lbla.Text = opcionIngles(4)
        lblclase.Text = opcionIngles(5)
        lblasiento.Text = opcionIngles(6)
        lblhoradeabordaje.Text = opcionIngles(7)
        lblfecha.Text = opcionIngles(8)
        lblvuelo.Text = opcionIngles(9)
        btnAceptar.Text = opcionIngles(10)
        btnLimpíar.Text = opcionIngles(11)
        gbnombre.Text = opcionIngles(1)
        gbvista.Text = opcionIngles(12)
        Label23.Text = opcionIngles(13)
        Label24.Text = opcionIngles(14)
        Label25.Text = opcionIngles(15)
        Label21.Text = opcionIngles(16)
        Label22.Text = opcionIngles(17)
        diversidades()

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            CargarLosComponentesEnEspañol()
        End If

        If ComboBox3.SelectedIndex = 1 Then
            CargarLosComponentesEnIngles()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub btnDespegar_Click(sender As Object, e As EventArgs) Handles btnDespegar.Click
        MsgBox("El avion esta listo para despegar", vbInformation)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lblNombreEmpresa_Click(sender As Object, e As EventArgs) Handles lblNombreEmpresa.Click

    End Sub
End Class
