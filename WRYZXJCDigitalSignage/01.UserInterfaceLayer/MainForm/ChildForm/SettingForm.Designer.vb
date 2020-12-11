<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginName = New System.Windows.Forms.TextBox()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.LoginUrl = New System.Windows.Forms.TextBox()
        Me.DataUrl = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pollingIntervalSec = New System.Windows.Forms.NumericUpDown()
        Me.EquipmentJCDXH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EquipmentPWKBH = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ZZJCYYFZRMobile = New System.Windows.Forms.TextBox()
        Me.ZZJCYYFZR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ZXJCYYWHDW = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.QYHBFZRMobile = New System.Windows.Forms.TextBox()
        Me.QYHBFZR = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.IsAutoRun = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DetectionInfoItems = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ShowSec = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ShowImageItems = New Wangk.Resource.CheckBoxDataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AddButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddOrSaveButton = New System.Windows.Forms.Button()
        Me.IsForgery = New System.Windows.Forms.CheckBox()
        Me.SSLLfForgery = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pollingIntervalSec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DetectionInfoItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.ShowSec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ShowImageItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SSLLfForgery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 257)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "数据抓取设置"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginUrl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DataUrl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.pollingIntervalSec, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.EquipmentJCDXH, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EquipmentPWKBH, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(724, 219)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "登陆用户名:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "登陆密码:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "登陆地址:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "数据抓取地址:"
        '
        'LoginName
        '
        Me.LoginName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginName.Location = New System.Drawing.Point(92, 4)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(629, 23)
        Me.LoginName.TabIndex = 1
        '
        'LoginPassword
        '
        Me.LoginPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginPassword.Location = New System.Drawing.Point(92, 35)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.LoginPassword.Size = New System.Drawing.Size(629, 23)
        Me.LoginPassword.TabIndex = 1
        '
        'LoginUrl
        '
        Me.LoginUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginUrl.Location = New System.Drawing.Point(92, 66)
        Me.LoginUrl.Name = "LoginUrl"
        Me.LoginUrl.Size = New System.Drawing.Size(629, 23)
        Me.LoginUrl.TabIndex = 1
        '
        'DataUrl
        '
        Me.DataUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataUrl.Location = New System.Drawing.Point(92, 97)
        Me.DataUrl.Name = "DataUrl"
        Me.DataUrl.Size = New System.Drawing.Size(629, 23)
        Me.DataUrl.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "抓取间隔(s):"
        '
        'pollingIntervalSec
        '
        Me.pollingIntervalSec.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pollingIntervalSec.Location = New System.Drawing.Point(92, 191)
        Me.pollingIntervalSec.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.pollingIntervalSec.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.pollingIntervalSec.Name = "pollingIntervalSec"
        Me.pollingIntervalSec.Size = New System.Drawing.Size(63, 23)
        Me.pollingIntervalSec.TabIndex = 2
        Me.pollingIntervalSec.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'EquipmentJCDXH
        '
        Me.EquipmentJCDXH.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EquipmentJCDXH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EquipmentJCDXH.Location = New System.Drawing.Point(92, 159)
        Me.EquipmentJCDXH.Name = "EquipmentJCDXH"
        Me.EquipmentJCDXH.Size = New System.Drawing.Size(629, 23)
        Me.EquipmentJCDXH.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "排污口标识:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "排污口编号:"
        '
        'EquipmentPWKBH
        '
        Me.EquipmentPWKBH.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EquipmentPWKBH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EquipmentPWKBH.Location = New System.Drawing.Point(92, 128)
        Me.EquipmentPWKBH.Name = "EquipmentPWKBH"
        Me.EquipmentPWKBH.Size = New System.Drawing.Size(629, 23)
        Me.EquipmentPWKBH.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 260)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "负责人信息"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ZZJCYYFZRMobile, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ZZJCYYFZR, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ZXJCYYWHDW, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.QYHBFZRMobile, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.QYHBFZR, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(347, 144)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "联系电话:"
        '
        'ZZJCYYFZRMobile
        '
        Me.ZZJCYYFZRMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZZJCYYFZRMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZZJCYYFZRMobile.Location = New System.Drawing.Point(152, 116)
        Me.ZZJCYYFZRMobile.Name = "ZZJCYYFZRMobile"
        Me.ZZJCYYFZRMobile.Size = New System.Drawing.Size(192, 23)
        Me.ZZJCYYFZRMobile.TabIndex = 1
        '
        'ZZJCYYFZR
        '
        Me.ZZJCYYFZR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZZJCYYFZR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZZJCYYFZR.Location = New System.Drawing.Point(152, 87)
        Me.ZZJCYYFZR.Name = "ZZJCYYFZR"
        Me.ZZJCYYFZR.Size = New System.Drawing.Size(192, 23)
        Me.ZZJCYYFZR.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "运营负责人:"
        '
        'ZXJCYYWHDW
        '
        Me.ZXJCYYWHDW.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZXJCYYWHDW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZXJCYYWHDW.Location = New System.Drawing.Point(152, 59)
        Me.ZXJCYYWHDW.Name = "ZXJCYYWHDW"
        Me.ZXJCYYWHDW.Size = New System.Drawing.Size(192, 23)
        Me.ZXJCYYWHDW.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "运营单位:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "企业环保负责人:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "企业环保负责人联系电话:"
        '
        'QYHBFZRMobile
        '
        Me.QYHBFZRMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QYHBFZRMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QYHBFZRMobile.Location = New System.Drawing.Point(152, 31)
        Me.QYHBFZRMobile.Name = "QYHBFZRMobile"
        Me.QYHBFZRMobile.Size = New System.Drawing.Size(192, 23)
        Me.QYHBFZRMobile.TabIndex = 1
        '
        'QYHBFZR
        '
        Me.QYHBFZR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QYHBFZR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QYHBFZR.Location = New System.Drawing.Point(152, 3)
        Me.QYHBFZR.Name = "QYHBFZR"
        Me.QYHBFZR.Size = New System.Drawing.Size(192, 23)
        Me.QYHBFZR.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.IsAutoRun)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(703, 53)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "其他设置"
        '
        'IsAutoRun
        '
        Me.IsAutoRun.AutoSize = True
        Me.IsAutoRun.Location = New System.Drawing.Point(12, 22)
        Me.IsAutoRun.Name = "IsAutoRun"
        Me.IsAutoRun.Size = New System.Drawing.Size(99, 21)
        Me.IsAutoRun.TabIndex = 0
        Me.IsAutoRun.Text = "开机自动启动"
        Me.IsAutoRun.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DetectionInfoItems)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 35)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(683, 224)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "监测值设置"
        '
        'DetectionInfoItems
        '
        Me.DetectionInfoItems.AllowUserToAddRows = False
        Me.DetectionInfoItems.AllowUserToDeleteRows = False
        Me.DetectionInfoItems.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DetectionInfoItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetectionInfoItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetectionInfoItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column9})
        Me.DetectionInfoItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetectionInfoItems.Location = New System.Drawing.Point(3, 19)
        Me.DetectionInfoItems.Name = "DetectionInfoItems"
        Me.DetectionInfoItems.RowTemplate.Height = 23
        Me.DetectionInfoItems.Size = New System.Drawing.Size(677, 202)
        Me.DetectionInfoItems.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(703, 299)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 49
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(748, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "数据抓取"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.SSLLfForgery)
        Me.TabPage2.Controls.Add(Me.IsForgery)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(695, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "监测值"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(748, 269)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "负责人信息"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.ShowSec)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(748, 269)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "图片轮播"
        '
        'ShowSec
        '
        Me.ShowSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShowSec.Location = New System.Drawing.Point(124, 9)
        Me.ShowSec.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.ShowSec.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ShowSec.Name = "ShowSec"
        Me.ShowSec.Size = New System.Drawing.Size(81, 23)
        Me.ShowSec.TabIndex = 3
        Me.ShowSec.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "主界面显示时长(s):"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.ShowImageItems)
        Me.GroupBox5.Controls.Add(Me.ToolStrip1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(739, 228)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "图片列表"
        '
        'ShowImageItems
        '
        Me.ShowImageItems.AllowUserToAddRows = False
        Me.ShowImageItems.AllowUserToDeleteRows = False
        Me.ShowImageItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.ShowImageItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ShowImageItems.BackgroundColor = System.Drawing.Color.White
        Me.ShowImageItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ShowImageItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ShowImageItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ShowImageItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShowImageItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.Column8, Me.Column6, Me.Column7})
        Me.ShowImageItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowImageItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ShowImageItems.Location = New System.Drawing.Point(3, 46)
        Me.ShowImageItems.Name = "ShowImageItems"
        Me.ShowImageItems.RowTemplate.Height = 23
        Me.ShowImageItems.Size = New System.Drawing.Size(733, 179)
        Me.ShowImageItems.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.Frozen = True
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 48
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 48
        '
        'Column8
        '
        Me.Column8.HeaderText = "文件名"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 240
        '
        'Column6
        '
        Me.Column6.HeaderText = "文件路径"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 220
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "显示时长(s)"
        Me.Column7.Name = "Column7"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddButton, Me.DeleteButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 19)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(733, 27)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AddButton
        '
        Me.AddButton.Image = Global.WRYZXJCDigitalSignage.My.Resources.Resources.add_20px
        Me.AddButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(80, 24)
        Me.AddButton.Text = "添加图片"
        '
        'DeleteButton
        '
        Me.DeleteButton.Image = Global.WRYZXJCDigitalSignage.My.Resources.Resources.close_20px
        Me.DeleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(104, 24)
        Me.DeleteButton.Text = "移除选中图片"
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Image = Global.WRYZXJCDigitalSignage.My.Resources.Resources.no_16px
        Me.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelButton.Location = New System.Drawing.Point(621, 376)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(96, 26)
        Me.CancelButton.TabIndex = 44
        Me.CancelButton.Text = "取消"
        Me.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddOrSaveButton
        '
        Me.AddOrSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddOrSaveButton.Image = Global.WRYZXJCDigitalSignage.My.Resources.Resources.yes_16px
        Me.AddOrSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddOrSaveButton.Location = New System.Drawing.Point(519, 376)
        Me.AddOrSaveButton.Name = "AddOrSaveButton"
        Me.AddOrSaveButton.Size = New System.Drawing.Size(96, 26)
        Me.AddOrSaveButton.TabIndex = 43
        Me.AddOrSaveButton.Text = "保存修改"
        Me.AddOrSaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddOrSaveButton.UseVisualStyleBackColor = True
        '
        'IsForgery
        '
        Me.IsForgery.AutoSize = True
        Me.IsForgery.Location = New System.Drawing.Point(18, 7)
        Me.IsForgery.Name = "IsForgery"
        Me.IsForgery.Size = New System.Drawing.Size(87, 21)
        Me.IsForgery.TabIndex = 0
        Me.IsForgery.Text = "使用预设值"
        Me.IsForgery.UseVisualStyleBackColor = True
        '
        'SSLLfForgery
        '
        Me.SSLLfForgery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSLLfForgery.DecimalPlaces = 3
        Me.SSLLfForgery.Location = New System.Drawing.Point(220, 6)
        Me.SSLLfForgery.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.SSLLfForgery.Name = "SSLLfForgery"
        Me.SSLLfForgery.Size = New System.Drawing.Size(120, 23)
        Me.SSLLfForgery.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(131, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 17)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "预设瞬时流量:"
        '
        'Column1
        '
        Me.Column1.HeaderText = "监测项名称"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "计量单位"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "最小值"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "最大值"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "排放总量(吨/年)"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "预设监测值"
        Me.Column9.Name = "Column9"
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 414)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddOrSaveButton)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "参数设置"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pollingIntervalSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DetectionInfoItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.ShowSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ShowImageItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SSLLfForgery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend Shadows WithEvents CancelButton As Button
    Friend WithEvents AddOrSaveButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LoginName As TextBox
    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents LoginUrl As TextBox
    Friend WithEvents DataUrl As TextBox
    Friend WithEvents EquipmentJCDXH As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ZZJCYYFZRMobile As TextBox
    Friend WithEvents ZZJCYYFZR As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents pollingIntervalSec As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents IsAutoRun As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DetectionInfoItems As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents ZXJCYYWHDW As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ShowSec As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ShowImageItems As Wangk.Resource.CheckBoxDataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents AddButton As ToolStripButton
    Friend WithEvents DeleteButton As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents EquipmentPWKBH As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents QYHBFZRMobile As TextBox
    Friend WithEvents QYHBFZR As TextBox
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents IsForgery As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents SSLLfForgery As NumericUpDown
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
