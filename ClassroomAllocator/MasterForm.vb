' AUTHOR:           Lance Gong, Lambert Zhu, Tymon Ng
' CREATED DATE:     20/07/2023
' DESCRIPTION:      A programme to help manage and allocate classrooms for teachers
'                   and students for academic purposes.
' INPUTS:
' OUTPUTS:
' VERSION HISTORY:  V0.0.1 - 27/07/2023 - GUI nearly done
'                   V0.0.2 - 31/07/2023 - Major functions done
'                   V0.1.0 - 01/08/2023 - Finished Basic Functions
'                   V0.2.0 - 10/08/2023 - Add Auto Allocation Function
' COMMENT:          我永远喜欢爱丽希雅
'                   To
'                   romantic
'                   unfailing
'                   Elysia

Public Class MasterForm
    ' A dynamic array containing orders in the selected date
    Private sttOrders() As Order
    Private datUserChooseDate As Date
    ' Utilities used in the programme
    Private utils As Utils = New Utils()

    Private Sub btnLoadTimetable_Click(sender As Object, e As EventArgs) Handles btnLoadTimetable.Click
        ' Clear the table firstly
        utils.ClearTable()

        ' Check whether the user has only chosen one date
        ' Inform the user if they choose more than one date and exit Sub
        If Not utils.CheckUserInputDate() Then
            MsgBox("Please choose one date", Title:="Choose date Error")
            Exit Sub
        End If

        ' Store the date that user chooses
        datUserChooseDate = cldrChooseDate.SelectionStart
        ' Store the previous data
        Dim strOrders(,) As String

        ' Read string data from assigned date, and convert into string array
        ' Otherwise, create a file if does not exist
        strOrders = utils.ReadFromDate(datUserChooseDate)
        ' Convert the string that read from file
        ' And add the data which read previously to sttOrders
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

    Private Sub btnAllocateByTime_Click(sender As Object, e As EventArgs) Handles btnAllocateByTime.Click
        If cboTimeChoose.SelectedItem Is Nothing Then
            ' If the users have not choose a time, then inform them
            MsgBox("Please choose a time period", Title:="No Period Chosen Error")
            Exit Sub
        End If

        ' Clear the table
        utils.ClearGreenGrid()

        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        Dim pedChosenPeriod As Period = cboTimeChoose.SelectedItem ' Get the item selected by user
        For rmmRoomIndex As Room = Room.S01 To Room.S10
            Dim lblAvailableLabel As Label = linker.lblTableLinker(pedChosenPeriod, rmmRoomIndex)
            If Not lblAvailableLabel.BackColor = Color.OrangeRed Then ' If the grid is painted red, then it's not available
                If cbAuto.Checked = True Then
                    lblAvailableLabel.BackColor = Color.Orange
                    Dim intUserInputToMsgbox As Integer
                    intUserInputToMsgbox = MsgBox("Are u ok with this?", Title:="Are u ok?", Buttons:=vbYesNo)
                    If intUserInputToMsgbox = vbYes Then
                        Dim strInputApplicantName As String = Nothing
                        Dim strInputPurpose As String = Nothing

                        Dim blnUserInputValidation As Boolean
                        blnUserInputValidation = utils.GetAndCheckUserInput(strInputApplicantName:=strInputApplicantName,
                                                                      strInputPurpose:=strInputPurpose,
                                                                      pedChosenPeriod:=pedChosenPeriod,
                                                                      rmmChosenRoom:=rmmRoomIndex,
                                                                      datUserChooseDate:=datUserChooseDate)

                        If Not blnUserInputValidation Then
                            Exit Sub
                        End If

                        utils.SaveRecord(sttOrders:=sttOrders,
                                         strInputApplicantName:=strInputApplicantName,
                                         strInputPurpose:=strInputPurpose,
                                         rmmChosenRoom:=rmmRoomIndex,
                                         pedChosenPeriod:=pedChosenPeriod,
                                         datUserChooseDate:=datUserChooseDate)

                        Exit Sub
                    Else
                        If pedChosenPeriod Mod 2 = 1 Then
                            lblAvailableLabel.BackColor = Color.WhiteSmoke
                        Else
                            lblAvailableLabel.BackColor = Color.Gainsboro
                        End If
                    End If
                Else
                    lblAvailableLabel.BackColor = Color.PaleGreen
                End If
            End If
        Next
    End Sub

    Private Sub btnAllocateByClassroom_Click(sender As Object, e As EventArgs) Handles btnAllocateByClassroom.Click
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
            Dim lblAvailableLabel As Label = linker.lblTableLinker(pedPeriodIndex, rmmChoseRoom)
            If Not lblAvailableLabel.BackColor = Color.OrangeRed Then
                If cbAuto.Checked = True Then
                    lblAvailableLabel.BackColor = Color.Orange
                    Dim intUserInputToMsgbox As Integer
                    intUserInputToMsgbox = MsgBox("Are u ok with this?", Title:="Are u ok?", Buttons:=vbYesNo)
                    If intUserInputToMsgbox = vbYes Then
                        Dim strInputApplicantName As String = Nothing
                        Dim strInputPurpose As String = Nothing

                        Dim blnUserInputValidation As Boolean
                        blnUserInputValidation = utils.GetAndCheckUserInput(strInputApplicantName:=strInputApplicantName,
                                                                      strInputPurpose:=strInputPurpose,
                                                                      pedChosenPeriod:=pedPeriodIndex,
                                                                      rmmChosenRoom:=rmmChoseRoom,
                                                                      datUserChooseDate:=datUserChooseDate)

                        If Not blnUserInputValidation Then
                            Exit Sub
                        End If

                        utils.SaveRecord(sttOrders:=sttOrders,
                                         strInputApplicantName:=strInputApplicantName,
                                         strInputPurpose:=strInputPurpose,
                                         rmmChosenRoom:=rmmChoseRoom,
                                         pedChosenPeriod:=pedPeriodIndex,
                                         datUserChooseDate:=datUserChooseDate)

                        Exit Sub
                    Else
                        If pedPeriodIndex Mod 2 = 1 Then
                            lblAvailableLabel.BackColor = Color.WhiteSmoke
                        Else
                            lblAvailableLabel.BackColor = Color.Gainsboro
                        End If
                    End If
                Else
                    lblAvailableLabel.BackColor = Color.PaleGreen
                End If
            End If
        Next
    End Sub

    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add items to two combo boxes
        For pedPeriod As Period = Period.Tutorial To Period.Period6
            cboTimeChoose.Items.Add(pedPeriod)
        Next
        For rmmRoom As Room = Room.S01 To Room.S10
            cboClassroomChoose.Items.Add(rmmRoom)
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
        ' Reset the table
        utils.ClearTable()
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        ' Declare variables to store user input data
        Dim strInputApplicantName As String = Nothing
        Dim strInputPurpose As String = Nothing
        Dim pedChosenPeriod As Period
        Dim rmmChosenRoom As Room

        ' Check if the user input is valid
        Dim blnUserInputValidation As Boolean
        blnUserInputValidation = utils.GetAndCheckUserInput(strInputApplicantName:=strInputApplicantName,
                                                      strInputPurpose:=strInputPurpose,
                                                      pedChosenPeriod:=pedChosenPeriod,
                                                      rmmChosenRoom:=rmmChosenRoom,
                                                      datUserChooseDate:=datUserChooseDate)
        ' If the user input is invalid, then exit the sub
        If Not blnUserInputValidation Then
            Exit Sub
        End If
        ' Otherwise, save the record into .csv file
        utils.SaveRecord(sttOrders:=sttOrders,
                         strInputApplicantName:=strInputApplicantName,
                         strInputPurpose:=strInputPurpose,
                         rmmChosenRoom:=rmmChosenRoom,
                         pedChosenPeriod:=pedChosenPeriod,
                         datUserChooseDate:=datUserChooseDate)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ' Show a messagebox to inform the user how to use the application
        MsgBox("How to use the system:" & vbCrLf & "Step 1, choose the date that you want for room booking" & vbCrLf & "Step 2, chooses the time and the classroom that is available or the system recommends." & vbCrLf & "Step 3, It is necessary to provide enough information. Such as name and purpose. The purpose of academics is acceptable." & vbCrLf & "Step 4, press the ‘submit’ button to send the order and the process of the booking is done." & vbCrLf & vbCrLf & "‘Clear’ button: Allow to use if the user needs to cancel the booking.",
               Title:="Help Doc")
    End Sub

    Private Sub btnClearGreen_Click(sender As Object, e As EventArgs) Handles btnClearGreen.Click
        ' Clear green grids
        utils.ClearGreenGrid()
    End Sub
End Class
