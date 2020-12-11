''' <summary>
''' 监测信息
''' </summary>
Public Class DetectionInfo
    ''' <summary>
    ''' 监测项名称
    ''' </summary>
    Public Name As String

    ''' <summary>
    ''' 排放总量(吨/年)(手动输入)
    ''' </summary>
    Public SumOfYear As Double

    ''' <summary>
    ''' 当前值
    ''' </summary>
    Public Value As Double

    ''' <summary>
    ''' 假值
    ''' </summary>
    Public ValueOfForgery As Double

    ''' <summary>
    ''' 最大值(手动输入)
    ''' </summary>
    Public Maximum As Integer
    ''' <summary>
    ''' 最小值(手动输入)
    ''' </summary>
    Public Minimum As Integer

    ''' <summary>
    ''' 计量单位(手动输入)
    ''' </summary>
    Public Unit As String = "mg/L"

    ''' <summary>
    ''' 状态
    ''' </summary>
    Public Status As String = "运行"

End Class
