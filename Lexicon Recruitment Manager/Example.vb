
Imports System.Xml
Imports System.Xml.Linq
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Collections.Generic


Namespace RightSignature
    Public Class Example
        Private Const apiToken As String = "YOUR TOKEN"
        ' API Secure Token
        Private Shared Sub Main(args As String())
            RightSignatureAPI.debug = True

            ' Gets Documents from RightSignature
            getDocuments()

            ' Gets Template Details
            'response = rightsignature.GetTemplateDetails("a_123_ed90909d0cc44d939ed6c9db79227421");

            ' Use a Templates to send a document, can merge multiple Templates into one Document
            Dim templateGUIDs As String() = New String(0) {"a_123_ed90909d0cc44d939ed6c9db79227421"}
            prepackage_and_send_template(templateGUIDs)


            ' wait for any key press before exiting
            Console.WriteLine(vbLf & "Press Any Key to exit...")
            Console.ReadKey()
        End Sub

        '*******************************************************************
        '         * Sample calls to the api to get Documents from RightSignature
        '         * 1. Prepackge Template(s) to get a Document GUID
        '         * 2. Send/Prefill Document using GUID
        '         *******************************************************************

        Public Shared Sub getDocuments()
            Dim rightsignature As New RightSignatureAPI(apiToken)
            'Dim response As XDocument

            ' Tags to search for
            Dim searchTags As New Dictionary(Of String, String)()
            ' A tag with value
            searchTags.Add("document", "54")
            ' A general tag (no value)
            searchTags.Add("test", Nothing)

            ' Calls API using our HTTPWebRequest wrapper to get a list of RightSignature Documents
            ' Using test as the search query and default options
            'response = rightsignature.GetDocuments("test", null, null, null, null, null);

            ' Get documents with specified tags and default options
            'response = rightsignature.GetDocuments(null, null, null, null, null, searchTags);
            ' Get 2nd page of documents with default options and tags
            'response = rightsignature.GetDocuments(null, null, 2, null, null, searchTags);
            ' Get documents from "alex@example.com"
            'response = rightsignature.GetDocuments(null, null, null, null, "alex@example.com", null);

            ' Test getting document details from a guid
            'response = rightsignature.GetDocumentDetails("NYWGKXIYDJPHK6DLW5WXCZ");

            ' Calls API using our HTTPWebRequest wrapper to get a list of RightSignature Templates
            'response = rightsignature.GetTemplates(null, null, null, null);

        End Sub

        '*******************************************************************
        '         * Workflow for using Templates to send a Document:
        '         * 1. Prepackge Template(s) to get a Document GUID
        '         * 2. Send/Prefill Document using GUID
        '         *******************************************************************

        Public Shared Sub prepackage_and_send_template(templateGUIDs As String())
            Dim rightsignature As New RightSignatureAPI(apiToken)
            Dim response As XDocument

            ' Prepackge a Template to prepare it for sending, sets a Callback URL so we can get listen for callbacks 
            '  when the Documenet gets created, viewed, and completed (all signers signed)
            Dim guid As String = rightsignature.PrepackageTemplate(templateGUIDs, "http://127.0.0.1:8888")
            Console.WriteLine(Convert.ToString("got GUID:") & guid)

            'Creating array for the mergeFields
            Dim mergeFields As RightSignatureAPI.MergeField() = New RightSignatureAPI.MergeField(1) {New RightSignatureAPI.MergeField("Notes", "custom Notes here", True), New RightSignatureAPI.MergeField("Notes 2", "Notes sections 2", True)}

            ' Filling in the info for Document Roles
            Dim roles As New Dictionary(Of String, RightSignatureAPI.RoleUser)()
            roles.Add("Document Sender", New RightSignatureAPI.RoleUser("Johnny John", "jj@example.com", True))
            roles.Add("Designer", New RightSignatureAPI.RoleUser("James Able", "ja@example.com", True))
            roles.Add("Project Manager", New RightSignatureAPI.RoleUser("Jim Brown", "jb@example.com", True))

            ' Create tags to associate with Document
            Dim tags As New Dictionary(Of String, String)()
            tags.Add("test", Nothing)
            tags.Add("user", "123")

            ' Send document with fields filled out
            ' (guid, subject, roles, mergeFields, tags, description, callbackURL, expires_in)
            response = rightsignature.SendDocument(guid, "Subject", roles, mergeFields, tags, "Please fill out the information form and submit it with your signature.", _
                "http://127.0.0.1:3000", 2)

            Console.WriteLine("Response received is:" & vbLf + response.ToString())
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
