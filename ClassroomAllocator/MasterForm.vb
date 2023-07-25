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
    Public Property strCode As String
    Public Property timePeriod As TimePeriod
End Class

Public Class Order
    Public Property strApplicantName As String
    Public Property strPurpose As String
End Class

Public Class TimePeriod
    Public Property periodName As Period
    Public Property order As Order
End Class

Public Class Day
    Public Property identifyDate As Date
    Public Property rooms As Room()
End Class

Public Class MasterForm
    Private Sub MasterForm_Load(sender As Object, e As EventArgs)

    End Sub
End Class
