<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(66, 611)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ControlMotor.My.Resources.Resources.tecnm_its
        Me.PictureBox1.Location = New System.Drawing.Point(68, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(555, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(188, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Control de un motor"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ControlMotor.My.Resources.Resources.motor
        Me.PictureBox2.Location = New System.Drawing.Point(133, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(411, 180)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ControlMotor.My.Resources.Resources.motorGif
        Me.PictureBox3.Location = New System.Drawing.Point(352, 112)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(192, 180)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(133, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 216)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sistemas Programables" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Impartida por: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MC. Luis Javier Mona Peña." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Equipo: A" &
    " - Z" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Eimy Lu-ruhama Cruz Rodríguez." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Brandon Alexis Prado Castro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Mario " &
    "Orlando Torres Salazar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnSalir.BackgroundImage = Global.ControlMotor.My.Resources.Resources.regresar
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(10, 553)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(47, 47)
        Me.BtnSalir.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Haz clic para cerra el programa")
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciar.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnIniciar.ForeColor = System.Drawing.Color.White
        Me.BtnIniciar.Location = New System.Drawing.Point(247, 539)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(173, 56)
        Me.BtnIniciar.TabIndex = 7
        Me.BtnIniciar.Text = "Menú principal"
        Me.ToolTip1.SetToolTip(Me.BtnIniciar, "Haz clic para abrir el menú principal")
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 607)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
