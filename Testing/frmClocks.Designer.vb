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
        Me.tmrBreak = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLunch = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblClocks24 = New System.Windows.Forms.Label()
        Me.lblBreak = New System.Windows.Forms.Label()
        Me.lblBreakLeft = New System.Windows.Forms.Label()
        Me.lblLunch = New System.Windows.Forms.Label()
        Me.lblLunchLeft = New System.Windows.Forms.Label()
        Me.btnBreak = New System.Windows.Forms.Button()
        Me.btnLunch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrClocks
        '
        Me.tmrClocks.Enabled = True
        Me.tmrClocks.Interval = 1000
        '
        'tmrBreak
        '
        Me.tmrBreak.Interval = 1000
        '
        'tmrLunch
        '
        Me.tmrLunch.Interval = 1000
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
        'lblClocks24
        '
        Me.lblClocks24.AutoSize = True
        Me.lblClocks24.BackColor = System.Drawing.Color.Black
        Me.lblClocks24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClocks24.Cursor = System.Windows.Forms.Cursors.No
        Me.lblClocks24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClocks24.Font = New System.Drawing.Font("alarm clock", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClocks24.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblClocks24.Location = New System.Drawing.Point(253, 103)
        Me.lblClocks24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblClocks24.Name = "lblClocks24"
        Me.lblClocks24.Size = New System.Drawing.Size(301, 69)
        Me.lblClocks24.TabIndex = 1
        Me.lblClocks24.Text = "12:00:00"
        '
        'lblBreak
        '
        Me.lblBreak.AutoSize = True
        Me.lblBreak.BackColor = System.Drawing.Color.Black
        Me.lblBreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBreak.Cursor = System.Windows.Forms.Cursors.No
        Me.lblBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBreak.Font = New System.Drawing.Font("alarm clock", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreak.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblBreak.Location = New System.Drawing.Point(490, 191)
        Me.lblBreak.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBreak.Name = "lblBreak"
        Me.lblBreak.Size = New System.Drawing.Size(204, 69)
        Me.lblBreak.TabIndex = 2
        Me.lblBreak.Text = "15:00"
        '
        'lblBreakLeft
        '
        Me.lblBreakLeft.AutoSize = True
        Me.lblBreakLeft.BackColor = System.Drawing.Color.Black
        Me.lblBreakLeft.Cursor = System.Windows.Forms.Cursors.No
        Me.lblBreakLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBreakLeft.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakLeft.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblBreakLeft.Location = New System.Drawing.Point(246, 191)
        Me.lblBreakLeft.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBreakLeft.Name = "lblBreakLeft"
        Me.lblBreakLeft.Size = New System.Drawing.Size(190, 37)
        Me.lblBreakLeft.TabIndex = 3
        Me.lblBreakLeft.Text = "Break Time"
        '
        'lblLunch
        '
        Me.lblLunch.AutoSize = True
        Me.lblLunch.BackColor = System.Drawing.Color.Black
        Me.lblLunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLunch.Cursor = System.Windows.Forms.Cursors.No
        Me.lblLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLunch.Font = New System.Drawing.Font("alarm clock", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunch.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblLunch.Location = New System.Drawing.Point(489, 274)
        Me.lblLunch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLunch.Name = "lblLunch"
        Me.lblLunch.Size = New System.Drawing.Size(205, 69)
        Me.lblLunch.TabIndex = 4
        Me.lblLunch.Text = "30:00"
        '
        'lblLunchLeft
        '
        Me.lblLunchLeft.AutoSize = True
        Me.lblLunchLeft.BackColor = System.Drawing.Color.Black
        Me.lblLunchLeft.Cursor = System.Windows.Forms.Cursors.No
        Me.lblLunchLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLunchLeft.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunchLeft.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblLunchLeft.Location = New System.Drawing.Point(246, 274)
        Me.lblLunchLeft.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLunchLeft.Name = "lblLunchLeft"
        Me.lblLunchLeft.Size = New System.Drawing.Size(196, 37)
        Me.lblLunchLeft.TabIndex = 5
        Me.lblLunchLeft.Text = "Lunch Time"
        '
        'btnBreak
        '
        Me.btnBreak.Location = New System.Drawing.Point(14, 191)
        Me.btnBreak.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnBreak.Name = "btnBreak"
        Me.btnBreak.Size = New System.Drawing.Size(162, 48)
        Me.btnBreak.TabIndex = 0
        Me.btnBreak.Text = "Start Break"
        Me.btnBreak.UseVisualStyleBackColor = True
        '
        'btnLunch
        '
        Me.btnLunch.Location = New System.Drawing.Point(14, 274)
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
        Me.btnStop.Location = New System.Drawing.Point(14, 115)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(162, 48)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'frmClocks
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(719, 365)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblLunchLeft)
        Me.Controls.Add(Me.btnLunch)
        Me.Controls.Add(Me.lblLunch)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblBreakLeft)
        Me.Controls.Add(Me.btnBreak)
        Me.Controls.Add(Me.lblBreak)
        Me.Controls.Add(Me.lblClocks24)
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
    Friend WithEvents tmrBreak As Timer
    Friend WithEvents tmrLunch As Timer
    Friend WithEvents lblClock As Label
    Friend WithEvents lblClocks24 As Label
    Friend WithEvents lblBreak As Label
    Friend WithEvents lblBreakLeft As Label
    Friend WithEvents lblLunch As Label
    Friend WithEvents lblLunchLeft As Label
    Friend WithEvents btnBreak As Button
    Friend WithEvents btnLunch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStop As Button
End Class
