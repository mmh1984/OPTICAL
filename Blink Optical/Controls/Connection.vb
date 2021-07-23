Imports System.Data.SqlClient

Public Class Connection
    Dim db As String

    Public Function get_connection() As String

        'db = "Data Source=DESKTOP-NK67OAM\SQLEXPRESS;Initial Catalog=opticaldb;Integrated Security=True"
        db = "Data Source=DESKTOP-5H1D5U0\SQLEXPRESS;Initial Catalog=opticaldb;Integrated Security=True"


        Return db

    End Function
End Class
