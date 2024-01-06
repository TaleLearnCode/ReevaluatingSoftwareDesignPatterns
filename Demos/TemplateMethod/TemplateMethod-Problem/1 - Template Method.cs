namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.TemplateMethod.Problem;

// Abstract class defining the template method
public abstract class DocumentProcessor
{
	// Template method defining the document processing algorithm
	public void ProcessDocument()
	{
		Console.WriteLine("1. Open the document");

		// Customizable steps
		PerformTextExtraction();
		PerformImageProcessing();

		Console.WriteLine("4. Save the processed document");
		Console.WriteLine("5. Close the document");
	}

	// Abstract methods to be implemented by subclasses
	protected abstract void PerformTextExtraction();
	protected abstract void PerformImageProcessing();
}