Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text


Public Class frm_gsb_admin

    <DllImport("kernel32.dll", EntryPoint:="GetPrivateProfileStringA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Private Shared Function GetPrivateProfileString(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function

    Public Function GetIniValue(ByVal section As String, ByVal key As String, ByVal path As String) As String
        Dim sb As New StringBuilder(255)
        Dim i = GetPrivateProfileString(section, key, "", sb, 255, path)
        Return sb.ToString()
    End Function

    Private Sub frm_gsb_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=" & GetIniValue("database", "server", "C:\wamp64\www\TESTAP7\include\conf.ini") & ";user=" & GetIniValue("database", "user", "C:\wamp64\www\TESTAP7\include\conf.ini") & ";password=" & GetIniValue("database", "password", "C:\wamp64\www\TESTAP7\include\conf.ini") & ";database=" & GetIniValue("database", "database", "C:\wamp64\www\TESTAP7\include\conf.ini") & ";"
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()
            MessageBox.Show("Connecté")

        Catch ex As Exception
            MessageBox.Show("Pas connecté")

        End Try

        ' Exécuter des requêtes SQL sur la base de données MySQL ici
        Dim sql As String = "SELECT nom, prenom FROM visiteur"
        Dim cmd As New MySqlCommand(sql, conn)

        conn.Close()

    End Sub

End Class
