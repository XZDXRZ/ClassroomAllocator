Public Enum Period As Integer
    TUTORIAL = 0
    PERIOD1
    PERIOD2
    RECESS
    PERIOD3
    PERIOD4
    LUNCH
    PERIOD5
    PERIOD6
End Enum

Public Class Room
    Public strCode As String
    Public timePeriod(9) As TimePeriod

    Public Sub New(ByVal strCode As String)
        Me.strCode = strCode
    End Sub
End Class

Public Structure Order
    Public strApplicantName As String
    Public strPurpose As String
End Structure

Public Class TimePeriod
    Public periodName As Period
    Public order As Order

    Public Sub New(ByVal periodName As Period)
        Me.periodName = periodName
    End Sub
End Class

Public Class Day
    Public identifyDate As Date
    Public rooms(10) As Room
End Class
