using DevExpress.Pdf;
using System.Drawing;

namespace CustomizePrintSettings {
    class Program {
        static void Main(string[] args) {

            // Create a PDF Document Processor instance and load a PDF into it.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(@"..\..\Demo.pdf");

                // Declare the PDF printer settings.
                PdfPrinterSettings settings = new PdfPrinterSettings();

                // Specify the page numbers to be printed.
                settings.PageNumbers = new int[] { 1, 2, 3, 4, 5, 6 };

                // Handle the PrintPage event to specify print output.
                documentProcessor.PrintPage += OnPrintPage;

                // Handle the QueryPageSettings event to customize settings for a page to be printed.
                documentProcessor.QueryPageSettings += OnQueryPageSettings;

                // Print the document using the specified printer settings.
                documentProcessor.Print(settings);

                // Unsubscribe from PrintPage and QueryPageSettings events. 
                documentProcessor.PrintPage -= OnPrintPage;
                documentProcessor.QueryPageSettings -= OnQueryPageSettings;
            }
        }

        private static void OnQueryPageSettings(object sender, PdfQueryPageSettingsEventArgs e) {
            // Print the second page with the landscape orientation.
            if (e.PageNumber == 2) {
                e.PageSettings.Landscape = true;
            }
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
