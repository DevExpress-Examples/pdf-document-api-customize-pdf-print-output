<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595431/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T334688)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:


<!-- default file list end -->
# PDF Document API - Customize PDF Print Output

This example shows how to customize the print output and change settings for a page to be printed. 

To specify the output to print, handle [PdfDocumentProcessor.PrintPage](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.PrintPage) event and use the `PdfPrintPageEventArgs.Graphics` property. For example, to draw an image on each page, call the <strong>Graphics.DrawImage</strong> method. 

You can print each document page using different page settings. For example, to print the second page in landscape size set the `PdfQueryPageSettingsEventArgs.PageSettings.Landscape` property to true when the [PdfDocumentProcessor.QueryPageSettings](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.QueryPageSettings) event is handled.

## Files to Look At

* [Program.cs](./CS/CustomizePrintSettings/Program.cs) (VB: [Program.vb](./VB/CustomizePrintSettings/Program.vb))

  ## Documentation

  * [Printing in PDF Document API](https://docs.devexpress.com/OfficeFileAPI/404300/pdf-document-api/printing?p=netframework)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-customize-pdf-print-output&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-customize-pdf-print-output&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
