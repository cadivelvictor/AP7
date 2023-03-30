<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gsb_admin
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
        Me.cb_box_utilisateur = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_create_user = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbl_lst_utilisateur = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.lbl_create_user = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lbl_reinitialise = New System.Windows.Forms.Label()
        Me.lbl_login_reinitialise = New System.Windows.Forms.Label()
        Me.lbl_mdp_reinittialise = New System.Windows.Forms.Label()
        Me.radio_btn_comptable = New System.Windows.Forms.RadioButton()
        Me.radio_btn_visiteur = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cb_box_utilisateur
        '
        Me.cb_box_utilisateur.FormattingEnabled = True
        Me.cb_box_utilisateur.Location = New System.Drawing.Point(514, 418)
        Me.cb_box_utilisateur.Name = "cb_box_utilisateur"
        Me.cb_box_utilisateur.Size = New System.Drawing.Size(209, 21)
        Me.cb_box_utilisateur.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 394)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btn_create_user
        '
        Me.btn_create_user.Location = New System.Drawing.Point(250, 488)
        Me.btn_create_user.Name = "btn_create_user"
        Me.btn_create_user.Size = New System.Drawing.Size(75, 23)
        Me.btn_create_user.TabIndex = 2
        Me.btn_create_user.Text = "Éxécuter"
        Me.btn_create_user.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(898, 440)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(198, 444)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(181, 20)
        Me.TextBox3.TabIndex = 4
        '
        'lbl_lst_utilisateur
        '
        Me.lbl_lst_utilisateur.AutoSize = True
        Me.lbl_lst_utilisateur.Location = New System.Drawing.Point(570, 358)
        Me.lbl_lst_utilisateur.Name = "lbl_lst_utilisateur"
        Me.lbl_lst_utilisateur.Size = New System.Drawing.Size(112, 13)
        Me.lbl_lst_utilisateur.TabIndex = 5
        Me.lbl_lst_utilisateur.Text = "Listes des utilisateurs :"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(153, 396)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(39, 13)
        Me.lbl_login.TabIndex = 6
        Me.lbl_login.Text = "Login :"
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.Location = New System.Drawing.Point(115, 447)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(77, 13)
        Me.lbl_mdp.TabIndex = 7
        Me.lbl_mdp.Text = "Mot de passe :"
        '
        'lbl_create_user
        '
        Me.lbl_create_user.AutoSize = True
        Me.lbl_create_user.Location = New System.Drawing.Point(217, 358)
        Me.lbl_create_user.Name = "lbl_create_user"
        Me.lbl_create_user.Size = New System.Drawing.Size(146, 13)
        Me.lbl_create_user.TabIndex = 8
        Me.lbl_create_user.Text = "CRÉATION D'UTILISATEUR"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(898, 394)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(181, 20)
        Me.TextBox4.TabIndex = 9
        '
        'lbl_reinitialise
        '
        Me.lbl_reinitialise.AutoSize = True
        Me.lbl_reinitialise.Location = New System.Drawing.Point(886, 358)
        Me.lbl_reinitialise.Name = "lbl_reinitialise"
        Me.lbl_reinitialise.Size = New System.Drawing.Size(203, 13)
        Me.lbl_reinitialise.TabIndex = 10
        Me.lbl_reinitialise.Text = "RÉINITIALISATION DE MOT DE PASSE"
        '
        'lbl_login_reinitialise
        '
        Me.lbl_login_reinitialise.AutoSize = True
        Me.lbl_login_reinitialise.Location = New System.Drawing.Point(853, 396)
        Me.lbl_login_reinitialise.Name = "lbl_login_reinitialise"
        Me.lbl_login_reinitialise.Size = New System.Drawing.Size(39, 13)
        Me.lbl_login_reinitialise.TabIndex = 11
        Me.lbl_login_reinitialise.Text = "Login :"
        '
        'lbl_mdp_reinittialise
        '
        Me.lbl_mdp_reinittialise.AutoSize = True
        Me.lbl_mdp_reinittialise.Location = New System.Drawing.Point(815, 444)
        Me.lbl_mdp_reinittialise.Name = "lbl_mdp_reinittialise"
        Me.lbl_mdp_reinittialise.Size = New System.Drawing.Size(77, 13)
        Me.lbl_mdp_reinittialise.TabIndex = 12
        Me.lbl_mdp_reinittialise.Text = "Mot de passe :"
        '
        'radio_btn_comptable
        '
        Me.radio_btn_comptable.AutoSize = True
        Me.radio_btn_comptable.Location = New System.Drawing.Point(514, 394)
        Me.radio_btn_comptable.Name = "radio_btn_comptable"
        Me.radio_btn_comptable.Size = New System.Drawing.Size(75, 17)
        Me.radio_btn_comptable.TabIndex = 13
        Me.radio_btn_comptable.TabStop = True
        Me.radio_btn_comptable.Text = "Comptable"
        Me.radio_btn_comptable.UseVisualStyleBackColor = True
        '
        'radio_btn_visiteur
        '
        Me.radio_btn_visiteur.AutoSize = True
        Me.radio_btn_visiteur.Location = New System.Drawing.Point(623, 394)
        Me.radio_btn_visiteur.Name = "radio_btn_visiteur"
        Me.radio_btn_visiteur.Size = New System.Drawing.Size(59, 17)
        Me.radio_btn_visiteur.TabIndex = 14
        Me.radio_btn_visiteur.TabStop = True
        Me.radio_btn_visiteur.Text = "Visiteur"
        Me.radio_btn_visiteur.UseVisualStyleBackColor = True
        '
        'frm_gsb_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 803)
        Me.Controls.Add(Me.radio_btn_visiteur)
        Me.Controls.Add(Me.radio_btn_comptable)
        Me.Controls.Add(Me.lbl_mdp_reinittialise)
        Me.Controls.Add(Me.lbl_login_reinitialise)
        Me.Controls.Add(Me.lbl_reinitialise)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lbl_create_user)
        Me.Controls.Add(Me.lbl_mdp)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_lst_utilisateur)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btn_create_user)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cb_box_utilisateur)
        Me.Name = "frm_gsb_admin"
        Me.Text = "GSB-ADMIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_box_utilisateur As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_create_user As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_lst_utilisateur As System.Windows.Forms.Label
    Friend WithEvents lbl_login As System.Windows.Forms.Label
    Friend WithEvents lbl_mdp As System.Windows.Forms.Label
    Friend WithEvents lbl_create_user As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_reinitialise As System.Windows.Forms.Label
    Friend WithEvents lbl_login_reinitialise As System.Windows.Forms.Label
    Friend WithEvents lbl_mdp_reinittialise As System.Windows.Forms.Label
    Friend WithEvents radio_btn_comptable As System.Windows.Forms.RadioButton
    Friend WithEvents radio_btn_visiteur As System.Windows.Forms.RadioButton

End Class
