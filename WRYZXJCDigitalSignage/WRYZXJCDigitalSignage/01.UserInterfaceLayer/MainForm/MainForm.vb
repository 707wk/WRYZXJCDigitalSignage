Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "产品版本号"
        Me.Text = $"{My.Application.Info.Description} V{AppSettingHelper.ProductVersion}"
#End Region

        'Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2)
        Me.BackColor = Color.Black
        Me.DoubleBuffered = True
        'Me.TopMost = True

        TaskBarIcon.Text = Me.Text
        TaskBarIcon.ContextMenuStrip = TaskBarMenu

        DataSourceHelper.UIMainForm = Me

        StringFormatNear.Alignment = StringAlignment.Near
        StringFormatCenter.Alignment = StringAlignment.Center
        StringFormatFar.Alignment = StringAlignment.Far

        DataSourceHelper.StartAsync()

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        Me.Refresh()
    End Sub

#Region "数据绘制"
    '画笔
    Private Shared ReadOnly BorderPen = New Pen(Color.Red) '248, 122, 116))
    Private Shared ReadOnly FontSolidBrush = New SolidBrush(Color.Red) '248, 122, 116))
    Private Shared ReadOnly StringFormatNear As New StringFormat()
    Private Shared ReadOnly StringFormatCenter As New StringFormat()
    Private Shared ReadOnly StringFormatFar As New StringFormat()

    Private Shared RowHeight As Integer = 22
    Private Shared RowsWidth = {
        17 + 51,
        17 + 51 + 60,
        17 + 51 + 60 + 30,
        17 + 51 + 60 + 30 + 50,
        17 + 51 + 60 + 30 + 50 + 95}

    Private Sub MainForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.Clear(Color.Black)

#Region "绘制线条"
        e.Graphics.DrawRectangle(BorderPen, 11, 8, Me.Width - 11 * 2, Me.Height - 8 * 2)
        For i001 = 8 To Me.Height - 8 * 2 Step RowHeight
            e.Graphics.DrawLine(BorderPen, 11, i001, Me.Width - 11, i001)
        Next
        e.Graphics.DrawLine(BorderPen, Me.Width \ 2 - 2, 8 + RowHeight, Me.Width \ 2 - 2, 8 + RowHeight * 2)

        e.Graphics.DrawLine(BorderPen, RowsWidth(0) + 4, 8 + RowHeight * 3, RowsWidth(0) + 4, 8 + RowHeight * 9)
        e.Graphics.DrawLine(BorderPen, RowsWidth(1) + 5 + 4, 8 + RowHeight * 3, RowsWidth(1) + 5 + 4, 8 + RowHeight * 9)
        e.Graphics.DrawLine(BorderPen, RowsWidth(2) + 15 + 4, 8 + RowHeight * 3, RowsWidth(2) + 15 + 4, 8 + RowHeight * 9)
        e.Graphics.DrawLine(BorderPen, RowsWidth(3) + 25 + 4, 8 + RowHeight * 3, RowsWidth(3) + 25 + 4, 8 + RowHeight * 9)
#End Region

        e.Graphics.DrawString(AppSettingHelper.Settings.Title, Me.Font, FontSolidBrush, Me.Width \ 2, RowHeight \ 2, StringFormatCenter)

        e.Graphics.DrawString($"排污口编号: {AppSettingHelper.Settings.EquipmentPWKBH}",
                                  Me.Font,
                                  FontSolidBrush,
                                  17,
                                  RowHeight + RowHeight \ 2)
        e.Graphics.DrawString($"监测时间: {AppSettingHelper.Settings.LastReadTime.ToString}",
                                  Me.Font,
                                  FontSolidBrush,
                                  Me.Width \ 2,
                                  RowHeight + RowHeight \ 2)

        e.Graphics.DrawString($"瞬时排放量: {AppSettingHelper.Settings.SSLL.ToString("0.000")} L/s",
                                  Me.Font,
                                  FontSolidBrush,
                                  17,
                                  RowHeight * 2 + RowHeight \ 2)

#Region "绘制监测值"
        e.Graphics.DrawString($"监测指标", Me.Font, FontSolidBrush, RowsWidth(0), RowHeight * 3 + RowHeight \ 2, StringFormatFar)
        e.Graphics.DrawString($"监测值", Me.Font, FontSolidBrush, RowsWidth(1), RowHeight * 3 + RowHeight \ 2, StringFormatFar)
        e.Graphics.DrawString($"单位", Me.Font, FontSolidBrush, RowsWidth(2), RowHeight * 3 + RowHeight \ 2, StringFormatCenter)
        e.Graphics.DrawString($"浓度限值", Me.Font, FontSolidBrush, RowsWidth(3), RowHeight * 3 + RowHeight \ 2, StringFormatCenter)
        e.Graphics.DrawString($"核定的排放总量(吨/年)", Me.Font, FontSolidBrush, RowsWidth(4), RowHeight * 3 + RowHeight \ 2, StringFormatCenter)

        For i001 = 0 To AppSettingHelper.Settings.DetectionInfoItems.Count - 1
            Dim item = AppSettingHelper.Settings.DetectionInfoItems(i001)
            e.Graphics.DrawString($"{item.Name}",
                                  Me.Font,
                                  FontSolidBrush,
                                   RowsWidth(0),
                                  i001 * RowHeight + RowHeight * 4 + RowHeight \ 2, StringFormatFar)
            e.Graphics.DrawString($"{item.Value.ToString("0.000")}",
                                  Me.Font,
                                  FontSolidBrush,
                                   RowsWidth(1),
                                  i001 * RowHeight + RowHeight * 4 + RowHeight \ 2, StringFormatFar)
            e.Graphics.DrawString($"{item.Unit}",
                                  Me.Font,
                                  FontSolidBrush,
                                   RowsWidth(2),
                                  i001 * RowHeight + RowHeight * 4 + RowHeight \ 2, StringFormatCenter)
            e.Graphics.DrawString($"{item.Minimum}~{item.Maximum}",
                                  Me.Font,
                                  FontSolidBrush,
                                   RowsWidth(3),
                                  i001 * RowHeight + RowHeight * 4 + RowHeight \ 2, StringFormatCenter)
            e.Graphics.DrawString($"{item.SumOfYear.ToString("0.0")}",
                                  Me.Font,
                                  FontSolidBrush,
                                   RowsWidth(4),
                                  i001 * RowHeight + RowHeight * 4 + RowHeight \ 2, StringFormatCenter)
        Next
#End Region

        e.Graphics.DrawString($"企业环保负责人及联系电话: {AppSettingHelper.Settings.QYHBFZR} {AppSettingHelper.Settings.QYHBFZRMobile}",
                              Me.Font,
                                  FontSolidBrush,
                                  17,
                                  RowHeight * 9 + RowHeight \ 2)
        e.Graphics.DrawString($"在线监测运营负责人及联系电话: {AppSettingHelper.Settings.ZZJCYYFZR} {AppSettingHelper.Settings.ZZJCYYFZRMobile}",
                                  Me.Font,
                                  FontSolidBrush,
                                  17,
                                  RowHeight * 10 + RowHeight \ 2)

    End Sub
#End Region

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Using tmpDialog As New SettingForm
            If tmpDialog.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            AppSettingHelper.SaveToLocaltion()
            ForceRefresh()

        End Using
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
#End Region

End Class