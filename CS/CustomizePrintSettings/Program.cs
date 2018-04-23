using DevExpress.Pdf;
using System;
using System.Drawing;

namespace CustomizePrintSettings {
    class Program {
        static void Main(string[] args) {

            // Create a PDF Document Processor instance and load a PDF into it.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(@"..\..\Demo.pdf");

                // Declare the PDF printer settings.
                PdfPrinterSettings settings = new PdfPrinterSettings();

                // Specify the PDF page numbers.
                settings.PageNumbers = new int[] { 1, 2, 3, 4, 5, 6 };

                // Change the default printing DPI. 
                settings.PrintingDpi = 300;

                // Handle the PrintPage event to receive notifications about printing progress and modify graphics used to paint the page.
                documentProcessor.PrintPage += OnPrintPage;

                // Handle the QueryPageSettings event to customize print settings.
                documentProcessor.QueryPageSettings += OnQueryPageSettings;

                // Print the document using the specified printer settings.
                documentProcessor.Print(settings);

                // Unsubscribe from PrintPage and QueryPageSettings events. 
                documentProcessor.PrintPage -= OnPrintPage;
                documentProcessor.QueryPageSettings -= OnQueryPageSettings;
            }
        }

        private static void OnQueryPageSettings(object sender, PdfQueryPageSettingsEventArgs e) {
            // Print the second page in landscape size.
            if (e.PageNumber == 2)
                e.PageSettings.Landscape = true;
            else e.PageSettings.Landscape = false;
        }

        // Specify what happens when the PrintPage event is raised.
        private static void OnPrintPage(object sender, PdfPrintPageEventArgs e) {

            // Draw a picture on each printed page.        
            using (Bitmap image = new Bitmap(@"..\..\DevExpress.png"))
                e.Graphics.DrawImage(image, new RectangleF(10, 30, image.Width / 2, image.Height / 2));
        }
    }
}
