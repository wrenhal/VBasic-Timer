<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrClocks = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.btnBreak = New System.Windows.Forms.Button()
        Me.btnLunch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.txtDataDir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tmrClocks
        '
        Me.tmrClocks.Enabled = True
        Me.tmrClocks.Interval = 1000
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Black
        Me.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClock.Cursor = System.Windows.Forms.Cursors.No
        Me.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClock.Font = New System.Drawing.Font("alarm clock", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblClock.Location = New System.Drawing.Point(253, 13)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(418, 69)
        Me.lblClock.TabIndex = 0
        Me.lblClock.Text = "12:00:00 AM"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Black
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimer.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTimer.Font = New System.Drawing.Font("alarm clock", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTimer.Location = New System.Drawing.Point(370, 163)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(301, 69)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.Text = "00:00:00"
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.BackColor = System.Drawing.Color.Black
        Me.lblIdentity.Cursor = System.Windows.Forms.Cursors.No
        Me.lblIdentity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIdentity.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentity.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblIdentity.Location = New System.Drawing.Point(246, 163)
        Me.lblIdentity.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(105, 37)
        Me.lblIdentity.TabIndex = 5
        Me.lblIdentity.Text = "Timer"
        '
        'btnBreak
        '
        Me.btnBreak.Location = New System.Drawing.Point(14, 229)
        Me.btnBreak.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnBreak.Name = "btnBreak"
        Me.btnBreak.Size = New System.Drawing.Size(162, 48)
        Me.btnBreak.TabIndex = 0
        Me.btnBreak.Text = "Start Break"
        Me.btnBreak.UseVisualStyleBackColor = True
        '
        'btnLunch
        '
        Me.btnLunch.Location = New System.Drawing.Point(14, 295)
        Me.btnLunch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnLunch.Name = "btnLunch"
        Me.btnLunch.Size = New System.Drawing.Size(162, 48)
        Me.btnLunch.TabIndex = 1
        Me.btnLunch.Text = "Start Lunch"
        Me.btnLunch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(14, 13)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 48)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(14, 79)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(162, 48)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(14, 163)
        Me.btnCall.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(162, 48)
        Me.btnCall.TabIndex = 7
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'txtDataDir
        '
        Me.txtDataDir.Location = New System.Drawing.Point(253, 295)
        Me.txtDataDir.Name = "txtDataDir"
        Me.txtDataDir.ReadOnly = True
        Me.txtDataDir.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDataDir.Size = New System.Drawing.Size(418, 22)
        Me.txtDataDir.TabIndex = 8
        Me.txtDataDir.WordWrap = False
        '
        'frmClocks
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(719, 365)
        Me.Controls.Add(Me.txtDataDir)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.btnLunch)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBreak)
        Me.Controls.Add(Me.lblClock)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "frmClocks"
        Me.ShowIcon = False
        Me.Text = "Clocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrClocks As Timer
    Friend WithEvents lblClock As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblIdentity As Label
    Friend WithEvents btnBreak As Button
    Friend WithEvents btnLunch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnCall As Button
    Friend WithEvents txtDataDir As TextBox
End Class
