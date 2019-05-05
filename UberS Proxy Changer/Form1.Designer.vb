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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HuraForm1 = New UberS_Proxy_Changer.HuraForm()
        Me.HuraButton7 = New UberS_Proxy_Changer.HuraButton()
        Me.HuraButton6 = New UberS_Proxy_Changer.HuraButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraTextBox1 = New UberS_Proxy_Changer.HuraTextBox()
        Me.HuraButton5 = New UberS_Proxy_Changer.HuraButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.HuraButton4 = New UberS_Proxy_Changer.HuraButton()
        Me.HuraButton3 = New UberS_Proxy_Changer.HuraButton()
        Me.HuraGroupBox1 = New UberS_Proxy_Changer.HuraGroupBox()
        Me.HuraButton2 = New UberS_Proxy_Changer.HuraButton()
        Me.HuraButton1 = New UberS_Proxy_Changer.HuraButton()
        Me.HuraForm1.SuspendLayout()
        Me.HuraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HuraForm1.ColorScheme = UberS_Proxy_Changer.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraButton7)
        Me.HuraForm1.Controls.Add(Me.HuraButton6)
        Me.HuraForm1.Controls.Add(Me.Label2)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.HuraTextBox1)
        Me.HuraForm1.Controls.Add(Me.HuraButton5)
        Me.HuraForm1.Controls.Add(Me.ListBox1)
        Me.HuraForm1.Controls.Add(Me.HuraButton4)
        Me.HuraForm1.Controls.Add(Me.HuraButton3)
        Me.HuraForm1.Controls.Add(Me.HuraGroupBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.White
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(425, 410)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "UberS Proxy Pack ~ For Panel Tarama"
        '
        'HuraButton7
        '
        Me.HuraButton7.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraButton7.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton7.Enabled = False
        Me.HuraButton7.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton7.ForeColor = System.Drawing.Color.White
        Me.HuraButton7.Location = New System.Drawing.Point(298, 116)
        Me.HuraButton7.Name = "HuraButton7"
        Me.HuraButton7.Size = New System.Drawing.Size(115, 23)
        Me.HuraButton7.TabIndex = 10
        Me.HuraButton7.Text = "Proxy Kapat!"
        Me.HuraButton7.UseVisualStyleBackColor = False
        '
        'HuraButton6
        '
        Me.HuraButton6.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraButton6.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton6.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton6.ForeColor = System.Drawing.Color.White
        Me.HuraButton6.Location = New System.Drawing.Point(298, 87)
        Me.HuraButton6.Name = "HuraButton6"
        Me.HuraButton6.Size = New System.Drawing.Size(115, 23)
        Me.HuraButton6.TabIndex = 9
        Me.HuraButton6.Text = "Proxy Aktif ET!"
        Me.HuraButton6.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Proxy Aktar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Proxy:"
        '
        'HuraTextBox1
        '
        Me.HuraTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HuraTextBox1.ColorScheme = UberS_Proxy_Changer.HuraTextBox.ColorSchemes.Dark
        Me.HuraTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraTextBox1.ForeColor = System.Drawing.Color.White
        Me.HuraTextBox1.Location = New System.Drawing.Point(298, 57)
        Me.HuraTextBox1.Name = "HuraTextBox1"
        Me.HuraTextBox1.Size = New System.Drawing.Size(115, 24)
        Me.HuraTextBox1.TabIndex = 6
        '
        'HuraButton5
        '
        Me.HuraButton5.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HuraButton5.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton5.ForeColor = System.Drawing.Color.White
        Me.HuraButton5.Location = New System.Drawing.Point(12, 34)
        Me.HuraButton5.Name = "HuraButton5"
        Me.HuraButton5.Size = New System.Drawing.Size(30, 20)
        Me.HuraButton5.TabIndex = 5
        Me.HuraButton5.Text = ">>"
        Me.HuraButton5.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.Color.Red
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(12, 69)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(207, 323)
        Me.ListBox1.TabIndex = 4
        '
        'HuraButton4
        '
        Me.HuraButton4.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraButton4.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton4.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton4.ForeColor = System.Drawing.Color.White
        Me.HuraButton4.Location = New System.Drawing.Point(357, 3)
        Me.HuraButton4.Name = "HuraButton4"
        Me.HuraButton4.Size = New System.Drawing.Size(24, 23)
        Me.HuraButton4.TabIndex = 3
        Me.HuraButton4.Text = "__"
        Me.HuraButton4.UseVisualStyleBackColor = False
        '
        'HuraButton3
        '
        Me.HuraButton3.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraButton3.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton3.ForeColor = System.Drawing.Color.White
        Me.HuraButton3.Location = New System.Drawing.Point(387, 3)
        Me.HuraButton3.Name = "HuraButton3"
        Me.HuraButton3.Size = New System.Drawing.Size(26, 23)
        Me.HuraButton3.TabIndex = 2
        Me.HuraButton3.Text = "X"
        Me.HuraButton3.UseVisualStyleBackColor = False
        '
        'HuraGroupBox1
        '
        Me.HuraGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HuraGroupBox1.Controls.Add(Me.HuraButton2)
        Me.HuraGroupBox1.Controls.Add(Me.HuraButton1)
        Me.HuraGroupBox1.Location = New System.Drawing.Point(282, 332)
        Me.HuraGroupBox1.Name = "HuraGroupBox1"
        Me.HuraGroupBox1.Size = New System.Drawing.Size(140, 75)
        Me.HuraGroupBox1.TabIndex = 1
        Me.HuraGroupBox1.Text = "HuraGroupBox1"
        '
        'HuraButton2
        '
        Me.HuraButton2.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HuraButton2.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton2.Enabled = False
        Me.HuraButton2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton2.ForeColor = System.Drawing.Color.White
        Me.HuraButton2.Location = New System.Drawing.Point(3, 41)
        Me.HuraButton2.Name = "HuraButton2"
        Me.HuraButton2.Size = New System.Drawing.Size(134, 32)
        Me.HuraButton2.TabIndex = 1
        Me.HuraButton2.Text = "Proxy Listesini Temizle"
        Me.HuraButton2.UseVisualStyleBackColor = False
        '
        'HuraButton1
        '
        Me.HuraButton1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HuraButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HuraButton1.ColorScheme = UberS_Proxy_Changer.HuraButton.ColorSchemes.Dark
        Me.HuraButton1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraButton1.ForeColor = System.Drawing.Color.White
        Me.HuraButton1.Location = New System.Drawing.Point(3, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.Size = New System.Drawing.Size(134, 32)
        Me.HuraButton1.TabIndex = 0
        Me.HuraButton1.Text = "Proxy Listesi Yükle"
        Me.HuraButton1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 410)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UberS Proxy Changer V1.1"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.HuraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As UberS_Proxy_Changer.HuraForm
    Friend WithEvents HuraButton1 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents HuraGroupBox1 As UberS_Proxy_Changer.HuraGroupBox
    Friend WithEvents HuraButton2 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents HuraButton3 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents HuraButton4 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents HuraButton5 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents HuraTextBox1 As UberS_Proxy_Changer.HuraTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HuraButton6 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents HuraButton7 As UberS_Proxy_Changer.HuraButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
