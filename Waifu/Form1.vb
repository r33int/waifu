Public Class Form1
    Dim WaifuSet As Boolean
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = ("") Then
            Button1.Enabled = (False)
            Button1.Text = ("You have no waifu :(")
        Else
            Button1.Enabled = (True)
            Button1.Text = (("Make ") & (TextBox1.Text) & (" your waifu!"))
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WaifuSet = True Then
            Button1.Enabled = (False)
            MsgBox((TextBox1.Text) & (" is not your waifu anymore :("))
            Button1.Text = ("You have no waifu :(")
            Label2.Visible = False
            TextBox1.Enabled = True
            TextBox1.Text = ("")
            WaifuSet = False
        Else
            Label2.Visible = True
            Button1.Text = ("Unwaifu")
            TextBox1.Enabled = False
            Label2.Text = ((TextBox1.Text) & (" is your waifu! <3"))
            WaifuSet = True
        End If
    End Sub
End Class