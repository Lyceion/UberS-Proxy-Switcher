Imports Microsoft.Win32
Imports System.IO
Imports System.Text
Public Class Form1
    Dim i = "1"

    Public Sub ProxyDegistir(ByVal Proxy As String)
        Dim proxykey As String = "Software\Microsoft\Windows\CurrentVersion\Internet Settings"

        Dim RegKey As RegistryKey = Registry.CurrentUser.OpenSubKey(proxykey, True)
        RegKey.SetValue("ProxyServer", Proxy)
        RegKey.SetValue("ProxyEnable", 1)

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        For Each kontrol As String In My.Application.CommandLineArgs
            Select Case Trim(LTrim(kontrol))
                Case "/pneltarama3162"
                    Timer1.Stop()
                    MsgBox("Hoş Geldiniz...")
            End Select
        Next
    End Sub

    Private Sub HuraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton3.Click
        ProxyKapat()
        End
    End Sub

    Private Sub HuraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton6.Click
        If ListBox1.Items.Count Then
            ProxyDegistir(HuraTextBox1.Text)
        Else
            MsgBox("Listede Proxy Yok!", "HATA", MsgBoxStyle.Critical)
        End If
        HuraButton6.Enabled = False
        HuraButton7.Enabled = True
    End Sub

    Private Sub HuraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton5.Click
        If ListBox1.Items.Count Then
            HuraTextBox1.Text = ListBox1.SelectedItem
        Else
            MsgBox("Listede Proxy Yok!", "HATA", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub ProxyKapat()
        Dim proxykey As String = "Software\Microsoft\Windows\CurrentVersion\Internet Settings"

        Dim RegKey As RegistryKey = Registry.CurrentUser.OpenSubKey(proxykey, True)
        RegKey.SetValue("ProxyEnable", 0)
    End Sub

    Private Sub HuraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton1.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim oku As New StreamReader(OpenFileDialog1.FileName)
                Dim satir As String = oku.ReadLine()
                While satir IsNot Nothing
                    ListBox1.Items.Add(satir)
                    satir = oku.ReadLine()
                End While
            End If
        Catch ex As Exception

        End Try
        HuraButton2.Enabled = True
        HuraButton1.Enabled = False
    End Sub

    Private Sub HuraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton7.Click
        ProxyKapat()
        HuraButton7.Enabled = False
        HuraButton6.Enabled = True
    End Sub

    Private Sub HuraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton2.Click
        ListBox1.Items.Clear()
        HuraButton2.Enabled = False
        HuraButton1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MsgBox("Bu Program Sadece Panel Taramaye Özeldir. Başka Yerden Açılamaz!", MsgBoxStyle.Critical, "HATA")
        End
    End Sub
End Class
