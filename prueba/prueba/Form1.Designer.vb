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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
<<<<<<< HEAD
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
=======
        Me.Button2 = New System.Windows.Forms.Button()
>>>>>>> 79c68016ce840e485426f156450a35d57a267495
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOLA MUNDO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(325, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 2
        '
<<<<<<< HEAD
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(618, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "nada"
        Me.CheckBox1.UseVisualStyleBackColor = True
=======
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(567, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "DALE CLICC"
        Me.Button2.UseVisualStyleBackColor = True
>>>>>>> 79c68016ce840e485426f156450a35d57a267495
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
<<<<<<< HEAD
        Me.Controls.Add(Me.CheckBox1)
=======
        Me.Controls.Add(Me.Button2)
>>>>>>> 79c68016ce840e485426f156450a35d57a267495
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
<<<<<<< HEAD
    Friend WithEvents CheckBox1 As CheckBox
=======
    Friend WithEvents Button2 As Button
>>>>>>> 79c68016ce840e485426f156450a35d57a267495
End Class
