<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 179)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Iván Rincón 2014"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.security_card100
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Validador NIF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Versión 2.0.4"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(218, 205)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Text = "Acerca de Validador NIF"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
