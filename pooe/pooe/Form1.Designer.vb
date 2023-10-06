<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblDeTipo = New System.Windows.Forms.Label()
        Me.lblATipo = New System.Windows.Forms.Label()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.cboTipoConversor = New System.Windows.Forms.ComboBox()
        Me.cboATipoConversor = New System.Windows.Forms.ComboBox()
        Me.cboDeTipoConversor = New System.Windows.Forms.ComboBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.txtConvertir = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.erpConversor = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erpConversor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(104, 54)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(49, 19)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'lblDeTipo
        '
        Me.lblDeTipo.AutoSize = True
        Me.lblDeTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblDeTipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeTipo.ForeColor = System.Drawing.Color.White
        Me.lblDeTipo.Location = New System.Drawing.Point(104, 99)
        Me.lblDeTipo.Name = "lblDeTipo"
        Me.lblDeTipo.Size = New System.Drawing.Size(36, 19)
        Me.lblDeTipo.TabIndex = 1
        Me.lblDeTipo.Text = "De:"
        '
        'lblATipo
        '
        Me.lblATipo.AutoSize = True
        Me.lblATipo.BackColor = System.Drawing.Color.Transparent
        Me.lblATipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATipo.ForeColor = System.Drawing.Color.White
        Me.lblATipo.Location = New System.Drawing.Point(104, 138)
        Me.lblATipo.Name = "lblATipo"
        Me.lblATipo.Size = New System.Drawing.Size(26, 19)
        Me.lblATipo.TabIndex = 2
        Me.lblATipo.Text = "A:"
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.BackColor = System.Drawing.Color.Transparent
        Me.lblRespuesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.ForeColor = System.Drawing.Color.White
        Me.lblRespuesta.Location = New System.Drawing.Point(363, 102)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(111, 19)
        Me.lblRespuesta.TabIndex = 3
        Me.lblRespuesta.Text = "Respuesta: ?"
        '
        'cboTipoConversor
        '
        Me.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConversor.FormattingEnabled = True
        Me.cboTipoConversor.Items.AddRange(New Object() {"Moneda", "Longitud", "Tiempo"})
        Me.cboTipoConversor.Location = New System.Drawing.Point(186, 55)
        Me.cboTipoConversor.Name = "cboTipoConversor"
        Me.cboTipoConversor.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoConversor.TabIndex = 4
        '
        'cboATipoConversor
        '
        Me.cboATipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboATipoConversor.FormattingEnabled = True
        Me.cboATipoConversor.Location = New System.Drawing.Point(186, 139)
        Me.cboATipoConversor.Name = "cboATipoConversor"
        Me.cboATipoConversor.Size = New System.Drawing.Size(121, 21)
        Me.cboATipoConversor.TabIndex = 5
        '
        'cboDeTipoConversor
        '
        Me.cboDeTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeTipoConversor.FormattingEnabled = True
        Me.cboDeTipoConversor.Location = New System.Drawing.Point(186, 100)
        Me.cboDeTipoConversor.Name = "cboDeTipoConversor"
        Me.cboDeTipoConversor.Size = New System.Drawing.Size(121, 21)
        Me.cboDeTipoConversor.TabIndex = 6
        '
        'btnConvertir
        '
        Me.btnConvertir.BackColor = System.Drawing.Color.Transparent
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.ForeColor = System.Drawing.Color.Black
        Me.btnConvertir.Location = New System.Drawing.Point(186, 214)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(92, 27)
        Me.btnConvertir.TabIndex = 7
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = False
        '
        'txtConvertir
        '
        Me.txtConvertir.Location = New System.Drawing.Point(194, 176)
        Me.txtConvertir.Name = "txtConvertir"
        Me.txtConvertir.Size = New System.Drawing.Size(113, 20)
        Me.txtConvertir.TabIndex = 8
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(104, 177)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(84, 19)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Cantidad:"
        '
        'erpConversor
        '
        Me.erpConversor.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(501, 280)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtConvertir)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.cboDeTipoConversor)
        Me.Controls.Add(Me.cboATipoConversor)
        Me.Controls.Add(Me.cboTipoConversor)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.lblATipo)
        Me.Controls.Add(Me.lblDeTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.erpConversor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTipo As Label
    Friend WithEvents lblDeTipo As Label
    Friend WithEvents lblATipo As Label
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents cboTipoConversor As ComboBox
    Friend WithEvents cboATipoConversor As ComboBox
    Friend WithEvents cboDeTipoConversor As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtConvertir As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents erpConversor As ErrorProvider
End Class
