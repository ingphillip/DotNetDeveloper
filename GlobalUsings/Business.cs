namespace GlobalUsings
{
    public  class Business
    {
        public void Run()
        {

            ReadPage readPage = new ReadPage();
            string htmlContent = readPage.ReadHtmlPage("http://www.msn.com");

            WriteEvidence writeEvidence = new WriteEvidence();
            writeEvidence.WriteFile(htmlContent);

            XmlManager.SaveTXT(htmlContent);
            Console.Read();


        }
    }
}
