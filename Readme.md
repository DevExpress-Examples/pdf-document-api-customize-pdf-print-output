<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595431/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T334688)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/CustomizePrintSettings/Program.cs) (VB: [Program.vb](./VB/CustomizePrintSettings/Program.vb))
<!-- default file list end -->
# How to customize PDF print output 


This example shows how to customize print output and change settings for a page to be printed. 


<h3>Description</h3>

To specify the output to print, handle the&nbsp;<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_PrintPagetopic">PdfDocumentProcessor.PrintPage </a>event and use the <strong>Graphics</strong> property of the <strong>PdfPrintPageEventArgs</strong>. For example, to draw an image on each page, call the <strong>Graphics.DrawImage</strong> method. <br><br>You can print each page of a document using different page settings. For example, to print the second page in landscape size, set&nbsp; the <strong>PdfQueryPageSettingsEventArgs.PageSettings.Landscape</strong> property to true when the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_QueryPageSettingstopic">PdfDocumentProcessor.QueryPageSettings </a>event is handled.

<br/>


