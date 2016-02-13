Imports System
Imports System.Diagnostics
Imports System.Text

''' <summary>The class MitLicense represents the "MIT License" originating from the Massachusetts Institute of Technology.
''' Usually this class is not instantiated but used by the Acknowledgment attribute as type reference.</summary>
<DebuggerDisplay("{DebuggerDisplayValue}")>
<Acknowledgment(Author:="Christoph Hafner", SourceUrl:="https://www.nuget.org/packages/SingleFile.VB.LicenseInfo.MitLicense/1.0.17", License:=GetType(MitLicense), Comment:="Leave this acknowledgment 'as-is' and you are legally licensed.")>
Friend NotInheritable Class MitLicense
    Inherits LicenseInfo

    'Constructors

    ''' <summary>Initializes a new instance of the <see cref="MitLicense" /> class.</summary>
    Public Sub New()
    End Sub

    'Public Properties

    ''' <summary>The name of the license, "MIT License".</summary>
    Public Overrides ReadOnly Property Name As String
        Get
            Return "MIT License"
        End Get
    End Property

    ''' <summary>The exact version of the license, "n/a".</summary>
    Public Overrides ReadOnly Property Version As String
        Get
            Return "n/a"
        End Get
    End Property

    ''' <summary>A link to the license text online, "http://opensource.org/licenses/MIT".</summary>
    Public Overrides ReadOnly Property Link As Uri
        Get
            Return New Uri("http://opensource.org/licenses/MIT")
        End Get
    End Property

    ''' <summary>The full legal license text of the "MIT License".</summary>
    Public Overrides ReadOnly Property Text As String
        Get
            Dim myResult As New StringBuilder()
            myResult.AppendLine("Copyright (c) <year> <copyright holders>")
            myResult.AppendLine("")
            myResult.AppendLine("Permission is hereby granted, free of charge, to any person obtaining a copy")
            myResult.AppendLine("of this software and associated documentation files (the ""Software""), to deal")
            myResult.AppendLine("in the Software without restriction, including without limitation the rights")
            myResult.AppendLine("to use, copy, modify, merge, publish, distribute, sublicense, and/or sell")
            myResult.AppendLine("copies of the Software, and to permit persons to whom the Software is")
            myResult.AppendLine("furnished to do so, subject to the following conditions:")
            myResult.AppendLine("")
            myResult.AppendLine("The above copyright notice and this permission notice shall be included in")
            myResult.AppendLine("all copies or substantial portions of the Software.")
            myResult.AppendLine("")
            myResult.AppendLine("THE SOFTWARE IS PROVIDED ""As Is"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR")
            myResult.AppendLine("IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,")
            myResult.AppendLine("FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE")
            myResult.AppendLine("AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER")
            myResult.AppendLine("LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,")
            myResult.AppendLine("OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN")
            myResult.AppendLine("THE SOFTWARE.")
            Return myResult.ToString()
        End Get
    End Property

    ''' <summary>Returns a <see cref="System.String" /> that represents this instance (the <see cref="Name"/>).</summary>
    ''' <returns>The <see cref="Name"/> of this instance.</returns>
    Public Overrides Function ToString() As String
        Return Name
    End Function

    'Private Properties

    ''' <summary>Gets the debugger display value.</summary>
    <DebuggerBrowsable(DebuggerBrowsableState.Never)>
    Private ReadOnly Property DebuggerDisplayValue As String
        Get
            Return Name
        End Get
    End Property

End Class
