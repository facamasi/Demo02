namespace MyLibrary;
public class Book : Product
{
    public string Title { get; set; }
    public Book(int id, string name, decimal unitPrice, int unitStock, string title) :
        base(id, name, unitPrice, unitStock)
    {
        Title = title;
    }
}

public class Book2(int id, string name, decimal unitPrice, int unitStock, string title) :
        Product(id, name, unitPrice, unitStock)
{
    public string Title => title;
}

