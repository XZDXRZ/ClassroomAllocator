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
        lblDate = New Label()
        mcdDate = New MonthCalendar()
        SuspendLayout()
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(12, 9)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(119, 20)
        lblDate.TabIndex = 0
        lblDate.Text = "Choose the Date"
        lblDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' mcdDate
        ' 
        mcdDate.Location = New Point(12, 38)
        mcdDate.Name = "mcdDate"
        mcdDate.TabIndex = 1
        ' 
        ' MasterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(mcdDate)
        Controls.Add(lblDate)
        Name = "MasterForm"
        Text = "Classroom Allocator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents mcdDate As MonthCalendar
End Class
