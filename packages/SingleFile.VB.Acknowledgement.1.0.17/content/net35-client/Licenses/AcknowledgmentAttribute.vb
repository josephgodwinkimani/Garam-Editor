Imports System

''' <summary>The class AcknowledgmentAttribute is an attribute that may be applied anywhere in code to give 
''' credit to the contributor of that code and to specify what license applies for that piece of code.</summary>
<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.Class Or AttributeTargets.Enum Or AttributeTargets.Interface Or AttributeTargets.Struct Or AttributeTargets.Module Or AttributeTargets.Method Or AttributeTargets.Field Or AttributeTargets.Property Or AttributeTargets.Event, AllowMultiple:=True, Inherited:=False)>
Friend Class AcknowledgmentAttribute
    Inherits Attribute

    'Constructors

    ''' <summary>Empty constructor that allows to specify the information through "Property:=Value" syntax.</summary>
    Public Sub New()
    End Sub

    ''' <summary>Defines a copyright, the source where the code comes from, the license that applies, as well as textual acknowledgments and comments.</summary>
    ''' <param name="author">Owner of the code, usually the person or company that wrote it.</param>
    ''' <param name="sourceUrl">Where was this code downloaded from?</param>
    ''' <param name="license">The type that holds the license information, that should be a subclass of <see cref="LicenseInfo" />.</param>
    ''' <param name="acknowledgment">A "thank you" statement to the writer of the code.</param>
    ''' <param name="comment">Some additional comments that should be included in the assembly.</param>
    ''' <remarks></remarks>
    Public Sub New(author As String, sourceUrl As String, license As Type, acknowledgment As String, comment As String)
        Me.Author = author
        Me.SourceUrl = sourceUrl
        Me.License = license
        Me.Acknowledgment = acknowledgment
        Me.Comment = comment
    End Sub

    'Public Properties

    ''' <summary>Owner of the code, usually the person or company that wrote it.</summary>
    Public Property Author As String
    ''' <summary>The place where this code was downloaded from.</summary>
    Public Property SourceUrl As String
    ''' <summary>The type of the class (usually containing a singleton-property) fully describing the license. The type should be a subclass of <see cref="LicenseInfo" />.</summary>
    Public Property License As Type
    ''' <summary>Some "Thank you" words addressed to the writer of the code.</summary>
    Public Property Acknowledgment As String
    ''' <summary>"Additional comments that should be included in the assembly.</summary>
    Public Property Comment As String

End Class
