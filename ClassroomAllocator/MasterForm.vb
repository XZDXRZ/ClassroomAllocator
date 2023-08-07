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
'                   To
'                   romantic
'                   unfailing
'                   Elysia

Imports System.IO

Public Class MasterForm
    ' A dynamic array containing orders in the selected date
    Private sttOrders() As Order
    Private datCurrentChooseDate As Date
    Private utils As Utils = New Utils()

    Private Sub btnLoadTimetable_Click(sender As Object, e As EventArgs)
        ' Clear the table firstly
        utils.ClearTable()

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
        strOrders = utils.ReadFromDate(datCurrentChooseDate)
        ' Add the data which read previously to sttOrders
        utils.addOrder(sttOrders, strOrders)
        ' Assign value to lblTableLinker

        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()

        ' Paint color to allocated rooms
        For Each sttOrder As Order In sttOrders
            ' Paint Red to the given gird
            linker.lblTableLinker(sttOrder.enmPeriod, sttOrder.enmRoom).BackColor = Color.OrangeRed
        Next
    End Sub

    Private Sub btnAllocateByTime_Click(sender As Object, e As EventArgs)
        If cboTimeChoose.SelectedItem Is Nothing Then
            ' If the users have not choose a time, then inform them
            MsgBox("Please choose a time period", Title:="No Period Chosen Error")
            Exit Sub
        End If

        ' Clear the table
        utils.ClearGreenGrid()

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

    Private Sub btnAllocateByClassroom_Click(sender As Object, e As EventArgs)
        If cboClassroomChoose.SelectedItem Is Nothing Then
            ' If the users have not choose a room, then inform them
            MsgBox("Please choose a classroom", Title:="No Room Chosen Error")
            Exit Sub
        End If

        ' Clear the table
        utils.ClearGreenGrid()

        Dim rmmChoseRoom As Room = cboClassroomChoose.SelectedItem ' Get the item selected by user
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        For pedPeriodIndex As Period = Period.Tutorial To Period.Period6
            Dim lblTargetLabel As Label = linker.lblTableLinker(pedPeriodIndex, rmmChoseRoom)
            If Not lblTargetLabel.BackColor = Color.OrangeRed Then
                lblTargetLabel.BackColor = Color.PaleGreen
            End If
        Next
    End Sub

    Private Sub MasterForm_Load(sender As Object, e As EventArgs)
        ' Add items to two combo boxes
        For pedPeriod As Period = Period.Tutorial To Period.Period6
            cboTimeChoose.Items.Add(pedPeriod)
        Next
        For rmmRoom As Room = Room.S01 To Room.S10
            cboClassroomChoose.Items.Add(rmmRoom)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ' Clear all text boxes, combo boxes and reset table
        ' Clear text box
        txtApplicantNameInput.Text = Nothing
        txtPurposeInput.Text = Nothing
        ' Clear combo box
        cboClassroomChoose.SelectedItem = Nothing
        cboTimeChoose.SelectedItem = Nothing
        ' Clear the table
        utils.ClearTable()
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs)
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
        Else ' ?
            linker.lblTableLinker(pedChosenPeriod, rmmChosenRoom).BackColor = Color.OrangeRed
        End If

        ' Process data into .csv format
        strCombinedData = strInputApplicantName & "," & strInputPurpose & "," & rmmChosenRoom & "," & pedChosenPeriod & vbCrLf

        ' Write into .csv file
        My.Computer.FileSystem.WriteAllText(
                "../date_files/" & datUserChooseDate.ToString("ddMMyy") & ".csv",
                strCombinedData,
                True)

        ' Save data in the programme
        ReDim Preserve sttOrders(sttOrders.Length) ' Change the size of sttOrders by plus 1 and keep the data
        ' And record the new order
        sttOrders(sttOrders.Length - 1) = New Order(strApplicantName:=strInputApplicantName,
                                                    strPurpose:=strInputPurpose,
                                                    strPeriod:=pedChosenPeriod,
                                                    strRoom:=rmmChosenRoom)

        ' Inform user
        MsgBox("Record Saved!")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)
        MsgBox("How to use the system:" & vbCrLf & "Step 1, choose the date that you want for room booking" & vbCrLf & "Step 2, chooses the time and the classroom that is available or the system recommends." & vbCrLf & "Step 3, It is necessary to provide enough information. Such as name and purpose. The purpose of academics is acceptable." & vbCrLf & "Step 4, press the ‘submit’ button to send the order and the process of the booking is done." & vbCrLf & vbCrLf & "‘Clear’ button: Allow to use if the user needs to cancel the booking.",
               Title:="Help Doc")
    End Sub

    Private Sub btnClearGreen_Click(sender As Object, e As EventArgs)
        ' Clear green grids
        utils.ClearGreenGrid()
    End Sub
End Class
