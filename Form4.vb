Public Class VolForm

    Private Sub vol_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vol.Scroll
        volval.Text = "Vol = " & vol.Value & "%"
        Form1.player.settings.volume = vol.Value
    End Sub

    Private Sub btnvolclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolclose.Click
        MyBase.Hide()
    End Sub
End Class