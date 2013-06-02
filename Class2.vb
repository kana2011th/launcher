Public Class Class2
    Public Shared Sub launch()
        'Declare Processes
        Dim appDataStartInfo As ProcessStartInfo = New ProcessStartInfo()
        Dim javaStartInfo As ProcessStartInfo = New ProcessStartInfo()
        Dim appPath As String = Application.StartupPath()
        'Launch appdata relocation process
        appDataStartInfo.FileName = "cmd.exe"
        appDataStartInfo.Arguments = "/c start cd %appdata%\.mc-re\bin"
        appDataStartInfo.UseShellExecute = True
        Process.Start(appDataStartInfo)
        'Launch Minecraft
        javaStartInfo.FileName = "javaw"
        javaStartInfo.Arguments = "-Xms512M -Xmx1024M -cp minecraft.jar net.minecraft.LauncherFrame"
        javaStartInfo.UseShellExecute = True
        Process.Start(javaStartInfo)
    End Sub
End Class
