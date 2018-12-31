Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox6.Text = "goat" Then PictureBox1.Visible = True
        If TextBox6.Text = "no goat" Then PictureBox1.Visible = False

        If TextBox6.Text = "" Then
            Dim msg = "No driver."
            Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or
                MsgBoxStyle.Critical

            Dim title = "No driver."
            Dim response = MsgBox(msg, style, title)
            GoTo nopes
        End If
        Dim item As New ListViewItem(TextBox6.Text)

        If TextBox3.Text = "" Then
            Dim msg = "No customer/stop."
            Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or
                MsgBoxStyle.Critical

            Dim title = "No customer/stop."
            Dim response = MsgBox(msg, style, title)
            GoTo nopes
        End If

        If TextBox4.Text = "" Then
            Dim msg = "No invoice number. Use 0 if not a customer stop."
            Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or
                MsgBoxStyle.Critical

            Dim title = "No invoice number."
            Dim response = MsgBox(msg, style, title)
            GoTo nopes
        End If

        If TextBox5.Text = "" Then
            Dim msg = "No ETA."
            Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or
                MsgBoxStyle.Critical

            Dim title = "No estimated time of return."
            Dim response = MsgBox(msg, style, title)
            GoTo nopes
        End If

        item.SubItems.Add(TextBox3.Text)
        item.SubItems.Add(TextBox4.Text)
        item.SubItems.Add(System.DateTime.Now.ToString("hh:mm"))
        item.SubItems.Add(TextBox5.Text)

        Me.ListView1.Items.Add(item)

        TextBox6.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
nopes:
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label6.Text = Date.Now


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Let's go ahead and push the delivery information to the report file

        ' Dim DelItems As String
        Dim DelDriver As String
        Dim DelEndTime As String
        Dim DelCust As String
        Dim DelInv As String
        Dim DelLeft As String
        Dim DelETR As String

        '  Do Until ListView1.CheckedIndices.Count = 0


        If (ListView1.SelectedItems.Count > 0) Then





            '  Do Until ListView1.CheckedIndices.Count = 0

            ' For Each checkedLVI As ListViewItem In ListView1.SelectedItems
            DelDriver = ListView1.SelectedItems(0).SubItems(0).Text.ToString()
                DelCust = ListView1.SelectedItems(0).SubItems(1).Text.ToString()
                DelInv = ListView1.SelectedItems(0).SubItems(2).Text.ToString()
                DelLeft = ListView1.SelectedItems(0).SubItems(3).Text.ToString()
                DelETR = ListView1.SelectedItems(0).SubItems(4).Text.ToString()

                Dim item As New ListViewItem(DelDriver)
                item.SubItems.Add(DelCust)
                item.SubItems.Add(DelInv)
                item.SubItems.Add(DelLeft)
                item.SubItems.Add(System.DateTime.Now.ToString("hh:mm"))

                Me.ListView2.Items.Add(item) ' Add delivery to completed delivery listview
                Me.ListView1.SelectedItems(0).Remove() ' Remove selected delivery from current deliveries

                '     Next
                ' Loop
                Else
                Dim msg = "No delivery selected."
                Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or
                MsgBoxStyle.Critical

                Dim title = "Selection error."
                Dim response = MsgBox(msg, style, title)

            ' Take some action based on the response.





        End If







Nopes:

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Label6.Text = Date.Now
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim msg = "Confirm EXIT?"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
        MsgBoxStyle.Critical

        Dim title = "EXIT prompt"
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response.
        If response = MsgBoxResult.Yes Then
            Me.Close()
        Else

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim msg = "Clear all old deliveries?"
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical

        Dim title = "Clear reports?"
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response.
        If response = MsgBoxResult.Yes Then
            ListView2.Items.Clear()
        Else

        End If

    End Sub



    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick


    End Sub
End Class
