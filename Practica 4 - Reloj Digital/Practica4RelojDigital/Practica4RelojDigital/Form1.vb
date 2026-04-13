Public Class Form1
    Dim formato As Boolean = True
    Dim start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o
        Dim Time_mod

        ' Este es el formato de 24 horas
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Time_mod = Time_o.Split(":")
        Horas.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Segundos.Text = Time_mod(2)
        Dias.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If

        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Predeterminado (Negro)" Then
            Horas.ForeColor = Color.Black
            Minutos.ForeColor = Color.Black
            Segundos.ForeColor = Color.Black
            Dias.ForeColor = Color.Black
            Fecha.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
        ElseIf color_texto = "Rojo" Then
            Horas.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Segundos.ForeColor = Color.Red
            Dias.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
        ElseIf color_texto = "Naranja" Then
            Horas.ForeColor = Color.OrangeRed
            Minutos.ForeColor = Color.OrangeRed
            Segundos.ForeColor = Color.OrangeRed
            Dias.ForeColor = Color.OrangeRed
            Fecha.ForeColor = Color.OrangeRed
            Label1.ForeColor = Color.OrangeRed
            Label2.ForeColor = Color.OrangeRed
        ElseIf color_texto = "Amarillo" Then
            Horas.ForeColor = Color.Orange
            Minutos.ForeColor = Color.Orange
            Segundos.ForeColor = Color.Orange
            Dias.ForeColor = Color.Orange
            Fecha.ForeColor = Color.Orange
            Label1.ForeColor = Color.Orange
            Label2.ForeColor = Color.Orange
        ElseIf color_texto = "Verde" Then
            Horas.ForeColor = Color.LimeGreen
            Minutos.ForeColor = Color.LimeGreen
            Segundos.ForeColor = Color.LimeGreen
            Dias.ForeColor = Color.LimeGreen
            Fecha.ForeColor = Color.LimeGreen
            Label1.ForeColor = Color.LimeGreen
            Label2.ForeColor = Color.LimeGreen
        ElseIf color_texto = "Azul" Then
            Horas.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Segundos.ForeColor = Color.Blue
            Dias.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Label2.ForeColor = Color.Blue
        ElseIf color_texto = "Cian" Then
            Horas.ForeColor = Color.DeepSkyBlue
            Minutos.ForeColor = Color.DeepSkyBlue
            Segundos.ForeColor = Color.DeepSkyBlue
            Dias.ForeColor = Color.DeepSkyBlue
            Fecha.ForeColor = Color.DeepSkyBlue
            Label1.ForeColor = Color.DeepSkyBlue
            Label2.ForeColor = Color.DeepSkyBlue
        ElseIf color_texto = "Morado" Then
            Horas.ForeColor = Color.MediumSlateBlue
            Minutos.ForeColor = Color.MediumSlateBlue
            Segundos.ForeColor = Color.MediumSlateBlue
            Dias.ForeColor = Color.MediumSlateBlue
            Fecha.ForeColor = Color.MediumSlateBlue
            Label1.ForeColor = Color.MediumSlateBlue
            Label2.ForeColor = Color.MediumSlateBlue
        ElseIf color_texto = "Rosa" Then
            Horas.ForeColor = Color.HotPink
            Minutos.ForeColor = Color.HotPink
            Segundos.ForeColor = Color.HotPink
            Dias.ForeColor = Color.HotPink
            Fecha.ForeColor = Color.HotPink
            Label1.ForeColor = Color.HotPink
            Label2.ForeColor = Color.HotPink
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12H"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24H"
            formato = True
        End If
    End Sub

    ' =============================
    ' Código para el Cronometro
    ' =============================

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If start = False Then
            Timer3.Enabled = True
            start = True
            Button4.Text = "Detener"
        ElseIf start = True Then
            Timer3.Enabled = False
            start = False
            Button4.Text = "Iniciar"
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono += 10
        Dim tiempo As TimeSpan = TimeSpan.FromMilliseconds(tiempo_crono)
        Label7.Text = tiempo.ToString("hh\:mm\:ss\.ff")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer3.Stop()
        start = False
        tiempo_crono = 0
        Label7.Text = "00:00:00.00"
        Button4.Text = "Iniciar"
    End Sub

    Private TiempoRestante As TimeSpan = TimeSpan.Zero
    Private TemporizadorActivo As Boolean = False

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Panel3.Visible = False Then
            Panel3.Visible = True
        ElseIf Panel3.Visible = True Then
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TiempoRestante = TiempoRestante.Add(TimeSpan.FromMinutes(1))
        Label13.Text = TiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TiempoRestante = TiempoRestante.Add(TimeSpan.FromMinutes(5))
        Label13.Text = TiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TiempoRestante = TimeSpan.Zero Then
            MessageBox.Show("Agrega tiempo primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If TemporizadorActivo = False Then
            Timer4.Enabled = True
            TemporizadorActivo = True
            Button9.Text = "Detener"
        Else
            Timer4.Enabled = False
            TemporizadorActivo = False
            Button9.Text = "Iniciar"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Timer4.Enabled = False
        TiempoRestante = TimeSpan.Zero
        TemporizadorActivo = False
        Label13.Text = "00:00"
        Button9.Text = "Iniciar"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If TiempoRestante.TotalMilliseconds > 0 Then
            TiempoRestante = TiempoRestante.Subtract(TimeSpan.FromMilliseconds(Timer4.Interval))
            Label13.Text = TiempoRestante.ToString("mm\:ss")
        Else
            Timer4.Enabled = False
            TemporizadorActivo = False
            TiempoRestante = TimeSpan.Zero
            Label13.Text = "00:00"
            Button9.Text = "Iniciar"

            MessageBox.Show("¡Tiempo Terminado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class


