Public Class HtmlGenerator

    Shared Function GetTableHtml(rows As List(Of String)) As String
        Dim html As XElement = <table>
                                   <%= From r In rows Select <Row><%= r %></Row> %>
                               </table>
        Return html.ToString()
    End Function

End Class
