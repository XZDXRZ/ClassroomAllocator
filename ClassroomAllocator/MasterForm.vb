' AUTHOR:           Lance Gong, Lambert Zhu, Tymon Ng
' CREATED DATE:     20/07/2023
' DESCRIPTION:      A programme to help manage and allocate classrooms for teachers
'                   and students for academic purposes.
' INPUTS:
' OUTPUTS:
' VERSION HISTORY:  V0.0.1 - 26/07/2023 - GUI Nearly Finished
'                   V0.0.2 - 27/07/2023 - GUI Finished
' COMMENT:          我永远喜欢爱丽希雅
'                   TruE

Imports System.IO

Public Class MasterForm
    ' A dynamic array containing orders in the selected date
    Private sttOrders() As Order
    ' A 2-dimensional array that connects the components on the form and a pair of number together
    Private lblTableLinker(9, 10) As Label

    Private Sub initlblTableLinker()
        ' Initialize lblTableLinker, connecting a pair of number to a label on the form
        lblTableLinker(Period.TUTORIAL, Room.S01) = lblTutorialS01
        lblTableLinker(Period.TUTORIAL, Room.S02) = lblTutorialS02
        lblTableLinker(Period.TUTORIAL, Room.S03) = lblTutorialS03
        lblTableLinker(Period.TUTORIAL, Room.S04) = lblTutorialS04
        lblTableLinker(Period.TUTORIAL, Room.S05) = lblTutorialS05
        lblTableLinker(Period.TUTORIAL, Room.S06) = lblTutorialS06
        lblTableLinker(Period.TUTORIAL, Room.S07) = lblTutorialS07
        lblTableLinker(Period.TUTORIAL, Room.S08) = lblTutorialS08
        lblTableLinker(Period.TUTORIAL, Room.S09) = lblTutorialS09
        lblTableLinker(Period.TUTORIAL, Room.S10) = lblTutorialS10
        lblTableLinker(Period.PERIOD1, Room.S01) = lblPeriod1S01
        lblTableLinker(Period.PERIOD1, Room.S02) = lblPeriod1S02
        lblTableLinker(Period.PERIOD1, Room.S03) = lblPeriod1S03
        lblTableLinker(Period.PERIOD1, Room.S04) = lblPeriod1S04
        lblTableLinker(Period.PERIOD1, Room.S05) = lblPeriod1S05
        lblTableLinker(Period.PERIOD1, Room.S06) = lblPeriod1S06
        lblTableLinker(Period.PERIOD1, Room.S07) = lblPeriod1S07
        lblTableLinker(Period.PERIOD1, Room.S08) = lblPeriod1S08
        lblTableLinker(Period.PERIOD1, Room.S09) = lblPeriod1S09
        lblTableLinker(Period.PERIOD1, Room.S10) = lblPeriod1S10
        lblTableLinker(Period.PERIOD2, Room.S01) = lblPeriod2S01
        lblTableLinker(Period.PERIOD2, Room.S02) = lblPeriod2S02
        lblTableLinker(Period.PERIOD2, Room.S03) = lblPeriod2S03
        lblTableLinker(Period.PERIOD2, Room.S04) = lblPeriod2S04
        lblTableLinker(Period.PERIOD2, Room.S05) = lblPeriod2S05
        lblTableLinker(Period.PERIOD2, Room.S06) = lblPeriod2S06
        lblTableLinker(Period.PERIOD2, Room.S07) = lblPeriod2S07
        lblTableLinker(Period.PERIOD2, Room.S08) = lblPeriod2S08
        lblTableLinker(Period.PERIOD2, Room.S09) = lblPeriod2S09
        lblTableLinker(Period.PERIOD2, Room.S10) = lblPeriod2S10
        lblTableLinker(Period.RECESS, Room.S01) = lblRecessS01
        lblTableLinker(Period.RECESS, Room.S02) = lblRecessS02
        lblTableLinker(Period.RECESS, Room.S03) = lblRecessS03
        lblTableLinker(Period.RECESS, Room.S04) = lblRecessS04
        lblTableLinker(Period.RECESS, Room.S05) = lblRecessS05
        lblTableLinker(Period.RECESS, Room.S06) = lblRecessS06
        lblTableLinker(Period.RECESS, Room.S07) = lblRecessS07
        lblTableLinker(Period.RECESS, Room.S08) = lblRecessS08
        lblTableLinker(Period.RECESS, Room.S09) = lblRecessS09
        lblTableLinker(Period.RECESS, Room.S10) = lblRecessS10
        lblTableLinker(Period.PERIOD3, Room.S01) = lblPeriod3S01
        lblTableLinker(Period.PERIOD3, Room.S02) = lblPeriod3S02
        lblTableLinker(Period.PERIOD3, Room.S03) = lblPeriod3S03
        lblTableLinker(Period.PERIOD3, Room.S04) = lblPeriod3S04
        lblTableLinker(Period.PERIOD3, Room.S05) = lblPeriod3S05
        lblTableLinker(Period.PERIOD3, Room.S06) = lblPeriod3S06
        lblTableLinker(Period.PERIOD3, Room.S07) = lblPeriod3S07
        lblTableLinker(Period.PERIOD3, Room.S08) = lblPeriod3S08
        lblTableLinker(Period.PERIOD3, Room.S09) = lblPeriod3S09
        lblTableLinker(Period.PERIOD3, Room.S10) = lblPeriod3S10
        lblTableLinker(Period.PERIOD4, Room.S01) = lblPeriod4S01
        lblTableLinker(Period.PERIOD4, Room.S02) = lblPeriod4S02
        lblTableLinker(Period.PERIOD4, Room.S03) = lblPeriod4S03
        lblTableLinker(Period.PERIOD4, Room.S04) = lblPeriod4S04
        lblTableLinker(Period.PERIOD4, Room.S05) = lblPeriod4S05
        lblTableLinker(Period.PERIOD4, Room.S06) = lblPeriod4S06
        lblTableLinker(Period.PERIOD4, Room.S07) = lblPeriod4S07
        lblTableLinker(Period.PERIOD4, Room.S08) = lblPeriod4S08
        lblTableLinker(Period.PERIOD4, Room.S09) = lblPeriod4S09
        lblTableLinker(Period.PERIOD4, Room.S10) = lblPeriod4S10
        lblTableLinker(Period.LUNCH, Room.S01) = lblLunchS01
        lblTableLinker(Period.LUNCH, Room.S02) = lblLunchS02
        lblTableLinker(Period.LUNCH, Room.S03) = lblLunchS03
        lblTableLinker(Period.LUNCH, Room.S04) = lblLunchS04
        lblTableLinker(Period.LUNCH, Room.S05) = lblLunchS05
        lblTableLinker(Period.LUNCH, Room.S06) = lblLunchS06
        lblTableLinker(Period.LUNCH, Room.S07) = lblLunchS07
        lblTableLinker(Period.LUNCH, Room.S08) = lblLunchS08
        lblTableLinker(Period.LUNCH, Room.S09) = lblLunchS09
        lblTableLinker(Period.LUNCH, Room.S10) = lblLunchS10
        lblTableLinker(Period.PERIOD5, Room.S01) = lblPeriod5S01
        lblTableLinker(Period.PERIOD5, Room.S02) = lblPeriod5S02
        lblTableLinker(Period.PERIOD5, Room.S03) = lblPeriod5S03
        lblTableLinker(Period.PERIOD5, Room.S04) = lblPeriod5S04
        lblTableLinker(Period.PERIOD5, Room.S05) = lblPeriod5S05
        lblTableLinker(Period.PERIOD5, Room.S06) = lblPeriod5S06
        lblTableLinker(Period.PERIOD5, Room.S07) = lblPeriod5S07
        lblTableLinker(Period.PERIOD5, Room.S08) = lblPeriod5S08
        lblTableLinker(Period.PERIOD5, Room.S09) = lblPeriod5S09
        lblTableLinker(Period.PERIOD5, Room.S10) = lblPeriod5S10
        lblTableLinker(Period.PERIOD6, Room.S01) = lblPeriod6S01
        lblTableLinker(Period.PERIOD6, Room.S02) = lblPeriod6S02
        lblTableLinker(Period.PERIOD6, Room.S03) = lblPeriod6S03
        lblTableLinker(Period.PERIOD6, Room.S04) = lblPeriod6S04
        lblTableLinker(Period.PERIOD6, Room.S05) = lblPeriod6S06
        lblTableLinker(Period.PERIOD6, Room.S06) = lblPeriod6S05
        lblTableLinker(Period.PERIOD6, Room.S07) = lblPeriod6S07
        lblTableLinker(Period.PERIOD6, Room.S08) = lblPeriod6S08
        lblTableLinker(Period.PERIOD6, Room.S09) = lblPeriod6S09
        lblTableLinker(Period.PERIOD6, Room.S10) = lblPeriod6S10
    End Sub

    Private Function ReadFromDate(userChooseDate As Date)
        ' A function to read data from given file, or otherwise create a new file.
        ' Args:
        '   userChooseDate: the date that user chosen
        ' Return:
        '   A 2-dimension array, containing processed data from files

        Try
            ' A 2-dimensional dynamic array
            ' 1st dimension: Order Index
            ' 2nd dimension: 4 data
            ' Note that all the array starts from 0, ends with total - 1
            Dim strOrders(,) As String
            Dim strOrdersNoSplit As String ' Raw string readed from file
            Dim strOrdersSplitedByCrlf() As String ' Split raw string by CRLF

            ' Read data from assigned file
            strOrdersNoSplit = My.Computer.FileSystem.ReadAllText(
                "../date_files/" & userChooseDate.ToString("ddMMyy") & ".csv")
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
                For intItemIndex As Integer = 0 To 3
                    strOrders(intOrderIndex, intItemIndex) = strTempOrders(intItemIndex)
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

    Private Sub addOrder(ByVal strOrders(,) As String)
        ' Add orders into sttOrders array
        ' Args:
        '   strOrders: A string array contains the previous data

        ' An integer represents the number of rows in previous data
        Dim intRowNumber As Integer = strOrders.Length / 4
        ' Give a certain size to sttOrders
        ReDim sttOrders(intRowNumber - 1)

        ' Assign each value to sttOrders
        For intOrderIndex As Integer = 0 To intRowNumber - 1
            sttOrders(intOrderIndex) = New Order(strApplicantName:=strOrders(intOrderIndex, 0),
                                                 strPurpose:=strOrders(intOrderIndex, 1),
                                                 strRoom:=strOrders(intOrderIndex, 2),
                                                 strPeriod:=strOrders(intOrderIndex, 3))
        Next
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

        ' Store the date that user chooses
        Dim datUserChooseDate As Date = userSelectionRange.Start
        ' Store the previous data
        Dim strOrders(,) As String

        ' Read string data from assigned date, and convert into string array
        ' Otherwise, create a file if does not exist
        strOrders = ReadFromDate(datUserChooseDate.Date)
        ' Add the data which read previously to sttOrders
        addOrder(strOrders)

        initlblTableLinker()
        ' Paint color to allocated rooms
        For Each sttOrder As Order In sttOrders
            ' Paint Red to the given gird
            lblTableLinker(sttOrder.enmPeriod, sttOrder.enmRoom).BackColor = Color.Red
        Next
    End Sub

    Private Sub txtPurposeInput_TextChanged(sender As Object, e As EventArgs) Handles txtPurposeInput.TextChanged

    End Sub
End Class
