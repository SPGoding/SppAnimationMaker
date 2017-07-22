Imports System.Drawing.Imaging
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports vb = Microsoft.VisualBasic

Public Class Form1
    Private Frames(127) As ClassFrame
    Public FramesCount As Int16
    Private OldSelectedFrame As Int16 = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(Application.StartupPath & "\Newtonsoft.Json.dll") Then
            MessageBox.Show("为什么要删掉'Newtonsoft.Json.dll'文件QwQ 软件坏掉了啦！")
            End
        End If
    End Sub

    Private Sub SelectResourcePackPath(sender As Object, e As EventArgs) Handles ButtonSelectResourcePack.Click
        Try
            If Directory.Exists(TextBoxResoucePackPath.Text) Then
                ' 把路径定位到 TextBox
                FolderBrowserDialog1.SelectedPath = TextBoxResoucePackPath.Text
            Else
                ' 把路径定位到正版的资源包文件夹
                If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\resourcepacks") Then
                    FolderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\resourcepacks"
                End If
            End If
            Dim TempDialogResult As DialogResult = FolderBrowserDialog1.ShowDialog()
            If TempDialogResult = DialogResult.OK Then
                ' UI
                TextBoxResoucePackPath.Text = FolderBrowserDialog1.SelectedPath
                GroupBoxSelectPng.Visible = True
                ' 获取方块们
                For Each BlockPng As String In BlockPngs
                    ListBoxPngs.Items.Add("[方块]" & BlockPng)
                Next
                ' 获取物品们
                For Each ItemPng As String In ItemPngs
                    ListBoxPngs.Items.Add("[物品]" & ItemPng)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("选择错误: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchItemsInListBoxPngs(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        ListBoxPngs.Items.Clear()
        If TextBoxSearch.Text <> "" Then
            ' 搜索 ListBoxPngs 的内容
            For Each BlockPng As String In BlockPngs
                If BlockPng.Replace(TextBoxSearch.Text, "") <> BlockPng Then
                    ListBoxPngs.Items.Add("[方块]" & BlockPng)
                End If
            Next
            For Each ItemPng As String In ItemPngs
                If ItemPng.Replace(TextBoxSearch.Text, "") <> ItemPng Then
                    ListBoxPngs.Items.Add("[物品]" & ItemPng)
                End If
            Next
        Else
            ' 获取方块们
            For Each BlockPng As String In BlockPngs
                ListBoxPngs.Items.Add("[方块]" & BlockPng)
            Next
            ' 获取物品们
            For Each ItemPng As String In ItemPngs
                ListBoxPngs.Items.Add("[物品]" & ItemPng)
            Next
        End If
    End Sub

    Private Sub ResetEdit(Optional All As Boolean = False)
        If All Then
            ListBoxFrames.Items.Clear()
            For i = 0 To UBound(Frames)
                Frames(i) = Nothing
            Next
            FramesCount = 0
            UpDownFrametime.Value = 1
            ButtonDel.Enabled = False
            InterpolateT.Checked = False
            InterpolateF.Checked = True
            UpDownTime.Enabled = False
            PictureBoxView.Enabled = False
            OldSelectedFrame = -1
            ComboBoxSize.Enabled = True
        End If
        UpDownTime.Value = 1
        PictureBoxView.Image = Nothing
    End Sub

    Private Sub Read(sender As Object, e As EventArgs) Handles ListBoxPngs.SelectedIndexChanged
        Try
            If ListBoxPngs.SelectedIndex >= 0 Then
                ' UI
                GroupBoxEdit.Visible = True
                ' 读取帧
                Dim FilePath As String
                If vb.Left(ListBoxPngs.SelectedItem.ToString, 4) = "[方块]" Then
                    FilePath = TextBoxResoucePackPath.Text & "\assets\minecraft\textures\blocks\" & vb.Right(ListBoxPngs.SelectedItem.ToString, ListBoxPngs.SelectedItem.ToString.Length - 4)
                Else
                    FilePath = TextBoxResoucePackPath.Text & "\assets\minecraft\textures\items\" & vb.Right(ListBoxPngs.SelectedItem.ToString, ListBoxPngs.SelectedItem.ToString.Length - 4)
                End If
                ResetEdit(True)
                If File.Exists(FilePath) Then
                    If File.Exists(FilePath & ".mcmeta") Then
                        ' 是动态材质
                        ' 读取 .mcmeta
                        Dim StrJson As String = File.ReadAllText(FilePath & ".mcmeta")
                        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
                        If ObjJson.Item("animation") IsNot Nothing Then
                            If ObjJson.Item("animation").Item("interpolate") IsNot Nothing Then
                                If ObjJson.Item("animation").Item("interpolate").ToString Then
                                    InterpolateT.Checked = True
                                Else
                                    InterpolateF.Checked = True
                                End If
                            End If
                            If ObjJson.Item("animation").Item("frametime") IsNot Nothing Then
                                UpDownFrametime.Value = ObjJson.Item("animation").Item("frametime").ToString
                            End If
                            If ObjJson.Item("animation").Item("frames") IsNot Nothing Then
                                For i As Int32 = 0 To ObjJson.Item("animation").Item("frames").Count - 1
                                    ListBoxFrames.Items.Add(i)
                                    Frames(i) = New ClassFrame
                                    Frames(i).SetFromJson(ObjJson.Item("animation").Item("frames").Item(i).ToString)
                                    FramesCount += 1
                                    ' 拆分 .png
                                    Dim Img As Image = Image.FromFile(FilePath)
                                    ComboBoxSize.Text = Img.Width & "x"
                                    Dim BM As New Bitmap(Img.Width, Img.Width)
                                    Dim GR As Graphics = Graphics.FromImage(BM)
                                    GR.DrawImage(Img, 0, 0, New Rectangle(0, i * BM.Height, BM.Height, BM.Height), GraphicsUnit.Pixel)
                                    Frames(i).Image = BM
                                    GR.Dispose()
                                Next
                            End If
                        End If
                    Else
                        ' 不是动态材质，自动加上第一帧
                        ListBoxFrames.Items.Add("0")
                        Frames(0) = New ClassFrame
                        Dim Img As Image = Image.FromFile(FilePath)
                        If Img.Width = Img.Height Then
                            ' 图片宽高一致
                            Frames(0).Image = Img
                            Select Case Img.Width
                                Case 1 To 24
                                    ComboBoxSize.Text = "16x"
                                Case 25 To 48
                                    ComboBoxSize.Text = "32x"
                                Case 49 To 96
                                    ComboBoxSize.Text = "64x"
                                Case 97 To 192
                                    ComboBoxSize.Text = "128x"
                                Case 193 To 384
                                    ComboBoxSize.Text = "256x"
                                Case 385 To 768
                                    ComboBoxSize.Text = "512x"
                                Case 769 To 1536
                                    ComboBoxSize.Text = "1024x"
                                Case 1537 To 3072
                                    ComboBoxSize.Text = "2048x"
                                Case 3073 To 6144
                                    ComboBoxSize.Text = "4096x"
                            End Select
                        Else
                            ResetEdit(True)
                        End If
                        FramesCount += 1
                    End If
                Else
                    ComboBoxSize.Text = "16x"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("读取错误: " & ex.Message)
        End Try
    End Sub

    Private Sub AddFrame_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        FramesCount += 1
        Frames(FramesCount - 1) = New ClassFrame
        ListBoxFrames.Items.Add(FramesCount - 1)
        ListBoxFrames.SelectedIndex = ListBoxFrames.Items.Count - 1
    End Sub
    Private Sub DelFrame_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If ListBoxFrames.SelectedIndex >= 0 Then
            Dim TempSelected As Int16 = ListBoxFrames.SelectedIndex
            For i = ListBoxFrames.SelectedIndex To ListBoxFrames.Items.Count - 1
                If i + 1 <= ListBoxFrames.Items.Count - 1 Then
                    ' 不是最后一帧
                    If IsNothing(Frames(i)) Then
                        Frames(i) = New ClassFrame
                    End If
                    Frames(i).Image = Frames(i + 1).Image
                    Frames(i).Time = Frames(i + 1).Time
                    Frames(i).Index = i
                    Frames(i + 1) = Nothing
                Else
                    Frames(i) = Nothing
                End If
            Next
            ListBoxFrames.Items.RemoveAt(ListBoxFrames.Items.Count - 1)
            If ListBoxFrames.Items.Count - 1 >= TempSelected Then
                ListBoxFrames.SelectedIndex = TempSelected
            Else
                ListBoxFrames.SelectedIndex = ListBoxFrames.Items.Count - 1
            End If
            If OldSelectedFrame = TempSelected Then
                OldSelectedFrame = -1
            End If
            FramesCount -= 1
            RefreshEdit()
        End If
    End Sub
    Private Sub RefreshEdit()
        Try
            ResetEdit()
            If ListBoxFrames.SelectedIndex >= 0 Then
                If Frames(ListBoxFrames.SelectedIndex) IsNot Nothing Then
                    UpDownTime.Value = Frames(ListBoxFrames.SelectedIndex).Time
                    PictureBoxView.Image = Frames(ListBoxFrames.SelectedIndex).Image
                End If
            Else
                ComboBoxSize.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("刷新错误: " & ex.Message)
        End Try
    End Sub
    Private Sub ListBoxFrames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFrames.SelectedIndexChanged
        If ListBoxFrames.SelectedIndex >= 0 Then
            ' UI
            ButtonDel.Enabled = True
            UpDownTime.Enabled = True
            PictureBoxView.Enabled = True
            ' 保存当前 Frame
            If OldSelectedFrame >= 0 Then
                If Frames(OldSelectedFrame) IsNot Nothing Then
                    Frames(OldSelectedFrame).SetFromForm()
                End If
            End If
            OldSelectedFrame = ListBoxFrames.SelectedIndex
            ' 读取 Frame 内容
            RefreshEdit()
        Else
            ' UI
            ButtonDel.Enabled = False
            UpDownTime.Enabled = False
            PictureBoxView.Enabled = False
        End If
    End Sub

    Private Sub SelectImage() Handles PictureBoxView.Click
        With OpenFileDialog1
            .Filter = "png图片文件|*.png"
            .Title = "选择该帧的图片"
            Dim Result As DialogResult = .ShowDialog()
            If Result = DialogResult.OK Then
                Try
                    Dim Img As Image = Image.FromFile(.FileName)
                    PictureBoxView.Image = Img
                Catch ex As Exception
                    MessageBox.Show("图片读取错误: " & ex.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub Save(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            If ListBoxFrames.SelectedIndex >= 0 Then
                Frames(ListBoxFrames.SelectedIndex).SetFromForm()
            End If
            ' 错误检测
            For i As Int16 = 0 To UBound(Frames)
                If Frames(i) IsNot Nothing Then
                    If Frames(i).Image Is Nothing Then
                        MessageBox.Show("保存不能: 第" & i & "帧中没有选择图片")
                        Exit Sub
                    End If
                Else
                    If i > 1 Then
                        Exit For
                    Else
                        MessageBox.Show("保存不能: 帧数过少，应当至少超过2帧")
                        Exit Sub
                    End If
                End If
            Next
            ' 写入 .mcmeta
            Dim Result As String
            Result = "{"
            Result &= Chr(34) & "animation" & Chr(34) & ":" & "{"
            If InterpolateT.Checked Then
                Result &= Chr(34) & "interpolate" & Chr(34) & ":true,"
            End If
            If UpDownFrametime.Value <> 1 Then
                Result &= Chr(34) & "frametime" & Chr(34) & ":" & UpDownFrametime.Value & ","
            End If
            Result &= Chr(34) & "frames" & Chr(34) & ":" & "["
            For Each i As ClassFrame In Frames
                If i IsNot Nothing Then
                    Result &= i.GetJson & ","
                End If
            Next
            Result &= "]"
            Result &= "}"
            Result &= "}"
            Result = Result.Replace(",}", "}")
            Result = Result.Replace(",]", "]")
            Dim JO As JObject = CType(JsonConvert.DeserializeObject(Result), JObject)
            Result = JO.ToString
            Dim FilePath As String
            If vb.Left(ListBoxPngs.SelectedItem.ToString, 4) = "[方块]" Then
                FilePath = TextBoxResoucePackPath.Text & "\assets\minecraft\textures\blocks\" & vb.Right(ListBoxPngs.SelectedItem.ToString, ListBoxPngs.SelectedItem.ToString.Length - 4)
            Else
                FilePath = TextBoxResoucePackPath.Text & "\assets\minecraft\textures\items\" & vb.Right(ListBoxPngs.SelectedItem.ToString, ListBoxPngs.SelectedItem.ToString.Length - 4)
            End If
            ' 覆盖提示
            If File.Exists(FilePath) Then
                Dim DialogResult As DialogResult = MessageBox.Show(Me, "该材质已存在，是否覆盖", "提示", MessageBoxButtons.YesNo)
                If DialogResult = DialogResult.No Then
                    Exit Sub
                End If
            End If
            ' 建立路径
            If Not Directory.Exists(GetParentPath(FilePath)) Then
                MkDir(GetParentPath(FilePath))
            End If
            File.WriteAllText(FilePath & ".mcmeta", Result)
            ' 写入 .png
            Dim Img As Image = MergeImages(Frames(0).Image, Frames(1).Image, vb.Left(ComboBoxSize.Text, ComboBoxSize.Text.Length - 1))
            For i As Int16 = 2 To UBound(Frames)
                If Frames(i) IsNot Nothing Then
                    Img = MergeImages(Img, Frames(i).Image, vb.Left(ComboBoxSize.Text, ComboBoxSize.Text.Length - 1))
                Else
                    Exit For
                End If
            Next
            Img.Save(FilePath, Img.RawFormat)
        Catch ex As Exception
            MessageBox.Show("生成错误: " & ex.Message)
        End Try
    End Sub

    Private Sub UpDownFrametime_TextChanged(sender As Object, e As EventArgs) Handles UpDownFrametime.TextChanged
        LabelFrameTime.Text = "(" & UpDownFrametime.Value * 0.05 & "s)"
    End Sub
    Private Sub UpDownTime_TextChanged(sender As Object, e As EventArgs) Handles UpDownTime.TextChanged
        LabelTime.Text = "(" & UpDownTime.Value * 0.05 & "s)"
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub ImportFramesFromGif(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGif.LinkClicked
        With OpenFileDialog1
            .Filter = "GIF动画文件|*.gif"
            .Title = "选择一个GIF动画"
            Dim Result As DialogResult = .ShowDialog()
            If Result = DialogResult.OK Then
                Try
                    Dim Gif As Image = Image.FromFile(.FileName)
                    Dim FD As FrameDimension = New FrameDimension(Gif.FrameDimensionsList(0))
                    Dim GifFramesCount As Integer = Gif.GetFrameCount(FD)
                    ' 获取每一帧到帧列表
                    For i As Int32 = 0 To GifFramesCount - 1
                        ' 新建帧 并设置图片
                        FramesCount += 1
                        Frames(FramesCount - 1) = New ClassFrame
                        ListBoxFrames.Items.Add(FramesCount - 1)
                        Gif.SelectActiveFrame(FD, i)
                        Frames(FramesCount - 1).Image = New Bitmap(Gif)
                    Next
                    ListBoxFrames.SelectedIndex = ListBoxFrames.Items.Count - 1
                Catch ex As Exception
                    MessageBox.Show("GIF动画读取错误: " & ex.Message)
                End Try
            End If
        End With
    End Sub

End Class
