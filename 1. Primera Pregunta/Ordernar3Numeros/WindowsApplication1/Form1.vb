Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        Dim print As String
        If a > b Then
            If a > c Then
                If b > c Then
                    print = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text
                    GoTo Final
                Else
                    print = TextBox1.Text + " " + TextBox3.Text + " " + TextBox2.Text
                    GoTo Final
                End If
            Else
                If c > b Then
                    print = TextBox3.Text + " " + TextBox1.Text + " " + TextBox2.Text
                    GoTo Final
                Else
                    print = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text
                    GoTo Final
                End If
            End If
        Else
            If b > c Then
                If c > a Then
                    print = TextBox2.Text + " " + TextBox3.Text + " " + TextBox1.Text
                    GoTo Final
                Else
                    print = TextBox2.Text + " " + TextBox1.Text + " " + TextBox3.Text
                    GoTo Final
                End If
            Else
                print = TextBox3.Text + " " + TextBox2.Text + " " + TextBox1.Text
                GoTo Final
            End If
        End If
Final:
        Label2.Text = print
    End Sub
End Class
