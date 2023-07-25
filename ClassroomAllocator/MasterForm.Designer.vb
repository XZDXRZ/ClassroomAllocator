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
        Me.lblName = New System.Windows.Forms.Label()
        Me.pbYarraLogo = New System.Windows.Forms.PictureBox()
        Me.lblDateHeading = New System.Windows.Forms.Label()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.btnLoadTimetable = New System.Windows.Forms.Button()
        Me.lblApplicantNameHeading = New System.Windows.Forms.Label()
        Me.txtApplicantNameInput = New System.Windows.Forms.TextBox()
        Me.lblPurposeHeading = New System.Windows.Forms.Label()
        Me.txtPurposeInput = New System.Windows.Forms.TextBox()
        Me.lblTimeHeading = New System.Windows.Forms.Label()
        Me.txtTimeInput = New System.Windows.Forms.TextBox()
        CType(Me.pbYarraLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(543, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(368, 84)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Yarra Valley Grammar Classroom Allocator"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbYarraLogo
        '
        Me.pbYarraLogo.Image = Global.ClassroomAllocator.My.Resources.Resources.yarra_logo
        Me.pbYarraLogo.Location = New System.Drawing.Point(966, 23)
        Me.pbYarraLogo.Name = "pbYarraLogo"
        Me.pbYarraLogo.Size = New System.Drawing.Size(115, 106)
        Me.pbYarraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbYarraLogo.TabIndex = 1
        Me.pbYarraLogo.TabStop = False
        '
        'lblDateHeading
        '
        Me.lblDateHeading.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDateHeading.Location = New System.Drawing.Point(23, 34)
        Me.lblDateHeading.Name = "lblDateHeading"
        Me.lblDateHeading.Size = New System.Drawing.Size(100, 23)
        Me.lblDateHeading.TabIndex = 2
        Me.lblDateHeading.Text = "Date: "
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(23, 66)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 3
        '
        'btnLoadTimetable
        '
        Me.btnLoadTimetable.BackColor = System.Drawing.Color.LightGray
        Me.btnLoadTimetable.Location = New System.Drawing.Point(23, 240)
        Me.btnLoadTimetable.Name = "btnLoadTimetable"
        Me.btnLoadTimetable.Size = New System.Drawing.Size(126, 31)
        Me.btnLoadTimetable.TabIndex = 4
        Me.btnLoadTimetable.Text = "Load Timetable"
        Me.btnLoadTimetable.UseVisualStyleBackColor = False
        '
        'lblApplicantNameHeading
        '
        Me.lblApplicantNameHeading.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblApplicantNameHeading.Location = New System.Drawing.Point(283, 64)
        Me.lblApplicantNameHeading.Name = "lblApplicantNameHeading"
        Me.lblApplicantNameHeading.Size = New System.Drawing.Size(148, 23)
        Me.lblApplicantNameHeading.TabIndex = 5
        Me.lblApplicantNameHeading.Text = "Applicant Name:"
        '
        'txtApplicantNameInput
        '
        Me.txtApplicantNameInput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApplicantNameInput.Location = New System.Drawing.Point(283, 102)
        Me.txtApplicantNameInput.Name = "txtApplicantNameInput"
        Me.txtApplicantNameInput.Size = New System.Drawing.Size(204, 27)
        Me.txtApplicantNameInput.TabIndex = 6
        '
        'lblPurposeHeading
        '
        Me.lblPurposeHeading.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPurposeHeading.Location = New System.Drawing.Point(283, 143)
        Me.lblPurposeHeading.Name = "lblPurposeHeading"
        Me.lblPurposeHeading.Size = New System.Drawing.Size(148, 23)
        Me.lblPurposeHeading.TabIndex = 7
        Me.lblPurposeHeading.Text = "Purpose:"
        '
        'txtPurposeInput
        '
        Me.txtPurposeInput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPurposeInput.Location = New System.Drawing.Point(283, 178)
        Me.txtPurposeInput.Name = "txtPurposeInput"
        Me.txtPurposeInput.Size = New System.Drawing.Size(204, 27)
        Me.txtPurposeInput.TabIndex = 8
        '
        'lblTimeHeading
        '
        Me.lblTimeHeading.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeHeading.Location = New System.Drawing.Point(543, 143)
        Me.lblTimeHeading.Name = "lblTimeHeading"
        Me.lblTimeHeading.Size = New System.Drawing.Size(65, 23)
        Me.lblTimeHeading.TabIndex = 9
        Me.lblTimeHeading.Text = "Time:"
        '
        'txtTimeInput
        '
        Me.txtTimeInput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTimeInput.Location = New System.Drawing.Point(598, 145)
        Me.txtTimeInput.Name = "txtTimeInput"
        Me.txtTimeInput.Size = New System.Drawing.Size(204, 27)
        Me.txtTimeInput.TabIndex = 10
        '
        'MasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1109, 675)
        Me.Controls.Add(Me.txtTimeInput)
        Me.Controls.Add(Me.lblTimeHeading)
        Me.Controls.Add(Me.txtPurposeInput)
        Me.Controls.Add(Me.lblPurposeHeading)
        Me.Controls.Add(Me.txtApplicantNameInput)
        Me.Controls.Add(Me.lblApplicantNameHeading)
        Me.Controls.Add(Me.btnLoadTimetable)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.lblDateHeading)
        Me.Controls.Add(Me.pbYarraLogo)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterForm"
        Me.Text = "Classroom Allocator"
        CType(Me.pbYarraLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents pbYarraLogo As PictureBox
    Friend WithEvents lblDateHeading As Label
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents btnLoadTimetable As Button
    Friend WithEvents lblApplicantNameHeading As Label
    Friend WithEvents txtApplicantNameInput As TextBox
    Friend WithEvents lblPurposeHeading As Label
    Friend WithEvents txtPurposeInput As TextBox
    Friend WithEvents lblTimeHeading As Label
    Friend WithEvents txtTimeInput As TextBox
End Class
