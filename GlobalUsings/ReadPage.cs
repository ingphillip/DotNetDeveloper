namespace GlobalUsings.Read
{
    public class ReadPage
    {
        HttpClient _client;
        public ReadPage ()
        {
            _client = new HttpClient ();
        }


        public string ReadHtmlPage(string url)
        {
            var result = _client.GetAsync(url).Result;
            var html = result.Content.ReadAsStringAsync().Result;
            Console.WriteLine (html);
            return html;
        }
    }
}
