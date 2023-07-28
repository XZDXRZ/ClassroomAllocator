' AUTHOR:           Lance Gong, Lambert Zhu, Tymon Ng
' CREATED DATE:     20/07/2023
' DESCRIPTION:      A programme to help manage and allocate classrooms for teachers
'                   and students for academic purposes.
' INPUTS:
' OUTPUTS:
' VERSION HISTORY:  V1 - 26/07/2023 - Most GUI Finished
'                   V2 - 27/07/2023 - Guid Finished
' ACKNOWLEDGEMENT:
' COMMENT:          我永远喜欢爱丽希雅

Imports System.IO

Public Class MasterForm
    Private Function ReadFromDate(userChooseDate As Date)
        Dim dateFile As FileStream = New FileStream("../date_files/" & userChooseDate.ToString("ddMMyy") & ".csv", FileMode.OpenOrCreate, FileAccess.ReadWrite)

        dateFile.Close()
        Return 0
    End Function

    Private Sub btnLoadTimetable_Click(sender As Object, e As EventArgs) Handles btnLoadTimetable.Click
        Dim datUserSelectionStart As Date = cldrChooseDate.SelectionStart
        Dim datUserSelectionEnd As Date = cldrChooseDate.SelectionEnd
        Dim userSelectionRange As SelectionRange = New SelectionRange(datUserSelectionStart, datUserSelectionEnd)

        If userSelectionRange.Start <> userSelectionRange.End Then
            MsgBox("Please choose one date", Title:="Choose date Error")
            Exit Sub
        End If

        Dim datUserChooseDate As Date = userSelectionRange.Start
        ReadFromDate(datUserChooseDate.Date)
    End Sub
End Class
