<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnuevousuario = New System.Windows.Forms.TextBox()
        Me.txtnuevopass = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USUARIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASS:"
        '
        'txtnuevousuario
        '
        Me.txtnuevousuario.Location = New System.Drawing.Point(135, 76)
        Me.txtnuevousuario.Name = "txtnuevousuario"
        Me.txtnuevousuario.Size = New System.Drawing.Size(100, 20)
        Me.txtnuevousuario.TabIndex = 3
        '
        'txtnuevopass
        '
        Me.txtnuevopass.Location = New System.Drawing.Point(135, 145)
        Me.txtnuevopass.Name = "txtnuevopass"
        Me.txtnuevopass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnuevopass.Size = New System.Drawing.Size(100, 20)
        Me.txtnuevopass.TabIndex = 4
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(144, 203)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 5
        Me.btnaceptar.Text = "ACEPTAR"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'frmregistar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 275)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtnuevopass)
        Me.Controls.Add(Me.txtnuevousuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmregistar"
        Me.Text = "REGISTAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnuevousuario As TextBox
    Friend WithEvents txtnuevopass As TextBox
    Friend WithEvents btnaceptar As Button
End Class
