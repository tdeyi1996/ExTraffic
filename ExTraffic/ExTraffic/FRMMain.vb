Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Text

Public Class FRMMain
    Dim tempPath_AllLinks As String
    Dim Thread_addLinks As Threading.Thread
    Dim Thread_removeLinks As Threading.Thread
    Dim Thread_surfLinks As Threading.Thread

    Private Sub AddLinks()
        Try
            GBbtnAddLinks.Enabled = False
            GBbtnRemoveLinks.Enabled = False
            GBbtnStartSurf.Enabled = False
            GBbtnStopSurf.Enabled = False
            lbStatus.Text = "Status : Adding links..."
            Thread.Sleep(2000)
            For i As Integer = 0 To LBLinks.Items.Count - 1
                LBLinks.Text = LBLinks.Items(i)
                wb.Navigate("http://tdy0123.neq3.com/ExTraffic/post.php?w=" & LBLinks.Items(i))
                For x As Integer = 0 To 5
                    lbStatus.Text = "Status : Added [" & LBLinks.Items(i) & "]"
                    lbDelayStatus.Text = "Delay status : Waiting (" & x.ToString & "/5) secs"
                    Thread.Sleep(1000)
                Next
            Next
            lbStatus.Text = "Status : nil"
            lbDelayStatus.Text = "Delay status : nil"
            MessageBox.Show("Finishing adding links.")
            GBbtnAddLinks.Enabled = True
            GBbtnRemoveLinks.Enabled = True
            GBbtnStartSurf.Enabled = True
            GBbtnStopSurf.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RemoveLinks()
        Try
            GBbtnAddLinks.Enabled = False
            GBbtnRemoveLinks.Enabled = False
            GBbtnStartSurf.Enabled = False
            lbStatus.Text = "Status : deleting links..."
            For i As Integer = 0 To LBLinks.Items.Count - 1
                wb.Navigate("http://tdy0123.neq3.com/ExTraffic/delete.php?w=" & LBLinks.Items(i))
                For x As Integer = 0 To 5
                    Thread.Sleep(1000)
                Next
            Next
            lbStatus.Text = "Status : nil"
            lbDelayStatus.Text = "Delay status : nil"
            LBLinks.Items.Clear()
            GBbtnAddLinks.Enabled = True
            GBbtnRemoveLinks.Enabled = True
            GBbtnStartSurf.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DownloadLinks()
        'Download all links
        Using webClient = New WebClient()
            Dim links = webClient.DownloadData("http://tdy0123.neq3.com/ExTraffic/Links.txt")
            File.WriteAllBytes(tempPath_AllLinks, links)
        End Using
    End Sub
    Private Sub SurfWebLinks()
        lbStatus.Text = "Status : Getting ready..."
        DownloadLinks()
        GBbtnAddLinks.Enabled = False
        GBbtnRemoveLinks.Enabled = False
        GBbtnStartSurf.Enabled = False

        Dim link_lines() As String = IO.File.ReadAllLines(tempPath_AllLinks)
        Dim link_lines_Arr As New ArrayList()

        For x As Integer = 0 To link_lines.GetUpperBound(0)
            link_lines_Arr.Add(link_lines(x))
        Next

        Dim webSurfer As New CSurf
        For i = 0 To link_lines_Arr.Count - 1
            lbStatus.Text = "Status : Surfing [" & link_lines(i).ToString & "]"
            lbDelayStatus.Text = "Delay Status : nil"
            Thread.Sleep(1000)
            webSurfer.Surf(link_lines(i))
            lbStatus.Text = "Status : Surfed [" & link_lines(i).ToString & "]"
            For x As Integer = 0 To 3
                lbDelayStatus.Text = "Delay Status : Waiting for (" & x.ToString & "/3) secs"
                Thread.Sleep(1000)
            Next
        Next
        lbStatus.Text = "Status : nil"
        lbDelayStatus.Text = "Delay status : nil"
        MessageBox.Show("Finishing surfing.")
        GBbtnAddLinks.Enabled = True
        GBbtnRemoveLinks.Enabled = True
        GBbtnStartSurf.Enabled = True
    End Sub

    Private Sub FRMMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wc As New WebClient()
        Dim connectiondata = wc.DownloadString("http://tdy0123.neq3.com/ExTraffic/connection.txt")
        If connectiondata.Contains("true") Then
        Else
            Application.Exit()
        End If

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        tempPath_AllLinks = Path.Combine(System.IO.Path.GetTempPath, "userlinks.txt")

        If File.Exists(tempPath_AllLinks) Then
            File.Delete(tempPath_AllLinks)
        End If
    End Sub
    Private Sub FRMMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If LBLinks.Items.Count > 0 Then
            Me.Hide()
            For i As Integer = 0 To LBLinks.Items.Count - 1
                wb.Navigate("http://tdy0123.neq3.com/ExTraffic/delete.php?w=" & LBLinks.Items(i))
                Application.DoEvents()
                Thread.Sleep(3000)
            Next
            LBLinks.Items.Clear()
        End If
        Application.Exit()
    End Sub

    Private Sub GBbtnAddLinks_Click(sender As Object, e As EventArgs) Handles GBbtnAddLinks.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            LBLinks.Items.AddRange(Split(My.Computer.FileSystem.ReadAllText(OFD.FileName), vbNewLine))
            Try
                Thread_addLinks = New Thread(AddressOf AddLinks)
                Thread_addLinks.Start()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GBbtnRemoveLinks_Click(sender As Object, e As EventArgs) Handles GBbtnRemoveLinks.Click
        Try
            Thread_removeLinks = New Thread(AddressOf RemoveLinks)
            Thread_removeLinks.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GBbtnStartSurf_Click(sender As Object, e As EventArgs) Handles GBbtnStartSurf.Click
        Try
            Thread_surfLinks = New Thread(AddressOf SurfWebLinks)
            Thread_surfLinks.Start()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GBbtnStopSurf_Click(sender As Object, e As EventArgs) Handles GBbtnStopSurf.Click
        Try
            Thread_surfLinks.Abort()
            lbStatus.Text = "Status : nil"
            lbDelayStatus.Text = "Delay status : nil"
            GBbtnAddLinks.Enabled = True
            GBbtnRemoveLinks.Enabled = True
            GBbtnStartSurf.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
End Class
