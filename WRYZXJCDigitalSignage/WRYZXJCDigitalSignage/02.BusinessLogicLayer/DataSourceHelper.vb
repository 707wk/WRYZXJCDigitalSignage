Imports System.IO
Imports System.Net
''' <summary>
''' 数据源辅助模块
''' </summary>
Public Class DataSourceHelper
    Private Sub New()
    End Sub

    ''' <summary>
    ''' 数据处理线程
    ''' </summary>
    Private Shared WorkThread As Threading.Thread

    ''' <summary>
    ''' 是否运行
    ''' </summary>
    Private Shared _IsRunning As Boolean = False

    ''' <summary>
    ''' 是否运行
    ''' </summary>
    Public Shared ReadOnly Property IsRunning As Boolean
        Get
            Return _IsRunning
        End Get
    End Property

    ''' <summary>
    ''' 主窗体
    ''' </summary>
    Public Shared UIMainForm As MainForm

#Region "开始检测"
    ''' <summary>
    ''' 开始检测
    ''' </summary>
    Public Shared Sub StartAsync()

        If _IsRunning Then
            Exit Sub
        End If
        _IsRunning = True

        WorkThread = New Threading.Thread(AddressOf WorkFunction) With {
            .IsBackground = True
        }
        WorkThread.Start()

    End Sub
#End Region

#Region "停止检测"
    ''' <summary>
    ''' 停止检测
    ''' </summary>
    Public Shared Sub StopAsync()

        If Not _IsRunning Then
            Exit Sub
        End If
        _IsRunning = False

        WorkThread.Join()
        WorkThread = Nothing

    End Sub
#End Region

#Region "检测线程"
    ''' <summary>
    ''' 检测线程
    ''' </summary>
    Private Shared Sub WorkFunction()

        Do
            If Not _IsRunning Then Exit Sub

            Try
                Dim webClient As HtmlAgilityPack.HtmlWeb = New HtmlAgilityPack.HtmlWeb()

#Region "获取标题"
                Dim tmpCookies As New CookieContainer
                Dim doc As New HtmlAgilityPack.HtmlDocument
                Dim request As System.Net.HttpWebRequest = WebRequest.Create($"{AppSettingHelper.Settings.LoginUrl}?userid={AppSettingHelper.Settings.LoginName}&password={AppSettingHelper.Settings.LoginPassword}")
                request.Method = "POST"
                request.ContentType = "application/x-www-form-urlencoded"
                request.CookieContainer = tmpCookies
                '接收数据
                Dim resp As HttpWebResponse = request.GetResponse()

                Dim Stream As Stream = resp.GetResponseStream()
                Using reader As StreamReader = New StreamReader(Stream,
                                                        System.Text.Encoding.UTF8)
                    doc.LoadHtml(reader.ReadToEnd())
                End Using

                Dim titleNode As HtmlAgilityPack.HtmlNode = doc.DocumentNode.SelectSingleNode("//span[@class='user-name']")

                AppSettingHelper.Settings.Title = $"{titleNode.Attributes("title").Value} -- 环保信息公示"
#End Region

#Region "获取企业环保负责人"
                request = WebRequest.Create($"{AppSettingHelper.Settings.QYHBFZRUrl}")
                request.Method = "POST"
                request.ContentType = "application/x-www-form-urlencoded"
                request.CookieContainer = tmpCookies
                '接收数据
                resp = request.GetResponse()

                Stream = resp.GetResponseStream()
                Using reader As StreamReader = New StreamReader(Stream,
                                                        System.Text.Encoding.UTF8)
                    doc.LoadHtml(reader.ReadToEnd())
                End Using

                Dim tableNodes = doc.DocumentNode.SelectNodes("//tr[@id='trid0']/td")

                '负责人
                Dim tmpStr = tableNodes(6).InnerText.Replace(vbTab, "").Replace(vbCrLf, "").Replace("&nbsp;", "")
                AppSettingHelper.Settings.QYHBFZR = tmpStr

                '电话
                tmpStr = tableNodes(7).InnerText.Replace(vbTab, "").Replace(vbCrLf, "").Replace("&nbsp;", "").Replace(" ", "")
                AppSettingHelper.Settings.QYHBFZRMobile = tmpStr
#End Region

#Region "获取检测值"
                request = WebRequest.Create($"{AppSettingHelper.Settings.DataUrl}?JCDLX=FS&JCDXH={AppSettingHelper.Settings.EquipmentJCDXH}")
                request.Method = "POST"
                request.ContentType = "application/x-www-form-urlencoded"
                request.CookieContainer = tmpCookies
                '接收数据
                resp = request.GetResponse()

                Stream = resp.GetResponseStream()
                Using reader As StreamReader = New StreamReader(Stream,
                                                        System.Text.Encoding.UTF8)
                    doc.LoadHtml(reader.ReadToEnd())
                End Using

                '排污口编号
                titleNode = doc.DocumentNode.SelectSingleNode("//div[@id='div_btn']/h1")
                Dim titleStr = titleNode.InnerText
                AppSettingHelper.Settings.EquipmentPWKBH = titleStr.Substring(titleStr.LastIndexOf("(") + 1).Replace(")", "")

                tableNodes = doc.DocumentNode.SelectNodes("//tr[@id='trid0']/td")

                '更新时间
                Dim tmpDate = Convert.ToDateTime(tableNodes(0).InnerText.Replace(vbTab, "").Replace(vbCrLf, "").Replace("&nbsp;", ""))
                AppSettingHelper.Settings.LastReadTime = tmpDate

                '瞬时流量
                Dim tmpDouble = CDbl(tableNodes(1).InnerText.Replace(vbTab, "").Replace(vbCrLf, "").Replace("&nbsp;", "").Replace(" ", ""))
                AppSettingHelper.Settings.SSLL = tmpDouble

                '污染物数值
                For i001 = 2 To 7 - 1
                    tmpDouble = CDbl(tableNodes(i001).InnerText.Replace(vbTab, "").Replace(vbCrLf, "").Replace("&nbsp;", "").Replace(" ", ""))
                    AppSettingHelper.Settings.DetectionInfoItems(i001 - 2).Value = tmpDouble
                Next

#End Region

                UIMainForm.ForceRefresh()
                'Debug.WriteLine(Now.ToString)

#Disable Warning CA1031 ' Do not catch general exception types
            Catch ex As Exception
#Enable Warning CA1031 ' Do not catch general exception types
            End Try

            For i001 = 0 To AppSettingHelper.Settings.pollingIntervalSec
                If Not _IsRunning Then Exit Sub
                Threading.Thread.Sleep(1000)
            Next

        Loop

    End Sub
#End Region

End Class
