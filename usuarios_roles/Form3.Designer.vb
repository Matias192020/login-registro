<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnactivar = New System.Windows.Forms.Button()
        Me.btncambiarclave = New System.Windows.Forms.Button()
        Me.txtcontnueva = New System.Windows.Forms.TextBox()
        Me.txtcontactual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtactivo = New System.Windows.Forms.TextBox()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndesactivar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(135, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(371, 209)
        Me.DataGridView1.TabIndex = 0
        '
        'btnactivar
        '
        Me.btnactivar.Location = New System.Drawing.Point(18, 151)
        Me.btnactivar.Name = "btnactivar"
        Me.btnactivar.Size = New System.Drawing.Size(82, 34)
        Me.btnactivar.TabIndex = 2
        Me.btnactivar.Text = "ACTIVAR"
        Me.btnactivar.UseVisualStyleBackColor = True
        '
        'btncambiarclave
        '
        Me.btncambiarclave.Location = New System.Drawing.Point(78, 160)
        Me.btncambiarclave.Name = "btncambiarclave"
        Me.btncambiarclave.Size = New System.Drawing.Size(103, 34)
        Me.btncambiarclave.TabIndex = 3
        Me.btncambiarclave.Text = "CAMBIAR CLAVE"
        Me.btncambiarclave.UseVisualStyleBackColor = True
        '
        'txtcontnueva
        '
        Me.txtcontnueva.Location = New System.Drawing.Point(118, 93)
        Me.txtcontnueva.Name = "txtcontnueva"
        Me.txtcontnueva.Size = New System.Drawing.Size(100, 20)
        Me.txtcontnueva.TabIndex = 4
        '
        'txtcontactual
        '
        Me.txtcontactual.Location = New System.Drawing.Point(118, 52)
        Me.txtcontactual.Name = "txtcontactual"
        Me.txtcontactual.ReadOnly = True
        Me.txtcontactual.Size = New System.Drawing.Size(100, 20)
        Me.txtcontactual.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "contraseña actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "contraseña nueva"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(54, 22)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(42, 13)
        Me.ID.TabIndex = 8
        Me.ID.Text = "nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(118, 19)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtactivo
        '
        Me.txtactivo.Location = New System.Drawing.Point(70, 87)
        Me.txtactivo.Name = "txtactivo"
        Me.txtactivo.Size = New System.Drawing.Size(100, 20)
        Me.txtactivo.TabIndex = 11
        '
        'txtidusuario
        '
        Me.txtidusuario.Location = New System.Drawing.Point(70, 32)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtidusuario.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "idusuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "activo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncambiarclave)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.txtcontactual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcontnueva)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 222)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambiar Clave"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndesactivar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtidusuario)
        Me.GroupBox2.Controls.Add(Me.txtactivo)
        Me.GroupBox2.Controls.Add(Me.btnactivar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 213)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activar Usuario"
        '
        'btndesactivar
        '
        Me.btndesactivar.Location = New System.Drawing.Point(111, 151)
        Me.btndesactivar.Name = "btndesactivar"
        Me.btndesactivar.Size = New System.Drawing.Size(86, 34)
        Me.btndesactivar.TabIndex = 15
        Me.btndesactivar.Text = "DESACTIVAR"
        Me.btndesactivar.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 489)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmmain"
        Me.Text = "MENU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnactivar As Button
    Friend WithEvents btncambiarclave As Button
    Friend WithEvents txtcontnueva As TextBox
    Friend WithEvents txtcontactual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtactivo As TextBox
    Friend WithEvents txtidusuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btndesactivar As Button
End Class
