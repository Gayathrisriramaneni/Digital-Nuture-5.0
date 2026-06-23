namespace FactoryMethodPatternExample
{
    public class DocumentFactory
    {
        public IDocument CreateDocument(string type)
        {
            if (type == "Word")
                return new WordDocument();

            if (type == "PDF")
                return new PdfDocument();

            if (type == "Excel")
                return new ExcelDocument();

            return null;
        }
    }
}