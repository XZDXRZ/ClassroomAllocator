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
    Private sttOrders() As Order

    Private Function ReadFromDate(userChooseDate As Date)
        Try
            ' A 2-dimensional dynamic array
            ' 1st dimension: Order Index
            ' 2nd dimension: 4 data
            ' Note that all the array starts from 0, ends with total - 1
            Dim strOrders(,) As String
            Dim strOrdersNoSplit As String ' Raw string readed from file
            Dim strOrdersSplitedByCrlf() As String ' Split raw string by CRLF

            ' Read data from assigned file
            strOrdersNoSplit = My.Computer.FileSystem.ReadAllText("../date_files/" & userChooseDate.ToString("ddMMyy") & ".csv")
            ' Split raw data by CRLF
            strOrdersSplitedByCrlf = strOrdersNoSplit.Split(vbCrLf)

            ' Get the number of row in assigned file
            Dim intOrdersSplitedByCrlfLength As Integer = strOrdersSplitedByCrlf.Length - 1 ' Last row is always empty
            ReDim strOrders(intOrdersSplitedByCrlfLength - 1, 3) ' And determine the size of order array

            ' Copy data in each row to order array
            ' Last row is always empty, so read till total - 1
            For intOrderIndex As Integer = 0 To intOrdersSplitedByCrlfLength - 1
                ' Split data in each row by comma
                Dim strTempOrders() As String = strOrdersSplitedByCrlf(intOrderIndex).Split(",")
                For i As Integer = 0 To 3
                    strOrders(intOrderIndex, i) = strTempOrders(i)
                Next
            Next

            ' Return orders in String
            Return strOrders
        Catch ex As Exception
            ' Create a new file if the file does not exist
            Dim dateFile As FileStream = New FileStream("../date_files/" & userChooseDate.ToString("ddMMyy") & ".csv",
                                                        FileMode.Create,
                                                        FileAccess.ReadWrite)
            dateFile.Close()

            ' Create and return an empty string array
            Dim strOrders(0, 0) As String
            Return strOrders
        End Try
    End Function

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

        ' Store the date that user chooses
        Dim datUserChooseDate As Date = userSelectionRange.Start
        Dim strOrders(,) As String

        ' Read string data from assigned date, and convert into string array
        ' Otherwise, create a file if does not exist
        strOrders = ReadFromDate(datUserChooseDate.Date)
    End Sub
End Class
