<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdStartMonitor = New System.Windows.Forms.Button()
        Me.cmdStopMonitor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProcessName = New System.Windows.Forms.TextBox()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.chkAutoKillProc = New System.Windows.Forms.CheckBox()
        Me.txtLastCheckAt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtREtry = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdStartMonitor
        '
        Me.cmdStartMonitor.Location = New System.Drawing.Point(12, 103)
        Me.cmdStartMonitor.Name = "cmdStartMonitor"
        Me.cmdStartMonitor.Size = New System.Drawing.Size(230, 80)
        Me.cmdStartMonitor.TabIndex = 0
        Me.cmdStartMonitor.Text = "Start Monitoring"
        Me.cmdStartMonitor.UseVisualStyleBackColor = True
        '
        'cmdStopMonitor
        '
        Me.cmdStopMonitor.Enabled = False
        Me.cmdStopMonitor.Location = New System.Drawing.Point(12, 201)
        Me.cmdStopMonitor.Name = "cmdStopMonitor"
        Me.cmdStopMonitor.Size = New System.Drawing.Size(230, 80)
        Me.cmdStopMonitor.TabIndex = 0
        Me.cmdStopMonitor.Text = "Stop Monitoring"
        Me.cmdStopMonitor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "process name"
        '
        'txtProcessName
        '
        Me.txtProcessName.Location = New System.Drawing.Point(12, 23)
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(158, 20)
        Me.txtProcessName.TabIndex = 2
        Me.txtProcessName.Text = "QuasiStarter"
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(12, 62)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(65, 20)
        Me.txtInterval.TabIndex = 4
        Me.txtInterval.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "interval (s)"
        '
        'tmr
        '
        '
        'chkAutoKillProc
        '
        Me.chkAutoKillProc.Checked = True
        Me.chkAutoKillProc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoKillProc.Location = New System.Drawing.Point(195, 7)
        Me.chkAutoKillProc.Name = "chkAutoKillProc"
        Me.chkAutoKillProc.Size = New System.Drawing.Size(99, 75)
        Me.chkAutoKillProc.TabIndex = 5
        Me.chkAutoKillProc.Text = "Automatically restart process if not responding"
        Me.chkAutoKillProc.UseVisualStyleBackColor = True
        '
        'txtLastCheckAt
        '
        Me.txtLastCheckAt.Location = New System.Drawing.Point(12, 300)
        Me.txtLastCheckAt.Name = "txtLastCheckAt"
        Me.txtLastCheckAt.ReadOnly = True
        Me.txtLastCheckAt.Size = New System.Drawing.Size(158, 20)
        Me.txtLastCheckAt.TabIndex = 7
        Me.txtLastCheckAt.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "last check at"
        '
        'txtREtry
        '
        Me.txtREtry.Location = New System.Drawing.Point(99, 62)
        Me.txtREtry.Name = "txtREtry"
        Me.txtREtry.Size = New System.Drawing.Size(65, 20)
        Me.txtREtry.TabIndex = 9
        Me.txtREtry.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "# Retries"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 334)
        Me.Controls.Add(Me.txtREtry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastCheckAt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkAutoKillProc)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProcessName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdStopMonitor)
        Me.Controls.Add(Me.cmdStartMonitor)
        Me.Name = "Form1"
        Me.Text = "Process Watch Dog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStartMonitor As System.Windows.Forms.Button
    Friend WithEvents cmdStopMonitor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProcessName As System.Windows.Forms.TextBox
    Friend WithEvents txtInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents chkAutoKillProc As System.Windows.Forms.CheckBox
    Friend WithEvents txtLastCheckAt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtREtry As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
