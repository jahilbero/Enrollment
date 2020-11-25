<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tuition_Fee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tuition_Fee))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MyScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StSemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NdSemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTuitionFeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayTuitionFeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyScheduleToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MyScheduleToolStripMenuItem
        '
        Me.MyScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StSemesterToolStripMenuItem, Me.NdSemesterToolStripMenuItem})
        Me.MyScheduleToolStripMenuItem.Name = "MyScheduleToolStripMenuItem"
        Me.MyScheduleToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.MyScheduleToolStripMenuItem.Text = "My Schedule"
        '
        'StSemesterToolStripMenuItem
        '
        Me.StSemesterToolStripMenuItem.Name = "StSemesterToolStripMenuItem"
        Me.StSemesterToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.StSemesterToolStripMenuItem.Text = "1st Semester"
        '
        'NdSemesterToolStripMenuItem
        '
        Me.NdSemesterToolStripMenuItem.Name = "NdSemesterToolStripMenuItem"
        Me.NdSemesterToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NdSemesterToolStripMenuItem.Text = "2nd Semester"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTuitionFeeToolStripMenuItem, Me.PayTuitionFeeToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'ViewTuitionFeeToolStripMenuItem
        '
        Me.ViewTuitionFeeToolStripMenuItem.Name = "ViewTuitionFeeToolStripMenuItem"
        Me.ViewTuitionFeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewTuitionFeeToolStripMenuItem.Text = "View Tuition Fee"
        '
        'PayTuitionFeeToolStripMenuItem
        '
        Me.PayTuitionFeeToolStripMenuItem.Name = "PayTuitionFeeToolStripMenuItem"
        Me.PayTuitionFeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PayTuitionFeeToolStripMenuItem.Text = "Pay Tuition Fee"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Tuition_Fee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Tuition_Fee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tuition_Fee"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MyScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StSemesterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NdSemesterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTuitionFeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayTuitionFeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
