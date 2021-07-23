Public Class frmproducttype
    Dim idselected As String
    Dim list1 As New List(Of ProductType)
    Private Sub frmproducttype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_types()
        btnupdate.Enabled = False
        btndelete.Enabled = False

    End Sub
    Private Sub load_types()
        Try

            Dim typeobj As New ProductType
            list1 = typeobj.get_category
            If list1 IsNot Nothing Then
                lvtypes.Enabled = True
                lvtypes.Items.Clear()
                Dim x As Integer
                Dim typeitems As ListViewItem
                For x = 0 To list1.Count - 1
                    typeitems = lvtypes.Items.Add(list1(x).getid)
                    typeitems.SubItems.Add(list1(x).getname)
                Next
                btnsave.Enabled = True
                btndelete.Enabled = False
                btnupdate.Enabled = False
                txtname.Clear()
                txtname.Focus()
            Else
                lvtypes.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Load types:" + ex.Message)
        End Try
    End Sub

    Private Sub lvtypes_Click(sender As Object, e As EventArgs) Handles lvtypes.Click
        If lvtypes.Items.Count <> 0 Then
            idselected = lvtypes.SelectedItems(0).Text
            txtname.Text = lvtypes.SelectedItems(0).SubItems(1).Text
            btnupdate.Enabled = True
            btndelete.Enabled = True
            btnsave.Enabled = False
        End If
    End Sub
    Private Function validate_name()
        Dim err As Boolean = False
        Try
            Dim x As Integer
            For x = 0 To list1.Count - 1
                If txtname.Text = list1(x).getname And idselected <> list1(x).getid And list1(x).getstatus = "available" Then
                    err = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Validate name:" + ex.Message)
        End Try
        Return err
    End Function
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If validate_name() = False Then
                Dim typeobj As New ProductType
                typeobj.setid(idselected)
                typeobj.setname(txtname.Text)
                typeobj.setstatus("available")
                If typeobj.update_type Then
                    MsgBox("Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    load_types()
                Else
                    MsgBox("Error updating product type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MsgBox("This type name is already taken", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Update type:" + ex.Message)
        End Try

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim x As Integer = MsgBox("Delete this item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = vbYes Then
                Dim typeobj As New ProductType
                typeobj.setid(idselected)
                typeobj.setname(txtname.Text)
                typeobj.setstatus("deleted")
                If typeobj.update_type Then
                    MsgBox("Item deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    load_types()
                Else
                    MsgBox("Error deleting item", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MsgBox("Delete type:" + ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim typeobj As New ProductType

            typeobj.setname(txtname.Text)
            typeobj.setstatus("available")
            typeobj.save_type()
            MsgBox("Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_types()
        Catch ex As Exception
            MsgBox("Save type:" + ex.Message)
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class