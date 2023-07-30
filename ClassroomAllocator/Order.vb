﻿' An Enum Type linking integer with Period Name
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

' An Enum Type linking integer with Room Number
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

' A structure containing specific information in an order
Public Structure Order
    Public strApplicantName As String ' A string representing Applicant Name
    Public strPurpose As String ' A string representing Application purpose
    Public enmRoom As Room ' An integer representing Room Number
    Public enmPeriod As Period ' An integer representing Period Number

    Public Sub New(strApplicantName As String,
                   strPurpose As String,
                   strRoom As String,
                   strPeriod As String)
        Me.strApplicantName = strApplicantName
        Me.strPurpose = strPurpose

        Dim intRoom, intPeriod As Integer
        Integer.TryParse(strRoom, intRoom)
        Integer.TryParse(strPeriod, intPeriod)

        Me.enmRoom = intRoom
        Me.enmPeriod = intPeriod
    End Sub
End Structure