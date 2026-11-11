public class Book
{
    private string _title = "";
    private string _author = "";
    private int _pageCount = 0;

    public Book()
    {
        _title = "Not provided";
        _author = "Not provided";
        _pageCount = 0;
        if (_pageCount == 0)
        {
            Console.Write("Not provided");
        }
    }

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        _pageCount = 0;
        if (_pageCount == 0)
        {
            Console.Write("Not provided");
        }

    }

    public Book(string title, string author, int page)
    {
        _title = title;
        _author = author;
        _pageCount = page;
    }



}