Public Class MasterForm
    Private Sub MasterForm_Load(sender As Object, e As EventArgs)

    End Sub
End Class

Enum Period As Integer
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

Class Room
    Public strCode As String
    Public timePeriod(9) As TimePeriod
End Class

Class Order
    Public strApplicantName As String
    Public strPurpose As String
End Class

Class TimePeriod
    Public periodName As Period
    Public order As Order
End Class

Class Day
    Public identifyDate As Date
    Public rooms(10) As Room
End Class
