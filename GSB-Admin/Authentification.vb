Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Authentification

    <DllImport("kernel32.dll", EntryPoint:="GetPrivateProfileStringA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Private Shared Function GetPrivateProfileString(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    End Function

    Public Function GetIniValue(ByVal section As String, ByVal key As String, ByVal path As String) As String
        Dim sb As New StringBuilder(255)
        Dim i = GetPrivateProfileString(section, key, "", sb, 255, path)
        Return sb.ToString()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_auth.Click

        Dim password As String

        Dim Liste() As String
        Liste = System.IO.File.ReadAllLines("C:\wamp64\www\TESTAP7\include\conf.ini")
        For Each Ligne In Liste
            If Ligne.Contains("=") Then
                Ligne = Ligne.Replace(" ", "")
                Dim Texte As String = Split(Ligne, "=")(0)
                Dim Valeur As String = Split(Ligne, "=")(1)

                If Texte = "auth_app" Then
                    password = Valeur
                End If

                'MessageBox.Show("Le texte : " & Texte & Environment.NewLine & "Le chiffre : " & Valeur)
            End If
        Next


        'Vérifier les informations de connexion ici (par exemple en comparant avec une base de données)
        If tb_auth.Text = password Then

            'Ouvrir le formulaire principal de l'application

            frm_gsb_admin.Show()

            'Fermer le formulaire d'authentification

            Me.Hide()

        Else
            'Afficher un message d'erreur et demander à l'utilisateur de saisir à nouveau ses informations de connexion
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect. Veuillez réessayer.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tb_auth.Text = ""
        End If

    End Sub
End Class