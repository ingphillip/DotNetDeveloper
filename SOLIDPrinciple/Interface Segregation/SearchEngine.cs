
// Open-Closed
public class SearchEngine : ISearchable
{
    private List<IDocument> documents = new List<IDocument>();

    public void AddDocument(IDocument document)
    {
        this.documents.Add(document);
    }

    public void SearchByAuthor(string author)
    {
        foreach (var document in documents)
        {
            if (document is IAuthorizable authDocument && authDocument.Author == author)
            {
                Console.WriteLine($"{document.GetType().Name}: Documento encontrado por autor '{author}': {document.Content}");
            }
        }
    }

    public void SearchByDate(DateTime date)
    {
        foreach (var document in documents)
        {
            if (document is IDatable dateDocument && dateDocument.Date == date)
            {
                Console.WriteLine($"{document.GetType().Name}: Documento encontrado por fecha '{date}': {document.Content}");
            }
        }
    }

    public void SearchByKeyword(string keyword)
    {
        foreach (var document in documents)
        {
            if (document.Content.Contains(keyword))
            {
                Console.WriteLine($"{document.GetType().Name}: Documento encontrado por palabra clave '{keyword}': {document.Content}");
            }
        }
    }
}
