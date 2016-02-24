' Class:        Registration Log File
' Developer:    Trevor Anthony Bowling
' Date:         April 21, 2014
' Purpose:      This class represents the Registration Log File. The WriteRecord
'               procedure writes a comma-delineated registration log file that
'               contains the Corporation ID, First Name, Last Name,
'               Number of Days, Course, and Total Costs.


Option Strict On

Public Class RegistrationLogFile


    ' Class variables
    Private _strCorporationID As String
    Private _strFirstName As String
    Private _strLastName As String
    Private _strCourse As String
    Private _decCosts As Decimal

    Sub New(ByVal ConferenceID As String, ByVal FirstName As String, _
            ByVal LastName As String, ByVal Course As String, ByVal Costs As Decimal)
        ' This sub procedure is the constructor for the RegistrationLogFile
        ' class.

        'The following code assigns the arguments to class variables
        _strCorporationID = _strCorporationID
        _strFirstName = FirstName
        _strLastName = LastName
        _strCourse = Course
        _decCosts = Costs

    End Sub

    Sub WriteRecord()
        ' This subprocedure opens the RegistrationLogFile output text file
        ' and then writes a record in the comma-delimited file.

        Dim strNameandLocationOfFile As String = "G:\RegistrationLogFile.txt"

        Try
            Dim objWriter As IO.StreamWriter = _
                IO.File.AppendText(strNameandLocationOfFile)

            objWriter.Write(_strCorporationID & ",")
            objWriter.Write(_strFirstName & ",")
            objWriter.Write(_strLastName & ",")
            objWriter.Write(_strCourse & ",")
            objWriter.WriteLine(_decCosts)
            objWriter.Close()

        Catch ex As Exception
            MessageBox.Show("No device available - program aborted", "Error")
            Application.Exit()

        End Try

    End Sub

End Class
