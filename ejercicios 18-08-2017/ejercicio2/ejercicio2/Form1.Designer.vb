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
        Me.cvCursiva = New System.Windows.Forms.CheckBox()
        Me.bolectura = New System.Windows.Forms.RadioButton()
        Me.boescritura = New System.Windows.Forms.RadioButton()
        Me.bdhColortexto = New System.Windows.Forms.HScrollBar()
        Me.IsLista = New System.Windows.Forms.ListBox()
        Me.ctDato = New System.Windows.Forms.TextBox()
        Me.btAñadir = New System.Windows.Forms.Button()
        Me.BarradeMenus = New System.Windows.Forms.MenuStrip()
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.itOpcionesColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.itOpcionesSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.itAyudaAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.BarradeMenus.SuspendLayout()
        Me.SuspendLayout()
        '
        'cvCursiva
        '
        Me.cvCursiva.AutoSize = True
        Me.cvCursiva.Location = New System.Drawing.Point(29, 72)
        Me.cvCursiva.Name = "cvCursiva"
        Me.cvCursiva.Size = New System.Drawing.Size(61, 17)
        Me.cvCursiva.TabIndex = 0
        Me.cvCursiva.Text = "Cursiva"
        Me.cvCursiva.UseVisualStyleBackColor = True
        '
        'bolectura
        '
        Me.bolectura.AutoSize = True
        Me.bolectura.Location = New System.Drawing.Point(29, 112)
        Me.bolectura.Name = "bolectura"
        Me.bolectura.Size = New System.Drawing.Size(61, 17)
        Me.bolectura.TabIndex = 1
        Me.bolectura.Text = "Lectura"
        Me.bolectura.UseVisualStyleBackColor = True
        '
        'boescritura
        '
        Me.boescritura.AutoSize = True
        Me.boescritura.Checked = True
        Me.boescritura.Location = New System.Drawing.Point(32, 149)
        Me.boescritura.Name = "boescritura"
        Me.boescritura.Size = New System.Drawing.Size(107, 17)
        Me.boescritura.TabIndex = 2
        Me.boescritura.TabStop = True
        Me.boescritura.Text = "Lectura/Escritura"
        Me.boescritura.UseVisualStyleBackColor = True
        '
        'bdhColortexto
        '
        Me.bdhColortexto.Location = New System.Drawing.Point(29, 236)
        Me.bdhColortexto.Maximum = 255
        Me.bdhColortexto.Name = "bdhColortexto"
        Me.bdhColortexto.Size = New System.Drawing.Size(80, 17)
        Me.bdhColortexto.TabIndex = 3
        Me.bdhColortexto.TabStop = True
        '
        'IsLista
        '
        Me.IsLista.FormattingEnabled = True
        Me.IsLista.Location = New System.Drawing.Point(203, 25)
        Me.IsLista.Name = "IsLista"
        Me.IsLista.Size = New System.Drawing.Size(120, 173)
        Me.IsLista.TabIndex = 4
        '
        'ctDato
        '
        Me.ctDato.Location = New System.Drawing.Point(29, 46)
        Me.ctDato.Name = "ctDato"
        Me.ctDato.ReadOnly = True
        Me.ctDato.Size = New System.Drawing.Size(100, 20)
        Me.ctDato.TabIndex = 5
        '
        'btAñadir
        '
        Me.btAñadir.Location = New System.Drawing.Point(203, 214)
        Me.btAñadir.Name = "btAñadir"
        Me.btAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btAñadir.TabIndex = 6
        Me.btAñadir.Text = "Añadir"
        Me.btAñadir.UseVisualStyleBackColor = True
        '
        'BarradeMenus
        '
        Me.BarradeMenus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpciones, Me.mnuAyuda})
        Me.BarradeMenus.Location = New System.Drawing.Point(0, 0)
        Me.BarradeMenus.Name = "BarradeMenus"
        Me.BarradeMenus.Size = New System.Drawing.Size(529, 24)
        Me.BarradeMenus.TabIndex = 7
        Me.BarradeMenus.Text = "MenuStrip1"
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Checked = True
        Me.mnuOpciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itOpcionesColor, Me.itOpcionesSalir})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpciones.Size = New System.Drawing.Size(69, 20)
        Me.mnuOpciones.Text = "&Opciones"
        '
        'itOpcionesColor
        '
        Me.itOpcionesColor.Checked = True
        Me.itOpcionesColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.itOpcionesColor.Name = "itOpcionesColor"
        Me.itOpcionesColor.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.itOpcionesColor.Size = New System.Drawing.Size(223, 22)
        Me.itOpcionesColor.Text = "&Color Caja de Texto.."
        '
        'itOpcionesSalir
        '
        Me.itOpcionesSalir.Checked = True
        Me.itOpcionesSalir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.itOpcionesSalir.Name = "itOpcionesSalir"
        Me.itOpcionesSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.itOpcionesSalir.Size = New System.Drawing.Size(223, 22)
        Me.itOpcionesSalir.Text = "-&Salir"
        '
        'mnuAyuda
        '
        Me.mnuAyuda.Checked = True
        Me.mnuAyuda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itAyudaAcercaDe})
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuAyuda.Size = New System.Drawing.Size(53, 20)
        Me.mnuAyuda.Text = "Ay&uda"
        '
        'itAyudaAcercaDe
        '
        Me.itAyudaAcercaDe.Checked = True
        Me.itAyudaAcercaDe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.itAyudaAcercaDe.Name = "itAyudaAcercaDe"
        Me.itAyudaAcercaDe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.itAyudaAcercaDe.Size = New System.Drawing.Size(177, 22)
        Me.itAyudaAcercaDe.Text = "&Acerca de..."
        '
        'dlgColor
        '
        Me.dlgColor.AllowFullOpen = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 262)
        Me.Controls.Add(Me.btAñadir)
        Me.Controls.Add(Me.ctDato)
        Me.Controls.Add(Me.IsLista)
        Me.Controls.Add(Me.bdhColortexto)
        Me.Controls.Add(Me.boescritura)
        Me.Controls.Add(Me.bolectura)
        Me.Controls.Add(Me.cvCursiva)
        Me.Controls.Add(Me.BarradeMenus)
        Me.MainMenuStrip = Me.BarradeMenus
        Me.Name = "Form1"
        Me.Text = "Controles"
        Me.BarradeMenus.ResumeLayout(False)
        Me.BarradeMenus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cvCursiva As CheckBox
    Friend WithEvents bolectura As RadioButton
    Friend WithEvents boescritura As RadioButton
    Friend WithEvents bdhColortexto As HScrollBar
    Friend WithEvents IsLista As ListBox
    Friend WithEvents ctDato As TextBox
    Friend WithEvents btAñadir As Button
    Friend WithEvents BarradeMenus As MenuStrip
    Friend WithEvents mnuOpciones As ToolStripMenuItem
    Friend WithEvents itOpcionesColor As ToolStripMenuItem
    Friend WithEvents itOpcionesSalir As ToolStripMenuItem
    Friend WithEvents mnuAyuda As ToolStripMenuItem
    Friend WithEvents itAyudaAcercaDe As ToolStripMenuItem
    Friend WithEvents dlgColor As ColorDialog
End Class
