<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Segundos = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.BackColor = System.Drawing.Color.White
        Me.Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.Location = New System.Drawing.Point(211, 197)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(215, 153)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 153)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.Color.White
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.Location = New System.Drawing.Point(441, 197)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(215, 153)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(617, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 153)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = ":"
        '
        'Segundos
        '
        Me.Segundos.AutoSize = True
        Me.Segundos.BackColor = System.Drawing.Color.White
        Me.Segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Segundos.Location = New System.Drawing.Point(674, 197)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(215, 153)
        Me.Segundos.TabIndex = 4
        Me.Segundos.Text = "00"
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.BackColor = System.Drawing.Color.White
        Me.Dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dias.Location = New System.Drawing.Point(258, 340)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(133, 46)
        Me.Dias.TabIndex = 5
        Me.Dias.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.White
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(397, 340)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(424, 46)
        Me.Fecha.TabIndex = 6
        Me.Fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica4RelojDigital.My.Resources.Resources.OIP
        Me.PictureBox1.Location = New System.Drawing.Point(-115, -46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1297, 786)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(209, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 382)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Predeterminado (Negro)", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Cian", "Morado", "Rosa"})
        Me.ComboBox1.Location = New System.Drawing.Point(177, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(471, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(55, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 72)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Configuración"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Click Derecho"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 708)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Segundos As Label
    Friend WithEvents Dias As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
