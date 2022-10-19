namespace Persistence
{
    public class XmlManager
    {
        public static void SaveTXT(string html)
        {
            var htmlContent = html ?? throw new ArgumentNullException(nameof(html));
            var path = Directory.GetCurrentDirectory()  + "/prueba.txt";
            File.WriteAllText(path, htmlContent);
        }
    }
}
