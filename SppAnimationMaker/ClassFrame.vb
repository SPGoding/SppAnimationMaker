Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ClassFrame
    Public Image As Image
    Public Time As Int32
    Public Index As Int32

    Public Sub New()
        Time = Form1.UpDownFrametime.Value
        Index = Form1.FramesCount - 1
    End Sub

    Public Function GetJson() As String
        Dim Result As String
        If Time <> Form1.UpDownFrametime.Value Then
            Result = "{"
            Result &= Chr(34) & "time" & Chr(34) & ":" & Time & ","
            Result &= Chr(34) & "index" & Chr(34) & ":" & Index
            Result &= "}"
        Else
            Result = Index
        End If
        Return Result
    End Function
    Public Sub SetFromJson(Json As String)
        If IsNumeric(Json) Then
            Index = Json
        Else
            Dim JO As JObject = JsonConvert.DeserializeObject(Json)
            If JO.Item("index") IsNot Nothing Then
                Index = JO.Item("index").ToString
            End If
            If JO.Item("time") IsNot Nothing Then
                Time = JO.Item("time").ToString
            End If
        End If
    End Sub
    Public Sub SetFromForm()
        Image = Form1.PictureBoxView.Image
        Time = Form1.UpDownTime.Value
    End Sub
End Class
