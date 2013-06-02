<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VolForm))
        Me.vol = New System.Windows.Forms.TrackBar()
        Me.volval = New System.Windows.Forms.Label()
        Me.btnvolclose = New System.Windows.Forms.Button()
        CType(Me.vol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vol
        '
        Me.vol.Location = New System.Drawing.Point(12, 12)
        Me.vol.Maximum = 50
        Me.vol.Name = "vol"
        Me.vol.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.vol.Size = New System.Drawing.Size(45, 237)
        Me.vol.SmallChange = 5
        Me.vol.TabIndex = 0
        Me.vol.Value = 10
        '
        'volval
        '
        Me.volval.AutoSize = True
        Me.volval.Location = New System.Drawing.Point(46, 224)
        Me.volval.Margin = New System.Windows.Forms.Padding(5)
        Me.volval.Name = "volval"
        Me.volval.Padding = New System.Windows.Forms.Padding(5)
        Me.volval.Size = New System.Drawing.Size(64, 23)
        Me.volval.TabIndex = 1
        Me.volval.Text = "Vol = 10%"
        '
        'btnvolclose
        '
        Me.btnvolclose.Location = New System.Drawing.Point(49, 13)
        Me.btnvolclose.Name = "btnvolclose"
        Me.btnvolclose.Size = New System.Drawing.Size(63, 23)
        Me.btnvolclose.TabIndex = 2
        Me.btnvolclose.Text = "ปิด"
        Me.btnvolclose.UseVisualStyleBackColor = True
        '
        'VolForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(124, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnvolclose)
        Me.Controls.Add(Me.volval)
        Me.Controls.Add(Me.vol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(140, 300)
        Me.MinimumSize = New System.Drawing.Size(140, 300)
        Me.Name = "VolForm"
        Me.Text = "Volume Control"
        CType(Me.vol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vol As System.Windows.Forms.TrackBar
    Friend WithEvents volval As System.Windows.Forms.Label
    Friend WithEvents btnvolclose As System.Windows.Forms.Button
End Class
