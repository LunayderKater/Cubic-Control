
Public Class config
    Dim loadinit As Boolean
    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadinit = True
        'LoadIn BCK
        If Form1.configlist.Items.Item(5).ToString = "backup=true" Then
            CheckBox1.Checked = True
        End If
        If Form1.configlist.Items.Item(7).ToString = "on-activity=true" Then
            CheckBox2.Checked = True
        End If
        If Form1.configlist.Items.Item(8).ToString = "while-online=true" Then
            CheckBox3.Checked = True
        End If

        NumericUpDown1.Value = Form1.configlist.Items.Item(6).ToString.Replace("interval=", "")
        NumericUpDown2.Value = Form1.configlist.Items.Item(9).ToString.Replace("max-backups=", "")
        TextBox1.Text = Form1.configlist.Items.Item(10).ToString.Replace("backup-message=", "")
        'LoadIn Discord

        If Form1.configlist.Items.Item(13).ToString = "enabled=true" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
        If Form1.configlist.Items.Item(14).ToString = "status=true" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
        If Form1.configlist.Items.Item(15).ToString = "chat=true" Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If

        TextBox2.Text = Form1.configlist.Items.Item(16).ToString.Replace("token=", "")

        loadinit = False
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel1.Enabled = True
            If loadinit = False Then

            End If
            Form1.configlist.Items.Item(5) = "backup=true"
            CheckBox1.Image = My.Resources._on
        Else
            Panel1.Enabled = False
            If loadinit = False Then

            End If
            Form1.configlist.Items.Item(5) = "backup=false"
            CheckBox1.Image = My.Resources.off
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            CheckBox4.Image = My.Resources._on
            PictureBox3.Image = My.Resources.sculkon
            Panel2.Enabled = True
            If loadinit = False Then
                Form1.configlist.Items.Item(13) = "enabled=true"
            End If
        Else
            Panel2.Enabled = False
            CheckBox4.Image = My.Resources.off
            PictureBox3.Image = My.Resources.sculk
            If loadinit = False Then
                Form1.configlist.Items.Item(13) = "enabled=false"
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            If loadinit = False Then
                Form1.configlist.Items.Item(7) = "on-activity=true"
            End If
            CheckBox2.Image = My.Resources._on
        Else
            If loadinit = False Then
                Form1.configlist.Items.Item(7) = "on-activity=false"
            End If
            CheckBox2.Image = My.Resources.off
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            If loadinit = False Then
                Form1.configlist.Items.Item(8) = "while-online=true"
            End If
            CheckBox3.Image = My.Resources._on
        Else
            If loadinit = False Then
                Form1.configlist.Items.Item(8) = "while-online=false"
            End If
            CheckBox3.Image = My.Resources.off
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If loadinit = False Then
            Form1.configlist.Items.Item(10) = "backup-message=" & TextBox1.Text
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        If loadinit = False Then
            Form1.configlist.Items.Item(6) = "interval=" & NumericUpDown1.Value
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

        If loadinit = False Then
            Form1.configlist.Items.Item(9) = "max-backups=" & NumericUpDown2.Value
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then
            If loadinit = False Then
                Form1.configlist.Items.Item(14) = "status=true"
            End If

            CheckBox5.Image = My.Resources._on
        Else
            If loadinit = False Then
                Form1.configlist.Items.Item(14) = "status=false"
            End If
            CheckBox5.Image = My.Resources.off
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = True Then
            If loadinit = False Then
                Form1.configlist.Items.Item(15) = "chat=true"
            End If
            CheckBox6.Image = My.Resources._on
        Else
            If loadinit = False Then
                Form1.configlist.Items.Item(15) = "chat=false"
            End If
            CheckBox6.Image = My.Resources.off
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If loadinit = False Then
            Form1.configlist.Items.Item(16) = "token=" & TextBox2.Text
        End If
    End Sub


    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If Form1.configlist.Items.Item(13).ToString = "enabled=true" Then
            Form1.dcstarten()
        End If

        Form1.ListBox_Save(Form1.configlist, Application.StartupPath & "\cubic-control.cfg")
        savebutton.Text = "Saved!"
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        savebutton.Text = "Save Config"
    End Sub
End Class