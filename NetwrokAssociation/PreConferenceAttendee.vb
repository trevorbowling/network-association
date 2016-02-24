' Class:        Pre-Conference Attendee
' Developer:    Trevor Anthony Bowling
' Date:         April 21, 2014
' Purpose:      This business class for a registering pre-conference
'               attendee calculates the cost of attending the conference. 
'               It also causes the attendee's costs file to be written. 

Option Strict On

Public Class PreConferenceAttendee
    Inherits Attendee

    ' Class variables
    Private _NetworkSecurity As Boolean
    Private _ConqueringYourWAN As Boolean
    Private _MovingBitsAndBytes As Boolean

    Dim objRegistrationLogFile As RegistrationLogFile

    Sub New(ByVal CorporationID As String, ByVal FirstName As String, _
            ByVal LastName As String, ByVal NumberOfDays As String, _
            ByVal NetworkSecurity As Boolean, ByVal ConqueringYourWAN As Boolean, _
            ByVal MovingBitsAndBytes As Boolean)

        ' This subprocedure is a constructor for the PreConferenceAttendee class. It 
        ' is called when instantiated with arguments

        MyBase.New(CorporationID, FirstName, LastName, NumberOfDays)

        'The following code assigns the arguments to class variables
        _NetworkSecurity = NetworkSecurity
        _ConqueringYourWAN = ConqueringYourWAN
        _MovingBitsAndBytes = MovingBitsAndBytes

    End Sub

    Overrides Function ComputeCosts() As Decimal
        ' This function computes the conference costs, writes a record 
        ' in the conference log file, and returns the conference costs

        'Define variables
        Const strNetworkSecurity As String = "Network Security"
        Const strConqueringYourWAN As String = "Conquering Your WAN"
        Const strMovingBitsAndBytes As String = "Moving Bits and Bytes"
        Const decCourseCost As Decimal = 675D
        Dim strCourse As String = " "

        'Calculate the cost
        _decCost = (_intDays * _decCostPerDay) + decCourseCost

        'Write the student record
        If _NetworkSecurity Then
            strCourse = strNetworkSecurity
        ElseIf _ConqueringYourWAN Then
            strCourse = strConqueringYourWAN
        ElseIf _MovingBitsAndBytes Then
            strCourse = strMovingBitsAndBytes
        End If

        objRegistrationLogFile = New RegistrationLogFile(_strCorporationID, _
             _strFirstName, _strLastName, strCourse, _decCost)
        objRegistrationLogFile.WriteRecord()

        'Return the calculated cost
        Return _decCost

    End Function

End Class
