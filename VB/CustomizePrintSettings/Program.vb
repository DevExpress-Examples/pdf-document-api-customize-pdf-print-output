Imports DevExpress.Pdf
Imports System.Drawing

Namespace CustomizePrintSettings

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            ' Create a PDF Document Processor instance and load a PDF into it.
            Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                documentProcessor.LoadDocument("..\..\Demo.pdf")
                ' Declare the PDF printer settings.
                Dim settings As PdfPrinterSettings = New PdfPrinterSettings()
                ' Specify the PDF page numbers.
                settings.PageNumbers = New Integer() {1, 2, 3, 4, 5, 6}
                ' Change the default printing DPI. 
                settings.PrintingDpi = 300
                ' Handle the PrintPage event to receive notifications about printing progress and modify graphics used to paint the page.
                AddHandler documentProcessor.PrintPage, AddressOf OnPrintPage
                ' Handle the QueryPageSettings event to customize print settings.
                AddHandler documentProcessor.QueryPageSettings, AddressOf OnQueryPageSettings
                ' Print the document using the specified printer settings.
                documentProcessor.Print(settings)
                ' Unsubscribe from PrintPage and QueryPageSettings events. 
                RemoveHandler documentProcessor.PrintPage, AddressOf OnPrintPage
                RemoveHandler documentProcessor.QueryPageSettings, AddressOf OnQueryPageSettings
            End Using
        End Sub

        Private Shared Sub OnQueryPageSettings(ByVal sender As Object, ByVal e As PdfQueryPageSettingsEventArgs)
            ' Print the second page in landscape size.
            If e.PageNumber = 2 Then
                e.PageSettings.Landscape = True
            Else
                e.PageSettings.Landscape = False
            End If
        End Sub

        ' Specify what happens when the PrintPage event is raised.
        Private Shared Sub OnPrintPage(ByVal sender As Object, ByVal e As PdfPrintPageEventArgs)
            ' Draw a picture on each printed page.        
            Using image As Bitmap = New Bitmap("..\..\DevExpress.png")
                e.Graphics.DrawImage(image, New RectangleF(10, 30, image.Width \ 2, image.Height \ 2))
            End Using
        End Sub
    End Class
End Namespace
