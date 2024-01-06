// Ignore Spelling: Pdf

namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.TemplateMethod;

// Concrete subclass for converting PDF documents
public class PdfConverter : DocumentConverter
{
	// Implementation of the abstract method
	protected override void ExtractText()
	{
		Console.WriteLine("3. Extract text from PDF document");
	}
}

// Concrete subclass for converting Word documents
public class WordConverter : DocumentConverter
{
	// Implementation of the abstract method
	protected override void ExtractText()
	{
		Console.WriteLine("3. Extract text from Word document");
	}
}