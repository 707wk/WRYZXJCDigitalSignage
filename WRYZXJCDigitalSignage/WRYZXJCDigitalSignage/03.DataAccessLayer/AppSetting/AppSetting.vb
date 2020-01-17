''' <summary>
''' 全局配置类
''' </summary>
Public Class AppSetting

    ''' <summary>
    ''' 登陆用户名(手动输入)
    ''' </summary>
    Public LoginName As String
    ''' <summary>
    ''' 登陆密码(手动输入)
    ''' </summary>
    Public LoginPassword As String

    ''' <summary>
    ''' 登陆网址(手动输入)
    ''' </summary>
    Public LoginUrl As String
    ''' <summary>
    ''' 数据网址(手动输入)
    ''' </summary>
    Public DataUrl As String
    '''' <summary>
    '''' 负责人信息网址(手动输入)
    '''' </summary>
    'Public QYHBFZRUrl As String

    ''' <summary>
    ''' 表头信息
    ''' </summary>
    Public Title As String

    ''' <summary>
    ''' 排污口编号(手动输入)
    ''' </summary>
    Public EquipmentPWKBH As String
    ''' <summary>
    ''' 排污口标识(手动输入)
    ''' </summary>
    Public EquipmentJCDXH As String

    ''' <summary>
    ''' 上次读取数据时间
    ''' </summary>
    Public LastReadTime As DateTime

    ''' <summary>
    ''' 企业环保负责人(手动输入)
    ''' </summary>
    Public QYHBFZR As String = "无"
    ''' <summary>
    ''' 企业环保负责人联系电话(手动输入)
    ''' </summary>
    Public QYHBFZRMobile As String = "无"

    ''' <summary>
    ''' 检测值项
    ''' </summary>
    Public DetectionInfoItems As List(Of DetectionInfo)

    ''' <summary>
    ''' 瞬时流量
    ''' </summary>
    Public SSLL As Double
    ''' <summary>
    ''' 瞬时流量
    ''' </summary>
    Public SSLLfForgery As Double

    ''' <summary>
    ''' 在线监测运营维护单位(手动输入)
    ''' </summary>
    Public ZXJCYYWHDW As String = "无"
    ''' <summary>
    ''' 在线监测运营负责人(手动输入)
    ''' </summary>
    Public ZZJCYYFZR As String = "无"
    ''' <summary>
    ''' 在线监测运营负责人联系电话(手动输入)
    ''' </summary>
    Public ZZJCYYFZRMobile As String = "无"

    ''' <summary>
    ''' 轮询间隔(手动输入)
    ''' </summary>
    Public pollingIntervalSec As Integer

    ''' <summary>
    ''' 显示时长
    ''' </summary>
    Public ShowSec As Integer
    ''' <summary>
    ''' 轮播图片列表
    ''' </summary>
    Public ShowImageItems As List(Of ShowImageInfo)

    ''' <summary>
    ''' 显示项ID
    ''' </summary>
    <Newtonsoft.Json.JsonIgnore>
    Public ShowID As Integer = 0

    ''' <summary>
    ''' 是否开机自启
    ''' </summary>
    Public IsAutoRun As Boolean

    ''' <summary>
    ''' 是否显示假值
    ''' </summary>
    Public IsForgery As Boolean

End Class
