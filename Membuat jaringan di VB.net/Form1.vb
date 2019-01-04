Public Class MauApaNak
    Private Sub Buat(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            '****************************************************************************************'
            If nama_jaringan.Text = "" And password_jaringan.Text = "" Then
                MsgBox(Label1.Text & " " & Label2.Text & " Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Notice!!")

                '// HAPUS
                nama_jaringan.Clear()
                password_jaringan.Clear()
                nama_jaringan.Focus() '// Focus
            ElseIf nama_jaringan.Text = "" Or password_jaringan.Text = "" Then '// name kosong
                MsgBox(Label1.Text & " Tidak Boleh Kosong!", MsgBoxStyle.Exclamation, "Notice!!")

                '// HAPUS
                nama_jaringan.Clear()
                password_jaringan.Clear()
                nama_jaringan.Focus() '// Focus
            ElseIf password_jaringan.Text.Length < 8 Then '// Karakter kurang dari 8
                MsgBox(Label2.Text & " Maximal 8 karakter!", MsgBoxStyle.Exclamation, "Notice!!")

                '// HAPUS
                nama_jaringan.Clear()
                password_jaringan.Clear()
                nama_jaringan.Focus() '// Focus
            Else
                Shell("netsh wlan set hostednetwork ssid=" & nama_jaringan.Text.Replace(" ", "_"))
                Shell("netsh wlan set hostednetwork key=" & password_jaringan.Text)
                MsgBox("Berhasil Membuat Jaringan", MsgBoxStyle.Information, "Information")

            End If
            '****************************************************************************************'
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub HidupkanJaringanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HidupkanJaringanToolStripMenuItem.Click
        Shell("netsh wlan start hostednetwork")
        MsgBox("Berhasil Menghidupkan Jaringan", MsgBoxStyle.Information, "Sucessfully")
    End Sub

    Private Sub MatikanJaringanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatikanJaringanToolStripMenuItem.Click
        Shell("netsh wlan stop hostednetwork")
        MsgBox("Berhasil Mematikan Jaringan", MsgBoxStyle.Information, "Sucessfully")
    End Sub

    Private Sub Checkbox_Password_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Password.CheckedChanged
        If Checkbox_Password.Checked = True Then
            password_jaringan.UseSystemPasswordChar = False
        Else
            password_jaringan.UseSystemPasswordChar = True
        End If
    End Sub
End Class
