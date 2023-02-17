public class DocumentManager
{
    private IDocumentFactory documentFactory;

    public DocumentManager(IDocumentFactory documentFactory)
    {
        this.documentFactory = documentFactory;
    }

    public IDocument CreateDocument()
    {
        return documentFactory.CreateDocument();
    }
}