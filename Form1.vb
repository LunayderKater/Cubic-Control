Imports System.ComponentModel
Imports System.Text
Imports Color = System.Drawing.Color
Imports Discord.Net
Imports Discord
Imports Discord.WebSocket

Public Class Form1
    Dim p As New Process
    Dim activity As New Integer
    Dim status As New Integer
    Dim tmplist As New ListBox
    Dim dcclient As DiscordSocketClient
    Dim levelname As String
    Dim gid As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dcclient = New DiscordSocketClient(New DiscordSocketConfig With {
                      .MessageCacheSize = 1024,
                      .GatewayIntents = GatewayIntents.All})

        status = 0
        activity = 0
        AddHandler p.OutputDataReceived, AddressOf datenerhalten
        AddHandler dcclient.MessageReceived, AddressOf discordmessage
        If IO.Directory.Exists(Application.StartupPath & "\server\") = False Then
            IO.Directory.CreateDirectory(Application.StartupPath & "\server\")
            IO.Directory.CreateDirectory(Application.StartupPath & "\backup\")
            IO.File.WriteAllText(Application.StartupPath & "\server\put-server-files.here", "")
            Dim newconfig As New ListBox
            newconfig.Items.Add(">>> Cubic Control Config")
            newconfig.Items.Add("autostart=false")
            newconfig.Items.Add("autoupdate=false")
            newconfig.Items.Add("------------------------------")
            newconfig.Items.Add(">>> Backup Config") 'Backuptitle
            newconfig.Items.Add("backup=false") 'Backup on?
            newconfig.Items.Add("interval=30") 'Backup Interval (minutes)
            newconfig.Items.Add("on-activity=true") 'Only on Activity?
            newconfig.Items.Add("while-online=false") 'While Online
            newconfig.Items.Add("max-backups=0") 'Max Backups
            newconfig.Items.Add("backup-message=Server will make a backup in 5 minutes.") 'Backup Message
            newconfig.Items.Add("------------------------------")
            newconfig.Items.Add(">>> Discord Config")
            newconfig.Items.Add("enabled=false")
            newconfig.Items.Add("status=true")
            newconfig.Items.Add("chat=true")
            newconfig.Items.Add("token=")
            newconfig.Items.Add(">>> Player Management Config")
            newconfig.Items.Add("banmessage=You have been banned from this server.")

            ListBox_Save(newconfig, Application.StartupPath & "\cubic-control.cfg")
            initsetup.Start()
        Else

        End If
        ListBox_Read(configlist, Application.StartupPath & "\cubic-control.cfg")

        dcstarten()
    End Sub
    Public Sub dcstarten()
        If dcclient.ConnectionState = ConnectionState.Connected Then
            dcclient.StopAsync()
            dcclient.LogoutAsync()
            dcstarten()
        Else
            If dcclient.ConnectionState = ConnectionState.Connecting Then
            Else
                If configlist.Items.Item(13).ToString = "enabled=true" Then
                    Try
                        dcclient.LoginAsync(TokenType.Bot, configlist.Items.Item(16).ToString.Replace("token=", ""), True)
                        dcclient.StartAsync()

                        tmplist.Items.Add("Discord Ready!")
                    Catch ex As Exception
                        tmplist.Items.Add("Discord-ERROR: Token Invalid or no connection!")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Async Function discordmessage(msg As SocketMessage) As Task
        Try

        Catch ex As Exception
            tmplist.Items.Add("Discord-ERROR: Message could not be decoded.")
        End Try
    End Function

    Private Sub starteserver()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.FileName = Application.StartupPath & "\server\bedrock_server.exe"
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.StandardOutputEncoding = Encoding.UTF8
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub datenerhalten(sender As Object, args As DataReceivedEventArgs)
        If args.Data IsNot Nothing Then
            tmplist.Items.Add(args.Data)
        End If
    End Sub

    Private Sub initsetup_Tick(sender As Object, e As EventArgs) Handles initsetup.Tick
        initsetup.Stop()
        If MsgBox("Hey! Welcome to Cubic Control the #1 Bedrock Server Manager" & vbCrLf &
                  "It seems u are new here so i made a folder called (server) here at the program. You should put the bedrock server software in it to make me work." & vbCrLf & vbCrLf &
                  "Wanna get directed to mojangs server software download?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Process.Start(Application.StartupPath & "\server\")
            Process.Start("https://www.minecraft.net/en-us/download/server/bedrock")
        End If

    End Sub
    Private Sub tmplistauswerten_Tick(sender As Object, e As EventArgs) Handles tmplistauswerten.Tick
        If tmplist.Items.Count > 0 Then
            'Inhalt prüfen --------------------------------------------------------------

            If tmplist.Items.Item(0).ToString.Contains("Quit correctly") Then
                activity = 0
                playerbox.Items.Clear()

                Try
                    p.CancelOutputRead()
                    p.Kill()
                Catch ex As Exception

                End Try
                If status = 3 Then
                    status = 4
                Else
                    If status = 666 Then
                        status = 111
                        Application.Exit()
                    Else
                        status = 0
                        startstopbutton.Text = "Start Server"
                        startstopbutton.BackColor = Color.Lime
                    End If
                End If
            End If
            If tmplist.Items.Item(0).ToString.Contains("Server started.") Then
                status = 1
                startstopbutton.Text = "Stop Server"
                startstopbutton.BackColor = Color.IndianRed
            End If
            If tmplist.Items.Item(0).ToString.Contains("Level Name: ") Then
                Dim rohname() As String = tmplist.Items.Item(0).ToString.Split("]"c)
                levelname = rohname(1).Replace(" Level Name: ", "")
            End If
            If tmplist.Items.Item(0).ToString.Contains("Player connected: ") Then
                Dim bearbeitenstring As String = tmplist.Items.Item(0).ToString
                bearbeitenstring = bearbeitenstring.Replace("Player connected: ", "")
                Dim rohneu() As String = bearbeitenstring.Split("]"c)
                bearbeitenstring = bearbeitenstring.Replace(rohneu(0) & "] ", "")
                Dim rohname() As String = bearbeitenstring.Split(","c)
                Dim playername As String = rohname(0)
                If playerbox.Items.Contains(playername) = False Then
                    playerbox.Items.Add(playername)
                End If
                activity = 1
            End If
            If tmplist.Items.Item(0).ToString.Contains("Player disconnected: ") Then
                Dim bearbeitenstring As String = tmplist.Items.Item(0).ToString
                bearbeitenstring = bearbeitenstring.Replace("Player disconnected: ", "")
                Dim rohneu() As String = bearbeitenstring.Split("]"c)
                bearbeitenstring = bearbeitenstring.Replace(rohneu(0) & "] ", "")
                Dim rohname() As String = bearbeitenstring.Split(","c)
                Dim playername As String = rohname(0)
                If playerbox.Items.Contains(playername) = True Then
                    playerbox.Items.Remove(playername)
                End If
            End If
            '----------------------------------------------------------------------------
            logbox.Items.Insert(0, " " & tmplist.Items.Item(0))
            tmplist.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub startstopbutton_Click(sender As Object, e As EventArgs) Handles startstopbutton.Click
        If IO.File.Exists(Application.StartupPath & "\server\bedrock_server.exe") = False Then
            MsgBox("I cant find the bedrock_server.exe at:" & vbCrLf & Application.StartupPath & "\server\bedrock_server.exe" & vbCrLf & "Please make shure it is found there.", MsgBoxStyle.Critical)
            Process.Start(Application.StartupPath & "\server\")
            Exit Sub
        End If
        If status = 0 Then

            status = 2
            Label3.Text = "-1"
            startstopbutton.Text = "starting server..."
            startstopbutton.BackColor = Color.Yellow
            starteserver()
        End If
        If status = 1 Then
            status = 2
            startstopbutton.BackColor = Color.Yellow
            startstopbutton.Text = "stopping server..."
            p.StandardInput.WriteLine("stop")
        End If

    End Sub

    Private Sub configbutton_Click(sender As Object, e As EventArgs) Handles configbutton.Click
        config.Show()
    End Sub
    Public Sub ListBox_Save(ByVal ListBox As ListBox,
ByVal sFile As String)

        ' Inhalt einer ListBox speichern
        Dim oStream As IO.StreamWriter
        Dim i As Short

        oStream = New IO.StreamWriter(sFile)

        For i = 0 To ListBox.Items.Count - 1
            oStream.WriteLine(ListBox.Items(i))
        Next
        oStream.Close()
    End Sub

    Public Sub ListBox_Read(ByVal ListBox As ListBox,
      ByVal sFile As String)

        ' Inhalt einer ListBox speichern
        Dim oStream As IO.StreamReader
        Dim sLine As String

        ' ListBox löschen
        ListBox.Items.Clear()

        ' Existsiert die Datei?
        Dim oFile As New IO.FileInfo(sFile)

        If oFile.Exists() = True Then
            oStream = New IO.StreamReader(sFile)
            ' Datei zeilenweise auslesen
            Do
                sLine = oStream.ReadLine()
                If IsNothing(sLine) Then Exit Do
                ListBox.Items.Add(sLine)
            Loop
            oStream.Close()
        End If
    End Sub
    Private Sub updatechecker_Tick(sender As Object, e As EventArgs) Handles updatechecker.Tick


        If status = 1 And configlist.Items.Item(5).ToString = "backup=true" Then
            If Label3.Text = "-1" Then
                Label3.Text = configlist.Items.Item(6).ToString.Replace("interval=", "") * 60
            Else
                If Label3.Text = 0 Then

                    'Backup when activity
                    If configlist.Items.Item(7).ToString = "on-activity=true" Then
                        If activity = 1 Then
                            p.StandardInput.WriteLine("start backup!")
                            If configlist.Items.Item(8).ToString = "while-online=false" Then
                                'Backup Offline!
                                status = 3
                                startstopbutton.Text = "creating backup..."
                                startstopbutton.BackColor = Color.MediumPurple
                                p.StandardInput.WriteLine("stop")
                            Else
                                'Backup Online!
                                status = 6
                                startstopbutton.Text = "creating backup..."
                                startstopbutton.BackColor = Color.MediumPurple
                                BackgroundWorker1.RunWorkerAsync()
                            End If
                        Else
                            'No activity / No backup
                            Label3.Text = "-1"
                        End If
                    Else
                        'Backup without activity
                        p.StandardInput.WriteLine("start backup!")
                        If configlist.Items.Item(8).ToString = "while-online=false" Then
                            'Backup Offline!
                            status = 3
                            startstopbutton.Text = "creating backup..."
                            startstopbutton.BackColor = Color.MediumPurple
                            p.StandardInput.WriteLine("stop")
                        Else
                            'Backup Online!
                            status = 6
                            startstopbutton.Text = "creating backup..."
                            startstopbutton.BackColor = Color.MediumPurple
                            BackgroundWorker1.RunWorkerAsync()
                        End If
                    End If
                Else
                    Label3.Text = Label3.Text - 1
                    If Label3.Text = 300 Then
                        If configlist.Items.Item(7).ToString = "on-activity=true" Then
                            If activity = 1 Then
                                'YE
                                p.StandardInput.WriteLine("say " & configlist.Items.Item(10).ToString.Replace("backup-message=", ""))
                            Else
                                'ZURÜCKSETZEN
                                Label3.Text = configlist.Items.Item(6).ToString.Replace("interval=", "") * 60
                            End If
                        Else
                            'YE
                            p.StandardInput.WriteLine("say " & configlist.Items.Item(10).ToString.Replace("backup-message=", ""))
                        End If
                    Else
                        If Label3.Text < 6 Then
                            p.StandardInput.WriteLine("say backup in " & Label3.Text)
                        End If
                    End If
                End If

            End If
        Else
            If status = 4 Then
                status = 5
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            Dim bckworld As String
            For Each diri In IO.Directory.GetDirectories(Application.StartupPath & "\server\worlds\")
                bckworld = diri
            Next

            Dim bckfolder As String = Application.StartupPath & "\backup\" & DateTime.Now.ToString("dd.MM.yyyy HH_mm") & "\"
            IO.Directory.CreateDirectory(bckfolder)
            My.Computer.FileSystem.CopyDirectory(bckworld, bckfolder, True)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If status = 5 Then
            status = 2
            Label3.Text = "-1"
            startstopbutton.Text = "starting server..."
            startstopbutton.BackColor = Color.Yellow
            starteserver()
        Else
            If status = 6 Then
                If playerbox.Items.Count = 0 Then
                    activity = 0
                End If
                status = 1
                Label3.Text = "-1"
                startstopbutton.Text = "Stop Server"
                startstopbutton.BackColor = Color.IndianRed
            End If
        End If
        delbck()
    End Sub
    Private Sub delbck()
        If configlist.Items.Item(9).ToString.Replace("max-backups=", "") > 0 Then
            Dim bckcount As Integer = 0
            For Each Diri In IO.Directory.GetDirectories(Application.StartupPath & "\backup\")
                bckcount = bckcount + 1
            Next
erneut:
            If bckcount > configlist.Items.Item(9).ToString.Replace("max-backups=", "") Then
                Dim tempscore As Integer = 0
                Dim dscore As Integer = 0
                Dim todel As String = ""
                For Each Diri In IO.Directory.GetDirectories(Application.StartupPath & "\backup\")
                    tempscore = 0
                    Dim datestrg As String = Diri.ToString.Replace(Application.StartupPath & "\backup\", "")
                    datestrg = datestrg.Replace("\", "")
                    datestrg = datestrg.Replace("_", ":")
                    If IsDate(datestrg) = True Then
                        Dim dududu As Date = datestrg

                        tempscore = tempscore + DateDiff(DateInterval.Day, dududu, DateTime.Now)
                        tempscore = tempscore + DateDiff(DateInterval.Month, dududu, DateTime.Now)
                        tempscore = tempscore + DateDiff(DateInterval.Year, dududu, DateTime.Now)
                        tempscore = tempscore + DateDiff(DateInterval.Hour, dududu, DateTime.Now)
                        tempscore = tempscore + DateDiff(DateInterval.Minute, dududu, DateTime.Now)

                        If tempscore > dscore Then
                            dscore = tempscore
                            todel = Diri
                        End If
                    End If
                Next

                IO.Directory.Delete(todel, True)
                bckcount = bckcount - 1
                If bckcount > configlist.Items.Item(9).ToString.Replace("max-backups=", "") Then
                    GoTo erneut
                End If
            Else
                'Deletion done


            End If


        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If status = 1 Or status = 666 Then
            e.Cancel = True
            status = 666
            p.StandardInput.WriteLine("stop")
        End If
    End Sub

    Private Sub discordstatustimer_Tick(sender As Object, e As EventArgs) Handles discordstatustimer.Tick

        If configlist.Items.Item(14).ToString = "status=true" Then
            If status = 0 Then
                dcclient.SetGameAsync("Server offline")
            End If
            If status = 1 Then
                If playerbox.Items.Count > 0 Then
                    dcclient.SetGameAsync(levelname & " with " & playerbox.Items.Count & " players.")
                Else
                    dcclient.SetGameAsync(levelname)
                End If
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
