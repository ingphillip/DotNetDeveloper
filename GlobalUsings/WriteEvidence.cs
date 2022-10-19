namespace GlobalUsings.Write
{
    public class WriteEvidence
    {
        public void WriteFile(string texto)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "/mihtml.html", texto);
        }
    }
}
