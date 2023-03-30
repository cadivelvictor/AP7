<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentification
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_auth = New System.Windows.Forms.TextBox()
        Me.lbl_auth = New System.Windows.Forms.Label()
        Me.btn_auth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_auth
        '
        Me.tb_auth.Location = New System.Drawing.Point(57, 114)
        Me.tb_auth.Name = "tb_auth"
        Me.tb_auth.Size = New System.Drawing.Size(149, 20)
        Me.tb_auth.TabIndex = 0
        Me.tb_auth.Text = "Entrer le code d'accès unique"
        '
        'lbl_auth
        '
        Me.lbl_auth.AutoSize = True
        Me.lbl_auth.Location = New System.Drawing.Point(75, 84)
        Me.lbl_auth.Name = "lbl_auth"
        Me.lbl_auth.Size = New System.Drawing.Size(111, 13)
        Me.lbl_auth.TabIndex = 1
        Me.lbl_auth.Text = "AUTHENTIFICATION"
        '
        'btn_auth
        '
        Me.btn_auth.Location = New System.Drawing.Point(92, 155)
        Me.btn_auth.Name = "btn_auth"
        Me.btn_auth.Size = New System.Drawing.Size(75, 23)
        Me.btn_auth.TabIndex = 2
        Me.btn_auth.Text = "Connexion"
        Me.btn_auth.UseVisualStyleBackColor = True
        '
        'Authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 326)
        Me.Controls.Add(Me.btn_auth)
        Me.Controls.Add(Me.lbl_auth)
        Me.Controls.Add(Me.tb_auth)
        Me.Name = "Authentification"
        Me.Text = "Authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_auth As System.Windows.Forms.TextBox
    Friend WithEvents lbl_auth As System.Windows.Forms.Label
    Friend WithEvents btn_auth As System.Windows.Forms.Button
End Class
