Public Class Form1
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
    End Sub
    Dim curwidh As Integer = Me.Width
    Dim curheight As Integer = Me.Height
    Dim path = Application.StartupPath + "/BTCUSD.HTML"

    Dim browser = New CefSharp.WinForms.ChromiumWebBrowser(path) With {.Dock = DockStyle.Fill, .Padding = New Padding(0, 0, 0, 0)}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.AllowDrop = True
        Panel1.Controls.Add(browser)
        'D:\TraderD\xrp.html
        Me.KeyPreview = True

    End Sub
    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop

    End Sub

    Private Sub TwitchLabel1_Click(sender As Object, e As EventArgs) Handles TwitchLabel1.Click
        CefSharp.WebBrowserExtensions.Reload(browser)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim f As New Form1
        f.Show()
    End Sub
End Class
