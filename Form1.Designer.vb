<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startstopbutton = New System.Windows.Forms.Button()
        Me.configbutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.initsetup = New System.Windows.Forms.Timer(Me.components)
        Me.tmplistauswerten = New System.Windows.Forms.Timer(Me.components)
        Me.logbox = New System.Windows.Forms.ListBox()
        Me.playerbox = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.configlist = New System.Windows.Forms.ListBox()
        Me.updatechecker = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.discordstatustimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(86, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cubic Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(89, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bedrock Server Manager"
        '
        'startstopbutton
        '
        Me.startstopbutton.BackColor = System.Drawing.Color.Lime
        Me.startstopbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startstopbutton.FlatAppearance.BorderSize = 2
        Me.startstopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startstopbutton.Location = New System.Drawing.Point(407, 18)
        Me.startstopbutton.Name = "startstopbutton"
        Me.startstopbutton.Size = New System.Drawing.Size(179, 53)
        Me.startstopbutton.TabIndex = 3
        Me.startstopbutton.Text = "Start Server"
        Me.startstopbutton.UseVisualStyleBackColor = False
        '
        'configbutton
        '
        Me.configbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.configbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.configbutton.FlatAppearance.BorderSize = 2
        Me.configbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.configbutton.Location = New System.Drawing.Point(592, 18)
        Me.configbutton.Name = "configbutton"
        Me.configbutton.Size = New System.Drawing.Size(179, 53)
        Me.configbutton.TabIndex = 4
        Me.configbutton.Text = "Config"
        Me.configbutton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 99)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(366, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "-1"
        Me.Label3.Visible = False
        '
        'initsetup
        '
        Me.initsetup.Interval = 1000
        '
        'tmplistauswerten
        '
        Me.tmplistauswerten.Enabled = True
        Me.tmplistauswerten.Interval = 1
        '
        'logbox
        '
        Me.logbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logbox.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.logbox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.logbox.FormattingEnabled = True
        Me.logbox.ItemHeight = 14
        Me.logbox.Items.AddRange(New Object() {"Welcome to Cubic Control"})
        Me.logbox.Location = New System.Drawing.Point(5, 100)
        Me.logbox.Name = "logbox"
        Me.logbox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.logbox.Size = New System.Drawing.Size(581, 282)
        Me.logbox.TabIndex = 7
        '
        'playerbox
        '
        Me.playerbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.playerbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.playerbox.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.playerbox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.playerbox.FormattingEnabled = True
        Me.playerbox.ItemHeight = 14
        Me.playerbox.Location = New System.Drawing.Point(592, 100)
        Me.playerbox.Name = "playerbox"
        Me.playerbox.Size = New System.Drawing.Size(179, 282)
        Me.playerbox.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(5, 388)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(581, 26)
        Me.TextBox1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(592, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Kick all Players"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'configlist
        '
        Me.configlist.FormattingEnabled = True
        Me.configlist.Location = New System.Drawing.Point(775, 177)
        Me.configlist.Name = "configlist"
        Me.configlist.Size = New System.Drawing.Size(421, 95)
        Me.configlist.TabIndex = 11
        Me.configlist.Visible = False
        '
        'updatechecker
        '
        Me.updatechecker.Enabled = True
        Me.updatechecker.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(120, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(549, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "This Software is for testing purposes only. Not to use in productive scenario! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "LunayderKater is not responsible for dataloss."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PictureBox1.Image = Global.Cubic_Control.My.Resources.Resources.bedrockicon
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'discordstatustimer
        '
        Me.discordstatustimer.Enabled = True
        Me.discordstatustimer.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 468)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.configlist)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.playerbox)
        Me.Controls.Add(Me.logbox)
        Me.Controls.Add(Me.configbutton)
        Me.Controls.Add(Me.startstopbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cubic Control v0.0.2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startstopbutton As Button
    Friend WithEvents configbutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents initsetup As Timer
    Friend WithEvents tmplistauswerten As Timer
    Friend WithEvents logbox As ListBox
    Friend WithEvents playerbox As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents configlist As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents updatechecker As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents discordstatustimer As Timer
End Class
