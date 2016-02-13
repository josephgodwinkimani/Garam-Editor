Imports System.Diagnostics
Imports System.Security
Imports System.ComponentModel
Imports System.IO

'Module Module1

'Sub Main()
'Dim sSource As String
'Dim sLog As String
'Dim sEvent As String
'Dim sMachine As String

'sSource = "Garam Editor"
'sLog = "Application"
'sEvent = "Error Event"
'sMachine = "."

' If Not EventLog.SourceExists(sSource, sMachine) Then
' EventLog.CreateEventSource(sSource, sLog, sMachine)
'End If

'Dim ELog As New EventLog(sLog, sMachine, sSource)
' ELog.WriteEntry(sEvent)
'ELog.WriteEntry(sEvent, EventLogEntryType.Warning, 234, CType(3, Short))

'End Sub

'End Module
Public Class frmEventsLog



    Private Sub btnReadLog_Click(sender As Object, e As EventArgs) Handles btnReadLog.Click
        ' Log type can be Application, Security, System or any other custom log
        ' Select the log type you want to read
        Dim logtype As String = "Application"

        ' In the constructor of the eventlog, pass the log type and the computer name 
        ' from which you want to read the logs 
        Dim evtLog As New EventLog(logtype, System.Environment.MachineName)

        Dim lastlogtoshow As Integer = evtLog.Entries.Count
        If lastlogtoshow <= 0 Then
            LogList.Text = ("There are no event logs in the log : " & logtype)
            Exit Sub
        End If

        ' Read the last record in the specified log 
        Dim currentEntry As EventLogEntry
        Dim i As Integer
        ' Show Last 2 entries. You can similarly write the log to a file.
        For i = evtLog.Entries.Count - 1 To lastlogtoshow - 2 Step -1
            currentEntry = evtLog.Entries(i)
            LogList.Text = ("Event Id is : " & currentEntry.EventID)
            LogList.Text = ("Entry type is : " & currentEntry.EntryType.ToString())
            LogList.Text = ("Event Message :  " & currentEntry.Message & vbCrLf)
        Next
        evtLog.Close()
    End Sub



    ' Private Sub btnWriteLog_Click(sender As Object, e As EventArgs) Handles btnWriteLog.Click
    'Dim sSource As String
    'Dim sLog As String
    'Dim sEvent As String
    'Dim sMachine As String

    'sSource = "Garam Editor"
    'sLog = "Application"
    'sEvent = "Error Event"
    'sMachine = "."

    ' If Not EventLog.SourceExists(sSource, sMachine) Then
    'EventLog.CreateEventSource(sSource, sLog, sMachine)
    '  End If
    '  Dim ELog As New EventLog(sLog, sMachine, sSource)
    ' ELog.WriteEntry(sEvent)
    ' ELog.WriteEntry(sEvent, EventLogEntryType.Warning, 234, CType(3, Short))
    '  End Sub

    Private Sub btnClearLogs_Click(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        LogList.Clear()

    End Sub

   
    Private Sub frmEventsLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Display the ProgressBar control.
        ToolStripProgressBar1.Visible = True
        ' Set Minimum to 1 to represent the first file being copied.
        ToolStripProgressBar1.Minimum = 1
        ' Set Maximum to the total number of files to copy.
        ToolStripProgressBar1.Maximum = 2



        ' Set the initial value of the ProgressBar.
        ToolStripProgressBar1.Value = 1
        ToolStripProgressBar1.Step = 1

        ToolStripProgressBar1.PerformStep()


    End Sub
End Class