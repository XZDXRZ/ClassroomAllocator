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
        cboTimeInput = New ComboBox()
        CType(picYarraLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Font = New Font("Algerian", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(621, 45)
        lblName.Name = "lblName"
        lblName.Size = New Size(420, 123)
        lblName.TabIndex = 0
        lblName.Text = "Yarra Valley Grammar Classroom Allocator"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picYarraLogo
        ' 
        picYarraLogo.Image = My.Resources.Resources.yarra_logo
        picYarraLogo.Location = New Point(1080, 30)
        picYarraLogo.Margin = New Padding(3, 4, 3, 4)
        picYarraLogo.Name = "picYarraLogo"
        picYarraLogo.Size = New Size(155, 142)
        picYarraLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picYarraLogo.TabIndex = 1
        picYarraLogo.TabStop = False
        ' 
        ' lblDateHeading
        ' 
        lblDateHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateHeading.Location = New Point(26, 45)
        lblDateHeading.Name = "lblDateHeading"
        lblDateHeading.Size = New Size(165, 31)
        lblDateHeading.TabIndex = 2
        lblDateHeading.Text = "Choose a Date: "' 
        ' MonthCalendar
        ' 
        MonthCalendar.Location = New Point(26, 88)
        MonthCalendar.Margin = New Padding(10, 12, 10, 12)
        MonthCalendar.Name = "MonthCalendar"
        MonthCalendar.TabIndex = 3
        ' 
        ' btnLoadTimetable
        ' 
        btnLoadTimetable.BackColor = Color.LightGray
        btnLoadTimetable.Location = New Point(26, 320)
        btnLoadTimetable.Margin = New Padding(3, 4, 3, 4)
        btnLoadTimetable.Name = "btnLoadTimetable"
        btnLoadTimetable.Size = New Size(144, 41)
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
        lblPurposeHeading.Location = New Point(323, 191)
        lblPurposeHeading.Name = "lblPurposeHeading"
        lblPurposeHeading.Size = New Size(169, 31)
        lblPurposeHeading.TabIndex = 7
        lblPurposeHeading.Text = "Purpose:"' 
        ' txtPurposeInput
        ' 
        txtPurposeInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPurposeInput.Location = New Point(323, 237)
        txtPurposeInput.Margin = New Padding(3, 4, 3, 4)
        txtPurposeInput.Name = "txtPurposeInput"
        txtPurposeInput.Size = New Size(233, 32)
        txtPurposeInput.TabIndex = 8
        ' 
        ' lblTimeHeading
        ' 
        lblTimeHeading.Font = New Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTimeHeading.Location = New Point(621, 191)
        lblTimeHeading.Name = "lblTimeHeading"
        lblTimeHeading.Size = New Size(74, 31)
        lblTimeHeading.TabIndex = 9
        lblTimeHeading.Text = "Time:"' 
        ' cboTimeInput
        ' 
        cboTimeInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cboTimeInput.FormattingEnabled = True
        cboTimeInput.Location = New Point(687, 193)
        cboTimeInput.Margin = New Padding(3, 4, 3, 4)
        cboTimeInput.Name = "cboTimeInput"
        cboTimeInput.Size = New Size(165, 33)
        cboTimeInput.TabIndex = 11
        ' 
        ' MasterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1267, 900)
        Controls.Add(cboTimeInput)
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
    Friend WithEvents cboTimeInput As ComboBox
End Class
