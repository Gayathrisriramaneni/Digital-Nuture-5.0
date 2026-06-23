namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory = new DocumentFactory();

            IDocument word = factory.CreateDocument("Word");
            word.Open();

            IDocument pdf = factory.CreateDocument("PDF");
            pdf.Open();

            IDocument excel = factory.CreateDocument("Excel");
            excel.Open();
        }
    }
}