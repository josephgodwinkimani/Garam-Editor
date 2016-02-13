
Class HTMLHelpClass

    Private Shared _getLocalHelpFileName As String

    Shared Property GetLocalHelpFileName(p1 As String) As String
        Get
            Return _getLocalHelpFileName
        End Get
        Set(value As String)
            _getLocalHelpFileName = value
        End Set
    End Property

    Shared Property HelpNamespace As String

End Class
