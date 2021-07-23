Public Class frmselectpackage
    Public idselected As Integer
    Public productname As String
    Private Sub frmselectpackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idselected = 0
        productname = ""
        load_package()

    End Sub
    Private Sub load_package()
        Dim list1 As New List(Of ProductPackage)
        Dim productobj As New ProductPackage
        list1 = productobj.load_packages
        If list1 IsNot Nothing Or list1.Count <> 0 Then
            lvpackage.Enabled = True
            lvpackage.Items.Clear()
            Dim packagelist As New ListViewItem
            Dim x As Integer
            For x = 0 To list1.Count - 1
                packagelist = lvpackage.Items.Add(list1(x).getid)
                packagelist.SubItems.Add(list1(x).getname)
                packagelist.SubItems.Add(list1(x).getprice)
                packagelist.SubItems.Add(list1(x).getdescription)
                packagelist.SubItems.Add(list1(x).getqty)
            Next
        Else
            lvpackage.Enabled = False
            MsgBox("There are no packages available in the system")
            idselected = 0
            Me.Close()

        End If
    End Sub

    Private Sub lvpackage_Click(sender As Object, e As EventArgs) Handles lvpackage.Click
        idselected = lvpackage.SelectedItems(0).Text
        productname = lvpackage.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        load_package()
        txtsearch.Clear()
    End Sub

    Private Sub lvpackage_DoubleClick(sender As Object, e As EventArgs) Handles lvpackage.DoubleClick
        idselected = lvpackage.SelectedItems(0).Text
        productname = lvpackage.SelectedItems(0).SubItems(1).Text
        Me.Close()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        Me.Close()

    End Sub
End Class