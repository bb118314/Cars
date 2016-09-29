Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCount As Integer
        Dim rand As New Random            'Dimming like a god
        Const dblFinish As Double = 501


        picPur.Left = rand.Next(625) + 15   '0XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX0
        picPin.Left = rand.Next(625) + 15   '0 Sets the cars to a random integer between 0 and 625. 0
        picRed.Left = rand.Next(625) + 15   '0XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX0
        picGre.Left = rand.Next(625) + 15
        picBro.Left = rand.Next(625) + 15


        If picPur.Left >= dblFinish Then
            MessageBox.Show("Purple is victorious!")
        ElseIf picBro.Left >= dblFinish Then
            MessageBox.Show("Brown takes the crown!")   'zZZZZZZZZZZZZZZZz
        ElseIf picPin.Left >= dblFinish Then            'z Shows who won z
            MessageBox.Show("Pink wins the race!")      'zZZZZZZZZZZZZZZZz
        ElseIf picRed.Left >= dblFinish Then
            MessageBox.Show("Red races ahead!")
        ElseIf picGre.Left >= dblFinish Then
            MessageBox.Show("Green finishes grand!")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit() 'This doesn't need an explaination
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        picBro.Left = 20
        picRed.Left = 20
        picGre.Left = 20
        picPin.Left = 20
        picPur.Left = 20


    End Sub
End Class
