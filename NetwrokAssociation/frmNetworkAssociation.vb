' Program:      Network Association Conference Registration      
' Name:         Trevor Anthony Bowling
' Date:         April 21, 2014
' Purpose:      This program calculates the registration costs for a conference attendee. 
'               It aslo records the costs in a text file.

Option Strict On

Public Class frmNetworkAssociation

    Private Sub btnCalculateCosts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateCosts.Click
        ' This Calculate Costs button click event handler edits the
        ' registration(costs) form to ensure it contains valid data.
        ' Then, after passing control to the business class, it
        ' displays the registration cost.

        Dim objAttendee As Attendee
        Dim objPreConferenceAttendee As PreConferenceAttendee
        Dim InputError As Boolean = False

        ' Is corporation ID entered properly
        If txtCorporationID.MaskFull = False Then
            MsgBox("Enter your Corporation ID in the Corporation ID box", , _
                   "Error")
            txtCorporationID.Clear()
            txtCorporationID.Focus()
            InputError = True
            ' Is first name entered properly
        ElseIf txtFirstName.TextLength < 1 Or _
            txtFirstName.Text < "A" Then
            MsgBox("Enter your first name in the First Name box", , "Error")
            txtFirstName.Clear()
            txtFirstName.Focus()
            InputError = True
            ' Is last name entered properly
        ElseIf txtLastName.TextLength < 1 Or _
            txtLastName.Text < "A" Then
            MsgBox("Enter your last name in the Last Name box", , "Error")
            txtLastName.Clear()
            txtLastName.Focus()
            InputError = True
            ' Is number of days entered properly
        ElseIf Not IsNumeric(txtNumberOfDays.Text) Then
            MsgBox("Enter the number of days in the Number of Days box", , _
                   "Error")
            txtNumberOfDays.Clear()
            txtNumberOfDays.Focus()
            InputError = True
            ' Has 1-4 days been entered
        ElseIf Convert.ToInt32(txtNumberOfDays.Text) < 1 _
            Or Convert.ToInt32(txtNumberOfDays.Text) > 4 Then
            MsgBox("Days must be 1-4", , "Error")
            txtNumberOfDays.Clear()
            txtNumberOfDays.Focus()
            InputError = True
        End If

        ' If no input error, process the registration costs]
        If Not InputError Then
            If radTakeCourse.Checked Then
                objPreConferenceAttendee = New PreConferenceAttendee(txtCorporationID.Text, _
                txtFirstName.Text, txtLastName.Text, txtNumberOfDays.Text, radNetworkSecurity.Checked, _
                radConqueringYourWAN.Checked, radMovingBitsAndBytes.Checked)
                lblCost.Visible = True
                lblCost.Text = "Total conference costs are: " _
                & (objPreConferenceAttendee.ComputeCosts()).ToString("C2")
            Else
                objAttendee = New Attendee(txtCorporationID.Text, _
                txtFirstName.Text, txtLastName.Text, txtNumberOfDays.Text)
                lblCost.Visible = True
                lblCost.Text = "Total conference costs are: " _
                & (objAttendee.ComputeCosts()).ToString("C2")
            End If
        End If

    End Sub

    Private Sub radOnTakeCourse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTakeCourse.CheckedChanged
        ' This event handler is executed when the Pre-Conference radio button
        ' is selected. It makes the Courses radio buttons visible.

        grpCourses.Visible = True

    End Sub

    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click
        ' This event handler is executed when the user clicks the
        ' Clear Form button. It resets all objects on the user interfaces.

        txtCorporationID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtNumberOfDays.Clear()
        radTakeCourse.Checked = False
        grpCourses.Visible = False
        radNetworkSecurity.Checked = False
        radConqueringYourWAN.Checked = False
        radMovingBitsAndBytes.Checked = False
        lblCost.Visible = False
        txtCorporationID.Focus()

    End Sub

End Class
