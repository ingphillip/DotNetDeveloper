﻿
// Interface Segregation



// Single Responsibility

public class WordDocument : IDocument, IAuthorizable, IDatable
{
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime Date { get; set; }
}
