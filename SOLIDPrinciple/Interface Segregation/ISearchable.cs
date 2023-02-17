public interface ISearchable
{
    void SearchByAuthor(string author);
    void SearchByDate(DateTime date);
    void SearchByKeyword(string keyword);
}
