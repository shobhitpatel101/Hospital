<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hospital
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hospital))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.patientEnquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newEnteryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.patientDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.patientListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.staffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.staffInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.billingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(873, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.patientEnquiryToolStripMenuItem, Me.staffToolStripMenuItem, Me.billingToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(873, 29)
        Me.menuStrip1.TabIndex = 10
        Me.menuStrip1.Text = "menuStrip1"
        '
        'patientEnquiryToolStripMenuItem
        '
        Me.patientEnquiryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newEnteryToolStripMenuItem, Me.patientDetailToolStripMenuItem, Me.toolStripMenuItem1, Me.patientListToolStripMenuItem})
        Me.patientEnquiryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientEnquiryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.patientEnquiryToolStripMenuItem.Name = "patientEnquiryToolStripMenuItem"
        Me.patientEnquiryToolStripMenuItem.Size = New System.Drawing.Size(127, 25)
        Me.patientEnquiryToolStripMenuItem.Text = "&Patient Enquiry"
        '
        'newEnteryToolStripMenuItem
        '
        Me.newEnteryToolStripMenuItem.Name = "newEnteryToolStripMenuItem"
        Me.newEnteryToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.newEnteryToolStripMenuItem.Text = "&New Entery"
        '
        'patientDetailToolStripMenuItem
        '
        Me.patientDetailToolStripMenuItem.Name = "patientDetailToolStripMenuItem"
        Me.patientDetailToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.patientDetailToolStripMenuItem.Text = "Patient &Detail"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(169, 6)
        '
        'patientListToolStripMenuItem
        '
        Me.patientListToolStripMenuItem.Name = "patientListToolStripMenuItem"
        Me.patientListToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.patientListToolStripMenuItem.Text = "Patient &List"
        '
        'staffToolStripMenuItem
        '
        Me.staffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.staffInfoToolStripMenuItem})
        Me.staffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffToolStripMenuItem.Name = "staffToolStripMenuItem"
        Me.staffToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.staffToolStripMenuItem.Text = "&Staff"
        '
        'staffInfoToolStripMenuItem
        '
        Me.staffInfoToolStripMenuItem.Name = "staffInfoToolStripMenuItem"
        Me.staffInfoToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.staffInfoToolStripMenuItem.Text = "Staff &Information"
        '
        'billingToolStripMenuItem
        '
        Me.billingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billingToolStripMenuItem.Name = "billingToolStripMenuItem"
        Me.billingToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.billingToolStripMenuItem.Text = "&Billing"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.exitToolStripMenuItem.Text = "&Exit"
        '
        'hospital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(873, 535)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "hospital"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Private WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents patientEnquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents newEnteryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents patientDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents patientListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents staffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents staffInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents billingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
