<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetworkAssociation
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
        Me.txtCorporationID = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.lblCorporationID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.radTakeCourse = New System.Windows.Forms.RadioButton()
        Me.btnCalculateCosts = New System.Windows.Forms.Button()
        Me.grpPreConference = New System.Windows.Forms.GroupBox()
        Me.radMovingBitsAndBytes = New System.Windows.Forms.RadioButton()
        Me.grpCourses = New System.Windows.Forms.GroupBox()
        Me.radConqueringYourWAN = New System.Windows.Forms.RadioButton()
        Me.radNetworkSecurity = New System.Windows.Forms.RadioButton()
        Me.picNetwork = New System.Windows.Forms.PictureBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.grpPreConference.SuspendLayout()
        Me.grpCourses.SuspendLayout()
        CType(Me.picNetwork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorporationID
        '
        Me.txtCorporationID.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationID.Location = New System.Drawing.Point(230, 147)
        Me.txtCorporationID.Mask = "00000"
        Me.txtCorporationID.Name = "txtCorporationID"
        Me.txtCorporationID.Size = New System.Drawing.Size(66, 30)
        Me.txtCorporationID.TabIndex = 27
        Me.txtCorporationID.ValidatingType = GetType(Integer)
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(258, 264)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(49, 30)
        Me.txtNumberOfDays.TabIndex = 26
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(149, 510)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(340, 23)
        Me.lblCost.TabIndex = 25
        Me.lblCost.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClearForm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(373, 434)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(127, 31)
        Me.btnClearForm.TabIndex = 24
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(38, 271)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(162, 23)
        Me.lblNumberOfDays.TabIndex = 20
        Me.lblNumberOfDays.Text = "Number Of Days: "
        '
        'lblCorporationID
        '
        Me.lblCorporationID.AutoSize = True
        Me.lblCorporationID.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorporationID.Location = New System.Drawing.Point(38, 157)
        Me.lblCorporationID.Name = "lblCorporationID"
        Me.lblCorporationID.Size = New System.Drawing.Size(146, 23)
        Me.lblCorporationID.TabIndex = 19
        Me.lblCorporationID.Text = "Corporation ID: "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(204, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(404, 78)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Network Association " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conference Registration"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'radTakeCourse
        '
        Me.radTakeCourse.AutoSize = True
        Me.radTakeCourse.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTakeCourse.Location = New System.Drawing.Point(7, 20)
        Me.radTakeCourse.Name = "radTakeCourse"
        Me.radTakeCourse.Size = New System.Drawing.Size(203, 50)
        Me.radTakeCourse.TabIndex = 0
        Me.radTakeCourse.Text = "Take Pre-Conference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Course"
        Me.radTakeCourse.UseVisualStyleBackColor = True
        '
        'btnCalculateCosts
        '
        Me.btnCalculateCosts.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCalculateCosts.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCosts.Location = New System.Drawing.Point(142, 434)
        Me.btnCalculateCosts.Name = "btnCalculateCosts"
        Me.btnCalculateCosts.Size = New System.Drawing.Size(154, 31)
        Me.btnCalculateCosts.TabIndex = 23
        Me.btnCalculateCosts.Text = "Calculate Costs"
        Me.btnCalculateCosts.UseVisualStyleBackColor = False
        '
        'grpPreConference
        '
        Me.grpPreConference.Controls.Add(Me.radTakeCourse)
        Me.grpPreConference.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPreConference.Location = New System.Drawing.Point(26, 323)
        Me.grpPreConference.Name = "grpPreConference"
        Me.grpPreConference.Size = New System.Drawing.Size(212, 73)
        Me.grpPreConference.TabIndex = 21
        Me.grpPreConference.TabStop = False
        Me.grpPreConference.Text = "Pre-Conference"
        '
        'radMovingBitsAndBytes
        '
        Me.radMovingBitsAndBytes.AutoSize = True
        Me.radMovingBitsAndBytes.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovingBitsAndBytes.Location = New System.Drawing.Point(7, 67)
        Me.radMovingBitsAndBytes.Name = "radMovingBitsAndBytes"
        Me.radMovingBitsAndBytes.Size = New System.Drawing.Size(123, 50)
        Me.radMovingBitsAndBytes.TabIndex = 2
        Me.radMovingBitsAndBytes.TabStop = True
        Me.radMovingBitsAndBytes.Text = "Moving Bits" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Bytes"
        Me.radMovingBitsAndBytes.UseVisualStyleBackColor = True
        '
        'grpCourses
        '
        Me.grpCourses.Controls.Add(Me.radMovingBitsAndBytes)
        Me.grpCourses.Controls.Add(Me.radConqueringYourWAN)
        Me.grpCourses.Controls.Add(Me.radNetworkSecurity)
        Me.grpCourses.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCourses.Location = New System.Drawing.Point(383, 274)
        Me.grpCourses.Name = "grpCourses"
        Me.grpCourses.Size = New System.Drawing.Size(239, 122)
        Me.grpCourses.TabIndex = 22
        Me.grpCourses.TabStop = False
        Me.grpCourses.Text = "Courses"
        Me.grpCourses.Visible = False
        '
        'radConqueringYourWAN
        '
        Me.radConqueringYourWAN.AutoSize = True
        Me.radConqueringYourWAN.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConqueringYourWAN.Location = New System.Drawing.Point(7, 43)
        Me.radConqueringYourWAN.Name = "radConqueringYourWAN"
        Me.radConqueringYourWAN.Size = New System.Drawing.Size(217, 27)
        Me.radConqueringYourWAN.TabIndex = 1
        Me.radConqueringYourWAN.TabStop = True
        Me.radConqueringYourWAN.Text = "Conquering Your WAN"
        Me.radConqueringYourWAN.UseVisualStyleBackColor = True
        '
        'radNetworkSecurity
        '
        Me.radNetworkSecurity.AutoSize = True
        Me.radNetworkSecurity.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNetworkSecurity.Location = New System.Drawing.Point(7, 20)
        Me.radNetworkSecurity.Name = "radNetworkSecurity"
        Me.radNetworkSecurity.Size = New System.Drawing.Size(170, 27)
        Me.radNetworkSecurity.TabIndex = 0
        Me.radNetworkSecurity.TabStop = True
        Me.radNetworkSecurity.Text = "Network Security"
        Me.radNetworkSecurity.UseVisualStyleBackColor = True
        '
        'picNetwork
        '
        Me.picNetwork.BackColor = System.Drawing.Color.Transparent
        Me.picNetwork.BackgroundImage = Global.NetwrokAssociation.My.Resources.Resources.conference1
        Me.picNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNetwork.Location = New System.Drawing.Point(41, 30)
        Me.picNetwork.Name = "picNetwork"
        Me.picNetwork.Size = New System.Drawing.Size(157, 100)
        Me.picNetwork.TabIndex = 18
        Me.picNetwork.TabStop = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(37, 209)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(113, 23)
        Me.lblFirstName.TabIndex = 28
        Me.lblFirstName.Text = "First Name: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(192, 206)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(115, 30)
        Me.txtFirstName.TabIndex = 29
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(436, 206)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(186, 30)
        Me.txtLastName.TabIndex = 31
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(330, 209)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(111, 23)
        Me.lblLastName.TabIndex = 30
        Me.lblLastName.Text = "Last Name: "
        '
        'frmNetworkAssociation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(634, 562)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtCorporationID)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.lblCorporationID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCalculateCosts)
        Me.Controls.Add(Me.grpPreConference)
        Me.Controls.Add(Me.grpCourses)
        Me.Controls.Add(Me.picNetwork)
        Me.Name = "frmNetworkAssociation"
        Me.Text = "Network Association"
        Me.grpPreConference.ResumeLayout(False)
        Me.grpPreConference.PerformLayout()
        Me.grpCourses.ResumeLayout(False)
        Me.grpCourses.PerformLayout()
        CType(Me.picNetwork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCorporationID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNumberOfDays As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfDays As System.Windows.Forms.Label
    Friend WithEvents lblCorporationID As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents radTakeCourse As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculateCosts As System.Windows.Forms.Button
    Friend WithEvents grpPreConference As System.Windows.Forms.GroupBox
    Friend WithEvents radMovingBitsAndBytes As System.Windows.Forms.RadioButton
    Friend WithEvents grpCourses As System.Windows.Forms.GroupBox
    Friend WithEvents radConqueringYourWAN As System.Windows.Forms.RadioButton
    Friend WithEvents radNetworkSecurity As System.Windows.Forms.RadioButton
    Friend WithEvents picNetwork As System.Windows.Forms.PictureBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label

End Class
