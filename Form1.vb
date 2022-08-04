Public Class Form1
   Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
      Transformar()
   End Sub

   Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
      SoloNumeros(e.KeyChar, True)
   End Sub

   Private Sub chkMay_CheckedChanged(sender As Object, e As EventArgs) Handles chkMay.CheckedChanged
      Transformar()
   End Sub

   Private Sub Transformar()
      TextBox2.Text = Numero_a_Texto(Val(TextBox1.Text),,, chkMay.Checked)
   End Sub

End Class
