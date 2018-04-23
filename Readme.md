# How to customize PDF print output 


This example shows how to customize print output and change settings for a page to be printed. 


<h3>Description</h3>

To specify the output to print, handle the&nbsp;<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_PrintPagetopic">PdfDocumentProcessor.PrintPage </a>event and use the <strong>Graphics</strong> property of the <strong>PdfPrintPageEventArgs</strong>. For example, to draw an image on each page, call the <strong>Graphics.DrawImage</strong> method. <br><br>You can print each page of a document using different page settings. For example, to print the second page in landscape size, set&nbsp; the <strong>PdfQueryPageSettingsEventArgs.PageSettings.Landscape</strong> property to true when the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_QueryPageSettingstopic">PdfDocumentProcessor.QueryPageSettings </a>event is handled.

<br/>


