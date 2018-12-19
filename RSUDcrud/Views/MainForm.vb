Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class MainForm
    Private Sub btnPASIEN_Click(sender As Object, e As EventArgs) Handles btnPASIEN.Click
        MainPasien.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainPegawai.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim jsonString As String = "{""id"":1, ""nama"":""Sugandi""}"
        Dim jsonObject As JObject = JObject.Parse(jsonString)
        MsgBox(jsonObject.SelectToken("nama").ToString)
        Console.WriteLine("id:" & jsonObject.SelectToken("id").ToString)
        Console.WriteLine("nama:" & jsonObject.SelectToken("nama").ToString)
    End Sub
End Class