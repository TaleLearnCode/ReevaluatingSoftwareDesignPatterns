Console.WriteLine("Converting a PDF Document:");
DocumentConverter pdfConverter = new PdfConverter();
pdfConverter.ConvertDocument();

Console.WriteLine();

Console.WriteLine("Converting a Word Document:");
DocumentConverter wordConverter = new WordConverter();
wordConverter.ConvertDocument();

/*
 * In this example:
 * 
 * - 'DocumentConverter' is the abstract class that defines the
 * template method ConvertDocument().
 * 
 * - The 'ConvertDocument()' method includes common steps for opening,
 * reading, saving, and closing a document. The 'ExtractText()' step
 * is left as an abstract method to be implemented by subclasses.
 * 
 * - 'PdfConverter' and 'WordConverter' are concrete subclasses that
 * extend DocumentConverter and provide their own implementation for
 * the ExtractText() step.
 * 
 * When the client code runs, it creates instances of 'PdfConverter'
 * and 'WordConverter' and calls the ConvertDocument() method on each.
 * The template method orchestrates the overall document conversion
 * process, and the concrete subclasses customize the text extraction
 * step based on the document type.
 * 
 * This example demonstrates how the Template Method pattern can be
 * applied in a document conversion scenario, providing a common
 * structure for the conversion process while allowing flexibility
 * for specific implementations in subclasses.
 */