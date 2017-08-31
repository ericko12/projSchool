Public Class frmcodigo

    Dim FontEncoder As New IDAutomation.NetAssembly.FontEncoder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtencodetext.Text = FontEncoder.Code39(txtdatatoencode.Text)
        txtbarcode.Text = txtencodetext.Text
        txtbarcode.Font = New System.Drawing.Font("IDAutomationSHC39M", 18, FontStyle.Regular)
    End Sub
End Class