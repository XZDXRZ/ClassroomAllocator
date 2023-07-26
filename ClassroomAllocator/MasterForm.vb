' AUTHOR:           Lance Gong, Lambert Zhu, Tymon Ng
'CREATED DATE:      20/07/2023
'DESCRIPTION:       A programme to help manage and allocate classrooms for teachers
'                   and students for academic purposes.
'INPUTS:
'OUTPUTS:
'VERSION HISTORY:   V1 - 26/07/2023 - Most GUI Finished
'ACKNOWLEDGEMENT:
'COMMENT:           我永远喜欢爱丽希雅

Public Class MasterForm

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
