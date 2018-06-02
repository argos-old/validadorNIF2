<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidadorSiempreEncimaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobarLetraAlPegarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CómoFuncionaValidadorNIFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeLaAplicaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidadorSiempreEncimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobarLetraAlPegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CómoFuncionaValidadorNIFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeLaAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(6, 14)
        Me.MaskedTextBox1.Mask = "00,000,000-?"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(145, 29)
        Me.MaskedTextBox1.TabIndex = 0
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.NuevoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 70)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = Global.Validador_NIF_2.x.My.Resources.Resources.copy16
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Image = Global.Validador_NIF_2.x.My.Resources.Resources.paste16
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.Validador_NIF_2.x.My.Resources.Resources.new16
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem1, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(168, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem1
        '
        Me.ConfiguraciónToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarResultadoAlPortapapelesToolStripMenuItem1, Me.ValidadorSiempreEncimaToolStripMenuItem1, Me.ComprobarLetraAlPegarToolStripMenuItem1})
        Me.ConfiguraciónToolStripMenuItem1.Name = "ConfiguraciónToolStripMenuItem1"
        Me.ConfiguraciónToolStripMenuItem1.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem1.Text = "&Configuración"
        '
        'CopiarResultadoAlPortapapelesToolStripMenuItem1
        '
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1.Checked = True
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.paste16
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1.Name = "CopiarResultadoAlPortapapelesToolStripMenuItem1"
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1.Size = New System.Drawing.Size(244, 22)
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem1.Text = "Copiar resultado al portapapeles"
        '
        'ValidadorSiempreEncimaToolStripMenuItem1
        '
        Me.ValidadorSiempreEncimaToolStripMenuItem1.Checked = True
        Me.ValidadorSiempreEncimaToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ValidadorSiempreEncimaToolStripMenuItem1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.upB16
        Me.ValidadorSiempreEncimaToolStripMenuItem1.Name = "ValidadorSiempreEncimaToolStripMenuItem1"
        Me.ValidadorSiempreEncimaToolStripMenuItem1.Size = New System.Drawing.Size(244, 22)
        Me.ValidadorSiempreEncimaToolStripMenuItem1.Text = "Validador siempre encima"
        '
        'ComprobarLetraAlPegarToolStripMenuItem1
        '
        Me.ComprobarLetraAlPegarToolStripMenuItem1.Checked = True
        Me.ComprobarLetraAlPegarToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ComprobarLetraAlPegarToolStripMenuItem1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.lupa16
        Me.ComprobarLetraAlPegarToolStripMenuItem1.Name = "ComprobarLetraAlPegarToolStripMenuItem1"
        Me.ComprobarLetraAlPegarToolStripMenuItem1.Size = New System.Drawing.Size(244, 22)
        Me.ComprobarLetraAlPegarToolStripMenuItem1.Text = "Comprobar letra al pegar"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CómoFuncionaValidadorNIFToolStripMenuItem1, Me.AcercaDeLaAplicaciónToolStripMenuItem1})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem1.Text = "&Ayuda"
        '
        'CómoFuncionaValidadorNIFToolStripMenuItem1
        '
        Me.CómoFuncionaValidadorNIFToolStripMenuItem1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.question16
        Me.CómoFuncionaValidadorNIFToolStripMenuItem1.Name = "CómoFuncionaValidadorNIFToolStripMenuItem1"
        Me.CómoFuncionaValidadorNIFToolStripMenuItem1.Size = New System.Drawing.Size(231, 22)
        Me.CómoFuncionaValidadorNIFToolStripMenuItem1.Text = "Cómo funciona Validador NIF"
        '
        'AcercaDeLaAplicaciónToolStripMenuItem1
        '
        Me.AcercaDeLaAplicaciónToolStripMenuItem1.Image = Global.Validador_NIF_2.x.My.Resources.Resources.información16
        Me.AcercaDeLaAplicaciónToolStripMenuItem1.Name = "AcercaDeLaAplicaciónToolStripMenuItem1"
        Me.AcercaDeLaAplicaciónToolStripMenuItem1.Size = New System.Drawing.Size(231, 22)
        Me.AcercaDeLaAplicaciónToolStripMenuItem1.Text = "Acerca de la aplicación"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'CopiarResultadoAlPortapapelesToolStripMenuItem
        '
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem.Name = "CopiarResultadoAlPortapapelesToolStripMenuItem"
        Me.CopiarResultadoAlPortapapelesToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'ValidadorSiempreEncimaToolStripMenuItem
        '
        Me.ValidadorSiempreEncimaToolStripMenuItem.Name = "ValidadorSiempreEncimaToolStripMenuItem"
        Me.ValidadorSiempreEncimaToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'ComprobarLetraAlPegarToolStripMenuItem
        '
        Me.ComprobarLetraAlPegarToolStripMenuItem.Name = "ComprobarLetraAlPegarToolStripMenuItem"
        Me.ComprobarLetraAlPegarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'CómoFuncionaValidadorNIFToolStripMenuItem
        '
        Me.CómoFuncionaValidadorNIFToolStripMenuItem.Name = "CómoFuncionaValidadorNIFToolStripMenuItem"
        Me.CómoFuncionaValidadorNIFToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'AcercaDeLaAplicaciónToolStripMenuItem
        '
        Me.AcercaDeLaAplicaciónToolStripMenuItem.Name = "AcercaDeLaAplicaciónToolStripMenuItem"
        Me.AcercaDeLaAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.KryptonButton3)
        Me.Panel1.Controls.Add(Me.KryptonButton2)
        Me.Panel1.Controls.Add(Me.KryptonButton1)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 144)
        Me.Panel1.TabIndex = 1
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(81, 99)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton3.Size = New System.Drawing.Size(68, 34)
        Me.KryptonButton3.TabIndex = 3
        Me.KryptonButton3.Values.Image = Global.Validador_NIF_2.x.My.Resources.Resources.paste16
        Me.KryptonButton3.Values.Text = "Pegar"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(7, 99)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton2.Size = New System.Drawing.Size(68, 34)
        Me.KryptonButton2.TabIndex = 2
        Me.KryptonButton2.Values.Image = Global.Validador_NIF_2.x.My.Resources.Resources.new16
        Me.KryptonButton2.Values.Text = "Nuevo"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(6, 59)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton1.Size = New System.Drawing.Size(145, 34)
        Me.KryptonButton1.TabIndex = 1
        Me.KryptonButton1.Values.Image = Global.Validador_NIF_2.x.My.Resources.Resources.lupa16
        Me.KryptonButton1.Values.Text = "Comprobar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(5, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 49)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Image = Global.Validador_NIF_2.x.My.Resources.Resources.security_card48
        Me.Label2.Location = New System.Drawing.Point(7, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(50, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Validador NIF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(168, 239)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Text = "Test NIF"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarResultadoAlPortapapelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValidadorSiempreEncimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CómoFuncionaValidadorNIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeLaAplicaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComprobarLetraAlPegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarResultadoAlPortapapelesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValidadorSiempreEncimaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprobarLetraAlPegarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CómoFuncionaValidadorNIFToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeLaAplicaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
