Imports Oracle.DataAccess.Client

Public Class FrmMenuPrincipal
    Private dato As Integer
    Private modoEjecucion As Integer
    'Private i As Integer = 0
    'BD
    Private idEjecucion As Integer
    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'MODO INICIAL
        BtnConectar.Enabled = False
        BtnPasoSimple.Enabled = False
        BtnPasoSimpleInverso.Enabled = False
        BtnPasoDoble.Enabled = False
        BtnPasoDobleInverso.Enabled = False
        BtnPasoMedio.Enabled = False
        BtnPasoMedioInverso.Enabled = False
        BtnCerrarConexion.Enabled = False
        ComboBoxPuertosCOM.Enabled = False
        CheckForIllegalCrossThreadCalls = False

        'Estado inicial del gráfico
        PBFlecha.Image = My.Resources.grafico001
        PBTransportador.Image = My.Resources.transportador360
        PBIzquierda.Visible = False
        PBDerecha.Visible = False

        'DGV
        ConsultaTodoElHistorial()
        'Bloquear
        BtnEliminar.Enabled = False
    End Sub

    'MÉTODO QUE CONSULTA EL HISTORIAL DE EJECUCIONES
    Public Sub ConsultaTodoElHistorial()
        Try
            strSql = "SELECT * FROM Vista_Todas_Ejecuciones"

            DGVHistorial.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVHistorial.Refresh()

            'Ocultar columna de ID
            DGVHistorial.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then
            MsgBox("Cierre la conexión")
            e.Cancel = True
        Else
            FrmInicio.Show()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnCerrarConexion_Click(sender As Object, e As EventArgs) Handles BtnCerrarConexion.Click
        'Cerrar cualquier indicacion anterior
        Try
            SerialPort1.Close()
            ComboBoxPuertosCOM.Items.Clear()
            BtnConectar.Enabled = False
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnCerrarConexion.Enabled = False
            BtnBuscar.Enabled = True
            ComboBoxPuertosCOM.Enabled = False
            BtnEliminar.Enabled = False
            DGVHistorial.DataSource = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            TxtDatoRecibido.Text += SerialPort1.ReadLine + " - "
            dato = Val(SerialPort1.ReadLine)
            If modoEjecucion = 2 Or modoEjecucion = 4 Or modoEjecucion = 6 Then
                If dato >= 0 And dato < 16 Then
                    LBRotacion.Text = "> 0°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico001
                ElseIf dato >= 16 And dato < 32 Then
                    LBRotacion.Text = "> 10°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico002
                ElseIf dato >= 32 And dato < 48 Then
                    LBRotacion.Text = "> 20°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico003
                ElseIf dato >= 48 And dato < 64 Then
                    LBRotacion.Text = "> 40°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico004
                ElseIf dato >= 64 And dato < 80 Then
                    LBRotacion.Text = "> 45°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico005
                ElseIf dato >= 80 And dato < 96 Then
                    LBRotacion.Text = "> 60°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico006
                ElseIf dato >= 96 And dato < 112 Then
                    LBRotacion.Text = "> 65°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico007
                ElseIf dato >= 112 And dato < 128 Then
                    LBRotacion.Text = "> 80°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico008
                ElseIf dato >= 128 And dato < 144 Then
                    LBRotacion.Text = "> 90°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico009
                ElseIf dato >= 144 And dato < 160 Then
                    LBRotacion.Text = "> 100°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico010
                ElseIf dato >= 160 And dato < 176 Then
                    LBRotacion.Text = "> 115°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico011
                ElseIf dato >= 176 And dato < 192 Then
                    LBRotacion.Text = "> 125°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico012
                ElseIf dato >= 192 And dato < 208 Then
                    LBRotacion.Text = "> 135°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico013
                ElseIf dato >= 208 And dato < 224 Then
                    LBRotacion.Text = "> 145°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico014
                ElseIf dato >= 224 And dato < 240 Then
                    LBRotacion.Text = "> 155°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico015
                ElseIf dato >= 240 And dato < 256 Then
                    LBRotacion.Text = "> 170°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico016
                ElseIf dato >= 256 And dato < 272 Then
                    LBRotacion.Text = "> 180°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico017
                ElseIf dato >= 272 And dato < 288 Then
                    LBRotacion.Text = "> 195°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico018
                ElseIf dato >= 288 And dato < 304 Then
                    LBRotacion.Text = "> 205°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico019
                ElseIf dato >= 304 And dato < 320 Then
                    LBRotacion.Text = "> 215°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico020
                ElseIf dato >= 320 And dato < 336 Then
                    LBRotacion.Text = "> 225°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico021
                ElseIf dato >= 336 And dato < 352 Then
                    LBRotacion.Text = "> 235°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico022
                ElseIf dato >= 352 And dato < 368 Then
                    LBRotacion.Text = "> 245°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico023
                ElseIf dato >= 368 And dato < 384 Then
                    LBRotacion.Text = "> 255°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico024
                ElseIf dato >= 384 And dato < 400 Then
                    LBRotacion.Text = "> 270°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico025
                ElseIf dato >= 400 And dato < 416 Then
                    LBRotacion.Text = "> 285°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico026
                ElseIf dato >= 416 And dato < 432 Then
                    LBRotacion.Text = "> 295°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico027
                ElseIf dato >= 432 And dato < 448 Then
                    LBRotacion.Text = "> 300°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico028
                ElseIf dato >= 448 And dato < 464 Then
                    LBRotacion.Text = "> 315°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico029
                ElseIf dato >= 464 And dato < 480 Then
                    LBRotacion.Text = "> 330°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico030
                ElseIf dato >= 480 And dato < 496 Then
                    LBRotacion.Text = "> 345°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico031
                ElseIf dato >= 496 And dato < 512 Then
                    LBRotacion.Text = "360°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico001
                    modoEjecucion = 0


                    'Desbloquear
                    BtnPasoSimple.Enabled = True
                    BtnPasoSimpleInverso.Enabled = True
                    BtnPasoDoble.Enabled = True
                    BtnPasoDobleInverso.Enabled = True
                    BtnPasoMedio.Enabled = True
                    BtnPasoMedioInverso.Enabled = True

                    ActualizarEjecucion()
                    'If i = 0 Then
                    '    ActualizarEjecucion()
                    '    Call BtnCargarDGV_Click(sender, e)
                    '    ConsultaTodoElHistorial()
                    '    i = 1
                    'End If
                End If
            ElseIf modoEjecucion = 1 Or modoEjecucion = 3 Or modoEjecucion = 5 Then
                If dato >= 0 And dato < 16 Then
                    LBRotacion.Text = "< 360°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico001
                ElseIf dato >= 16 And dato < 32 Then
                    LBRotacion.Text = "< 345°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico031
                ElseIf dato >= 32 And dato < 48 Then
                    LBRotacion.Text = "< 330°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico030
                ElseIf dato >= 48 And dato < 64 Then
                    LBRotacion.Text = "< 315°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico029
                ElseIf dato >= 64 And dato < 80 Then
                    LBRotacion.Text = "< 300°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico028
                ElseIf dato >= 80 And dato < 96 Then
                    LBRotacion.Text = "< 295°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico027
                ElseIf dato >= 96 And dato < 112 Then
                    LBRotacion.Text = "< 285°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico026
                ElseIf dato >= 112 And dato < 128 Then
                    LBRotacion.Text = "< 270°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico025
                ElseIf dato >= 128 And dato < 144 Then
                    LBRotacion.Text = "< 255°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico024
                ElseIf dato >= 144 And dato < 160 Then
                    LBRotacion.Text = "< 245°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico023
                ElseIf dato >= 160 And dato < 176 Then
                    LBRotacion.Text = "< 235°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico022
                ElseIf dato >= 176 And dato < 192 Then
                    LBRotacion.Text = "< 225°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico021
                ElseIf dato >= 192 And dato < 208 Then
                    LBRotacion.Text = "< 215°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico020
                ElseIf dato >= 208 And dato < 224 Then
                    LBRotacion.Text = "< 205°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico019
                ElseIf dato >= 224 And dato < 240 Then
                    LBRotacion.Text = "< 195°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico018
                ElseIf dato >= 240 And dato < 256 Then
                    LBRotacion.Text = "< 180°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico017
                ElseIf dato >= 256 And dato < 272 Then
                    LBRotacion.Text = "< 170°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico016
                ElseIf dato >= 272 And dato < 288 Then
                    LBRotacion.Text = "< 155°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico015
                ElseIf dato >= 288 And dato < 304 Then
                    LBRotacion.Text = "< 145°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico014
                ElseIf dato >= 304 And dato < 320 Then
                    LBRotacion.Text = "< 135°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico013
                ElseIf dato >= 320 And dato < 336 Then
                    LBRotacion.Text = "< 125°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico012
                ElseIf dato >= 336 And dato < 352 Then
                    LBRotacion.Text = "< 115°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico011
                ElseIf dato >= 352 And dato < 368 Then
                    LBRotacion.Text = "< 100°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico010
                ElseIf dato >= 368 And dato < 384 Then
                    LBRotacion.Text = "< 90°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico009
                ElseIf dato >= 384 And dato < 400 Then
                    LBRotacion.Text = "< 80°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico008
                ElseIf dato >= 400 And dato < 416 Then
                    LBRotacion.Text = "< 65°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico007
                ElseIf dato >= 416 And dato < 432 Then
                    LBRotacion.Text = "< 60°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico006
                ElseIf dato >= 432 And dato < 448 Then
                    LBRotacion.Text = "< 45°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico005
                ElseIf dato >= 448 And dato < 464 Then
                    LBRotacion.Text = "< 40°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico004
                ElseIf dato >= 464 And dato < 480 Then
                    LBRotacion.Text = "< 20°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico003
                ElseIf dato >= 480 And dato < 496 Then
                    LBRotacion.Text = "< 10°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico002
                ElseIf dato >= 496 And dato < 512 Then
                    LBRotacion.Text = "0°"
                    SerialPort1.DiscardInBuffer()
                    PBFlecha.Image = My.Resources.grafico001
                    modoEjecucion = 0

                    'Desbloquear
                    BtnPasoSimple.Enabled = True
                    BtnPasoSimpleInverso.Enabled = True
                    BtnPasoDoble.Enabled = True
                    BtnPasoDobleInverso.Enabled = True
                    BtnPasoMedio.Enabled = True
                    BtnPasoMedioInverso.Enabled = True

                    ActualizarEjecucion()
                    'If i = 0 Then
                    '    ActualizarEjecucion()
                    '    'Call BtnCargarDGV_Click(sender, e)
                    '    'ConsultaTodoElHistorial()
                    '    i = 1
                    'End If
                End If
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ComboBoxPuertosCOM.Items.Clear()

        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames
            ComboBoxPuertosCOM.Items.Add(PuertoDisponible)
        Next

        If ComboBoxPuertosCOM.Items.Count > 0 Then
            ComboBoxPuertosCOM.Text = ComboBoxPuertosCOM.Items(0)
            BtnConectar.Enabled = True
            ComboBoxPuertosCOM.Enabled = True
        Else
            BtnConectar.Enabled = False
            ComboBoxPuertosCOM.Enabled = False
            ComboBoxPuertosCOM.Items.Clear()
        End If
    End Sub

    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click
        Try
            With SerialPort1
                .BaudRate = 9600
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = IO.Ports.StopBits.One
                .PortName = ComboBoxPuertosCOM.Text
                .Open()
            End With
            BtnConectar.Enabled = False
            BtnBuscar.Enabled = False
            BtnPasoSimple.Enabled = True
            BtnPasoSimpleInverso.Enabled = True
            BtnPasoDoble.Enabled = True
            BtnPasoDobleInverso.Enabled = True
            BtnPasoMedio.Enabled = True
            BtnPasoMedioInverso.Enabled = True
            BtnCerrarConexion.Enabled = True
            ComboBoxPuertosCOM.Enabled = False
            BtnEliminar.Enabled = False
            ConsultaTodoElHistorial()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Método que obtiene el id de la ejecución
    Public Sub ObtenerIdEjecucion()
        Try
            'Obtención del id la ejecución
            Dim xDT As New DataTable
            Dim conector As New OracleDataAdapter("SELECT MAX(id_ejecucion) FROM Ejecucion", cnx)
            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                idEjecucion = registro("MAX(id_ejecucion)")
            Next
        Catch ex As Exception

        End Try
    End Sub

    'Método que actualiza la ejecución con la fecha/hora de término
    Public Sub ActualizarEjecucion()
        Try
            ObtenerIdEjecucion()
            'Actualización de ejecución
            strSql = "BEGIN Ejecucion_Actualizar (" & idEjecucion & ", SYSDATE); End;"
            xCnx.objetoCommand(strSql)
            'Recarga los cambios realizados
            'ConsultaTodoElHistorial()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Método que elimina un registro de la tabla Ejecución
    Public Sub EliminarEjecucion()
        Try
            strSql = "BEGIN Ejecucion_Eliminar (" & idEjecucion & "); END;"
            xCnx.objetoCommand(strSql)
            'Recarga los cambios realizados
            ConsultaTodoElHistorial()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnPasoSimple_Click(sender As Object, e As EventArgs) Handles BtnPasoSimple.Click
        Try
            TxtDatoRecibido.Text = ""
            LBRotacion.Text = ""
            PBFlecha.Image = My.Resources.grafico001
            PBIzquierda.Visible = False
            PBDerecha.Visible = True
            'BD
            strSql = "BEGIN Ejecucion_Insertar ('PASO SIMPLE', SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            ObtenerIdEjecucion()
            ConsultaTodoElHistorial()
            'ARDUINO
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("1")
            modoEjecucion = 1
            'Bloquear
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnPasoSimpleInverso_Click(sender As Object, e As EventArgs) Handles BtnPasoSimpleInverso.Click
        Try
            TxtDatoRecibido.Text = ""
            LBRotacion.Text = ""
            PBFlecha.Image = My.Resources.grafico001
            PBIzquierda.Visible = True
            PBDerecha.Visible = False
            'BD
            strSql = "BEGIN Ejecucion_Insertar ('PASO SIMPLE INVERSO', SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            ObtenerIdEjecucion()
            ConsultaTodoElHistorial()
            'ARDUINO
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("2")
            modoEjecucion = 2
            'Bloquear
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPasoDoble_Click(sender As Object, e As EventArgs) Handles BtnPasoDoble.Click
        Try
            TxtDatoRecibido.Text = ""
            LBRotacion.Text = ""
            PBFlecha.Image = My.Resources.grafico001
            PBIzquierda.Visible = False
            PBDerecha.Visible = True
            'BD
            strSql = "BEGIN Ejecucion_Insertar ('PASO DOBLE', SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            ObtenerIdEjecucion()
            ConsultaTodoElHistorial()
            'ARDUINO
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("3")
            modoEjecucion = 3
            'Bloquear
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnEliminar.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPasoDobleInverso_Click(sender As Object, e As EventArgs) Handles BtnPasoDobleInverso.Click
        Try
            TxtDatoRecibido.Text = ""
            LBRotacion.Text = ""
            PBFlecha.Image = My.Resources.grafico001
            PBIzquierda.Visible = True
            PBDerecha.Visible = False
            'BD
            strSql = "BEGIN Ejecucion_Insertar ('PASO DOBLE INVERSO', SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            ObtenerIdEjecucion()
            ConsultaTodoElHistorial()
            'ARDUINO
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("4")
            modoEjecucion = 4
            'Bloquear
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPasoMedio_Click(sender As Object, e As EventArgs) Handles BtnPasoMedio.Click
        Try
            TxtDatoRecibido.Text = ""
            LBRotacion.Text = ""
            PBFlecha.Image = My.Resources.grafico001
            PBIzquierda.Visible = False
            PBDerecha.Visible = True
            'BD
            strSql = "BEGIN Ejecucion_Insertar ('PASO MEDIO', SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            ObtenerIdEjecucion()
            ConsultaTodoElHistorial()
            'ARDUINO
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("5")
            modoEjecucion = 5
            'Bloquear
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPasoMedioInverso_Click(sender As Object, e As EventArgs) Handles BtnPasoMedioInverso.Click
        Try
            TxtDatoRecibido.Text = ""
            LBRotacion.Text = ""
            PBFlecha.Image = My.Resources.grafico001
            PBIzquierda.Visible = True
            PBDerecha.Visible = False
            'BD
            strSql = "BEGIN Ejecucion_Insertar ('PASO MEDIO INVERSO', SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            ObtenerIdEjecucion()
            ConsultaTodoElHistorial()
            'ARDUINO
            SerialPort1.DiscardInBuffer()
            SerialPort1.Write("6")
            modoEjecucion = 6
            'Bloquear
            BtnPasoSimple.Enabled = False
            BtnPasoSimpleInverso.Enabled = False
            BtnPasoDoble.Enabled = False
            BtnPasoDobleInverso.Enabled = False
            BtnPasoMedio.Enabled = False
            BtnPasoMedioInverso.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'BD
        'ObtenerIdEjecucion()
        strSql = "BEGIN Ejecucion_Eliminar (" & idEjecucion & "); END;"
        xCnx.objetoCommand(strSql)
        ConsultaTodoElHistorial()
        'Bloquear
        BtnEliminar.Enabled = False
    End Sub

    Private Sub DGVHistorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHistorial.CellContentClick
        Dim renglon As Integer
        renglon = DGVHistorial.CurrentCellAddress.Y

        'Obtner id al seleccionar el registro
        idEjecucion = DGVHistorial.Rows(renglon).Cells(0).Value

        'Desbloquear
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnCargarDGV_Click(sender As Object, e As EventArgs) Handles BtnCargarDGV.Click
        ConsultaTodoElHistorial()
    End Sub
End Class