Console.WriteLine("Processing a PDF Document:");
DocumentProcessor pdfProcessor = new PdfDocumentProcessor();
pdfProcessor.ProcessDocument();

Console.WriteLine("\nProcessing a Word Document:");
DocumentProcessor wordProcessor = new WordDocumentProcessor();
wordProcessor.ProcessDocument();