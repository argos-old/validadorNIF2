<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel1.Controls.Add(Me.Label2)
        Me.KryptonPanel1.Controls.Add(Me.Label1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCustom1
        Me.KryptonPanel1.Size = New System.Drawing.Size(393, 145)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(271, 106)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton1.Size = New System.Drawing.Size(105, 27)
        Me.KryptonButton1.TabIndex = 3
        Me.KryptonButton1.Values.Text = "&Aceptar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 66)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.exclamación48
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 66)
        Me.Label1.TabIndex = 1
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 145)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Text = "Form4"
        Me.TopMost = True
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
