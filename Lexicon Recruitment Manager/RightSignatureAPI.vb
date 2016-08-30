
Imports System.Collections.Generic
Imports System.Linq
Imports System.Xml
Imports System.Xml.Linq
Imports System.Net
Imports System.IO
Imports System.Text

Namespace RightSignature
    Public Class RightSignatureAPI
        Private baseUrl As String
        Private apiToken As String
        ' response buffer
        Private sb As StringBuilder
        Private buf As Byte()
        Public Shared debug As [Boolean]

        Public Sub New(inputApiToken As String)
            ' initialize response buffer
            sb = New StringBuilder()
            buf = New Byte(8191) {}

            baseUrl = "https://rightsignature.com"
            apiToken = inputApiToken
        End Sub

        '****************************************************************************
        '         * Structs to help filing out documents
        '         ***************************************************************************

        ' A Signer or CC of a Document
        ' name - name of the Person for the role
        ' email - email of the Person for the role
        ' locked - values can be changed
        Public Structure RoleUser
            Public name As String, email As String
            Public locked As [Boolean]
            ' If true, not allow the redirected user to modify the value
            Public Sub New(uName As String, uEmail As String, isLocked As [Boolean])
                name = uName
                email = uEmail
                locked = isLocked
            End Sub
        End Structure

        Public Structure MergeField
            Public name As String, value As String
            Public locked As [Boolean]
            ' If true, not allow the redirected user to modify the value
            Public Sub New(mName As String, mValue As String, isLocked As [Boolean])
                name = mName
                value = mValue
                locked = isLocked
            End Sub
        End Structure

        '*****************************************************************************
        '         * PRIVATE FUNCTIONS
        '         *****************************************************************************




        '*****************************************************************************
        '         * Gets Documents from API and returns response as XDocument
        '         * 
        '	     * query (optional) = Search term to narrow results. Should be URI encoded.
        '	     * 		ex. "State Street"
        '	     * state (optional) - Comma-joined Document states to filter results. States should be 'completed', 'pending', 'expired'.
        '	     * 		ex. "completed,pending"
        '	     * page (optional) - Page number offset. Default is 1.
        '	     * 		ex. 1
        '	     * perPage (optional) - number of result per page to return.
        '	     * 		Valid values are 10, 20, 30, 40, and 50. Default is 10.
        '	     * 		ex. 20
        '	     * recipientEmail (optional) = Narrow results to documents sent by RightSignature API User to the given Recipient Email.
        '	     * 		ex. "a@abc.com"
        '	     * tags (optional) - Dictionary tag names and values that are associated with documents. 
        '	     * 		ex. Dictionary<string, string> tags = new Dictionary;
        '         * 		tags.Add('customized', '')
        '         * 		tags.Add('user id', '123')
        '         *****************************************************************************

        Public Function GetDocuments(query As String, docStates As String, page As System.Nullable(Of Integer), perPage As System.Nullable(Of Integer), recipientEmail As String, tags As Dictionary(Of String, String)) As XDocument
            Dim urlPath As String = "/api/documents.xml"
            Dim requestPath As String
            Dim queryParams As New List(Of String)()

            ' Build up the URL request path parameters
            If query IsNot Nothing Then
                queryParams.Add(Convert.ToString("search=") & query)
            End If
            If docStates IsNot Nothing Then
                queryParams.Add(Convert.ToString("state=") & docStates)
            End If
            If page.HasValue Then
                queryParams.Add("page=" + page.ToString())
            End If
            If perPage.HasValue Then
                queryParams.Add("per_page=" + perPage.ToString())
            End If
            If recipientEmail IsNot Nothing Then
                queryParams.Add("recipient_email=" + recipientEmail.ToString())
            End If

            ' Creates parameter string for tags
            If tags IsNot Nothing Then
                queryParams.Add(CreateTagsParameter(tags))
            End If

            ' Creates URL path with query parameters in it
            requestPath = CreateRequestPath(urlPath, queryParams)

            ' Creates HTTP Request and parses it as XDocument
            Return ParseResponseAsXML(HttpRequest(requestPath, "GET", Nothing))
        End Function

        '*****************************************************************************
        '         * Gets Document details from API and returns response as XDocument
        '         * 
        '         * guid - RightSignature Document GUID
        '         *      ex. 'J1KHD2NX4KJ5S6X7S8'
        '         *****************************************************************************

        Public Function GetDocumentDetails(guid As String) As XDocument
            Return ParseResponseAsXML(HttpRequest((Convert.ToString("/api/documents/") & guid) + ".xml", "GET", Nothing))
        End Function

        '*****************************************************************************
        '         * Gets Documents from API and returns response as string
        '         *****************************************************************************

        Public Function GetDocumentsString() As String
            Return ParseResponseAsString(HttpRequest("/api/documents.xml", "GET", Nothing))
        End Function


        '*****************************************************************************
        '         * Gets Templates from API and returns response as XDocument
        '         * 
        '         * query (optional) = Search term to narrow results. Should be URI encoded.
        '         * 		ex. "State Street"
        '         * page (optional) - Page number offset. Default is 1.
        '         * 		ex. 1
        '         * perPage (optional) - number of result per page to return.
        '         * 		Valid values are 10, 20, 30, 40, and 50. Default is 10.
        '         * 		ex. 20
        '         * tags (optional) - Dictionary tag names and values that are associated with documents. 
        '         * 		ex. Dictionary<string, string> tags = new Dictionary;
        '         * 		tags.Add('test', null)
        '         * 		tags.Add('user id', '123')
        '         *****************************************************************************

        Public Function GetTemplates(query As String, page As System.Nullable(Of Integer), perPage As System.Nullable(Of Integer), tags As Dictionary(Of String, String)) As XDocument
            Dim urlPath As String = "/api/templates.xml"
            Dim requestPath As String
            Dim queryParams As New List(Of String)()

            ' Build up the URL request path parameters
            If query IsNot Nothing Then
                queryParams.Add(Convert.ToString("search=") & query)
            End If
            If page.HasValue Then
                queryParams.Add("page=" + page.ToString())
            End If
            If perPage.HasValue Then
                queryParams.Add("per_page=" + perPage.ToString())
            End If

            ' Creates parameter string for tags
            If tags IsNot Nothing Then
                queryParams.Add(CreateTagsParameter(tags))
            End If

            ' Creates URL path with query parameters in it
            requestPath = CreateRequestPath(urlPath, queryParams)

            ' Creates HTTP Request and parses it as XDocument
            Return ParseResponseAsXML(HttpRequest(requestPath, "GET", Nothing))
        End Function

        '*****************************************************************************
        '         * Gets Template details from API and returns response as XDocument
        '         * 
        '         * guid - RightSignature Template GUID
        '         *      ex. 'A_123_J1KHD2NX4KJ5S6X7S8'
        '         *****************************************************************************

        Public Function GetTemplateDetails(guid As String) As XDocument
            Return ParseResponseAsXML(HttpRequest((Convert.ToString("/api/templates/") & guid) + ".xml", "GET", Nothing))
        End Function

        '*****************************************************************************
        '         * Prepackages 1 or more Templates so it creates a RightSignature Document from the RightSignature Templates.
        '         *  Returns GUID for new Document
        '         * 
        '         * guids - RightSignature Template GUID
        '         *      ex. 'A_123_J1KHD2NX4KJ5S6X7S8'
        '         * callbackURL (optional) - URL to callback when the Document is created. 
        '         *               If none is specified, the default in RightSignature's Account settings will be used
        '         *      ex. "http://mysite/template_callback.php"
        '         *****************************************************************************

        Public Function PrepackageTemplate(guids As String(), callbackURL As String) As String
            Dim guidsString As String = ""
            For Each guid As String In guids
                guidsString += guid
                guidsString += ","
            Next

            ' XML body to POST to RightSignature API
            Dim data As String = "<?xml version='1.0' encoding='UTF-8'?><template>"
            If callbackURL IsNot Nothing Then
                data += (Convert.ToString("<callback_location>") & callbackURL) + "</callback_location>"
            End If
            data += "</template>"

            Dim response As XDocument = ParseResponseAsXML(HttpRequest((Convert.ToString("/api/templates/") & guidsString) + "/prepackage.xml", "POST", data))

            RightSignatureAPI.log("Prepackage Response" & vbLf + response.ToString())

            ' TODO: Need to Check if there's an Error response in XML


            Return response.Element("template").Element("guid").Value
        End Function

        '*****************************************************************************
        '         * Sends Document from API and returns response as XDocument
        '         * 
        '         * guid - RightSignature's Dcoument GUID
        '         * 		ex. "AKJ8CUID2D34TFS"
        '         * roles - Dictionary of RoleUser structs with the Key being the Role Name in the Document:
        '         * 		ex. Dictionary<string, string> roles = new Dictionary;
        '         * 		tags.Add('Client', RoleUser("Tim Tam Timmy", "tim@example.com", true))
        '         * 		tags.Add('CoSigner', RoleUser("Jim Jam Jammy", "jim@example.com", false))
        '         * mergeFields - Array of MergeField structs the name must map to MergeField names in the Document. 
        '         * 		ex. [MergeField('Address', "123 Maple Lane", false)]
        '         * tags (optional) - Dictionary tag names and values to associate with Document. 
        '         * 		ex. Dictionary<string, string> tags = new Dictionary;
        '         * 		tags.Add('test', null)
        '         * 		tags.Add('user id', '123')
        '         * description (Optional) - description of document for signer to see
        '         * callbackURL (Optional) - string of URL for RightSignature to POST document details to after Template gets created, viewed, and completed (all parties have signed). 
        '         *      Tip: add a unique parameter in the URL to distinguish each callback, like the template_id.
        '         *      NULL will use the default callback url set in the RightSignature Account settings page (https://rightsignature.com/oauth_clients).
        '         *      ex. 'http://mysite/document_callback.php?template_id=123'
        '         * expires_in (Optional) - integer of days to expire document, allowed values are 2, 5, 15, or 30.
        '         *****************************************************************************

        Public Function SendDocument(guid As String, subject As String, roles As Dictionary(Of String, RoleUser), mergeFields As MergeField(), tags As Dictionary(Of String, String), description As String, _
            callbackURL As String, expires_in As System.Nullable(Of Integer)) As XDocument
            Dim urlPath As String = "/api/templates.xml"
            Dim requestPath As String
            Dim queryParams As New List(Of String)()
            Dim rootNode As New XElement("template")
            Dim xml As New XDocument(rootNode)

            ' Creates the xml body to send to API
            rootNode.Add(New XElement("guid", guid))
            rootNode.Add(New XElement("subject", subject))
            rootNode.Add(New XElement("action", "send"))
            ' Action can be 'send' or 'prefill' 
            If description IsNot Nothing Then
                rootNode.Add(New XElement("description", description))
            End If
            If expires_in IsNot Nothing Then
                rootNode.Add(New XElement("expires_in", expires_in.ToString()))
            End If
            ' Must be 2, 5, 15, or 30. Otherwise, API will default it to 30 days
            ' Create Roles XML
            Dim rolesNode As New XElement("roles")
            For Each role As KeyValuePair(Of String, RoleUser) In roles
                Dim roleNode As New XElement("role")
                roleNode.SetAttributeValue("role_name", role.Key)
                roleNode.Add(New XElement("name", role.Value.name))
                roleNode.Add(New XElement("email", role.Value.email))
                roleNode.Add(New XElement("locked", role.Value.locked.ToString().ToLower()))
                rolesNode.Add(roleNode)
            Next
            rootNode.Add(rolesNode)

            ' Create mergefields XML
            If mergeFields IsNot Nothing Then
                Dim mfsNode As New XElement("merge_fields")
                For Each mergeField As MergeField In mergeFields
                    Dim mfNode As New XElement("merge_field")
                    mfNode.SetAttributeValue("merge_field_name", mergeField.name)
                    mfNode.Add(New XElement("value", mergeField.value))
                    mfNode.Add(New XElement("locked", mergeField.locked.ToString().ToLower()))
                    mfsNode.Add(mfNode)
                Next
                rootNode.Add(mfsNode)
            End If

            If tags IsNot Nothing Then
                rootNode.Add(CreateTagsXML(tags))
            End If
            If callbackURL IsNot Nothing Then
                rootNode.Add(New XElement("callback_location", callbackURL))
            End If

            RightSignature.RightSignatureAPI.log("Generated xml:" & vbLf & "~~~~~~~~~~~~" & vbLf + xml.ToString() + vbLf & "~~~~~~~~~~~~" & vbLf)

            ' Creates URL path with query parameters in it
            requestPath = CreateRequestPath(urlPath, queryParams)

            ' Creates HTTP Request and parses it as XDocument
            Return ParseResponseAsXML(HttpRequest(requestPath, "POST", xml.ToString()))
        End Function

        '*****************************************************************************
        '         * STATIC FUNCTIONS
        '        *****************************************************************************

        Private Shared Sub log(message As String)
            If debug Then
                Console.WriteLine(message)
            End If
        End Sub



        '*****************************************************************************
        '         * PRIVATE FUNCTIONS
        '         *****************************************************************************


        ' Converts a List and request path into one request path with paramters
        Private Function CreateRequestPath(path As String, parameters As List(Of String)) As String
            For i As Integer = 0 To parameters.Count - 1
                path += If(i = 0, "?", "&")
                path += parameters(i)
            Next
            Return path
        End Function

        ' Converts Dictionary into tags parameter
        Private Function CreateTagsParameter(tags As Dictionary(Of String, String)) As String
            Dim tagsParam As String = "tags="
            Dim i As Integer = 0
            For Each tag As KeyValuePair(Of String, String) In tags
                If i > 0 Then
                    tagsParam += ","c
                End If
                If tag.Value Is Nothing Then
                    tagsParam += tag.Key
                Else
                    tagsParam += tag.Key + ":" + tag.Value
                End If
                i += 1
            Next
            Return tagsParam
        End Function

        ' Converts Dictionary into tags XML Element
        Private Function CreateTagsXML(tags As Dictionary(Of String, String)) As XElement
            Dim tagsNode As New XElement("tags")
            For Each tag As KeyValuePair(Of String, String) In tags
                Dim tagNode As New XElement("tag")
                tagNode.Add(New XElement("name", tag.Key))
                If tag.Value IsNot Nothing Then
                    tagNode.Add(New XElement("value", tag.Value))
                End If
                tagsNode.Add(tagNode)
            Next
            Return tagsNode
        End Function

        Private Function ParseResponseAsXML(response As HttpWebResponse) As XDocument
            Dim xmlReader__1 As XmlReader = XmlReader.Create(response.GetResponseStream())
            Dim xdoc As XDocument = XDocument.Load(xmlReader__1)
            xmlReader__1.Close()
            Return xdoc
        End Function

        Private Function ParseResponseAsString(response As HttpWebResponse) As String
            Dim resStream As Stream
            Dim tempString As String = Nothing
            Dim count As Integer = 0

            RightSignatureAPI.log("Reading stream")
            ' we will read data via the response stream
            resStream = response.GetResponseStream()

            ' fill the buffer with data
            count = resStream.Read(buf, 0, buf.Length)
            RightSignatureAPI.log("got " + count + " bytes of data")

            Do
                ' read buffer
                count = resStream.Read(buf, 0, buf.Length)

                ' make sure we read some data
                If count <> 0 Then
                    ' translate from bytes to ASCII text
                    tempString = Encoding.UTF8.GetString(buf, 0, count)

                    ' continue building the string
                    sb.Append(tempString)
                End If
            Loop While count > 0
            ' any more data to read?
            Return sb.ToString()

        End Function


        '*****************************************************************************
        '         * Sends given path, method, and body to API and returns response.
        '         * path - URL path
        '         *  ex. "/api/documents.xml"
        '         * method - HTTP method
        '         *  ex. "GET"
        '         * body - Request Body as string
        '         *  ex. "<document><guid>ZNMSDFLK1JBFD</guid></document>"
        '         *****************************************************************************

        Private Function HttpRequest(path As String, method As String, body As String) As HttpWebResponse
            ' Creates Request
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl & path), HttpWebRequest)
            Dim response As HttpWebResponse

            ' Adds Secure Token to Header
            request.Headers.Add("api-token", apiToken)
            request.Method = method

            If method.Equals("POST") Then
                request.ContentType = "text/xml;charset=utf-8"
                If body IsNot Nothing Then
                    request.ContentLength = body.Length
                    ' Writes data to request
                    Using writeStream As Stream = request.GetRequestStream()
                        Dim encoding As New UTF8Encoding()
                        Dim bytes As Byte() = encoding.GetBytes(body)
                        writeStream.Write(bytes, 0, bytes.Length)
                    End Using

                End If
            End If


            ' execute the request
            RightSignatureAPI.log("Getting Request")

            response = DirectCast(request.GetResponse(), HttpWebResponse)

            Return response
        End Function
    End Class
End Namespace

