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
        QYHBFZRUrl.Text = AppSettingHelper.Settings.QYHBFZRUrl
        EquipmentJCDXH.Text = AppSettingHelper.Settings.EquipmentJCDXH
        pollingIntervalSec.Value = AppSettingHelper.Settings.pollingIntervalSec

        For Each item In AppSettingHelper.Settings.DetectionInfoItems
            DetectionInfoItems.Rows.Add({item.Name, item.Unit, item.Minimum, item.Maximum, item.SumOfYear})
        Next

        ZZJCYYFZR.Text = AppSettingHelper.Settings.ZZJCYYFZR
        ZZJCYYFZRMobile.Text = AppSettingHelper.Settings.ZZJCYYFZRMobile

        IsAutoRun.Checked = AppSettingHelper.Settings.IsAutoRun

    End Sub

    Private Sub AddOrSaveButton_Click(sender As Object, e As EventArgs) Handles AddOrSaveButton.Click

        If String.IsNullOrWhiteSpace(LoginName.Text) OrElse
            String.IsNullOrWhiteSpace(LoginPassword.Text) OrElse
            String.IsNullOrWhiteSpace(LoginUrl.Text) OrElse
            String.IsNullOrWhiteSpace(DataUrl.Text) OrElse
            String.IsNullOrWhiteSpace(EquipmentJCDXH.Text) OrElse
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

        AppSettingHelper.Settings.LoginName = LoginName.Text
        AppSettingHelper.Settings.LoginPassword = LoginPassword.Text
        AppSettingHelper.Settings.LoginUrl = LoginUrl.Text
        AppSettingHelper.Settings.DataUrl = DataUrl.Text
        AppSettingHelper.Settings.QYHBFZRUrl = QYHBFZRUrl.Text
        AppSettingHelper.Settings.EquipmentJCDXH = EquipmentJCDXH.Text
        AppSettingHelper.Settings.pollingIntervalSec = pollingIntervalSec.Value

        For i001 = 0 To DetectionInfoItems.Rows.Count - 1
            Dim rowItem = DetectionInfoItems.Rows(i001)

            AppSettingHelper.Settings.DetectionInfoItems(i001).Name = $"{rowItem.Cells(0).Value}"
            AppSettingHelper.Settings.DetectionInfoItems(i001).Unit = $"{rowItem.Cells(1).Value}"
            AppSettingHelper.Settings.DetectionInfoItems(i001).Minimum = Val($"{rowItem.Cells(2).Value}")
            AppSettingHelper.Settings.DetectionInfoItems(i001).Maximum = Val($"{rowItem.Cells(3).Value}")
            AppSettingHelper.Settings.DetectionInfoItems(i001).SumOfYear = Val($"{rowItem.Cells(4).Value}")

        Next

        AppSettingHelper.Settings.ZZJCYYFZR = ZZJCYYFZR.Text
        AppSettingHelper.Settings.ZZJCYYFZRMobile = ZZJCYYFZRMobile.Text

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

End Class