<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Silver
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(897, 504)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(897, 504)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(400, 0)
        Me.Name = "Form2"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Text = "Ayuda Validador NIF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
