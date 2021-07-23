Imports System.Data.SqlClient
Public Class frmconfirmation
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader

    Dim id, table, column As String
    Public status As Integer


    Private Sub frmconfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status = 0
    End Sub
    'functions and procedures

    'open connection
    Private Sub open_connection()
        Try
            Dim db As Connection
            db = New Connection

            conn = New SqlConnection(db.get_connection)
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("Open Connection:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblusers WHERE username=@user AND userpass=@pass AND userlevel=@level"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", txtusername.Text)
            cmd.Parameters.AddWithValue("@pass", txtpassword.Text)
            cmd.Parameters.AddWithValue("@level", "manager")
            rs = cmd.ExecuteReader

            If (rs.HasRows) Then
                status = 1
                cmd.Dispose()
                conn.Close()
                Me.Close()
            Else
                status = 0
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Confirmation" + ex.Message)
        End Try
    End Sub
End Class