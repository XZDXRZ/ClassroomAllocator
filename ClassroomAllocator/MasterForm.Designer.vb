<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        lblPeriod6S10 = New Label()
        lblPeriod5S10 = New Label()
        lblLunchS10 = New Label()
        lblPeriod4S10 = New Label()
        lblPeriod3S10 = New Label()
        lblRecessS10 = New Label()
        lblPeriod2S10 = New Label()
        lblPeriod1S10 = New Label()
        lblTutorialS10 = New Label()
        lblPeriod6S09 = New Label()
        lblPeriod5S09 = New Label()
        lblLunchS09 = New Label()
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
        lblLunchS08 = New Label()
        lblPeriod5S08 = New Label()
        lblPeriod6S08 = New Label()
        lblTutorialS07 = New Label()
        lblPeriod1S07 = New Label()
        lblPeriod2S07 = New Label()
        lblRecessS07 = New Label()
        lblPeriod3S07 = New Label()
        lblLunchS07 = New Label()
        lblPeriod5S07 = New Label()
        lblPeriod6S07 = New Label()
        lblPeriod4S06 = New Label()
        lblLunchS06 = New Label()
        lblPeriod5S06 = New Label()
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
        lblLunchS05 = New Label()
        lblPeriod5S05 = New Label()
        lblPeriod5S04 = New Label()
        lblLunchS04 = New Label()
        lblPeriod4S04 = New Label()
        lblPeriod3S04 = New Label()
        lblRecessS04 = New Label()
        lblPeriod2S04 = New Label()
        lblPeriod1S04 = New Label()
        lblTutorialS04 = New Label()
        lblPeriod5S03 = New Label()
        lblLunchS03 = New Label()
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
        lblLunchS02 = New Label()
        lblLunchS01 = New Label()
        lblPeriod4S01 = New Label()
        lblPeriod3S01 = New Label()
        lblRecessS01 = New Label()
        lblPeriod2S01 = New Label()
        lblPeriod1S01 = New Label()
        lblPeriod5S02 = New Label()
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
        lblPeriod6S01 = New Label()
        lblPeriod5S01 = New Label()
        lblPeriod6S02 = New Label()
        lblPeriod6S05 = New Label()
        lblPeriod6S06 = New Label()
        lblPeriod6S04 = New Label()
        lblPeriod6S03 = New Label()
        lblPeriod6 = New Label()
        btnHelp = New Button()
        btnSubmitRequest = New Button()
        CType(picYarraLogo, ComponentModel.ISupportInitialize).BeginInit()
        tlpTimeTable.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Font = New Font("Algerian", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(638, 29)
        lblName.Name = "lblName"
        lblName.Size = New Size(460, 106)
        lblName.TabIndex = 0
        lblName.Text = "Yarra Valley Grammar Classroom Allocator"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picYarraLogo
        ' 
        picYarraLogo.Image = My.Resources.Resources.yarra_logo
        picYarraLogo.Location = New Point(1123, 16)
        picYarraLogo.Margin = New Padding(3, 4, 3, 4)
        picYarraLogo.Name = "picYarraLogo"
        picYarraLogo.Size = New Size(130, 141)
        picYarraLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picYarraLogo.TabIndex = 1
        picYarraLogo.TabStop = False
        ' 
        ' lblDateHeading
        ' 
        lblDateHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateHeading.Location = New Point(26, 29)
        lblDateHeading.Name = "lblDateHeading"
        lblDateHeading.Size = New Size(165, 31)
        lblDateHeading.TabIndex = 2
        lblDateHeading.Text = "Choose a Date: "' 
        ' MonthCalendar
        ' 
        MonthCalendar.Location = New Point(26, 72)
        MonthCalendar.Margin = New Padding(10, 12, 10, 12)
        MonthCalendar.Name = "MonthCalendar"
        MonthCalendar.TabIndex = 3
        ' 
        ' btnLoadTimetable
        ' 
        btnLoadTimetable.BackColor = Color.LightGray
        btnLoadTimetable.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLoadTimetable.Location = New Point(26, 304)
        btnLoadTimetable.Margin = New Padding(3, 4, 3, 4)
        btnLoadTimetable.Name = "btnLoadTimetable"
        btnLoadTimetable.Size = New Size(259, 41)
        btnLoadTimetable.TabIndex = 4
        btnLoadTimetable.Text = "Load Timetable"
        btnLoadTimetable.UseVisualStyleBackColor = False
        ' 
        ' lblApplicantNameHeading
        ' 
        lblApplicantNameHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblApplicantNameHeading.Location = New Point(323, 85)
        lblApplicantNameHeading.Name = "lblApplicantNameHeading"
        lblApplicantNameHeading.Size = New Size(169, 31)
        lblApplicantNameHeading.TabIndex = 5
        lblApplicantNameHeading.Text = "Applicant Name:"' 
        ' txtApplicantNameInput
        ' 
        txtApplicantNameInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtApplicantNameInput.Location = New Point(323, 136)
        txtApplicantNameInput.Margin = New Padding(3, 4, 3, 4)
        txtApplicantNameInput.Name = "txtApplicantNameInput"
        txtApplicantNameInput.Size = New Size(233, 32)
        txtApplicantNameInput.TabIndex = 6
        ' 
        ' lblPurposeHeading
        ' 
        lblPurposeHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPurposeHeading.Location = New Point(323, 220)
        lblPurposeHeading.Name = "lblPurposeHeading"
        lblPurposeHeading.Size = New Size(169, 31)
        lblPurposeHeading.TabIndex = 7
        lblPurposeHeading.Text = "Purpose:"' 
        ' txtPurposeInput
        ' 
        txtPurposeInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPurposeInput.Location = New Point(323, 268)
        txtPurposeInput.Margin = New Padding(3, 4, 3, 4)
        txtPurposeInput.Name = "txtPurposeInput"
        txtPurposeInput.Size = New Size(233, 32)
        txtPurposeInput.TabIndex = 8
        ' 
        ' lblTimeHeading
        ' 
        lblTimeHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTimeHeading.Location = New Point(638, 188)
        lblTimeHeading.Name = "lblTimeHeading"
        lblTimeHeading.Size = New Size(74, 31)
        lblTimeHeading.TabIndex = 9
        lblTimeHeading.Text = "Time:"' 
        ' cboTimeChoose
        ' 
        cboTimeChoose.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cboTimeChoose.FormattingEnabled = True
        cboTimeChoose.Location = New Point(763, 181)
        cboTimeChoose.Margin = New Padding(3, 4, 3, 4)
        cboTimeChoose.Name = "cboTimeChoose"
        cboTimeChoose.Size = New Size(165, 33)
        cboTimeChoose.TabIndex = 11
        ' 
        ' btnAllocateByTime
        ' 
        btnAllocateByTime.BackColor = Color.LightGray
        btnAllocateByTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAllocateByTime.Location = New Point(950, 180)
        btnAllocateByTime.Margin = New Padding(3, 4, 3, 4)
        btnAllocateByTime.Name = "btnAllocateByTime"
        btnAllocateByTime.Size = New Size(174, 41)
        btnAllocateByTime.TabIndex = 12
        btnAllocateByTime.Text = "Allocate By Time"
        btnAllocateByTime.UseVisualStyleBackColor = False
        ' 
        ' lblClassroomHeading
        ' 
        lblClassroomHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblClassroomHeading.Location = New Point(638, 265)
        lblClassroomHeading.Name = "lblClassroomHeading"
        lblClassroomHeading.Size = New Size(135, 31)
        lblClassroomHeading.TabIndex = 13
        lblClassroomHeading.Text = "Classroom:"' 
        ' cboClassroomChoose
        ' 
        cboClassroomChoose.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cboClassroomChoose.FormattingEnabled = True
        cboClassroomChoose.Location = New Point(763, 267)
        cboClassroomChoose.Margin = New Padding(3, 4, 3, 4)
        cboClassroomChoose.Name = "cboClassroomChoose"
        cboClassroomChoose.Size = New Size(165, 33)
        cboClassroomChoose.TabIndex = 14
        ' 
        ' btnAllocateByClassroom
        ' 
        btnAllocateByClassroom.BackColor = Color.LightGray
        btnAllocateByClassroom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAllocateByClassroom.Location = New Point(950, 263)
        btnAllocateByClassroom.Margin = New Padding(3, 4, 3, 4)
        btnAllocateByClassroom.Name = "btnAllocateByClassroom"
        btnAllocateByClassroom.Size = New Size(174, 41)
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
        tlpTimeTable.Controls.Add(lblPeriod6S10, 10, 9)
        tlpTimeTable.Controls.Add(lblPeriod5S10, 10, 8)
        tlpTimeTable.Controls.Add(lblLunchS10, 10, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S10, 10, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S10, 10, 5)
        tlpTimeTable.Controls.Add(lblRecessS10, 10, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S10, 10, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S10, 10, 2)
        tlpTimeTable.Controls.Add(lblTutorialS10, 10, 1)
        tlpTimeTable.Controls.Add(lblPeriod6S09, 9, 9)
        tlpTimeTable.Controls.Add(lblPeriod5S09, 9, 8)
        tlpTimeTable.Controls.Add(lblLunchS09, 9, 7)
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
        tlpTimeTable.Controls.Add(lblLunchS08, 8, 7)
        tlpTimeTable.Controls.Add(lblPeriod5S08, 8, 8)
        tlpTimeTable.Controls.Add(lblPeriod6S08, 8, 9)
        tlpTimeTable.Controls.Add(lblTutorialS07, 7, 1)
        tlpTimeTable.Controls.Add(lblPeriod1S07, 7, 2)
        tlpTimeTable.Controls.Add(lblPeriod2S07, 7, 3)
        tlpTimeTable.Controls.Add(lblRecessS07, 7, 4)
        tlpTimeTable.Controls.Add(lblPeriod3S07, 7, 5)
        tlpTimeTable.Controls.Add(lblLunchS07, 7, 7)
        tlpTimeTable.Controls.Add(lblPeriod5S07, 7, 8)
        tlpTimeTable.Controls.Add(lblPeriod6S07, 7, 9)
        tlpTimeTable.Controls.Add(lblPeriod4S06, 6, 6)
        tlpTimeTable.Controls.Add(lblLunchS06, 6, 7)
        tlpTimeTable.Controls.Add(lblPeriod5S06, 6, 8)
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
        tlpTimeTable.Controls.Add(lblLunchS05, 5, 7)
        tlpTimeTable.Controls.Add(lblPeriod5S05, 5, 8)
        tlpTimeTable.Controls.Add(lblPeriod5S04, 4, 8)
        tlpTimeTable.Controls.Add(lblLunchS04, 4, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S04, 4, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S04, 4, 5)
        tlpTimeTable.Controls.Add(lblRecessS04, 4, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S04, 4, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S04, 4, 2)
        tlpTimeTable.Controls.Add(lblTutorialS04, 4, 1)
        tlpTimeTable.Controls.Add(lblPeriod5S03, 3, 8)
        tlpTimeTable.Controls.Add(lblLunchS03, 3, 7)
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
        tlpTimeTable.Controls.Add(lblLunchS02, 2, 7)
        tlpTimeTable.Controls.Add(lblLunchS01, 1, 7)
        tlpTimeTable.Controls.Add(lblPeriod4S01, 1, 6)
        tlpTimeTable.Controls.Add(lblPeriod3S01, 1, 5)
        tlpTimeTable.Controls.Add(lblRecessS01, 1, 4)
        tlpTimeTable.Controls.Add(lblPeriod2S01, 1, 3)
        tlpTimeTable.Controls.Add(lblPeriod1S01, 1, 2)
        tlpTimeTable.Controls.Add(lblPeriod5S02, 2, 8)
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
        tlpTimeTable.Controls.Add(lblPeriod6S01, 1, 9)
        tlpTimeTable.Controls.Add(lblPeriod5S01, 1, 8)
        tlpTimeTable.Controls.Add(lblPeriod6S02, 1, 9)
        tlpTimeTable.Controls.Add(lblPeriod6S05, 2, 9)
        tlpTimeTable.Controls.Add(lblPeriod6S06, 2, 9)
        tlpTimeTable.Controls.Add(lblPeriod6S04, 1, 9)
        tlpTimeTable.Controls.Add(lblPeriod6S03, 1, 9)
        tlpTimeTable.Controls.Add(lblPeriod6, 0, 9)
        tlpTimeTable.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        tlpTimeTable.Location = New Point(106, 365)
        tlpTimeTable.Margin = New Padding(3, 4, 3, 4)
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
        tlpTimeTable.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        tlpTimeTable.Size = New Size(1038, 452)
        tlpTimeTable.TabIndex = 16
        ' 
        ' lblPeriod4S07
        ' 
        lblPeriod4S07.Anchor = AnchorStyles.None
        lblPeriod4S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S07.Location = New Point(675, 273)
        lblPeriod4S07.Name = "lblPeriod4S07"
        lblPeriod4S07.Size = New Size(82, 40)
        lblPeriod4S07.TabIndex = 43
        lblPeriod4S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S10
        ' 
        lblPeriod6S10.Anchor = AnchorStyles.None
        lblPeriod6S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S10.Location = New Point(943, 406)
        lblPeriod6S10.Name = "lblPeriod6S10"
        lblPeriod6S10.Size = New Size(90, 45)
        lblPeriod6S10.TabIndex = 33
        lblPeriod6S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S10
        ' 
        lblPeriod5S10.Anchor = AnchorStyles.None
        lblPeriod5S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S10.Location = New Point(943, 363)
        lblPeriod5S10.Name = "lblPeriod5S10"
        lblPeriod5S10.Size = New Size(90, 40)
        lblPeriod5S10.TabIndex = 33
        lblPeriod5S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS10
        ' 
        lblLunchS10.Anchor = AnchorStyles.None
        lblLunchS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS10.Location = New Point(943, 318)
        lblLunchS10.Name = "lblLunchS10"
        lblLunchS10.Size = New Size(90, 40)
        lblLunchS10.TabIndex = 34
        lblLunchS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S10
        ' 
        lblPeriod4S10.Anchor = AnchorStyles.None
        lblPeriod4S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S10.Location = New Point(943, 273)
        lblPeriod4S10.Name = "lblPeriod4S10"
        lblPeriod4S10.Size = New Size(90, 40)
        lblPeriod4S10.TabIndex = 35
        lblPeriod4S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S10
        ' 
        lblPeriod3S10.Anchor = AnchorStyles.None
        lblPeriod3S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S10.Location = New Point(943, 228)
        lblPeriod3S10.Name = "lblPeriod3S10"
        lblPeriod3S10.Size = New Size(90, 40)
        lblPeriod3S10.TabIndex = 36
        lblPeriod3S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS10
        ' 
        lblRecessS10.Anchor = AnchorStyles.None
        lblRecessS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS10.Location = New Point(943, 183)
        lblRecessS10.Name = "lblRecessS10"
        lblRecessS10.Size = New Size(90, 40)
        lblRecessS10.TabIndex = 37
        lblRecessS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S10
        ' 
        lblPeriod2S10.Anchor = AnchorStyles.None
        lblPeriod2S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S10.Location = New Point(943, 138)
        lblPeriod2S10.Name = "lblPeriod2S10"
        lblPeriod2S10.Size = New Size(90, 40)
        lblPeriod2S10.TabIndex = 38
        lblPeriod2S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S10
        ' 
        lblPeriod1S10.Anchor = AnchorStyles.None
        lblPeriod1S10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S10.Location = New Point(943, 93)
        lblPeriod1S10.Name = "lblPeriod1S10"
        lblPeriod1S10.Size = New Size(90, 40)
        lblPeriod1S10.TabIndex = 39
        lblPeriod1S10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS10
        ' 
        lblTutorialS10.Anchor = AnchorStyles.None
        lblTutorialS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS10.Location = New Point(943, 48)
        lblTutorialS10.Name = "lblTutorialS10"
        lblTutorialS10.Size = New Size(90, 40)
        lblTutorialS10.TabIndex = 40
        lblTutorialS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S09
        ' 
        lblPeriod6S09.Anchor = AnchorStyles.None
        lblPeriod6S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S09.Location = New Point(853, 406)
        lblPeriod6S09.Name = "lblPeriod6S09"
        lblPeriod6S09.Size = New Size(82, 45)
        lblPeriod6S09.TabIndex = 33
        lblPeriod6S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S09
        ' 
        lblPeriod5S09.Anchor = AnchorStyles.None
        lblPeriod5S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S09.Location = New Point(853, 363)
        lblPeriod5S09.Name = "lblPeriod5S09"
        lblPeriod5S09.Size = New Size(82, 40)
        lblPeriod5S09.TabIndex = 34
        lblPeriod5S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS09
        ' 
        lblLunchS09.Anchor = AnchorStyles.None
        lblLunchS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS09.Location = New Point(853, 318)
        lblLunchS09.Name = "lblLunchS09"
        lblLunchS09.Size = New Size(82, 40)
        lblLunchS09.TabIndex = 35
        lblLunchS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S09
        ' 
        lblPeriod4S09.Anchor = AnchorStyles.None
        lblPeriod4S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S09.Location = New Point(853, 273)
        lblPeriod4S09.Name = "lblPeriod4S09"
        lblPeriod4S09.Size = New Size(82, 40)
        lblPeriod4S09.TabIndex = 36
        lblPeriod4S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S09
        ' 
        lblPeriod3S09.Anchor = AnchorStyles.None
        lblPeriod3S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S09.Location = New Point(853, 228)
        lblPeriod3S09.Name = "lblPeriod3S09"
        lblPeriod3S09.Size = New Size(82, 40)
        lblPeriod3S09.TabIndex = 37
        lblPeriod3S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS09
        ' 
        lblRecessS09.Anchor = AnchorStyles.None
        lblRecessS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS09.Location = New Point(853, 183)
        lblRecessS09.Name = "lblRecessS09"
        lblRecessS09.Size = New Size(82, 40)
        lblRecessS09.TabIndex = 38
        lblRecessS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S09
        ' 
        lblPeriod2S09.Anchor = AnchorStyles.None
        lblPeriod2S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S09.Location = New Point(853, 138)
        lblPeriod2S09.Name = "lblPeriod2S09"
        lblPeriod2S09.Size = New Size(82, 40)
        lblPeriod2S09.TabIndex = 39
        lblPeriod2S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S09
        ' 
        lblPeriod1S09.Anchor = AnchorStyles.None
        lblPeriod1S09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S09.Location = New Point(853, 93)
        lblPeriod1S09.Name = "lblPeriod1S09"
        lblPeriod1S09.Size = New Size(82, 40)
        lblPeriod1S09.TabIndex = 40
        lblPeriod1S09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS09
        ' 
        lblTutorialS09.Anchor = AnchorStyles.None
        lblTutorialS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS09.Location = New Point(853, 48)
        lblTutorialS09.Name = "lblTutorialS09"
        lblTutorialS09.Size = New Size(82, 40)
        lblTutorialS09.TabIndex = 41
        lblTutorialS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS08
        ' 
        lblTutorialS08.Anchor = AnchorStyles.None
        lblTutorialS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS08.Location = New Point(764, 48)
        lblTutorialS08.Name = "lblTutorialS08"
        lblTutorialS08.Size = New Size(82, 40)
        lblTutorialS08.TabIndex = 42
        lblTutorialS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S08
        ' 
        lblPeriod1S08.Anchor = AnchorStyles.None
        lblPeriod1S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S08.Location = New Point(764, 93)
        lblPeriod1S08.Name = "lblPeriod1S08"
        lblPeriod1S08.Size = New Size(82, 40)
        lblPeriod1S08.TabIndex = 43
        lblPeriod1S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S08
        ' 
        lblPeriod2S08.Anchor = AnchorStyles.None
        lblPeriod2S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S08.Location = New Point(764, 138)
        lblPeriod2S08.Name = "lblPeriod2S08"
        lblPeriod2S08.Size = New Size(82, 40)
        lblPeriod2S08.TabIndex = 44
        lblPeriod2S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS08
        ' 
        lblRecessS08.Anchor = AnchorStyles.None
        lblRecessS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS08.Location = New Point(764, 183)
        lblRecessS08.Name = "lblRecessS08"
        lblRecessS08.Size = New Size(82, 40)
        lblRecessS08.TabIndex = 45
        lblRecessS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S08
        ' 
        lblPeriod3S08.Anchor = AnchorStyles.None
        lblPeriod3S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S08.Location = New Point(764, 228)
        lblPeriod3S08.Name = "lblPeriod3S08"
        lblPeriod3S08.Size = New Size(82, 40)
        lblPeriod3S08.TabIndex = 46
        lblPeriod3S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S08
        ' 
        lblPeriod4S08.Anchor = AnchorStyles.None
        lblPeriod4S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S08.Location = New Point(764, 273)
        lblPeriod4S08.Name = "lblPeriod4S08"
        lblPeriod4S08.Size = New Size(82, 40)
        lblPeriod4S08.TabIndex = 47
        lblPeriod4S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS08
        ' 
        lblLunchS08.Anchor = AnchorStyles.None
        lblLunchS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS08.Location = New Point(764, 318)
        lblLunchS08.Name = "lblLunchS08"
        lblLunchS08.Size = New Size(82, 40)
        lblLunchS08.TabIndex = 48
        lblLunchS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S08
        ' 
        lblPeriod5S08.Anchor = AnchorStyles.None
        lblPeriod5S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S08.Location = New Point(764, 363)
        lblPeriod5S08.Name = "lblPeriod5S08"
        lblPeriod5S08.Size = New Size(82, 40)
        lblPeriod5S08.TabIndex = 49
        lblPeriod5S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S08
        ' 
        lblPeriod6S08.Anchor = AnchorStyles.None
        lblPeriod6S08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S08.Location = New Point(764, 406)
        lblPeriod6S08.Name = "lblPeriod6S08"
        lblPeriod6S08.Size = New Size(82, 45)
        lblPeriod6S08.TabIndex = 50
        lblPeriod6S08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS07
        ' 
        lblTutorialS07.Anchor = AnchorStyles.None
        lblTutorialS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS07.Location = New Point(675, 48)
        lblTutorialS07.Name = "lblTutorialS07"
        lblTutorialS07.Size = New Size(82, 40)
        lblTutorialS07.TabIndex = 51
        lblTutorialS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S07
        ' 
        lblPeriod1S07.Anchor = AnchorStyles.None
        lblPeriod1S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S07.Location = New Point(675, 93)
        lblPeriod1S07.Name = "lblPeriod1S07"
        lblPeriod1S07.Size = New Size(82, 40)
        lblPeriod1S07.TabIndex = 33
        lblPeriod1S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S07
        ' 
        lblPeriod2S07.Anchor = AnchorStyles.None
        lblPeriod2S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S07.Location = New Point(675, 138)
        lblPeriod2S07.Name = "lblPeriod2S07"
        lblPeriod2S07.Size = New Size(82, 40)
        lblPeriod2S07.TabIndex = 34
        lblPeriod2S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS07
        ' 
        lblRecessS07.Anchor = AnchorStyles.None
        lblRecessS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS07.Location = New Point(675, 183)
        lblRecessS07.Name = "lblRecessS07"
        lblRecessS07.Size = New Size(82, 40)
        lblRecessS07.TabIndex = 35
        lblRecessS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S07
        ' 
        lblPeriod3S07.Anchor = AnchorStyles.None
        lblPeriod3S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S07.Location = New Point(675, 228)
        lblPeriod3S07.Name = "lblPeriod3S07"
        lblPeriod3S07.Size = New Size(82, 40)
        lblPeriod3S07.TabIndex = 36
        lblPeriod3S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS07
        ' 
        lblLunchS07.Anchor = AnchorStyles.None
        lblLunchS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS07.Location = New Point(675, 318)
        lblLunchS07.Name = "lblLunchS07"
        lblLunchS07.Size = New Size(82, 40)
        lblLunchS07.TabIndex = 37
        lblLunchS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S07
        ' 
        lblPeriod5S07.Anchor = AnchorStyles.None
        lblPeriod5S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S07.Location = New Point(675, 363)
        lblPeriod5S07.Name = "lblPeriod5S07"
        lblPeriod5S07.Size = New Size(82, 40)
        lblPeriod5S07.TabIndex = 38
        lblPeriod5S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S07
        ' 
        lblPeriod6S07.Anchor = AnchorStyles.None
        lblPeriod6S07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S07.Location = New Point(675, 406)
        lblPeriod6S07.Name = "lblPeriod6S07"
        lblPeriod6S07.Size = New Size(82, 45)
        lblPeriod6S07.TabIndex = 39
        lblPeriod6S07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S06
        ' 
        lblPeriod4S06.Anchor = AnchorStyles.None
        lblPeriod4S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S06.Location = New Point(586, 273)
        lblPeriod4S06.Name = "lblPeriod4S06"
        lblPeriod4S06.Size = New Size(82, 40)
        lblPeriod4S06.TabIndex = 40
        lblPeriod4S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS06
        ' 
        lblLunchS06.Anchor = AnchorStyles.None
        lblLunchS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS06.Location = New Point(586, 318)
        lblLunchS06.Name = "lblLunchS06"
        lblLunchS06.Size = New Size(82, 40)
        lblLunchS06.TabIndex = 41
        lblLunchS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S06
        ' 
        lblPeriod5S06.Anchor = AnchorStyles.None
        lblPeriod5S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S06.Location = New Point(586, 363)
        lblPeriod5S06.Name = "lblPeriod5S06"
        lblPeriod5S06.Size = New Size(82, 40)
        lblPeriod5S06.TabIndex = 42
        lblPeriod5S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S06
        ' 
        lblPeriod3S06.Anchor = AnchorStyles.None
        lblPeriod3S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S06.Location = New Point(586, 228)
        lblPeriod3S06.Name = "lblPeriod3S06"
        lblPeriod3S06.Size = New Size(82, 40)
        lblPeriod3S06.TabIndex = 33
        lblPeriod3S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS06
        ' 
        lblRecessS06.Anchor = AnchorStyles.None
        lblRecessS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS06.Location = New Point(586, 183)
        lblRecessS06.Name = "lblRecessS06"
        lblRecessS06.Size = New Size(82, 40)
        lblRecessS06.TabIndex = 34
        lblRecessS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S06
        ' 
        lblPeriod2S06.Anchor = AnchorStyles.None
        lblPeriod2S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S06.Location = New Point(586, 138)
        lblPeriod2S06.Name = "lblPeriod2S06"
        lblPeriod2S06.Size = New Size(82, 40)
        lblPeriod2S06.TabIndex = 35
        lblPeriod2S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S06
        ' 
        lblPeriod1S06.Anchor = AnchorStyles.None
        lblPeriod1S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S06.Location = New Point(586, 93)
        lblPeriod1S06.Name = "lblPeriod1S06"
        lblPeriod1S06.Size = New Size(82, 40)
        lblPeriod1S06.TabIndex = 36
        lblPeriod1S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS06
        ' 
        lblTutorialS06.Anchor = AnchorStyles.None
        lblTutorialS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS06.Location = New Point(586, 48)
        lblTutorialS06.Name = "lblTutorialS06"
        lblTutorialS06.Size = New Size(82, 40)
        lblTutorialS06.TabIndex = 37
        lblTutorialS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S05
        ' 
        lblPeriod1S05.Anchor = AnchorStyles.None
        lblPeriod1S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S05.Location = New Point(497, 93)
        lblPeriod1S05.Name = "lblPeriod1S05"
        lblPeriod1S05.Size = New Size(82, 40)
        lblPeriod1S05.TabIndex = 38
        lblPeriod1S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS05
        ' 
        lblTutorialS05.Anchor = AnchorStyles.None
        lblTutorialS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS05.Location = New Point(497, 48)
        lblTutorialS05.Name = "lblTutorialS05"
        lblTutorialS05.Size = New Size(82, 40)
        lblTutorialS05.TabIndex = 39
        lblTutorialS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S05
        ' 
        lblPeriod2S05.Anchor = AnchorStyles.None
        lblPeriod2S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S05.Location = New Point(497, 138)
        lblPeriod2S05.Name = "lblPeriod2S05"
        lblPeriod2S05.Size = New Size(82, 40)
        lblPeriod2S05.TabIndex = 40
        lblPeriod2S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS05
        ' 
        lblRecessS05.Anchor = AnchorStyles.None
        lblRecessS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS05.Location = New Point(497, 183)
        lblRecessS05.Name = "lblRecessS05"
        lblRecessS05.Size = New Size(82, 40)
        lblRecessS05.TabIndex = 41
        lblRecessS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S05
        ' 
        lblPeriod3S05.Anchor = AnchorStyles.None
        lblPeriod3S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S05.Location = New Point(497, 228)
        lblPeriod3S05.Name = "lblPeriod3S05"
        lblPeriod3S05.Size = New Size(82, 40)
        lblPeriod3S05.TabIndex = 42
        lblPeriod3S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S05
        ' 
        lblPeriod4S05.Anchor = AnchorStyles.None
        lblPeriod4S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S05.Location = New Point(497, 273)
        lblPeriod4S05.Name = "lblPeriod4S05"
        lblPeriod4S05.Size = New Size(82, 40)
        lblPeriod4S05.TabIndex = 43
        lblPeriod4S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS05
        ' 
        lblLunchS05.Anchor = AnchorStyles.None
        lblLunchS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS05.Location = New Point(497, 318)
        lblLunchS05.Name = "lblLunchS05"
        lblLunchS05.Size = New Size(82, 40)
        lblLunchS05.TabIndex = 44
        lblLunchS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S05
        ' 
        lblPeriod5S05.Anchor = AnchorStyles.None
        lblPeriod5S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S05.Location = New Point(497, 363)
        lblPeriod5S05.Name = "lblPeriod5S05"
        lblPeriod5S05.Size = New Size(82, 40)
        lblPeriod5S05.TabIndex = 45
        lblPeriod5S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S04
        ' 
        lblPeriod5S04.Anchor = AnchorStyles.None
        lblPeriod5S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S04.Location = New Point(408, 363)
        lblPeriod5S04.Name = "lblPeriod5S04"
        lblPeriod5S04.Size = New Size(82, 40)
        lblPeriod5S04.TabIndex = 46
        lblPeriod5S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS04
        ' 
        lblLunchS04.Anchor = AnchorStyles.None
        lblLunchS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS04.Location = New Point(408, 318)
        lblLunchS04.Name = "lblLunchS04"
        lblLunchS04.Size = New Size(82, 40)
        lblLunchS04.TabIndex = 47
        lblLunchS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S04
        ' 
        lblPeriod4S04.Anchor = AnchorStyles.None
        lblPeriod4S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S04.Location = New Point(408, 273)
        lblPeriod4S04.Name = "lblPeriod4S04"
        lblPeriod4S04.Size = New Size(82, 40)
        lblPeriod4S04.TabIndex = 48
        lblPeriod4S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S04
        ' 
        lblPeriod3S04.Anchor = AnchorStyles.None
        lblPeriod3S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S04.Location = New Point(408, 228)
        lblPeriod3S04.Name = "lblPeriod3S04"
        lblPeriod3S04.Size = New Size(82, 40)
        lblPeriod3S04.TabIndex = 49
        lblPeriod3S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS04
        ' 
        lblRecessS04.Anchor = AnchorStyles.None
        lblRecessS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS04.Location = New Point(408, 183)
        lblRecessS04.Name = "lblRecessS04"
        lblRecessS04.Size = New Size(82, 40)
        lblRecessS04.TabIndex = 50
        lblRecessS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S04
        ' 
        lblPeriod2S04.Anchor = AnchorStyles.None
        lblPeriod2S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S04.Location = New Point(408, 138)
        lblPeriod2S04.Name = "lblPeriod2S04"
        lblPeriod2S04.Size = New Size(82, 40)
        lblPeriod2S04.TabIndex = 51
        lblPeriod2S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S04
        ' 
        lblPeriod1S04.Anchor = AnchorStyles.None
        lblPeriod1S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S04.Location = New Point(408, 93)
        lblPeriod1S04.Name = "lblPeriod1S04"
        lblPeriod1S04.Size = New Size(82, 40)
        lblPeriod1S04.TabIndex = 33
        lblPeriod1S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS04
        ' 
        lblTutorialS04.Anchor = AnchorStyles.None
        lblTutorialS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS04.Location = New Point(408, 48)
        lblTutorialS04.Name = "lblTutorialS04"
        lblTutorialS04.Size = New Size(82, 40)
        lblTutorialS04.TabIndex = 34
        lblTutorialS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S03
        ' 
        lblPeriod5S03.Anchor = AnchorStyles.None
        lblPeriod5S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S03.Location = New Point(319, 363)
        lblPeriod5S03.Name = "lblPeriod5S03"
        lblPeriod5S03.Size = New Size(82, 40)
        lblPeriod5S03.TabIndex = 35
        lblPeriod5S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS03
        ' 
        lblLunchS03.Anchor = AnchorStyles.None
        lblLunchS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS03.Location = New Point(319, 318)
        lblLunchS03.Name = "lblLunchS03"
        lblLunchS03.Size = New Size(82, 40)
        lblLunchS03.TabIndex = 36
        lblLunchS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S03
        ' 
        lblPeriod4S03.Anchor = AnchorStyles.None
        lblPeriod4S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S03.Location = New Point(319, 273)
        lblPeriod4S03.Name = "lblPeriod4S03"
        lblPeriod4S03.Size = New Size(82, 40)
        lblPeriod4S03.TabIndex = 37
        lblPeriod4S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S03
        ' 
        lblPeriod3S03.Anchor = AnchorStyles.None
        lblPeriod3S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S03.Location = New Point(319, 228)
        lblPeriod3S03.Name = "lblPeriod3S03"
        lblPeriod3S03.Size = New Size(82, 40)
        lblPeriod3S03.TabIndex = 38
        lblPeriod3S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS03
        ' 
        lblRecessS03.Anchor = AnchorStyles.None
        lblRecessS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS03.Location = New Point(319, 183)
        lblRecessS03.Name = "lblRecessS03"
        lblRecessS03.Size = New Size(82, 40)
        lblRecessS03.TabIndex = 39
        lblRecessS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S03
        ' 
        lblPeriod2S03.Anchor = AnchorStyles.None
        lblPeriod2S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S03.Location = New Point(319, 138)
        lblPeriod2S03.Name = "lblPeriod2S03"
        lblPeriod2S03.Size = New Size(82, 40)
        lblPeriod2S03.TabIndex = 40
        lblPeriod2S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S03
        ' 
        lblPeriod1S03.Anchor = AnchorStyles.None
        lblPeriod1S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S03.Location = New Point(319, 93)
        lblPeriod1S03.Name = "lblPeriod1S03"
        lblPeriod1S03.Size = New Size(82, 40)
        lblPeriod1S03.TabIndex = 41
        lblPeriod1S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS03
        ' 
        lblTutorialS03.Anchor = AnchorStyles.None
        lblTutorialS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS03.Location = New Point(319, 48)
        lblTutorialS03.Name = "lblTutorialS03"
        lblTutorialS03.Size = New Size(82, 40)
        lblTutorialS03.TabIndex = 42
        lblTutorialS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS02
        ' 
        lblTutorialS02.Anchor = AnchorStyles.None
        lblTutorialS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS02.Location = New Point(230, 48)
        lblTutorialS02.Name = "lblTutorialS02"
        lblTutorialS02.Size = New Size(82, 40)
        lblTutorialS02.TabIndex = 43
        lblTutorialS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S02
        ' 
        lblPeriod1S02.Anchor = AnchorStyles.None
        lblPeriod1S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S02.Location = New Point(230, 93)
        lblPeriod1S02.Name = "lblPeriod1S02"
        lblPeriod1S02.Size = New Size(82, 40)
        lblPeriod1S02.TabIndex = 44
        lblPeriod1S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S02
        ' 
        lblPeriod2S02.Anchor = AnchorStyles.None
        lblPeriod2S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S02.Location = New Point(230, 138)
        lblPeriod2S02.Name = "lblPeriod2S02"
        lblPeriod2S02.Size = New Size(82, 40)
        lblPeriod2S02.TabIndex = 45
        lblPeriod2S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS02
        ' 
        lblRecessS02.Anchor = AnchorStyles.None
        lblRecessS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS02.Location = New Point(230, 183)
        lblRecessS02.Name = "lblRecessS02"
        lblRecessS02.Size = New Size(82, 40)
        lblRecessS02.TabIndex = 46
        lblRecessS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S02
        ' 
        lblPeriod3S02.Anchor = AnchorStyles.None
        lblPeriod3S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S02.Location = New Point(230, 228)
        lblPeriod3S02.Name = "lblPeriod3S02"
        lblPeriod3S02.Size = New Size(82, 40)
        lblPeriod3S02.TabIndex = 47
        lblPeriod3S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S02
        ' 
        lblPeriod4S02.Anchor = AnchorStyles.None
        lblPeriod4S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S02.Location = New Point(230, 273)
        lblPeriod4S02.Name = "lblPeriod4S02"
        lblPeriod4S02.Size = New Size(82, 40)
        lblPeriod4S02.TabIndex = 48
        lblPeriod4S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS02
        ' 
        lblLunchS02.Anchor = AnchorStyles.None
        lblLunchS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS02.Location = New Point(230, 318)
        lblLunchS02.Name = "lblLunchS02"
        lblLunchS02.Size = New Size(82, 40)
        lblLunchS02.TabIndex = 49
        lblLunchS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunchS01
        ' 
        lblLunchS01.Anchor = AnchorStyles.None
        lblLunchS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunchS01.Location = New Point(141, 318)
        lblLunchS01.Name = "lblLunchS01"
        lblLunchS01.Size = New Size(82, 40)
        lblLunchS01.TabIndex = 50
        lblLunchS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4S01
        ' 
        lblPeriod4S01.Anchor = AnchorStyles.None
        lblPeriod4S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4S01.Location = New Point(141, 273)
        lblPeriod4S01.Name = "lblPeriod4S01"
        lblPeriod4S01.Size = New Size(82, 40)
        lblPeriod4S01.TabIndex = 51
        lblPeriod4S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3S01
        ' 
        lblPeriod3S01.Anchor = AnchorStyles.None
        lblPeriod3S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3S01.Location = New Point(141, 228)
        lblPeriod3S01.Name = "lblPeriod3S01"
        lblPeriod3S01.Size = New Size(82, 40)
        lblPeriod3S01.TabIndex = 52
        lblPeriod3S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecessS01
        ' 
        lblRecessS01.Anchor = AnchorStyles.None
        lblRecessS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecessS01.Location = New Point(141, 183)
        lblRecessS01.Name = "lblRecessS01"
        lblRecessS01.Size = New Size(82, 40)
        lblRecessS01.TabIndex = 53
        lblRecessS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2S01
        ' 
        lblPeriod2S01.Anchor = AnchorStyles.None
        lblPeriod2S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2S01.Location = New Point(141, 138)
        lblPeriod2S01.Name = "lblPeriod2S01"
        lblPeriod2S01.Size = New Size(82, 40)
        lblPeriod2S01.TabIndex = 54
        lblPeriod2S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1S01
        ' 
        lblPeriod1S01.Anchor = AnchorStyles.None
        lblPeriod1S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1S01.Location = New Point(141, 93)
        lblPeriod1S01.Name = "lblPeriod1S01"
        lblPeriod1S01.Size = New Size(82, 40)
        lblPeriod1S01.TabIndex = 55
        lblPeriod1S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S02
        ' 
        lblPeriod5S02.Anchor = AnchorStyles.None
        lblPeriod5S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S02.Location = New Point(230, 363)
        lblPeriod5S02.Name = "lblPeriod5S02"
        lblPeriod5S02.Size = New Size(82, 40)
        lblPeriod5S02.TabIndex = 103
        lblPeriod5S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorial
        ' 
        lblTutorial.Anchor = AnchorStyles.None
        lblTutorial.Font = New Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorial.Location = New Point(4, 48)
        lblTutorial.Name = "lblTutorial"
        lblTutorial.Size = New Size(130, 40)
        lblTutorial.TabIndex = 17
        lblTutorial.Text = "Tutorial"
        lblTutorial.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS10
        ' 
        lblS10.Anchor = AnchorStyles.None
        lblS10.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS10.Location = New Point(943, 3)
        lblS10.Name = "lblS10"
        lblS10.Size = New Size(89, 40)
        lblS10.TabIndex = 17
        lblS10.Text = "S10"
        lblS10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS09
        ' 
        lblS09.Anchor = AnchorStyles.None
        lblS09.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS09.Location = New Point(860, 3)
        lblS09.Name = "lblS09"
        lblS09.Size = New Size(67, 40)
        lblS09.TabIndex = 17
        lblS09.Text = "S09"
        lblS09.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS08
        ' 
        lblS08.Anchor = AnchorStyles.None
        lblS08.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS08.Location = New Point(771, 3)
        lblS08.Name = "lblS08"
        lblS08.Size = New Size(67, 40)
        lblS08.TabIndex = 18
        lblS08.Text = "S08"
        lblS08.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS07
        ' 
        lblS07.Anchor = AnchorStyles.None
        lblS07.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS07.Location = New Point(682, 3)
        lblS07.Name = "lblS07"
        lblS07.Size = New Size(67, 40)
        lblS07.TabIndex = 19
        lblS07.Text = "S07"
        lblS07.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS06
        ' 
        lblS06.Anchor = AnchorStyles.None
        lblS06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS06.Location = New Point(593, 3)
        lblS06.Name = "lblS06"
        lblS06.RightToLeft = RightToLeft.No
        lblS06.Size = New Size(67, 40)
        lblS06.TabIndex = 20
        lblS06.Text = "S06"
        lblS06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS05
        ' 
        lblS05.Anchor = AnchorStyles.None
        lblS05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS05.Location = New Point(504, 3)
        lblS05.Name = "lblS05"
        lblS05.Size = New Size(67, 40)
        lblS05.TabIndex = 21
        lblS05.Text = "S05"
        lblS05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS04
        ' 
        lblS04.Anchor = AnchorStyles.None
        lblS04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS04.Location = New Point(415, 3)
        lblS04.Name = "lblS04"
        lblS04.Size = New Size(67, 40)
        lblS04.TabIndex = 22
        lblS04.Text = "S04"
        lblS04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS03
        ' 
        lblS03.Anchor = AnchorStyles.None
        lblS03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS03.Location = New Point(326, 3)
        lblS03.Name = "lblS03"
        lblS03.Size = New Size(67, 40)
        lblS03.TabIndex = 23
        lblS03.Text = "S03"
        lblS03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS02
        ' 
        lblS02.Anchor = AnchorStyles.None
        lblS02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS02.Location = New Point(237, 3)
        lblS02.Name = "lblS02"
        lblS02.Size = New Size(67, 40)
        lblS02.TabIndex = 17
        lblS02.Text = "S02"
        lblS02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblS01
        ' 
        lblS01.Anchor = AnchorStyles.None
        lblS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblS01.Location = New Point(148, 3)
        lblS01.Name = "lblS01"
        lblS01.Size = New Size(67, 40)
        lblS01.TabIndex = 0
        lblS01.Text = "S01"
        lblS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5
        ' 
        lblPeriod5.Anchor = AnchorStyles.None
        lblPeriod5.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5.Location = New Point(4, 363)
        lblPeriod5.Name = "lblPeriod5"
        lblPeriod5.Size = New Size(130, 40)
        lblPeriod5.TabIndex = 24
        lblPeriod5.Text = "Period 5"
        lblPeriod5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod1
        ' 
        lblPeriod1.Anchor = AnchorStyles.None
        lblPeriod1.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod1.Location = New Point(4, 93)
        lblPeriod1.Name = "lblPeriod1"
        lblPeriod1.Size = New Size(130, 40)
        lblPeriod1.TabIndex = 27
        lblPeriod1.Text = "Period 1"
        lblPeriod1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod2
        ' 
        lblPeriod2.Anchor = AnchorStyles.None
        lblPeriod2.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod2.Location = New Point(4, 138)
        lblPeriod2.Name = "lblPeriod2"
        lblPeriod2.Size = New Size(130, 40)
        lblPeriod2.TabIndex = 26
        lblPeriod2.Text = "Period 2"
        lblPeriod2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRecess
        ' 
        lblRecess.Anchor = AnchorStyles.None
        lblRecess.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecess.Location = New Point(11, 183)
        lblRecess.Name = "lblRecess"
        lblRecess.Size = New Size(115, 40)
        lblRecess.TabIndex = 25
        lblRecess.Text = "Recess"
        lblRecess.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod3
        ' 
        lblPeriod3.Anchor = AnchorStyles.None
        lblPeriod3.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod3.Location = New Point(4, 228)
        lblPeriod3.Name = "lblPeriod3"
        lblPeriod3.Size = New Size(130, 40)
        lblPeriod3.TabIndex = 28
        lblPeriod3.Text = "Period 3"
        lblPeriod3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod4
        ' 
        lblPeriod4.Anchor = AnchorStyles.None
        lblPeriod4.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod4.Location = New Point(4, 273)
        lblPeriod4.Name = "lblPeriod4"
        lblPeriod4.Size = New Size(130, 40)
        lblPeriod4.TabIndex = 29
        lblPeriod4.Text = "Period 4"
        lblPeriod4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLunch
        ' 
        lblLunch.Anchor = AnchorStyles.None
        lblLunch.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLunch.Location = New Point(4, 318)
        lblLunch.Name = "lblLunch"
        lblLunch.Size = New Size(129, 40)
        lblLunch.TabIndex = 30
        lblLunch.Text = "Lunch"
        lblLunch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTutorialS01
        ' 
        lblTutorialS01.Anchor = AnchorStyles.None
        lblTutorialS01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTutorialS01.Location = New Point(141, 48)
        lblTutorialS01.Name = "lblTutorialS01"
        lblTutorialS01.Size = New Size(82, 40)
        lblTutorialS01.TabIndex = 32
        lblTutorialS01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S01
        ' 
        lblPeriod6S01.Anchor = AnchorStyles.None
        lblPeriod6S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S01.Location = New Point(141, 406)
        lblPeriod6S01.Name = "lblPeriod6S01"
        lblPeriod6S01.Size = New Size(82, 45)
        lblPeriod6S01.TabIndex = 122
        lblPeriod6S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod5S01
        ' 
        lblPeriod5S01.Anchor = AnchorStyles.None
        lblPeriod5S01.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod5S01.Location = New Point(141, 363)
        lblPeriod5S01.Name = "lblPeriod5S01"
        lblPeriod5S01.Size = New Size(82, 40)
        lblPeriod5S01.TabIndex = 124
        lblPeriod5S01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S02
        ' 
        lblPeriod6S02.Anchor = AnchorStyles.None
        lblPeriod6S02.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S02.Location = New Point(230, 406)
        lblPeriod6S02.Name = "lblPeriod6S02"
        lblPeriod6S02.Size = New Size(82, 45)
        lblPeriod6S02.TabIndex = 127
        lblPeriod6S02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S05
        ' 
        lblPeriod6S05.Anchor = AnchorStyles.None
        lblPeriod6S05.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S05.Location = New Point(497, 406)
        lblPeriod6S05.Name = "lblPeriod6S05"
        lblPeriod6S05.Size = New Size(82, 45)
        lblPeriod6S05.TabIndex = 130
        lblPeriod6S05.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S06
        ' 
        lblPeriod6S06.Anchor = AnchorStyles.None
        lblPeriod6S06.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S06.Location = New Point(586, 406)
        lblPeriod6S06.Name = "lblPeriod6S06"
        lblPeriod6S06.Size = New Size(82, 45)
        lblPeriod6S06.TabIndex = 129
        lblPeriod6S06.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S04
        ' 
        lblPeriod6S04.Anchor = AnchorStyles.None
        lblPeriod6S04.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S04.Location = New Point(408, 406)
        lblPeriod6S04.Name = "lblPeriod6S04"
        lblPeriod6S04.Size = New Size(82, 45)
        lblPeriod6S04.TabIndex = 128
        lblPeriod6S04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6S03
        ' 
        lblPeriod6S03.Anchor = AnchorStyles.None
        lblPeriod6S03.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6S03.Location = New Point(319, 406)
        lblPeriod6S03.Name = "lblPeriod6S03"
        lblPeriod6S03.Size = New Size(82, 45)
        lblPeriod6S03.TabIndex = 125
        lblPeriod6S03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeriod6
        ' 
        lblPeriod6.Anchor = AnchorStyles.None
        lblPeriod6.Font = New Font("HoloLens MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeriod6.Location = New Point(4, 406)
        lblPeriod6.Name = "lblPeriod6"
        lblPeriod6.Size = New Size(130, 45)
        lblPeriod6.TabIndex = 25
        lblPeriod6.Text = "Period 6"
        lblPeriod6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnHelp
        ' 
        btnHelp.BackColor = Color.LightGray
        btnHelp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnHelp.Location = New Point(801, 838)
        btnHelp.Margin = New Padding(3, 4, 3, 4)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(174, 41)
        btnHelp.TabIndex = 17
        btnHelp.Text = "Help"
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' btnSubmitRequest
        ' 
        btnSubmitRequest.BackColor = Color.LightGray
        btnSubmitRequest.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmitRequest.Location = New Point(997, 838)
        btnSubmitRequest.Margin = New Padding(3, 4, 3, 4)
        btnSubmitRequest.Name = "btnSubmitRequest"
        btnSubmitRequest.Size = New Size(174, 41)
        btnSubmitRequest.TabIndex = 18
        btnSubmitRequest.Text = "Submit Request"
        btnSubmitRequest.UseVisualStyleBackColor = False
        ' 
        ' MasterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScrollMargin = New Size(30, 30)
        AutoSize = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1272, 892)
        Controls.Add(btnSubmitRequest)
        Controls.Add(btnHelp)
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
    Friend WithEvents lblPeriod5S02 As Label
    Friend WithEvents lblTutorialS01 As Label
    Friend WithEvents lblPeriod6S01 As Label
    Friend WithEvents lblPeriod1S07 As Label
    Friend WithEvents lblPeriod2S07 As Label
    Friend WithEvents lblRecessS07 As Label
    Friend WithEvents lblPeriod3S07 As Label
    Friend WithEvents lblLunchS07 As Label
    Friend WithEvents lblPeriod5S07 As Label
    Friend WithEvents lblPeriod6S07 As Label
    Friend WithEvents lblPeriod4S06 As Label
    Friend WithEvents lblLunchS06 As Label
    Friend WithEvents lblPeriod5S06 As Label
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
    Friend WithEvents lblLunchS05 As Label
    Friend WithEvents lblPeriod5S05 As Label
    Friend WithEvents lblPeriod5S04 As Label
    Friend WithEvents lblLunchS04 As Label
    Friend WithEvents lblPeriod4S04 As Label
    Friend WithEvents lblPeriod3S04 As Label
    Friend WithEvents lblRecessS04 As Label
    Friend WithEvents lblPeriod2S04 As Label
    Friend WithEvents lblPeriod1S04 As Label
    Friend WithEvents lblTutorialS04 As Label
    Friend WithEvents lblPeriod5S03 As Label
    Friend WithEvents lblLunchS03 As Label
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
    Friend WithEvents lblLunchS02 As Label
    Friend WithEvents lblLunchS01 As Label
    Friend WithEvents lblPeriod4S01 As Label
    Friend WithEvents lblPeriod3S01 As Label
    Friend WithEvents lblRecessS01 As Label
    Friend WithEvents lblPeriod2S01 As Label
    Friend WithEvents lblPeriod1S01 As Label
    Friend WithEvents lblPeriod5S01 As Label
    Friend WithEvents lblPeriod6S02 As Label
    Friend WithEvents lblPeriod6S05 As Label
    Friend WithEvents lblPeriod6S06 As Label
    Friend WithEvents lblPeriod6S04 As Label
    Friend WithEvents lblPeriod6S03 As Label
    Friend WithEvents lblPeriod6S09 As Label
    Friend WithEvents lblPeriod5S09 As Label
    Friend WithEvents lblLunchS09 As Label
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
    Friend WithEvents lblLunchS08 As Label
    Friend WithEvents lblPeriod5S08 As Label
    Friend WithEvents lblPeriod6S08 As Label
    Friend WithEvents lblTutorialS07 As Label
    Friend WithEvents lblPeriod6S10 As Label
    Friend WithEvents lblPeriod5S10 As Label
    Friend WithEvents lblLunchS10 As Label
    Friend WithEvents lblPeriod4S10 As Label
    Friend WithEvents lblPeriod3S10 As Label
    Friend WithEvents lblRecessS10 As Label
    Friend WithEvents lblPeriod2S10 As Label
    Friend WithEvents lblPeriod1S10 As Label
    Friend WithEvents lblTutorialS10 As Label
    Friend WithEvents lblPeriod4S07 As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnSubmitRequest As Button
End Class
