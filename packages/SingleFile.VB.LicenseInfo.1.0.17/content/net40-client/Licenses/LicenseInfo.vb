Imports System

''' <summary>Abstract base class for license informations.</summary>
Friend MustInherit Class LicenseInfo

    ''' <summary>Initializes a new instance of the <see cref="LicenseInfo"/> class.</summary>
    Protected Sub New()
    End Sub

    ''' <summary>The name of the license, eg. "GNU Lesser General Public License (LGPL)", "GNU General Public License (GPL)", "Code Project Open License (CPOL)", "GNU Affero General Public License (AGPL)" etc.</summary>
    Public MustOverride ReadOnly Property Name As String
    ''' <summary>The exact version of the license, eg. "3.0" for an LGPL" or "1.02" of a CPOL etc.</summary>
    Public MustOverride ReadOnly Property Version As String
    ''' <summary>A link to the license text online.</summary>
    Public MustOverride ReadOnly Property Link As Uri
    ''' <summary>The full legal license text.</summary>
    Public MustOverride ReadOnly Property Text As String

End Class
