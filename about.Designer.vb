<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        version = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(303, 221)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 37)
        Button1.TabIndex = 0
        Button1.Text = "关闭"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 24)
        Label1.TabIndex = 1
        Label1.Text = "幸运鹅-重制"
        ' 
        ' version
        ' 
        version.AutoSize = True
        version.Location = New Point(29, 50)
        version.Name = "version"
        version.Size = New Size(58, 20)
        version.TabIndex = 2
        version.Text = "V 0.0.0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(353, 40)
        Label3.TabIndex = 3
        Label3.Text = "重制的幸运鹅，优化了外观，修了奇奇怪怪的bug，" & vbCrLf & "增加了一些功能。"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(29, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 20)
        Label4.TabIndex = 4
        Label4.Text = "本程序遵循 GPL-3.0 协议"
        ' 
        ' about
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 270)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(version)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "about"
        StartPosition = FormStartPosition.Manual
        Text = "关于 幸运鹅-重制"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents version As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
