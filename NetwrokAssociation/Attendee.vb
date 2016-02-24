' Class:        Attendee
' Developer:    Trevor Anthony Bowling
' Date:         April 21, 2014
' Purpose:      This business class for a registering attendee
'               calculates the cost of attending the conference. It also causes the
'               attendee's costs file to be written. 

Option Strict On

Public Class Attendee

    'Class variables
    Protected _strCorporationID As String
    Protected _strFirstName As String
    Protected _strLastName As String
    Protected _intDays As Integer
    Protected _decCost As Decimal
    Protected _decCostPerDay As Decimal = 350D


    Dim objRegistrationLogFile As RegistrationLogFile


    Sub New(ByVal strCorporationID As String, ByVal strFirstName As String, _
            ByVal strLastName As String, ByVal intDays As String)
        ' This subprocedure is constructor for the Attendee class. 
        ' It is called when the object is instantiated with arguments.


        'The following code assigns the arguments to class variables
        _strCorporationID = strCorporationID
        _strFirstName = strFirstName
        _strLastName = strLastName
        _intDays = Convert.ToInt32(intDays)

    End Sub

    Overridable Function ComputeCosts() As Decimal
        ' This function computes the conference registration costs, 
        ' writes a record in the conference log file, and returns 
        ' the conference costs.

        'Calculate the cost
        _decCost = _intDays * _decCostPerDay

        'Write the conference log record
        objRegistrationLogFile = New RegistrationLogFile(_strCorporationID, _
            _strFirstName, _strLastName, "", _decCost)
        objRegistrationLogFile.WriteRecord()

        'Return the calculated cost
        Return _decCost

    End Function

End Class
