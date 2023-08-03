' AUTHOR:           Lance Gong, Lambert Zhu, Tymon Ng
' CREATED DATE:     20/07/2023
' DESCRIPTION:      A programme to help manage and allocate classrooms for teachers
'                   and students for academic purposes.
' INPUTS:
' OUTPUTS:
' VERSION HISTORY:  V0.0.1 - 27/07/2023 - GUI nearly done
'                   V0.0.2 - 31/07/2023 - Major functions done
'                   V0.1.0 - 01/08/2023 - Finished Basic Functions
' COMMENT:          我永远喜欢爱丽希雅
'                   TruE

Imports System.IO

Public Class MasterForm
    ' A dynamic array containing orders in the selected date
    Private sttOrders() As Order
    Private datCurrentChooseDate As Date

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

            ' Inform the user if there is no order on this date
            MsgBox("Orders loaded, no order on this date", Title:="No Order")

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
        ' Clear the table firstly
        ClearTable()

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
        datCurrentChooseDate = userSelectionRange.Start
        ' Store the previous data
        Dim strOrders(,) As String

        ' Read string data from assigned date, and convert into string array
        ' Otherwise, create a file if does not exist
        strOrders = ReadFromDate(datCurrentChooseDate)
        ' Add the data which read previously to sttOrders
        addOrder(strOrders)
        ' Assign value to lblTableLinker

        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()

        ' Paint color to allocated rooms
        For Each sttOrder As Order In sttOrders
            ' Paint Red to the given gird
            linker.lblTableLinker(sttOrder.enmPeriod, sttOrder.enmRoom).BackColor = Color.OrangeRed
        Next
    End Sub

    Private Sub btnAllocateByTime_Click(sender As Object, e As EventArgs) Handles btnAllocateByTime.Click
        If cboTimeChoose.SelectedItem Is Nothing Then
            ' If the users have not choose a time, then inform them
            MsgBox("Please choose a time period", Title:="No Period Chosen Error")
            Exit Sub
        End If
        Dim pedChosePeriod As Period = cboTimeChoose.SelectedItem ' Get the item selected by user
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        For rmmRoomIndex As Room = Room.S01 To Room.S10
            Dim lblTargetLabel As Label = linker.lblTableLinker(pedChosePeriod, rmmRoomIndex)
            If Not lblTargetLabel.BackColor = Color.OrangeRed Then
                lblTargetLabel.BackColor = Color.PaleGreen
            End If
        Next
    End Sub

    Private Sub btnAllocateByClassroom_Click(sender As Object, e As EventArgs) Handles btnAllocateByClassroom.Click
        If cboClassroomChoose.SelectedItem Is Nothing Then
            ' If the users have not choose a room, then inform them
            MsgBox("Please choose a classroom", Title:="No Room Chosen Error")
            Exit Sub
        End If
        Dim rmmChoseRoom As Room = cboClassroomChoose.SelectedItem ' Get the item selected by user
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        For pedPeriodIndex As Period = Period.TUTORIAL To Period.PERIOD6
            Dim lblTargetLabel As Label = linker.lblTableLinker(pedPeriodIndex, rmmChoseRoom)
            If Not lblTargetLabel.BackColor = Color.OrangeRed Then
                lblTargetLabel.BackColor = Color.PaleGreen
            End If
        Next
    End Sub

    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to two combo boxes
        For pedPeriod As Period = Period.Tutorial To Period.Period6
            cboTimeChoose.Items.Add(pedPeriod)
        Next
        For rmmRoom As Room = Room.S01 To Room.S10
            cboClassroomChoose.Items.Add(rmmRoom)
        Next
    End Sub

    Private Sub ClearTable()
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        ' Reset table
        For pedPeriodIndex As Period = Period.TUTORIAL To Period.PERIOD6 ' traverse all labels in the table
            For rmmRoomIndex As Room = Room.S01 To Room.S10
                ' Different color in odd and even number row
                If pedPeriodIndex Mod 2 = 1 Then
                    linker.lblTableLinker(pedPeriodIndex, rmmRoomIndex).BackColor = Color.WhiteSmoke
                Else
                    linker.lblTableLinker(pedPeriodIndex, rmmRoomIndex).BackColor = Color.Gainsboro
                End If
            Next
        Next
    End Sub

    Private Sub ClearGreenGrid()
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        ' Clear green grid on the table
        For pedPeriodIndex As Period = Period.TUTORIAL To Period.PERIOD6 ' traverse all labels in the table
            For rmmRoomIndex As Room = Room.S01 To Room.S10
                ' Different color in odd and even number row
                If pedPeriodIndex Mod 2 = 1 And linker.lblTableLinker(pedPeriodIndex, rmmRoomIndex).BackColor = Color.PaleGreen Then
                    linker.lblTableLinker(pedPeriodIndex, rmmRoomIndex).BackColor = Color.WhiteSmoke
                ElseIf linker.lblTableLinker(pedPeriodIndex, rmmRoomIndex).BackColor = Color.PaleGreen Then
                    linker.lblTableLinker(pedPeriodIndex, rmmRoomIndex).BackColor = Color.Gainsboro
                End If
            Next
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all text boxes, combo boxes and reset table
        ' Clear text box
        txtApplicantNameInput.Text = Nothing
        txtPurposeInput.Text = Nothing
        ' Clear combo box
        cboClassroomChoose.SelectedItem = Nothing
        cboTimeChoose.SelectedItem = Nothing
        ' Clear the table
        ClearTable()
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        ' If the user leave one of Name, Purpose, Time and Room blank, then reject request and inform
        If txtApplicantNameInput.Text Is Nothing Or txtPurposeInput.Text Is Nothing Or cboClassroomChoose.SelectedItem Is Nothing Or cboTimeChoose.SelectedItem Is Nothing Then
            MsgBox("Please complete your Name, Purpose, Period and Room input", Title:="Order Rejected!")
            Exit Sub
        End If

        Dim strInputApplicantName As String
        Dim strInputPurpose As String
        Dim pedChosenPeriod As Period
        Dim rmmChosenRoom As Room

        ' Get user input data
        strInputApplicantName = txtApplicantNameInput.Text.ToString()
        strInputPurpose = txtPurposeInput.Text.ToString()
        pedChosenPeriod = cboTimeChoose.SelectedItem
        rmmChosenRoom = cboClassroomChoose.SelectedItem

        ' Get user input date
        Dim strCombinedData As String = Nothing
        Dim userSelectionRange As SelectionRange = New SelectionRange(cldrChooseDate.SelectionStart,
                                                                      cldrChooseDate.SelectionEnd)
        Dim datUserChooseDate As Date = userSelectionRange.Start

        ' Check if user choose another date after loading the timetable
        If datCurrentChooseDate <> datUserChooseDate Then
            MsgBox("Please load the timetable on your choosing date", Title:="Date Not Match Error")
            Exit Sub
        End If

        ' Check if the room is allocated
        Dim linker As LabelTableLinker = New LabelTableLinker
        If linker.lblTableLinker(pedChosenPeriod, rmmChosenRoom).BackColor = Color.OrangeRed Then
            MsgBox("The room is allocated. Order is Rejected", Title:="Room Already Allocated")
            Exit Sub
        End If

        ' Process data into .csv format
        strCombinedData = strInputApplicantName & "," & strInputPurpose & "," & rmmChosenRoom & "," & pedChosenPeriod & vbCrLf

        ' Write into .csv file
        My.Computer.FileSystem.WriteAllText(
                "../date_files/" & datUserChooseDate.ToString("ddMMyy") & ".csv",
                strCombinedData,
                True)

        ' Save data in the programme
        Dim sttTempOrders() As Order = sttOrders
        ReDim Preserve sttOrders(sttOrders.Length)
        sttOrders(sttOrders.Length - 1) = New Order(strApplicantName:=strInputApplicantName,
                                                    strPurpose:=strInputPurpose,
                                                    strPeriod:=pedChosenPeriod,
                                                    strRoom:=rmmChosenRoom)

        ' Inform user
        MsgBox("Record Saved!")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("How to use the system:" & vbCrLf & "Step 1, choose the date that you want for room booking" & vbCrLf & "Step 2, chooses the time and the classroom that is available or the system recommends." & vbCrLf & "Step 3, It is necessary to provide enough information. Such as name and purpose. The purpose of academics is acceptable." & vbCrLf & "Step 4, press the ‘submit’ button to send the order and the process of the booking is done." & vbCrLf & vbCrLf & "‘Clear’ button: Allow to use if the user needs to cancel the booking.",
               Title:="Help Doc")
    End Sub

    Private Sub btnClearGreen_Click(sender As Object, e As EventArgs) Handles btnClearGreen.Click
        ' Clear green grids
        ClearGreenGrid()
    End Sub
End Class
