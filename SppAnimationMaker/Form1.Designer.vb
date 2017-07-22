<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxResoucePackPath = New System.Windows.Forms.TextBox()
        Me.ButtonSelectResourcePack = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBoxSelectPath = New System.Windows.Forms.GroupBox()
        Me.ListBoxPngs = New System.Windows.Forms.ListBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBoxSelectPng = New System.Windows.Forms.GroupBox()
        Me.GroupBoxEdit = New System.Windows.Forms.GroupBox()
        Me.LinkLabelGif = New System.Windows.Forms.LinkLabel()
        Me.InterpolateF = New System.Windows.Forms.RadioButton()
        Me.InterpolateT = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxSize = New System.Windows.Forms.ComboBox()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.UpDownTime = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxView = New System.Windows.Forms.PictureBox()
        Me.LabelFrameTime = New System.Windows.Forms.Label()
        Me.UpDownFrametime = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxFrames = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxSelectPath.SuspendLayout()
        Me.GroupBoxSelectPng.SuspendLayout()
        Me.GroupBoxEdit.SuspendLayout()
        CType(Me.UpDownTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpDownFrametime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxResoucePackPath
        '
        Me.TextBoxResoucePackPath.Location = New System.Drawing.Point(23, 25)
        Me.TextBoxResoucePackPath.Name = "TextBoxResoucePackPath"
        Me.TextBoxResoucePackPath.ReadOnly = True
        Me.TextBoxResoucePackPath.Size = New System.Drawing.Size(595, 26)
        Me.TextBoxResoucePackPath.TabIndex = 1
        '
        'ButtonSelectResourcePack
        '
        Me.ButtonSelectResourcePack.Location = New System.Drawing.Point(624, 26)
        Me.ButtonSelectResourcePack.Name = "ButtonSelectResourcePack"
        Me.ButtonSelectResourcePack.Size = New System.Drawing.Size(27, 25)
        Me.ButtonSelectResourcePack.TabIndex = 2
        Me.ButtonSelectResourcePack.Text = "···"
        Me.ButtonSelectResourcePack.UseVisualStyleBackColor = True
        '
        'GroupBoxSelectPath
        '
        Me.GroupBoxSelectPath.Controls.Add(Me.ButtonSelectResourcePack)
        Me.GroupBoxSelectPath.Controls.Add(Me.TextBoxResoucePackPath)
        Me.GroupBoxSelectPath.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxSelectPath.Name = "GroupBoxSelectPath"
        Me.GroupBoxSelectPath.Size = New System.Drawing.Size(657, 61)
        Me.GroupBoxSelectPath.TabIndex = 5
        Me.GroupBoxSelectPath.TabStop = False
        Me.GroupBoxSelectPath.Text = "请选择资源包路径(暂只支持文件夹形式)"
        '
        'ListBoxPngs
        '
        Me.ListBoxPngs.HorizontalScrollbar = True
        Me.ListBoxPngs.IntegralHeight = False
        Me.ListBoxPngs.ItemHeight = 20
        Me.ListBoxPngs.Location = New System.Drawing.Point(23, 57)
        Me.ListBoxPngs.Name = "ListBoxPngs"
        Me.ListBoxPngs.Size = New System.Drawing.Size(216, 391)
        Me.ListBoxPngs.Sorted = True
        Me.ListBoxPngs.TabIndex = 0
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(23, 25)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(216, 26)
        Me.TextBoxSearch.TabIndex = 2
        '
        'GroupBoxSelectPng
        '
        Me.GroupBoxSelectPng.Controls.Add(Me.ListBoxPngs)
        Me.GroupBoxSelectPng.Controls.Add(Me.TextBoxSearch)
        Me.GroupBoxSelectPng.Location = New System.Drawing.Point(12, 79)
        Me.GroupBoxSelectPng.Name = "GroupBoxSelectPng"
        Me.GroupBoxSelectPng.Size = New System.Drawing.Size(245, 454)
        Me.GroupBoxSelectPng.TabIndex = 6
        Me.GroupBoxSelectPng.TabStop = False
        Me.GroupBoxSelectPng.Text = "请选择要制作成动态材质的材质"
        Me.GroupBoxSelectPng.Visible = False
        '
        'GroupBoxEdit
        '
        Me.GroupBoxEdit.Controls.Add(Me.LinkLabelGif)
        Me.GroupBoxEdit.Controls.Add(Me.InterpolateF)
        Me.GroupBoxEdit.Controls.Add(Me.InterpolateT)
        Me.GroupBoxEdit.Controls.Add(Me.Label3)
        Me.GroupBoxEdit.Controls.Add(Me.ComboBoxSize)
        Me.GroupBoxEdit.Controls.Add(Me.ButtonDel)
        Me.GroupBoxEdit.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxEdit.Controls.Add(Me.ButtonSave)
        Me.GroupBoxEdit.Controls.Add(Me.LabelTime)
        Me.GroupBoxEdit.Controls.Add(Me.UpDownTime)
        Me.GroupBoxEdit.Controls.Add(Me.Label4)
        Me.GroupBoxEdit.Controls.Add(Me.PictureBoxView)
        Me.GroupBoxEdit.Controls.Add(Me.LabelFrameTime)
        Me.GroupBoxEdit.Controls.Add(Me.UpDownFrametime)
        Me.GroupBoxEdit.Controls.Add(Me.Label2)
        Me.GroupBoxEdit.Controls.Add(Me.Label1)
        Me.GroupBoxEdit.Controls.Add(Me.ListBoxFrames)
        Me.GroupBoxEdit.Location = New System.Drawing.Point(263, 79)
        Me.GroupBoxEdit.Name = "GroupBoxEdit"
        Me.GroupBoxEdit.Size = New System.Drawing.Size(405, 454)
        Me.GroupBoxEdit.TabIndex = 7
        Me.GroupBoxEdit.TabStop = False
        Me.GroupBoxEdit.Text = "请对选中的材质进行编辑"
        Me.GroupBoxEdit.Visible = False
        '
        'LinkLabelGif
        '
        Me.LinkLabelGif.AutoSize = True
        Me.LinkLabelGif.Location = New System.Drawing.Point(280, 82)
        Me.LinkLabelGif.Name = "LinkLabelGif"
        Me.LinkLabelGif.Size = New System.Drawing.Size(114, 20)
        Me.LinkLabelGif.TabIndex = 23
        Me.LinkLabelGif.TabStop = True
        Me.LinkLabelGif.Text = "从GIF图片导入帧"
        '
        'InterpolateF
        '
        Me.InterpolateF.AutoSize = True
        Me.InterpolateF.Checked = True
        Me.InterpolateF.Location = New System.Drawing.Point(255, 48)
        Me.InterpolateF.Name = "InterpolateF"
        Me.InterpolateF.Size = New System.Drawing.Size(41, 24)
        Me.InterpolateF.TabIndex = 22
        Me.InterpolateF.TabStop = True
        Me.InterpolateF.Text = "否"
        Me.InterpolateF.UseVisualStyleBackColor = True
        '
        'InterpolateT
        '
        Me.InterpolateT.AutoSize = True
        Me.InterpolateT.Location = New System.Drawing.Point(208, 48)
        Me.InterpolateT.Name = "InterpolateT"
        Me.InterpolateT.Size = New System.Drawing.Size(41, 24)
        Me.InterpolateT.TabIndex = 21
        Me.InterpolateT.Text = "是"
        Me.InterpolateT.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "在两帧中生成帧"
        '
        'ComboBoxSize
        '
        Me.ComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSize.FormattingEnabled = True
        Me.ComboBoxSize.IntegralHeight = False
        Me.ComboBoxSize.Items.AddRange(New Object() {"16x", "32x", "64x", "128x", "256x", "512x", "1024x", "2048x", "4096x"})
        Me.ComboBoxSize.Location = New System.Drawing.Point(169, 413)
        Me.ComboBoxSize.MaxDropDownItems = 4
        Me.ComboBoxSize.Name = "ComboBoxSize"
        Me.ComboBoxSize.Size = New System.Drawing.Size(98, 28)
        Me.ComboBoxSize.TabIndex = 19
        '
        'ButtonDel
        '
        Me.ButtonDel.Enabled = False
        Me.ButtonDel.Location = New System.Drawing.Point(79, 108)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(54, 32)
        Me.ButtonDel.TabIndex = 17
        Me.ButtonDel.Text = "-"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(24, 108)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(54, 32)
        Me.ButtonAdd.TabIndex = 16
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(279, 405)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(116, 43)
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "保存当前材质"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(328, 369)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(66, 20)
        Me.LabelTime.TabIndex = 13
        Me.LabelTime.Text = "刻(0.05s)"
        '
        'UpDownTime
        '
        Me.UpDownTime.Enabled = False
        Me.UpDownTime.Location = New System.Drawing.Point(264, 367)
        Me.UpDownTime.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.UpDownTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UpDownTime.Name = "UpDownTime"
        Me.UpDownTime.Size = New System.Drawing.Size(58, 26)
        Me.UpDownTime.TabIndex = 12
        Me.UpDownTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "当前帧的显示时间: "
        '
        'PictureBoxView
        '
        Me.PictureBoxView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxView.Enabled = False
        Me.PictureBoxView.Location = New System.Drawing.Point(139, 105)
        Me.PictureBoxView.Name = "PictureBoxView"
        Me.PictureBoxView.Size = New System.Drawing.Size(256, 256)
        Me.PictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxView.TabIndex = 10
        Me.PictureBoxView.TabStop = False
        '
        'LabelFrameTime
        '
        Me.LabelFrameTime.AutoSize = True
        Me.LabelFrameTime.Location = New System.Drawing.Point(104, 48)
        Me.LabelFrameTime.Name = "LabelFrameTime"
        Me.LabelFrameTime.Size = New System.Drawing.Size(52, 20)
        Me.LabelFrameTime.TabIndex = 6
        Me.LabelFrameTime.Text = "(0.05s)"
        '
        'UpDownFrametime
        '
        Me.UpDownFrametime.Location = New System.Drawing.Point(40, 46)
        Me.UpDownFrametime.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.UpDownFrametime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UpDownFrametime.Name = "UpDownFrametime"
        Me.UpDownFrametime.Size = New System.Drawing.Size(58, 26)
        Me.UpDownFrametime.TabIndex = 5
        Me.UpDownFrametime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "每一帧的显示时间(刻)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "帧列表"
        '
        'ListBoxFrames
        '
        Me.ListBoxFrames.HorizontalScrollbar = True
        Me.ListBoxFrames.IntegralHeight = False
        Me.ListBoxFrames.ItemHeight = 20
        Me.ListBoxFrames.Location = New System.Drawing.Point(24, 146)
        Me.ListBoxFrames.Name = "ListBoxFrames"
        Me.ListBoxFrames.Size = New System.Drawing.Size(109, 247)
        Me.ListBoxFrames.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 547)
        Me.Controls.Add(Me.GroupBoxEdit)
        Me.Controls.Add(Me.GroupBoxSelectPng)
        Me.Controls.Add(Me.GroupBoxSelectPath)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "动态材质制作者"
        Me.GroupBoxSelectPath.ResumeLayout(False)
        Me.GroupBoxSelectPath.PerformLayout()
        Me.GroupBoxSelectPng.ResumeLayout(False)
        Me.GroupBoxSelectPng.PerformLayout()
        Me.GroupBoxEdit.ResumeLayout(False)
        Me.GroupBoxEdit.PerformLayout()
        CType(Me.UpDownTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpDownFrametime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxResoucePackPath As TextBox
    Friend WithEvents ButtonSelectResourcePack As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBoxSelectPath As GroupBox
    Friend WithEvents ListBoxPngs As ListBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents GroupBoxSelectPng As GroupBox
    Friend WithEvents GroupBoxEdit As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxFrames As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelFrameTime As Label
    Friend WithEvents UpDownFrametime As NumericUpDown
    Friend WithEvents PictureBoxView As PictureBox
    Friend WithEvents LabelTime As Label
    Friend WithEvents UpDownTime As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComboBoxSize As ComboBox
    Friend WithEvents InterpolateF As RadioButton
    Friend WithEvents InterpolateT As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabelGif As LinkLabel
End Class
