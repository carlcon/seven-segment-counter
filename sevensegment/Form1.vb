Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        While True
            '0
            Button3.BackColor = Color.Snow
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Await Task.Delay(1000)

            '1
            Button1.BackColor = Color.Snow
            Button5.BackColor = Color.Snow
            Button4.BackColor = Color.Snow
            Button7.BackColor = Color.Snow
            Await Task.Delay(1000)

            '2
            Button6.BackColor = Color.Snow
            Button1.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Await Task.Delay(1000)

            '3
            Button5.BackColor = Color.Snow
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Await Task.Delay(1000)

            '4
            Button1.BackColor = Color.Snow
            Button4.BackColor = Color.Snow
            Button7.BackColor = Color.Red
            Await Task.Delay(1000)

            '5
            Button2.BackColor = Color.Snow
            Button1.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Await Task.Delay(1000)

            '6
            Button5.BackColor = Color.Red
            Await Task.Delay(1000)


            '7
            Button7.BackColor = Color.Snow
            Button3.BackColor = Color.Snow
            Button5.BackColor = Color.Snow
            Button4.BackColor = Color.Snow
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Await Task.Delay(1000)

            '8
            Button7.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Await Task.Delay(1000)

            '9
            Button5.BackColor = Color.Snow
            Await Task.Delay(1000)
        End While
    End Sub
End Class
