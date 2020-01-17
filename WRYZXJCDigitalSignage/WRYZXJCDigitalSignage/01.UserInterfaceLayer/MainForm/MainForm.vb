Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "产品版本号"
        Me.Text = $"{My.Application.Info.Description} V{AppSettingHelper.ProductVersion}"
#End Region

        'Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width \ 2, Screen.PrimaryScreen.Bounds.Height \ 2)
        Me.BackColor = Color.Black
        Me.DoubleBuffered = True
        'Me.TopMost = True

        TaskBarIcon.Text = Me.Text
        TaskBarIcon.ContextMenuStrip = TaskBarMenu

        DataSourceHelper.UIMainForm = Me

        'StringFormatNear.Alignment = StringAlignment.Near
        StringFormatCenter.Alignment = StringAlignment.Center
        StringFormatFar.Alignment = StringAlignment.Far

        DataSourceHelper.StartAsync()

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Interval = AppSettingHelper.Settings.ShowSec * 1000
        Timer1.Start()
        Me.Refresh()
    End Sub

#Region "数据绘制"
    '画笔
    Private Shared ReadOnly BorderPen = New Pen(Color.Red) '248, 122, 116))
    Private Shared ReadOnly FontSolidBrush = New SolidBrush(Color.Red) '248, 122, 116))
    'Private Shared ReadOnly StringFormatNear As New StringFormat()
    Private Shared ReadOnly StringFormatCenter As New StringFormat()
    Private Shared ReadOnly StringFormatFar As New StringFormat()

    Private Shared RowHeight As Integer = 21
    Private Shared RowsWidthItems As Integer() = {
    3 + 50,'检测指标
    3 + 50 + 54,'监测值
    3 + 50 + 54 + 44 \ 2,'单位
    3 + 50 + 54 + 44 + 54 \ 2,'浓度限值
    3 + 50 + 54 + 44 + 54 + 44 \ 2,'单位
    3 + 50 + 54 + 44 + 54 + 44 + 36 \ 2,'状态
    3 + 50 + 54 + 44 + 54 + 44 + 36 + 54 \ 2,'瞬时流量
    3 + 50 + 54 + 44 + 54 + 44 + 36 + 54 + 44 \ 2'单位
    }

    Private Sub MainForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.Clear(Color.Black)

        If AppSettingHelper.Settings.ShowID = 0 Then
            '绘制首页

#Region "绘制线条"
            e.Graphics.DrawRectangle(BorderPen, 0, 0, Me.Width - 1, Me.Height - 1)
            For i001 = RowHeight + 3 To Me.Height - 2 Step RowHeight
                e.Graphics.DrawLine(BorderPen, 0, i001, Me.Width - 1, i001)
            Next
            e.Graphics.DrawLine(BorderPen, Me.Width \ 2 - 2, 3 + RowHeight * 1, Me.Width \ 2 - 2, 3 + RowHeight * 2)

            For i001 = 0 To AppSettingHelper.Settings.DetectionInfoItems.Count
                e.Graphics.DrawLine(BorderPen,
                               RowsWidthItems(2) + 44 \ 2 - 1 + 40 * i001,
                                3 + RowHeight * 3,
                                RowsWidthItems(2) + 44 \ 2 - 1 + 40 * i001,
                                3 + RowHeight * 5)

                If i001 < AppSettingHelper.Settings.DetectionInfoItems.Count Then
                    Dim item = AppSettingHelper.Settings.DetectionInfoItems(i001)
                    e.Graphics.DrawString($"{item.Name}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(2) + 44 \ 2 - 1 + 40 * i001 + 40 \ 2,
                                      RowHeight * 3 + RowHeight \ 2 - 2, StringFormatCenter)
                    e.Graphics.DrawString($"{If(item.SumOfYear > 0, item.SumOfYear, "/")}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(2) + 44 \ 2 - 1 + 40 * i001 + 40 \ 2,
                                      RowHeight * 4 + RowHeight \ 2 - 2, StringFormatCenter)
                End If

            Next

            e.Graphics.DrawLine(BorderPen, RowsWidthItems(0) + 1, 3 + RowHeight * 5, RowsWidthItems(0) + 1, 3 + RowHeight * 11)
            e.Graphics.DrawLine(BorderPen, RowsWidthItems(1) + 1, 3 + RowHeight * 5, RowsWidthItems(1) + 1, 3 + RowHeight * 11)
            e.Graphics.DrawLine(BorderPen,
                                RowsWidthItems(2) + 44 \ 2 - 1,
                                3 + RowHeight * 5,
                                RowsWidthItems(2) + 44 \ 2 - 1,
                                3 + RowHeight * 11)
            e.Graphics.DrawLine(BorderPen,
                                RowsWidthItems(3) + 54 \ 2 - 1,
                                3 + RowHeight * 5,
                                RowsWidthItems(3) + 54 \ 2 - 1,
                                3 + RowHeight * 11)
            e.Graphics.DrawLine(BorderPen,
                                RowsWidthItems(4) + 44 \ 2 - 1,
                                3 + RowHeight * 5,
                                RowsWidthItems(4) + 44 \ 2 - 1,
                                3 + RowHeight * 11)
            e.Graphics.DrawLine(BorderPen,
                                RowsWidthItems(5) + 36 \ 2 - 1,
                                3 + RowHeight * 5,
                                RowsWidthItems(5) + 36 \ 2 - 1,
                                3 + RowHeight * 11)
            e.Graphics.DrawLine(BorderPen,
                                RowsWidthItems(6) + 54 \ 2 - 1,
                                3 + RowHeight * 5,
                                RowsWidthItems(6) + 54 \ 2 - 1,
                                3 + RowHeight * 11)
#End Region

#Region "绘制表头"
            e.Graphics.DrawString(AppSettingHelper.Settings.Title,
                                  Me.Font,
                                  FontSolidBrush,
                                  Me.Width \ 2,
                                  RowHeight \ 2 - 3, StringFormatCenter)

            e.Graphics.DrawString($"排污口编号: {AppSettingHelper.Settings.EquipmentPWKBH}",
                                      Me.Font,
                                      FontSolidBrush,
                                      1,
                                      RowHeight + RowHeight \ 2 - 2)
            e.Graphics.DrawString($"监测时间: {AppSettingHelper.Settings.LastReadTime.ToString}",
                                      Me.Font,
                                      FontSolidBrush,
                                      Me.Width \ 2,
                                      RowHeight + RowHeight \ 2 - 2)

            e.Graphics.DrawString($"企业环保负责人及联系电话: {AppSettingHelper.Settings.QYHBFZR} {AppSettingHelper.Settings.QYHBFZRMobile}",
                                  Me.Font,
                                      FontSolidBrush,
                                      1,
                                      RowHeight * 2 + RowHeight \ 2 - 2)

            e.Graphics.DrawString($"污染物名称",
                                  Me.Font,
                                      FontSolidBrush,
                                      1,
                                      RowHeight * 3 + RowHeight \ 2 - 2)
            e.Graphics.DrawString($"核定的排放总量(吨/年)",
                                  Me.Font,
                                      FontSolidBrush,
                                      1,
                                      RowHeight * 4 + RowHeight \ 2 - 2)
#End Region

#Region "绘制监测值"
            e.Graphics.DrawString($"监测指标", Me.Font, FontSolidBrush, RowsWidthItems(0), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatFar)
            e.Graphics.DrawString($"监测值", Me.Font, FontSolidBrush, RowsWidthItems(1), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatFar)
            e.Graphics.DrawString($"单位", Me.Font, FontSolidBrush, RowsWidthItems(2), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatCenter)
            e.Graphics.DrawString($"浓度限值", Me.Font, FontSolidBrush, RowsWidthItems(3), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatCenter)
            e.Graphics.DrawString($"单位", Me.Font, FontSolidBrush, RowsWidthItems(4), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatCenter)
            e.Graphics.DrawString($"状态", Me.Font, FontSolidBrush, RowsWidthItems(5), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatCenter)
            e.Graphics.DrawString($"瞬时流量", Me.Font, FontSolidBrush, RowsWidthItems(6), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatCenter)
            e.Graphics.DrawString($"单位", Me.Font, FontSolidBrush, RowsWidthItems(7), RowHeight * 5 + RowHeight \ 2 - 2, StringFormatCenter)

            For i001 = 0 To AppSettingHelper.Settings.DetectionInfoItems.Count - 1
                Dim item = AppSettingHelper.Settings.DetectionInfoItems(i001)
                e.Graphics.DrawString($"{item.Name}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(0),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatFar)
                e.Graphics.DrawString($"{If(AppSettingHelper.Settings.IsForgery,
                                      item.ValueOfForgery.ToString("0.000"),
                                      item.Value.ToString("0.000"))}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(1),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatFar)
                e.Graphics.DrawString($"{item.Unit}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(2),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatCenter)
                e.Graphics.DrawString($"{item.Minimum}-{item.Maximum}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(3),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatCenter)
                e.Graphics.DrawString($"{item.Unit}",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(4),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatCenter)
                e.Graphics.DrawString($"运行",
                                      Me.Font,
                                      FontSolidBrush,
                                       RowsWidthItems(5),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatCenter)
                e.Graphics.DrawString($"{If(AppSettingHelper.Settings.IsForgery,
                                      AppSettingHelper.Settings.SSLLfForgery.ToString("0.000"),
                                      AppSettingHelper.Settings.SSLL.ToString("0.000")) }",
                                          Me.Font,
                                          FontSolidBrush,
                                       RowsWidthItems(6),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatCenter)
                e.Graphics.DrawString($"L/s",
                                          Me.Font,
                                          FontSolidBrush,
                                       RowsWidthItems(7),
                                      i001 * RowHeight + RowHeight * 6 + RowHeight \ 2 - 2, StringFormatCenter)
            Next
#End Region

#Region "绘制结尾"
            e.Graphics.DrawString($"运营单位:{AppSettingHelper.Settings.ZXJCYYWHDW}",
                                Me.Font,
                                      FontSolidBrush,
                                      1,
                                      RowHeight * 11 + RowHeight \ 2 - 2)
            e.Graphics.DrawString($"联系人:{AppSettingHelper.Settings.ZZJCYYFZR} {AppSettingHelper.Settings.ZZJCYYFZRMobile}",
                                   Me.Font,
                                      FontSolidBrush,
                                      Me.Width - 1,
                                      RowHeight * 11 + RowHeight \ 2 - 2, StringFormatFar)
#End Region

        Else
            '绘制图片
            Dim filePath = AppSettingHelper.Settings.ShowImageItems(AppSettingHelper.Settings.ShowID - 1).Path
            If Not IO.File.Exists(filePath) Then
                Exit Sub
            End If
            e.Graphics.DrawImage(New Bitmap(filePath),
                                 0,
                                 0,
                                 Me.Width,
                                 Me.Height)

        End If
    End Sub
#End Region

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Timer1.Stop()
        DataSourceHelper.StopAsync()

        Using tmpDialog As New SettingForm
            If tmpDialog.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            AppSettingHelper.SaveToLocaltion()
            AppSettingHelper.Settings.ShowID = 0
            Timer1.Interval = AppSettingHelper.Settings.ShowSec * 1000

        End Using

        Timer1.Start()
        DataSourceHelper.StartAsync()
        Me.Refresh()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DataSourceHelper.StopAsync()

        AppSettingHelper.SaveToLocaltion()
    End Sub

#Region "更新画面"
    Public Delegate Sub ForceRefreshCallback()
    Public Sub ForceRefresh()
        If Me.InvokeRequired Then
            Me.Invoke(New ForceRefreshCallback(AddressOf ForceRefresh))
            Exit Sub
        End If

        Me.Refresh()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        AppSettingHelper.Settings.ShowID = (AppSettingHelper.Settings.ShowID + 1) Mod (AppSettingHelper.Settings.ShowImageItems.Count + 1)

        Timer1.Stop()
        If AppSettingHelper.Settings.ShowID = 0 Then
            '首页
            Timer1.Interval = AppSettingHelper.Settings.ShowSec * 1000
        Else
            '图片
            Timer1.Interval = AppSettingHelper.Settings.ShowImageItems(AppSettingHelper.Settings.ShowID - 1).ShowSec * 1000
        End If
        Timer1.Start()

        Me.Refresh()
    End Sub
#End Region

End Class