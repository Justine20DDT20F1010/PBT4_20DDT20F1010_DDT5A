' Name : Justine Nanggai
'Class: DDT5A
' PBT : 4
'No Matrik : 20DDT20F1010


Imports System.Data.SqlClient
Public Class Form1
    'SQL connection put a server, name database, and password
    Dim con As New SqlConnection("server=DESKTOP-D46HQFR;database=SystemOrdering;user=sa;password=P@ssw0rd")
    Dim OrderDetail As New DataTable
    Dim currentIndex As Integer

    Sub Refresh_Form()
        currentIndex = 0
        Tb_ID.ResetText()
        Tb_Name.ResetText()
        Tb_Address.ResetText()
        Tb_Menu.ResetText()
        OrderDetail.Reset()
        Dim searchquery As String = "select * from OrderDetail"
        Dim cmd As New SqlCommand(searchquery, con)
        Dim ta As New SqlDataAdapter(cmd)
        ta.Fill(OrderDetail)


        Btn_Previous.Enabled = False
    End Sub

    Private Sub Btn_First_Click(sender As Object, e As EventArgs) Handles Btn_First.Click
        'user can view the first record 
        Btn_Previous.Enabled = False
        Tb_ID.Text = OrderDetail.Rows(0)(0)
        Tb_Name.Text = OrderDetail.Rows(0)(1)
        Tb_Address.Text = OrderDetail.Rows(0)(2)
        Tb_Menu.Text = OrderDetail.Rows(0)(3)
        currentIndex = 0
    End Sub

    Private Sub Btn_Last_Click(sender As Object, e As EventArgs) Handles Btn_Last.Click
        'user can view the last record 
        Dim lastIndex As Integer = OrderDetail.Rows.Count - 1
        Btn_Previous.Enabled = True
        Tb_ID.Text = OrderDetail.Rows(lastIndex)(0)
        Tb_Name.Text = OrderDetail.Rows(lastIndex)(1)
        Tb_Address.Text = OrderDetail.Rows(lastIndex)(2)
        Tb_Menu.Text = OrderDetail.Rows(lastIndex)(3)

        currentIndex = lastIndex
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim exist As Boolean = False
        Dim i As Integer = 0

        While i < OrderDetail.Rows.Count
            If OrderDetail.Rows(i)(0) = Tb_ID.Text Then
                exist = True
                Exit While
            End If
            i += 1
        End While

        If (exist = True) Then
            'use command delete
            Dim deletequery As String = "delete from OrderDetail where Order_ID= '" & Tb_ID.Text & "'"
            Dim cmd As New SqlCommand(deletequery, con)
            'connection open
            con.Open()
            cmd.ExecuteNonQuery()
            'connection close
            con.Close()
            Refresh_Form()
            'messagges box appear
            MsgBox("Record deleted successfully!")
        Else
            MsgBox("This Order ID does not exist!")
        End If
        Me.OrderDetailTableAdapter.Fill(Me.SystemOrderingDataSet1.OrderDetail)
        Dim bs As New BindingSource
        bs.DataSource = SystemOrderingDataSet1.Tables(0).DefaultView
        DataGridView1.DataSource = bs
    End Sub

    Private Sub Btn_Previous_Click(sender As Object, e As EventArgs) Handles Btn_Previous.Click
        ' user can view the previous record
        Btn_Next.Enabled = True
        currentIndex -= 1
        Tb_ID.Text = OrderDetail.Rows(currentIndex)(0)
        Tb_Name.Text = OrderDetail.Rows(currentIndex)(1)
        Tb_Address.Text = OrderDetail.Rows(currentIndex)(2)
        Tb_Menu.Text = OrderDetail.Rows(currentIndex)(3)

        If (currentIndex = 0) Then
            Btn_Previous.Enabled = False
        End If
    End Sub

    Private Sub Btn_Next_Click_1(sender As Object, e As EventArgs) Handles Btn_Next.Click
        ' user can view all the record ONE BY ONE
        Btn_Previous.Enabled = True
        currentIndex += 1
        Tb_ID.Text = OrderDetail.Rows(currentIndex)(0)
        Tb_Name.Text = OrderDetail.Rows(currentIndex)(1)
        Tb_Address.Text = OrderDetail.Rows(currentIndex)(2)
        Tb_Menu.Text = OrderDetail.Rows(currentIndex)(3)

        If (currentIndex = OrderDetail.Rows.Count - 1) Then
            Btn_Next.Enabled = False
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Dim duplicate As Boolean = False
        Dim i As Integer = 0
        ' if the textbox not complete 
        If (Tb_ID.Text = "" Or Tb_Name.Text = "" Or Tb_Address.Text = "" Or Tb_Menu.Text = "") Then
            'this messagges box will appear
            MsgBox("No data inserted!")

        Else
            While i < OrderDetail.Rows.Count
                If OrderDetail.Rows(i)(0) = Tb_ID.Text Then
                    duplicate = True
                    Exit While
                End If
                i += 1
            End While

            If (duplicate = True) Then
                'but if u want insert but have same id number the messagess will appear
                MsgBox("This Order ID already exist!")
            Else
                ' use insertquery command
                Dim insertquery As String = "insert into OrderDetail(Order_ID, Name, Address, Menu) values('" & Tb_ID.Text & "',
'" & Tb_Name.Text & "','" & Tb_Address.Text & "','" & Tb_Menu.Text & "')"
                Dim cmd As New SqlCommand(insertquery, con)
                'connection open
                con.Open()
                cmd.ExecuteNonQuery()
                'connection close
                con.Close()
                Refresh_Form()
                'messaggesbox
                MsgBox("New record added successfully!")
            End If
        End If
        Me.OrderDetailTableAdapter.Fill(Me.SystemOrderingDataSet1.OrderDetail)
        Dim bs As New BindingSource
        bs.DataSource = SystemOrderingDataSet1.Tables(0).DefaultView
        DataGridView1.DataSource = bs


    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Dim exist As Boolean = False
        Dim i As Integer = 0
        'using while loop 
        While i < OrderDetail.Rows.Count
            If OrderDetail.Rows(i)(0) = Tb_ID.Text Then
                exist = True
                Exit While
            End If
            i += 1
        End While

        If (exist = True) Then
            'use update to update the record
            Dim updatequery As String = "update OrderDetail set Name='" & Tb_Name.Text & "', Address='" & Tb_Address.Text &
                "', Menu='" & Tb_Menu.Text & "' where Order_ID='" & Tb_ID.Text & "'"
            Dim cmd As New SqlCommand(updatequery, con)
            'connection open
            con.Open()
            'connection close
            cmd.ExecuteNonQuery()
            con.Close()
            Refresh_Form()
            'messaggesbox
            MsgBox("Record updated successfully!")
        Else
            'if the id not found this messages box will appear in form
            MsgBox("This Order ID does not exist!")
        End If


        Me.OrderDetailTableAdapter.Fill(Me.SystemOrderingDataSet1.OrderDetail)
        Dim bs As New BindingSource
        bs.DataSource = SystemOrderingDataSet1.Tables(0).DefaultView
        DataGridView1.DataSource = bs
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        'exit the form
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemOrderingDataSet1.OrderDetail' table. You can move, or remove it, as needed.
        Me.OrderDetailTableAdapter.Fill(Me.SystemOrderingDataSet1.OrderDetail)
        Refresh_Form()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        ' reset all the textbox
        Tb_ID.ResetText()
        Tb_Name.ResetText()
        Tb_Address.ResetText()
        Tb_Menu.ResetText()
    End Sub
End Class
