Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario As String = "ADMIN"
        Dim Password As String = "CAPUFE"
        If UsernameTextBox.Text = usuario Then
            If PasswordTextBox.Text = Password Then
                If BanderaCierre = True Then
                    End
                Else
                    MDIInicio.Show()
                    Me.Hide()

                    BanderaCierre = True
                End If

            Else
                MessageBox.Show("Usuario o contraseña incorrectos!")
            End If
        Else
            BanderaCierre = False
            MessageBox.Show("Usuario o contraseña incorrectos!")
        End If


        ' Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        BanderaCierre = False

        Me.Close()
    End Sub
    Private Sub Login_FormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'BanderaCierre = True
        'Dim Login As New Login
        'Login.ShowDialog()
        If BanderaCierre = True Then
            e.Cancel = True
            Dim inicio As New MDIInicio
            inicio.Show()
            Me.Hide()
            BanderaCierre = True
        End If
    End Sub
End Class
