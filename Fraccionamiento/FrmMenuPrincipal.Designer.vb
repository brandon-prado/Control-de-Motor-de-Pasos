<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPasoSimple = New System.Windows.Forms.Button()
        Me.BtnPasoSimpleInverso = New System.Windows.Forms.Button()
        Me.BtnPasoDoble = New System.Windows.Forms.Button()
        Me.BtnPasoDobleInverso = New System.Windows.Forms.Button()
        Me.BtnPasoMedio = New System.Windows.Forms.Button()
        Me.BtnPasoMedioInverso = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrarConexion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBRotacion = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVHistorial = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ComboBoxPuertosCOM = New System.Windows.Forms.ComboBox()
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.TxtDatoRecibido = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCargarDGV = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBDerecha = New System.Windows.Forms.PictureBox()
        Me.PBIzquierda = New System.Windows.Forms.PictureBox()
        Me.PBTransportador = New System.Windows.Forms.PictureBox()
        Me.PBFlecha = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTransportador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(66, 677)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(77, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 75)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Menú principal"
        '
        'FechaHora
        '
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHora.Location = New System.Drawing.Point(1119, 37)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 254
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(1002, 6)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(344, 23)
        Me.LbFecha.TabIndex = 253
        '
        'BtnPasoSimple
        '
        Me.BtnPasoSimple.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnPasoSimple.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.BtnPasoSimple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.BtnPasoSimple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.BtnPasoSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPasoSimple.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPasoSimple.Location = New System.Drawing.Point(88, 353)
        Me.BtnPasoSimple.Name = "BtnPasoSimple"
        Me.BtnPasoSimple.Size = New System.Drawing.Size(363, 35)
        Me.BtnPasoSimple.TabIndex = 255
        Me.BtnPasoSimple.Text = "Paso simple"
        Me.BtnPasoSimple.UseVisualStyleBackColor = False
        '
        'BtnPasoSimpleInverso
        '
        Me.BtnPasoSimpleInverso.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnPasoSimpleInverso.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.BtnPasoSimpleInverso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.BtnPasoSimpleInverso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.BtnPasoSimpleInverso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPasoSimpleInverso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPasoSimpleInverso.Location = New System.Drawing.Point(88, 396)
        Me.BtnPasoSimpleInverso.Name = "BtnPasoSimpleInverso"
        Me.BtnPasoSimpleInverso.Size = New System.Drawing.Size(363, 35)
        Me.BtnPasoSimpleInverso.TabIndex = 256
        Me.BtnPasoSimpleInverso.Text = "Paso simple inverso"
        Me.BtnPasoSimpleInverso.UseVisualStyleBackColor = False
        '
        'BtnPasoDoble
        '
        Me.BtnPasoDoble.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnPasoDoble.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnPasoDoble.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.BtnPasoDoble.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.BtnPasoDoble.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPasoDoble.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPasoDoble.Location = New System.Drawing.Point(87, 438)
        Me.BtnPasoDoble.Name = "BtnPasoDoble"
        Me.BtnPasoDoble.Size = New System.Drawing.Size(363, 35)
        Me.BtnPasoDoble.TabIndex = 257
        Me.BtnPasoDoble.Text = "Paso doble"
        Me.BtnPasoDoble.UseVisualStyleBackColor = False
        '
        'BtnPasoDobleInverso
        '
        Me.BtnPasoDobleInverso.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnPasoDobleInverso.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnPasoDobleInverso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.BtnPasoDobleInverso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.BtnPasoDobleInverso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPasoDobleInverso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPasoDobleInverso.Location = New System.Drawing.Point(87, 479)
        Me.BtnPasoDobleInverso.Name = "BtnPasoDobleInverso"
        Me.BtnPasoDobleInverso.Size = New System.Drawing.Size(363, 35)
        Me.BtnPasoDobleInverso.TabIndex = 258
        Me.BtnPasoDobleInverso.Text = "Paso doble inverso"
        Me.BtnPasoDobleInverso.UseVisualStyleBackColor = False
        '
        'BtnPasoMedio
        '
        Me.BtnPasoMedio.BackColor = System.Drawing.Color.Tomato
        Me.BtnPasoMedio.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BtnPasoMedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnPasoMedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.BtnPasoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPasoMedio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPasoMedio.Location = New System.Drawing.Point(87, 522)
        Me.BtnPasoMedio.Name = "BtnPasoMedio"
        Me.BtnPasoMedio.Size = New System.Drawing.Size(363, 35)
        Me.BtnPasoMedio.TabIndex = 259
        Me.BtnPasoMedio.Text = "Paso medio"
        Me.BtnPasoMedio.UseVisualStyleBackColor = False
        '
        'BtnPasoMedioInverso
        '
        Me.BtnPasoMedioInverso.BackColor = System.Drawing.Color.Tomato
        Me.BtnPasoMedioInverso.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BtnPasoMedioInverso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnPasoMedioInverso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.BtnPasoMedioInverso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPasoMedioInverso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPasoMedioInverso.Location = New System.Drawing.Point(87, 565)
        Me.BtnPasoMedioInverso.Name = "BtnPasoMedioInverso"
        Me.BtnPasoMedioInverso.Size = New System.Drawing.Size(363, 35)
        Me.BtnPasoMedioInverso.TabIndex = 260
        Me.BtnPasoMedioInverso.Text = "Paso medio inverso"
        Me.BtnPasoMedioInverso.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 33)
        Me.Label2.TabIndex = 261
        Me.Label2.Text = "Submenú para controlar el motor"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(85, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(368, 55)
        Me.Label3.TabIndex = 262
        Me.Label3.Text = "Selecciona el paso que deseas que realice el motor:"
        '
        'BtnCerrarConexion
        '
        Me.BtnCerrarConexion.BackColor = System.Drawing.Color.Maroon
        Me.BtnCerrarConexion.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.BtnCerrarConexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnCerrarConexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.BtnCerrarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarConexion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCerrarConexion.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarConexion.Location = New System.Drawing.Point(88, 608)
        Me.BtnCerrarConexion.Name = "BtnCerrarConexion"
        Me.BtnCerrarConexion.Size = New System.Drawing.Size(363, 35)
        Me.BtnCerrarConexion.TabIndex = 263
        Me.BtnCerrarConexion.Text = "Cerrar conexión"
        Me.BtnCerrarConexion.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(496, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 33)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Gráfico"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(497, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 33)
        Me.Label5.TabIndex = 267
        Me.Label5.Text = "Dato de giro:"
        '
        'LBRotacion
        '
        Me.LBRotacion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBRotacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBRotacion.Location = New System.Drawing.Point(605, 133)
        Me.LBRotacion.Name = "LBRotacion"
        Me.LBRotacion.Size = New System.Drawing.Size(149, 33)
        Me.LBRotacion.TabIndex = 268
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(873, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(421, 33)
        Me.Label6.TabIndex = 269
        Me.Label6.Text = "Estado e historial de ejecución"
        '
        'DGVHistorial
        '
        Me.DGVHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHistorial.Location = New System.Drawing.Point(878, 363)
        Me.DGVHistorial.Name = "DGVHistorial"
        Me.DGVHistorial.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        Me.DGVHistorial.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVHistorial.Size = New System.Drawing.Size(432, 240)
        Me.DGVHistorial.TabIndex = 270
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(874, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(329, 48)
        Me.Label7.TabIndex = 271
        Me.Label7.Text = "Información de ejecuciones guardadas en ORACLE DB:"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(87, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 33)
        Me.Label8.TabIndex = 272
        Me.Label8.Text = "Conexión con Arduino"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(85, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(273, 55)
        Me.Label9.TabIndex = 273
        Me.Label9.Text = "Selecciona el puerto en el que se encuentra conectado el Arduino:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(88, 210)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(86, 29)
        Me.BtnBuscar.TabIndex = 274
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'ComboBoxPuertosCOM
        '
        Me.ComboBoxPuertosCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPuertosCOM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxPuertosCOM.FormattingEnabled = True
        Me.ComboBoxPuertosCOM.Location = New System.Drawing.Point(189, 210)
        Me.ComboBoxPuertosCOM.Name = "ComboBoxPuertosCOM"
        Me.ComboBoxPuertosCOM.Size = New System.Drawing.Size(157, 29)
        Me.ComboBoxPuertosCOM.TabIndex = 275
        '
        'BtnConectar
        '
        Me.BtnConectar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnConectar.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.BtnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.BtnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConectar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnConectar.Location = New System.Drawing.Point(365, 209)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(86, 29)
        Me.BtnConectar.TabIndex = 276
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.UseVisualStyleBackColor = False
        '
        'TxtDatoRecibido
        '
        Me.TxtDatoRecibido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtDatoRecibido.Location = New System.Drawing.Point(878, 160)
        Me.TxtDatoRecibido.Multiline = True
        Me.TxtDatoRecibido.Name = "TxtDatoRecibido"
        Me.TxtDatoRecibido.ReadOnly = True
        Me.TxtDatoRecibido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDatoRecibido.Size = New System.Drawing.Size(432, 139)
        Me.TxtDatoRecibido.TabIndex = 277
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(1218, 613)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(94, 31)
        Me.BtnEliminar.TabIndex = 281
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCargarDGV
        '
        Me.BtnCargarDGV.Location = New System.Drawing.Point(1119, 613)
        Me.BtnCargarDGV.Name = "BtnCargarDGV"
        Me.BtnCargarDGV.Size = New System.Drawing.Size(94, 31)
        Me.BtnCargarDGV.TabIndex = 282
        Me.BtnCargarDGV.Text = "Refrescar"
        Me.BtnCargarDGV.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(874, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(438, 32)
        Me.Label10.TabIndex = 283
        Me.Label10.Text = "Información recibida desde el Puerto Serial:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ControlMotor.My.Resources.Resources.oracleDB
        Me.PictureBox3.Location = New System.Drawing.Point(1199, 303)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 286
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ControlMotor.My.Resources.Resources.geogebra
        Me.PictureBox2.Location = New System.Drawing.Point(739, 463)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 285
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ControlMotor.My.Resources.Resources.arduinoLogo
        Me.PictureBox1.Location = New System.Drawing.Point(364, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 284
        Me.PictureBox1.TabStop = False
        '
        'PBDerecha
        '
        Me.PBDerecha.Image = Global.ControlMotor.My.Resources.Resources.derecha
        Me.PBDerecha.Location = New System.Drawing.Point(501, 496)
        Me.PBDerecha.Name = "PBDerecha"
        Me.PBDerecha.Size = New System.Drawing.Size(76, 148)
        Me.PBDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDerecha.TabIndex = 280
        Me.PBDerecha.TabStop = False
        '
        'PBIzquierda
        '
        Me.PBIzquierda.Image = Global.ControlMotor.My.Resources.Resources.izquierda
        Me.PBIzquierda.Location = New System.Drawing.Point(750, 496)
        Me.PBIzquierda.Name = "PBIzquierda"
        Me.PBIzquierda.Size = New System.Drawing.Size(76, 148)
        Me.PBIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBIzquierda.TabIndex = 279
        Me.PBIzquierda.TabStop = False
        '
        'PBTransportador
        '
        Me.PBTransportador.Image = Global.ControlMotor.My.Resources.Resources.transportador360
        Me.PBTransportador.Location = New System.Drawing.Point(588, 496)
        Me.PBTransportador.Name = "PBTransportador"
        Me.PBTransportador.Size = New System.Drawing.Size(150, 148)
        Me.PBTransportador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBTransportador.TabIndex = 278
        Me.PBTransportador.TabStop = False
        '
        'PBFlecha
        '
        Me.PBFlecha.Image = Global.ControlMotor.My.Resources.Resources.grafico001
        Me.PBFlecha.Location = New System.Drawing.Point(501, 168)
        Me.PBFlecha.Name = "PBFlecha"
        Me.PBFlecha.Size = New System.Drawing.Size(325, 325)
        Me.PBFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFlecha.TabIndex = 265
        Me.PBFlecha.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnSalir.BackgroundImage = Global.ControlMotor.My.Resources.Resources.regresar
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(10, 615)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(47, 47)
        Me.BtnSalir.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Haz clic para cerra menú principal")
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 666)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnCargarDGV)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.PBDerecha)
        Me.Controls.Add(Me.PBIzquierda)
        Me.Controls.Add(Me.PBTransportador)
        Me.Controls.Add(Me.LBRotacion)
        Me.Controls.Add(Me.DGVHistorial)
        Me.Controls.Add(Me.TxtDatoRecibido)
        Me.Controls.Add(Me.BtnConectar)
        Me.Controls.Add(Me.ComboBoxPuertosCOM)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PBFlecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCerrarConexion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPasoMedioInverso)
        Me.Controls.Add(Me.BtnPasoMedio)
        Me.Controls.Add(Me.BtnPasoDobleInverso)
        Me.Controls.Add(Me.BtnPasoDoble)
        Me.Controls.Add(Me.BtnPasoSimpleInverso)
        Me.Controls.Add(Me.BtnPasoSimple)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTransportador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnPasoSimple As Button
    Friend WithEvents BtnPasoSimpleInverso As Button
    Friend WithEvents BtnPasoDoble As Button
    Friend WithEvents BtnPasoDobleInverso As Button
    Friend WithEvents BtnPasoMedio As Button
    Friend WithEvents BtnPasoMedioInverso As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCerrarConexion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PBFlecha As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVHistorial As DataGridView
    Friend WithEvents Label7 As Label
    Public WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents ComboBoxPuertosCOM As ComboBox
    Friend WithEvents BtnConectar As Button
    Public WithEvents LBRotacion As Label
    Public WithEvents TxtDatoRecibido As TextBox
    Friend WithEvents PBTransportador As PictureBox
    Friend WithEvents PBIzquierda As PictureBox
    Friend WithEvents PBDerecha As PictureBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCargarDGV As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
