Public Enum Period As Integer
    TUTORIAL = 1
    PERIOD1
    PERIOD2
    RECESS
    PERIOD3
    PERIOD4
    LUNCH
    PERIOD5
    PERIOD6
End Enum

Public Enum Room As Integer
    S01 = 1
    S02
    S03
    S04
    S05
    S06
    S07
    S08
    S09
    S10
End Enum

Public Structure Order
    Public strApplicantName As String
    Public strPurpose As String
    Public intRoom As Room
    Public intPeriod As Period
End Structure
