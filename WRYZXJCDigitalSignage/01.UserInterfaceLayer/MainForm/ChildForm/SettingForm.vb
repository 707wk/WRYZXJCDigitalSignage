Public Class SettingForm
    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DetectionInfoItems
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .RowHeadersVisible = False

            .AllowUserToResizeRows = True
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Control
            .GridColor = Color.FromArgb(&HE5, &HE5, &HE5)
            '.CellBorderStyle = DataGridViewCellBorderStyle.None
            .ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False

            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            .ReadOnly = False
            .EditMode = DataGridViewEditMode.EditOnEnter
            '.CellBorderStyle = DataGridViewCellBorderStyle.Single

            For Each i001 As DataGridViewColumn In .Columns
                i001.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End With

        LoginName.Text = AppSettingHelper.Settings.LoginName
        LoginPassword.Text = AppSettingHelper.Settings.LoginPassword
        LoginUrl.Text = AppSettingHelper.Settings.LoginUrl
        DataUrl.Text = AppSettingHelper.Settings.DataUrl
        'QYHBFZRUrl.Text = AppSettingHelper.Settings.QYHBFZRUrl
        EquipmentPWKBH.Text = AppSettingHelper.Settings.EquipmentPWKBH
        EquipmentJCDXH.Text = AppSettingHelper.Settings.EquipmentJCDXH
        pollingIntervalSec.Value = AppSettingHelper.Settings.pollingIntervalSec

        QYHBFZR.Text = AppSettingHelper.Settings.QYHBFZR
        QYHBFZRMobile.Text = AppSettingHelper.Settings.QYHBFZRMobile

        IsForgery.Checked = AppSettingHelper.Settings.IsForgery
        SSLLfForgery.Value = AppSettingHelper.Settings.SSLLfForgery

        For Each item In AppSettingHelper.Settings.DetectionInfoItems
            DetectionInfoItems.Rows.Add({item.Name, item.Unit, item.Minimum, item.Maximum, item.SumOfYear, item.ValueOfForgery})
        Next

        ZXJCYYWHDW.Text = AppSettingHelper.Settings.ZXJCYYWHDW
        ZZJCYYFZR.Text = AppSettingHelper.Settings.ZZJCYYFZR
        ZZJCYYFZRMobile.Text = AppSettingHelper.Settings.ZZJCYYFZRMobile

        ShowSec.Value = AppSettingHelper.Settings.ShowSec

        With ShowImageItems
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = True
            .ReadOnly = False
            .EditMode = DataGridViewEditMode.EditOnEnter
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
        End With

        For Each item In AppSettingHelper.Settings.ShowImageItems
            ShowImageItems.Rows.Add({False, IO.Path.GetFileName(item.Path), item.Path, item.ShowSec})
        Next

        IsAutoRun.Checked = AppSettingHelper.Settings.IsAutoRun

    End Sub

    Private Sub AddOrSaveButton_Click(sender As Object, e As EventArgs) Handles AddOrSaveButton.Click

        If String.IsNullOrWhiteSpace(LoginName.Text) OrElse
            String.IsNullOrWhiteSpace(LoginPassword.Text) OrElse
            String.IsNullOrWhiteSpace(LoginUrl.Text) OrElse
            String.IsNullOrWhiteSpace(DataUrl.Text) OrElse
            String.IsNullOrWhiteSpace(EquipmentPWKBH.Text) OrElse
            String.IsNullOrWhiteSpace(EquipmentJCDXH.Text) OrElse
            String.IsNullOrWhiteSpace(QYHBFZR.Text) OrElse
            String.IsNullOrWhiteSpace(QYHBFZRMobile.Text) OrElse
            String.IsNullOrWhiteSpace(ZXJCYYWHDW.Text) OrElse
            String.IsNullOrWhiteSpace(ZZJCYYFZR.Text) OrElse
            String.IsNullOrWhiteSpace(ZZJCYYFZRMobile.Text) Then
            MsgBox("内容不能为空", MsgBoxStyle.Information, AddOrSaveButton.Text)
            Exit Sub
        End If

        For Each rowItem As DataGridViewRow In DetectionInfoItems.Rows
            For Each cellItem As DataGridViewCell In rowItem.Cells
                If String.IsNullOrWhiteSpace($"{cellItem.Value}") Then
                    MsgBox("内容不能为空", MsgBoxStyle.Information, AddOrSaveButton.Text)
                    Exit Sub
                End If
            Next
        Next

        For Each rowItem As DataGridViewRow In ShowImageItems.Rows
            If Val($"{rowItem.Cells(3).Value}") <= 0 Then
                MsgBox("播放时间错误", MsgBoxStyle.Information, AddOrSaveButton.Text)
                Exit Sub
            End If
        Next

        AppSettingHelper.Settings.LoginName = LoginName.Text
        AppSettingHelper.Settings.LoginPassword = LoginPassword.Text
        AppSettingHelper.Settings.LoginUrl = LoginUrl.Text
        AppSettingHelper.Settings.DataUrl = DataUrl.Text
        'AppSettingHelper.Settings.QYHBFZRUrl = QYHBFZRUrl.Text
        AppSettingHelper.Settings.EquipmentPWKBH = EquipmentPWKBH.Text
        AppSettingHelper.Settings.EquipmentJCDXH = EquipmentJCDXH.Text
        AppSettingHelper.Settings.pollingIntervalSec = pollingIntervalSec.Value

        AppSettingHelper.Settings.QYHBFZR = QYHBFZR.Text
        AppSettingHelper.Settings.QYHBFZRMobile = QYHBFZRMobile.Text

        AppSettingHelper.Settings.IsForgery = IsForgery.Checked
        AppSettingHelper.Settings.SSLLfForgery = SSLLfForgery.Value

        For i001 = 0 To DetectionInfoItems.Rows.Count - 1
            Dim rowItem = DetectionInfoItems.Rows(i001)

            AppSettingHelper.Settings.DetectionInfoItems(i001).Name = $"{rowItem.Cells(0).Value}"
            AppSettingHelper.Settings.DetectionInfoItems(i001).Unit = $"{rowItem.Cells(1).Value}"
            AppSettingHelper.Settings.DetectionInfoItems(i001).Minimum = Val($"{rowItem.Cells(2).Value}")
            AppSettingHelper.Settings.DetectionInfoItems(i001).Maximum = Val($"{rowItem.Cells(3).Value}")
            AppSettingHelper.Settings.DetectionInfoItems(i001).SumOfYear = Val($"{rowItem.Cells(4).Value}")
            AppSettingHelper.Settings.DetectionInfoItems(i001).ValueOfForgery = Val($"{rowItem.Cells(5).Value}")
        Next

        AppSettingHelper.Settings.ZXJCYYWHDW = ZXJCYYWHDW.Text
        AppSettingHelper.Settings.ZZJCYYFZR = ZZJCYYFZR.Text
        AppSettingHelper.Settings.ZZJCYYFZRMobile = ZZJCYYFZRMobile.Text

        AppSettingHelper.Settings.ShowSec = ShowSec.Value

        AppSettingHelper.Settings.ShowImageItems.Clear()
        For Each rowItem As DataGridViewRow In ShowImageItems.Rows
            AppSettingHelper.Settings.ShowImageItems.Add(New ShowImageInfo With {
                                                         .Path = $"{rowItem.Cells(2).Value}",
                                                         .ShowSec = Val($"{rowItem.Cells(3).Value}")
                                                         })
        Next

        AppSettingHelper.Settings.IsAutoRun = IsAutoRun.Checked
        Try
            If AppSettingHelper.Settings.IsAutoRun Then

                Dim shortcutPath As String = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.Startup) }\{My.Application.Info.ProductName}.lnk"
                Dim tmpWshShell = New IWshRuntimeLibrary.WshShell()
                Dim tmpIWshShortcut As IWshRuntimeLibrary.IWshShortcut = tmpWshShell.CreateShortcut(shortcutPath)
                With tmpIWshShortcut
                    .TargetPath = Application.ExecutablePath
                    .WorkingDirectory = IO.Path.GetDirectoryName(Application.ExecutablePath)
                    .WindowStyle = 1
                    .Description = My.Application.Info.ProductName
                    .IconLocation = .TargetPath
                    .Save()
                End With

            Else
                Dim shortcutPath As String = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.Startup) }\{My.Application.Info.ProductName}.lnk"
                Try
                    IO.File.Delete(shortcutPath)
                Catch ex As Exception
                End Try

            End If

        Catch ex As Exception
            MsgBox(ex.Message,
                   MsgBoxStyle.Information,
                   IsAutoRun.Text)
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Using tmpDialog As New OpenFileDialog With {
            .Filter = "图片|*.png;*.bitmap;*.jpg",
            .Multiselect = True
        }
            If tmpDialog.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            For Each item In tmpDialog.FileNames
                ShowImageItems.Rows.Add({False, IO.Path.GetFileName(item), item, 10})
            Next

        End Using
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim selectedCount As Integer = 0
        For Each item As DataGridViewRow In ShowImageItems.Rows
            If item.Cells(0).EditedFormattedValue Then
                selectedCount += 1
            End If
        Next

        If selectedCount = 0 Then
            Exit Sub
        End If

        If MsgBox("确定移除选中图片?", MsgBoxStyle.YesNo, DeleteButton.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        '删除
        For rowID = ShowImageItems.Rows.Count - 1 To 0 Step -1
            If ShowImageItems.Rows(rowID).Cells(0).EditedFormattedValue Then
                ShowImageItems.Rows.RemoveAt(rowID)
            End If
        Next

    End Sub

End Class