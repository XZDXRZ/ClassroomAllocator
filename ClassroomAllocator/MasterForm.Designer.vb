﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        picYarraLogo = New PictureBox()
        lblDateHeading = New Label()
        MonthCalendar = New MonthCalendar()
        btnLoadTimetable = New Button()
        lblApplicantNameHeading = New Label()
        txtApplicantNameInput = New TextBox()
        lblPurposeHeading = New Label()
        txtPurposeInput = New TextBox()
        lblTimeHeading = New Label()
        cboTimeChoose = New ComboBox()
        btnAllocateByTime = New Button()
        lblClassroomHeading = New Label()
        cboClassroomChoose = New ComboBox()
        btnAllocateByClassroom = New Button()
        tlpTimeTable = New TableLayoutPanel()
        lblPeriod4S07 = New Label()
        Label89 = New Label()
        Label80 = New Label()
        Label81 = New Label()
        lblPeriod4S10 = New Label()
        lblPeriod3S10 = New Label()
        lblRecessS10 = New Label()
        lblPeriod2S10 = New Label()
        lblPeriod1S10 = New Label()
        lblTutorialS10 = New Label()
        Label60 = New Label()
        Label61 = New Label()
        Label62 = New Label()
        lblPeriod4S09 = New Label()
        lblPeriod3S09 = New Label()
        lblRecessS09 = New Label()
        lblPeriod2S09 = New Label()
        lblPeriod1S09 = New Label()
        lblTutorialS09 = New Label()
        lblTutorialS08 = New Label()
        lblPeriod1S08 = New Label()
        lblPeriod2S08 = New Label()
        lblRecessS08 = New Label()
        lblPeriod3S08 = New Label()
        lblPeriod4S08 = New Label()
        Label76 = New Label()
        Label77 = New Label()
        Label78 = New Label()
        lblTutorialS07 = New Label()
        lblPeriod1S07 = New Label()
        lblPeriod2S07 = New Label()
        lblRecessS07 = New Label()
        lblPeriod3S07 = New Label()
        Label54 = New Label()
        Label55 = New Label()
        Label56 = New Label()
        lblPeriod4S06 = New Label()
        Label58 = New Label()
        Label59 = New Label()
        lblPeriod3S06 = New Label()
        lblRecessS06 = New Label()
        lblPeriod2S06 = New Label()
        lblPeriod1S06 = New Label()
        lblTutorialS06 = New Label()
        lblPeriod1S05 = New Label()
        lblTutorialS05 = New Label()
        lblPeriod2S05 = New Label()
        lblRecessS05 = New Label()
        lblPeriod3S05 = New Label()
        lblPeriod4S05 = New Label()
        Label42 = New Label()
        Label43 = New Label()
        Label44 = New Label()
        Label45 = New Label()
        lblPeriod4S04 = New Label()
        lblPeriod3S04 = New Label()
        lblRecessS04 = New Label()
        lblPeriod2S04 = New Label()
        lblPeriod1S04 = New Label()
        lblTutorialS04 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        lblPeriod4S03 = New Label()
        lblPeriod3S03 = New Label()
        lblRecessS03 = New Label()
        lblPeriod2S03 = New Label()
        lblPeriod1S03 = New Label()
        lblTutorialS03 = New Label()
        lblTutorialS02 = New Label()
        lblPeriod1S02 = New Label()
        lblPeriod2S02 = New Label()
        lblRecessS02 = New Label()
        lblPeriod3S02 = New Label()
        lblPeriod4S02 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        lblPeriod4S01 = New Label()
        lblPeriod3S01 = New Label()
        lblRecessS01 = New Label()
        lblPeriod2S01 = New Label()
        lblPeriod1S01 = New Label()
        Label73 = New Label()
        lblTutorial = New Label()
        lblS10 = New Label()
        lblS09 = New Label()
        lblS08 = New Label()
        lblS07 = New Label()
        lblS06 = New Label()
        lblS05 = New Label()
        lblS04 = New Label()
        lblS03 = New Label()
        lblS02 = New Label()
        lblS01 = New Label()
        lblPeriod5 = New Label()
        lblPeriod1 = New Label()
        lblPeriod2 = New Label()
        lblRecess = New Label()
        lblPeriod3 = New Label()
        lblPeriod4 = New Label()
        lblLunch = New Label()
        lblTutorialS01 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        lblPeriod6 = New Label()
        CType(picYarraLogo, ComponentModel.ISupportInitialize).BeginInit()
        tlpTimeTable.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Font = New Font("Algerian", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(558, 22)
        lblName.Name = "lblName"
        lblName.Size = New Size(403, 80)
        lblName.TabIndex = 0
        lblName.Text = "Yarra Valley Grammar Classroom Allocator"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picYarraLogo
        ' 
        picYarraLogo.Image = My.Resources.Resources.yarra_logo
        picYarraLogo.Location = New Point(983, 12)
        picYarraLogo.Name = "picYarraLogo"
        picYarraLogo.Size = New Size(114, 106)
        picYarraLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picYarraLogo.TabIndex = 1
        picYarraLogo.TabStop = False
        ' 
        ' lblDateHeading
        ' 
        lblDateHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateHeading.Location = New Point(23, 22)
        lblDateHeading.Name = "lblDateHeading"
        lblDateHeading.Size = New Size(144, 23)
        lblDateHeading.TabIndex = 2
        lblDateHeading.Text = "Choose a Date: "' 
        ' MonthCalendar
        ' 
        MonthCalendar.Location = New Point(23, 54)
        MonthCalendar.Name = "MonthCalendar"
        MonthCalendar.TabIndex = 3
        ' 
        ' btnLoadTimetable
        ' 
        btnLoadTimetable.BackColor = Color.LightGray
        btnLoadTimetable.Location = New Point(23, 228)
        btnLoadTimetable.Name = "btnLoadTimetable"
        btnLoadTimetable.Size = New Size(227, 31)
        btnLoadTimetable.TabIndex = 4
        btnLoadTimetable.Text = "Load Timetable"
        btnLoadTimetable.UseVisualStyleBackColor = False
        ' 
        ' lblApplicantNameHeading
        ' 
        lblApplicantNameHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblApplicantNameHeading.Location = New Point(283, 64)
        lblApplicantNameHeading.Name = "lblApplicantNameHeading"
        lblApplicantNameHeading.Size = New Size(148, 23)
        lblApplicantNameHeading.TabIndex = 5
        lblApplicantNameHeading.Text = "Applicant Name:"' 
        ' txtApplicantNameInput
        ' 
        txtApplicantNameInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtApplicantNameInput.Location = New Point(283, 102)
        txtApplicantNameInput.Name = "txtApplicantNameInput"
        txtApplicantNameInput.Size = New Size(204, 27)
        txtApplicantNameInput.TabIndex = 6
        ' 
        ' lblPurposeHeading
        ' 
        lblPurposeHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPurposeHeading.Location = New Point(283, 165)
        lblPurposeHeading.Name = "lblPurposeHeading"
        lblPurposeHeading.Size = New Size(148, 23)
        lblPurposeHeading.TabIndex = 7
        lblPurposeHeading.Text = "Purpose:"' 
        ' txtPurposeInput
        ' 
        txtPurposeInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPurposeInput.Location = New Point(283, 201)
        txtPurposeInput.Name = "txtPurposeInput"
        txtPurposeInput.Size = New Size(204, 27)
        txtPurposeInput.TabIndex = 8
        ' 
        ' lblTimeHeading
        ' 
        lblTimeHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTimeHeading.Location = New Point(558, 141)
        lblTimeHeading.Name = "lblTimeHeading"
        lblTimeHeading.Size = New Size(65, 23)
        lblTimeHeading.TabIndex = 9
        lblTimeHeading.Text = "Time:"' 
        ' cboTimeChoose
        ' 
        cboTimeChoose.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cboTimeChoose.FormattingEnabled = True
        cboTimeChoose.Location = New Point(668, 136)
        cboTimeChoose.Name = "cboTimeChoose"
        cboTimeChoose.Size = New Size(145, 28)
        cboTimeChoose.TabIndex = 11
        ' 
        ' btnAllocateByTime
        ' 
        btnAllocateByTime.BackColor = Color.LightGray
        btnAllocateByTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAllocateByTime.Location = New Point(831, 135)
        btnAllocateByTime.Name = "btnAllocateByTime"
        btnAllocateByTime.Size = New Size(152, 31)
        btnAllocateByTime.TabIndex = 12
        btnAllocateByTime.Text = "Allocate By Time"
        btnAllocateByTime.UseVisualStyleBackColor = False
        ' 
        ' lblClassroomHeading
        ' 
        lblClassroomHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblClassroomHeading.Location = New Point(558, 199)
        lblClassroomHeading.Name = "lblClassroomHeading"
        lblClassroomHeading.Size = New Size(118, 23)
        lblClassroomHeading.TabIndex = 13
        lblClassroomHeading.Text = "Classroom:"' 
        ' cboClassroomChoose
        ' 
        cboClassroomChoose.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cboClassroomChoose.FormattingEnabled = True
        cboClassroomChoose.Location = New Point(668, 200)
        cboClassroomChoose.Name = "cboClassroomChoose"
        cboClassroomChoose.Size = New Size(145, 28)
        cboClassroomChoose.TabIndex = 14
        ' 
        ' btnAllocateByClassroom
        ' 
        btnAllocateByClassroom.BackColor = Color.LightGray
        btnAllocateByClassroom.Location = New Point(831, 197)
        btnAllocateByClassroom.Name = "btnAllocateByClassroom"
        btnAllocateByClassroom.Size = New Size(130, 31)
        btnAllocateByClassroom.TabIndex = 15
        btnAllocateByClassroom.Text = "Allocate By Room"
        btnAllocateByClassroom.UseVisualStyleBackColor = False
        ' 
        ' tlpTimeTable
        ' 
        tlpTimeTable.Anchor = AnchorStyles.None
        tlpTimeTable.BackColor = Color.WhiteSmoke
        tlpTimeTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tlpTimeTable.ColumnCount = 11
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.30432F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.669567F))
        tlpTimeTable.Controls.Add(lblPeriod4S07, 7, 6)
        tlpTimeTable.Controls.Add(Label89, 10, 9)
        tlpTimeTable.Controls.Add(Label80, 10, 8)
        tlpTimeTable.Controls.Add(Label81, 10, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S10, 10, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S10, 10, 5)
        tlpTimeTable.Controls.Add(lblRecessS10, 10, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S10, 10, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S10, 10, 2)
        tlpTimeTable.Controls.Add(lblTutorialS10, 10, 1)
        tlpTimeTable.Controls.Add(Label60, 9, 9)
        tlpTimeTable.Controls.Add(Label61, 9, 8)
        tlpTimeTable.Controls.Add(Label62, 9, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S09, 9, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S09, 9, 5)
        tlpTimeTable.Controls.Add(lblRecessS09, 9, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S09, 9, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S09, 9, 2)
        tlpTimeTable.Controls.Add(lblTutorialS09, 9, 1)
        tlpTimeTable.Controls.Add(lblTutorialS08, 8, 1)
        tlpTimeTable.Controls.Add(lblPeriod1S08, 8, 2)
        tlpTimeTable.Controls.Add(lblPeriod2S08, 8, 3)
        tlpTimeTable.Controls.Add(lblRecessS08, 8, 4)
        tlpTimeTable.Controls.Add(lblPeriod3S08, 8, 5)
        tlpTimeTable.Controls.Add(lblPeriod4S08, 8, 6)
        tlpTimeTable.Controls.Add(Label76, 8, 7)
        tlpTimeTable.Controls.Add(Label77, 8, 8)
        tlpTimeTable.Controls.Add(Label78, 8, 9)
        tlpTimeTable.Controls.Add(lblTutorialS07, 7, 1)
        tlpTimeTable.Controls.Add(lblPeriod1S07, 7, 2)
        tlpTimeTable.Controls.Add(lblPeriod2S07, 7, 3)
        tlpTimeTable.Controls.Add(lblRecessS07, 7, 4)
        tlpTimeTable.Controls.Add(lblPeriod3S07, 7, 5)
        tlpTimeTable.Controls.Add(Label54, 7, 7)
        tlpTimeTable.Controls.Add(Label55, 7, 8)
        tlpTimeTable.Controls.Add(Label56, 7, 9)
        tlpTimeTable.Controls.Add(lblPeriod4S06, 6, 6)
        tlpTimeTable.Controls.Add(Label58, 6, 7)
        tlpTimeTable.Controls.Add(Label59, 6, 8)
        tlpTimeTable.Controls.Add(lblPeriod3S06, 6, 5)
        tlpTimeTable.Controls.Add(lblRecessS06, 6, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S06, 6, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S06, 6, 2)
        tlpTimeTable.Controls.Add(lblTutorialS06, 6, 1)
        tlpTimeTable.Controls.Add(lblPeriod1S05, 5, 2)
        tlpTimeTable.Controls.Add(lblTutorialS05, 5, 1)
        tlpTimeTable.Controls.Add(lblPeriod2S05, 5, 3)
        tlpTimeTable.Controls.Add(lblRecessS05, 5, 4)
        tlpTimeTable.Controls.Add(lblPeriod3S05, 5, 5)
        tlpTimeTable.Controls.Add(lblPeriod4S05, 5, 6)
        tlpTimeTable.Controls.Add(Label42, 5, 7)
        tlpTimeTable.Controls.Add(Label43, 5, 8)
        tlpTimeTable.Controls.Add(Label44, 4, 8)
        tlpTimeTable.Controls.Add(Label45, 4, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S04, 4, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S04, 4, 5)
        tlpTimeTable.Controls.Add(lblRecessS04, 4, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S04, 4, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S04, 4, 2)
        tlpTimeTable.Controls.Add(lblTutorialS04, 4, 1)
        tlpTimeTable.Controls.Add(Label14, 3, 8)
        tlpTimeTable.Controls.Add(Label15, 3, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S03, 3, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S03, 3, 5)
        tlpTimeTable.Controls.Add(lblRecessS03, 3, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S03, 3, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S03, 3, 2)
        tlpTimeTable.Controls.Add(lblTutorialS03, 3, 1)
        tlpTimeTable.Controls.Add(lblTutorialS02, 2, 1)
        tlpTimeTable.Controls.Add(lblPeriod1S02, 2, 2)
        tlpTimeTable.Controls.Add(lblPeriod2S02, 2, 3)
        tlpTimeTable.Controls.Add(lblRecessS02, 2, 4)
        tlpTimeTable.Controls.Add(lblPeriod3S02, 2, 5)
        tlpTimeTable.Controls.Add(lblPeriod4S02, 2, 6)
        tlpTimeTable.Controls.Add(Label28, 2, 7)
        tlpTimeTable.Controls.Add(Label29, 1, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S01, 1, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S01, 1, 5)
        tlpTimeTable.Controls.Add(lblRecessS01, 1, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S01, 1, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S01, 1, 2)
        tlpTimeTable.Controls.Add(Label73, 2, 8)
        tlpTimeTable.Controls.Add(lblTutorial, 0, 1)
        tlpTimeTable.Controls.Add(lblS10, 10, 0)
        tlpTimeTable.Controls.Add(lblS09, 9, 0)
        tlpTimeTable.Controls.Add(lblS08, 8, 0)
        tlpTimeTable.Controls.Add(lblS07, 7, 0)
        tlpTimeTable.Controls.Add(lblS06, 6, 0)
        tlpTimeTable.Controls.Add(lblS05, 5, 0)
        tlpTimeTable.Controls.Add(lblS04, 4, 0)
        tlpTimeTable.Controls.Add(lblS03, 3, 0)
        tlpTimeTable.Controls.Add(lblS02, 2, 0)
        tlpTimeTable.Controls.Add(lblS01, 1, 0)
        tlpTimeTable.Controls.Add(lblPeriod5, 0, 8)
        tlpTimeTable.Controls.Add(lblPeriod1, 0, 2)
        tlpTimeTable.Controls.Add(lblPeriod2, 0, 3)
        tlpTimeTable.Controls.Add(lblRecess, 0, 4)
        tlpTimeTable.Controls.Add(lblPeriod3, 0, 5)
        tlpTimeTable.Controls.Add(lblPeriod4, 0, 6)
        tlpTimeTable.Controls.Add(lblLunch, 0, 7)
        tlpTimeTable.Controls.Add(lblTutorialS01, 1, 1)
        tlpTimeTable.Controls.Add(Label1, 1, 9)
        tlpTimeTable.Controls.Add(Label3, 1, 8)
        tlpTimeTable.Controls.Add(Label6, 1, 9)
        tlpTimeTable.Controls.Add(Label9, 2, 9)
        tlpTimeTable.Controls.Add(Label8, 2, 9)
        tlpTimeTable.Controls.Add(Label7, 1, 9)
        tlpTimeTable.Controls.Add(Label4, 1, 9)
        tlpTimeTable.Controls.Add(lblPeriod6, 0, 9)
        tlpTimeTable.Location = New Point(67, 285)
        tlpTimeTable.Name = "tlpTimeTable"
        tlpTimeTable.RowCount = 10
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpTimeTable.Size = New Size(997, 466)
        tlpTimeTable.TabIndex = 16
        ' 
        ' lblPeriod4S07
        ' 
        lblPeriod4S07.Anchor = AnchorStyles.None
        lblPeriod4S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S07.Location = New Point(652, 278)
        lblPeriod4S07.Name = "lblPeriod4S07"
        lblPeriod4S07.Size = New Size(79, 42)
        lblPeriod4S07.TabIndex = 43
        lblPeriod4S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label89
        ' 
        Label89.Anchor = AnchorStyles.None
        Label89.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label89.Location = New Point(912, 419)
        Label89.Name = "Label89"
        Label89.Size = New Size(79, 42)
        Label89.TabIndex = 33
        Label89.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label80
        ' 
        Label80.Anchor = AnchorStyles.None
        Label80.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label80.Location = New Point(912, 370)
        Label80.Name = "Label80"
        Label80.Size = New Size(79, 42)
        Label80.TabIndex = 33
        Label80.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label81
        ' 
        Label81.Anchor = AnchorStyles.None
        Label81.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label81.Location = New Point(912, 324)
        Label81.Name = "Label81"
        Label81.Size = New Size(79, 42)
        Label81.TabIndex = 34
        Label81.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S10
        ' 
        lblPeriod4S10.Anchor = AnchorStyles.None
        lblPeriod4S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S10.Location = New Point(912, 278)
        lblPeriod4S10.Name = "lblPeriod4S10"
        lblPeriod4S10.Size = New Size(79, 42)
        lblPeriod4S10.TabIndex = 35
        lblPeriod4S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S10
        ' 
        lblPeriod3S10.Anchor = AnchorStyles.None
        lblPeriod3S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S10.Location = New Point(912, 232)
        lblPeriod3S10.Name = "lblPeriod3S10"
        lblPeriod3S10.Size = New Size(79, 42)
        lblPeriod3S10.TabIndex = 36
        lblPeriod3S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS10
        ' 
        lblRecessS10.Anchor = AnchorStyles.None
        lblRecessS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS10.Location = New Point(912, 186)
        lblRecessS10.Name = "lblRecessS10"
        lblRecessS10.Size = New Size(79, 42)
        lblRecessS10.TabIndex = 37
        lblRecessS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S10
        ' 
        lblPeriod2S10.Anchor = AnchorStyles.None
        lblPeriod2S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S10.Location = New Point(912, 140)
        lblPeriod2S10.Name = "lblPeriod2S10"
        lblPeriod2S10.Size = New Size(79, 42)
        lblPeriod2S10.TabIndex = 38
        lblPeriod2S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S10
        ' 
        lblPeriod1S10.Anchor = AnchorStyles.None
        lblPeriod1S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S10.Location = New Point(912, 94)
        lblPeriod1S10.Name = "lblPeriod1S10"
        lblPeriod1S10.Size = New Size(79, 42)
        lblPeriod1S10.TabIndex = 39
        lblPeriod1S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS10
        ' 
        lblTutorialS10.Anchor = AnchorStyles.None
        lblTutorialS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS10.Location = New Point(912, 48)
        lblTutorialS10.Name = "lblTutorialS10"
        lblTutorialS10.Size = New Size(79, 42)
        lblTutorialS10.TabIndex = 40
        lblTutorialS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label60
        ' 
        Label60.Anchor = AnchorStyles.None
        Label60.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label60.Location = New Point(824, 419)
        Label60.Name = "Label60"
        Label60.Size = New Size(79, 42)
        Label60.TabIndex = 33
        Label60.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label61
        ' 
        Label61.Anchor = AnchorStyles.None
        Label61.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label61.Location = New Point(824, 370)
        Label61.Name = "Label61"
        Label61.Size = New Size(79, 42)
        Label61.TabIndex = 34
        Label61.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label62
        ' 
        Label62.Anchor = AnchorStyles.None
        Label62.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label62.Location = New Point(824, 324)
        Label62.Name = "Label62"
        Label62.Size = New Size(79, 42)
        Label62.TabIndex = 35
        Label62.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S09
        ' 
        lblPeriod4S09.Anchor = AnchorStyles.None
        lblPeriod4S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S09.Location = New Point(824, 278)
        lblPeriod4S09.Name = "lblPeriod4S09"
        lblPeriod4S09.Size = New Size(79, 42)
        lblPeriod4S09.TabIndex = 36
        lblPeriod4S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S09
        ' 
        lblPeriod3S09.Anchor = AnchorStyles.None
        lblPeriod3S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S09.Location = New Point(824, 232)
        lblPeriod3S09.Name = "lblPeriod3S09"
        lblPeriod3S09.Size = New Size(79, 42)
        lblPeriod3S09.TabIndex = 37
        lblPeriod3S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS09
        ' 
        lblRecessS09.Anchor = AnchorStyles.None
        lblRecessS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS09.Location = New Point(824, 186)
        lblRecessS09.Name = "lblRecessS09"
        lblRecessS09.Size = New Size(79, 42)
        lblRecessS09.TabIndex = 38
        lblRecessS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S09
        ' 
        lblPeriod2S09.Anchor = AnchorStyles.None
        lblPeriod2S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S09.Location = New Point(824, 140)
        lblPeriod2S09.Name = "lblPeriod2S09"
        lblPeriod2S09.Size = New Size(79, 42)
        lblPeriod2S09.TabIndex = 39
        lblPeriod2S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S09
        ' 
        lblPeriod1S09.Anchor = AnchorStyles.None
        lblPeriod1S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S09.Location = New Point(824, 94)
        lblPeriod1S09.Name = "lblPeriod1S09"
        lblPeriod1S09.Size = New Size(79, 42)
        lblPeriod1S09.TabIndex = 40
        lblPeriod1S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS09
        ' 
        lblTutorialS09.Anchor = AnchorStyles.None
        lblTutorialS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS09.Location = New Point(824, 48)
        lblTutorialS09.Name = "lblTutorialS09"
        lblTutorialS09.Size = New Size(79, 42)
        lblTutorialS09.TabIndex = 41
        lblTutorialS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS08
        ' 
        lblTutorialS08.Anchor = AnchorStyles.None
        lblTutorialS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS08.Location = New Point(738, 48)
        lblTutorialS08.Name = "lblTutorialS08"
        lblTutorialS08.Size = New Size(79, 42)
        lblTutorialS08.TabIndex = 42
        lblTutorialS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S08
        ' 
        lblPeriod1S08.Anchor = AnchorStyles.None
        lblPeriod1S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S08.Location = New Point(738, 94)
        lblPeriod1S08.Name = "lblPeriod1S08"
        lblPeriod1S08.Size = New Size(79, 42)
        lblPeriod1S08.TabIndex = 43
        lblPeriod1S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S08
        ' 
        lblPeriod2S08.Anchor = AnchorStyles.None
        lblPeriod2S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S08.Location = New Point(738, 140)
        lblPeriod2S08.Name = "lblPeriod2S08"
        lblPeriod2S08.Size = New Size(79, 42)
        lblPeriod2S08.TabIndex = 44
        lblPeriod2S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS08
        ' 
        lblRecessS08.Anchor = AnchorStyles.None
        lblRecessS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS08.Location = New Point(738, 186)
        lblRecessS08.Name = "lblRecessS08"
        lblRecessS08.Size = New Size(79, 42)
        lblRecessS08.TabIndex = 45
        lblRecessS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S08
        ' 
        lblPeriod3S08.Anchor = AnchorStyles.None
        lblPeriod3S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S08.Location = New Point(738, 232)
        lblPeriod3S08.Name = "lblPeriod3S08"
        lblPeriod3S08.Size = New Size(79, 42)
        lblPeriod3S08.TabIndex = 46
        lblPeriod3S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S08
        ' 
        lblPeriod4S08.Anchor = AnchorStyles.None
        lblPeriod4S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S08.Location = New Point(738, 278)
        lblPeriod4S08.Name = "lblPeriod4S08"
        lblPeriod4S08.Size = New Size(79, 42)
        lblPeriod4S08.TabIndex = 47
        lblPeriod4S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label76
        ' 
        Label76.Anchor = AnchorStyles.None
        Label76.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label76.Location = New Point(738, 324)
        Label76.Name = "Label76"
        Label76.Size = New Size(79, 42)
        Label76.TabIndex = 48
        Label76.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label77
        ' 
        Label77.Anchor = AnchorStyles.None
        Label77.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label77.Location = New Point(738, 370)
        Label77.Name = "Label77"
        Label77.Size = New Size(79, 42)
        Label77.TabIndex = 49
        Label77.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label78
        ' 
        Label78.Anchor = AnchorStyles.None
        Label78.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label78.Location = New Point(738, 419)
        Label78.Name = "Label78"
        Label78.Size = New Size(79, 42)
        Label78.TabIndex = 50
        Label78.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS07
        ' 
        lblTutorialS07.Anchor = AnchorStyles.None
        lblTutorialS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS07.Location = New Point(652, 48)
        lblTutorialS07.Name = "lblTutorialS07"
        lblTutorialS07.Size = New Size(79, 42)
        lblTutorialS07.TabIndex = 51
        lblTutorialS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S07
        ' 
        lblPeriod1S07.Anchor = AnchorStyles.None
        lblPeriod1S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S07.Location = New Point(652, 94)
        lblPeriod1S07.Name = "lblPeriod1S07"
        lblPeriod1S07.Size = New Size(79, 42)
        lblPeriod1S07.TabIndex = 33
        lblPeriod1S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S07
        ' 
        lblPeriod2S07.Anchor = AnchorStyles.None
        lblPeriod2S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S07.Location = New Point(652, 140)
        lblPeriod2S07.Name = "lblPeriod2S07"
        lblPeriod2S07.Size = New Size(79, 42)
        lblPeriod2S07.TabIndex = 34
        lblPeriod2S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS07
        ' 
        lblRecessS07.Anchor = AnchorStyles.None
        lblRecessS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS07.Location = New Point(652, 186)
        lblRecessS07.Name = "lblRecessS07"
        lblRecessS07.Size = New Size(79, 42)
        lblRecessS07.TabIndex = 35
        lblRecessS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S07
        ' 
        lblPeriod3S07.Anchor = AnchorStyles.None
        lblPeriod3S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S07.Location = New Point(652, 232)
        lblPeriod3S07.Name = "lblPeriod3S07"
        lblPeriod3S07.Size = New Size(79, 42)
        lblPeriod3S07.TabIndex = 36
        lblPeriod3S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label54
        ' 
        Label54.Anchor = AnchorStyles.None
        Label54.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label54.Location = New Point(652, 324)
        Label54.Name = "Label54"
        Label54.Size = New Size(79, 42)
        Label54.TabIndex = 37
        Label54.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label55
        ' 
        Label55.Anchor = AnchorStyles.None
        Label55.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label55.Location = New Point(652, 370)
        Label55.Name = "Label55"
        Label55.Size = New Size(79, 42)
        Label55.TabIndex = 38
        Label55.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label56
        ' 
        Label56.Anchor = AnchorStyles.None
        Label56.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label56.Location = New Point(652, 419)
        Label56.Name = "Label56"
        Label56.Size = New Size(79, 42)
        Label56.TabIndex = 39
        Label56.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S06
        ' 
        lblPeriod4S06.Anchor = AnchorStyles.None
        lblPeriod4S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S06.Location = New Point(566, 278)
        lblPeriod4S06.Name = "lblPeriod4S06"
        lblPeriod4S06.Size = New Size(79, 42)
        lblPeriod4S06.TabIndex = 40
        lblPeriod4S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label58
        ' 
        Label58.Anchor = AnchorStyles.None
        Label58.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label58.Location = New Point(566, 324)
        Label58.Name = "Label58"
        Label58.Size = New Size(79, 42)
        Label58.TabIndex = 41
        Label58.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label59
        ' 
        Label59.Anchor = AnchorStyles.None
        Label59.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label59.Location = New Point(566, 370)
        Label59.Name = "Label59"
        Label59.Size = New Size(79, 42)
        Label59.TabIndex = 42
        Label59.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S06
        ' 
        lblPeriod3S06.Anchor = AnchorStyles.None
        lblPeriod3S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S06.Location = New Point(566, 232)
        lblPeriod3S06.Name = "lblPeriod3S06"
        lblPeriod3S06.Size = New Size(79, 42)
        lblPeriod3S06.TabIndex = 33
        lblPeriod3S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS06
        ' 
        lblRecessS06.Anchor = AnchorStyles.None
        lblRecessS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS06.Location = New Point(566, 186)
        lblRecessS06.Name = "lblRecessS06"
        lblRecessS06.Size = New Size(79, 42)
        lblRecessS06.TabIndex = 34
        lblRecessS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S06
        ' 
        lblPeriod2S06.Anchor = AnchorStyles.None
        lblPeriod2S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S06.Location = New Point(566, 140)
        lblPeriod2S06.Name = "lblPeriod2S06"
        lblPeriod2S06.Size = New Size(79, 42)
        lblPeriod2S06.TabIndex = 35
        lblPeriod2S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S06
        ' 
        lblPeriod1S06.Anchor = AnchorStyles.None
        lblPeriod1S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S06.Location = New Point(566, 94)
        lblPeriod1S06.Name = "lblPeriod1S06"
        lblPeriod1S06.Size = New Size(79, 42)
        lblPeriod1S06.TabIndex = 36
        lblPeriod1S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS06
        ' 
        lblTutorialS06.Anchor = AnchorStyles.None
        lblTutorialS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS06.Location = New Point(566, 48)
        lblTutorialS06.Name = "lblTutorialS06"
        lblTutorialS06.Size = New Size(79, 42)
        lblTutorialS06.TabIndex = 37
        lblTutorialS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S05
        ' 
        lblPeriod1S05.Anchor = AnchorStyles.None
        lblPeriod1S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S05.Location = New Point(480, 94)
        lblPeriod1S05.Name = "lblPeriod1S05"
        lblPeriod1S05.Size = New Size(79, 42)
        lblPeriod1S05.TabIndex = 38
        lblPeriod1S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS05
        ' 
        lblTutorialS05.Anchor = AnchorStyles.None
        lblTutorialS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS05.Location = New Point(480, 48)
        lblTutorialS05.Name = "lblTutorialS05"
        lblTutorialS05.Size = New Size(79, 42)
        lblTutorialS05.TabIndex = 39
        lblTutorialS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S05
        ' 
        lblPeriod2S05.Anchor = AnchorStyles.None
        lblPeriod2S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S05.Location = New Point(480, 140)
        lblPeriod2S05.Name = "lblPeriod2S05"
        lblPeriod2S05.Size = New Size(79, 42)
        lblPeriod2S05.TabIndex = 40
        lblPeriod2S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS05
        ' 
        lblRecessS05.Anchor = AnchorStyles.None
        lblRecessS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS05.Location = New Point(480, 186)
        lblRecessS05.Name = "lblRecessS05"
        lblRecessS05.Size = New Size(79, 42)
        lblRecessS05.TabIndex = 41
        lblRecessS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S05
        ' 
        lblPeriod3S05.Anchor = AnchorStyles.None
        lblPeriod3S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S05.Location = New Point(480, 232)
        lblPeriod3S05.Name = "lblPeriod3S05"
        lblPeriod3S05.Size = New Size(79, 42)
        lblPeriod3S05.TabIndex = 42
        lblPeriod3S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S05
        ' 
        lblPeriod4S05.Anchor = AnchorStyles.None
        lblPeriod4S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S05.Location = New Point(480, 278)
        lblPeriod4S05.Name = "lblPeriod4S05"
        lblPeriod4S05.Size = New Size(79, 42)
        lblPeriod4S05.TabIndex = 43
        lblPeriod4S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label42
        ' 
        Label42.Anchor = AnchorStyles.None
        Label42.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label42.Location = New Point(480, 324)
        Label42.Name = "Label42"
        Label42.Size = New Size(79, 42)
        Label42.TabIndex = 44
        Label42.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label43
        ' 
        Label43.Anchor = AnchorStyles.None
        Label43.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label43.Location = New Point(480, 370)
        Label43.Name = "Label43"
        Label43.Size = New Size(79, 42)
        Label43.TabIndex = 45
        Label43.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label44
        ' 
        Label44.Anchor = AnchorStyles.None
        Label44.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label44.Location = New Point(394, 370)
        Label44.Name = "Label44"
        Label44.Size = New Size(79, 42)
        Label44.TabIndex = 46
        Label44.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label45
        ' 
        Label45.Anchor = AnchorStyles.None
        Label45.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label45.Location = New Point(394, 324)
        Label45.Name = "Label45"
        Label45.Size = New Size(79, 42)
        Label45.TabIndex = 47
        Label45.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S04
        ' 
        lblPeriod4S04.Anchor = AnchorStyles.None
        lblPeriod4S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S04.Location = New Point(394, 278)
        lblPeriod4S04.Name = "lblPeriod4S04"
        lblPeriod4S04.Size = New Size(79, 42)
        lblPeriod4S04.TabIndex = 48
        lblPeriod4S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S04
        ' 
        lblPeriod3S04.Anchor = AnchorStyles.None
        lblPeriod3S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S04.Location = New Point(394, 232)
        lblPeriod3S04.Name = "lblPeriod3S04"
        lblPeriod3S04.Size = New Size(79, 42)
        lblPeriod3S04.TabIndex = 49
        lblPeriod3S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS04
        ' 
        lblRecessS04.Anchor = AnchorStyles.None
        lblRecessS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS04.Location = New Point(394, 186)
        lblRecessS04.Name = "lblRecessS04"
        lblRecessS04.Size = New Size(79, 42)
        lblRecessS04.TabIndex = 50
        lblRecessS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S04
        ' 
        lblPeriod2S04.Anchor = AnchorStyles.None
        lblPeriod2S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S04.Location = New Point(394, 140)
        lblPeriod2S04.Name = "lblPeriod2S04"
        lblPeriod2S04.Size = New Size(79, 42)
        lblPeriod2S04.TabIndex = 51
        lblPeriod2S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S04
        ' 
        lblPeriod1S04.Anchor = AnchorStyles.None
        lblPeriod1S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S04.Location = New Point(394, 94)
        lblPeriod1S04.Name = "lblPeriod1S04"
        lblPeriod1S04.Size = New Size(79, 42)
        lblPeriod1S04.TabIndex = 33
        lblPeriod1S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS04
        ' 
        lblTutorialS04.Anchor = AnchorStyles.None
        lblTutorialS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS04.Location = New Point(394, 48)
        lblTutorialS04.Name = "lblTutorialS04"
        lblTutorialS04.Size = New Size(79, 42)
        lblTutorialS04.TabIndex = 34
        lblTutorialS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(308, 370)
        Label14.Name = "Label14"
        Label14.Size = New Size(79, 42)
        Label14.TabIndex = 35
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.None
        Label15.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(308, 324)
        Label15.Name = "Label15"
        Label15.Size = New Size(79, 42)
        Label15.TabIndex = 36
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S03
        ' 
        lblPeriod4S03.Anchor = AnchorStyles.None
        lblPeriod4S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S03.Location = New Point(308, 278)
        lblPeriod4S03.Name = "lblPeriod4S03"
        lblPeriod4S03.Size = New Size(79, 42)
        lblPeriod4S03.TabIndex = 37
        lblPeriod4S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S03
        ' 
        lblPeriod3S03.Anchor = AnchorStyles.None
        lblPeriod3S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S03.Location = New Point(308, 232)
        lblPeriod3S03.Name = "lblPeriod3S03"
        lblPeriod3S03.Size = New Size(79, 42)
        lblPeriod3S03.TabIndex = 38
        lblPeriod3S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS03
        ' 
        lblRecessS03.Anchor = AnchorStyles.None
        lblRecessS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS03.Location = New Point(308, 186)
        lblRecessS03.Name = "lblRecessS03"
        lblRecessS03.Size = New Size(79, 42)
        lblRecessS03.TabIndex = 39
        lblRecessS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S03
        ' 
        lblPeriod2S03.Anchor = AnchorStyles.None
        lblPeriod2S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S03.Location = New Point(308, 140)
        lblPeriod2S03.Name = "lblPeriod2S03"
        lblPeriod2S03.Size = New Size(79, 42)
        lblPeriod2S03.TabIndex = 40
        lblPeriod2S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S03
        ' 
        lblPeriod1S03.Anchor = AnchorStyles.None
        lblPeriod1S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S03.Location = New Point(308, 94)
        lblPeriod1S03.Name = "lblPeriod1S03"
        lblPeriod1S03.Size = New Size(79, 42)
        lblPeriod1S03.TabIndex = 41
        lblPeriod1S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS03
        ' 
        lblTutorialS03.Anchor = AnchorStyles.None
        lblTutorialS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS03.Location = New Point(308, 48)
        lblTutorialS03.Name = "lblTutorialS03"
        lblTutorialS03.Size = New Size(79, 42)
        lblTutorialS03.TabIndex = 42
        lblTutorialS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS02
        ' 
        lblTutorialS02.Anchor = AnchorStyles.None
        lblTutorialS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS02.Location = New Point(222, 48)
        lblTutorialS02.Name = "lblTutorialS02"
        lblTutorialS02.Size = New Size(79, 42)
        lblTutorialS02.TabIndex = 43
        lblTutorialS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S02
        ' 
        lblPeriod1S02.Anchor = AnchorStyles.None
        lblPeriod1S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S02.Location = New Point(222, 94)
        lblPeriod1S02.Name = "lblPeriod1S02"
        lblPeriod1S02.Size = New Size(79, 42)
        lblPeriod1S02.TabIndex = 44
        lblPeriod1S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S02
        ' 
        lblPeriod2S02.Anchor = AnchorStyles.None
        lblPeriod2S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S02.Location = New Point(222, 140)
        lblPeriod2S02.Name = "lblPeriod2S02"
        lblPeriod2S02.Size = New Size(79, 42)
        lblPeriod2S02.TabIndex = 45
        lblPeriod2S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS02
        ' 
        lblRecessS02.Anchor = AnchorStyles.None
        lblRecessS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS02.Location = New Point(222, 186)
        lblRecessS02.Name = "lblRecessS02"
        lblRecessS02.Size = New Size(79, 42)
        lblRecessS02.TabIndex = 46
        lblRecessS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S02
        ' 
        lblPeriod3S02.Anchor = AnchorStyles.None
        lblPeriod3S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S02.Location = New Point(222, 232)
        lblPeriod3S02.Name = "lblPeriod3S02"
        lblPeriod3S02.Size = New Size(79, 42)
        lblPeriod3S02.TabIndex = 47
        lblPeriod3S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S02
        ' 
        lblPeriod4S02.Anchor = AnchorStyles.None
        lblPeriod4S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S02.Location = New Point(222, 278)
        lblPeriod4S02.Name = "lblPeriod4S02"
        lblPeriod4S02.Size = New Size(79, 42)
        lblPeriod4S02.TabIndex = 48
        lblPeriod4S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.None
        Label28.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label28.Location = New Point(222, 324)
        Label28.Name = "Label28"
        Label28.Size = New Size(79, 42)
        Label28.TabIndex = 49
        Label28.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label29
        ' 
        Label29.Anchor = AnchorStyles.None
        Label29.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label29.Location = New Point(136, 324)
        Label29.Name = "Label29"
        Label29.Size = New Size(79, 42)
        Label29.TabIndex = 50
        Label29.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S01
        ' 
        lblPeriod4S01.Anchor = AnchorStyles.None
        lblPeriod4S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S01.Location = New Point(136, 278)
        lblPeriod4S01.Name = "lblPeriod4S01"
        lblPeriod4S01.Size = New Size(79, 42)
        lblPeriod4S01.TabIndex = 51
        lblPeriod4S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S01
        ' 
        lblPeriod3S01.Anchor = AnchorStyles.None
        lblPeriod3S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S01.Location = New Point(136, 232)
        lblPeriod3S01.Name = "lblPeriod3S01"
        lblPeriod3S01.Size = New Size(79, 42)
        lblPeriod3S01.TabIndex = 52
        lblPeriod3S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS01
        ' 
        lblRecessS01.Anchor = AnchorStyles.None
        lblRecessS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS01.Location = New Point(136, 186)
        lblRecessS01.Name = "lblRecessS01"
        lblRecessS01.Size = New Size(79, 42)
        lblRecessS01.TabIndex = 53
        lblRecessS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S01
        ' 
        lblPeriod2S01.Anchor = AnchorStyles.None
        lblPeriod2S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S01.Location = New Point(136, 140)
        lblPeriod2S01.Name = "lblPeriod2S01"
        lblPeriod2S01.Size = New Size(79, 42)
        lblPeriod2S01.TabIndex = 54
        lblPeriod2S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S01
        ' 
        lblPeriod1S01.Anchor = AnchorStyles.None
        lblPeriod1S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S01.Location = New Point(136, 94)
        lblPeriod1S01.Name = "lblPeriod1S01"
        lblPeriod1S01.Size = New Size(79, 42)
        lblPeriod1S01.TabIndex = 55
        lblPeriod1S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label73
        ' 
        Label73.Anchor = AnchorStyles.None
        Label73.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label73.Location = New Point(222, 370)
        Label73.Name = "Label73"
        Label73.Size = New Size(79, 42)
        Label73.TabIndex = 103
        Label73.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorial
        ' 
        lblTutorial.Anchor = AnchorStyles.None
        lblTutorial.Font = New Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorial.Location = New Point(4, 48)
        lblTutorial.Name = "lblTutorial"
        lblTutorial.Size = New Size(125, 42)
        lblTutorial.TabIndex = 17
        lblTutorial.Text = "Tutorial"
        lblTutorial.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS10
        ' 
        lblS10.Anchor = AnchorStyles.None
        lblS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS10.Location = New Point(912, 2)
        lblS10.Name = "lblS10"
        lblS10.Size = New Size(78, 42)
        lblS10.TabIndex = 17
        lblS10.Text = "S10"
        lblS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS09
        ' 
        lblS09.Anchor = AnchorStyles.None
        lblS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS09.Location = New Point(834, 2)
        lblS09.Name = "lblS09"
        lblS09.Size = New Size(59, 42)
        lblS09.TabIndex = 17
        lblS09.Text = "S09"
        lblS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS08
        ' 
        lblS08.Anchor = AnchorStyles.None
        lblS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS08.Location = New Point(748, 2)
        lblS08.Name = "lblS08"
        lblS08.Size = New Size(59, 42)
        lblS08.TabIndex = 18
        lblS08.Text = "S08"
        lblS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS07
        ' 
        lblS07.Anchor = AnchorStyles.None
        lblS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS07.Location = New Point(662, 2)
        lblS07.Name = "lblS07"
        lblS07.Size = New Size(59, 42)
        lblS07.TabIndex = 19
        lblS07.Text = "S07"
        lblS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS06
        ' 
        lblS06.Anchor = AnchorStyles.None
        lblS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS06.Location = New Point(576, 2)
        lblS06.Name = "lblS06"
        lblS06.RightToLeft = RightToLeft.No
        lblS06.Size = New Size(59, 42)
        lblS06.TabIndex = 20
        lblS06.Text = "S06"
        lblS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS05
        ' 
        lblS05.Anchor = AnchorStyles.None
        lblS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS05.Location = New Point(490, 2)
        lblS05.Name = "lblS05"
        lblS05.Size = New Size(59, 42)
        lblS05.TabIndex = 21
        lblS05.Text = "S05"
        lblS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS04
        ' 
        lblS04.Anchor = AnchorStyles.None
        lblS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS04.Location = New Point(404, 2)
        lblS04.Name = "lblS04"
        lblS04.Size = New Size(59, 42)
        lblS04.TabIndex = 22
        lblS04.Text = "S04"
        lblS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS03
        ' 
        lblS03.Anchor = AnchorStyles.None
        lblS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS03.Location = New Point(318, 2)
        lblS03.Name = "lblS03"
        lblS03.Size = New Size(59, 42)
        lblS03.TabIndex = 23
        lblS03.Text = "S03"
        lblS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS02
        ' 
        lblS02.Anchor = AnchorStyles.None
        lblS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS02.Location = New Point(232, 2)
        lblS02.Name = "lblS02"
        lblS02.Size = New Size(59, 42)
        lblS02.TabIndex = 17
        lblS02.Text = "S02"
        lblS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS01
        ' 
        lblS01.Anchor = AnchorStyles.None
        lblS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS01.Location = New Point(146, 2)
        lblS01.Name = "lblS01"
        lblS01.Size = New Size(59, 42)
        lblS01.TabIndex = 0
        lblS01.Text = "S01"
        lblS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5
        ' 
        lblPeriod5.Anchor = AnchorStyles.None
        lblPeriod5.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5.Location = New Point(4, 370)
        lblPeriod5.Name = "lblPeriod5"
        lblPeriod5.Size = New Size(125, 42)
        lblPeriod5.TabIndex = 24
        lblPeriod5.Text = "Period 5"
        lblPeriod5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1
        ' 
        lblPeriod1.Anchor = AnchorStyles.None
        lblPeriod1.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1.Location = New Point(4, 94)
        lblPeriod1.Name = "lblPeriod1"
        lblPeriod1.Size = New Size(125, 42)
        lblPeriod1.TabIndex = 27
        lblPeriod1.Text = "Period 1"
        lblPeriod1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2
        ' 
        lblPeriod2.Anchor = AnchorStyles.None
        lblPeriod2.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2.Location = New Point(4, 140)
        lblPeriod2.Name = "lblPeriod2"
        lblPeriod2.Size = New Size(125, 42)
        lblPeriod2.TabIndex = 26
        lblPeriod2.Text = "Period 2"
        lblPeriod2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecess
        ' 
        lblRecess.Anchor = AnchorStyles.None
        lblRecess.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecess.Location = New Point(16, 186)
        lblRecess.Name = "lblRecess"
        lblRecess.Size = New Size(101, 42)
        lblRecess.TabIndex = 25
        lblRecess.Text = "Recess"
        lblRecess.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3
        ' 
        lblPeriod3.Anchor = AnchorStyles.None
        lblPeriod3.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3.Location = New Point(4, 232)
        lblPeriod3.Name = "lblPeriod3"
        lblPeriod3.Size = New Size(125, 42)
        lblPeriod3.TabIndex = 28
        lblPeriod3.Text = "Period 3"
        lblPeriod3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4
        ' 
        lblPeriod4.Anchor = AnchorStyles.None
        lblPeriod4.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4.Location = New Point(8, 278)
        lblPeriod4.Name = "lblPeriod4"
        lblPeriod4.Size = New Size(117, 42)
        lblPeriod4.TabIndex = 29
        lblPeriod4.Text = "Period 4"
        lblPeriod4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunch
        ' 
        lblLunch.Anchor = AnchorStyles.None
        lblLunch.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunch.Location = New Point(10, 324)
        lblLunch.Name = "lblLunch"
        lblLunch.Size = New Size(113, 42)
        lblLunch.TabIndex = 30
        lblLunch.Text = "Lunch"
        lblLunch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS01
        ' 
        lblTutorialS01.Anchor = AnchorStyles.None
        lblTutorialS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS01.Location = New Point(136, 48)
        lblTutorialS01.Name = "lblTutorialS01"
        lblTutorialS01.Size = New Size(79, 42)
        lblTutorialS01.TabIndex = 32
        lblTutorialS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(136, 419)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 42)
        Label1.TabIndex = 122
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(136, 370)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 42)
        Label3.TabIndex = 124
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(222, 419)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 42)
        Label6.TabIndex = 127
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(480, 419)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 42)
        Label9.TabIndex = 130
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(566, 419)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 42)
        Label8.TabIndex = 129
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(394, 419)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 42)
        Label7.TabIndex = 128
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(308, 419)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 42)
        Label4.TabIndex = 125
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6
        ' 
        lblPeriod6.Anchor = AnchorStyles.None
        lblPeriod6.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6.Location = New Point(4, 419)
        lblPeriod6.Name = "lblPeriod6"
        lblPeriod6.Size = New Size(125, 42)
        lblPeriod6.TabIndex = 25
        lblPeriod6.Text = "Period 6"
        lblPeriod6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MasterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1109, 807)
        Controls.Add(tlpTimeTable)
        Controls.Add(btnAllocateByClassroom)
        Controls.Add(cboClassroomChoose)
        Controls.Add(lblClassroomHeading)
        Controls.Add(btnAllocateByTime)
        Controls.Add(cboTimeChoose)
        Controls.Add(lblTimeHeading)
        Controls.Add(txtPurposeInput)
        Controls.Add(lblPurposeHeading)
        Controls.Add(txtApplicantNameInput)
        Controls.Add(lblApplicantNameHeading)
        Controls.Add(btnLoadTimetable)
        Controls.Add(MonthCalendar)
        Controls.Add(lblDateHeading)
        Controls.Add(picYarraLogo)
        Controls.Add(lblName)
        Margin = New Padding(3, 2, 3, 2)
        Name = "MasterForm"
        Text = "Classroom Allocator"
        CType(picYarraLogo, ComponentModel.ISupportInitialize).EndInit()
        tlpTimeTable.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents picYarraLogo As PictureBox
    Friend WithEvents lblDateHeading As Label
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents btnLoadTimetable As Button
    Friend WithEvents lblApplicantNameHeading As Label
    Friend WithEvents txtApplicantNameInput As TextBox
    Friend WithEvents lblPurposeHeading As Label
    Friend WithEvents txtPurposeInput As TextBox
    Friend WithEvents lblTimeHeading As Label
    Friend WithEvents cboTimeChoose As ComboBox
    Friend WithEvents btnAllocateByTime As Button
    Friend WithEvents lblClassroomHeading As Label
    Friend WithEvents cboClassroomChoose As ComboBox
    Friend WithEvents btnAllocateByClassroom As Button
    Friend WithEvents tlpTimeTable As TableLayoutPanel
    Friend WithEvents lblS01 As Label
    Friend WithEvents lblS07 As Label
    Friend WithEvents lblS06 As Label
    Friend WithEvents lblS05 As Label
    Friend WithEvents lblS04 As Label
    Friend WithEvents lblS03 As Label
    Friend WithEvents lblS02 As Label
    Friend WithEvents lblS09 As Label
    Friend WithEvents lblS08 As Label
    Friend WithEvents lblS10 As Label
    Friend WithEvents lblTutorial As Label
    Friend WithEvents lblPeriod5 As Label
    Friend WithEvents lblPeriod1 As Label
    Friend WithEvents lblPeriod2 As Label
    Friend WithEvents lblRecess As Label
    Friend WithEvents lblPeriod3 As Label
    Friend WithEvents lblPeriod4 As Label
    Friend WithEvents lblLunch As Label
    Friend WithEvents lblPeriod6 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents lblTutorialS01 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPeriod1S07 As Label
    Friend WithEvents lblPeriod2S07 As Label
    Friend WithEvents lblRecessS07 As Label
    Friend WithEvents lblPeriod3S07 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents lblPeriod4S06 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents lblPeriod3S06 As Label
    Friend WithEvents lblRecessS06 As Label
    Friend WithEvents lblPeriod2S06 As Label
    Friend WithEvents lblPeriod1S06 As Label
    Friend WithEvents lblTutorialS06 As Label
    Friend WithEvents lblPeriod1S05 As Label
    Friend WithEvents lblTutorialS05 As Label
    Friend WithEvents lblPeriod2S05 As Label
    Friend WithEvents lblRecessS05 As Label
    Friend WithEvents lblPeriod3S05 As Label
    Friend WithEvents lblPeriod4S05 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents lblPeriod4S04 As Label
    Friend WithEvents lblPeriod3S04 As Label
    Friend WithEvents lblRecessS04 As Label
    Friend WithEvents lblPeriod2S04 As Label
    Friend WithEvents lblPeriod1S04 As Label
    Friend WithEvents lblTutorialS04 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPeriod4S03 As Label
    Friend WithEvents lblPeriod3S03 As Label
    Friend WithEvents lblRecessS03 As Label
    Friend WithEvents lblPeriod2S03 As Label
    Friend WithEvents lblPeriod1S03 As Label
    Friend WithEvents lblTutorialS03 As Label
    Friend WithEvents lblTutorialS02 As Label
    Friend WithEvents lblPeriod1S02 As Label
    Friend WithEvents lblPeriod2S02 As Label
    Friend WithEvents lblRecessS02 As Label
    Friend WithEvents lblPeriod3S02 As Label
    Friend WithEvents lblPeriod4S02 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblPeriod4S01 As Label
    Friend WithEvents lblPeriod3S01 As Label
    Friend WithEvents lblRecessS01 As Label
    Friend WithEvents lblPeriod2S01 As Label
    Friend WithEvents lblPeriod1S01 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents lblPeriod4S09 As Label
    Friend WithEvents lblPeriod3S09 As Label
    Friend WithEvents lblRecessS09 As Label
    Friend WithEvents lblPeriod2S09 As Label
    Friend WithEvents lblPeriod1S09 As Label
    Friend WithEvents lblTutorialS09 As Label
    Friend WithEvents lblTutorialS08 As Label
    Friend WithEvents lblPeriod1S08 As Label
    Friend WithEvents lblPeriod2S08 As Label
    Friend WithEvents lblRecessS08 As Label
    Friend WithEvents lblPeriod3S08 As Label
    Friend WithEvents lblPeriod4S08 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents lblTutorialS07 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents lblPeriod4S10 As Label
    Friend WithEvents lblPeriod3S10 As Label
    Friend WithEvents lblRecessS10 As Label
    Friend WithEvents lblPeriod2S10 As Label
    Friend WithEvents lblPeriod1S10 As Label
    Friend WithEvents lblTutorialS10 As Label
    Friend WithEvents lblPeriod4S07 As Label
End Class
