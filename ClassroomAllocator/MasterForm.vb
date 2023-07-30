' AUTHOR:           Lance Gong, Lambert Zhu, Tymon Ng
' CREATED DATE:     20/07/2023
' DESCRIPTION:      A programme to help manage and allocate classrooms for teachers
'                   and students for academic purposes.
' INPUTS:
' OUTPUTS:
' VERSION HISTORY:  V0.0.1 - 26/07/2023 - GUI Nearly Finished
'                   V0.0.2 - 27/07/2023 - GUI Finished
' COMMENT:          我永远喜欢爱丽希雅
'                   True

Imports System.IO

Public Class MasterForm
    ' A dynamic array containing orders in the selected date
    Private orders() As Order

    Private Sub ReadFromDate(userChooseDate As Date)
        Try
            Dim strOrders(,) As String
            Dim strOrdersNoSplit As String
            Dim strOrdersSplitedByCrlf() As String

            strOrdersNoSplit = My.Computer.FileSystem.ReadAllText("../date_files/" & userChooseDate.ToString("ddMMyy") & ".csv")
            strOrdersSplitedByCrlf = strOrdersNoSplit.Split(vbCrLf)

            Dim intStrOrdersSplitedByCrlfLength As Integer = strOrdersSplitedByCrlf.Length
            ReDim strOrders(intStrOrdersSplitedByCrlfLength, 4)

            For orderIndex As Integer = 1 To intStrOrdersSplitedByCrlfLength

            Next
        Catch ex As Exception
            ' Create a new file if the file does not exist
            Dim dateFile As FileStream = New FileStream("../date_files/" & userChooseDate.ToString("ddMMyy") & ".csv",
                       FileMode.Create,
                       FileAccess.ReadWrite)
            dateFile.Close()
        End Try
    End Sub

    Private Sub btnLoadTimetable_Click(sender As Object, e As EventArgs) Handles btnLoadTimetable.Click
        ' Judgement of whether user select one date
        Dim datUserSelectionStart As Date = cldrChooseDate.SelectionStart
        Dim datUserSelectionEnd As Date = cldrChooseDate.SelectionEnd
        Dim userSelectionRange As SelectionRange = New SelectionRange(datUserSelectionStart, datUserSelectionEnd)

        ' Inform the user if they choose more than one date and exit Sub
        If userSelectionRange.Start <> userSelectionRange.End Then
            MsgBox("Please choose one date", Title:="Choose date Error")
            Exit Sub
        End If

        Dim datUserChooseDate As Date = userSelectionRange.Start
        Dim blnFileExists As Boolean

        ReadFromDate(datUserChooseDate.Date)
    End Sub
End Class
