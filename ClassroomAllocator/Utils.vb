Imports System.IO

Public Class Utils
    Public Function CheckUserInputDate()
        ' Judgement of whether user select one date
        Dim datUserSelectionStart As Date = MasterForm.cldrChooseDate.SelectionStart
        Dim datUserSelectionEnd As Date = MasterForm.cldrChooseDate.SelectionEnd
        Dim userSelectionRange As SelectionRange = New SelectionRange(datUserSelectionStart, datUserSelectionEnd)

        If userSelectionRange.Start <> userSelectionRange.End Then
            Return False
        End If
        Return True
    End Function

    Public Function ReadFromDate(userChooseDate As Date)
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

    Public Sub addOrder(ByRef sttOrders() As Order, ByVal strOrders(,) As String)
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

    Public Sub ClearTable()
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        ' Reset table
        For pedPeriodIndex As Period = Period.Tutorial To Period.Period6 ' traverse all labels in the table
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

    Public Sub ClearGreenGrid()
        ' Create a linker between the number pairs and Labels
        Dim linker As LabelTableLinker = New LabelTableLinker()
        ' Clear green grid on the table
        For pedPeriodIndex As Period = Period.Tutorial To Period.Period6 ' traverse all labels in the table
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

    Public Sub SaveRecord(ByRef sttOrders() As Order,
                          strInputApplicantName As String,
                          strInputPurpose As String,
                          rmmChosenRoom As Room,
                          pedChosenPeriod As Period,
                          datUserChooseDate As Date)
        Dim strCombinedData As String = Nothing

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

    Public Function CheckUserInput(ByRef strInputApplicantName As String,
                                   ByRef strInputPurpose As String,
                                   ByRef pedChosenPeriod As Period,
                                   ByRef rmmChosenRoom As Room,
                                   datCurrentChooseDate As Date)
        ' If the user leave one of Name, Purpose, Time and Room blank, then reject request and inform
        If MasterForm.txtApplicantNameInput.Text Is Nothing Or MasterForm.txtPurposeInput.Text Is Nothing Or pedChosenPeriod = 0 Or rmmChosenRoom = 0 Then
            MsgBox("Please complete your Name, Purpose, Period and Room input", Title:="Order Rejected!")
            Return False
        End If

        ' Get user input data
        strInputApplicantName = MasterForm.txtApplicantNameInput.Text.ToString()
        strInputPurpose = MasterForm.txtPurposeInput.Text.ToString()
        If pedChosenPeriod = 0 Or rmmChosenRoom = 0 Then
            pedChosenPeriod = MasterForm.cboTimeChoose.SelectedItem
            rmmChosenRoom = MasterForm.cboClassroomChoose.SelectedItem
        End If

        ' Get user input date
        Dim userSelectionRange As SelectionRange = New SelectionRange(MasterForm.cldrChooseDate.SelectionStart,
                                                                      MasterForm.cldrChooseDate.SelectionEnd)
        Dim datUserChooseDate As Date = userSelectionRange.Start

        ' Check if user choose another date after loading the timetable
        If datCurrentChooseDate <> datUserChooseDate Then
            MsgBox("Please load the timetable on your choosing date", Title:="Date Not Match Error")
            Return False
        End If

        ' Check if the room is allocated
        Dim linker As LabelTableLinker = New LabelTableLinker
        If linker.lblTableLinker(pedChosenPeriod, rmmChosenRoom).BackColor = Color.OrangeRed Then
            MsgBox("The room is allocated. Order is Rejected", Title:="Room Already Allocated")
            Return False
        Else
            linker.lblTableLinker(pedChosenPeriod, rmmChosenRoom).BackColor = Color.OrangeRed
        End If

        Return True
    End Function
End Class
