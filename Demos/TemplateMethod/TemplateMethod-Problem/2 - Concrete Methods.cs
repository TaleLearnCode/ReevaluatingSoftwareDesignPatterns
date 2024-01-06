// Ignore Spelling: Pdf

namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.TemplateMethod.Problem;

// Concrete subclass for processing PDF documents
public class PdfDocumentProcessor : DocumentProcessor
{
	// Implementation of text extraction for PDF
	protected override void PerformTextExtraction()
	{
		Console.WriteLine("2. Extract text from PDF document");
	}

	// Implementation of image processing for PDF
	protected override void PerformImageProcessing()
	{
		Console.WriteLine("3. Apply compression to images in PDF");
	}
}

// Concrete subclass for processing Word documents
public class WordDocumentProcessor : DocumentProcessor
{
	// Implementation of text extraction for Word
	protected override void PerformTextExtraction()
	{
		Console.WriteLine("2. Extract text from Word document");
	}

	// Incorrect implementation: Word documents don't have images
	protected override void PerformImageProcessing()
	{
		Console.WriteLine("3. Attempt to process images in Word (not applicable)");
	}
}


/*
 * In this example:
 * 
 * - 'DocumentProcessor' is the abstract class that defines the
 * template method 'ProcessDocument()'.
 * 
 * - The 'ProcessDocument()' method includes common steps for opening,
 * saving, and closing a document. The steps for text extraction and
 * image processing are left as abstract methods to be implemented by
 * subclasses.
 * 
 * - 'PdfDocumentProcessor' and 'WordDocumentProcessor' are concrete
 * subclasses that extend DocumentProcessor and provide their own
 * implementations for text extraction and image processing.
 * 
 * Now, let's analyze the consequences:
 * 
 * 1. Rigidity:
 *      If we need to add a new processing step (e.g., metadata
 *      extraction), we would have to modify the template method in
 *      the superclass, potentially affecting all existing subclasses.
 * 
 * 2. Inappropriate Abstraction:
 *      The 'PerformImageProcessing' method in the
 *      'WordDocumentProcessor' is implemented even though Word
 *      documents typically don't have images. This is an inappropriate
 *      abstraction, violating the expected behavior for Word documents.
 * 
 * 3. Complexity:
 *      As more processing steps are added or overridden in subclasses,
 *      the overall complexity of the system may increase, making it
 *      harder to understand and maintain.
 *      
 * 4. Difficulty in Debugging:
 *      Debugging might become challenging when trying to identify
 *      issues related to overridden or added steps in the template
 *      method.
 * 
 * This example highlights how issues related to rigidity,
 * inappropriate abstraction, and complexity can arise when applying
 * the Template Method pattern without careful consideration. In
 * practice, it's crucial to strike a balance between providing a
 * common structure and allowing for flexibility, and to use
 * alternative patterns if necessary.
 */