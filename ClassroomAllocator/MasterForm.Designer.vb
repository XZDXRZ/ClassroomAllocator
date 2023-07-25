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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDateHeading = New System.Windows.Forms.Label()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.btnLoadTimetable = New System.Windows.Forms.Button()
        Me.lblApplicantNameHeading = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(474, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(453, 97)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Yarra Valley Grammar Classroom Allocator"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClassroomAllocator.My.Resources.Resources.yarra_logo
        Me.PictureBox1.Location = New System.Drawing.Point(944, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        Me.lblApplicantNameHeading.Location = New System.Drawing.Point(283, 34)
        Me.lblApplicantNameHeading.Name = "lblApplicantNameHeading"
        Me.lblApplicantNameHeading.Size = New System.Drawing.Size(148, 23)
        Me.lblApplicantNameHeading.TabIndex = 5
        Me.lblApplicantNameHeading.Text = "Applicant Name"
        '
        'MasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1109, 675)
        Me.Controls.Add(Me.lblApplicantNameHeading)
        Me.Controls.Add(Me.btnLoadTimetable)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.lblDateHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterForm"
        Me.Text = "Classroom Allocator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDateHeading As Label
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents btnLoadTimetable As Button
    Friend WithEvents lblApplicantNameHeading As Label
End Class
