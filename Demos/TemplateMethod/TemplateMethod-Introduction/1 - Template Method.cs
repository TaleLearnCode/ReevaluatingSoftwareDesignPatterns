namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.TemplateMethod;

public abstract class DocumentConverter
{

	// Template method defining the document conversion algorithm
	public void ConvertDocument()
	{
		Console.WriteLine("1. Open the document");
		Console.WriteLine("2. Read the document");

		// Customizable step
		ExtractText();

		Console.WriteLine("4. Save the text content");
		Console.WriteLine("5. Close the document");
	}

	// Abstract method to be implemented by subclasses
	protected abstract void ExtractText();

}